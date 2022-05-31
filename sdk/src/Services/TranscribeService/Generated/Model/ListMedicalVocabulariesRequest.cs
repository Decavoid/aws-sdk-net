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
    /// Container for the parameters to the ListMedicalVocabularies operation.
    /// Provides a list of custom medical vocabularies that match the specified criteria.
    /// If no criteria are specified, all custom medical vocabularies are returned.
    /// 
    ///  
    /// <para>
    /// To get detailed information about a specific custom medical vocabulary, use the operation.
    /// </para>
    /// </summary>
    public partial class ListMedicalVocabulariesRequest : AmazonTranscribeServiceRequest
    {
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private VocabularyState _stateEquals;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of custom medical vocabularies to return in each page of results.
        /// If there are fewer results than the value you specify, only the actual results are
        /// returned. If you don't specify a value, a default of 5 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Returns only the custom medical vocabularies that contain the specified string. The
        /// search is not case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If your <code>ListMedicalVocabularies</code> request returns more results than can
        /// be displayed, <code>NextToken</code> is displayed in the response with an associated
        /// string. To get the next page of results, copy this string and repeat your request,
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
        /// Gets and sets the property StateEquals. 
        /// <para>
        /// Returns only custom medical vocabularies with the specified state. Vocabularies are
        /// ordered by creation date, with the newest vocabulary first. If you don't include <code>StateEquals</code>,
        /// all custom medical vocabularies are returned.
        /// </para>
        /// </summary>
        public VocabularyState StateEquals
        {
            get { return this._stateEquals; }
            set { this._stateEquals = value; }
        }

        // Check to see if StateEquals property is set
        internal bool IsSetStateEquals()
        {
            return this._stateEquals != null;
        }

    }
}