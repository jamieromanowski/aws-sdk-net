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
    /// Describes a data repository association's automatic export policy. The <code>AutoExportPolicy</code>
    /// defines the types of updated objects on the file system that will be automatically
    /// exported to the data repository. As you create, modify, or delete files, Amazon FSx
    /// automatically exports the defined changes asynchronously once your application finishes
    /// modifying the file.
    /// 
    ///  
    /// <para>
    /// This <code>AutoExportPolicy</code> is supported only for file systems with the <code>Persistent_2</code>
    /// deployment type.
    /// </para>
    /// </summary>
    public partial class AutoExportPolicy
    {
        private List<string> _events = new List<string>();

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The <code>AutoExportPolicy</code> can have the following event values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEW</code> - Amazon FSx automatically exports new files and directories to
        /// the data repository as they are added to the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CHANGED</code> - Amazon FSx automatically exports changes to files and directories
        /// on the file system to the data repository.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - Files and directories are automatically deleted on the data
        /// repository when they are deleted on the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can define any combination of event types for your <code>AutoExportPolicy</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

    }
}