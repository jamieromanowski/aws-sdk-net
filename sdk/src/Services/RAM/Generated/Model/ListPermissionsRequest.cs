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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the ListPermissions operation.
    /// Retrieves a list of available RAM permissions that you can use for the supported resource
    /// types.
    /// </summary>
    public partial class ListPermissionsRequest : AmazonRAMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the total number of results that you want included on each page of the response.
        /// If you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the number you specify, the <code>NextToken</code>
        /// response element is returned with a value (not null). Include the specified value
        /// as the <code>NextToken</code> request parameter in the next call to the operation
        /// to get the next part of the results. Note that the service might return fewer results
        /// than the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specifies that you want to receive the next page of results. Valid only if you received
        /// a <code>NextToken</code> response in the previous request. If you did, it indicates
        /// that more output is available. Set this parameter to the value provided by the previous
        /// call's <code>NextToken</code> response to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies that you want to list permissions for only the specified resource type.
        /// For example, to list only permissions that apply to EC2 subnets, specify <code>ec2:Subnet</code>.
        /// You can use the <a>ListResourceTypes</a> operation to get the specific string required.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}