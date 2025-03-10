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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for Lustre logging used to write the enabled logging events for
    /// your file system to Amazon CloudWatch Logs.
    /// 
    ///  
    /// <para>
    /// When logging is enabled, Lustre logs error and warning events from data repository
    /// operations such as automatic export and data repository tasks. To learn more about
    /// Lustre logging, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/cw-event-logging.html">Logging
    /// with Amazon CloudWatch Logs</a>. 
    /// </para>
    /// </summary>
    public partial class LustreLogConfiguration
    {
        private string _destination;
        private LustreAccessAuditLogLevel _level;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Resource Name (ARN) that specifies the destination of the logs. The destination
        /// can be any Amazon CloudWatch Logs log group ARN. The destination ARN must be in the
        /// same Amazon Web Services partition, Amazon Web Services Region, and Amazon Web Services
        /// account as your Amazon FSx file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=1024)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The data repository events that are logged by Amazon FSx.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WARN_ONLY</code> - only warning events are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ERROR_ONLY</code> - only error events are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WARN_ERROR</code> - both warning events and error events are logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> - logging of data repository events is turned off.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public LustreAccessAuditLogLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

    }
}