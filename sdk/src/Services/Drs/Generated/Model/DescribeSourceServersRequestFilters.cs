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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// A set of filters by which to return Source Servers.
    /// </summary>
    public partial class DescribeSourceServersRequestFilters
    {
        private string _hardwareId;
        private List<string> _sourceServerIDs = new List<string>();

        /// <summary>
        /// Gets and sets the property HardwareId. 
        /// <para>
        /// An ID that describes the hardware of the Source Server. This is either an EC2 instance
        /// id, a VMware uuid or a mac address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string HardwareId
        {
            get { return this._hardwareId; }
            set { this._hardwareId = value; }
        }

        // Check to see if HardwareId property is set
        internal bool IsSetHardwareId()
        {
            return this._hardwareId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerIDs. 
        /// <para>
        /// An array of Source Servers IDs that should be returned. An empty array means all Source
        /// Servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> SourceServerIDs
        {
            get { return this._sourceServerIDs; }
            set { this._sourceServerIDs = value; }
        }

        // Check to see if SourceServerIDs property is set
        internal bool IsSetSourceServerIDs()
        {
            return this._sourceServerIDs != null && this._sourceServerIDs.Count > 0; 
        }

    }
}