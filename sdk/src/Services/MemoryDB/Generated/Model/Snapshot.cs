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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Represents a copy of an entire cluster as of the time when the snapshot was taken.
    /// </summary>
    public partial class Snapshot
    {
        private string _arn;
        private ClusterConfiguration _clusterConfiguration;
        private string _kmsKeyId;
        private string _name;
        private string _source;
        private string _status;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the snapshot.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterConfiguration. 
        /// <para>
        /// The configuration of the cluster from which the snapshot was taken
        /// </para>
        /// </summary>
        public ClusterConfiguration ClusterConfiguration
        {
            get { return this._clusterConfiguration; }
            set { this._clusterConfiguration = value; }
        }

        // Check to see if ClusterConfiguration property is set
        internal bool IsSetClusterConfiguration()
        {
            return this._clusterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the snapshot.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the snapshot
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Source. 
        /// <para>
        /// Indicates whether the snapshot is from an automatic backup (automated) or was created
        /// manually (manual).
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the snapshot. Valid values: creating | available | restoring | copying
        /// | deleting.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}