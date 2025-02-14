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
    /// FxOptionAllOf
    /// </summary>
    [DataContract(Name = "FxOption_allOf")]
    public partial class FxOptionAllOf : IEquatable<FxOptionAllOf>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="FxOptionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FxOptionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FxOptionAllOf" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the instrument. This is normally synonymous with the trade-date. (required).</param>
        /// <param name="domCcy">The domestic currency of the instrument. (required).</param>
        /// <param name="domAmount">The Amount of DomCcy that will be exchanged if the option is exercised.  This amount should be a positive number, with the Call/Put flag used to indicate direction.  The corresponding amount of FgnCcy that will be exchanged is this amount times the strike.  Note there is no rounding performed on this computed value.  This is an optional field, if not set the option ContractSize will default to 1..</param>
        /// <param name="fgnCcy">The foreign currency of the FX. (required).</param>
        /// <param name="fgnAmount">For a vanilla FxOption contract, FgnAmount cannot be set.  In case of a digital FxOption (IsPayoffDigital&#x3D;&#x3D;true)  a payoff (if the option is in the money) can be either  in domestic or in foreign currency - for the latter  FgnAmount must be set.  Note: It is invalid to have FgnAmount and DomAmount  at the same time..</param>
        /// <param name="strike">The strike of the option..</param>
        /// <param name="barriers">For a barrier option the list should not be empty. Up to two barriers are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty..</param>
        /// <param name="exerciseType">Type of optionality that is present; European, American.    Supported string (enumeration) values are: [European, American]..</param>
        /// <param name="isCallNotPut">True if the option is a call, false if the option is a put. (required).</param>
        /// <param name="isDeliveryNotCash">True if the option delivers the FX underlying, False if the option is settled in cash. (required).</param>
        /// <param name="isPayoffDigital">By default IsPayoffDigital is false. If IsPayoffDigital&#x3D;true,  the option is &#39;digital&#39;, and the option payoff is 0 or 1 unit of currency,  instead of a vanilla CallPayoff&#x3D;max(spot-strike,0) or PutPayoff&#x3D;max(strike-spot,0)..</param>
        /// <param name="optionMaturityDate">The maturity date of the option. (required).</param>
        /// <param name="optionSettlementDate">The settlement date of the option. (required).</param>
        /// <param name="payoutStyle">PayoutStyle for touch options.                For options without touch optionality, payoutStyle should not be set.  For options with touch optionality (where the touches data has been set), payoutStyle must be defined and cannot be None.    Supported string (enumeration) values are: [Deferred, Immediate]..</param>
        /// <param name="premium">premium.</param>
        /// <param name="touches">For a touch option the list should not be empty. Up to two touches are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty..</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg (required).</param>
        public FxOptionAllOf(DateTimeOffset startDate = default(DateTimeOffset), string domCcy = default(string), decimal? domAmount = default(decimal?), string fgnCcy = default(string), decimal? fgnAmount = default(decimal?), decimal? strike = default(decimal?), List<Barrier> barriers = default(List<Barrier>), string exerciseType = default(string), bool isCallNotPut = default(bool), bool isDeliveryNotCash = default(bool), bool isPayoffDigital = default(bool), DateTimeOffset optionMaturityDate = default(DateTimeOffset), DateTimeOffset optionSettlementDate = default(DateTimeOffset), string payoutStyle = default(string), Premium premium = default(Premium), List<Touch> touches = default(List<Touch>), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum))
        {
            this.StartDate = startDate;
            // to ensure "domCcy" is required (not null)
            if (domCcy == null)
            {
                throw new ArgumentNullException("domCcy is a required property for FxOptionAllOf and cannot be null");
            }
            this.DomCcy = domCcy;
            // to ensure "fgnCcy" is required (not null)
            if (fgnCcy == null)
            {
                throw new ArgumentNullException("fgnCcy is a required property for FxOptionAllOf and cannot be null");
            }
            this.FgnCcy = fgnCcy;
            this.IsCallNotPut = isCallNotPut;
            this.IsDeliveryNotCash = isDeliveryNotCash;
            this.OptionMaturityDate = optionMaturityDate;
            this.OptionSettlementDate = optionSettlementDate;
            this.InstrumentType = instrumentType;
            this.DomAmount = domAmount;
            this.FgnAmount = fgnAmount;
            this.Strike = strike;
            this.Barriers = barriers;
            this.ExerciseType = exerciseType;
            this.IsPayoffDigital = isPayoffDigital;
            this.PayoutStyle = payoutStyle;
            this.Premium = premium;
            this.Touches = touches;
        }

        /// <summary>
        /// The start date of the instrument. This is normally synonymous with the trade-date.
        /// </summary>
        /// <value>The start date of the instrument. This is normally synonymous with the trade-date.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The domestic currency of the instrument.
        /// </summary>
        /// <value>The domestic currency of the instrument.</value>
        [DataMember(Name = "domCcy", IsRequired = true, EmitDefaultValue = true)]
        public string DomCcy { get; set; }

        /// <summary>
        /// The Amount of DomCcy that will be exchanged if the option is exercised.  This amount should be a positive number, with the Call/Put flag used to indicate direction.  The corresponding amount of FgnCcy that will be exchanged is this amount times the strike.  Note there is no rounding performed on this computed value.  This is an optional field, if not set the option ContractSize will default to 1.
        /// </summary>
        /// <value>The Amount of DomCcy that will be exchanged if the option is exercised.  This amount should be a positive number, with the Call/Put flag used to indicate direction.  The corresponding amount of FgnCcy that will be exchanged is this amount times the strike.  Note there is no rounding performed on this computed value.  This is an optional field, if not set the option ContractSize will default to 1.</value>
        [DataMember(Name = "domAmount", EmitDefaultValue = true)]
        public decimal? DomAmount { get; set; }

        /// <summary>
        /// The foreign currency of the FX.
        /// </summary>
        /// <value>The foreign currency of the FX.</value>
        [DataMember(Name = "fgnCcy", IsRequired = true, EmitDefaultValue = true)]
        public string FgnCcy { get; set; }

        /// <summary>
        /// For a vanilla FxOption contract, FgnAmount cannot be set.  In case of a digital FxOption (IsPayoffDigital&#x3D;&#x3D;true)  a payoff (if the option is in the money) can be either  in domestic or in foreign currency - for the latter  FgnAmount must be set.  Note: It is invalid to have FgnAmount and DomAmount  at the same time.
        /// </summary>
        /// <value>For a vanilla FxOption contract, FgnAmount cannot be set.  In case of a digital FxOption (IsPayoffDigital&#x3D;&#x3D;true)  a payoff (if the option is in the money) can be either  in domestic or in foreign currency - for the latter  FgnAmount must be set.  Note: It is invalid to have FgnAmount and DomAmount  at the same time.</value>
        [DataMember(Name = "fgnAmount", EmitDefaultValue = true)]
        public decimal? FgnAmount { get; set; }

        /// <summary>
        /// The strike of the option.
        /// </summary>
        /// <value>The strike of the option.</value>
        [DataMember(Name = "strike", EmitDefaultValue = true)]
        public decimal? Strike { get; set; }

        /// <summary>
        /// For a barrier option the list should not be empty. Up to two barriers are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty.
        /// </summary>
        /// <value>For a barrier option the list should not be empty. Up to two barriers are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty.</value>
        [DataMember(Name = "barriers", EmitDefaultValue = true)]
        public List<Barrier> Barriers { get; set; }

        /// <summary>
        /// Type of optionality that is present; European, American.    Supported string (enumeration) values are: [European, American].
        /// </summary>
        /// <value>Type of optionality that is present; European, American.    Supported string (enumeration) values are: [European, American].</value>
        [DataMember(Name = "exerciseType", EmitDefaultValue = true)]
        public string ExerciseType { get; set; }

        /// <summary>
        /// True if the option is a call, false if the option is a put.
        /// </summary>
        /// <value>True if the option is a call, false if the option is a put.</value>
        [DataMember(Name = "isCallNotPut", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCallNotPut { get; set; }

        /// <summary>
        /// True if the option delivers the FX underlying, False if the option is settled in cash.
        /// </summary>
        /// <value>True if the option delivers the FX underlying, False if the option is settled in cash.</value>
        [DataMember(Name = "isDeliveryNotCash", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDeliveryNotCash { get; set; }

        /// <summary>
        /// By default IsPayoffDigital is false. If IsPayoffDigital&#x3D;true,  the option is &#39;digital&#39;, and the option payoff is 0 or 1 unit of currency,  instead of a vanilla CallPayoff&#x3D;max(spot-strike,0) or PutPayoff&#x3D;max(strike-spot,0).
        /// </summary>
        /// <value>By default IsPayoffDigital is false. If IsPayoffDigital&#x3D;true,  the option is &#39;digital&#39;, and the option payoff is 0 or 1 unit of currency,  instead of a vanilla CallPayoff&#x3D;max(spot-strike,0) or PutPayoff&#x3D;max(strike-spot,0).</value>
        [DataMember(Name = "isPayoffDigital", EmitDefaultValue = true)]
        public bool IsPayoffDigital { get; set; }

        /// <summary>
        /// The maturity date of the option.
        /// </summary>
        /// <value>The maturity date of the option.</value>
        [DataMember(Name = "optionMaturityDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset OptionMaturityDate { get; set; }

        /// <summary>
        /// The settlement date of the option.
        /// </summary>
        /// <value>The settlement date of the option.</value>
        [DataMember(Name = "optionSettlementDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset OptionSettlementDate { get; set; }

        /// <summary>
        /// PayoutStyle for touch options.                For options without touch optionality, payoutStyle should not be set.  For options with touch optionality (where the touches data has been set), payoutStyle must be defined and cannot be None.    Supported string (enumeration) values are: [Deferred, Immediate].
        /// </summary>
        /// <value>PayoutStyle for touch options.                For options without touch optionality, payoutStyle should not be set.  For options with touch optionality (where the touches data has been set), payoutStyle must be defined and cannot be None.    Supported string (enumeration) values are: [Deferred, Immediate].</value>
        [DataMember(Name = "payoutStyle", EmitDefaultValue = true)]
        public string PayoutStyle { get; set; }

        /// <summary>
        /// Gets or Sets Premium
        /// </summary>
        [DataMember(Name = "premium", EmitDefaultValue = false)]
        public Premium Premium { get; set; }

        /// <summary>
        /// For a touch option the list should not be empty. Up to two touches are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty.
        /// </summary>
        /// <value>For a touch option the list should not be empty. Up to two touches are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty.</value>
        [DataMember(Name = "touches", EmitDefaultValue = true)]
        public List<Touch> Touches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FxOptionAllOf {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  DomCcy: ").Append(DomCcy).Append("\n");
            sb.Append("  DomAmount: ").Append(DomAmount).Append("\n");
            sb.Append("  FgnCcy: ").Append(FgnCcy).Append("\n");
            sb.Append("  FgnAmount: ").Append(FgnAmount).Append("\n");
            sb.Append("  Strike: ").Append(Strike).Append("\n");
            sb.Append("  Barriers: ").Append(Barriers).Append("\n");
            sb.Append("  ExerciseType: ").Append(ExerciseType).Append("\n");
            sb.Append("  IsCallNotPut: ").Append(IsCallNotPut).Append("\n");
            sb.Append("  IsDeliveryNotCash: ").Append(IsDeliveryNotCash).Append("\n");
            sb.Append("  IsPayoffDigital: ").Append(IsPayoffDigital).Append("\n");
            sb.Append("  OptionMaturityDate: ").Append(OptionMaturityDate).Append("\n");
            sb.Append("  OptionSettlementDate: ").Append(OptionSettlementDate).Append("\n");
            sb.Append("  PayoutStyle: ").Append(PayoutStyle).Append("\n");
            sb.Append("  Premium: ").Append(Premium).Append("\n");
            sb.Append("  Touches: ").Append(Touches).Append("\n");
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
            return this.Equals(input as FxOptionAllOf);
        }

        /// <summary>
        /// Returns true if FxOptionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of FxOptionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FxOptionAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.DomCcy == input.DomCcy ||
                    (this.DomCcy != null &&
                    this.DomCcy.Equals(input.DomCcy))
                ) && 
                (
                    this.DomAmount == input.DomAmount ||
                    (this.DomAmount != null &&
                    this.DomAmount.Equals(input.DomAmount))
                ) && 
                (
                    this.FgnCcy == input.FgnCcy ||
                    (this.FgnCcy != null &&
                    this.FgnCcy.Equals(input.FgnCcy))
                ) && 
                (
                    this.FgnAmount == input.FgnAmount ||
                    (this.FgnAmount != null &&
                    this.FgnAmount.Equals(input.FgnAmount))
                ) && 
                (
                    this.Strike == input.Strike ||
                    (this.Strike != null &&
                    this.Strike.Equals(input.Strike))
                ) && 
                (
                    this.Barriers == input.Barriers ||
                    this.Barriers != null &&
                    input.Barriers != null &&
                    this.Barriers.SequenceEqual(input.Barriers)
                ) && 
                (
                    this.ExerciseType == input.ExerciseType ||
                    (this.ExerciseType != null &&
                    this.ExerciseType.Equals(input.ExerciseType))
                ) && 
                (
                    this.IsCallNotPut == input.IsCallNotPut ||
                    this.IsCallNotPut.Equals(input.IsCallNotPut)
                ) && 
                (
                    this.IsDeliveryNotCash == input.IsDeliveryNotCash ||
                    this.IsDeliveryNotCash.Equals(input.IsDeliveryNotCash)
                ) && 
                (
                    this.IsPayoffDigital == input.IsPayoffDigital ||
                    this.IsPayoffDigital.Equals(input.IsPayoffDigital)
                ) && 
                (
                    this.OptionMaturityDate == input.OptionMaturityDate ||
                    (this.OptionMaturityDate != null &&
                    this.OptionMaturityDate.Equals(input.OptionMaturityDate))
                ) && 
                (
                    this.OptionSettlementDate == input.OptionSettlementDate ||
                    (this.OptionSettlementDate != null &&
                    this.OptionSettlementDate.Equals(input.OptionSettlementDate))
                ) && 
                (
                    this.PayoutStyle == input.PayoutStyle ||
                    (this.PayoutStyle != null &&
                    this.PayoutStyle.Equals(input.PayoutStyle))
                ) && 
                (
                    this.Premium == input.Premium ||
                    (this.Premium != null &&
                    this.Premium.Equals(input.Premium))
                ) && 
                (
                    this.Touches == input.Touches ||
                    this.Touches != null &&
                    input.Touches != null &&
                    this.Touches.SequenceEqual(input.Touches)
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.DomCcy != null)
                {
                    hashCode = (hashCode * 59) + this.DomCcy.GetHashCode();
                }
                if (this.DomAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DomAmount.GetHashCode();
                }
                if (this.FgnCcy != null)
                {
                    hashCode = (hashCode * 59) + this.FgnCcy.GetHashCode();
                }
                if (this.FgnAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FgnAmount.GetHashCode();
                }
                if (this.Strike != null)
                {
                    hashCode = (hashCode * 59) + this.Strike.GetHashCode();
                }
                if (this.Barriers != null)
                {
                    hashCode = (hashCode * 59) + this.Barriers.GetHashCode();
                }
                if (this.ExerciseType != null)
                {
                    hashCode = (hashCode * 59) + this.ExerciseType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCallNotPut.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDeliveryNotCash.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPayoffDigital.GetHashCode();
                if (this.OptionMaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.OptionMaturityDate.GetHashCode();
                }
                if (this.OptionSettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.OptionSettlementDate.GetHashCode();
                }
                if (this.PayoutStyle != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutStyle.GetHashCode();
                }
                if (this.Premium != null)
                {
                    hashCode = (hashCode * 59) + this.Premium.GetHashCode();
                }
                if (this.Touches != null)
                {
                    hashCode = (hashCode * 59) + this.Touches.GetHashCode();
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
            yield break;
        }
    }
}
