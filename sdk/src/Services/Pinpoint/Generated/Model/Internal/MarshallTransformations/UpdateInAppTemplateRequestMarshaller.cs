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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInAppTemplate Request Marshaller
    /// </summary>       
    public class UpdateInAppTemplateRequestMarshaller : IMarshaller<IRequest, UpdateInAppTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateInAppTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateInAppTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetTemplateName())
                throw new AmazonPinpointException("Request object does not have required field TemplateName set");
            request.AddPathResource("{template-name}", StringUtils.FromString(publicRequest.TemplateName));
            
            if (publicRequest.IsSetCreateNewVersion())
                request.Parameters.Add("create-new-version", StringUtils.FromBool(publicRequest.CreateNewVersion));
            
            if (publicRequest.IsSetVersion())
                request.Parameters.Add("version", StringUtils.FromString(publicRequest.Version));
            request.ResourcePath = "/v1/templates/{template-name}/inapp";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                var context = new JsonMarshallerContext(request, writer);
                context.Writer.WriteObjectStart();

                var marshaller = InAppTemplateRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.InAppTemplateRequest, context);

                context.Writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static UpdateInAppTemplateRequestMarshaller _instance = new UpdateInAppTemplateRequestMarshaller();        

        internal static UpdateInAppTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateInAppTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}