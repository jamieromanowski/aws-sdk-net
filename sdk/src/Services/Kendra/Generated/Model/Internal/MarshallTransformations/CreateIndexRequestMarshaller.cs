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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIndex Request Marshaller
    /// </summary>       
    public class CreateIndexRequestMarshaller : IMarshaller<IRequest, CreateIndexRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIndexRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIndexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Kendra");
            string target = "AWSKendraFrontendService.CreateIndex";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-02-03";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());                                                
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEdition())
                {
                    context.Writer.WritePropertyName("Edition");
                    context.Writer.Write(publicRequest.Edition);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("RoleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetServerSideEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("ServerSideEncryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServerSideEncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServerSideEncryptionConfiguration, context);

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

                if(publicRequest.IsSetUserContextPolicy())
                {
                    context.Writer.WritePropertyName("UserContextPolicy");
                    context.Writer.Write(publicRequest.UserContextPolicy);
                }

                if(publicRequest.IsSetUserGroupResolutionConfiguration())
                {
                    context.Writer.WritePropertyName("UserGroupResolutionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UserGroupResolutionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.UserGroupResolutionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetUserTokenConfigurations())
                {
                    context.Writer.WritePropertyName("UserTokenConfigurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestUserTokenConfigurationsListValue in publicRequest.UserTokenConfigurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = UserTokenConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestUserTokenConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateIndexRequestMarshaller _instance = new CreateIndexRequestMarshaller();        

        internal static CreateIndexRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIndexRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}