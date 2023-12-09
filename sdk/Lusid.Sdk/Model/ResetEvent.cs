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
    /// Definition of a reset event.  This is an event that describes a reset or fixing for an instrument such as the floating payment on  a swap cash flow.
    /// </summary>
    [DataContract(Name = "ResetEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class ResetEvent : InstrumentEvent, IEquatable<ResetEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResetEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetEvent" /> class.
        /// </summary>
        /// <param name="value">The quantity associated with the reset. This will only be populated if the information is known..</param>
        /// <param name="resetType">The type of the reset; e.g. RIC, Currency-pair (required).</param>
        /// <param name="fixingSource">Fixing identification source, if available..</param>
        /// <param name="eventStatus">What is the event status, is it a known (ie historic) or unknown (ie projected) event? (required).</param>
        /// <param name="fixingDate">The date the reset fixes, or is observed upon. (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent (required) (default to &quot;ResetEvent&quot;).</param>
        public ResetEvent(decimal? value = default(decimal?), string resetType = default(string), string fixingSource = default(string), string eventStatus = default(string), DateTimeOffset fixingDate = default(DateTimeOffset), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            // to ensure "resetType" is required (not null)
            if (resetType == null)
            {
                throw new ArgumentNullException("resetType is a required property for ResetEvent and cannot be null");
            }
            this.ResetType = resetType;
            // to ensure "eventStatus" is required (not null)
            if (eventStatus == null)
            {
                throw new ArgumentNullException("eventStatus is a required property for ResetEvent and cannot be null");
            }
            this.EventStatus = eventStatus;
            this.FixingDate = fixingDate;
            this.Value = value;
            this.FixingSource = fixingSource;
        }

        /// <summary>
        /// The quantity associated with the reset. This will only be populated if the information is known.
        /// </summary>
        /// <value>The quantity associated with the reset. This will only be populated if the information is known.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public decimal? Value { get; set; }

        /// <summary>
        /// The type of the reset; e.g. RIC, Currency-pair
        /// </summary>
        /// <value>The type of the reset; e.g. RIC, Currency-pair</value>
        [DataMember(Name = "resetType", IsRequired = true, EmitDefaultValue = true)]
        public string ResetType { get; set; }

        /// <summary>
        /// Fixing identification source, if available.
        /// </summary>
        /// <value>Fixing identification source, if available.</value>
        [DataMember(Name = "fixingSource", EmitDefaultValue = true)]
        public string FixingSource { get; set; }

        /// <summary>
        /// What is the event status, is it a known (ie historic) or unknown (ie projected) event?
        /// </summary>
        /// <value>What is the event status, is it a known (ie historic) or unknown (ie projected) event?</value>
        [DataMember(Name = "eventStatus", IsRequired = true, EmitDefaultValue = true)]
        public string EventStatus { get; set; }

        /// <summary>
        /// The date the reset fixes, or is observed upon.
        /// </summary>
        /// <value>The date the reset fixes, or is observed upon.</value>
        [DataMember(Name = "fixingDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset FixingDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResetEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ResetType: ").Append(ResetType).Append("\n");
            sb.Append("  FixingSource: ").Append(FixingSource).Append("\n");
            sb.Append("  EventStatus: ").Append(EventStatus).Append("\n");
            sb.Append("  FixingDate: ").Append(FixingDate).Append("\n");
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
            return this.Equals(input as ResetEvent);
        }

        /// <summary>
        /// Returns true if ResetEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ResetEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResetEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.ResetType == input.ResetType ||
                    (this.ResetType != null &&
                    this.ResetType.Equals(input.ResetType))
                ) && base.Equals(input) && 
                (
                    this.FixingSource == input.FixingSource ||
                    (this.FixingSource != null &&
                    this.FixingSource.Equals(input.FixingSource))
                ) && base.Equals(input) && 
                (
                    this.EventStatus == input.EventStatus ||
                    (this.EventStatus != null &&
                    this.EventStatus.Equals(input.EventStatus))
                ) && base.Equals(input) && 
                (
                    this.FixingDate == input.FixingDate ||
                    (this.FixingDate != null &&
                    this.FixingDate.Equals(input.FixingDate))
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
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.ResetType != null)
                {
                    hashCode = (hashCode * 59) + this.ResetType.GetHashCode();
                }
                if (this.FixingSource != null)
                {
                    hashCode = (hashCode * 59) + this.FixingSource.GetHashCode();
                }
                if (this.EventStatus != null)
                {
                    hashCode = (hashCode * 59) + this.EventStatus.GetHashCode();
                }
                if (this.FixingDate != null)
                {
                    hashCode = (hashCode * 59) + this.FixingDate.GetHashCode();
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
            // ResetType (string) minLength
            if (this.ResetType != null && this.ResetType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResetType, length must be greater than 1.", new [] { "ResetType" });
            }

            // EventStatus (string) minLength
            if (this.EventStatus != null && this.EventStatus.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventStatus, length must be greater than 1.", new [] { "EventStatus" });
            }

            yield break;
        }
    }
}
