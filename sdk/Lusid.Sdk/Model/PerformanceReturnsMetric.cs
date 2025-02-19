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
    /// The request used in the AggregatedReturns.
    /// </summary>
    [DataContract(Name = "PerformanceReturnsMetric")]
    public partial class PerformanceReturnsMetric : IEquatable<PerformanceReturnsMetric>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceReturnsMetric" /> class.
        /// </summary>
        /// <param name="type">The type of the metric. Default to Return.</param>
        /// <param name="window">The given metric for the calculation i.e. 1Y, 1D..</param>
        /// <param name="allowPartial">Bool if the metric is allowed partial results. Deafult to false..</param>
        /// <param name="annualised">Bool if the metric is annualized. Default to false..</param>
        /// <param name="withFee">Bool if the metric should consider the fees when is calculated. Default to false..</param>
        /// <param name="seedAmount">The given seed amount for the calculation of the indicative amount metrics..</param>
        /// <param name="alias">The alias for the metric..</param>
        public PerformanceReturnsMetric(string type = default(string), string window = default(string), bool allowPartial = default(bool), bool annualised = default(bool), bool withFee = default(bool), string seedAmount = default(string), string alias = default(string))
        {
            this.Type = type;
            this.Window = window;
            this.AllowPartial = allowPartial;
            this.Annualised = annualised;
            this.WithFee = withFee;
            this.SeedAmount = seedAmount;
            this.Alias = alias;
        }

        /// <summary>
        /// The type of the metric. Default to Return
        /// </summary>
        /// <value>The type of the metric. Default to Return</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The given metric for the calculation i.e. 1Y, 1D.
        /// </summary>
        /// <value>The given metric for the calculation i.e. 1Y, 1D.</value>
        [DataMember(Name = "window", EmitDefaultValue = true)]
        public string Window { get; set; }

        /// <summary>
        /// Bool if the metric is allowed partial results. Deafult to false.
        /// </summary>
        /// <value>Bool if the metric is allowed partial results. Deafult to false.</value>
        [DataMember(Name = "allowPartial", EmitDefaultValue = true)]
        public bool AllowPartial { get; set; }

        /// <summary>
        /// Bool if the metric is annualized. Default to false.
        /// </summary>
        /// <value>Bool if the metric is annualized. Default to false.</value>
        [DataMember(Name = "annualised", EmitDefaultValue = true)]
        public bool Annualised { get; set; }

        /// <summary>
        /// Bool if the metric should consider the fees when is calculated. Default to false.
        /// </summary>
        /// <value>Bool if the metric should consider the fees when is calculated. Default to false.</value>
        [DataMember(Name = "withFee", EmitDefaultValue = true)]
        public bool WithFee { get; set; }

        /// <summary>
        /// The given seed amount for the calculation of the indicative amount metrics.
        /// </summary>
        /// <value>The given seed amount for the calculation of the indicative amount metrics.</value>
        [DataMember(Name = "seedAmount", EmitDefaultValue = true)]
        public string SeedAmount { get; set; }

        /// <summary>
        /// The alias for the metric.
        /// </summary>
        /// <value>The alias for the metric.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PerformanceReturnsMetric {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Window: ").Append(Window).Append("\n");
            sb.Append("  AllowPartial: ").Append(AllowPartial).Append("\n");
            sb.Append("  Annualised: ").Append(Annualised).Append("\n");
            sb.Append("  WithFee: ").Append(WithFee).Append("\n");
            sb.Append("  SeedAmount: ").Append(SeedAmount).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
            return this.Equals(input as PerformanceReturnsMetric);
        }

        /// <summary>
        /// Returns true if PerformanceReturnsMetric instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceReturnsMetric to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceReturnsMetric input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Window == input.Window ||
                    (this.Window != null &&
                    this.Window.Equals(input.Window))
                ) && 
                (
                    this.AllowPartial == input.AllowPartial ||
                    this.AllowPartial.Equals(input.AllowPartial)
                ) && 
                (
                    this.Annualised == input.Annualised ||
                    this.Annualised.Equals(input.Annualised)
                ) && 
                (
                    this.WithFee == input.WithFee ||
                    this.WithFee.Equals(input.WithFee)
                ) && 
                (
                    this.SeedAmount == input.SeedAmount ||
                    (this.SeedAmount != null &&
                    this.SeedAmount.Equals(input.SeedAmount))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Window != null)
                {
                    hashCode = (hashCode * 59) + this.Window.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowPartial.GetHashCode();
                hashCode = (hashCode * 59) + this.Annualised.GetHashCode();
                hashCode = (hashCode * 59) + this.WithFee.GetHashCode();
                if (this.SeedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SeedAmount.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
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
