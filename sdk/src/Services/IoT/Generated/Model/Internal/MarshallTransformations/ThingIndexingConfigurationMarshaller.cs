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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ThingIndexingConfiguration Marshaller
    /// </summary>       
    public class ThingIndexingConfigurationMarshaller : IRequestMarshaller<ThingIndexingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ThingIndexingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCustomFields())
            {
                context.Writer.WritePropertyName("customFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCustomFieldsListValue in requestObject.CustomFields)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomFieldsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDeviceDefenderIndexingMode())
            {
                context.Writer.WritePropertyName("deviceDefenderIndexingMode");
                context.Writer.Write(requestObject.DeviceDefenderIndexingMode);
            }

            if(requestObject.IsSetManagedFields())
            {
                context.Writer.WritePropertyName("managedFields");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectManagedFieldsListValue in requestObject.ManagedFields)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = FieldMarshaller.Instance;
                    marshaller.Marshall(requestObjectManagedFieldsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNamedShadowIndexingMode())
            {
                context.Writer.WritePropertyName("namedShadowIndexingMode");
                context.Writer.Write(requestObject.NamedShadowIndexingMode);
            }

            if(requestObject.IsSetThingConnectivityIndexingMode())
            {
                context.Writer.WritePropertyName("thingConnectivityIndexingMode");
                context.Writer.Write(requestObject.ThingConnectivityIndexingMode);
            }

            if(requestObject.IsSetThingIndexingMode())
            {
                context.Writer.WritePropertyName("thingIndexingMode");
                context.Writer.Write(requestObject.ThingIndexingMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ThingIndexingConfigurationMarshaller Instance = new ThingIndexingConfigurationMarshaller();

    }
}