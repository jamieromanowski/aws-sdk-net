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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLocationHdfs Request Marshaller
    /// </summary>       
    public class UpdateLocationHdfsRequestMarshaller : IMarshaller<IRequest, UpdateLocationHdfsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationHdfsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLocationHdfsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.UpdateLocationHdfs";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAgentArns())
                {
                    context.Writer.WritePropertyName("AgentArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                    {
                            context.Writer.Write(publicRequestAgentArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAuthenticationType())
                {
                    context.Writer.WritePropertyName("AuthenticationType");
                    context.Writer.Write(publicRequest.AuthenticationType);
                }

                if(publicRequest.IsSetBlockSize())
                {
                    context.Writer.WritePropertyName("BlockSize");
                    context.Writer.Write(publicRequest.BlockSize);
                }

                if(publicRequest.IsSetKerberosKeytab())
                {
                    context.Writer.WritePropertyName("KerberosKeytab");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.KerberosKeytab));
                }

                if(publicRequest.IsSetKerberosKrb5Conf())
                {
                    context.Writer.WritePropertyName("KerberosKrb5Conf");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.KerberosKrb5Conf));
                }

                if(publicRequest.IsSetKerberosPrincipal())
                {
                    context.Writer.WritePropertyName("KerberosPrincipal");
                    context.Writer.Write(publicRequest.KerberosPrincipal);
                }

                if(publicRequest.IsSetKmsKeyProviderUri())
                {
                    context.Writer.WritePropertyName("KmsKeyProviderUri");
                    context.Writer.Write(publicRequest.KmsKeyProviderUri);
                }

                if(publicRequest.IsSetLocationArn())
                {
                    context.Writer.WritePropertyName("LocationArn");
                    context.Writer.Write(publicRequest.LocationArn);
                }

                if(publicRequest.IsSetNameNodes())
                {
                    context.Writer.WritePropertyName("NameNodes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNameNodesListValue in publicRequest.NameNodes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = HdfsNameNodeMarshaller.Instance;
                        marshaller.Marshall(publicRequestNameNodesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetQopConfiguration())
                {
                    context.Writer.WritePropertyName("QopConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = QopConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.QopConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetReplicationFactor())
                {
                    context.Writer.WritePropertyName("ReplicationFactor");
                    context.Writer.Write(publicRequest.ReplicationFactor);
                }

                if(publicRequest.IsSetSimpleUser())
                {
                    context.Writer.WritePropertyName("SimpleUser");
                    context.Writer.Write(publicRequest.SimpleUser);
                }

                if(publicRequest.IsSetSubdirectory())
                {
                    context.Writer.WritePropertyName("Subdirectory");
                    context.Writer.Write(publicRequest.Subdirectory);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLocationHdfsRequestMarshaller _instance = new UpdateLocationHdfsRequestMarshaller();        

        internal static UpdateLocationHdfsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLocationHdfsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}