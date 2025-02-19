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
    /// ExoticInstrumentAllOf
    /// </summary>
    [DataContract(Name = "ExoticInstrument_allOf")]
    public partial class ExoticInstrumentAllOf : IEquatable<ExoticInstrumentAllOf>, IValidatableObject
    {
        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentTypeEnum
        {
            /// <summary>
            /// Enum QuotedSecurity for value: QuotedSecurity
            /// </summary>
            [EnumMember(Value = "QuotedSecurity")]
            QuotedSecurity = 1,

            /// <summary>
            /// Enum InterestRateSwap for value: InterestRateSwap
            /// </summary>
            [EnumMember(Value = "InterestRateSwap")]
            InterestRateSwap = 2,

            /// <summary>
            /// Enum FxForward for value: FxForward
            /// </summary>
            [EnumMember(Value = "FxForward")]
            FxForward = 3,

            /// <summary>
            /// Enum Future for value: Future
            /// </summary>
            [EnumMember(Value = "Future")]
            Future = 4,

            /// <summary>
            /// Enum ExoticInstrument for value: ExoticInstrument
            /// </summary>
            [EnumMember(Value = "ExoticInstrument")]
            ExoticInstrument = 5,

            /// <summary>
            /// Enum FxOption for value: FxOption
            /// </summary>
            [EnumMember(Value = "FxOption")]
            FxOption = 6,

            /// <summary>
            /// Enum CreditDefaultSwap for value: CreditDefaultSwap
            /// </summary>
            [EnumMember(Value = "CreditDefaultSwap")]
            CreditDefaultSwap = 7,

            /// <summary>
            /// Enum InterestRateSwaption for value: InterestRateSwaption
            /// </summary>
            [EnumMember(Value = "InterestRateSwaption")]
            InterestRateSwaption = 8,

            /// <summary>
            /// Enum Bond for value: Bond
            /// </summary>
            [EnumMember(Value = "Bond")]
            Bond = 9,

            /// <summary>
            /// Enum EquityOption for value: EquityOption
            /// </summary>
            [EnumMember(Value = "EquityOption")]
            EquityOption = 10,

            /// <summary>
            /// Enum FixedLeg for value: FixedLeg
            /// </summary>
            [EnumMember(Value = "FixedLeg")]
            FixedLeg = 11,

            /// <summary>
            /// Enum FloatingLeg for value: FloatingLeg
            /// </summary>
            [EnumMember(Value = "FloatingLeg")]
            FloatingLeg = 12,

            /// <summary>
            /// Enum BespokeCashFlowsLeg for value: BespokeCashFlowsLeg
            /// </summary>
            [EnumMember(Value = "BespokeCashFlowsLeg")]
            BespokeCashFlowsLeg = 13,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 14,

            /// <summary>
            /// Enum TermDeposit for value: TermDeposit
            /// </summary>
            [EnumMember(Value = "TermDeposit")]
            TermDeposit = 15,

            /// <summary>
            /// Enum ContractForDifference for value: ContractForDifference
            /// </summary>
            [EnumMember(Value = "ContractForDifference")]
            ContractForDifference = 16,

            /// <summary>
            /// Enum EquitySwap for value: EquitySwap
            /// </summary>
            [EnumMember(Value = "EquitySwap")]
            EquitySwap = 17,

            /// <summary>
            /// Enum CashPerpetual for value: CashPerpetual
            /// </summary>
            [EnumMember(Value = "CashPerpetual")]
            CashPerpetual = 18,

            /// <summary>
            /// Enum CapFloor for value: CapFloor
            /// </summary>
            [EnumMember(Value = "CapFloor")]
            CapFloor = 19,

            /// <summary>
            /// Enum CashSettled for value: CashSettled
            /// </summary>
            [EnumMember(Value = "CashSettled")]
            CashSettled = 20,

            /// <summary>
            /// Enum CdsIndex for value: CdsIndex
            /// </summary>
            [EnumMember(Value = "CdsIndex")]
            CdsIndex = 21,

            /// <summary>
            /// Enum Basket for value: Basket
            /// </summary>
            [EnumMember(Value = "Basket")]
            Basket = 22,

            /// <summary>
            /// Enum FundingLeg for value: FundingLeg
            /// </summary>
            [EnumMember(Value = "FundingLeg")]
            FundingLeg = 23,

            /// <summary>
            /// Enum FxSwap for value: FxSwap
            /// </summary>
            [EnumMember(Value = "FxSwap")]
            FxSwap = 24,

            /// <summary>
            /// Enum ForwardRateAgreement for value: ForwardRateAgreement
            /// </summary>
            [EnumMember(Value = "ForwardRateAgreement")]
            ForwardRateAgreement = 25,

            /// <summary>
            /// Enum SimpleInstrument for value: SimpleInstrument
            /// </summary>
            [EnumMember(Value = "SimpleInstrument")]
            SimpleInstrument = 26,

            /// <summary>
            /// Enum Repo for value: Repo
            /// </summary>
            [EnumMember(Value = "Repo")]
            Repo = 27,

            /// <summary>
            /// Enum Equity for value: Equity
            /// </summary>
            [EnumMember(Value = "Equity")]
            Equity = 28,

            /// <summary>
            /// Enum ExchangeTradedOption for value: ExchangeTradedOption
            /// </summary>
            [EnumMember(Value = "ExchangeTradedOption")]
            ExchangeTradedOption = 29,

            /// <summary>
            /// Enum ReferenceInstrument for value: ReferenceInstrument
            /// </summary>
            [EnumMember(Value = "ReferenceInstrument")]
            ReferenceInstrument = 30,

            /// <summary>
            /// Enum ComplexBond for value: ComplexBond
            /// </summary>
            [EnumMember(Value = "ComplexBond")]
            ComplexBond = 31,

            /// <summary>
            /// Enum InflationLinkedBond for value: InflationLinkedBond
            /// </summary>
            [EnumMember(Value = "InflationLinkedBond")]
            InflationLinkedBond = 32,

            /// <summary>
            /// Enum InflationSwap for value: InflationSwap
            /// </summary>
            [EnumMember(Value = "InflationSwap")]
            InflationSwap = 33,

            /// <summary>
            /// Enum SimpleCashFlowLoan for value: SimpleCashFlowLoan
            /// </summary>
            [EnumMember(Value = "SimpleCashFlowLoan")]
            SimpleCashFlowLoan = 34,

            /// <summary>
            /// Enum TotalReturnSwap for value: TotalReturnSwap
            /// </summary>
            [EnumMember(Value = "TotalReturnSwap")]
            TotalReturnSwap = 35,

            /// <summary>
            /// Enum InflationLeg for value: InflationLeg
            /// </summary>
            [EnumMember(Value = "InflationLeg")]
            InflationLeg = 36

        }


        /// <summary>
        /// The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg
        /// </summary>
        /// <value>The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg</value>
        [DataMember(Name = "instrumentType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentTypeEnum InstrumentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExoticInstrumentAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExoticInstrumentAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExoticInstrumentAllOf" /> class.
        /// </summary>
        /// <param name="instrumentFormat">instrumentFormat (required).</param>
        /// <param name="content">The original document received into the system. This format could potentially be anything though is most likely to be either Json or Xml. In the case where no other  interface is supported it is possible to fall back onto this.  For example, a trade from an external client system. This may be recognized internally by Lusid or simply passed through to another vendor system. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg (required).</param>
        public ExoticInstrumentAllOf(InstrumentDefinitionFormat instrumentFormat = default(InstrumentDefinitionFormat), string content = default(string), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            // to ensure "instrumentFormat" is required (not null)
            if (instrumentFormat == null)
            {
                throw new ArgumentNullException("instrumentFormat is a required property for ExoticInstrumentAllOf and cannot be null");
            }
            this.InstrumentFormat = instrumentFormat;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for ExoticInstrumentAllOf and cannot be null");
            }
            this.Content = content;
            this.InstrumentType = instrumentType;
        }

        /// <summary>
        /// Gets or Sets InstrumentFormat
        /// </summary>
        [DataMember(Name = "instrumentFormat", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentDefinitionFormat InstrumentFormat { get; set; }

        /// <summary>
        /// The original document received into the system. This format could potentially be anything though is most likely to be either Json or Xml. In the case where no other  interface is supported it is possible to fall back onto this.  For example, a trade from an external client system. This may be recognized internally by Lusid or simply passed through to another vendor system.
        /// </summary>
        /// <value>The original document received into the system. This format could potentially be anything though is most likely to be either Json or Xml. In the case where no other  interface is supported it is possible to fall back onto this.  For example, a trade from an external client system. This may be recognized internally by Lusid or simply passed through to another vendor system.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExoticInstrumentAllOf {\n");
            sb.Append("  InstrumentFormat: ").Append(InstrumentFormat).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  InstrumentType: ").Append(InstrumentType).Append("\n");
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
            return this.Equals(input as ExoticInstrumentAllOf);
        }

        /// <summary>
        /// Returns true if ExoticInstrumentAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ExoticInstrumentAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExoticInstrumentAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentFormat == input.InstrumentFormat ||
                    (this.InstrumentFormat != null &&
                    this.InstrumentFormat.Equals(input.InstrumentFormat))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.InstrumentType == input.InstrumentType ||
                    this.InstrumentType.Equals(input.InstrumentType)
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
                if (this.InstrumentFormat != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentFormat.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InstrumentType.GetHashCode();
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
            // Content (string) minLength
            if (this.Content != null && this.Content.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Content, length must be greater than 1.", new [] { "Content" });
            }

            yield break;
        }
    }
}
