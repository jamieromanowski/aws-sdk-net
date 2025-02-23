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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBotVersion operation.
    /// Deletes a specific version of a bot. To delete all version of a bot, use the <a href="https://docs.aws.amazon.com/lexv2/latest/dg/API_DeleteBot.html">DeleteBot</a>
    /// operation.
    /// </summary>
    public partial class DeleteBotVersionRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private string _botVersion;
        private bool? _skipResourceInUseCheck;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier of the bot that contains the version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property BotVersion. 
        /// <para>
        /// The version of the bot to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string BotVersion
        {
            get { return this._botVersion; }
            set { this._botVersion = value; }
        }

        // Check to see if BotVersion property is set
        internal bool IsSetBotVersion()
        {
            return this._botVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// By default, the <code>DeleteBotVersion</code> operations throws a <code>ResourceInUseException</code>
        /// exception if you try to delete a bot version that has an alias pointing at it. Set
        /// the <code>skipResourceInUseCheck</code> parameter to <code>true</code> to skip this
        /// check and remove the version even if an alias points to it.
        /// </para>
        /// </summary>
        public bool SkipResourceInUseCheck
        {
            get { return this._skipResourceInUseCheck.GetValueOrDefault(); }
            set { this._skipResourceInUseCheck = value; }
        }

        // Check to see if SkipResourceInUseCheck property is set
        internal bool IsSetSkipResourceInUseCheck()
        {
            return this._skipResourceInUseCheck.HasValue; 
        }

    }
}