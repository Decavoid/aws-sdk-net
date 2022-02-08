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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The encryption configuration to use when storing the generated manifest.
    /// </summary>
    public partial class GeneratedManifestEncryption
    {
        private SSEKMSEncryption _ssekms;
        private SSES3Encryption _sses3;

        /// <summary>
        /// Gets and sets the property SSEKMS. 
        /// <para>
        /// Configuration details on how SSE-KMS is used to encrypt generated manifest objects.
        /// </para>
        /// </summary>
        public SSEKMSEncryption SSEKMS
        {
            get { return this._ssekms; }
            set { this._ssekms = value; }
        }

        // Check to see if SSEKMS property is set
        internal bool IsSetSSEKMS()
        {
            return this._ssekms != null;
        }

        /// <summary>
        /// Gets and sets the property SSES3. 
        /// <para>
        /// Specifies the use of SSE-S3 to encrypt generated manifest objects.
        /// </para>
        /// </summary>
        public SSES3Encryption SSES3
        {
            get { return this._sses3; }
            set { this._sses3 = value; }
        }

        // Check to see if SSES3 property is set
        internal bool IsSetSSES3()
        {
            return this._sses3 != null;
        }

    }
}