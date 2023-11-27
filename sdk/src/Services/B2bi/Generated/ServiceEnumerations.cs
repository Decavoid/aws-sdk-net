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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.B2bi
{

    /// <summary>
    /// Constants used for properties of type CapabilityType.
    /// </summary>
    public class CapabilityType : ConstantClass
    {

        /// <summary>
        /// Constant Edi for CapabilityType
        /// </summary>
        public static readonly CapabilityType Edi = new CapabilityType("edi");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapabilityType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapabilityType FindValue(string value)
        {
            return FindValue<CapabilityType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapabilityType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileFormat.
    /// </summary>
    public class FileFormat : ConstantClass
    {

        /// <summary>
        /// Constant JSON for FileFormat
        /// </summary>
        public static readonly FileFormat JSON = new FileFormat("JSON");
        /// <summary>
        /// Constant XML for FileFormat
        /// </summary>
        public static readonly FileFormat XML = new FileFormat("XML");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileFormat(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileFormat FindValue(string value)
        {
            return FindValue<FileFormat>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileFormat(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Logging.
    /// </summary>
    public class Logging : ConstantClass
    {

        /// <summary>
        /// Constant DISABLED for Logging
        /// </summary>
        public static readonly Logging DISABLED = new Logging("DISABLED");
        /// <summary>
        /// Constant ENABLED for Logging
        /// </summary>
        public static readonly Logging ENABLED = new Logging("ENABLED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Logging(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Logging FindValue(string value)
        {
            return FindValue<Logging>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Logging(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformerJobStatus.
    /// </summary>
    public class TransformerJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for TransformerJobStatus
        /// </summary>
        public static readonly TransformerJobStatus Failed = new TransformerJobStatus("failed");
        /// <summary>
        /// Constant Running for TransformerJobStatus
        /// </summary>
        public static readonly TransformerJobStatus Running = new TransformerJobStatus("running");
        /// <summary>
        /// Constant Succeeded for TransformerJobStatus
        /// </summary>
        public static readonly TransformerJobStatus Succeeded = new TransformerJobStatus("succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformerJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformerJobStatus FindValue(string value)
        {
            return FindValue<TransformerJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformerJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformerStatus.
    /// </summary>
    public class TransformerStatus : ConstantClass
    {

        /// <summary>
        /// Constant Active for TransformerStatus
        /// </summary>
        public static readonly TransformerStatus Active = new TransformerStatus("active");
        /// <summary>
        /// Constant Inactive for TransformerStatus
        /// </summary>
        public static readonly TransformerStatus Inactive = new TransformerStatus("inactive");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformerStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformerStatus FindValue(string value)
        {
            return FindValue<TransformerStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformerStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12TransactionSet.
    /// </summary>
    public class X12TransactionSet : ConstantClass
    {

        /// <summary>
        /// Constant X12_110 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_110 = new X12TransactionSet("X12_110");
        /// <summary>
        /// Constant X12_180 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_180 = new X12TransactionSet("X12_180");
        /// <summary>
        /// Constant X12_204 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_204 = new X12TransactionSet("X12_204");
        /// <summary>
        /// Constant X12_210 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_210 = new X12TransactionSet("X12_210");
        /// <summary>
        /// Constant X12_214 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_214 = new X12TransactionSet("X12_214");
        /// <summary>
        /// Constant X12_215 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_215 = new X12TransactionSet("X12_215");
        /// <summary>
        /// Constant X12_310 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_310 = new X12TransactionSet("X12_310");
        /// <summary>
        /// Constant X12_315 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_315 = new X12TransactionSet("X12_315");
        /// <summary>
        /// Constant X12_322 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_322 = new X12TransactionSet("X12_322");
        /// <summary>
        /// Constant X12_404 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_404 = new X12TransactionSet("X12_404");
        /// <summary>
        /// Constant X12_410 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_410 = new X12TransactionSet("X12_410");
        /// <summary>
        /// Constant X12_820 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_820 = new X12TransactionSet("X12_820");
        /// <summary>
        /// Constant X12_824 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_824 = new X12TransactionSet("X12_824");
        /// <summary>
        /// Constant X12_830 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_830 = new X12TransactionSet("X12_830");
        /// <summary>
        /// Constant X12_846 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_846 = new X12TransactionSet("X12_846");
        /// <summary>
        /// Constant X12_850 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_850 = new X12TransactionSet("X12_850");
        /// <summary>
        /// Constant X12_852 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_852 = new X12TransactionSet("X12_852");
        /// <summary>
        /// Constant X12_855 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_855 = new X12TransactionSet("X12_855");
        /// <summary>
        /// Constant X12_856 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_856 = new X12TransactionSet("X12_856");
        /// <summary>
        /// Constant X12_860 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_860 = new X12TransactionSet("X12_860");
        /// <summary>
        /// Constant X12_861 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_861 = new X12TransactionSet("X12_861");
        /// <summary>
        /// Constant X12_864 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_864 = new X12TransactionSet("X12_864");
        /// <summary>
        /// Constant X12_940 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_940 = new X12TransactionSet("X12_940");
        /// <summary>
        /// Constant X12_990 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_990 = new X12TransactionSet("X12_990");
        /// <summary>
        /// Constant X12_997 for X12TransactionSet
        /// </summary>
        public static readonly X12TransactionSet X12_997 = new X12TransactionSet("X12_997");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12TransactionSet(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12TransactionSet FindValue(string value)
        {
            return FindValue<X12TransactionSet>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12TransactionSet(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type X12Version.
    /// </summary>
    public class X12Version : ConstantClass
    {

        /// <summary>
        /// Constant VERSION_4010 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_4010 = new X12Version("VERSION_4010");
        /// <summary>
        /// Constant VERSION_4030 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_4030 = new X12Version("VERSION_4030");
        /// <summary>
        /// Constant VERSION_5010 for X12Version
        /// </summary>
        public static readonly X12Version VERSION_5010 = new X12Version("VERSION_5010");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public X12Version(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static X12Version FindValue(string value)
        {
            return FindValue<X12Version>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator X12Version(string value)
        {
            return FindValue(value);
        }
    }

}