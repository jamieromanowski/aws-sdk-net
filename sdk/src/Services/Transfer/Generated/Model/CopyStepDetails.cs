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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Each step type has its own <code>StepDetails</code> structure.
    /// </summary>
    public partial class CopyStepDetails
    {
        private InputFileLocation _destinationFileLocation;
        private string _name;
        private OverwriteExisting _overwriteExisting;

        /// <summary>
        /// Gets and sets the property DestinationFileLocation.
        /// </summary>
        public InputFileLocation DestinationFileLocation
        {
            get { return this._destinationFileLocation; }
            set { this._destinationFileLocation = value; }
        }

        // Check to see if DestinationFileLocation property is set
        internal bool IsSetDestinationFileLocation()
        {
            return this._destinationFileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the step, used as an identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OverwriteExisting. 
        /// <para>
        /// A flag that indicates whether or not to overwrite an existing file of the same name.
        /// The default is <code>FALSE</code>.
        /// </para>
        /// </summary>
        public OverwriteExisting OverwriteExisting
        {
            get { return this._overwriteExisting; }
            set { this._overwriteExisting = value; }
        }

        // Check to see if OverwriteExisting property is set
        internal bool IsSetOverwriteExisting()
        {
            return this._overwriteExisting != null;
        }

    }
}