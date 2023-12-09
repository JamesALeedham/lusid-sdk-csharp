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
    /// Definition of a Bond Principal Event  This is an event that describes the occurence of a cashflow due to the principal payment.
    /// </summary>
    [DataContract(Name = "BondPrincipalEvent")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentEventType")]
    public partial class BondPrincipalEvent : InstrumentEvent, IEquatable<BondPrincipalEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BondPrincipalEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BondPrincipalEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BondPrincipalEvent" /> class.
        /// </summary>
        /// <param name="currency">Currency of the principal payment (required).</param>
        /// <param name="exDate">Ex-Dividend date of the principal payment (required).</param>
        /// <param name="paymentDate">Payment date of the principal payment (required).</param>
        /// <param name="principalPerUnit">Principal per unit (required).</param>
        /// <param name="instrumentEventType">The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent (required) (default to &quot;BondPrincipalEvent&quot;).</param>
        public BondPrincipalEvent(string currency = default(string), DateTimeOffset exDate = default(DateTimeOffset), DateTimeOffset paymentDate = default(DateTimeOffset), decimal principalPerUnit = default(decimal), InstrumentEventTypeEnum instrumentEventType = default(InstrumentEventTypeEnum)) : base(instrumentEventType)
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for BondPrincipalEvent and cannot be null");
            }
            this.Currency = currency;
            this.ExDate = exDate;
            this.PaymentDate = paymentDate;
            this.PrincipalPerUnit = principalPerUnit;
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
            sb.Append("class BondPrincipalEvent {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExDate: ").Append(ExDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PrincipalPerUnit: ").Append(PrincipalPerUnit).Append("\n");
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
            return this.Equals(input as BondPrincipalEvent);
        }

        /// <summary>
        /// Returns true if BondPrincipalEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of BondPrincipalEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BondPrincipalEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && base.Equals(input) && 
                (
                    this.ExDate == input.ExDate ||
                    (this.ExDate != null &&
                    this.ExDate.Equals(input.ExDate))
                ) && base.Equals(input) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && base.Equals(input) && 
                (
                    this.PrincipalPerUnit == input.PrincipalPerUnit ||
                    this.PrincipalPerUnit.Equals(input.PrincipalPerUnit)
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
            yield break;
        }
    }
}
