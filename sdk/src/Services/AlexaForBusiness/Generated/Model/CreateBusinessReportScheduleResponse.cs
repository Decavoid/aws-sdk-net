/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// This is the response object from the CreateBusinessReportSchedule operation.
    /// </summary>
    public partial class CreateBusinessReportScheduleResponse : AmazonWebServiceResponse
    {
        private string _scheduleArn;

        /// <summary>
        /// Gets and sets the property ScheduleArn. 
        /// <para>
        /// The ARN of the business report schedule.
        /// </para>
        /// </summary>
        public string ScheduleArn
        {
            get { return this._scheduleArn; }
            set { this._scheduleArn = value; }
        }

        // Check to see if ScheduleArn property is set
        internal bool IsSetScheduleArn()
        {
            return this._scheduleArn != null;
        }

    }
}