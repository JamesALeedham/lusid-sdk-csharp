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
    /// LUSID representation of a Contract for Difference.
    /// </summary>
    [DataContract(Name = "ContractForDifference")]
    [JsonConverter(typeof(JsonSubtypes), "InstrumentType")]
    public partial class ContractForDifference : LusidInstrument, IEquatable<ContractForDifference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractForDifference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractForDifference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractForDifference" /> class.
        /// </summary>
        /// <param name="startDate">The start date of the CFD. (required).</param>
        /// <param name="maturityDate">The maturity date for the CFD. If CFDType is Futures, this should be set to be the maturity date of the underlying  future. If CFDType is Cash, this should not be set..</param>
        /// <param name="code">The code of the underlying. (required).</param>
        /// <param name="contractSize">The size of the CFD contract, this should represent the total number of stocks that the CFD represents. (required).</param>
        /// <param name="payCcy">The currency that this CFD pays out, this can be different to the UnderlyingCcy. (required).</param>
        /// <param name="referenceRate">The reference rate of the CFD, this can be set to 0 but not negative values.  This field is optional, if not set it will default to 0..</param>
        /// <param name="type">The type of CFD.    Supported string (enumeration) values are: [Cash, Futures]. (required).</param>
        /// <param name="underlyingCcy">The currency of the underlying (required).</param>
        /// <param name="underlyingIdentifier">External market codes and identifiers for the CFD, e.g. RIC.    Supported string (enumeration) values are: [LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode]. (required).</param>
        /// <param name="instrumentType">The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg (required) (default to &quot;ContractForDifference&quot;).</param>
        public ContractForDifference(DateTimeOffset startDate = default(DateTimeOffset), DateTimeOffset maturityDate = default(DateTimeOffset), string code = default(string), decimal contractSize = default(decimal), string payCcy = default(string), decimal referenceRate = default(decimal), string type = default(string), string underlyingCcy = default(string), string underlyingIdentifier = default(string), InstrumentTypeEnum instrumentType = default(InstrumentTypeEnum)) : base(instrumentType)
        {
            this.StartDate = startDate;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for ContractForDifference and cannot be null");
            }
            this.Code = code;
            this.ContractSize = contractSize;
            // to ensure "payCcy" is required (not null)
            if (payCcy == null)
            {
                throw new ArgumentNullException("payCcy is a required property for ContractForDifference and cannot be null");
            }
            this.PayCcy = payCcy;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ContractForDifference and cannot be null");
            }
            this.Type = type;
            // to ensure "underlyingCcy" is required (not null)
            if (underlyingCcy == null)
            {
                throw new ArgumentNullException("underlyingCcy is a required property for ContractForDifference and cannot be null");
            }
            this.UnderlyingCcy = underlyingCcy;
            // to ensure "underlyingIdentifier" is required (not null)
            if (underlyingIdentifier == null)
            {
                throw new ArgumentNullException("underlyingIdentifier is a required property for ContractForDifference and cannot be null");
            }
            this.UnderlyingIdentifier = underlyingIdentifier;
            this.MaturityDate = maturityDate;
            this.ReferenceRate = referenceRate;
        }

        /// <summary>
        /// The start date of the CFD.
        /// </summary>
        /// <value>The start date of the CFD.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// The maturity date for the CFD. If CFDType is Futures, this should be set to be the maturity date of the underlying  future. If CFDType is Cash, this should not be set.
        /// </summary>
        /// <value>The maturity date for the CFD. If CFDType is Futures, this should be set to be the maturity date of the underlying  future. If CFDType is Cash, this should not be set.</value>
        [DataMember(Name = "maturityDate", EmitDefaultValue = false)]
        public DateTimeOffset MaturityDate { get; set; }

        /// <summary>
        /// The code of the underlying.
        /// </summary>
        /// <value>The code of the underlying.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The size of the CFD contract, this should represent the total number of stocks that the CFD represents.
        /// </summary>
        /// <value>The size of the CFD contract, this should represent the total number of stocks that the CFD represents.</value>
        [DataMember(Name = "contractSize", IsRequired = true, EmitDefaultValue = true)]
        public decimal ContractSize { get; set; }

        /// <summary>
        /// The currency that this CFD pays out, this can be different to the UnderlyingCcy.
        /// </summary>
        /// <value>The currency that this CFD pays out, this can be different to the UnderlyingCcy.</value>
        [DataMember(Name = "payCcy", IsRequired = true, EmitDefaultValue = true)]
        public string PayCcy { get; set; }

        /// <summary>
        /// The reference rate of the CFD, this can be set to 0 but not negative values.  This field is optional, if not set it will default to 0.
        /// </summary>
        /// <value>The reference rate of the CFD, this can be set to 0 but not negative values.  This field is optional, if not set it will default to 0.</value>
        [DataMember(Name = "referenceRate", EmitDefaultValue = false)]
        public decimal ReferenceRate { get; set; }

        /// <summary>
        /// The type of CFD.    Supported string (enumeration) values are: [Cash, Futures].
        /// </summary>
        /// <value>The type of CFD.    Supported string (enumeration) values are: [Cash, Futures].</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The currency of the underlying
        /// </summary>
        /// <value>The currency of the underlying</value>
        [DataMember(Name = "underlyingCcy", IsRequired = true, EmitDefaultValue = true)]
        public string UnderlyingCcy { get; set; }

        /// <summary>
        /// External market codes and identifiers for the CFD, e.g. RIC.    Supported string (enumeration) values are: [LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode].
        /// </summary>
        /// <value>External market codes and identifiers for the CFD, e.g. RIC.    Supported string (enumeration) values are: [LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode].</value>
        [DataMember(Name = "underlyingIdentifier", IsRequired = true, EmitDefaultValue = true)]
        public string UnderlyingIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractForDifference {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  MaturityDate: ").Append(MaturityDate).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ContractSize: ").Append(ContractSize).Append("\n");
            sb.Append("  PayCcy: ").Append(PayCcy).Append("\n");
            sb.Append("  ReferenceRate: ").Append(ReferenceRate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnderlyingCcy: ").Append(UnderlyingCcy).Append("\n");
            sb.Append("  UnderlyingIdentifier: ").Append(UnderlyingIdentifier).Append("\n");
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
            return this.Equals(input as ContractForDifference);
        }

        /// <summary>
        /// Returns true if ContractForDifference instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractForDifference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractForDifference input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && base.Equals(input) && 
                (
                    this.MaturityDate == input.MaturityDate ||
                    (this.MaturityDate != null &&
                    this.MaturityDate.Equals(input.MaturityDate))
                ) && base.Equals(input) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && base.Equals(input) && 
                (
                    this.ContractSize == input.ContractSize ||
                    this.ContractSize.Equals(input.ContractSize)
                ) && base.Equals(input) && 
                (
                    this.PayCcy == input.PayCcy ||
                    (this.PayCcy != null &&
                    this.PayCcy.Equals(input.PayCcy))
                ) && base.Equals(input) && 
                (
                    this.ReferenceRate == input.ReferenceRate ||
                    this.ReferenceRate.Equals(input.ReferenceRate)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.UnderlyingCcy == input.UnderlyingCcy ||
                    (this.UnderlyingCcy != null &&
                    this.UnderlyingCcy.Equals(input.UnderlyingCcy))
                ) && base.Equals(input) && 
                (
                    this.UnderlyingIdentifier == input.UnderlyingIdentifier ||
                    (this.UnderlyingIdentifier != null &&
                    this.UnderlyingIdentifier.Equals(input.UnderlyingIdentifier))
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
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.MaturityDate != null)
                {
                    hashCode = (hashCode * 59) + this.MaturityDate.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContractSize.GetHashCode();
                if (this.PayCcy != null)
                {
                    hashCode = (hashCode * 59) + this.PayCcy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReferenceRate.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UnderlyingCcy != null)
                {
                    hashCode = (hashCode * 59) + this.UnderlyingCcy.GetHashCode();
                }
                if (this.UnderlyingIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.UnderlyingIdentifier.GetHashCode();
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
            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // UnderlyingIdentifier (string) minLength
            if (this.UnderlyingIdentifier != null && this.UnderlyingIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnderlyingIdentifier, length must be greater than 1.", new [] { "UnderlyingIdentifier" });
            }

            yield break;
        }
    }
}
