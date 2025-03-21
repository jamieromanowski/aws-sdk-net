/*
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

/*
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService.Model.Internal.MarshallTransformations;
using Amazon.KeyManagementService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Implementation for accessing KeyManagementService
    ///
    /// Key Management Service 
    /// <para>
    /// Key Management Service (KMS) is an encryption and key management web service. This
    /// guide describes the KMS operations that you can call programmatically. For general
    /// information about KMS, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/">
    /// <i>Key Management Service Developer Guide</i> </a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// KMS is replacing the term <i>customer master key (CMK)</i> with <i>KMS key</i> and
    /// <i>KMS key</i>. The concept has not changed. To prevent breaking changes, KMS is keeping
    /// some variations of this term.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services provides SDKs that consist of libraries and sample code for various
    /// programming languages and platforms (Java, Ruby, .Net, macOS, Android, etc.). The
    /// SDKs provide a convenient way to create programmatic access to KMS and other Amazon
    /// Web Services services. For example, the SDKs take care of tasks such as signing requests
    /// (see below), managing errors, and retrying requests automatically. For more information
    /// about the Amazon Web Services SDKs, including how to download and install them, see
    /// <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the Amazon Web Services SDKs to make programmatic API calls
    /// to KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your Amazon Web Services account (root) access
    /// key ID and secret key for everyday work with KMS. Instead, use the access key ID and
    /// secret access key for an IAM user. You can also use the Amazon Web Services Security
    /// Token Service to generate temporary security credentials that you can use to sign
    /// requests.
    /// </para>
    ///  
    /// <para>
    /// All KMS operations require <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// KMS supports CloudTrail, a service that logs Amazon Web Services API calls and related
    /// events for your Amazon Web Services account and delivers them to an Amazon S3 bucket
    /// that you specify. By using the information collected by CloudTrail, you can determine
    /// what requests were made to KMS, who made the request, when it was made, and so on.
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/">CloudTrail
    /// User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">Amazon
    /// Web Services Security Credentials</a> - This topic provides general information about
    /// the types of credentials used to access Amazon Web Services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used API Operations</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the API operations discussed in this guide, the following will prove the most useful
    /// for most applications. You will likely perform operations other than these, such as
    /// creating keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonKeyManagementServiceMetadata();
        private IKeyManagementServicePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKeyManagementServicePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KeyManagementServicePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKeyManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AmazonKeyManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials and an
        /// AmazonKeyManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, AmazonKeyManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CancelKeyDeletion


        /// <summary>
        /// Cancels the deletion of a KMS key. When this operation succeeds, the key state of
        /// the KMS key is <code>Disabled</code>. To enable the KMS key, use <a>EnableKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a KMS key, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CancelKeyDeletion</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>ScheduleKeyDeletion</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key whose deletion is being canceled. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual CancelKeyDeletionResponse CancelKeyDeletion(string keyId)
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletion(request);
        }


        /// <summary>
        /// Cancels the deletion of a KMS key. When this operation succeeds, the key state of
        /// the KMS key is <code>Disabled</code>. To enable the KMS key, use <a>EnableKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a KMS key, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CancelKeyDeletion</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>ScheduleKeyDeletion</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<CancelKeyDeletionResponse>(request, options);
        }


        /// <summary>
        /// Cancels the deletion of a KMS key. When this operation succeeds, the key state of
        /// the KMS key is <code>Disabled</code>. To enable the KMS key, use <a>EnableKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a KMS key, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CancelKeyDeletion</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>ScheduleKeyDeletion</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key whose deletion is being canceled. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Cancels the deletion of a KMS key. When this operation succeeds, the key state of
        /// the KMS key is <code>Disabled</code>. To enable the KMS key, use <a>EnableKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a KMS key, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CancelKeyDeletion</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>ScheduleKeyDeletion</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CancelKeyDeletionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConnectCustomKeyStore


        /// <summary>
        /// Connects or reconnects a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> to its associated CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store must be connected before you can create KMS keys in the key store
        /// or use the KMS keys it contains. You can disconnect and reconnect a custom key store
        /// at any time.
        /// </para>
        ///  
        /// <para>
        /// To connect a custom key store, its associated CloudHSM cluster must have at least
        /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation. To add HSMs to the cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation. Also, the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user</a> (CU) must not be logged into the cluster. This
        /// prevents KMS from using this account to log in.
        /// </para>
        ///  
        /// <para>
        /// The connection process can take an extended amount of time to complete; up to 20 minutes.
        /// This operation starts the connection process, but it does not wait for it to complete.
        /// When it succeeds, this operation quickly returns an HTTP 200 response and a JSON object
        /// with no properties. However, this response does not indicate that the custom key store
        /// is connected. To get the connection state of the custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// During the connection process, KMS finds the CloudHSM cluster that is associated with
        /// the custom key store, creates the connection infrastructure, connects to the cluster,
        /// logs into the CloudHSM client as the <code>kmsuser</code> CU, and rotates its password.
        /// </para>
        ///  
        /// <para>
        /// The <code>ConnectCustomKeyStore</code> operation might fail for various reasons. To
        /// find the reason, use the <a>DescribeCustomKeyStores</a> operation and see the <code>ConnectionErrorCode</code>
        /// in the response. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// To fix the failure, use the <a>DisconnectCustomKeyStore</a> operation to disconnect
        /// the custom key store, correct the error, use the <a>UpdateCustomKeyStore</a> operation
        /// if necessary, and then use <code>ConnectCustomKeyStore</code> again.
        /// </para>
        ///  
        /// <para>
        /// If you are having trouble connecting or disconnecting a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ConnectCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the ConnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster that is associated with the
        /// custom key store is not active. Initialize and activate the cluster and try the command
        /// again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        public virtual ConnectCustomKeyStoreResponse ConnectCustomKeyStore(ConnectCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<ConnectCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Connects or reconnects a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> to its associated CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store must be connected before you can create KMS keys in the key store
        /// or use the KMS keys it contains. You can disconnect and reconnect a custom key store
        /// at any time.
        /// </para>
        ///  
        /// <para>
        /// To connect a custom key store, its associated CloudHSM cluster must have at least
        /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation. To add HSMs to the cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation. Also, the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user</a> (CU) must not be logged into the cluster. This
        /// prevents KMS from using this account to log in.
        /// </para>
        ///  
        /// <para>
        /// The connection process can take an extended amount of time to complete; up to 20 minutes.
        /// This operation starts the connection process, but it does not wait for it to complete.
        /// When it succeeds, this operation quickly returns an HTTP 200 response and a JSON object
        /// with no properties. However, this response does not indicate that the custom key store
        /// is connected. To get the connection state of the custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// During the connection process, KMS finds the CloudHSM cluster that is associated with
        /// the custom key store, creates the connection infrastructure, connects to the cluster,
        /// logs into the CloudHSM client as the <code>kmsuser</code> CU, and rotates its password.
        /// </para>
        ///  
        /// <para>
        /// The <code>ConnectCustomKeyStore</code> operation might fail for various reasons. To
        /// find the reason, use the <a>DescribeCustomKeyStores</a> operation and see the <code>ConnectionErrorCode</code>
        /// in the response. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// To fix the failure, use the <a>DisconnectCustomKeyStore</a> operation to disconnect
        /// the custom key store, correct the error, use the <a>UpdateCustomKeyStore</a> operation
        /// if necessary, and then use <code>ConnectCustomKeyStore</code> again.
        /// </para>
        ///  
        /// <para>
        /// If you are having trouble connecting or disconnecting a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ConnectCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster that is associated with the
        /// custom key store is not active. Initialize and activate the cluster and try the command
        /// again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        public virtual Task<ConnectCustomKeyStoreResponse> ConnectCustomKeyStoreAsync(ConnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectCustomKeyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<ConnectCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Creates a friendly name for a KMS key. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
        /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
        /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
        /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// You can associate the alias with any customer managed key in the same Amazon Web Services
        /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
        /// have multiple aliases. A valid KMS key is required. You can't create an alias without
        /// a KMS key.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique in the account and Region, but you can have aliases with
        /// the same name in different Regions. For detailed information about aliases, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Using
        /// aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasName">Specifies the alias name. This value must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.  The <code>AliasName</code> value must be string of 1-256 characters. It can contain only alphanumeric characters, forward slashes (/), underscores (_), and dashes (-). The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code> prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed keys</a>.</param>
        /// <param name="targetKeyId">Associates the alias with the specified <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a>. The KMS key must be in the same Amazon Web Services Region.  A valid key ID is required. If you supply a null or empty string value, this operation returns an error. For help finding the key ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html#find-cmk-id-arn">Finding the Key ID and ARN</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(string aliasName, string targetKeyId)
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAlias(request);
        }


        /// <summary>
        /// Creates a friendly name for a KMS key. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
        /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
        /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
        /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// You can associate the alias with any customer managed key in the same Amazon Web Services
        /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
        /// have multiple aliases. A valid KMS key is required. You can't create an alias without
        /// a KMS key.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique in the account and Region, but you can have aliases with
        /// the same name in different Regions. For detailed information about aliases, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Using
        /// aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }


        /// <summary>
        /// Creates a friendly name for a KMS key. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
        /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
        /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
        /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// You can associate the alias with any customer managed key in the same Amazon Web Services
        /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
        /// have multiple aliases. A valid KMS key is required. You can't create an alias without
        /// a KMS key.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique in the account and Region, but you can have aliases with
        /// the same name in different Regions. For detailed information about aliases, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Using
        /// aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasName">Specifies the alias name. This value must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.  The <code>AliasName</code> value must be string of 1-256 characters. It can contain only alphanumeric characters, forward slashes (/), underscores (_), and dashes (-). The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code> prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed keys</a>.</param>
        /// <param name="targetKeyId">Associates the alias with the specified <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a>. The KMS key must be in the same Amazon Web Services Region.  A valid key ID is required. If you supply a null or empty string value, this operation returns an error. For help finding the key ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html#find-cmk-id-arn">Finding the Key ID and ARN</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a friendly name for a KMS key. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
        /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
        /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
        /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// You can associate the alias with any customer managed key in the same Amazon Web Services
        /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
        /// have multiple aliases. A valid KMS key is required. You can't create an alias without
        /// a KMS key.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique in the account and Region, but you can have aliases with
        /// the same name in different Regions. For detailed information about aliases, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Using
        /// aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomKeyStore


        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> that is associated with an <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">CloudHSM
        /// cluster</a> that you own and manage.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// Before you create the custom key store, you must assemble the required elements, including
        /// an CloudHSM cluster that fulfills the requirements for a custom key store. For details
        /// about the required elements, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the operation completes successfully, it returns the ID of the new custom key
        /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
        /// operation to connect the new key store to its CloudHSM cluster. Even if you are not
        /// going to use your custom key store immediately, you might want to connect it to verify
        /// that all settings are correct and then disconnect it until you are ready to use it.
        /// </para>
        ///  
        /// <para>
        /// For help with failures, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateCustomKeyStore</a>
        /// (IAM policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the CreateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInUseException">
        /// The request was rejected because the specified CloudHSM cluster is already associated
        /// with a custom key store or it shares a backup history with a cluster that is associated
        /// with a custom key store. Each custom key store must be associated with a different
        /// CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster that is associated with the
        /// custom key store is not active. Initialize and activate the cluster and try the command
        /// again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectTrustAnchorException">
        /// The request was rejected because the trust anchor certificate in the request is not
        /// the trust anchor certificate for the specified CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// When you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the cluster</a>, you create the trust anchor certificate and save it in the <code>customerCA.crt</code>
        /// file.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        public virtual CreateCustomKeyStoreResponse CreateCustomKeyStore(CreateCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<CreateCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> that is associated with an <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">CloudHSM
        /// cluster</a> that you own and manage.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// Before you create the custom key store, you must assemble the required elements, including
        /// an CloudHSM cluster that fulfills the requirements for a custom key store. For details
        /// about the required elements, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the operation completes successfully, it returns the ID of the new custom key
        /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
        /// operation to connect the new key store to its CloudHSM cluster. Even if you are not
        /// going to use your custom key store immediately, you might want to connect it to verify
        /// that all settings are correct and then disconnect it until you are ready to use it.
        /// </para>
        ///  
        /// <para>
        /// For help with failures, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateCustomKeyStore</a>
        /// (IAM policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInUseException">
        /// The request was rejected because the specified CloudHSM cluster is already associated
        /// with a custom key store or it shares a backup history with a cluster that is associated
        /// with a custom key store. Each custom key store must be associated with a different
        /// CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster that is associated with the
        /// custom key store is not active. Initialize and activate the cluster and try the command
        /// again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectTrustAnchorException">
        /// The request was rejected because the trust anchor certificate in the request is not
        /// the trust anchor certificate for the specified CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// When you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the cluster</a>, you create the trust anchor certificate and save it in the <code>customerCA.crt</code>
        /// file.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        public virtual Task<CreateCustomKeyStoreResponse> CreateCustomKeyStoreAsync(CreateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomKeyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant


        /// <summary>
        /// Adds a grant to a KMS key. 
        /// 
        ///  
        /// <para>
        /// A <i>grant</i> is a policy instrument that allows Amazon Web Services principals to
        /// use KMS keys in cryptographic operations. It also can allow them to view a KMS key
        /// (<a>DescribeKey</a>) and create and manage grants. When authorizing access to a KMS
        /// key, grants are considered along with key policies and IAM policies. Grants are often
        /// used for temporary permissions because you can create one, use its permissions, and
        /// delete it without changing your key policies or IAM policies. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateGrant</code> operation returns a <code>GrantToken</code> and a <code>GrantId</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. Once the grant has achieved eventual consistency,
        /// the grantee principal can use the permissions in the grant without identifying the
        /// grant. 
        /// </para>
        ///  
        /// <para>
        /// However, to use the permissions in the grant immediately, use the <code>GrantToken</code>
        /// that <code>CreateGrant</code> returns. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token">Using
        /// a grant token</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>CreateGrant</code> operation also returns a <code>GrantId</code>. You can
        /// use the <code>GrantId</code> and a key identifier to identify the grant in the <a>RetireGrant</a>
        /// and <a>RevokeGrant</a> operations. To find the grant ID, use the <a>ListGrants</a>
        /// or <a>ListRetirableGrants</a> operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateGrant</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public virtual CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantResponse>(request, options);
        }


        /// <summary>
        /// Adds a grant to a KMS key. 
        /// 
        ///  
        /// <para>
        /// A <i>grant</i> is a policy instrument that allows Amazon Web Services principals to
        /// use KMS keys in cryptographic operations. It also can allow them to view a KMS key
        /// (<a>DescribeKey</a>) and create and manage grants. When authorizing access to a KMS
        /// key, grants are considered along with key policies and IAM policies. Grants are often
        /// used for temporary permissions because you can create one, use its permissions, and
        /// delete it without changing your key policies or IAM policies. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateGrant</code> operation returns a <code>GrantToken</code> and a <code>GrantId</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. Once the grant has achieved eventual consistency,
        /// the grantee principal can use the permissions in the grant without identifying the
        /// grant. 
        /// </para>
        ///  
        /// <para>
        /// However, to use the permissions in the grant immediately, use the <code>GrantToken</code>
        /// that <code>CreateGrant</code> returns. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token">Using
        /// a grant token</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>CreateGrant</code> operation also returns a <code>GrantId</code>. You can
        /// use the <code>GrantId</code> and a key identifier to identify the grant in the <a>RetireGrant</a>
        /// and <a>RevokeGrant</a> operations. To find the grant ID, use the <a>ListGrants</a>
        /// or <a>ListRetirableGrants</a> operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateGrant</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public virtual Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKey


        /// <summary>
        /// Creates a unique customer managed <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms-keys">KMS
        /// key</a> in your Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// KMS is replacing the term <i>customer master key (CMK)</i> with <i>KMS key</i> and
        /// <i>KMS key</i>. The concept has not changed. To prevent breaking changes, KMS is keeping
        /// some variations of this term.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use the <code>CreateKey</code> operation to create symmetric or asymmetric
        /// KMS keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Symmetric KMS keys</b> contain a 256-bit symmetric key that never leaves KMS unencrypted.
        /// To use the KMS key, you must call KMS. You can use a symmetric KMS key to encrypt
        /// and decrypt small amounts of data, but they are typically used to generate <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
        /// keys</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-key-pairs">data
        /// keys pairs</a>. For details, see <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Asymmetric KMS keys</b> can contain an RSA key pair or an Elliptic Curve (ECC)
        /// key pair. The private key in an asymmetric KMS key never leaves KMS unencrypted. However,
        /// you can use the <a>GetPublicKey</a> operation to download the public key so it can
        /// be used outside of KMS. KMS keys with RSA key pairs can be used to encrypt or decrypt
        /// data or sign and verify messages (but not both). KMS keys with ECC key pairs can be
        /// used only to sign and verify messages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create different types of KMS keys, use the following guidance:
        /// </para>
        ///  <dl> <dt>Asymmetric KMS keys</dt> <dd> 
        /// <para>
        /// To create an asymmetric KMS key, use the <code>KeySpec</code> parameter to specify
        /// the type of key material in the KMS key. Then, use the <code>KeyUsage</code> parameter
        /// to determine whether the KMS key will be used to encrypt and decrypt or sign and verify.
        /// You can't change these properties after the KMS key is created.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Symmetric KMS keys</dt> <dd> 
        /// <para>
        /// When creating a symmetric KMS key, you don't need to specify the <code>KeySpec</code>
        /// or <code>KeyUsage</code> parameters. The default value for <code>KeySpec</code>, <code>SYMMETRIC_DEFAULT</code>,
        /// and the default value for <code>KeyUsage</code>, <code>ENCRYPT_DECRYPT</code>, are
        /// the only valid values for symmetric KMS keys. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Multi-Region primary keys</dt> <dt>Imported key material</dt> <dd> 
        /// <para>
        /// To create a multi-Region <i>primary key</i> in the local Amazon Web Services Region,
        /// use the <code>MultiRegion</code> parameter with a value of <code>True</code>. To create
        /// a multi-Region <i>replica key</i>, that is, a KMS key with the same key ID and key
        /// material as a primary key, but in a different Amazon Web Services Region, use the
        /// <a>ReplicateKey</a> operation. To change a replica key to a primary key, and its primary
        /// key to a replica key, use the <a>UpdatePrimaryRegion</a> operation.
        /// </para>
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can create symmetric and asymmetric multi-Region keys and multi-Region keys with
        /// imported key material. You cannot create multi-Region keys in a custom key store.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dd> 
        /// <para>
        /// To import your own key material, begin by creating a symmetric KMS key with no key
        /// material. To do this, use the <code>Origin</code> parameter of <code>CreateKey</code>
        /// with a value of <code>EXTERNAL</code>. Next, use <a>GetParametersForImport</a> operation
        /// to get a public key and import token, and use the public key to encrypt your key material.
        /// Then, use <a>ImportKeyMaterial</a> with your import token to import the key material.
        /// For step-by-step instructions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. You
        /// cannot import the key material into an asymmetric KMS key.
        /// </para>
        ///  
        /// <para>
        /// To create a multi-Region primary key with imported key material, use the <code>Origin</code>
        /// parameter of <code>CreateKey</code> with a value of <code>EXTERNAL</code> and the
        /// <code>MultiRegion</code> parameter with a value of <code>True</code>. To create replicas
        /// of the multi-Region primary key, use the <a>ReplicateKey</a> operation. For more information
        /// about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Custom key store</dt> <dd> 
        /// <para>
        /// To create a symmetric KMS key in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, use the <code>CustomKeyStoreId</code> parameter to specify the custom
        /// key store. You must also use the <code>Origin</code> parameter with a value of <code>AWS_CLOUDHSM</code>.
        /// The CloudHSM cluster that is associated with the custom key store must have at least
        /// two active HSMs in different Availability Zones in the Amazon Web Services Region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You cannot create an asymmetric KMS key in a custom key store. For information about
        /// custom key stores in KMS see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Using
        /// Custom Key Stores</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation to create a KMS key in
        /// a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateKey</a>
        /// (IAM policy). To use the <code>Tags</code> parameter, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// (IAM policy). For examples and information about related permissions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policy-example-create-key">Allow
        /// a user to create KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ScheduleKeyDeletion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public virtual CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return Invoke<CreateKeyResponse>(request, options);
        }


        /// <summary>
        /// Creates a unique customer managed <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms-keys">KMS
        /// key</a> in your Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// KMS is replacing the term <i>customer master key (CMK)</i> with <i>KMS key</i> and
        /// <i>KMS key</i>. The concept has not changed. To prevent breaking changes, KMS is keeping
        /// some variations of this term.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use the <code>CreateKey</code> operation to create symmetric or asymmetric
        /// KMS keys.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Symmetric KMS keys</b> contain a 256-bit symmetric key that never leaves KMS unencrypted.
        /// To use the KMS key, you must call KMS. You can use a symmetric KMS key to encrypt
        /// and decrypt small amounts of data, but they are typically used to generate <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
        /// keys</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-key-pairs">data
        /// keys pairs</a>. For details, see <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Asymmetric KMS keys</b> can contain an RSA key pair or an Elliptic Curve (ECC)
        /// key pair. The private key in an asymmetric KMS key never leaves KMS unencrypted. However,
        /// you can use the <a>GetPublicKey</a> operation to download the public key so it can
        /// be used outside of KMS. KMS keys with RSA key pairs can be used to encrypt or decrypt
        /// data or sign and verify messages (but not both). KMS keys with ECC key pairs can be
        /// used only to sign and verify messages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create different types of KMS keys, use the following guidance:
        /// </para>
        ///  <dl> <dt>Asymmetric KMS keys</dt> <dd> 
        /// <para>
        /// To create an asymmetric KMS key, use the <code>KeySpec</code> parameter to specify
        /// the type of key material in the KMS key. Then, use the <code>KeyUsage</code> parameter
        /// to determine whether the KMS key will be used to encrypt and decrypt or sign and verify.
        /// You can't change these properties after the KMS key is created.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Symmetric KMS keys</dt> <dd> 
        /// <para>
        /// When creating a symmetric KMS key, you don't need to specify the <code>KeySpec</code>
        /// or <code>KeyUsage</code> parameters. The default value for <code>KeySpec</code>, <code>SYMMETRIC_DEFAULT</code>,
        /// and the default value for <code>KeyUsage</code>, <code>ENCRYPT_DECRYPT</code>, are
        /// the only valid values for symmetric KMS keys. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Multi-Region primary keys</dt> <dt>Imported key material</dt> <dd> 
        /// <para>
        /// To create a multi-Region <i>primary key</i> in the local Amazon Web Services Region,
        /// use the <code>MultiRegion</code> parameter with a value of <code>True</code>. To create
        /// a multi-Region <i>replica key</i>, that is, a KMS key with the same key ID and key
        /// material as a primary key, but in a different Amazon Web Services Region, use the
        /// <a>ReplicateKey</a> operation. To change a replica key to a primary key, and its primary
        /// key to a replica key, use the <a>UpdatePrimaryRegion</a> operation.
        /// </para>
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can create symmetric and asymmetric multi-Region keys and multi-Region keys with
        /// imported key material. You cannot create multi-Region keys in a custom key store.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dd> 
        /// <para>
        /// To import your own key material, begin by creating a symmetric KMS key with no key
        /// material. To do this, use the <code>Origin</code> parameter of <code>CreateKey</code>
        /// with a value of <code>EXTERNAL</code>. Next, use <a>GetParametersForImport</a> operation
        /// to get a public key and import token, and use the public key to encrypt your key material.
        /// Then, use <a>ImportKeyMaterial</a> with your import token to import the key material.
        /// For step-by-step instructions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. You
        /// cannot import the key material into an asymmetric KMS key.
        /// </para>
        ///  
        /// <para>
        /// To create a multi-Region primary key with imported key material, use the <code>Origin</code>
        /// parameter of <code>CreateKey</code> with a value of <code>EXTERNAL</code> and the
        /// <code>MultiRegion</code> parameter with a value of <code>True</code>. To create replicas
        /// of the multi-Region primary key, use the <a>ReplicateKey</a> operation. For more information
        /// about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Custom key store</dt> <dd> 
        /// <para>
        /// To create a symmetric KMS key in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, use the <code>CustomKeyStoreId</code> parameter to specify the custom
        /// key store. You must also use the <code>Origin</code> parameter with a value of <code>AWS_CLOUDHSM</code>.
        /// The CloudHSM cluster that is associated with the custom key store must have at least
        /// two active HSMs in different Availability Zones in the Amazon Web Services Region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You cannot create an asymmetric KMS key in a custom key store. For information about
        /// custom key stores in KMS see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Using
        /// Custom Key Stores</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation to create a KMS key in
        /// a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateKey</a>
        /// (IAM policy). To use the <code>Tags</code> parameter, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// (IAM policy). For examples and information about related permissions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policy-example-create-key">Allow
        /// a user to create KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ScheduleKeyDeletion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public virtual Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Decrypt


        /// <summary>
        /// Decrypts ciphertext that was encrypted by a KMS key using any of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use this operation to decrypt ciphertext that was encrypted under a symmetric
        /// or asymmetric KMS key. When the KMS key is asymmetric, you must specify the KMS key
        /// and the encryption algorithm that was used to encrypt the ciphertext. For information
        /// about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The Decrypt operation also decrypts ciphertext that was encrypted outside of KMS by
        /// the public key in an KMS asymmetric KMS key. However, it cannot decrypt ciphertext
        /// produced by other libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
        /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with KMS.
        /// </para>
        ///  
        /// <para>
        /// If the ciphertext was encrypted under a symmetric KMS key, the <code>KeyId</code>
        /// parameter is optional. KMS can get this information from metadata that it adds to
        /// the symmetric ciphertext blob. This feature adds durability to your implementation
        /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
        /// even if they've lost track of the key ID. However, specifying the KMS key is always
        /// recommended as a best practice. When you use the <code>KeyId</code> parameter to specify
        /// a KMS key, KMS only uses the KMS key you specify. If the ciphertext was encrypted
        /// under a different KMS key, the <code>Decrypt</code> operation fails. This practice
        /// ensures that you use the KMS key that you intend.
        /// </para>
        ///  
        /// <para>
        /// Whenever possible, use key policies to give users permission to call the <code>Decrypt</code>
        /// operation on a particular KMS key, instead of using IAM policies. Otherwise, you might
        /// create an IAM user policy that gives the user <code>Decrypt</code> permission on all
        /// KMS keys. This user could decrypt ciphertext that was encrypted by KMS keys in other
        /// accounts if the key policy for the cross-account KMS key permits it. If you must use
        /// an IAM policy for <code>Decrypt</code> permissions, limit the user to particular KMS
        /// keys or particular trusted accounts. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policies-best-practices">Best
        /// practices for IAM policies</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Decrypt</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReEncrypt</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified KMS key cannot decrypt the data. The
        /// <code>KeyId</code> in a <a>Decrypt</a> request and the <code>SourceKeyId</code> in
        /// a <a>ReEncrypt</a> request must identify the same KMS key that was used to encrypt
        /// the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public virtual DecryptResponse Decrypt(DecryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptResponseUnmarshaller.Instance;

            return Invoke<DecryptResponse>(request, options);
        }


        /// <summary>
        /// Decrypts ciphertext that was encrypted by a KMS key using any of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use this operation to decrypt ciphertext that was encrypted under a symmetric
        /// or asymmetric KMS key. When the KMS key is asymmetric, you must specify the KMS key
        /// and the encryption algorithm that was used to encrypt the ciphertext. For information
        /// about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The Decrypt operation also decrypts ciphertext that was encrypted outside of KMS by
        /// the public key in an KMS asymmetric KMS key. However, it cannot decrypt ciphertext
        /// produced by other libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
        /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with KMS.
        /// </para>
        ///  
        /// <para>
        /// If the ciphertext was encrypted under a symmetric KMS key, the <code>KeyId</code>
        /// parameter is optional. KMS can get this information from metadata that it adds to
        /// the symmetric ciphertext blob. This feature adds durability to your implementation
        /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
        /// even if they've lost track of the key ID. However, specifying the KMS key is always
        /// recommended as a best practice. When you use the <code>KeyId</code> parameter to specify
        /// a KMS key, KMS only uses the KMS key you specify. If the ciphertext was encrypted
        /// under a different KMS key, the <code>Decrypt</code> operation fails. This practice
        /// ensures that you use the KMS key that you intend.
        /// </para>
        ///  
        /// <para>
        /// Whenever possible, use key policies to give users permission to call the <code>Decrypt</code>
        /// operation on a particular KMS key, instead of using IAM policies. Otherwise, you might
        /// create an IAM user policy that gives the user <code>Decrypt</code> permission on all
        /// KMS keys. This user could decrypt ciphertext that was encrypted by KMS keys in other
        /// accounts if the key policy for the cross-account KMS key permits it. If you must use
        /// an IAM policy for <code>Decrypt</code> permissions, limit the user to particular KMS
        /// keys or particular trusted accounts. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policies-best-practices">Best
        /// practices for IAM policies</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Decrypt</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReEncrypt</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified KMS key cannot decrypt the data. The
        /// <code>KeyId</code> in a <a>Decrypt</a> request and the <code>SourceKeyId</code> in
        /// a <a>ReEncrypt</a> request must identify the same KMS key that was used to encrypt
        /// the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public virtual Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptResponseUnmarshaller.Instance;
            
            return InvokeAsync<DecryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes the specified alias. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Because an alias is not a property of a KMS key, you can delete and change the aliases
        /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
        /// <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The alias name must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(string aliasName)
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAlias(request);
        }


        /// <summary>
        /// Deletes the specified alias. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Because an alias is not a property of a KMS key, you can delete and change the aliases
        /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
        /// <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified alias. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Because an alias is not a property of a KMS key, you can delete and change the aliases
        /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
        /// <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The alias name must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes the specified alias. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Because an alias is not a property of a KMS key, you can delete and change the aliases
        /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
        /// <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomKeyStore


        /// <summary>
        /// Deletes a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. This operation does not delete the CloudHSM cluster that is associated
        /// with the custom key store, or affect any users or keys in the cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store that you delete cannot contain any KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms_keys">KMS
        /// keys</a>. Before deleting the key store, verify that you will never need to use any
        /// of the KMS keys in the key store for any <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. Then, use <a>ScheduleKeyDeletion</a> to delete the KMS keys from the
        /// key store. When the scheduled waiting period expires, the <code>ScheduleKeyDeletion</code>
        /// operation deletes the KMS keys. Then it makes a best effort to delete the key material
        /// from the associated cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// After all KMS keys are deleted from KMS, use <a>DisconnectCustomKeyStore</a> to disconnect
        /// the key store from KMS. Then, you can delete the custom key store.
        /// </para>
        ///  
        /// <para>
        /// Instead of deleting the custom key store, consider using <a>DisconnectCustomKeyStore</a>
        /// to disconnect it from KMS. While the key store is disconnected, you cannot create
        /// or use the KMS keys in the key store. But, you do not need to delete KMS keys and
        /// you can reconnect a disconnected custom key store at any time.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreHasCMKsException">
        /// The request was rejected because the custom key store contains KMS keys. After verifying
        /// that you do not need to use the KMS keys, use the <a>ScheduleKeyDeletion</a> operation
        /// to delete the KMS keys. After they are deleted, you can delete the custom key store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        public virtual DeleteCustomKeyStoreResponse DeleteCustomKeyStore(DeleteCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Deletes a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. This operation does not delete the CloudHSM cluster that is associated
        /// with the custom key store, or affect any users or keys in the cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store that you delete cannot contain any KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms_keys">KMS
        /// keys</a>. Before deleting the key store, verify that you will never need to use any
        /// of the KMS keys in the key store for any <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. Then, use <a>ScheduleKeyDeletion</a> to delete the KMS keys from the
        /// key store. When the scheduled waiting period expires, the <code>ScheduleKeyDeletion</code>
        /// operation deletes the KMS keys. Then it makes a best effort to delete the key material
        /// from the associated cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// After all KMS keys are deleted from KMS, use <a>DisconnectCustomKeyStore</a> to disconnect
        /// the key store from KMS. Then, you can delete the custom key store.
        /// </para>
        ///  
        /// <para>
        /// Instead of deleting the custom key store, consider using <a>DisconnectCustomKeyStore</a>
        /// to disconnect it from KMS. While the key store is disconnected, you cannot create
        /// or use the KMS keys in the key store. But, you do not need to delete KMS keys and
        /// you can reconnect a disconnected custom key store at any time.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreHasCMKsException">
        /// The request was rejected because the custom key store contains KMS keys. After verifying
        /// that you do not need to use the KMS keys, use the <a>ScheduleKeyDeletion</a> operation
        /// to delete the KMS keys. After they are deleted, you can delete the custom key store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        public virtual Task<DeleteCustomKeyStoreResponse> DeleteCustomKeyStoreAsync(DeleteCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomKeyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportedKeyMaterial


        /// <summary>
        /// Deletes key material that you previously imported. This operation makes the specified
        /// KMS key unusable. For more information about importing key material into KMS, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>. 
        /// 
        ///  
        /// <para>
        /// When the specified KMS key is in the <code>PendingDeletion</code> state, this operation
        /// does not change the KMS key's state. Otherwise, it changes the KMS key's state to
        /// <code>PendingImport</code>.
        /// </para>
        ///  
        /// <para>
        /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
        /// same key material into the KMS key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteImportedKeyMaterial</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial service method.</param>
        /// 
        /// <returns>The response from the DeleteImportedKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public virtual DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedKeyMaterialResponse>(request, options);
        }


        /// <summary>
        /// Deletes key material that you previously imported. This operation makes the specified
        /// KMS key unusable. For more information about importing key material into KMS, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>. 
        /// 
        ///  
        /// <para>
        /// When the specified KMS key is in the <code>PendingDeletion</code> state, this operation
        /// does not change the KMS key's state. Otherwise, it changes the KMS key's state to
        /// <code>PendingImport</code>.
        /// </para>
        ///  
        /// <para>
        /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
        /// same key material into the KMS key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteImportedKeyMaterial</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImportedKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public virtual Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteImportedKeyMaterialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomKeyStores


        /// <summary>
        /// Gets information about <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key stores</a> in the account and Region.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns information about all custom key stores in the
        /// account and Region. To get only information about a particular custom key store, use
        /// either the <code>CustomKeyStoreName</code> or <code>CustomKeyStoreId</code> parameter
        /// (but not both).
        /// </para>
        ///  
        /// <para>
        /// To determine whether the custom key store is connected to its CloudHSM cluster, use
        /// the <code>ConnectionState</code> element in the response. If an attempt to connect
        /// the custom key store failed, the <code>ConnectionState</code> value is <code>FAILED</code>
        /// and the <code>ConnectionErrorCode</code> element in the response indicates the cause
        /// of the failure. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// Custom key stores have a <code>DISCONNECTED</code> connection state if the key store
        /// has never been connected or you use the <a>DisconnectCustomKeyStore</a> operation
        /// to disconnect it. If your custom key store state is <code>CONNECTED</code> but you
        /// are having trouble using it, make sure that its associated CloudHSM cluster is active
        /// and contains the minimum number of HSMs required for the operation, if any.
        /// </para>
        ///  
        /// <para>
        ///  For help repairing your custom key store, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// Custom Key Stores</a> topic in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeCustomKeyStores</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomKeyStores service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        public virtual DescribeCustomKeyStoresResponse DescribeCustomKeyStores(DescribeCustomKeyStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomKeyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomKeyStoresResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomKeyStoresResponse>(request, options);
        }


        /// <summary>
        /// Gets information about <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key stores</a> in the account and Region.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns information about all custom key stores in the
        /// account and Region. To get only information about a particular custom key store, use
        /// either the <code>CustomKeyStoreName</code> or <code>CustomKeyStoreId</code> parameter
        /// (but not both).
        /// </para>
        ///  
        /// <para>
        /// To determine whether the custom key store is connected to its CloudHSM cluster, use
        /// the <code>ConnectionState</code> element in the response. If an attempt to connect
        /// the custom key store failed, the <code>ConnectionState</code> value is <code>FAILED</code>
        /// and the <code>ConnectionErrorCode</code> element in the response indicates the cause
        /// of the failure. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// Custom key stores have a <code>DISCONNECTED</code> connection state if the key store
        /// has never been connected or you use the <a>DisconnectCustomKeyStore</a> operation
        /// to disconnect it. If your custom key store state is <code>CONNECTED</code> but you
        /// are having trouble using it, make sure that its associated CloudHSM cluster is active
        /// and contains the minimum number of HSMs required for the operation, if any.
        /// </para>
        ///  
        /// <para>
        ///  For help repairing your custom key store, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// Custom Key Stores</a> topic in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeCustomKeyStores</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomKeyStores service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        public virtual Task<DescribeCustomKeyStoresResponse> DescribeCustomKeyStoresAsync(DescribeCustomKeyStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomKeyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomKeyStoresResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeCustomKeyStoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKey


        /// <summary>
        /// Provides detailed information about a KMS key. You can run <code>DescribeKey</code>
        /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. It includes fields, like <code>KeySpec</code>, that help you distinguish
        /// symmetric from asymmetric KMS keys. It also provides information that is particularly
        /// important to asymmetric keys, such as the key usage (encryption or signing) and the
        /// encryption algorithms or signing algorithms that the KMS key supports. For KMS keys
        /// in custom key stores, it includes information about the custom key store, such as
        /// the key store ID and the CloudHSM cluster ID. For multi-Region keys, it displays the
        /// primary key and all related replica keys. 
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeKey</code> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the KMS key. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the KMS key. To get this information,
        /// use <a>GetKeyRotationStatus</a>. Also, some key states prevent a KMS key from being
        /// automatically rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// Automatic Key Rotation Works</a> in <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the KMS key. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the KMS key. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you call the <code>DescribeKey</code> operation on a <i>predefined Amazon Web Services
        /// alias</i>, that is, an Amazon Web Services alias with no key ID, KMS creates an <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>. Then, it associates the alias with the new KMS key,
        /// and returns the <code>KeyId</code> and <code>Arn</code> of the new KMS key in the
        /// response.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Describes the specified KMS key.  If you specify a predefined Amazon Web Services alias (an Amazon Web Services alias with no key ID), KMS associates the alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html##aws-managed-cmk">Amazon Web Services managed key</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual DescribeKeyResponse DescribeKey(string keyId)
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKey(request);
        }


        /// <summary>
        /// Provides detailed information about a KMS key. You can run <code>DescribeKey</code>
        /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. It includes fields, like <code>KeySpec</code>, that help you distinguish
        /// symmetric from asymmetric KMS keys. It also provides information that is particularly
        /// important to asymmetric keys, such as the key usage (encryption or signing) and the
        /// encryption algorithms or signing algorithms that the KMS key supports. For KMS keys
        /// in custom key stores, it includes information about the custom key store, such as
        /// the key store ID and the CloudHSM cluster ID. For multi-Region keys, it displays the
        /// primary key and all related replica keys. 
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeKey</code> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the KMS key. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the KMS key. To get this information,
        /// use <a>GetKeyRotationStatus</a>. Also, some key states prevent a KMS key from being
        /// automatically rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// Automatic Key Rotation Works</a> in <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the KMS key. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the KMS key. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you call the <code>DescribeKey</code> operation on a <i>predefined Amazon Web Services
        /// alias</i>, that is, an Amazon Web Services alias with no key ID, KMS creates an <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>. Then, it associates the alias with the new KMS key,
        /// and returns the <code>KeyId</code> and <code>Arn</code> of the new KMS key in the
        /// response.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyResponse>(request, options);
        }


        /// <summary>
        /// Provides detailed information about a KMS key. You can run <code>DescribeKey</code>
        /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. It includes fields, like <code>KeySpec</code>, that help you distinguish
        /// symmetric from asymmetric KMS keys. It also provides information that is particularly
        /// important to asymmetric keys, such as the key usage (encryption or signing) and the
        /// encryption algorithms or signing algorithms that the KMS key supports. For KMS keys
        /// in custom key stores, it includes information about the custom key store, such as
        /// the key store ID and the CloudHSM cluster ID. For multi-Region keys, it displays the
        /// primary key and all related replica keys. 
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeKey</code> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the KMS key. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the KMS key. To get this information,
        /// use <a>GetKeyRotationStatus</a>. Also, some key states prevent a KMS key from being
        /// automatically rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// Automatic Key Rotation Works</a> in <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the KMS key. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the KMS key. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you call the <code>DescribeKey</code> operation on a <i>predefined Amazon Web Services
        /// alias</i>, that is, an Amazon Web Services alias with no key ID, KMS creates an <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>. Then, it associates the alias with the new KMS key,
        /// and returns the <code>KeyId</code> and <code>Arn</code> of the new KMS key in the
        /// response.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Describes the specified KMS key.  If you specify a predefined Amazon Web Services alias (an Amazon Web Services alias with no key ID), KMS associates the alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html##aws-managed-cmk">Amazon Web Services managed key</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Provides detailed information about a KMS key. You can run <code>DescribeKey</code>
        /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. It includes fields, like <code>KeySpec</code>, that help you distinguish
        /// symmetric from asymmetric KMS keys. It also provides information that is particularly
        /// important to asymmetric keys, such as the key usage (encryption or signing) and the
        /// encryption algorithms or signing algorithms that the KMS key supports. For KMS keys
        /// in custom key stores, it includes information about the custom key store, such as
        /// the key store ID and the CloudHSM cluster ID. For multi-Region keys, it displays the
        /// primary key and all related replica keys. 
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeKey</code> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the KMS key. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the KMS key. To get this information,
        /// use <a>GetKeyRotationStatus</a>. Also, some key states prevent a KMS key from being
        /// automatically rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// Automatic Key Rotation Works</a> in <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the KMS key. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the KMS key. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you call the <code>DescribeKey</code> operation on a <i>predefined Amazon Web Services
        /// alias</i>, that is, an Amazon Web Services alias with no key ID, KMS creates an <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>. Then, it associates the alias with the new KMS key,
        /// and returns the <code>KeyId</code> and <code>Arn</code> of the new KMS key in the
        /// response.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKey


        /// <summary>
        /// Sets the state of a KMS key to disabled. This change temporarily prevents use of the
        /// KMS key for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>EnableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key to disable. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual DisableKeyResponse DisableKey(string keyId)
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKey(request);
        }


        /// <summary>
        /// Sets the state of a KMS key to disabled. This change temporarily prevents use of the
        /// KMS key for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>EnableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return Invoke<DisableKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the state of a KMS key to disabled. This change temporarily prevents use of the
        /// KMS key for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>EnableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key to disable. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Sets the state of a KMS key to disabled. This change temporarily prevents use of the
        /// KMS key for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>EnableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKeyRotation


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        ///  You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric KMS key. You cannot enable or disable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html#asymmetric-cmks">asymmetric KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom key store</a>. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual DisableKeyRotationResponse DisableKeyRotation(string keyId)
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotation(request);
        }


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        ///  You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRotationResponse>(request, options);
        }


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        ///  You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric KMS key. You cannot enable or disable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html#asymmetric-cmks">asymmetric KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom key store</a>. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        ///  You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisableKeyRotationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectCustomKeyStore


        /// <summary>
        /// Disconnects the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> from its associated CloudHSM cluster. While a custom key store is disconnected,
        /// you can manage the custom key store and its KMS keys, but you cannot create or use
        /// KMS keys in the custom key store. You can reconnect the custom key store at any time.
        /// 
        ///  <note> 
        /// <para>
        /// While a custom key store is disconnected, all attempts to create KMS keys in the custom
        /// key store or to use existing KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a> will fail. This action can prevent users from storing and accessing
        /// sensitive data.
        /// </para>
        ///  </note>  
        /// <para>
        /// To find the connection state of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation. To reconnect a custom key store, use the <a>ConnectCustomKeyStore</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisconnectCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the DisconnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        public virtual DisconnectCustomKeyStoreResponse DisconnectCustomKeyStore(DisconnectCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<DisconnectCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Disconnects the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> from its associated CloudHSM cluster. While a custom key store is disconnected,
        /// you can manage the custom key store and its KMS keys, but you cannot create or use
        /// KMS keys in the custom key store. You can reconnect the custom key store at any time.
        /// 
        ///  <note> 
        /// <para>
        /// While a custom key store is disconnected, all attempts to create KMS keys in the custom
        /// key store or to use existing KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a> will fail. This action can prevent users from storing and accessing
        /// sensitive data.
        /// </para>
        ///  </note>  
        /// <para>
        /// To find the connection state of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation. To reconnect a custom key store, use the <a>ConnectCustomKeyStore</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisconnectCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        public virtual Task<DisconnectCustomKeyStoreResponse> DisconnectCustomKeyStoreAsync(DisconnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectCustomKeyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisconnectCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKey


        /// <summary>
        /// Sets the key state of a KMS key to enabled. This allows you to use the KMS key for
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>DisableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key to enable. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual EnableKeyResponse EnableKey(string keyId)
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKey(request);
        }


        /// <summary>
        /// Sets the key state of a KMS key to enabled. This allows you to use the KMS key for
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>DisableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return Invoke<EnableKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the key state of a KMS key to enabled. This allows you to use the KMS key for
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>DisableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key to enable. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Sets the key state of a KMS key to enabled. This allows you to use the KMS key for
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>DisableKey</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKeyRotation


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric KMS key. You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region keys</a>, set the property on the primary key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual EnableKeyRotationResponse EnableKeyRotation(string keyId)
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotation(request);
        }


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRotationResponse>(request, options);
        }


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric KMS key. You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region keys</a>, set the property on the primary key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;
            
            return InvokeAsync<EnableKeyRotationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Encrypt


        /// <summary>
        /// Encrypts plaintext into ciphertext by using a KMS key. The <code>Encrypt</code> operation
        /// has two primary use cases:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can encrypt small amounts of arbitrary data, such as a personal identifier or
        /// database password, or other sensitive information. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use the <code>Encrypt</code> operation to move encrypted data from one Amazon
        /// Web Services Region to another. For example, in Region A, generate a data key and
        /// use the plaintext key to encrypt your data. Then, in Region A, use the <code>Encrypt</code>
        /// operation to encrypt the plaintext data key under a KMS key in Region B. Now, you
        /// can move the encrypted data and the encrypted data key to Region B. When necessary,
        /// you can decrypt the encrypted data key and the encrypted data entirely within in Region
        /// B.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You don't need to use the <code>Encrypt</code> operation to encrypt a data key. The
        /// <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a> operations return a plaintext
        /// data key and an encrypted copy of that data key.
        /// </para>
        ///  
        /// <para>
        /// When you encrypt data, you must specify a symmetric or asymmetric KMS key to use in
        /// the encryption operation. The KMS key must have a <code>KeyUsage</code> value of <code>ENCRYPT_DECRYPT.</code>
        /// To find the <code>KeyUsage</code> of a KMS key, use the <a>DescribeKey</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you use a symmetric KMS key, you can use an encryption context to add additional
        /// security to your encryption operation. If you specify an <code>EncryptionContext</code>
        /// when encrypting data, you must specify the same encryption context (a case-sensitive
        /// exact match) when decrypting the data. Otherwise, the request to decrypt fails with
        /// an <code>InvalidCiphertextException</code>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify an asymmetric KMS key, you must also specify the encryption algorithm.
        /// The algorithm must be compatible with the KMS key type.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
        /// the KMS key and encryption algorithm that you choose. You will be required to provide
        /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
        /// and algorithm do not match the values used to encrypt the data, the decrypt operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the key ID and encryption algorithm when you decrypt
        /// with symmetric KMS keys because KMS stores this information in the ciphertext blob.
        /// KMS cannot store metadata in ciphertext generated with asymmetric keys. The standard
        /// format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> 
        /// <para>
        /// The maximum size of the data that you can encrypt varies with the type of KMS key
        /// and the encryption algorithm that you choose.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Symmetric KMS keys
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SYMMETRIC_DEFAULT</code>: 4096 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_2048</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 214 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 190 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_3072</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 342 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 318 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_4096</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 470 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 446 bytes
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Encrypt</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public virtual EncryptResponse Encrypt(EncryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptResponseUnmarshaller.Instance;

            return Invoke<EncryptResponse>(request, options);
        }


        /// <summary>
        /// Encrypts plaintext into ciphertext by using a KMS key. The <code>Encrypt</code> operation
        /// has two primary use cases:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can encrypt small amounts of arbitrary data, such as a personal identifier or
        /// database password, or other sensitive information. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use the <code>Encrypt</code> operation to move encrypted data from one Amazon
        /// Web Services Region to another. For example, in Region A, generate a data key and
        /// use the plaintext key to encrypt your data. Then, in Region A, use the <code>Encrypt</code>
        /// operation to encrypt the plaintext data key under a KMS key in Region B. Now, you
        /// can move the encrypted data and the encrypted data key to Region B. When necessary,
        /// you can decrypt the encrypted data key and the encrypted data entirely within in Region
        /// B.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You don't need to use the <code>Encrypt</code> operation to encrypt a data key. The
        /// <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a> operations return a plaintext
        /// data key and an encrypted copy of that data key.
        /// </para>
        ///  
        /// <para>
        /// When you encrypt data, you must specify a symmetric or asymmetric KMS key to use in
        /// the encryption operation. The KMS key must have a <code>KeyUsage</code> value of <code>ENCRYPT_DECRYPT.</code>
        /// To find the <code>KeyUsage</code> of a KMS key, use the <a>DescribeKey</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you use a symmetric KMS key, you can use an encryption context to add additional
        /// security to your encryption operation. If you specify an <code>EncryptionContext</code>
        /// when encrypting data, you must specify the same encryption context (a case-sensitive
        /// exact match) when decrypting the data. Otherwise, the request to decrypt fails with
        /// an <code>InvalidCiphertextException</code>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify an asymmetric KMS key, you must also specify the encryption algorithm.
        /// The algorithm must be compatible with the KMS key type.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
        /// the KMS key and encryption algorithm that you choose. You will be required to provide
        /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
        /// and algorithm do not match the values used to encrypt the data, the decrypt operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the key ID and encryption algorithm when you decrypt
        /// with symmetric KMS keys because KMS stores this information in the ciphertext blob.
        /// KMS cannot store metadata in ciphertext generated with asymmetric keys. The standard
        /// format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> 
        /// <para>
        /// The maximum size of the data that you can encrypt varies with the type of KMS key
        /// and the encryption algorithm that you choose.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Symmetric KMS keys
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SYMMETRIC_DEFAULT</code>: 4096 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_2048</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 214 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 190 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_3072</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 342 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 318 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_4096</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 470 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 446 bytes
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Encrypt</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public virtual Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptResponseUnmarshaller.Instance;
            
            return InvokeAsync<EncryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKey


        /// <summary>
        /// Generates a unique symmetric data key for client-side encryption. This operation returns
        /// a plaintext copy of the data key and a copy that is encrypted under a KMS key that
        /// you specify. You can use the plaintext key to encrypt your data outside of KMS and
        /// store the encrypted data key with the encrypted data.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKey</code> returns a unique data key for each request. The bytes
        /// in the plaintext key are not related to the caller or the KMS key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, specify the symmetric KMS key that will be used to encrypt
        /// the data key. You cannot use an asymmetric KMS key to generate data keys. To get the
        /// type of your KMS key, use the <a>DescribeKey</a> operation. You must also specify
        /// the length of the data key. Use either the <code>KeySpec</code> or <code>NumberOfBytes</code>
        /// parameters (but not both). For 128-bit and 256-bit data keys, use the <code>KeySpec</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        /// To get only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
        /// To generate an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. To get a cryptographically secure random byte string, use <a>GenerateRandom</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>How to use your data key</b> 
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use the following pattern to encrypt data locally in your application.
        /// You can write your own code or use a client-side encryption library, such as the <a
        /// href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon Web
        /// Services Encryption SDK</a>, the <a href="https://docs.aws.amazon.com/dynamodb-encryption-client/latest/devguide/">Amazon
        /// DynamoDB Encryption Client</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a> to do these tasks for you.
        /// </para>
        ///  
        /// <para>
        /// To encrypt data outside of KMS:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <code>GenerateDataKey</code> operation to get a data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key (in the <code>Plaintext</code> field of the response) to
        /// encrypt your data outside of KMS. Then erase the plaintext data key from memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Store the encrypted data key (in the <code>CiphertextBlob</code> field of the response)
        /// with the encrypted data.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To decrypt data outside of KMS:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key. The operation
        /// returns a plaintext copy of the data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key to decrypt data outside of KMS, then erase the plaintext
        /// data key from memory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public virtual GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyResponse>(request, options);
        }


        /// <summary>
        /// Generates a unique symmetric data key for client-side encryption. This operation returns
        /// a plaintext copy of the data key and a copy that is encrypted under a KMS key that
        /// you specify. You can use the plaintext key to encrypt your data outside of KMS and
        /// store the encrypted data key with the encrypted data.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKey</code> returns a unique data key for each request. The bytes
        /// in the plaintext key are not related to the caller or the KMS key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, specify the symmetric KMS key that will be used to encrypt
        /// the data key. You cannot use an asymmetric KMS key to generate data keys. To get the
        /// type of your KMS key, use the <a>DescribeKey</a> operation. You must also specify
        /// the length of the data key. Use either the <code>KeySpec</code> or <code>NumberOfBytes</code>
        /// parameters (but not both). For 128-bit and 256-bit data keys, use the <code>KeySpec</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        /// To get only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
        /// To generate an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. To get a cryptographically secure random byte string, use <a>GenerateRandom</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>How to use your data key</b> 
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use the following pattern to encrypt data locally in your application.
        /// You can write your own code or use a client-side encryption library, such as the <a
        /// href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon Web
        /// Services Encryption SDK</a>, the <a href="https://docs.aws.amazon.com/dynamodb-encryption-client/latest/devguide/">Amazon
        /// DynamoDB Encryption Client</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a> to do these tasks for you.
        /// </para>
        ///  
        /// <para>
        /// To encrypt data outside of KMS:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <code>GenerateDataKey</code> operation to get a data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key (in the <code>Plaintext</code> field of the response) to
        /// encrypt your data outside of KMS. Then erase the plaintext data key from memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Store the encrypted data key (in the <code>CiphertextBlob</code> field of the response)
        /// with the encrypted data.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To decrypt data outside of KMS:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key. The operation
        /// returns a plaintext copy of the data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key to decrypt data outside of KMS, then erase the plaintext
        /// data key from memory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public virtual Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateDataKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyPair


        /// <summary>
        /// Generates a unique asymmetric data key pair. The <code>GenerateDataKeyPair</code>
        /// operation returns a plaintext public key, a plaintext private key, and a copy of the
        /// private key that is encrypted under the symmetric KMS key you specify. You can use
        /// the data key pair to perform asymmetric cryptography and implement digital signatures
        /// outside of KMS.
        /// 
        ///  
        /// <para>
        /// You can use the public key that <code>GenerateDataKeyPair</code> returns to encrypt
        /// data or verify a signature outside of KMS. Then, store the encrypted private key with
        /// the data. When you are ready to decrypt data or sign a message, you can use the <a>Decrypt</a>
        /// operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric KMS key to encrypt the private
        /// key in a data key pair. You cannot use an asymmetric KMS key or a KMS key in a custom
        /// key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>KeyPairSpec</code> parameter to choose an RSA or Elliptic Curve (ECC)
        /// data key pair. KMS recommends that your use ECC key pairs for signing, and use RSA
        /// key pairs for either encryption or signing, but not both. However, KMS cannot enforce
        /// any restrictions on the use of data key pairs outside of KMS.
        /// </para>
        ///  
        /// <para>
        /// If you are using the data key pair to encrypt data, or for any operation where you
        /// don't immediately need a private key, consider using the <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. <code>GenerateDataKeyPairWithoutPlaintext</code> returns a plaintext public
        /// key and an encrypted private key, but omits the plaintext private key that you need
        /// only to decrypt ciphertext or sign a message. Later, when you need to decrypt the
        /// data or sign a message, use the <a>Decrypt</a> operation to decrypt the encrypted
        /// private key in the data key pair.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyPair</code> returns a unique data key pair for each request.
        /// The bytes in the keys are not related to the caller or the KMS key that is used to
        /// encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
        /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>. The private
        /// key is a DER-encoded PKCS8 PrivateKeyInfo, as specified in <a href="https://tools.ietf.org/html/rfc5958">RFC
        /// 5958</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPair</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPair service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyPair service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPair">REST API Reference for GenerateDataKeyPair Operation</seealso>
        public virtual GenerateDataKeyPairResponse GenerateDataKeyPair(GenerateDataKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyPairResponse>(request, options);
        }


        /// <summary>
        /// Generates a unique asymmetric data key pair. The <code>GenerateDataKeyPair</code>
        /// operation returns a plaintext public key, a plaintext private key, and a copy of the
        /// private key that is encrypted under the symmetric KMS key you specify. You can use
        /// the data key pair to perform asymmetric cryptography and implement digital signatures
        /// outside of KMS.
        /// 
        ///  
        /// <para>
        /// You can use the public key that <code>GenerateDataKeyPair</code> returns to encrypt
        /// data or verify a signature outside of KMS. Then, store the encrypted private key with
        /// the data. When you are ready to decrypt data or sign a message, you can use the <a>Decrypt</a>
        /// operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric KMS key to encrypt the private
        /// key in a data key pair. You cannot use an asymmetric KMS key or a KMS key in a custom
        /// key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>KeyPairSpec</code> parameter to choose an RSA or Elliptic Curve (ECC)
        /// data key pair. KMS recommends that your use ECC key pairs for signing, and use RSA
        /// key pairs for either encryption or signing, but not both. However, KMS cannot enforce
        /// any restrictions on the use of data key pairs outside of KMS.
        /// </para>
        ///  
        /// <para>
        /// If you are using the data key pair to encrypt data, or for any operation where you
        /// don't immediately need a private key, consider using the <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. <code>GenerateDataKeyPairWithoutPlaintext</code> returns a plaintext public
        /// key and an encrypted private key, but omits the plaintext private key that you need
        /// only to decrypt ciphertext or sign a message. Later, when you need to decrypt the
        /// data or sign a message, use the <a>Decrypt</a> operation to decrypt the encrypted
        /// private key in the data key pair.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyPair</code> returns a unique data key pair for each request.
        /// The bytes in the keys are not related to the caller or the KMS key that is used to
        /// encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
        /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>. The private
        /// key is a DER-encoded PKCS8 PrivateKeyInfo, as specified in <a href="https://tools.ietf.org/html/rfc5958">RFC
        /// 5958</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPair</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyPair service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPair">REST API Reference for GenerateDataKeyPair Operation</seealso>
        public virtual Task<GenerateDataKeyPairResponse> GenerateDataKeyPairAsync(GenerateDataKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateDataKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyPairWithoutPlaintext


        /// <summary>
        /// Generates a unique asymmetric data key pair. The <code>GenerateDataKeyPairWithoutPlaintext</code>
        /// operation returns a plaintext public key and a copy of the private key that is encrypted
        /// under the symmetric KMS key you specify. Unlike <a>GenerateDataKeyPair</a>, this operation
        /// does not return a plaintext private key. 
        /// 
        ///  
        /// <para>
        /// You can use the public key that <code>GenerateDataKeyPairWithoutPlaintext</code> returns
        /// to encrypt data or verify a signature outside of KMS. Then, store the encrypted private
        /// key with the data. When you are ready to decrypt data or sign a message, you can use
        /// the <a>Decrypt</a> operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric KMS key to encrypt the private
        /// key in a data key pair. You cannot use an asymmetric KMS key or a KMS key in a custom
        /// key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>KeyPairSpec</code> parameter to choose an RSA or Elliptic Curve (ECC)
        /// data key pair. KMS recommends that your use ECC key pairs for signing, and use RSA
        /// key pairs for either encryption or signing, but not both. However, KMS cannot enforce
        /// any restrictions on the use of data key pairs outside of KMS.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyPairWithoutPlaintext</code> returns a unique data key pair for
        /// each request. The bytes in the key are not related to the caller or KMS key that is
        /// used to encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
        /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPairWithoutPlaintext</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPairWithoutPlaintext service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyPairWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPairWithoutPlaintext">REST API Reference for GenerateDataKeyPairWithoutPlaintext Operation</seealso>
        public virtual GenerateDataKeyPairWithoutPlaintextResponse GenerateDataKeyPairWithoutPlaintext(GenerateDataKeyPairWithoutPlaintextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyPairWithoutPlaintextResponse>(request, options);
        }


        /// <summary>
        /// Generates a unique asymmetric data key pair. The <code>GenerateDataKeyPairWithoutPlaintext</code>
        /// operation returns a plaintext public key and a copy of the private key that is encrypted
        /// under the symmetric KMS key you specify. Unlike <a>GenerateDataKeyPair</a>, this operation
        /// does not return a plaintext private key. 
        /// 
        ///  
        /// <para>
        /// You can use the public key that <code>GenerateDataKeyPairWithoutPlaintext</code> returns
        /// to encrypt data or verify a signature outside of KMS. Then, store the encrypted private
        /// key with the data. When you are ready to decrypt data or sign a message, you can use
        /// the <a>Decrypt</a> operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric KMS key to encrypt the private
        /// key in a data key pair. You cannot use an asymmetric KMS key or a KMS key in a custom
        /// key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Use the <code>KeyPairSpec</code> parameter to choose an RSA or Elliptic Curve (ECC)
        /// data key pair. KMS recommends that your use ECC key pairs for signing, and use RSA
        /// key pairs for either encryption or signing, but not both. However, KMS cannot enforce
        /// any restrictions on the use of data key pairs outside of KMS.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyPairWithoutPlaintext</code> returns a unique data key pair for
        /// each request. The bytes in the key are not related to the caller or KMS key that is
        /// used to encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
        /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPairWithoutPlaintext</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPairWithoutPlaintext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyPairWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPairWithoutPlaintext">REST API Reference for GenerateDataKeyPairWithoutPlaintext Operation</seealso>
        public virtual Task<GenerateDataKeyPairWithoutPlaintextResponse> GenerateDataKeyPairWithoutPlaintextAsync(GenerateDataKeyPairWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairWithoutPlaintextResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateDataKeyPairWithoutPlaintextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext


        /// <summary>
        /// Generates a unique symmetric data key. This operation returns a data key that is encrypted
        /// under a KMS key that you specify. To request an asymmetric data key pair, use the
        /// <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a> operations.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKeyWithoutPlaintext</code> is identical to the <a>GenerateDataKey</a>
        /// operation except that returns only the encrypted copy of the data key. This operation
        /// is useful for systems that need to encrypt data at some point, but not immediately.
        /// When you need to encrypt the data, you call the <a>Decrypt</a> operation on the encrypted
        /// copy of the key. 
        /// </para>
        ///  
        /// <para>
        /// It's also useful in distributed systems with different levels of trust. For example,
        /// you might store encrypted data in containers. One component of your system creates
        /// new containers and stores an encrypted data key with each container. Then, a different
        /// component puts the data into the containers. That component first decrypts the data
        /// key, uses the plaintext data key to encrypt data, puts the encrypted data into the
        /// container, and then destroys the plaintext data key. In this system, the component
        /// that creates the containers never sees the plaintext data key.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyWithoutPlaintext</code> returns a unique data key for each request.
        /// The bytes in the keys are not related to the caller or KMS key that is used to encrypt
        /// the private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, you must specify the symmetric KMS key that is used to encrypt
        /// the data key. You cannot use an asymmetric KMS key to generate a data key. To get
        /// the type of your KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, you will find the encrypted copy of the data key in the
        /// <code>CiphertextBlob</code> field.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyWithoutPlaintext</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public virtual GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyWithoutPlaintextResponse>(request, options);
        }


        /// <summary>
        /// Generates a unique symmetric data key. This operation returns a data key that is encrypted
        /// under a KMS key that you specify. To request an asymmetric data key pair, use the
        /// <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a> operations.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKeyWithoutPlaintext</code> is identical to the <a>GenerateDataKey</a>
        /// operation except that returns only the encrypted copy of the data key. This operation
        /// is useful for systems that need to encrypt data at some point, but not immediately.
        /// When you need to encrypt the data, you call the <a>Decrypt</a> operation on the encrypted
        /// copy of the key. 
        /// </para>
        ///  
        /// <para>
        /// It's also useful in distributed systems with different levels of trust. For example,
        /// you might store encrypted data in containers. One component of your system creates
        /// new containers and stores an encrypted data key with each container. Then, a different
        /// component puts the data into the containers. That component first decrypts the data
        /// key, uses the plaintext data key to encrypt data, puts the encrypted data into the
        /// container, and then destroys the plaintext data key. In this system, the component
        /// that creates the containers never sees the plaintext data key.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyWithoutPlaintext</code> returns a unique data key for each request.
        /// The bytes in the keys are not related to the caller or KMS key that is used to encrypt
        /// the private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, you must specify the symmetric KMS key that is used to encrypt
        /// the data key. You cannot use an asymmetric KMS key to generate a data key. To get
        /// the type of your KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, you will find the encrypted copy of the data key in the
        /// <code>CiphertextBlob</code> field.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyWithoutPlaintext</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public virtual Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateDataKeyWithoutPlaintextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateRandom


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in KMS. To generate the byte string
        /// in the CloudHSM cluster that is associated with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
        /// Management Service Cryptographic Details</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
        /// (IAM policy)
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual GenerateRandomResponse GenerateRandom(int numberOfBytes)
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandom(request);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in KMS. To generate the byte string
        /// in the CloudHSM cluster that is associated with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
        /// Management Service Cryptographic Details</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
        /// (IAM policy)
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRandomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return Invoke<GenerateRandomResponse>(request, options);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in KMS. To generate the byte string
        /// in the CloudHSM cluster that is associated with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
        /// Management Service Cryptographic Details</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
        /// (IAM policy)
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(int numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandomAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in KMS. To generate the byte string
        /// in the CloudHSM cluster that is associated with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// Applications in Amazon Web Services Nitro Enclaves can call this operation by using
        /// the <a href="https://github.com/aws/aws-nitro-enclaves-sdk-c">Amazon Web Services
        /// Nitro Enclaves Development Kit</a>. For information about the supporting parameters,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/services-nitro-enclaves.html">How
        /// Amazon Web Services Nitro Enclaves use KMS</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/cryptographic-details/">Key
        /// Management Service Cryptographic Details</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
        /// (IAM policy)
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRandomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRandomResponseUnmarshaller.Instance;
            
            return InvokeAsync<GenerateRandomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPolicy


        /// <summary>
        /// Gets a key policy attached to the specified KMS key.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>PutKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Gets the key policy for the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual GetKeyPolicyResponse GetKeyPolicy(string keyId, string policyName)
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicy(request);
        }


        /// <summary>
        /// Gets a key policy attached to the specified KMS key.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>PutKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<GetKeyPolicyResponse>(request, options);
        }


        /// <summary>
        /// Gets a key policy attached to the specified KMS key.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>PutKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Gets the key policy for the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets a key policy attached to the specified KMS key.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>PutKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetKeyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyRotationStatus


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. The key rotation status for these KMS
        /// keys is always <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a KMS key. However,
        /// while the KMS key is disabled, KMS does not rotate the key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a KMS key is pending deletion, its key rotation status is
        /// <code>false</code> and KMS does not rotate the key material. If you cancel the deletion,
        /// the original key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyRotationStatus</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Gets the rotation status for the specified KMS key. Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual GetKeyRotationStatusResponse GetKeyRotationStatus(string keyId)
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatus(request);
        }


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. The key rotation status for these KMS
        /// keys is always <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a KMS key. However,
        /// while the KMS key is disabled, KMS does not rotate the key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a KMS key is pending deletion, its key rotation status is
        /// <code>false</code> and KMS does not rotate the key material. If you cancel the deletion,
        /// the original key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyRotationStatus</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return Invoke<GetKeyRotationStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. The key rotation status for these KMS
        /// keys is always <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a KMS key. However,
        /// while the KMS key is disabled, KMS does not rotate the key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a KMS key is pending deletion, its key rotation status is
        /// <code>false</code> and KMS does not rotate the key material. If you cancel the deletion,
        /// the original key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyRotationStatus</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Gets the rotation status for the specified KMS key. Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatusAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified KMS key.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-replica-key">multi-Region
        /// keys</a>, set the property on the primary key. The key rotation status for these KMS
        /// keys is always <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a KMS key. However,
        /// while the KMS key is disabled, KMS does not rotate the key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a KMS key is pending deletion, its key rotation status is
        /// <code>false</code> and KMS does not rotate the key material. If you cancel the deletion,
        /// the original key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyRotationStatus</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetKeyRotationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParametersForImport


        /// <summary>
        /// Returns the items you need to import key material into a symmetric, customer managed
        /// KMS key. For more information about importing key material into KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation returns a public key and an import token. Use the public key to encrypt
        /// the symmetric key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// You must specify the key ID of the symmetric KMS key into which you will import key
        /// material. This KMS key's <code>Origin</code> must be <code>EXTERNAL</code>. You must
        /// also specify the wrapping algorithm and type of wrapping key (public key) that you
        /// will use to encrypt the key material. You cannot perform this operation on an asymmetric
        /// KMS key or on any KMS key in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// To import key material, you must use the public key and import token from the same
        /// response. These items are valid for 24 hours. The expiration date and time appear
        /// in the <code>GetParametersForImport</code> response. You cannot use an expired token
        /// in an <a>ImportKeyMaterial</a> request. If your key and token expire, send another
        /// <code>GetParametersForImport</code> request.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetParametersForImport</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public virtual GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return Invoke<GetParametersForImportResponse>(request, options);
        }


        /// <summary>
        /// Returns the items you need to import key material into a symmetric, customer managed
        /// KMS key. For more information about importing key material into KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation returns a public key and an import token. Use the public key to encrypt
        /// the symmetric key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// You must specify the key ID of the symmetric KMS key into which you will import key
        /// material. This KMS key's <code>Origin</code> must be <code>EXTERNAL</code>. You must
        /// also specify the wrapping algorithm and type of wrapping key (public key) that you
        /// will use to encrypt the key material. You cannot perform this operation on an asymmetric
        /// KMS key or on any KMS key in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// To import key material, you must use the public key and import token from the same
        /// response. These items are valid for 24 hours. The expiration date and time appear
        /// in the <code>GetParametersForImport</code> response. You cannot use an expired token
        /// in an <a>ImportKeyMaterial</a> request. If your key and token expire, send another
        /// <code>GetParametersForImport</code> request.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetParametersForImport</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public virtual Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetParametersForImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKey


        /// <summary>
        /// Returns the public key of an asymmetric KMS key. Unlike the private key of a asymmetric
        /// KMS key, which never leaves KMS unencrypted, callers with <code>kms:GetPublicKey</code>
        /// permission can download the public key of an asymmetric KMS key. You can share the
        /// public key to allow others to encrypt messages and verify signatures outside of KMS.
        /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You do not need to download the public key. Instead, you can use the public key within
        /// KMS by calling the <a>Encrypt</a>, <a>ReEncrypt</a>, or <a>Verify</a> operations with
        /// the identifier of an asymmetric KMS key. When you use the public key within KMS, you
        /// benefit from the authentication, authorization, and logging that are part of every
        /// KMS operation. You also reduce of risk of encrypting data that cannot be decrypted.
        /// These features are not effective outside of KMS. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/download-public-key.html#download-public-key-considerations">Special
        /// Considerations for Downloading Public Keys</a>.
        /// </para>
        ///  
        /// <para>
        /// To help you use the public key safely outside of KMS, <code>GetPublicKey</code> returns
        /// important information about the public key in the response, including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeySpec">KeySpec</a>:
        /// The type of key material in the public key, such as <code>RSA_4096</code> or <code>ECC_NIST_P521</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeyUsage">KeyUsage</a>:
        /// Whether the key is used for encryption or signing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-EncryptionAlgorithms">EncryptionAlgorithms</a>
        /// or <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-SigningAlgorithms">SigningAlgorithms</a>:
        /// A list of the encryption algorithms or the signing algorithms for the key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Although KMS cannot enforce these restrictions on external operations, it is crucial
        /// that you use this information to prevent the public key from being used improperly.
        /// For example, you can prevent a public signing key from being used encrypt data, or
        /// prevent a public key from being used with an encryption algorithm that is not supported
        /// by KMS. You can also avoid errors, such as using the wrong signing algorithm in a
        /// verification operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetPublicKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>CreateKey</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyResponse>(request, options);
        }


        /// <summary>
        /// Returns the public key of an asymmetric KMS key. Unlike the private key of a asymmetric
        /// KMS key, which never leaves KMS unencrypted, callers with <code>kms:GetPublicKey</code>
        /// permission can download the public key of an asymmetric KMS key. You can share the
        /// public key to allow others to encrypt messages and verify signatures outside of KMS.
        /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You do not need to download the public key. Instead, you can use the public key within
        /// KMS by calling the <a>Encrypt</a>, <a>ReEncrypt</a>, or <a>Verify</a> operations with
        /// the identifier of an asymmetric KMS key. When you use the public key within KMS, you
        /// benefit from the authentication, authorization, and logging that are part of every
        /// KMS operation. You also reduce of risk of encrypting data that cannot be decrypted.
        /// These features are not effective outside of KMS. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/download-public-key.html#download-public-key-considerations">Special
        /// Considerations for Downloading Public Keys</a>.
        /// </para>
        ///  
        /// <para>
        /// To help you use the public key safely outside of KMS, <code>GetPublicKey</code> returns
        /// important information about the public key in the response, including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeySpec">KeySpec</a>:
        /// The type of key material in the public key, such as <code>RSA_4096</code> or <code>ECC_NIST_P521</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeyUsage">KeyUsage</a>:
        /// Whether the key is used for encryption or signing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-EncryptionAlgorithms">EncryptionAlgorithms</a>
        /// or <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-SigningAlgorithms">SigningAlgorithms</a>:
        /// A list of the encryption algorithms or the signing algorithms for the key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Although KMS cannot enforce these restrictions on external operations, it is crucial
        /// that you use this information to prevent the public key from being used improperly.
        /// For example, you can prevent a public signing key from being used encrypt data, or
        /// prevent a public key from being used with an encryption algorithm that is not supported
        /// by KMS. You can also avoid errors, such as using the wrong signing algorithm in a
        /// verification operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetPublicKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>CreateKey</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyMaterial


        /// <summary>
        /// Imports key material into an existing symmetric KMS KMS key that was created without
        /// key material. After you successfully import key material into a KMS key, you can <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#reimport-key-material">reimport
        /// the same key material</a> into that KMS key, but you cannot import different key material.
        /// 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on an asymmetric KMS key or on any KMS key in a
        /// different Amazon Web Services account. For more information about creating KMS keys
        /// with no key material and then importing key material, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before using this operation, call <a>GetParametersForImport</a>. Its response includes
        /// a public key and an import token. Use the public key to encrypt the key material.
        /// Then, submit the import token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  
        /// <para>
        /// When calling this operation, you must specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key ID or key ARN of a KMS key with no key material. Its <code>Origin</code> must
        /// be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a KMS key with no key material, call <a>CreateKey</a> and set the value
        /// of its <code>Origin</code> parameter to <code>EXTERNAL</code>. To get the <code>Origin</code>
        /// of a KMS key, call <a>DescribeKey</a>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encrypted key material. To get the public key to encrypt the key material, call
        /// <a>GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The import token that <a>GetParametersForImport</a> returned. You must use a public
        /// key and token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether the key material expires and if so, when. If you set an expiration date, KMS
        /// deletes the key material from the KMS key on the specified date, and the KMS key becomes
        /// unusable. To use the KMS key again, you must reimport the same key material. The only
        /// way to change an expiration date is by reimporting the same key material and specifying
        /// a new expiration date. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, the key state of the KMS key changes from <code>PendingImport</code>
        /// to <code>Enabled</code>, and you can use the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If this operation fails, use the exception to help determine the problem. If the error
        /// is related to the key material, the import token, or wrapping key, use <a>GetParametersForImport</a>
        /// to get a new public key and import token for the KMS key and repeat the import procedure.
        /// For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#importing-keys-overview">How
        /// To Import Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ImportKeyMaterial</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial service method.</param>
        /// 
        /// <returns>The response from the ImportKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.ExpiredImportTokenException">
        /// The request was rejected because the specified import token is expired. Use <a>GetParametersForImport</a>
        /// to get a new import token and public key, use the new public key to encrypt the key
        /// material, and then try the request again.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyMaterialException">
        /// The request was rejected because the key material in the request is, expired, invalid,
        /// or is not the same key material that was previously imported into this KMS key.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidImportTokenException">
        /// The request was rejected because the provided import token is invalid or is associated
        /// with a different KMS key.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public virtual ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<ImportKeyMaterialResponse>(request, options);
        }


        /// <summary>
        /// Imports key material into an existing symmetric KMS KMS key that was created without
        /// key material. After you successfully import key material into a KMS key, you can <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#reimport-key-material">reimport
        /// the same key material</a> into that KMS key, but you cannot import different key material.
        /// 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on an asymmetric KMS key or on any KMS key in a
        /// different Amazon Web Services account. For more information about creating KMS keys
        /// with no key material and then importing key material, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before using this operation, call <a>GetParametersForImport</a>. Its response includes
        /// a public key and an import token. Use the public key to encrypt the key material.
        /// Then, submit the import token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  
        /// <para>
        /// When calling this operation, you must specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key ID or key ARN of a KMS key with no key material. Its <code>Origin</code> must
        /// be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a KMS key with no key material, call <a>CreateKey</a> and set the value
        /// of its <code>Origin</code> parameter to <code>EXTERNAL</code>. To get the <code>Origin</code>
        /// of a KMS key, call <a>DescribeKey</a>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encrypted key material. To get the public key to encrypt the key material, call
        /// <a>GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The import token that <a>GetParametersForImport</a> returned. You must use a public
        /// key and token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether the key material expires and if so, when. If you set an expiration date, KMS
        /// deletes the key material from the KMS key on the specified date, and the KMS key becomes
        /// unusable. To use the KMS key again, you must reimport the same key material. The only
        /// way to change an expiration date is by reimporting the same key material and specifying
        /// a new expiration date. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, the key state of the KMS key changes from <code>PendingImport</code>
        /// to <code>Enabled</code>, and you can use the KMS key.
        /// </para>
        ///  
        /// <para>
        /// If this operation fails, use the exception to help determine the problem. If the error
        /// is related to the key material, the import token, or wrapping key, use <a>GetParametersForImport</a>
        /// to get a new public key and import token for the KMS key and repeat the import procedure.
        /// For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#importing-keys-overview">How
        /// To Import Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ImportKeyMaterial</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.ExpiredImportTokenException">
        /// The request was rejected because the specified import token is expired. Use <a>GetParametersForImport</a>
        /// to get a new import token and public key, use the new public key to encrypt the key
        /// material, and then try the request again.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyMaterialException">
        /// The request was rejected because the key material in the request is, expired, invalid,
        /// or is not the same key material that was previously imported into this KMS key.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidImportTokenException">
        /// The request was rejected because the provided import token is invalid or is associated
        /// with a different KMS key.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public virtual Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportKeyMaterialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Gets a list of aliases in the caller's Amazon Web Services account and region. For
        /// more information about aliases, see <a>CreateAlias</a>.
        /// 
        ///  
        /// <para>
        /// By default, the <code>ListAliases</code> operation returns all aliases in the account
        /// and region. To get only the aliases associated with a particular KMS key, use the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// The <code>ListAliases</code> response can include aliases that you created and associated
        /// with your customer managed keys, and aliases that Amazon Web Services created and
        /// associated with Amazon Web Services managed keys in your account. You can recognize
        /// Amazon Web Services aliases because their names have the format <code>aws/&lt;service-name&gt;</code>,
        /// such as <code>aws/dynamodb</code>.
        /// </para>
        ///  
        /// <para>
        /// The response might also include aliases that have no <code>TargetKeyId</code> field.
        /// These are predefined aliases that Amazon Web Services has created but has not yet
        /// associated with a KMS key. Aliases that Amazon Web Services creates in your account,
        /// including predefined aliases, do not count against your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#aliases-limit">KMS
        /// aliases quota</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. <code>ListAliases</code> does not return aliases in
        /// other Amazon Web Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListAliases</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of aliases in the caller's Amazon Web Services account and region. For
        /// more information about aliases, see <a>CreateAlias</a>.
        /// 
        ///  
        /// <para>
        /// By default, the <code>ListAliases</code> operation returns all aliases in the account
        /// and region. To get only the aliases associated with a particular KMS key, use the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// The <code>ListAliases</code> response can include aliases that you created and associated
        /// with your customer managed keys, and aliases that Amazon Web Services created and
        /// associated with Amazon Web Services managed keys in your account. You can recognize
        /// Amazon Web Services aliases because their names have the format <code>aws/&lt;service-name&gt;</code>,
        /// such as <code>aws/dynamodb</code>.
        /// </para>
        ///  
        /// <para>
        /// The response might also include aliases that have no <code>TargetKeyId</code> field.
        /// These are predefined aliases that Amazon Web Services has created but has not yet
        /// associated with a KMS key. Aliases that Amazon Web Services creates in your account,
        /// including predefined aliases, do not count against your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#aliases-limit">KMS
        /// aliases quota</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. <code>ListAliases</code> does not return aliases in
        /// other Amazon Web Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListAliases</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGrants


        /// <summary>
        /// Gets a list of all grants for the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// You must specify the KMS key in all requests. You can filter the grant list by grant
        /// ID or grantee principal.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>GranteePrincipal</code> field in the <code>ListGrants</code> response usually
        /// contains the user or role designated as the grantee principal in the grant. However,
        /// when the grantee principal in the grant is an Amazon Web Services service, the <code>GranteePrincipal</code>
        /// field contains the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a>, which might represent several different grantee principals.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListGrants</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public virtual ListGrantsResponse ListGrants(ListGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return Invoke<ListGrantsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of all grants for the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// You must specify the KMS key in all requests. You can filter the grant list by grant
        /// ID or grantee principal.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>GranteePrincipal</code> field in the <code>ListGrants</code> response usually
        /// contains the user or role designated as the grantee principal in the grant. However,
        /// when the grantee principal in the grant is an Amazon Web Services service, the <code>GranteePrincipal</code>
        /// field contains the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a>, which might represent several different grantee principals.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListGrants</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public virtual Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGrantsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPolicies


        /// <summary>
        /// Gets the names of the key policies that are attached to a KMS key. This operation
        /// is designed to get policy names that you can use in a <a>GetKeyPolicy</a> operation.
        /// However, the only valid policy name is <code>default</code>. 
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeyPolicies</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutKeyPolicy</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public virtual ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListKeyPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Gets the names of the key policies that are attached to a KMS key. This operation
        /// is designed to get policy names that you can use in a <a>GetKeyPolicy</a> operation.
        /// However, the only valid policy name is <code>default</code>. 
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeyPolicies</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutKeyPolicy</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public virtual Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListKeyPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Gets a list of all KMS keys in the caller's Amazon Web Services account and Region.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeys</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of all KMS keys in the caller's Amazon Web Services account and Region.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeys</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceTags


        /// <summary>
        /// Returns all tags on the specified KMS key.
        /// 
        ///  
        /// <para>
        /// For general information about tags, including the format and syntax, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListResourceTags</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags service method.</param>
        /// 
        /// <returns>The response from the ListResourceTags service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public virtual ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return Invoke<ListResourceTagsResponse>(request, options);
        }


        /// <summary>
        /// Returns all tags on the specified KMS key.
        /// 
        ///  
        /// <para>
        /// For general information about tags, including the format and syntax, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListResourceTags</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTags service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public virtual Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourceTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRetirableGrants


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. However, this operation can return grants in any Amazon Web Services account.
        /// You do not need <code>kms:ListRetirableGrants</code> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. Enter a principal in your Amazon Web Services account. To specify the retiring principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an Amazon Web Services principal. Valid Amazon Web Services principals include Amazon Web Services accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">Amazon Web Services Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual ListRetirableGrantsResponse ListRetirableGrants(string retiringPrincipal)
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrants(request);
        }


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. However, this operation can return grants in any Amazon Web Services account.
        /// You do not need <code>kms:ListRetirableGrants</code> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual ListRetirableGrantsResponse ListRetirableGrants()
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrants(request);
        }


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. However, this operation can return grants in any Amazon Web Services account.
        /// You do not need <code>kms:ListRetirableGrants</code> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetirableGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return Invoke<ListRetirableGrantsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. However, this operation can return grants in any Amazon Web Services account.
        /// You do not need <code>kms:ListRetirableGrants</code> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. Enter a principal in your Amazon Web Services account. To specify the retiring principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an Amazon Web Services principal. Valid Amazon Web Services principals include Amazon Web Services accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">Amazon Web Services Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. However, this operation can return grants in any Amazon Web Services account.
        /// You do not need <code>kms:ListRetirableGrants</code> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. However, this operation can return grants in any Amazon Web Services account.
        /// You do not need <code>kms:ListRetirableGrants</code> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetirableGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRetirableGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutKeyPolicy


        /// <summary>
        /// Attaches a key policy to the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
        /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>. For examples of adding a key policy in multiple programming languages, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-key-policies.html#put-policy">Setting
        /// a key policy</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Sets the key policy on the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the KMS key. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the KMS key. This reduces the risk that the KMS key becomes unmanageable. For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to KMS. When you create a new Amazon Web Services principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to KMS. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>Amazon Web Services Identity and Access Management User Guide</i>. </li> </ul> The key policy cannot exceed 32 kilobytes (32768 bytes). For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/resource-limits.html">Resource Quotas</a> in the <i>Key Management Service Developer Guide</i>.</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual PutKeyPolicyResponse PutKeyPolicy(string keyId, string policy, string policyName)
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicy(request);
        }


        /// <summary>
        /// Attaches a key policy to the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
        /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>. For examples of adding a key policy in multiple programming languages, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-key-policies.html#put-policy">Setting
        /// a key policy</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<PutKeyPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches a key policy to the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
        /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>. For examples of adding a key policy in multiple programming languages, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-key-policies.html#put-policy">Setting
        /// a key policy</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="keyId">Sets the key policy on the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the KMS key. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the KMS key. This reduces the risk that the KMS key becomes unmanageable. For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to KMS. When you create a new Amazon Web Services principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to KMS. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>Amazon Web Services Identity and Access Management User Guide</i>. </li> </ul> The key policy cannot exceed 32 kilobytes (32768 bytes). For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/resource-limits.html">Resource Quotas</a> in the <i>Key Management Service Developer Guide</i>.</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Attaches a key policy to the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
        /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>. For examples of adding a key policy in multiple programming languages, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-key-policies.html#put-policy">Setting
        /// a key policy</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutKeyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReEncrypt


        /// <summary>
        /// Decrypts ciphertext and then reencrypts it entirely within KMS. You can use this operation
        /// to change the KMS key under which data is encrypted, such as when you <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-manually">manually
        /// rotate</a> a KMS key or change the KMS key that protects a ciphertext. You can also
        /// use it to reencrypt ciphertext under the same KMS key, such as to change the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
        /// context</a> of a ciphertext.
        /// 
        ///  
        /// <para>
        /// The <code>ReEncrypt</code> operation can decrypt ciphertext that was encrypted by
        /// using an KMS KMS key in an KMS operation, such as <a>Encrypt</a> or <a>GenerateDataKey</a>.
        /// It can also decrypt ciphertext that was encrypted by using the public key of an <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS key</a> outside of KMS. However, it cannot decrypt ciphertext produced by other
        /// libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
        /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with KMS.
        /// </para>
        ///  
        /// <para>
        /// When you use the <code>ReEncrypt</code> operation, you need to provide information
        /// for the decrypt operation and the subsequent encrypt operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If your ciphertext was encrypted under an asymmetric KMS key, you must use the <code>SourceKeyId</code>
        /// parameter to identify the KMS key that encrypted the ciphertext. You must also supply
        /// the encryption algorithm that was used. This information is required to decrypt the
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your ciphertext was encrypted under a symmetric KMS key, the <code>SourceKeyId</code>
        /// parameter is optional. KMS can get this information from metadata that it adds to
        /// the symmetric ciphertext blob. This feature adds durability to your implementation
        /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
        /// even if they've lost track of the key ID. However, specifying the source KMS key is
        /// always recommended as a best practice. When you use the <code>SourceKeyId</code> parameter
        /// to specify a KMS key, KMS uses only the KMS key you specify. If the ciphertext was
        /// encrypted under a different KMS key, the <code>ReEncrypt</code> operation fails. This
        /// practice ensures that you use the KMS key that you intend.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To reencrypt the data, you must use the <code>DestinationKeyId</code> parameter specify
        /// the KMS key that re-encrypts the data after it is decrypted. You can select a symmetric
        /// or asymmetric KMS key. If the destination KMS key is an asymmetric KMS key, you must
        /// also provide the encryption algorithm. The algorithm that you choose must be compatible
        /// with the KMS key.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
        /// the KMS key and encryption algorithm that you choose. You will be required to provide
        /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
        /// and algorithm do not match the values used to encrypt the data, the decrypt operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the key ID and encryption algorithm when you decrypt
        /// with symmetric KMS keys because KMS stores this information in the ciphertext blob.
        /// KMS cannot store metadata in ciphertext generated with asymmetric keys. The standard
        /// format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. The source KMS key and destination KMS key can be
        /// in different Amazon Web Services accounts. Either or both KMS keys can be in a different
        /// account than the caller. To specify a KMS key in a different account, you must use
        /// its key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptFrom</a>
        /// permission on the source KMS key (key policy)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptTo</a>
        /// permission on the destination KMS key (key policy)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To permit reencryption from or to a KMS key, include the <code>"kms:ReEncrypt*"</code>
        /// permission in your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>. This permission is automatically included in the key policy when you use
        /// the console to create a KMS key. But you must include it manually when you create
        /// a KMS key programmatically or when you use the <a>PutKeyPolicy</a> operation to set
        /// a key policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified KMS key cannot decrypt the data. The
        /// <code>KeyId</code> in a <a>Decrypt</a> request and the <code>SourceKeyId</code> in
        /// a <a>ReEncrypt</a> request must identify the same KMS key that was used to encrypt
        /// the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public virtual ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return Invoke<ReEncryptResponse>(request, options);
        }


        /// <summary>
        /// Decrypts ciphertext and then reencrypts it entirely within KMS. You can use this operation
        /// to change the KMS key under which data is encrypted, such as when you <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-manually">manually
        /// rotate</a> a KMS key or change the KMS key that protects a ciphertext. You can also
        /// use it to reencrypt ciphertext under the same KMS key, such as to change the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
        /// context</a> of a ciphertext.
        /// 
        ///  
        /// <para>
        /// The <code>ReEncrypt</code> operation can decrypt ciphertext that was encrypted by
        /// using an KMS KMS key in an KMS operation, such as <a>Encrypt</a> or <a>GenerateDataKey</a>.
        /// It can also decrypt ciphertext that was encrypted by using the public key of an <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/symm-asymm-concepts.html#asymmetric-cmks">asymmetric
        /// KMS key</a> outside of KMS. However, it cannot decrypt ciphertext produced by other
        /// libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
        /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with KMS.
        /// </para>
        ///  
        /// <para>
        /// When you use the <code>ReEncrypt</code> operation, you need to provide information
        /// for the decrypt operation and the subsequent encrypt operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If your ciphertext was encrypted under an asymmetric KMS key, you must use the <code>SourceKeyId</code>
        /// parameter to identify the KMS key that encrypted the ciphertext. You must also supply
        /// the encryption algorithm that was used. This information is required to decrypt the
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your ciphertext was encrypted under a symmetric KMS key, the <code>SourceKeyId</code>
        /// parameter is optional. KMS can get this information from metadata that it adds to
        /// the symmetric ciphertext blob. This feature adds durability to your implementation
        /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
        /// even if they've lost track of the key ID. However, specifying the source KMS key is
        /// always recommended as a best practice. When you use the <code>SourceKeyId</code> parameter
        /// to specify a KMS key, KMS uses only the KMS key you specify. If the ciphertext was
        /// encrypted under a different KMS key, the <code>ReEncrypt</code> operation fails. This
        /// practice ensures that you use the KMS key that you intend.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To reencrypt the data, you must use the <code>DestinationKeyId</code> parameter specify
        /// the KMS key that re-encrypts the data after it is decrypted. You can select a symmetric
        /// or asymmetric KMS key. If the destination KMS key is an asymmetric KMS key, you must
        /// also provide the encryption algorithm. The algorithm that you choose must be compatible
        /// with the KMS key.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
        /// the KMS key and encryption algorithm that you choose. You will be required to provide
        /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
        /// and algorithm do not match the values used to encrypt the data, the decrypt operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the key ID and encryption algorithm when you decrypt
        /// with symmetric KMS keys because KMS stores this information in the ciphertext blob.
        /// KMS cannot store metadata in ciphertext generated with asymmetric keys. The standard
        /// format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. The source KMS key and destination KMS key can be
        /// in different Amazon Web Services accounts. Either or both KMS keys can be in a different
        /// account than the caller. To specify a KMS key in a different account, you must use
        /// its key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptFrom</a>
        /// permission on the source KMS key (key policy)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptTo</a>
        /// permission on the destination KMS key (key policy)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To permit reencryption from or to a KMS key, include the <code>"kms:ReEncrypt*"</code>
        /// permission in your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>. This permission is automatically included in the key policy when you use
        /// the console to create a KMS key. But you must include it manually when you create
        /// a KMS key programmatically or when you use the <a>PutKeyPolicy</a> operation to set
        /// a key policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified KMS key cannot decrypt the data. The
        /// <code>KeyId</code> in a <a>Decrypt</a> request and the <code>SourceKeyId</code> in
        /// a <a>ReEncrypt</a> request must identify the same KMS key that was used to encrypt
        /// the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public virtual Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReEncryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplicateKey


        /// <summary>
        /// Replicates a multi-Region key into the specified Region. This operation creates a
        /// multi-Region replica key based on a multi-Region primary key in a different Region
        /// of the same Amazon Web Services partition. You can create multiple replicas of a primary
        /// key, but each must be in a different Region. To create a multi-Region primary key,
        /// use the <a>CreateKey</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A <i>replica key</i> is a fully-functional KMS key that can be used independently
        /// of its primary and peer replica keys. A primary key and its replica keys share properties
        /// that make them interoperable. They have the same <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
        /// ID</a> and key material. They also have the same <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-spec">key
        /// spec</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-usage">key
        /// usage</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-origin">key
        /// material origin</a>, and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// key rotation status</a>. KMS automatically synchronizes these shared properties among
        /// related multi-Region keys. All other properties of a replica key can differ, including
        /// its <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">tags</a>,
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">aliases</a>,
        /// and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">key
        /// state</a>. KMS pricing and quotas for KMS keys apply to each primary key and replica
        /// key.
        /// </para>
        ///  
        /// <para>
        /// When this operation completes, the new replica key has a transient key state of <code>Creating</code>.
        /// This key state changes to <code>Enabled</code> (or <code>PendingImport</code>) after
        /// a few seconds when the process of creating the new replica key is complete. While
        /// the key state is <code>Creating</code>, you can manage key, but you cannot yet use
        /// it in cryptographic operations. If you are creating and using the replica key programmatically,
        /// retry on <code>KMSInvalidStateException</code> or call <code>DescribeKey</code> to
        /// check its <code>KeyState</code> value before using it. For details about the <code>Creating</code>
        /// key state, see <a href="kms/latest/developerguide/key-state.html">Key state: Effect
        /// on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CloudTrail log of a <code>ReplicateKey</code> operation records a <code>ReplicateKey</code>
        /// operation in the primary key's Region and a <a>CreateKey</a> operation in the replica
        /// key's Region.
        /// </para>
        ///  
        /// <para>
        /// If you replicate a multi-Region primary key with imported key material, the replica
        /// key is created with no key material. You must import the same key material that you
        /// imported into the primary key. For details, see <a href="kms/latest/developerguide/multi-region-keys-import.html">Importing
        /// key material into multi-Region keys</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To convert a replica key to a primary key, use the <a>UpdatePrimaryRegion</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>ReplicateKey</code> uses different default values for the <code>KeyPolicy</code>
        /// and <code>Tags</code> parameters than those used in the KMS console. For details,
        /// see the parameter descriptions.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation to create a replica key
        /// in a different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>kms:ReplicateKey</code> on the primary key (in the primary key's Region). Include
        /// this permission in the primary key's key policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kms:CreateKey</code> in an IAM policy in the replica Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use the <code>Tags</code> parameter, <code>kms:TagResource</code> in an IAM policy
        /// in the replica Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdatePrimaryRegion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateKey service method.</param>
        /// 
        /// <returns>The response from the ReplicateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReplicateKey">REST API Reference for ReplicateKey Operation</seealso>
        public virtual ReplicateKeyResponse ReplicateKey(ReplicateKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplicateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplicateKeyResponseUnmarshaller.Instance;

            return Invoke<ReplicateKeyResponse>(request, options);
        }


        /// <summary>
        /// Replicates a multi-Region key into the specified Region. This operation creates a
        /// multi-Region replica key based on a multi-Region primary key in a different Region
        /// of the same Amazon Web Services partition. You can create multiple replicas of a primary
        /// key, but each must be in a different Region. To create a multi-Region primary key,
        /// use the <a>CreateKey</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A <i>replica key</i> is a fully-functional KMS key that can be used independently
        /// of its primary and peer replica keys. A primary key and its replica keys share properties
        /// that make them interoperable. They have the same <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
        /// ID</a> and key material. They also have the same <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-spec">key
        /// spec</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-usage">key
        /// usage</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-origin">key
        /// material origin</a>, and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// key rotation status</a>. KMS automatically synchronizes these shared properties among
        /// related multi-Region keys. All other properties of a replica key can differ, including
        /// its <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">tags</a>,
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">aliases</a>,
        /// and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">key
        /// state</a>. KMS pricing and quotas for KMS keys apply to each primary key and replica
        /// key.
        /// </para>
        ///  
        /// <para>
        /// When this operation completes, the new replica key has a transient key state of <code>Creating</code>.
        /// This key state changes to <code>Enabled</code> (or <code>PendingImport</code>) after
        /// a few seconds when the process of creating the new replica key is complete. While
        /// the key state is <code>Creating</code>, you can manage key, but you cannot yet use
        /// it in cryptographic operations. If you are creating and using the replica key programmatically,
        /// retry on <code>KMSInvalidStateException</code> or call <code>DescribeKey</code> to
        /// check its <code>KeyState</code> value before using it. For details about the <code>Creating</code>
        /// key state, see <a href="kms/latest/developerguide/key-state.html">Key state: Effect
        /// on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CloudTrail log of a <code>ReplicateKey</code> operation records a <code>ReplicateKey</code>
        /// operation in the primary key's Region and a <a>CreateKey</a> operation in the replica
        /// key's Region.
        /// </para>
        ///  
        /// <para>
        /// If you replicate a multi-Region primary key with imported key material, the replica
        /// key is created with no key material. You must import the same key material that you
        /// imported into the primary key. For details, see <a href="kms/latest/developerguide/multi-region-keys-import.html">Importing
        /// key material into multi-Region keys</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To convert a replica key to a primary key, use the <a>UpdatePrimaryRegion</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>ReplicateKey</code> uses different default values for the <code>KeyPolicy</code>
        /// and <code>Tags</code> parameters than those used in the KMS console. For details,
        /// see the parameter descriptions.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation to create a replica key
        /// in a different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>kms:ReplicateKey</code> on the primary key (in the primary key's Region). Include
        /// this permission in the primary key's key policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kms:CreateKey</code> in an IAM policy in the replica Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use the <code>Tags</code> parameter, <code>kms:TagResource</code> in an IAM policy
        /// in the replica Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdatePrimaryRegion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplicateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReplicateKey">REST API Reference for ReplicateKey Operation</seealso>
        public virtual Task<ReplicateKeyResponse> ReplicateKeyAsync(ReplicateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplicateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplicateKeyResponseUnmarshaller.Instance;
            
            return InvokeAsync<ReplicateKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetireGrant


        /// <summary>
        /// Deletes a grant. Typically, you retire a grant when you no longer need its permissions.
        /// To identify the grant to retire, use a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">grant
        /// token</a>, or both the grant ID and a key identifier (key ID or key ARN) of the KMS
        /// key. The <a>CreateGrant</a> operation returns both values.
        /// 
        ///  
        /// <para>
        /// This operation can be called by the <i>retiring principal</i> for a grant, by the
        /// <i>grantee principal</i> if the grant allows the <code>RetireGrant</code> operation,
        /// and by the Amazon Web Services account (root user) in which the grant is created.
        /// It can also be called by principals to whom permission for retiring a grant is delegated.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. You can retire a grant on a KMS key in a different
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions:</b>:Permission to retire a grant is determined primarily
        /// by the grant. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="grantToken">Identifies the grant to be retired. You can use a grant token to identify a new grant even before it has achieved eventual consistency. Only the <a>CreateGrant</a> operation returns a grant token. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual consistency</a> in the <i>Key Management Service Developer Guide</i>.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual RetireGrantResponse RetireGrant(string grantToken)
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrant(request);
        }


        /// <summary>
        /// Deletes a grant. Typically, you retire a grant when you no longer need its permissions.
        /// To identify the grant to retire, use a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">grant
        /// token</a>, or both the grant ID and a key identifier (key ID or key ARN) of the KMS
        /// key. The <a>CreateGrant</a> operation returns both values.
        /// 
        ///  
        /// <para>
        /// This operation can be called by the <i>retiring principal</i> for a grant, by the
        /// <i>grantee principal</i> if the grant allows the <code>RetireGrant</code> operation,
        /// and by the Amazon Web Services account (root user) in which the grant is created.
        /// It can also be called by principals to whom permission for retiring a grant is delegated.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. You can retire a grant on a KMS key in a different
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions:</b>:Permission to retire a grant is determined primarily
        /// by the grant. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual RetireGrantResponse RetireGrant(RetireGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetireGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return Invoke<RetireGrantResponse>(request, options);
        }


        /// <summary>
        /// Deletes a grant. Typically, you retire a grant when you no longer need its permissions.
        /// To identify the grant to retire, use a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">grant
        /// token</a>, or both the grant ID and a key identifier (key ID or key ARN) of the KMS
        /// key. The <a>CreateGrant</a> operation returns both values.
        /// 
        ///  
        /// <para>
        /// This operation can be called by the <i>retiring principal</i> for a grant, by the
        /// <i>grantee principal</i> if the grant allows the <code>RetireGrant</code> operation,
        /// and by the Amazon Web Services account (root user) in which the grant is created.
        /// It can also be called by principals to whom permission for retiring a grant is delegated.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. You can retire a grant on a KMS key in a different
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions:</b>:Permission to retire a grant is determined primarily
        /// by the grant. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="grantToken">Identifies the grant to be retired. You can use a grant token to identify a new grant even before it has achieved eventual consistency. Only the <a>CreateGrant</a> operation returns a grant token. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual consistency</a> in the <i>Key Management Service Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrantAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes a grant. Typically, you retire a grant when you no longer need its permissions.
        /// To identify the grant to retire, use a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">grant
        /// token</a>, or both the grant ID and a key identifier (key ID or key ARN) of the KMS
        /// key. The <a>CreateGrant</a> operation returns both values.
        /// 
        ///  
        /// <para>
        /// This operation can be called by the <i>retiring principal</i> for a grant, by the
        /// <i>grantee principal</i> if the grant allows the <code>RetireGrant</code> operation,
        /// and by the Amazon Web Services account (root user) in which the grant is created.
        /// It can also be called by principals to whom permission for retiring a grant is delegated.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. You can retire a grant on a KMS key in a different
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions:</b>:Permission to retire a grant is determined primarily
        /// by the grant. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetireGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetireGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<RetireGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeGrant


        /// <summary>
        /// Deletes the specified grant. You revoke a grant to terminate the permissions that
        /// the grant allows. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/managing-grants.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// 
        ///  
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual
        /// consistency</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RevokeGrant</a>
        /// (key policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="grantId">Identifies the grant to revoke. To get the grant ID, use <a>CreateGrant</a>, <a>ListGrants</a>, or <a>ListRetirableGrants</a>.</param>
        /// <param name="keyId">A unique identifier for the KMS key associated with the grant. To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual RevokeGrantResponse RevokeGrant(string grantId, string keyId)
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrant(request);
        }


        /// <summary>
        /// Deletes the specified grant. You revoke a grant to terminate the permissions that
        /// the grant allows. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/managing-grants.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// 
        ///  
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual
        /// consistency</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RevokeGrant</a>
        /// (key policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual RevokeGrantResponse RevokeGrant(RevokeGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return Invoke<RevokeGrantResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified grant. You revoke a grant to terminate the permissions that
        /// the grant allows. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/managing-grants.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// 
        ///  
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual
        /// consistency</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RevokeGrant</a>
        /// (key policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="grantId">Identifies the grant to revoke. To get the grant ID, use <a>CreateGrant</a>, <a>ListGrants</a>, or <a>ListRetirableGrants</a>.</param>
        /// <param name="keyId">A unique identifier for the KMS key associated with the grant. To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrantAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes the specified grant. You revoke a grant to terminate the permissions that
        /// the grant allows. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/managing-grants.html#grant-delete">Retiring
        /// and revoking grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// 
        ///  
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual
        /// consistency</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Using
        /// grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of working with grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/programming-grants.html">Programming
        /// grants</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <code>KeyId</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RevokeGrant</a>
        /// (key policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeGrantResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScheduleKeyDeletion


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
        /// be used in any cryptographic operations. It remains in this state for the duration
        /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a KMS key from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the KMS key from KMS. Then KMS makes a best effort to delete the key material from
        /// the associated CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
        /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">The unique identifier of the KMS key to delete. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId)
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletion(request);
        }


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
        /// be used in any cryptographic operations. It remains in this state for the duration
        /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a KMS key from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the KMS key from KMS. Then KMS makes a best effort to delete the key material from
        /// the associated CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
        /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">The unique identifier of the KMS key to delete. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, KMS deletes the KMS key. If the KMS key is a multi-Region primary key with replicas, the waiting period begins when the last of its replica keys is deleted. Otherwise, the waiting period begins immediately. This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual ScheduleKeyDeletionResponse ScheduleKeyDeletion(string keyId, int pendingWindowInDays)
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletion(request);
        }


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
        /// be used in any cryptographic operations. It remains in this state for the duration
        /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a KMS key from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the KMS key from KMS. Then KMS makes a best effort to delete the key material from
        /// the associated CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
        /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<ScheduleKeyDeletionResponse>(request, options);
        }


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
        /// be used in any cryptographic operations. It remains in this state for the duration
        /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a KMS key from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the KMS key from KMS. Then KMS makes a best effort to delete the key material from
        /// the associated CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
        /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">The unique identifier of the KMS key to delete. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
        /// be used in any cryptographic operations. It remains in this state for the duration
        /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a KMS key from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the KMS key from KMS. Then KMS makes a best effort to delete the key material from
        /// the associated CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
        /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">The unique identifier of the KMS key to delete. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, KMS deletes the KMS key. If the KMS key is a multi-Region primary key with replicas, the waiting period begins when the last of its replica keys is deleted. Otherwise, the waiting period begins immediately. This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <code>PendingDeletion</code> and the key can't
        /// be used in any cryptographic operations. It remains in this state for the duration
        /// of the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a multi-Region replica key.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a KMS key from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the KMS key from KMS. Then KMS makes a best effort to delete the key material from
        /// the associated CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <code>PendingReplicaDeletion</code> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <code>PendingDeletion</code>
        /// and its waiting period (<code>PendingWindowInDays</code>) begins. For details, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ScheduleKeyDeletionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Sign


        /// <summary>
        /// Creates a <a href="https://en.wikipedia.org/wiki/Digital_signature">digital signature</a>
        /// for a message or message digest by using the private key in an asymmetric KMS key.
        /// To verify the signature, use the <a>Verify</a> operation, or use the public key in
        /// the same asymmetric KMS key outside of KMS. For information about symmetric and asymmetric
        /// KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Digital signatures are generated and verified by using asymmetric key pair, such as
        /// an RSA or ECC pair that is represented by an asymmetric KMS key. The key owner (or
        /// an authorized user) uses their private key to sign a message. Anyone with the public
        /// key can verify that the message was signed with that particular private key and that
        /// the message hasn't changed since it was signed. 
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Sign</code> operation, provide the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>KeyId</code> parameter to identify an asymmetric KMS key with a <code>KeyUsage</code>
        /// value of <code>SIGN_VERIFY</code>. To get the <code>KeyUsage</code> value of a KMS
        /// key, use the <a>DescribeKey</a> operation. The caller must have <code>kms:Sign</code>
        /// permission on the KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>Message</code> parameter to specify the message or message digest to
        /// sign. You can submit messages of up to 4096 bytes. To sign a larger message, generate
        /// a hash digest of the message, and then provide the hash digest in the <code>Message</code>
        /// parameter. To indicate whether the message is a full message or a digest, use the
        /// <code>MessageType</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose a signing algorithm that is compatible with the KMS key. 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When signing a message, be sure to record the KMS key and the signing algorithm. This
        /// information is required to verify the signature.
        /// </para>
        ///  </important> 
        /// <para>
        /// To verify the signature that this operation generates, use the <a>Verify</a> operation.
        /// Or use the <a>GetPublicKey</a> operation to download the public key and then use the
        /// public key to verify the signature outside of KMS. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Sign</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>Verify</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Sign service method.</param>
        /// 
        /// <returns>The response from the Sign service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Sign">REST API Reference for Sign Operation</seealso>
        public virtual SignResponse Sign(SignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignResponseUnmarshaller.Instance;

            return Invoke<SignResponse>(request, options);
        }


        /// <summary>
        /// Creates a <a href="https://en.wikipedia.org/wiki/Digital_signature">digital signature</a>
        /// for a message or message digest by using the private key in an asymmetric KMS key.
        /// To verify the signature, use the <a>Verify</a> operation, or use the public key in
        /// the same asymmetric KMS key outside of KMS. For information about symmetric and asymmetric
        /// KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Digital signatures are generated and verified by using asymmetric key pair, such as
        /// an RSA or ECC pair that is represented by an asymmetric KMS key. The key owner (or
        /// an authorized user) uses their private key to sign a message. Anyone with the public
        /// key can verify that the message was signed with that particular private key and that
        /// the message hasn't changed since it was signed. 
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Sign</code> operation, provide the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>KeyId</code> parameter to identify an asymmetric KMS key with a <code>KeyUsage</code>
        /// value of <code>SIGN_VERIFY</code>. To get the <code>KeyUsage</code> value of a KMS
        /// key, use the <a>DescribeKey</a> operation. The caller must have <code>kms:Sign</code>
        /// permission on the KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>Message</code> parameter to specify the message or message digest to
        /// sign. You can submit messages of up to 4096 bytes. To sign a larger message, generate
        /// a hash digest of the message, and then provide the hash digest in the <code>Message</code>
        /// parameter. To indicate whether the message is a full message or a digest, use the
        /// <code>MessageType</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose a signing algorithm that is compatible with the KMS key. 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When signing a message, be sure to record the KMS key and the signing algorithm. This
        /// information is required to verify the signature.
        /// </para>
        ///  </important> 
        /// <para>
        /// To verify the signature that this operation generates, use the <a>Verify</a> operation.
        /// Or use the <a>GetPublicKey</a> operation to download the public key and then use the
        /// public key to verify the signature outside of KMS. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Sign</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>Verify</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Sign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Sign service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Sign">REST API Reference for Sign Operation</seealso>
        public virtual Task<SignResponse> SignAsync(SignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignResponseUnmarshaller.Instance;
            
            return InvokeAsync<SignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or edits tags on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each tag consists of a tag key and a tag value, both of which are case-sensitive strings.
        /// The tag value can be an empty (null) string. To add a tag, specify a new tag key and
        /// a tag value. To edit a tag, specify an existing tag key and a new tag value.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to tag a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>, but you cannot tag an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>, an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">Amazon
        /// Web Services owned key</a>, a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#keystore-concept">custom
        /// key store</a>, or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#alias-concept">alias</a>.
        /// </para>
        ///  
        /// <para>
        /// You can also add tags to a KMS key while creating it (<a>CreateKey</a>) or replicating
        /// it (<a>ReplicateKey</a>).
        /// </para>
        ///  
        /// <para>
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>. For general information about tags, including the format and syntax, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or edits tags on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each tag consists of a tag key and a tag value, both of which are case-sensitive strings.
        /// The tag value can be an empty (null) string. To add a tag, specify a new tag key and
        /// a tag value. To edit a tag, specify an existing tag key and a new tag value.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to tag a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>, but you cannot tag an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a>, an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">Amazon
        /// Web Services owned key</a>, a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#keystore-concept">custom
        /// key store</a>, or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#alias-concept">alias</a>.
        /// </para>
        ///  
        /// <para>
        /// You can also add tags to a KMS key while creating it (<a>CreateKey</a>) or replicating
        /// it (<a>ReplicateKey</a>).
        /// </para>
        ///  
        /// <para>
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>. For general information about tags, including the format and syntax, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes tags from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>. To delete a tag, specify the tag key and the KMS key.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When it succeeds, the <code>UntagResource</code> operation doesn't return any output.
        /// Also, if the specified tag key isn't found on the KMS key, it doesn't throw an exception
        /// or return a response. To confirm that the operation worked, use the <a>ListResourceTags</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>. For general information about tags, including the format and syntax, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UntagResource</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Deletes tags from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>. To delete a tag, specify the tag key and the KMS key.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When it succeeds, the <code>UntagResource</code> operation doesn't return any output.
        /// Also, if the specified tag key isn't found on the KMS key, it doesn't throw an exception
        /// or return a response. To confirm that the operation worked, use the <a>ListResourceTags</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>. For general information about tags, including the format and syntax, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UntagResource</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Associates an existing KMS alias with a different KMS key. Each alias is associated
        /// with only one KMS key at a time, although a KMS key can have multiple aliases. The
        /// alias and the KMS key must be in the same Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The current and new KMS key must be the same type (both symmetric or both asymmetric),
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents errors in code that uses aliases. If you must assign an
        /// alias to a different type of KMS key, use <a>DeleteAlias</a> to delete the old alias
        /// and <a>CreateAlias</a> to create a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
        /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a KMS key, you can create, update, and delete
        /// the aliases of a KMS key without affecting the KMS key. Also, aliases do not appear
        /// in the response from the <a>DescribeKey</a> operation. To get the aliases of all KMS
        /// keys in the account, use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the current KMS key (key policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the new KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasName">Identifies the alias that is changing its KMS key. This value must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>. You cannot use UpdateAlias to change the alias name.</param>
        /// <param name="targetKeyId">Identifies the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> to associate with the alias. You don't have permission to associate an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a>. The KMS key must be in the same Amazon Web Services account and Region as the alias. Also, the new target KMS key must be the same type as the current target KMS key (both symmetric or both asymmetric) and they must have the same key usage.  Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct KMS key, use <a>ListAliases</a>.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse UpdateAlias(string aliasName, string targetKeyId)
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAlias(request);
        }


        /// <summary>
        /// Associates an existing KMS alias with a different KMS key. Each alias is associated
        /// with only one KMS key at a time, although a KMS key can have multiple aliases. The
        /// alias and the KMS key must be in the same Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The current and new KMS key must be the same type (both symmetric or both asymmetric),
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents errors in code that uses aliases. If you must assign an
        /// alias to a different type of KMS key, use <a>DeleteAlias</a> to delete the old alias
        /// and <a>CreateAlias</a> to create a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
        /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a KMS key, you can create, update, and delete
        /// the aliases of a KMS key without affecting the KMS key. Also, aliases do not appear
        /// in the response from the <a>DescribeKey</a> operation. To get the aliases of all KMS
        /// keys in the account, use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the current KMS key (key policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the new KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }


        /// <summary>
        /// Associates an existing KMS alias with a different KMS key. Each alias is associated
        /// with only one KMS key at a time, although a KMS key can have multiple aliases. The
        /// alias and the KMS key must be in the same Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The current and new KMS key must be the same type (both symmetric or both asymmetric),
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents errors in code that uses aliases. If you must assign an
        /// alias to a different type of KMS key, use <a>DeleteAlias</a> to delete the old alias
        /// and <a>CreateAlias</a> to create a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
        /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a KMS key, you can create, update, and delete
        /// the aliases of a KMS key without affecting the KMS key. Also, aliases do not appear
        /// in the response from the <a>DescribeKey</a> operation. To get the aliases of all KMS
        /// keys in the account, use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the current KMS key (key policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the new KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasName">Identifies the alias that is changing its KMS key. This value must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>. You cannot use UpdateAlias to change the alias name.</param>
        /// <param name="targetKeyId">Identifies the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> to associate with the alias. You don't have permission to associate an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a>. The KMS key must be in the same Amazon Web Services account and Region as the alias. Also, the new target KMS key must be the same type as the current target KMS key (both symmetric or both asymmetric) and they must have the same key usage.  Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct KMS key, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Associates an existing KMS alias with a different KMS key. Each alias is associated
        /// with only one KMS key at a time, although a KMS key can have multiple aliases. The
        /// alias and the KMS key must be in the same Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">Using
        /// ABAC in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The current and new KMS key must be the same type (both symmetric or both asymmetric),
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents errors in code that uses aliases. If you must assign an
        /// alias to a different type of KMS key, use <a>DeleteAlias</a> to delete the old alias
        /// and <a>CreateAlias</a> to create a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
        /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a KMS key, you can create, update, and delete
        /// the aliases of a KMS key without affecting the KMS key. Also, aliases do not appear
        /// in the response from the <a>DescribeKey</a> operation. To get the aliases of all KMS
        /// keys in the account, use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the current KMS key (key policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the new KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomKeyStore


        /// <summary>
        /// Changes the properties of a custom key store. Use the <code>CustomKeyStoreId</code>
        /// parameter to identify the custom key store you want to edit. Use the remaining parameters
        /// to change the properties of the custom key store.
        /// 
        ///  
        /// <para>
        /// You can only update a custom key store that is disconnected. To disconnect the custom
        /// key store, use <a>DisconnectCustomKeyStore</a>. To reconnect the custom key store
        /// after the update completes, use <a>ConnectCustomKeyStore</a>. To find the connection
        /// state of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>CustomKeyStoreId</code> parameter is required in all commands. Use the other
        /// parameters of <code>UpdateCustomKeyStore</code> to edit your key store settings.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>NewCustomKeyStoreName</code> parameter to change the friendly name of
        /// the custom key store to the value that you specify.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>KeyStorePassword</code> parameter tell KMS the current password of the
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user (CU)</a> in the associated CloudHSM cluster. You
        /// can use this parameter to <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-password">fix
        /// connection failures</a> that occur when KMS cannot log into the associated cluster
        /// because the <code>kmsuser</code> password has changed. This value does not change
        /// the password in the CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>CloudHsmClusterId</code> parameter to associate the custom key store
        /// with a different, but related, CloudHSM cluster. You can use this parameter to repair
        /// a custom key store if its CloudHSM cluster becomes corrupted or is deleted, or when
        /// you need to create or restore a cluster from a backup. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster that is associated with the
        /// custom key store is not active. Initialize and activate the cluster and try the command
        /// again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotRelatedException">
        /// The request was rejected because the specified CloudHSM cluster has a different cluster
        /// certificate than the original cluster. You cannot use the operation to specify an
        /// unrelated cluster.
        /// 
        ///  
        /// <para>
        /// Specify a cluster that shares a backup history with the original cluster. This includes
        /// clusters that were created from a backup of the current cluster, and clusters that
        /// were created from the same backup that produced the current cluster.
        /// </para>
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        public virtual UpdateCustomKeyStoreResponse UpdateCustomKeyStore(UpdateCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Changes the properties of a custom key store. Use the <code>CustomKeyStoreId</code>
        /// parameter to identify the custom key store you want to edit. Use the remaining parameters
        /// to change the properties of the custom key store.
        /// 
        ///  
        /// <para>
        /// You can only update a custom key store that is disconnected. To disconnect the custom
        /// key store, use <a>DisconnectCustomKeyStore</a>. To reconnect the custom key store
        /// after the update completes, use <a>ConnectCustomKeyStore</a>. To find the connection
        /// state of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The <code>CustomKeyStoreId</code> parameter is required in all commands. Use the other
        /// parameters of <code>UpdateCustomKeyStore</code> to edit your key store settings.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>NewCustomKeyStoreName</code> parameter to change the friendly name of
        /// the custom key store to the value that you specify.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>KeyStorePassword</code> parameter tell KMS the current password of the
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user (CU)</a> in the associated CloudHSM cluster. You
        /// can use this parameter to <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-password">fix
        /// connection failures</a> that occur when KMS cannot log into the associated cluster
        /// because the <code>kmsuser</code> password has changed. This value does not change
        /// the password in the CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>CloudHsmClusterId</code> parameter to associate the custom key store
        /// with a different, but related, CloudHSM cluster. You can use this parameter to repair
        /// a custom key store if its CloudHSM cluster becomes corrupted or is deleted, or when
        /// you need to create or restore a cluster from a backup. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in KMS, which combines the convenience and extensive
        /// integration of KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster that is associated with the
        /// custom key store is not active. Initialize and activate the cluster and try the command
        /// again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotRelatedException">
        /// The request was rejected because the specified CloudHSM cluster has a different cluster
        /// certificate than the original cluster. You cannot use the operation to specify an
        /// unrelated cluster.
        /// 
        ///  
        /// <para>
        /// Specify a cluster that shares a backup history with the original cluster. This includes
        /// clusters that were created from a backup of the current cluster, and clusters that
        /// were created from the same backup that produced the current cluster.
        /// </para>
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        public virtual Task<UpdateCustomKeyStoreResponse> UpdateCustomKeyStoreAsync(UpdateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomKeyStoreResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyDescription


        /// <summary>
        /// Updates the description of a KMS key. To see the description of a KMS key, use <a>DescribeKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateKeyDescription</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Updates the description of the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the KMS key.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual UpdateKeyDescriptionResponse UpdateKeyDescription(string keyId, string description)
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescription(request);
        }


        /// <summary>
        /// Updates the description of a KMS key. To see the description of a KMS key, use <a>DescribeKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateKeyDescription</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the description of a KMS key. To see the description of a KMS key, use <a>DescribeKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateKeyDescription</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="keyId">Updates the description of the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the KMS key.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescriptionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Updates the description of a KMS key. To see the description of a KMS key, use <a>DescribeKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateKeyDescription</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateKeyDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePrimaryRegion


        /// <summary>
        /// Changes the primary key of a multi-Region key. 
        /// 
        ///  
        /// <para>
        /// This operation changes the replica key in the specified Region to a primary key and
        /// changes the former primary key to a replica key. For example, suppose you have a primary
        /// key in <code>us-east-1</code> and a replica key in <code>eu-west-2</code>. If you
        /// run <code>UpdatePrimaryRegion</code> with a <code>PrimaryRegion</code> value of <code>eu-west-2</code>,
        /// the primary key is now the key in <code>eu-west-2</code>, and the key in <code>us-east-1</code>
        /// becomes a replica key. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-manage.html#multi-region-update">Updating
        /// the primary Region</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <i>primary key</i> of a multi-Region key is the source for properties that are
        /// always shared by primary and replica keys, including the key material, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
        /// ID</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-spec">key
        /// spec</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-usage">key
        /// usage</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-origin">key
        /// material origin</a>, and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// key rotation</a>. It's the only key that can be replicated. You cannot <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_ScheduleKeyDeletion.html">delete
        /// the primary key</a> until all replica keys are deleted.
        /// </para>
        ///  
        /// <para>
        /// The key ID and primary Region that you specify uniquely identify the replica key that
        /// will become the primary key. The primary Region must already have a replica key. This
        /// operation does not create a KMS key in the specified Region. To find the replica keys,
        /// use the <a>DescribeKey</a> operation on the primary key or any replica key. To create
        /// a replica key, use the <a>ReplicateKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You can run this operation while using the affected multi-Region keys in cryptographic
        /// operations. This operation should not delay, interrupt, or cause failures in cryptographic
        /// operations. 
        /// </para>
        ///  
        /// <para>
        /// Even after this operation completes, the process of updating the primary Region might
        /// still be in progress for a few more seconds. Operations such as <code>DescribeKey</code>
        /// might display both the old and new primary keys as replicas. The old and new primary
        /// keys have a transient key state of <code>Updating</code>. The original key state is
        /// restored when the update is complete. While the key state is <code>Updating</code>,
        /// you can use the keys in cryptographic operations, but you cannot replicate the new
        /// primary key or perform certain management operations, such as enabling or disabling
        /// these keys. For details about the <code>Updating</code> key state, see <a href="kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return any output. To verify that primary key is changed,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation in a different Amazon
        /// Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>kms:UpdatePrimaryRegion</code> on the current primary key (in the primary key's
        /// Region). Include this permission primary key's key policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kms:UpdatePrimaryRegion</code> on the current replica key (in the replica key's
        /// Region). Include this permission in the replica key's key policy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryRegion service method.</param>
        /// 
        /// <returns>The response from the UpdatePrimaryRegion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdatePrimaryRegion">REST API Reference for UpdatePrimaryRegion Operation</seealso>
        public virtual UpdatePrimaryRegionResponse UpdatePrimaryRegion(UpdatePrimaryRegionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrimaryRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrimaryRegionResponseUnmarshaller.Instance;

            return Invoke<UpdatePrimaryRegionResponse>(request, options);
        }


        /// <summary>
        /// Changes the primary key of a multi-Region key. 
        /// 
        ///  
        /// <para>
        /// This operation changes the replica key in the specified Region to a primary key and
        /// changes the former primary key to a replica key. For example, suppose you have a primary
        /// key in <code>us-east-1</code> and a replica key in <code>eu-west-2</code>. If you
        /// run <code>UpdatePrimaryRegion</code> with a <code>PrimaryRegion</code> value of <code>eu-west-2</code>,
        /// the primary key is now the key in <code>eu-west-2</code>, and the key in <code>us-east-1</code>
        /// becomes a replica key. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-manage.html#multi-region-update">Updating
        /// the primary Region</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Using
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <i>primary key</i> of a multi-Region key is the source for properties that are
        /// always shared by primary and replica keys, including the key material, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
        /// ID</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-spec">key
        /// spec</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-usage">key
        /// usage</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-origin">key
        /// material origin</a>, and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// key rotation</a>. It's the only key that can be replicated. You cannot <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_ScheduleKeyDeletion.html">delete
        /// the primary key</a> until all replica keys are deleted.
        /// </para>
        ///  
        /// <para>
        /// The key ID and primary Region that you specify uniquely identify the replica key that
        /// will become the primary key. The primary Region must already have a replica key. This
        /// operation does not create a KMS key in the specified Region. To find the replica keys,
        /// use the <a>DescribeKey</a> operation on the primary key or any replica key. To create
        /// a replica key, use the <a>ReplicateKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You can run this operation while using the affected multi-Region keys in cryptographic
        /// operations. This operation should not delay, interrupt, or cause failures in cryptographic
        /// operations. 
        /// </para>
        ///  
        /// <para>
        /// Even after this operation completes, the process of updating the primary Region might
        /// still be in progress for a few more seconds. Operations such as <code>DescribeKey</code>
        /// might display both the old and new primary keys as replicas. The old and new primary
        /// keys have a transient key state of <code>Updating</code>. The original key state is
        /// restored when the update is complete. While the key state is <code>Updating</code>,
        /// you can use the keys in cryptographic operations, but you cannot replicate the new
        /// primary key or perform certain management operations, such as enabling or disabling
        /// these keys. For details about the <code>Updating</code> key state, see <a href="kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return any output. To verify that primary key is changed,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation in a different Amazon
        /// Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>kms:UpdatePrimaryRegion</code> on the current primary key (in the primary key's
        /// Region). Include this permission primary key's key policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kms:UpdatePrimaryRegion</code> on the current replica key (in the replica key's
        /// Region). Include this permission in the replica key's key policy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrimaryRegion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdatePrimaryRegion">REST API Reference for UpdatePrimaryRegion Operation</seealso>
        public virtual Task<UpdatePrimaryRegionResponse> UpdatePrimaryRegionAsync(UpdatePrimaryRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePrimaryRegionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePrimaryRegionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePrimaryRegionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Verify


        /// <summary>
        /// Verifies a digital signature that was generated by the <a>Sign</a> operation. 
        /// 
        ///   
        /// <para>
        /// Verification confirms that an authorized user signed the message with the specified
        /// KMS key and signing algorithm, and the message hasn't changed since it was signed.
        /// If the signature is verified, the value of the <code>SignatureValid</code> field in
        /// the response is <code>True</code>. If the signature verification fails, the <code>Verify</code>
        /// operation fails with an <code>KMSInvalidSignatureException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// A digital signature is generated by using the private key in an asymmetric KMS key.
        /// The signature is verified by using the public key in the same asymmetric KMS key.
        /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To verify a digital signature, you can use the <code>Verify</code> operation. Specify
        /// the same asymmetric KMS key, message, and signing algorithm that were used to produce
        /// the signature.
        /// </para>
        ///  
        /// <para>
        /// You can also verify the digital signature by using the public key of the KMS key outside
        /// of KMS. Use the <a>GetPublicKey</a> operation to download the public key in the asymmetric
        /// KMS key and then use the public key to verify the signature outside of KMS. The advantage
        /// of using the <code>Verify</code> operation is that it is performed within KMS. As
        /// a result, it's easy to call, the operation is performed within the FIPS boundary,
        /// it is logged in CloudTrail, and you can use key policy and IAM policy to determine
        /// who is authorized to use the KMS key to verify signatures.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Verify</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>Sign</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Verify service method.</param>
        /// 
        /// <returns>The response from the Verify service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidSignatureException">
        /// The request was rejected because the signature verification failed. Signature verification
        /// fails when it cannot confirm that signature was produced by signing the specified
        /// message with the specified KMS key and signing algorithm.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Verify">REST API Reference for Verify Operation</seealso>
        public virtual VerifyResponse Verify(VerifyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyResponseUnmarshaller.Instance;

            return Invoke<VerifyResponse>(request, options);
        }


        /// <summary>
        /// Verifies a digital signature that was generated by the <a>Sign</a> operation. 
        /// 
        ///   
        /// <para>
        /// Verification confirms that an authorized user signed the message with the specified
        /// KMS key and signing algorithm, and the message hasn't changed since it was signed.
        /// If the signature is verified, the value of the <code>SignatureValid</code> field in
        /// the response is <code>True</code>. If the signature verification fails, the <code>Verify</code>
        /// operation fails with an <code>KMSInvalidSignatureException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// A digital signature is generated by using the private key in an asymmetric KMS key.
        /// The signature is verified by using the public key in the same asymmetric KMS key.
        /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To verify a digital signature, you can use the <code>Verify</code> operation. Specify
        /// the same asymmetric KMS key, message, and signing algorithm that were used to produce
        /// the signature.
        /// </para>
        ///  
        /// <para>
        /// You can also verify the digital signature by using the public key of the KMS key outside
        /// of KMS. Use the <a>GetPublicKey</a> operation to download the public key in the asymmetric
        /// KMS key and then use the public key to verify the signature outside of KMS. The advantage
        /// of using the <code>Verify</code> operation is that it is performed within KMS. As
        /// a result, it's easy to call, the operation is performed within the FIPS boundary,
        /// it is logged in CloudTrail, and you can use key policy and IAM policy to determine
        /// who is authorized to use the KMS key to verify signatures.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <code>KeyId</code> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Verify</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>Sign</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Verify service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Verify service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <code>(KeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a KMS key,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidSignatureException">
        /// The request was rejected because the signature verification failed. Signature verification
        /// fails when it cannot confirm that signature was produced by signing the specified
        /// message with the specified KMS key and signing algorithm.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// state: Effect on your KMS key</a> in the <i> <i>Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Verify">REST API Reference for Verify Operation</seealso>
        public virtual Task<VerifyResponse> VerifyAsync(VerifyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyResponseUnmarshaller.Instance;
            
            return InvokeAsync<VerifyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}