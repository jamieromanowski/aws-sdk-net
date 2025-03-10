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
    /// Container for the parameters to the DeleteSecret operation.
    /// Deletes a secret and all of its versions. You can specify a recovery window during
    /// which you can restore the secret. The minimum recovery window is 7 days. The default
    /// recovery window is 30 days. Secrets Manager attaches a <code>DeletionDate</code> stamp
    /// to the secret that specifies the end of the recovery window. At the end of the recovery
    /// window, Secrets Manager deletes the secret permanently.
    /// 
    ///  
    /// <para>
    /// For information about deleting a secret in the console, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_delete-secret.html">https://docs.aws.amazon.com/secretsmanager/latest/userguide/manage_delete-secret.html</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager performs the permanent secret deletion at the end of the waiting period
    /// as a background task with low priority. There is no guarantee of a specific time after
    /// the recovery window for the permanent delete to occur.
    /// </para>
    ///  
    /// <para>
    /// At any time before recovery window ends, you can use <a>RestoreSecret</a> to remove
    /// the <code>DeletionDate</code> and cancel the deletion of the secret.
    /// </para>
    ///  
    /// <para>
    /// In a secret scheduled for deletion, you cannot access the encrypted secret value.
    /// To access that information, first cancel the deletion with <a>RestoreSecret</a> and
    /// then retrieve the information.
    /// </para>
    /// </summary>
    public partial class DeleteSecretRequest : AmazonSecretsManagerRequest
    {
        private bool? _forceDeleteWithoutRecovery;
        private long? _recoveryWindowInDays;
        private string _secretId;

        /// <summary>
        /// Gets and sets the property ForceDeleteWithoutRecovery. 
        /// <para>
        /// Specifies whether to delete the secret without any recovery window. You can't use
        /// both this parameter and <code>RecoveryWindowInDays</code> in the same call. If you
        /// don't use either, then Secrets Manager defaults to a 30 day recovery window.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager performs the actual deletion with an asynchronous background process,
        /// so there might be a short delay before the secret is permanently deleted. If you delete
        /// a secret and then immediately create a secret with the same name, use appropriate
        /// back off and retry logic.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use this parameter with caution. This parameter causes the operation to skip the normal
        /// recovery window before the permanent deletion that Secrets Manager would normally
        /// impose with the <code>RecoveryWindowInDays</code> parameter. If you delete a secret
        /// with the <code>ForceDeleteWithouRecovery</code> parameter, then you have no opportunity
        /// to recover the secret. You lose the secret permanently.
        /// </para>
        ///  </important>
        /// </summary>
        public bool ForceDeleteWithoutRecovery
        {
            get { return this._forceDeleteWithoutRecovery.GetValueOrDefault(); }
            set { this._forceDeleteWithoutRecovery = value; }
        }

        // Check to see if ForceDeleteWithoutRecovery property is set
        internal bool IsSetForceDeleteWithoutRecovery()
        {
            return this._forceDeleteWithoutRecovery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryWindowInDays. 
        /// <para>
        /// The number of days from 7 to 30 that Secrets Manager waits before permanently deleting
        /// the secret. You can't use both this parameter and <code>ForceDeleteWithoutRecovery</code>
        /// in the same call. If you don't use either, then Secrets Manager defaults to a 30 day
        /// recovery window.
        /// </para>
        /// </summary>
        public long RecoveryWindowInDays
        {
            get { return this._recoveryWindowInDays.GetValueOrDefault(); }
            set { this._recoveryWindowInDays = value; }
        }

        // Check to see if RecoveryWindowInDays property is set
        internal bool IsSetRecoveryWindowInDays()
        {
            return this._recoveryWindowInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretId. 
        /// <para>
        /// The ARN or name of the secret to delete.
        /// </para>
        ///  
        /// <para>
        /// For an ARN, we recommend that you specify a complete ARN rather than a partial ARN.
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