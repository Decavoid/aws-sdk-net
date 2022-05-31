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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the ListVocabularyFilters operation.
    /// </summary>
    public partial class ListVocabularyFiltersResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<VocabularyFilterInfo> _vocabularyFilters = new List<VocabularyFilterInfo>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>NextToken</code> is present in your response, it indicates that not all results
        /// are displayed. To view the next set of results, copy the string associated with the
        /// <code>NextToken</code> parameter in your results output, then run your request again
        /// including <code>NextToken</code> with the value of the copied string. Repeat as needed
        /// to view all your results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property VocabularyFilters. 
        /// <para>
        /// Provides information about the custom vocabulary filters that match the criteria specified
        /// in your request.
        /// </para>
        /// </summary>
        public List<VocabularyFilterInfo> VocabularyFilters
        {
            get { return this._vocabularyFilters; }
            set { this._vocabularyFilters = value; }
        }

        // Check to see if VocabularyFilters property is set
        internal bool IsSetVocabularyFilters()
        {
            return this._vocabularyFilters != null && this._vocabularyFilters.Count > 0; 
        }

    }
}