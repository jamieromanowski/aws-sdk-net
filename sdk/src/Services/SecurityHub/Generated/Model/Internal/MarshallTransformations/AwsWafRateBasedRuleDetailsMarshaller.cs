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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsWafRateBasedRuleDetails Marshaller
    /// </summary>       
    public class AwsWafRateBasedRuleDetailsMarshaller : IRequestMarshaller<AwsWafRateBasedRuleDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsWafRateBasedRuleDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMatchPredicates())
            {
                context.Writer.WritePropertyName("MatchPredicates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMatchPredicatesListValue in requestObject.MatchPredicates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsWafRateBasedRuleMatchPredicateMarshaller.Instance;
                    marshaller.Marshall(requestObjectMatchPredicatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.Write(requestObject.MetricName);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRateKey())
            {
                context.Writer.WritePropertyName("RateKey");
                context.Writer.Write(requestObject.RateKey);
            }

            if(requestObject.IsSetRateLimit())
            {
                context.Writer.WritePropertyName("RateLimit");
                context.Writer.Write(requestObject.RateLimit);
            }

            if(requestObject.IsSetRuleId())
            {
                context.Writer.WritePropertyName("RuleId");
                context.Writer.Write(requestObject.RuleId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsWafRateBasedRuleDetailsMarshaller Instance = new AwsWafRateBasedRuleDetailsMarshaller();

    }
}