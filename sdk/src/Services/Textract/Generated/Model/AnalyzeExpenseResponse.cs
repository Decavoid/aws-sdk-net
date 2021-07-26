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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// This is the response object from the AnalyzeExpense operation.
    /// </summary>
    public partial class AnalyzeExpenseResponse : AmazonWebServiceResponse
    {
        private DocumentMetadata _documentMetadata;
        private List<ExpenseDocument> _expenseDocuments = new List<ExpenseDocument>();

        /// <summary>
        /// Gets and sets the property DocumentMetadata.
        /// </summary>
        public DocumentMetadata DocumentMetadata
        {
            get { return this._documentMetadata; }
            set { this._documentMetadata = value; }
        }

        // Check to see if DocumentMetadata property is set
        internal bool IsSetDocumentMetadata()
        {
            return this._documentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ExpenseDocuments. 
        /// <para>
        /// The expenses detected by Amazon Textract.
        /// </para>
        /// </summary>
        public List<ExpenseDocument> ExpenseDocuments
        {
            get { return this._expenseDocuments; }
            set { this._expenseDocuments = value; }
        }

        // Check to see if ExpenseDocuments property is set
        internal bool IsSetExpenseDocuments()
        {
            return this._expenseDocuments != null && this._expenseDocuments.Count > 0; 
        }

    }
}