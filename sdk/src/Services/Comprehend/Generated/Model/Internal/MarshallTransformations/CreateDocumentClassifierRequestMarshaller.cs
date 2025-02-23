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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDocumentClassifier Request Marshaller
    /// </summary>       
    public class CreateDocumentClassifierRequestMarshaller : IMarshaller<IRequest, CreateDocumentClassifierRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDocumentClassifierRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDocumentClassifierRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Comprehend");
            string target = "Comprehend_20171127.CreateDocumentClassifier";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-27";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WritePropertyName("DataAccessRoleArn");
                    context.Writer.Write(publicRequest.DataAccessRoleArn);
                }

                if(publicRequest.IsSetDocumentClassifierName())
                {
                    context.Writer.WritePropertyName("DocumentClassifierName");
                    context.Writer.Write(publicRequest.DocumentClassifierName);
                }

                if(publicRequest.IsSetInputDataConfig())
                {
                    context.Writer.WritePropertyName("InputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentClassifierInputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WritePropertyName("LanguageCode");
                    context.Writer.Write(publicRequest.LanguageCode);
                }

                if(publicRequest.IsSetMode())
                {
                    context.Writer.WritePropertyName("Mode");
                    context.Writer.Write(publicRequest.Mode);
                }

                if(publicRequest.IsSetModelKmsKeyId())
                {
                    context.Writer.WritePropertyName("ModelKmsKeyId");
                    context.Writer.Write(publicRequest.ModelKmsKeyId);
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("OutputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentClassifierOutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVersionName())
                {
                    context.Writer.WritePropertyName("VersionName");
                    context.Writer.Write(publicRequest.VersionName);
                }

                if(publicRequest.IsSetVolumeKmsKeyId())
                {
                    context.Writer.WritePropertyName("VolumeKmsKeyId");
                    context.Writer.Write(publicRequest.VolumeKmsKeyId);
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateDocumentClassifierRequestMarshaller _instance = new CreateDocumentClassifierRequestMarshaller();        

        internal static CreateDocumentClassifierRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDocumentClassifierRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}