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
    /// The basic building block of a workflow.
    /// </summary>
    public partial class WorkflowStep
    {
        private CopyStepDetails _copyStepDetails;
        private CustomStepDetails _customStepDetails;
        private DeleteStepDetails _deleteStepDetails;
        private TagStepDetails _tagStepDetails;
        private WorkflowStepType _type;

        /// <summary>
        /// Gets and sets the property CopyStepDetails. 
        /// <para>
        /// Details for a step that performs a file copy.
        /// </para>
        ///  
        /// <para>
        ///  Consists of the following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A description
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An S3 location for the destination of the file copy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A flag that indicates whether or not to overwrite an existing file of the same name.
        /// The default is <code>FALSE</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CopyStepDetails CopyStepDetails
        {
            get { return this._copyStepDetails; }
            set { this._copyStepDetails = value; }
        }

        // Check to see if CopyStepDetails property is set
        internal bool IsSetCopyStepDetails()
        {
            return this._copyStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CustomStepDetails. 
        /// <para>
        /// Details for a step that invokes a lambda function.
        /// </para>
        ///  
        /// <para>
        ///  Consists of the lambda function name, target, and timeout (in seconds). 
        /// </para>
        /// </summary>
        public CustomStepDetails CustomStepDetails
        {
            get { return this._customStepDetails; }
            set { this._customStepDetails = value; }
        }

        // Check to see if CustomStepDetails property is set
        internal bool IsSetCustomStepDetails()
        {
            return this._customStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteStepDetails. 
        /// <para>
        /// Details for a step that deletes the file.
        /// </para>
        /// </summary>
        public DeleteStepDetails DeleteStepDetails
        {
            get { return this._deleteStepDetails; }
            set { this._deleteStepDetails = value; }
        }

        // Check to see if DeleteStepDetails property is set
        internal bool IsSetDeleteStepDetails()
        {
            return this._deleteStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TagStepDetails. 
        /// <para>
        /// Details for a step that creates one or more tags.
        /// </para>
        ///  
        /// <para>
        /// You specify one or more tags: each tag contains a key/value pair.
        /// </para>
        /// </summary>
        public TagStepDetails TagStepDetails
        {
            get { return this._tagStepDetails; }
            set { this._tagStepDetails = value; }
        }

        // Check to see if TagStepDetails property is set
        internal bool IsSetTagStepDetails()
        {
            return this._tagStepDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  Currently, the following step types are supported. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Copy</i>: copy the file to another location
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Custom</i>: custom step with a lambda target
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Delete</i>: delete the file
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Tag</i>: add a tag to the file
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkflowStepType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}