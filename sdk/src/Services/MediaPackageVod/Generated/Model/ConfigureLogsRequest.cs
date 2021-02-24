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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Container for the parameters to the ConfigureLogs operation.
    /// Changes the packaging group's properities to configure log subscription
    /// </summary>
    public partial class ConfigureLogsRequest : AmazonMediaPackageVodRequest
    {
        private EgressAccessLogs _egressAccessLogs;
        private string _id;

        /// <summary>
        /// Gets and sets the property EgressAccessLogs.
        /// </summary>
        public EgressAccessLogs EgressAccessLogs
        {
            get { return this._egressAccessLogs; }
            set { this._egressAccessLogs = value; }
        }

        // Check to see if EgressAccessLogs property is set
        internal bool IsSetEgressAccessLogs()
        {
            return this._egressAccessLogs != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of a MediaPackage VOD PackagingGroup resource.
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}