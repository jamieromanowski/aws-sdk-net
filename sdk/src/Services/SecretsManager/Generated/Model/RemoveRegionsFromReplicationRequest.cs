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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveRegionsFromReplication operation.
    /// For a secret that is replicated to other Regions, deletes the secret replicas from
    /// the Regions you specify.
    /// </summary>
    public partial class RemoveRegionsFromReplicationRequest : AmazonSecretsManagerRequest
    {
        private List<string> _removeReplicaRegions = new List<string>();
        private string _secretId;

        /// <summary>
        /// Gets and sets the property RemoveReplicaRegions. 
        /// <para>
        /// The Regions of the replicas to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> RemoveReplicaRegions
        {
            get { return this._removeReplicaRegions; }
            set { this._removeReplicaRegions = value; }
        }

        // Check to see if RemoveReplicaRegions property is set
        internal bool IsSetRemoveReplicaRegions()
        {
            return this._removeReplicaRegions != null && this._removeReplicaRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SecretId
        {
            get { return this._secretId; }
            set { this._secretId = value; }
        }

        // Check to see if SecretId property is set
        internal bool IsSetSecretId()
        {
            return this._secretId != null;
        }

    }
}