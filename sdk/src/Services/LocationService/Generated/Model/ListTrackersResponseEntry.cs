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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains the tracker resource details.
    /// </summary>
    public partial class ListTrackersResponseEntry
    {
        private DateTime? _createTime;
        private string _description;
        private PricingPlan _pricingPlan;
        private string _pricingPlanDataSource;
        private string _trackerName;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp for when the tracker resource was created in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlan. 
        /// <para>
        /// The pricing plan for the specified tracker resource.
        /// </para>
        ///  
        /// <para>
        /// For additional details and restrictions on each pricing plan option, see <a href="https://aws.amazon.com/location/pricing/">Amazon
        /// Location Service pricing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PricingPlan PricingPlan
        {
            get { return this._pricingPlan; }
            set { this._pricingPlan = value; }
        }

        // Check to see if PricingPlan property is set
        internal bool IsSetPricingPlan()
        {
            return this._pricingPlan != null;
        }

        /// <summary>
        /// Gets and sets the property PricingPlanDataSource. 
        /// <para>
        /// The specified data provider for the tracker resource.
        /// </para>
        /// </summary>
        public string PricingPlanDataSource
        {
            get { return this._pricingPlanDataSource; }
            set { this._pricingPlanDataSource = value; }
        }

        // Check to see if PricingPlanDataSource property is set
        internal bool IsSetPricingPlanDataSource()
        {
            return this._pricingPlanDataSource != null;
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The timestamp at which the device's position was determined. Uses <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601</a> format: <code>YYYY-MM-DDThh:mm:ss.sssZ</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}