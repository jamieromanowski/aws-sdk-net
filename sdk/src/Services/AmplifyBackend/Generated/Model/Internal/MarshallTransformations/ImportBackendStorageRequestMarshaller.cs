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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportBackendStorage Request Marshaller
    /// </summary>       
    public class ImportBackendStorageRequestMarshaller : IMarshaller<IRequest, ImportBackendStorageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportBackendStorageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportBackendStorageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AmplifyBackend");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-11";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppId())
                throw new AmazonAmplifyBackendException("Request object does not have required field AppId set");
            request.AddPathResource("{appId}", StringUtils.FromString(publicRequest.AppId));
            if (!publicRequest.IsSetBackendEnvironmentName())
                throw new AmazonAmplifyBackendException("Request object does not have required field BackendEnvironmentName set");
            request.AddPathResource("{backendEnvironmentName}", StringUtils.FromString(publicRequest.BackendEnvironmentName));
            request.ResourcePath = "/backend/{appId}/storage/{backendEnvironmentName}/import";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBucketName())
                {
                    context.Writer.WritePropertyName("bucketName");
                    context.Writer.Write(publicRequest.BucketName);
                }

                if(publicRequest.IsSetServiceName())
                {
                    context.Writer.WritePropertyName("serviceName");
                    context.Writer.Write(publicRequest.ServiceName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ImportBackendStorageRequestMarshaller _instance = new ImportBackendStorageRequestMarshaller();        

        internal static ImportBackendStorageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportBackendStorageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}