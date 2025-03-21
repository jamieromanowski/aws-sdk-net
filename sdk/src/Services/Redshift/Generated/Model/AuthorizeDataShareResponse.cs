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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the AuthorizeDataShare operation.
    /// </summary>
    public partial class AuthorizeDataShareResponse : AmazonWebServiceResponse
    {
        private bool? _allowPubliclyAccessibleConsumers;
        private string _dataShareArn;
        private List<DataShareAssociation> _dataShareAssociations = new List<DataShareAssociation>();
        private string _managedBy;
        private string _producerArn;

        /// <summary>
        /// Gets and sets the property AllowPubliclyAccessibleConsumers. 
        /// <para>
        /// A value that specifies whether the datashare can be shared to a publicly accessible
        /// cluster.
        /// </para>
        /// </summary>
        public bool AllowPubliclyAccessibleConsumers
        {
            get { return this._allowPubliclyAccessibleConsumers.GetValueOrDefault(); }
            set { this._allowPubliclyAccessibleConsumers = value; }
        }

        // Check to see if AllowPubliclyAccessibleConsumers property is set
        internal bool IsSetAllowPubliclyAccessibleConsumers()
        {
            return this._allowPubliclyAccessibleConsumers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that references the datashare that is owned by a specific
        /// namespace of the producer cluster. A datashare ARN is in the <code>arn:aws:redshift:{region}:{account-id}:{datashare}:{namespace-guid}/{datashare-name}</code>
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DataShareArn
        {
            get { return this._dataShareArn; }
            set { this._dataShareArn = value; }
        }

        // Check to see if DataShareArn property is set
        internal bool IsSetDataShareArn()
        {
            return this._dataShareArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataShareAssociations. 
        /// <para>
        /// A value that specifies when the datashare has an association between a producer and
        /// data consumers.
        /// </para>
        /// </summary>
        public List<DataShareAssociation> DataShareAssociations
        {
            get { return this._dataShareAssociations; }
            set { this._dataShareAssociations = value; }
        }

        // Check to see if DataShareAssociations property is set
        internal bool IsSetDataShareAssociations()
        {
            return this._dataShareAssociations != null && this._dataShareAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The identifier of a datashare to show its managing entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ManagedBy
        {
            get { return this._managedBy; }
            set { this._managedBy = value; }
        }

        // Check to see if ManagedBy property is set
        internal bool IsSetManagedBy()
        {
            return this._managedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ProducerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the producer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ProducerArn
        {
            get { return this._producerArn; }
            set { this._producerArn = value; }
        }

        // Check to see if ProducerArn property is set
        internal bool IsSetProducerArn()
        {
            return this._producerArn != null;
        }

    }
}