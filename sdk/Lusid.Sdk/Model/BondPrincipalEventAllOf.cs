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
    /// BondPrincipalEventAllOf
    /// </summary>
    [DataContract(Name = "BondPrincipalEvent_allOf")]
    public partial class BondPrincipalEventAllOf : IEquatable<BondPrincipalEventAllOf>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="BondPrincipalEventAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BondPrincipalEventAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BondPrincipalEventAllOf" /> class.
        /// </summary>
        /// <param name="currency">Currency of the principal payment (required).</param>
        /// <param name="exDate">Ex-Dividend date of the principal payment (required).</param>
        /// <param name="paymentDate">Payment date of the principal payment (required).</param>
        /// <param name="principalPerUnit">Principal per unit (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent (required).</param>
        public BondPrincipalEventAllOf(string currency = default(string), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset paymentDate = default(DateTimeOffset), decimal principalPerUnit = default(decimal), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for BondPrincipalEventAllOf and cannot be null");
            }
            this.Currency = currency;
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            this.PrincipalPerUnit = principalPerUnit;
            this.InstrumentEventType = instrumentEventType;
        }

        /// <summary>
        /// Currency of the principal payment
        /// </summary>
        /// <value>Currency of the principal payment</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Ex-Dividend date of the principal payment
        /// </summary>
        /// <value>Ex-Dividend date of the principal payment</value>
        [DataMember(Name = "exDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset ExDate { get; set; }

        /// <summary>
        /// Payment date of the principal payment
        /// </summary>
        /// <value>Payment date of the principal payment</value>
        [DataMember(Name = "paymentDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Principal per unit
        /// </summary>
        /// <value>Principal per unit</value>
        [DataMember(Name = "principalPerUnit", IsRequired = true, EmitDefaultValue = true)]
        public decimal PrincipalPerUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BondPrincipalEventAllOf {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PrincipalPerUnit: ").Append(PrincipalPerUnit).Append("\n");
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
            return this.Equals(input as BondPrincipalEventAllOf);
        }

        /// <summary>
        /// Returns true if BondPrincipalEventAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of BondPrincipalEventAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondPrincipalEventAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.PrincipalPerUnit == input.PrincipalPerUnit ||
                    this.PrincipalPerUnit.Equals(input.PrincipalPerUnit)
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.ExDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExDate.GetHashCode();
                }
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PrincipalPerUnit.GetHashCode();
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
            yield break;
        }
    }
}
