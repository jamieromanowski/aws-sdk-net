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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the DeleteEnvironmentTemplate operation.
    /// </summary>
    public partial class DeleteEnvironmentTemplateResponse : AmazonWebServiceResponse
    {
        private EnvironmentTemplate _environmentTemplate;

        /// <summary>
        /// Gets and sets the property EnvironmentTemplate. 
        /// <para>
        /// The environment template detail data that's returned by Proton.
        /// </para>
        /// </summary>
        public EnvironmentTemplate EnvironmentTemplate
        {
            get { return this._environmentTemplate; }
            set { this._environmentTemplate = value; }
        }

        // Check to see if EnvironmentTemplate property is set
        internal bool IsSetEnvironmentTemplate()
        {
            return this._environmentTemplate != null;
        }

    }
}