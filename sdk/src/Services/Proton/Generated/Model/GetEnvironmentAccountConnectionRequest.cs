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
    /// Container for the parameters to the GetEnvironmentAccountConnection operation.
    /// In an environment account, view the detail data for an environment account connection.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-env-account-connections.html">Environment
    /// account connections</a> in the <i>Proton Administrator guide</i>.
    /// </para>
    /// </summary>
    public partial class GetEnvironmentAccountConnectionRequest : AmazonProtonRequest
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the environment account connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}