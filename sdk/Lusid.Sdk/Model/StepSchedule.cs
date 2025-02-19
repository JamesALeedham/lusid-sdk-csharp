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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Schedule that steps at known dated points in time.  Used in representation of a sinking bond, also called amortisation, steps in coupons for fixed bonds and spreads for floating bonds.
    /// </summary>
    [DataContract(Name = "StepSchedule")]
    [JsonConverter(typeof(JsonSubtypes), "ScheduleType")]
    public partial class StepSchedule : Schedule, IEquatable<StepSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StepSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StepSchedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StepSchedule" /> class.
        /// </summary>
        /// <param name="levelType">The type of shift or adjustment that the quantity represents.    Supported string (enumeration) values are: [Absolute, AbsoluteShift, Percentage, AbsolutePercentage]. (required).</param>
        /// <param name="stepScheduleType">The type of step that this schedule is for.  Supported string (enumeration) values are: [Coupon, Notional, Spread]. (required).</param>
        /// <param name="steps">The level steps which are applied. (required).</param>
        /// <param name="scheduleType">The available values are: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, Invalid (required) (default to &quot;StepSchedule&quot;).</param>
        public StepSchedule(string levelType = default(string), string stepScheduleType = default(string), List<LevelStep> steps = default(List<LevelStep>), ScheduleTypeEnum scheduleType = default(ScheduleTypeEnum)) : base(scheduleType)
        {
            // to ensure "levelType" is required (not null)
            if (levelType == null)
            {
                throw new ArgumentNullException("levelType is a required property for StepSchedule and cannot be null");
            }
            this.LevelType = levelType;
            // to ensure "stepScheduleType" is required (not null)
            if (stepScheduleType == null)
            {
                throw new ArgumentNullException("stepScheduleType is a required property for StepSchedule and cannot be null");
            }
            this.StepScheduleType = stepScheduleType;
            // to ensure "steps" is required (not null)
            if (steps == null)
            {
                throw new ArgumentNullException("steps is a required property for StepSchedule and cannot be null");
            }
            this.Steps = steps;
        }

        /// <summary>
        /// The type of shift or adjustment that the quantity represents.    Supported string (enumeration) values are: [Absolute, AbsoluteShift, Percentage, AbsolutePercentage].
        /// </summary>
        /// <value>The type of shift or adjustment that the quantity represents.    Supported string (enumeration) values are: [Absolute, AbsoluteShift, Percentage, AbsolutePercentage].</value>
        [DataMember(Name = "levelType", IsRequired = true, EmitDefaultValue = true)]
        public string LevelType { get; set; }

        /// <summary>
        /// The type of step that this schedule is for.  Supported string (enumeration) values are: [Coupon, Notional, Spread].
        /// </summary>
        /// <value>The type of step that this schedule is for.  Supported string (enumeration) values are: [Coupon, Notional, Spread].</value>
        [DataMember(Name = "stepScheduleType", IsRequired = true, EmitDefaultValue = true)]
        public string StepScheduleType { get; set; }

        /// <summary>
        /// The level steps which are applied.
        /// </summary>
        /// <value>The level steps which are applied.</value>
        [DataMember(Name = "steps", IsRequired = true, EmitDefaultValue = true)]
        public List<LevelStep> Steps { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StepSchedule {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  LevelType: ").Append(LevelType).Append("\n");
            sb.Append("  StepScheduleType: ").Append(StepScheduleType).Append("\n");
            sb.Append("  Steps: ").Append(Steps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as StepSchedule);
        }

        /// <summary>
        /// Returns true if StepSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of StepSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StepSchedule input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.LevelType == input.LevelType ||
                    (this.LevelType != null &&
                    this.LevelType.Equals(input.LevelType))
                ) && base.Equals(input) && 
                (
                    this.StepScheduleType == input.StepScheduleType ||
                    (this.StepScheduleType != null &&
                    this.StepScheduleType.Equals(input.StepScheduleType))
                ) && base.Equals(input) && 
                (
                    this.Steps == input.Steps ||
                    this.Steps != null &&
                    input.Steps != null &&
                    this.Steps.SequenceEqual(input.Steps)
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
                int hashCode = base.GetHashCode();
                if (this.LevelType != null)
                {
                    hashCode = (hashCode * 59) + this.LevelType.GetHashCode();
                }
                if (this.StepScheduleType != null)
                {
                    hashCode = (hashCode * 59) + this.StepScheduleType.GetHashCode();
                }
                if (this.Steps != null)
                {
                    hashCode = (hashCode * 59) + this.Steps.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            // LevelType (string) minLength
            if (this.LevelType != null && this.LevelType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LevelType, length must be greater than 1.", new [] { "LevelType" });
            }

            // StepScheduleType (string) minLength
            if (this.StepScheduleType != null && this.StepScheduleType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StepScheduleType, length must be greater than 1.", new [] { "StepScheduleType" });
            }

            yield break;
        }
    }
}
