/*
 * LUSID API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// IndexModelOptionsAllOf
    /// </summary>
    [DataContract(Name = "IndexModelOptions_allOf")]
    public partial class IndexModelOptionsAllOf : IEquatable<IndexModelOptionsAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: Sum, AbsoluteSum, Unity
        /// </summary>
        /// <value>The available values are: Sum, AbsoluteSum, Unity</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PortfolioScalingEnum
        {
            /// <summary>
            /// Enum Sum for value: Sum
            /// </summary>
            [EnumMember(Value = "Sum")]
            Sum = 1,

            /// <summary>
            /// Enum AbsoluteSum for value: AbsoluteSum
            /// </summary>
            [EnumMember(Value = "AbsoluteSum")]
            AbsoluteSum = 2,

            /// <summary>
            /// Enum Unity for value: Unity
            /// </summary>
            [EnumMember(Value = "Unity")]
            Unity = 3

        }


        /// <summary>
        /// The available values are: Sum, AbsoluteSum, Unity
        /// </summary>
        /// <value>The available values are: Sum, AbsoluteSum, Unity</value>
        [DataMember(Name = "portfolioScaling", IsRequired = true, EmitDefaultValue = true)]
        public PortfolioScalingEnum PortfolioScaling { get; set; }
        /// <summary>
        /// The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions
        /// </summary>
        /// <value>The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModelOptionsTypeEnum
        {
            /// <summary>
            /// Enum Invalid for value: Invalid
            /// </summary>
            [EnumMember(Value = "Invalid")]
            Invalid = 1,

            /// <summary>
            /// Enum OpaqueModelOptions for value: OpaqueModelOptions
            /// </summary>
            [EnumMember(Value = "OpaqueModelOptions")]
            OpaqueModelOptions = 2,

            /// <summary>
            /// Enum EmptyModelOptions for value: EmptyModelOptions
            /// </summary>
            [EnumMember(Value = "EmptyModelOptions")]
            EmptyModelOptions = 3,

            /// <summary>
            /// Enum IndexModelOptions for value: IndexModelOptions
            /// </summary>
            [EnumMember(Value = "IndexModelOptions")]
            IndexModelOptions = 4,

            /// <summary>
            /// Enum FxForwardModelOptions for value: FxForwardModelOptions
            /// </summary>
            [EnumMember(Value = "FxForwardModelOptions")]
            FxForwardModelOptions = 5,

            /// <summary>
            /// Enum FundingLegModelOptions for value: FundingLegModelOptions
            /// </summary>
            [EnumMember(Value = "FundingLegModelOptions")]
            FundingLegModelOptions = 6,

            /// <summary>
            /// Enum EquityModelOptions for value: EquityModelOptions
            /// </summary>
            [EnumMember(Value = "EquityModelOptions")]
            EquityModelOptions = 7,

            /// <summary>
            /// Enum LookUpPricingModelOptions for value: LookUpPricingModelOptions
            /// </summary>
            [EnumMember(Value = "LookUpPricingModelOptions")]
            LookUpPricingModelOptions = 8

        }


        /// <summary>
        /// The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions
        /// </summary>
        /// <value>The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions</value>
        [DataMember(Name = "modelOptionsType", IsRequired = true, EmitDefaultValue = true)]
        public ModelOptionsTypeEnum ModelOptionsType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelOptionsAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndexModelOptionsAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelOptionsAllOf" /> class.
        /// </summary>
        /// <param name="portfolioScaling">The available values are: Sum, AbsoluteSum, Unity (required).</param>
        /// <param name="modelOptionsType">The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, LookUpPricingModelOptions (required).</param>
        public IndexModelOptionsAllOf(PortfolioScalingEnum portfolioScaling = default(PortfolioScalingEnum), ModelOptionsTypeEnum modelOptionsType = default(ModelOptionsTypeEnum))
        {
            this.PortfolioScaling = portfolioScaling;
            this.ModelOptionsType = modelOptionsType;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndexModelOptionsAllOf {\n");
            sb.Append("  PortfolioScaling: ").Append(PortfolioScaling).Append("\n");
            sb.Append("  ModelOptionsType: ").Append(ModelOptionsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IndexModelOptionsAllOf);
        }

        /// <summary>
        /// Returns true if IndexModelOptionsAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of IndexModelOptionsAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndexModelOptionsAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PortfolioScaling == input.PortfolioScaling ||
                    this.PortfolioScaling.Equals(input.PortfolioScaling)
                ) && 
                (
                    this.ModelOptionsType == input.ModelOptionsType ||
                    this.ModelOptionsType.Equals(input.ModelOptionsType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.PortfolioScaling.GetHashCode();
                hashCode = (hashCode * 59) + this.ModelOptionsType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
