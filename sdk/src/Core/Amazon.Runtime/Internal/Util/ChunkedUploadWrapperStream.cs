﻿/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Globalization;
using System.IO;
using System.Text;
using Amazon.Util;
using Amazon.Runtime.Internal.Auth;
#if AWS_ASYNC_API
using System.Threading;
using System.Threading.Tasks;
#endif

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Stream wrapper that double-buffers from a wrapped stream and
    /// returns the buffered content as a series of signed 'chunks'
    /// for the AWS4 ('Signature V4') protocol or the asymmetric Sigv4 (Sigv4a) protocol.
    /// </summary>
    public class ChunkedUploadWrapperStream : WrapperStream
    {
        public static readonly int DefaultChunkSize = 81920;

        private const string CLRF = "\r\n";
        private const string CHUNK_STRING_TO_SIGN_PREFIX = "AWS4-HMAC-SHA256-PAYLOAD";
        private const string CHUNK_SIGNATURE_HEADER = ";chunk-signature=";
        public const int V4_SIGNATURE_LENGTH = 64;
        public const int V4A_SIGNATURE_LENGTH = 144;

        private byte[] _inputBuffer;
        
        private readonly byte[] _outputBuffer;
        private int _outputBufferPos = -1;
        private int _outputBufferDataLen = -1;

        private readonly int _wrappedStreamBufferSize;
        private bool _wrappedStreamConsumed;

        // if this is set, we've exhausted the input stream and are now sending
        // back to the client the final termination chunk, after which all Read
        // operations will return 0 bytes.
        private bool _outputBufferIsTerminatingChunk;

        // The reading strategy used by FillInputBuffer against the wrapped stream.
        // We prefer to read direct into our _inputBuffer but this isn't compatible
        // with wrapped encryption streams, where we need to read into an interim
        // buffer and then copy the encrypted content to _inputBuffer
        private enum ReadStrategy
        {
            ReadDirect,
            ReadAndCopy
        }

        private readonly ReadStrategy _readStrategy = ReadStrategy.ReadDirect;

        /// <summary>
        /// Initializes a chunked upload stream
        /// </summary>
        /// <param name="stream">stream to wrap</param>
        /// <param name="wrappedStreamBufferSize">Size of buffer used for reading from stream</param>
        /// <param name="headerSigningResult">SigV4 or SigV4a signing result for the request's headers</param>
        internal ChunkedUploadWrapperStream(Stream stream, int wrappedStreamBufferSize, AWSSigningResultBase headerSigningResult) : base(stream)
        {
            if (!(headerSigningResult is AWS4aSigningResult || headerSigningResult is AWS4SigningResult ))
            {
                throw new AmazonClientException($"{nameof(ChunkedUploadWrapperStream)} was initialized without a SigV4 or SigV4a signing result.");
            }
            else if (headerSigningResult is AWS4aSigningResult)
            {
                Sigv4aSigner = new AWS4aSignerCRTWrapper();
            }

            HeaderSigningResult = headerSigningResult;
            PreviousChunkSignature = headerSigningResult?.Signature;

            _wrappedStreamBufferSize = wrappedStreamBufferSize;
            _inputBuffer = new byte[DefaultChunkSize];
            _outputBuffer = new byte[CalculateChunkHeaderLength(DefaultChunkSize, HeaderSigningResult is AWS4aSigningResult ? V4A_SIGNATURE_LENGTH : V4_SIGNATURE_LENGTH)]; // header+data

            // if the wrapped stream implements encryption, switch to a read-and-copy
            // strategy for filling the chunk buffer
            var encryptionStream = SearchWrappedStream(s =>
            {
                var encryptUploadPartStream = s as EncryptUploadPartStream;
                if (encryptUploadPartStream != null)
                    return true;

                var encryptStream = s as EncryptStream;
                return encryptStream != null;
            });

            if (encryptionStream != null)
                _readStrategy = ReadStrategy.ReadAndCopy;
        }

        /// <summary>
        /// Reads some or all of the processed chunk to the consumer, constructing
        /// and streaming a new chunk if more input data is available.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            int bytesRead = 0;

            // if we've no output and it was the special termination chunk,
            // we're done otherwise fill the input buffer with enough data
            // for the next chunk (or with whatever is left) and construct
            // the chunk in the output buffer ready for streaming
            if (_outputBufferPos == -1)
            {
                if (_wrappedStreamConsumed && _outputBufferIsTerminatingChunk)
                    return 0;

                bytesRead = FillInputBuffer();
            }

            return AdjustBufferAfterReading(buffer, offset, count, bytesRead);
        }

        private int AdjustBufferAfterReading(byte[] buffer, int offset, int count, int bytesRead)
        {
            if (_outputBufferPos == -1)
            {
                ConstructOutputBufferChunk(bytesRead);
                _outputBufferIsTerminatingChunk = (_wrappedStreamConsumed && bytesRead == 0);
            }

            var outputRemaining = _outputBufferDataLen - _outputBufferPos;
            if (outputRemaining < count)
                count = outputRemaining;

            Buffer.BlockCopy(_outputBuffer, _outputBufferPos, buffer, offset, count);
            _outputBufferPos += count;
            if (_outputBufferPos >= _outputBufferDataLen)
                _outputBufferPos = -1;

            return count;
        }

#if AWS_ASYNC_API
        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            int bytesRead = 0;

            // if we've no output and it was the special termination chunk,
            // we're done otherwise fill the input buffer with enough data
            // for the next chunk (or with whatever is left) and construct
            // the chunk in the output buffer ready for streaming
            if (_outputBufferPos == -1)
            {
                if (_wrappedStreamConsumed && _outputBufferIsTerminatingChunk)
                    return 0;

                bytesRead = await FillInputBufferAsync(cancellationToken).ConfigureAwait(false);
            }

            return AdjustBufferAfterReading(buffer, offset, count, bytesRead);
        }

        /// <summary>
        /// Attempt to read sufficient data for a whole chunk from the wrapped stream,
        /// returning the number of bytes successfully read to be processed into a chunk
        /// </summary>
        private async Task<int> FillInputBufferAsync(CancellationToken cancellationToken)
        {
            if (_wrappedStreamConsumed)
                return 0;

            var inputBufferPos = 0;

            if (_readStrategy == ReadStrategy.ReadDirect)
            {
                while (inputBufferPos < _inputBuffer.Length && !_wrappedStreamConsumed)
                {
                    // chunk buffer size may not align exactly with underlying buffer size
                    var chunkBufferRemaining = _inputBuffer.Length - inputBufferPos;
                    if (chunkBufferRemaining > _wrappedStreamBufferSize)
                        chunkBufferRemaining = _wrappedStreamBufferSize;

                    var bytesRead = await BaseStream.ReadAsync(_inputBuffer, inputBufferPos, chunkBufferRemaining, cancellationToken).ConfigureAwait(false);
                    if (bytesRead == 0)
                        _wrappedStreamConsumed = true;
                    else
                        inputBufferPos += bytesRead;
                }
            }
            else
            {
                var readBuffer = new byte[_wrappedStreamBufferSize];
                while (inputBufferPos < _inputBuffer.Length && !_wrappedStreamConsumed)
                {
                    var bytesRead = await BaseStream.ReadAsync(readBuffer, 0, _wrappedStreamBufferSize, cancellationToken).ConfigureAwait(false);
                    if (bytesRead == 0)
                        _wrappedStreamConsumed = true;
                    else
                    {
                        Buffer.BlockCopy(readBuffer, 0, _inputBuffer, inputBufferPos, bytesRead);
                        inputBufferPos += bytesRead;
                    }
                }
            }

            return inputBufferPos;
        }
#endif

        /// <summary>
        /// Results of the header-signing portion of the request when using SigV4 signing
        /// </summary>
        private AWSSigningResultBase HeaderSigningResult { get; set; }

        /// <summary>
        /// SigV4a signer
        /// </summary>
        private AWS4aSignerCRTWrapper Sigv4aSigner { get; set; }

        /// <summary>
        /// Computed signature of the chunk prior to the one in-flight in hex,
        /// for either SigV4 or SigV4a
        /// </summary>
        private string PreviousChunkSignature { get; set; }

        /// <summary>
        /// Computes the derived signature for a chunk of data of given length in the input buffer, 
        /// placing a formatted chunk with headers, signature and data into the output buffer
        /// ready for streaming back to the consumer.
        /// </summary>
        /// <param name="dataLen"></param>
        private void ConstructOutputBufferChunk(int dataLen)
        {
            // if the input wasn't sufficient to fill the buffer, size it
            // down to make the subseqent hashing/computations easier since
            // they don't take any length arguments
            if (dataLen > 0 && dataLen < _inputBuffer.Length)
            {
                var temp = new byte[dataLen];
                Buffer.BlockCopy(_inputBuffer, 0, temp, 0, dataLen);
                _inputBuffer = temp;
            }

            var chunkHeader = new StringBuilder();

            // variable-length size of the embedded chunk data in hex
            chunkHeader.Append(dataLen.ToString("X", CultureInfo.InvariantCulture));

            string chunkSignature = "";
            if (HeaderSigningResult is AWS4aSigningResult v4aHeaderSigningResult)
            {
                if (dataLen == 0)   // _inputBuffer still contains previous chunk, but this is the final 0 content chunk so sign null
                {
                    chunkSignature = Sigv4aSigner.SignChunk(null, PreviousChunkSignature, v4aHeaderSigningResult);
                }
                else
                {
                    chunkSignature = Sigv4aSigner.SignChunk(new MemoryStream(_inputBuffer), PreviousChunkSignature, v4aHeaderSigningResult);
                }
            }
            else if (HeaderSigningResult is AWS4SigningResult v4HeaderSingingResult) // SigV4
            {
                var chunkStringToSign = BuildChunkedStringToSign(CHUNK_STRING_TO_SIGN_PREFIX, v4HeaderSingingResult.ISO8601DateTime,
                                                                    v4HeaderSingingResult.Scope,  PreviousChunkSignature, dataLen, _inputBuffer);

                chunkSignature = AWSSDKUtils.ToHex(AWS4Signer.SignBlob(v4HeaderSingingResult.GetSigningKey(), chunkStringToSign), true);
            }

            // For Sigv4a the chunk signature must be padded when being appended to the chunk metadata,
            // but not when being used as the input for the next chunk
            PreviousChunkSignature = chunkSignature;
            if (HeaderSigningResult is AWS4aSigningResult)
            {
                chunkHeader.Append(CHUNK_SIGNATURE_HEADER + chunkSignature.PadRight(V4A_SIGNATURE_LENGTH, '*'));
            }
            else // SigV4
            {
                chunkHeader.Append(CHUNK_SIGNATURE_HEADER + chunkSignature);
            }
            chunkHeader.Append(CLRF);

            try
            {
                var header = Encoding.UTF8.GetBytes(chunkHeader.ToString());
                var trailer = Encoding.UTF8.GetBytes(CLRF);

                var writePos = 0;
                Buffer.BlockCopy(header, 0, _outputBuffer, writePos, header.Length);
                writePos += header.Length;
                if (dataLen > 0)
                {
                    Buffer.BlockCopy(_inputBuffer, 0, _outputBuffer, writePos, dataLen);
                    writePos += dataLen;
                }
                Buffer.BlockCopy(trailer, 0, _outputBuffer, writePos, trailer.Length);

                _outputBufferPos = 0;
                _outputBufferDataLen = header.Length + dataLen + trailer.Length;
            }
            catch (Exception e)
            {
                throw new AmazonClientException("Unable to sign the chunked data. " + e.Message, e);
            }
        }

        /// <summary>
        /// Length override to return the true length of the payload plus the metainfo
        /// supplied with each chunk
        /// </summary>
        public override long Length
        {
            get
            {
                if (BaseStream == null)
                {
                    return 0;
                }
                return ComputeChunkedContentLength(BaseStream.Length, HeaderSigningResult is AWS4aSigningResult ? V4A_SIGNATURE_LENGTH : V4_SIGNATURE_LENGTH);
            }
        }

        public override bool CanSeek
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Computes the total size of the data payload, including the chunk metadata.
        /// Called externally so as to be able to set the correct Content-Length header
        /// value.
        /// </summary>
        /// <param name="originalLength"></param>
        /// <param name="signatureLength">Length of the signature for each chunk, in bytes</param>
        /// <returns></returns>
        public static long ComputeChunkedContentLength(long originalLength, int signatureLength)
        {
            if (originalLength < 0)
                throw new ArgumentOutOfRangeException("originalLength", "Expected 0 or greater value for originalLength.");

            if (originalLength == 0)
                return CalculateChunkHeaderLength(0, signatureLength);

            var maxSizeChunks = originalLength / DefaultChunkSize;
            var remainingBytes = originalLength % DefaultChunkSize;
            return maxSizeChunks * CalculateChunkHeaderLength(DefaultChunkSize, signatureLength)
                   + (remainingBytes > 0 ? CalculateChunkHeaderLength(remainingBytes, signatureLength) : 0)
                   + CalculateChunkHeaderLength(0, signatureLength);
        }

        /// <summary>
        /// Builds the string to sign for a single V4/V4a chunk
        /// </summary>
        /// <param name="prefix">Algorithm being used</param>
        /// <param name="dateTime">ISO8601DateTime that we're signing the request for</param>
        /// <param name="scope">Signing scope (date/region/service/aws4_request)</param>
        /// <param name="previousSignature">Previous chunk's unpadded signature</param>
        /// <param name="dataLength">Length of the content for this chunk</param>
        /// <param name="inputBuffer">Content of this chunk</param>
        /// <returns>The string to sign for this chunk</returns>
        public static string BuildChunkedStringToSign(string prefix, string dateTime, string scope, string previousSignature, int dataLength, byte[] inputBuffer)
        {
            return prefix + "\n" +
                   dateTime + "\n" +
                   scope + "\n" +
                   previousSignature + "\n" +
                   AWSSDKUtils.ToHex(AWS4Signer.ComputeHash(""), true) + "\n" +
                   (dataLength > 0
                       ? AWSSDKUtils.ToHex(AWS4Signer.ComputeHash(inputBuffer), true)
                       : AWS4Signer.EmptyBodySha256);
        }

        /// <summary>
        /// Computes the size of the header data for each chunk.
        /// </summary>
        /// <param name="chunkDataSize">Payload size of each chunk, in bytes</param>
        /// <param name="signatureLength">Length of the signature for each chunk, in bytes</param>
        /// <returns></returns>
        private static long CalculateChunkHeaderLength(long chunkDataSize, int signatureLength)
        {
            return chunkDataSize.ToString("X", CultureInfo.InvariantCulture).Length
                   + CHUNK_SIGNATURE_HEADER.Length
                   + signatureLength
                   + CLRF.Length
                   + chunkDataSize
                   + CLRF.Length;
        }

        /// <summary>
        /// Attempt to read sufficient data for a whole chunk from the wrapped stream,
        /// returning the number of bytes successfully read to be processed into a chunk
        /// </summary>
        private int FillInputBuffer()
        {
            if (_wrappedStreamConsumed)
                return 0;

            var inputBufferPos = 0;

            if (_readStrategy == ReadStrategy.ReadDirect)
            {
                while (inputBufferPos < _inputBuffer.Length && !_wrappedStreamConsumed)
                {
                    // chunk buffer size may not align exactly with underlying buffer size
                    var chunkBufferRemaining = _inputBuffer.Length - inputBufferPos;
                    if (chunkBufferRemaining > _wrappedStreamBufferSize)
                        chunkBufferRemaining = _wrappedStreamBufferSize;

                    var bytesRead = BaseStream.Read(_inputBuffer, inputBufferPos, chunkBufferRemaining);
                    if (bytesRead == 0)
                        _wrappedStreamConsumed = true;
                    else
                        inputBufferPos += bytesRead;
                }
            }
            else
            {
                var readBuffer = new byte[_wrappedStreamBufferSize];
                while (inputBufferPos < _inputBuffer.Length && !_wrappedStreamConsumed)
                {
                    var bytesRead = BaseStream.Read(readBuffer, 0, _wrappedStreamBufferSize);
                    if (bytesRead == 0)
                        _wrappedStreamConsumed = true;
                    else
                    {
                        Buffer.BlockCopy(readBuffer, 0, _inputBuffer, inputBufferPos, bytesRead);
                        inputBufferPos += bytesRead;
                    }
                }
            }

            return inputBufferPos;
        }

        internal override bool HasLength
        {
            get
            {
                return HeaderSigningResult != null;
            }
        }
    }
}
