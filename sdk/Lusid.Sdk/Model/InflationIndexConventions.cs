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
    /// A set of conventions that describe the conventions for an inflation index.
    /// </summary>
    [DataContract(Name = "InflationIndexConventions")]
    public partial class InflationIndexConventions : IEquatable<InflationIndexConventions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InflationIndexConventions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InflationIndexConventions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InflationIndexConventions" /> class.
        /// </summary>
        /// <param name="inflationIndexName">Name of the index, e.g. UKRPI. (required).</param>
        /// <param name="currency">Currency of the inflation index convention. (required).</param>
        /// <param name="observationLag">Observation lag. This is a string that must have units of Month.  This field is typically 3 or 4 months, but can vary, older bonds and swaps have 8 months lag.  For Bonds with a calculation type of Ratio, this property, if set, must be 0Invalid. (required).</param>
        /// <param name="inflationInterpolation">Inflation Interpolation. This is optional and defaults to Linear if not set.    Supported string (enumeration) values are: [Linear, Flat]..</param>
        /// <param name="inflationFrequency">Frequency of inflation updated. Optional and defaults to Monthly which is the most common.  However both Australian and New Zealand inflation is published Quarterly. Only tenors of 1M or 3M are supported..</param>
        /// <param name="inflationRollDay">Day of the month that inflation rolls from one month to the next. This is optional and defaults to 1, which is  the typically value for the majority of inflation bonds (exceptions include Japan which rolls on the 10th  and some LatAm bonds which roll on the 15th)..</param>
        public InflationIndexConventions(string inflationIndexName = default(string), string currency = default(string), string observationLag = default(string), string inflationInterpolation = default(string), string inflationFrequency = default(string), int inflationRollDay = default(int))
        {
            // to ensure "inflationIndexName" is required (not null)
            if (inflationIndexName == null)
            {
                throw new ArgumentNullException("inflationIndexName is a required property for InflationIndexConventions and cannot be null");
            }
            this.InflationIndexName = inflationIndexName;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for InflationIndexConventions and cannot be null");
            }
            this.Currency = currency;
            // to ensure "observationLag" is required (not null)
            if (observationLag == null)
            {
                throw new ArgumentNullException("observationLag is a required property for InflationIndexConventions and cannot be null");
            }
            this.ObservationLag = observationLag;
            this.InflationInterpolation = inflationInterpolation;
            this.InflationFrequency = inflationFrequency;
            this.InflationRollDay = inflationRollDay;
        }

        /// <summary>
        /// Name of the index, e.g. UKRPI.
        /// </summary>
        /// <value>Name of the index, e.g. UKRPI.</value>
        [DataMember(Name = "inflationIndexName", IsRequired = true, EmitDefaultValue = true)]
        public string InflationIndexName { get; set; }

        /// <summary>
        /// Currency of the inflation index convention.
        /// </summary>
        /// <value>Currency of the inflation index convention.</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Observation lag. This is a string that must have units of Month.  This field is typically 3 or 4 months, but can vary, older bonds and swaps have 8 months lag.  For Bonds with a calculation type of Ratio, this property, if set, must be 0Invalid.
        /// </summary>
        /// <value>Observation lag. This is a string that must have units of Month.  This field is typically 3 or 4 months, but can vary, older bonds and swaps have 8 months lag.  For Bonds with a calculation type of Ratio, this property, if set, must be 0Invalid.</value>
        [DataMember(Name = "observationLag", IsRequired = true, EmitDefaultValue = true)]
        public string ObservationLag { get; set; }

        /// <summary>
        /// Inflation Interpolation. This is optional and defaults to Linear if not set.    Supported string (enumeration) values are: [Linear, Flat].
        /// </summary>
        /// <value>Inflation Interpolation. This is optional and defaults to Linear if not set.    Supported string (enumeration) values are: [Linear, Flat].</value>
        [DataMember(Name = "inflationInterpolation", EmitDefaultValue = true)]
        public string InflationInterpolation { get; set; }

        /// <summary>
        /// Frequency of inflation updated. Optional and defaults to Monthly which is the most common.  However both Australian and New Zealand inflation is published Quarterly. Only tenors of 1M or 3M are supported.
        /// </summary>
        /// <value>Frequency of inflation updated. Optional and defaults to Monthly which is the most common.  However both Australian and New Zealand inflation is published Quarterly. Only tenors of 1M or 3M are supported.</value>
        [DataMember(Name = "inflationFrequency", EmitDefaultValue = true)]
        public string InflationFrequency { get; set; }

        /// <summary>
        /// Day of the month that inflation rolls from one month to the next. This is optional and defaults to 1, which is  the typically value for the majority of inflation bonds (exceptions include Japan which rolls on the 10th  and some LatAm bonds which roll on the 15th).
        /// </summary>
        /// <value>Day of the month that inflation rolls from one month to the next. This is optional and defaults to 1, which is  the typically value for the majority of inflation bonds (exceptions include Japan which rolls on the 10th  and some LatAm bonds which roll on the 15th).</value>
        [DataMember(Name = "inflationRollDay", EmitDefaultValue = false)]
        public int InflationRollDay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InflationIndexConventions {\n");
            sb.Append("  InflationIndexName: ").Append(InflationIndexName).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ObservationLag: ").Append(ObservationLag).Append("\n");
            sb.Append("  InflationInterpolation: ").Append(InflationInterpolation).Append("\n");
            sb.Append("  InflationFrequency: ").Append(InflationFrequency).Append("\n");
            sb.Append("  InflationRollDay: ").Append(InflationRollDay).Append("\n");
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
            return this.Equals(input as InflationIndexConventions);
        }

        /// <summary>
        /// Returns true if InflationIndexConventions instances are equal
        /// </summary>
        /// <param name="input">Instance of InflationIndexConventions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InflationIndexConventions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InflationIndexName == input.InflationIndexName ||
                    (this.InflationIndexName != null &&
                    this.InflationIndexName.Equals(input.InflationIndexName))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.ObservationLag == input.ObservationLag ||
                    (this.ObservationLag != null &&
                    this.ObservationLag.Equals(input.ObservationLag))
                ) && 
                (
                    this.InflationInterpolation == input.InflationInterpolation ||
                    (this.InflationInterpolation != null &&
                    this.InflationInterpolation.Equals(input.InflationInterpolation))
                ) && 
                (
                    this.InflationFrequency == input.InflationFrequency ||
                    (this.InflationFrequency != null &&
                    this.InflationFrequency.Equals(input.InflationFrequency))
                ) && 
                (
                    this.InflationRollDay == input.InflationRollDay ||
                    this.InflationRollDay.Equals(input.InflationRollDay)
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
                if (this.InflationIndexName != null)
                {
                    hashCode = (hashCode * 59) + this.InflationIndexName.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.ObservationLag != null)
                {
                    hashCode = (hashCode * 59) + this.ObservationLag.GetHashCode();
                }
                if (this.InflationInterpolation != null)
                {
                    hashCode = (hashCode * 59) + this.InflationInterpolation.GetHashCode();
                }
                if (this.InflationFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.InflationFrequency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InflationRollDay.GetHashCode();
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
            // InflationIndexName (string) maxLength
            if (this.InflationIndexName != null && this.InflationIndexName.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InflationIndexName, length must be less than 50.", new [] { "InflationIndexName" });
            }

            // InflationIndexName (string) minLength
            if (this.InflationIndexName != null && this.InflationIndexName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InflationIndexName, length must be greater than 0.", new [] { "InflationIndexName" });
            }

            // ObservationLag (string) maxLength
            if (this.ObservationLag != null && this.ObservationLag.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObservationLag, length must be less than 32.", new [] { "ObservationLag" });
            }

            // ObservationLag (string) minLength
            if (this.ObservationLag != null && this.ObservationLag.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObservationLag, length must be greater than 0.", new [] { "ObservationLag" });
            }

            // InflationInterpolation (string) maxLength
            if (this.InflationInterpolation != null && this.InflationInterpolation.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InflationInterpolation, length must be less than 32.", new [] { "InflationInterpolation" });
            }

            // InflationInterpolation (string) minLength
            if (this.InflationInterpolation != null && this.InflationInterpolation.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InflationInterpolation, length must be greater than 0.", new [] { "InflationInterpolation" });
            }

            // InflationFrequency (string) maxLength
            if (this.InflationFrequency != null && this.InflationFrequency.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InflationFrequency, length must be less than 32.", new [] { "InflationFrequency" });
            }

            // InflationFrequency (string) minLength
            if (this.InflationFrequency != null && this.InflationFrequency.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InflationFrequency, length must be greater than 0.", new [] { "InflationFrequency" });
            }

            yield break;
        }
    }
}
