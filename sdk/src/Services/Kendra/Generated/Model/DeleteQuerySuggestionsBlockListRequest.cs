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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteQuerySuggestionsBlockList operation.
    /// Deletes a block list used for query suggestions for an index.
    /// 
    ///  
    /// <para>
    /// A deleted block list might not take effect right away. Amazon Kendra needs to refresh
    /// the entire suggestions list to add back the queries that were previously blocked.
    /// </para>
    ///  
    /// <para>
    ///  <code>DeleteQuerySuggestionsBlockList</code> is currently not supported in the Amazon
    /// Web Services GovCloud (US-West) region.
    /// </para>
    /// </summary>
    public partial class DeleteQuerySuggestionsBlockListRequest : AmazonKendraRequest
    {
        private string _id;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the block list that needs to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the you want to delete a block list from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}