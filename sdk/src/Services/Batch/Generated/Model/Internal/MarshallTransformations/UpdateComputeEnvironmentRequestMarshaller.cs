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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateComputeEnvironment Request Marshaller
    /// </summary>       
    public class UpdateComputeEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateComputeEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateComputeEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateComputeEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/updatecomputeenvironment";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetComputeEnvironment())
                {
                    context.Writer.WritePropertyName("computeEnvironment");
                    context.Writer.Write(publicRequest.ComputeEnvironment);
                }

                if(publicRequest.IsSetComputeResources())
                {
                    context.Writer.WritePropertyName("computeResources");
                    context.Writer.WriteObjectStart();

                    var marshaller = ComputeResourceUpdateMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ComputeResources, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServiceRole())
                {
                    context.Writer.WritePropertyName("serviceRole");
                    context.Writer.Write(publicRequest.ServiceRole);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("state");
                    context.Writer.Write(publicRequest.State);
                }

                if(publicRequest.IsSetUnmanagedvCpus())
                {
                    context.Writer.WritePropertyName("unmanagedvCpus");
                    context.Writer.Write(publicRequest.UnmanagedvCpus);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateComputeEnvironmentRequestMarshaller _instance = new UpdateComputeEnvironmentRequestMarshaller();        

        internal static UpdateComputeEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateComputeEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}