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
    /// TriggerEventAllOf
    /// </summary>
    [DataContract(Name = "TriggerEvent_allOf")]
    public partial class TriggerEventAllOf : IEquatable<TriggerEventAllOf>, IValidatableObject
    {
        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentEventTypeEnum
        {
            /// <summary>
            /// Enum TransitionEvent for value: TransitionEvent
            /// </summary>
            [EnumMember(Value = "TransitionEvent")]
            TransitionEvent = 1,

            /// <summary>
            /// Enum InformationalEvent for value: InformationalEvent
            /// </summary>
            [EnumMember(Value = "InformationalEvent")]
            InformationalEvent = 2,

            /// <summary>
            /// Enum OpenEvent for value: OpenEvent
            /// </summary>
            [EnumMember(Value = "OpenEvent")]
            OpenEvent = 3,

            /// <summary>
            /// Enum CloseEvent for value: CloseEvent
            /// </summary>
            [EnumMember(Value = "CloseEvent")]
            CloseEvent = 4,

            /// <summary>
            /// Enum StockSplitEvent for value: StockSplitEvent
            /// </summary>
            [EnumMember(Value = "StockSplitEvent")]
            StockSplitEvent = 5,

            /// <summary>
            /// Enum BondDefaultEvent for value: BondDefaultEvent
            /// </summary>
            [EnumMember(Value = "BondDefaultEvent")]
            BondDefaultEvent = 6,

            /// <summary>
            /// Enum CashDividendEvent for value: CashDividendEvent
            /// </summary>
            [EnumMember(Value = "CashDividendEvent")]
            CashDividendEvent = 7,

            /// <summary>
            /// Enum AmortisationEvent for value: AmortisationEvent
            /// </summary>
            [EnumMember(Value = "AmortisationEvent")]
            AmortisationEvent = 8,

            /// <summary>
            /// Enum CashFlowEvent for value: CashFlowEvent
            /// </summary>
            [EnumMember(Value = "CashFlowEvent")]
            CashFlowEvent = 9,

            /// <summary>
            /// Enum ExerciseEvent for value: ExerciseEvent
            /// </summary>
            [EnumMember(Value = "ExerciseEvent")]
            ExerciseEvent = 10,

            /// <summary>
            /// Enum ResetEvent for value: ResetEvent
            /// </summary>
            [EnumMember(Value = "ResetEvent")]
            ResetEvent = 11,

            /// <summary>
            /// Enum TriggerEvent for value: TriggerEvent
            /// </summary>
            [EnumMember(Value = "TriggerEvent")]
            TriggerEvent = 12,

            /// <summary>
            /// Enum RawVendorEvent for value: RawVendorEvent
            /// </summary>
            [EnumMember(Value = "RawVendorEvent")]
            RawVendorEvent = 13,

            /// <summary>
            /// Enum InformationalErrorEvent for value: InformationalErrorEvent
            /// </summary>
            [EnumMember(Value = "InformationalErrorEvent")]
            InformationalErrorEvent = 14,

            /// <summary>
            /// Enum BondCouponEvent for value: BondCouponEvent
            /// </summary>
            [EnumMember(Value = "BondCouponEvent")]
            BondCouponEvent = 15,

            /// <summary>
            /// Enum DividendReinvestmentEvent for value: DividendReinvestmentEvent
            /// </summary>
            [EnumMember(Value = "DividendReinvestmentEvent")]
            DividendReinvestmentEvent = 16,

            /// <summary>
            /// Enum AccumulationEvent for value: AccumulationEvent
            /// </summary>
            [EnumMember(Value = "AccumulationEvent")]
            AccumulationEvent = 17,

            /// <summary>
            /// Enum BondPrincipalEvent for value: BondPrincipalEvent
            /// </summary>
            [EnumMember(Value = "BondPrincipalEvent")]
            BondPrincipalEvent = 18,

            /// <summary>
            /// Enum DividendOptionEvent for value: DividendOptionEvent
            /// </summary>
            [EnumMember(Value = "DividendOptionEvent")]
            DividendOptionEvent = 19

        }


        /// <summary>
        /// The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent
        /// </summary>
        /// <value>The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent</value>
        [DataMember(Name = "instrumentEventType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentEventTypeEnum InstrumentEventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TriggerEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerEventAllOf" /> class.
        /// </summary>
        /// <param name="level">The underlying price level that triggers the event (required).</param>
        /// <param name="triggerType">The type of the trigger; valid options are Knock-In, Knock-Out, Touch or No-Touch (required).</param>
        /// <param name="triggerDirection">The direction of the trigger; valid options are Up and Down (required).</param>
        /// <param name="triggerDate">The date the trigger happens at. (required).</param>
        /// <param name="maturityDate">The date the trigger takes effect. (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent (required).</param>
        public TriggerEventAllOf(decimal level = default(decimal), string triggerType = default(string), string triggerDirection = default(string), DateTimeOffset triggerDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            this.Level = level;
            // to ensure "triggerType" is required (not null)
            if (triggerType == null)
            {
                throw new ArgumentNullException("triggerType is a required property for TriggerEventAllOf and cannot be null");
            }
            this.TriggerType = triggerType;
            // to ensure "triggerDirection" is required (not null)
            if (triggerDirection == null)
            {
                throw new ArgumentNullException("triggerDirection is a required property for TriggerEventAllOf and cannot be null");
            }
            this.TriggerDirection = triggerDirection;
            this.TriggerDate = triggerDate;
            this.MaturityDate = maturityDate;
            this.InstrumentEventType = instrumentEventType;
        }

        /// <summary>
        /// The underlying price level that triggers the event
        /// </summary>
        /// <value>The underlying price level that triggers the event</value>
        [DataMember(Name = "level", IsRequired = true, EmitDefaultValue = true)]
        public decimal Level { get; set; }

        /// <summary>
        /// The type of the trigger; valid options are Knock-In, Knock-Out, Touch or No-Touch
        /// </summary>
        /// <value>The type of the trigger; valid options are Knock-In, Knock-Out, Touch or No-Touch</value>
        [DataMember(Name = "triggerType", IsRequired = true, EmitDefaultValue = true)]
        public string TriggerType { get; set; }

        /// <summary>
        /// The direction of the trigger; valid options are Up and Down
        /// </summary>
        /// <value>The direction of the trigger; valid options are Up and Down</value>
        [DataMember(Name = "triggerDirection", IsRequired = true, EmitDefaultValue = true)]
        public string TriggerDirection { get; set; }

        /// <summary>
        /// The date the trigger happens at.
        /// </summary>
        /// <value>The date the trigger happens at.</value>
        [DataMember(Name = "triggerDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset TriggerDate { get; set; }

        /// <summary>
        /// The date the trigger takes effect.
        /// </summary>
        /// <value>The date the trigger takes effect.</value>
        [DataMember(Name = "maturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TriggerEventAllOf {\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  TriggerDirection: ").Append(TriggerDirection).Append("\n");
            sb.Append("  TriggerDate: ").Append(TriggerDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  InstrumentEventType: ").Append(InstrumentEventType).Append("\n");
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
            return this.Equals(input as TriggerEventAllOf);
        }

        /// <summary>
        /// Returns true if TriggerEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TriggerEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    (this.TriggerType != null &&
                    this.TriggerType.Equals(input.TriggerType))
                ) && 
                (
                    this.TriggerDirection == input.TriggerDirection ||
                    (this.TriggerDirection != null &&
                    this.TriggerDirection.Equals(input.TriggerDirection))
                ) && 
                (
                    this.TriggerDate == input.TriggerDate ||
                    (this.TriggerDate != null &&
                    this.TriggerDate.Equals(input.TriggerDate))
                ) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && 
                (
                    this.InstrumentEventType == input.InstrumentEventType ||
                    this.InstrumentEventType.Equals(input.InstrumentEventType)
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
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                if (this.TriggerType != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerType.GetHashCode();
                }
                if (this.TriggerDirection != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerDirection.GetHashCode();
                }
                if (this.TriggerDate != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerDate.GetHashCode();
                }
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstrumentEventType.GetHashCode();
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
            // TriggerType (string) minLength
            if (this.TriggerType != null && this.TriggerType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TriggerType, length must be greater than 1.", new [] { "TriggerType" });
            }

            // TriggerDirection (string) minLength
            if (this.TriggerDirection != null && this.TriggerDirection.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TriggerDirection, length must be greater than 1.", new [] { "TriggerDirection" });
            }

            yield break;
        }
    }
}
