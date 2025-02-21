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
    /// InAppTemplateRequest Marshaller
    /// </summary>       
    public class InAppTemplateRequestMarshaller : IRequestMarshaller<InAppTemplateRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InAppTemplateRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContent())
            {
                context.Writer.WritePropertyName("Content");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectContentListValue in requestObject.Content)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InAppMessageContentMarshaller.Instance;
                    marshaller.Marshall(requestObjectContentListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCustomConfig())
            {
                context.Writer.WritePropertyName("CustomConfig");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectCustomConfigKvp in requestObject.CustomConfig)
                {
                    context.Writer.WritePropertyName(requestObjectCustomConfigKvp.Key);
                    var requestObjectCustomConfigValue = requestObjectCustomConfigKvp.Value;

                        context.Writer.Write(requestObjectCustomConfigValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLayout())
            {
                context.Writer.WritePropertyName("Layout");
                context.Writer.Write(requestObject.Layout);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemplateDescription())
            {
                context.Writer.WritePropertyName("TemplateDescription");
                context.Writer.Write(requestObject.TemplateDescription);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InAppTemplateRequestMarshaller Instance = new InAppTemplateRequestMarshaller();

    }
}