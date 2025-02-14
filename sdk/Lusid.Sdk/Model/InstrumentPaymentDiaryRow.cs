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
    /// An individual row containing details of a single cashflow in the diary.
    /// </summary>
    [DataContract(Name = "InstrumentPaymentDiaryRow")]
    public partial class InstrumentPaymentDiaryRow : IEquatable<InstrumentPaymentDiaryRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstrumentPaymentDiaryRow" /> class.
        /// </summary>
        /// <param name="quantity">The quantity (amount) that will be paid. Note that this can be empty if the payment is in the future and a model is used that cannot estimate it..</param>
        /// <param name="currency">The payment currency of the cash flow..</param>
        /// <param name="paymentDate">The date at which the given cash flow is due to be paid..</param>
        /// <param name="payOrReceive">Does the cash flow belong to the Pay or Receive leg..</param>
        /// <param name="accrualStart">The date on which accruals start for this cashflow..</param>
        /// <param name="accrualEnd">The date on which accruals end for this cashflow..</param>
        /// <param name="cashFlowType">The type of cashflow..</param>
        /// <param name="isCashFlowDetermined">Is the cashflow determined as of the effective date time..</param>
        /// <param name="isCashFlowHistoric">Has the cashflow been paid, i.e. has it become a historic cashflow, as of the date and time pointed to be effectiveAt..</param>
        /// <param name="discountFactor">Weighting factor to discount cashflow to the present value..</param>
        /// <param name="discountedExpectedCashFlowAmount">The expected cashflow amount taking into account the discount factor..</param>
        /// <param name="dayCountFraction">The day count fraction, if appropriate..</param>
        /// <param name="forwardRate">Forward rate for cash flow if appropriate. (as in for a rates fixed or floating leg).</param>
        /// <param name="resetRate">The value of the reset, if any..</param>
        /// <param name="spread">The spread that exists on the payoff..</param>
        public InstrumentPaymentDiaryRow(decimal quantity = default(decimal), string currency = default(string), DateTimeOffset paymentDate = default(DateTimeOffset), string payOrReceive = default(string), DateTimeOffset accrualStart = default(DateTimeOffset), DateTimeOffset accrualEnd = default(DateTimeOffset), string cashFlowType = default(string), bool isCashFlowDetermined = default(bool), bool isCashFlowHistoric = default(bool), decimal discountFactor = default(decimal), decimal discountedExpectedCashFlowAmount = default(decimal), decimal? dayCountFraction = default(decimal?), decimal? forwardRate = default(decimal?), decimal? resetRate = default(decimal?), decimal? spread = default(decimal?))
        {
            this.Quantity = quantity;
            this.Currency = currency;
            this.PaymentDate = paymentDate;
            this.PayOrReceive = payOrReceive;
            this.AccrualStart = accrualStart;
            this.AccrualEnd = accrualEnd;
            this.CashFlowType = cashFlowType;
            this.IsCashFlowDetermined = isCashFlowDetermined;
            this.IsCashFlowHistoric = isCashFlowHistoric;
            this.DiscountFactor = discountFactor;
            this.DiscountedExpectedCashFlowAmount = discountedExpectedCashFlowAmount;
            this.DayCountFraction = dayCountFraction;
            this.ForwardRate = forwardRate;
            this.ResetRate = resetRate;
            this.Spread = spread;
        }

        /// <summary>
        /// The quantity (amount) that will be paid. Note that this can be empty if the payment is in the future and a model is used that cannot estimate it.
        /// </summary>
        /// <value>The quantity (amount) that will be paid. Note that this can be empty if the payment is in the future and a model is used that cannot estimate it.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The payment currency of the cash flow.
        /// </summary>
        /// <value>The payment currency of the cash flow.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The date at which the given cash flow is due to be paid.
        /// </summary>
        /// <value>The date at which the given cash flow is due to be paid.</value>
        [DataMember(Name = "paymentDate", EmitDefaultValue = false)]
        public DateTimeOffset PaymentDate { get; set; }

        /// <summary>
        /// Does the cash flow belong to the Pay or Receive leg.
        /// </summary>
        /// <value>Does the cash flow belong to the Pay or Receive leg.</value>
        [DataMember(Name = "payOrReceive", EmitDefaultValue = true)]
        public string PayOrReceive { get; set; }

        /// <summary>
        /// The date on which accruals start for this cashflow.
        /// </summary>
        /// <value>The date on which accruals start for this cashflow.</value>
        [DataMember(Name = "accrualStart", EmitDefaultValue = false)]
        public DateTimeOffset AccrualStart { get; set; }

        /// <summary>
        /// The date on which accruals end for this cashflow.
        /// </summary>
        /// <value>The date on which accruals end for this cashflow.</value>
        [DataMember(Name = "accrualEnd", EmitDefaultValue = false)]
        public DateTimeOffset AccrualEnd { get; set; }

        /// <summary>
        /// The type of cashflow.
        /// </summary>
        /// <value>The type of cashflow.</value>
        [DataMember(Name = "cashFlowType", EmitDefaultValue = true)]
        public string CashFlowType { get; set; }

        /// <summary>
        /// Is the cashflow determined as of the effective date time.
        /// </summary>
        /// <value>Is the cashflow determined as of the effective date time.</value>
        [DataMember(Name = "isCashFlowDetermined", EmitDefaultValue = true)]
        public bool IsCashFlowDetermined { get; set; }

        /// <summary>
        /// Has the cashflow been paid, i.e. has it become a historic cashflow, as of the date and time pointed to be effectiveAt.
        /// </summary>
        /// <value>Has the cashflow been paid, i.e. has it become a historic cashflow, as of the date and time pointed to be effectiveAt.</value>
        [DataMember(Name = "isCashFlowHistoric", EmitDefaultValue = true)]
        public bool IsCashFlowHistoric { get; set; }

        /// <summary>
        /// Weighting factor to discount cashflow to the present value.
        /// </summary>
        /// <value>Weighting factor to discount cashflow to the present value.</value>
        [DataMember(Name = "discountFactor", EmitDefaultValue = false)]
        public decimal DiscountFactor { get; set; }

        /// <summary>
        /// The expected cashflow amount taking into account the discount factor.
        /// </summary>
        /// <value>The expected cashflow amount taking into account the discount factor.</value>
        [DataMember(Name = "discountedExpectedCashFlowAmount", EmitDefaultValue = false)]
        public decimal DiscountedExpectedCashFlowAmount { get; set; }

        /// <summary>
        /// The day count fraction, if appropriate.
        /// </summary>
        /// <value>The day count fraction, if appropriate.</value>
        [DataMember(Name = "dayCountFraction", EmitDefaultValue = true)]
        public decimal? DayCountFraction { get; set; }

        /// <summary>
        /// Forward rate for cash flow if appropriate. (as in for a rates fixed or floating leg)
        /// </summary>
        /// <value>Forward rate for cash flow if appropriate. (as in for a rates fixed or floating leg)</value>
        [DataMember(Name = "forwardRate", EmitDefaultValue = true)]
        public decimal? ForwardRate { get; set; }

        /// <summary>
        /// The value of the reset, if any.
        /// </summary>
        /// <value>The value of the reset, if any.</value>
        [DataMember(Name = "resetRate", EmitDefaultValue = true)]
        public decimal? ResetRate { get; set; }

        /// <summary>
        /// The spread that exists on the payoff.
        /// </summary>
        /// <value>The spread that exists on the payoff.</value>
        [DataMember(Name = "spread", EmitDefaultValue = true)]
        public decimal? Spread { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstrumentPaymentDiaryRow {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PayOrReceive: ").Append(PayOrReceive).Append("\n");
            sb.Append("  AccrualStart: ").Append(AccrualStart).Append("\n");
            sb.Append("  AccrualEnd: ").Append(AccrualEnd).Append("\n");
            sb.Append("  CashFlowType: ").Append(CashFlowType).Append("\n");
            sb.Append("  IsCashFlowDetermined: ").Append(IsCashFlowDetermined).Append("\n");
            sb.Append("  IsCashFlowHistoric: ").Append(IsCashFlowHistoric).Append("\n");
            sb.Append("  DiscountFactor: ").Append(DiscountFactor).Append("\n");
            sb.Append("  DiscountedExpectedCashFlowAmount: ").Append(DiscountedExpectedCashFlowAmount).Append("\n");
            sb.Append("  DayCountFraction: ").Append(DayCountFraction).Append("\n");
            sb.Append("  ForwardRate: ").Append(ForwardRate).Append("\n");
            sb.Append("  ResetRate: ").Append(ResetRate).Append("\n");
            sb.Append("  Spread: ").Append(Spread).Append("\n");
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
            return this.Equals(input as InstrumentPaymentDiaryRow);
        }

        /// <summary>
        /// Returns true if InstrumentPaymentDiaryRow instances are equal
        /// </summary>
        /// <param name="input">Instance of InstrumentPaymentDiaryRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstrumentPaymentDiaryRow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.PayOrReceive == input.PayOrReceive ||
                    (this.PayOrReceive != null &&
                    this.PayOrReceive.Equals(input.PayOrReceive))
                ) && 
                (
                    this.AccrualStart == input.AccrualStart ||
                    (this.AccrualStart != null &&
                    this.AccrualStart.Equals(input.AccrualStart))
                ) && 
                (
                    this.AccrualEnd == input.AccrualEnd ||
                    (this.AccrualEnd != null &&
                    this.AccrualEnd.Equals(input.AccrualEnd))
                ) && 
                (
                    this.CashFlowType == input.CashFlowType ||
                    (this.CashFlowType != null &&
                    this.CashFlowType.Equals(input.CashFlowType))
                ) && 
                (
                    this.IsCashFlowDetermined == input.IsCashFlowDetermined ||
                    this.IsCashFlowDetermined.Equals(input.IsCashFlowDetermined)
                ) && 
                (
                    this.IsCashFlowHistoric == input.IsCashFlowHistoric ||
                    this.IsCashFlowHistoric.Equals(input.IsCashFlowHistoric)
                ) && 
                (
                    this.DiscountFactor == input.DiscountFactor ||
                    this.DiscountFactor.Equals(input.DiscountFactor)
                ) && 
                (
                    this.DiscountedExpectedCashFlowAmount == input.DiscountedExpectedCashFlowAmount ||
                    this.DiscountedExpectedCashFlowAmount.Equals(input.DiscountedExpectedCashFlowAmount)
                ) && 
                (
                    this.DayCountFraction == input.DayCountFraction ||
                    (this.DayCountFraction != null &&
                    this.DayCountFraction.Equals(input.DayCountFraction))
                ) && 
                (
                    this.ForwardRate == input.ForwardRate ||
                    (this.ForwardRate != null &&
                    this.ForwardRate.Equals(input.ForwardRate))
                ) && 
                (
                    this.ResetRate == input.ResetRate ||
                    (this.ResetRate != null &&
                    this.ResetRate.Equals(input.ResetRate))
                ) && 
                (
                    this.Spread == input.Spread ||
                    (this.Spread != null &&
                    this.Spread.Equals(input.Spread))
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
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.PaymentDate != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDate.GetHashCode();
                }
                if (this.PayOrReceive != null)
                {
                    hashCode = (hashCode * 59) + this.PayOrReceive.GetHashCode();
                }
                if (this.AccrualStart != null)
                {
                    hashCode = (hashCode * 59) + this.AccrualStart.GetHashCode();
                }
                if (this.AccrualEnd != null)
                {
                    hashCode = (hashCode * 59) + this.AccrualEnd.GetHashCode();
                }
                if (this.CashFlowType != null)
                {
                    hashCode = (hashCode * 59) + this.CashFlowType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCashFlowDetermined.GetHashCode();
                hashCode = (hashCode * 59) + this.IsCashFlowHistoric.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountFactor.GetHashCode();
                hashCode = (hashCode * 59) + this.DiscountedExpectedCashFlowAmount.GetHashCode();
                if (this.DayCountFraction != null)
                {
                    hashCode = (hashCode * 59) + this.DayCountFraction.GetHashCode();
                }
                if (this.ForwardRate != null)
                {
                    hashCode = (hashCode * 59) + this.ForwardRate.GetHashCode();
                }
                if (this.ResetRate != null)
                {
                    hashCode = (hashCode * 59) + this.ResetRate.GetHashCode();
                }
                if (this.Spread != null)
                {
                    hashCode = (hashCode * 59) + this.Spread.GetHashCode();
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
