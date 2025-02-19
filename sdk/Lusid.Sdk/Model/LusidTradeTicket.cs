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
    /// A LUSID Trade Ticket comprising an instrument, a transaction, and a counterparty.
    /// </summary>
    [DataContract(Name = "LusidTradeTicket")]
    public partial class LusidTradeTicket : IEquatable<LusidTradeTicket>, IValidatableObject
    {
        /// <summary>
        /// The available values are: LusidTradeTicket, ExternalTradeTicket
        /// </summary>
        /// <value>The available values are: LusidTradeTicket, ExternalTradeTicket</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TradeTicketTypeEnum
        {
            /// <summary>
            /// Enum LusidTradeTicket for value: LusidTradeTicket
            /// </summary>
            [EnumMember(Value = "LusidTradeTicket")]
            LusidTradeTicket = 1,

            /// <summary>
            /// Enum ExternalTradeTicket for value: ExternalTradeTicket
            /// </summary>
            [EnumMember(Value = "ExternalTradeTicket")]
            ExternalTradeTicket = 2

        }


        /// <summary>
        /// The available values are: LusidTradeTicket, ExternalTradeTicket
        /// </summary>
        /// <value>The available values are: LusidTradeTicket, ExternalTradeTicket</value>
        [DataMember(Name = "tradeTicketType", IsRequired = true, EmitDefaultValue = true)]
        public TradeTicketTypeEnum TradeTicketType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidTradeTicket" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LusidTradeTicket() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LusidTradeTicket" /> class.
        /// </summary>
        /// <param name="transactionId">Transaction ID. Must be unique. (required).</param>
        /// <param name="transactionType">Type of transaction for processing. Referenced by Transaction Configuration. (required).</param>
        /// <param name="source">Transaction Source. Referenced by Transaction Configuration..</param>
        /// <param name="transactionDate">Transaction Date. Date at which transaction is known. (required).</param>
        /// <param name="settlementDate">Transaction settlement. Date at which transaction is finalised and realised into the system. (required).</param>
        /// <param name="totalConsideration">totalConsideration (required).</param>
        /// <param name="units">Number of units in the transaction. For an OTC this is somewhat interchangeable with the quantity booked in the  instrument. As M x N or N x M are equivalent it is advised a client chooses one approach and sticks to it.  Arguably either the unit or holding is best unitised. (required).</param>
        /// <param name="instrumentIdentifiers">Identifiers for the instrument. (required).</param>
        /// <param name="instrumentScope">Scope of instrument.</param>
        /// <param name="instrumentName">Name of instrument.</param>
        /// <param name="instrumentDefinition">instrumentDefinition.</param>
        /// <param name="counterpartyAgreementId">counterpartyAgreementId.</param>
        /// <param name="instrumentProperties">Set of instrument properties (as defined by client/user)..</param>
        /// <param name="transactionProperties">Set of transaction properties (as defined by client/user)..</param>
        /// <param name="tradeTicketType">The available values are: LusidTradeTicket, ExternalTradeTicket (required).</param>
        public LusidTradeTicket(string transactionId = default(string), string transactionType = default(string), string source = default(string), string transactionDate = default(string), string settlementDate = default(string), CurrencyAndAmount totalConsideration = default(CurrencyAndAmount), decimal units = default(decimal), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentScope = default(string), string instrumentName = default(string), LusidInstrument instrumentDefinition = default(LusidInstrument), ResourceId counterpartyAgreementId = default(ResourceId), List<Property> instrumentProperties = default(List<Property>), List<Property> transactionProperties = default(List<Property>), TradeTicketTypeEnum tradeTicketType = default(TradeTicketTypeEnum))
        {
            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new ArgumentNullException("transactionId is a required property for LusidTradeTicket and cannot be null");
            }
            this.TransactionId = transactionId;
            // to ensure "transactionType" is required (not null)
            if (transactionType == null)
            {
                throw new ArgumentNullException("transactionType is a required property for LusidTradeTicket and cannot be null");
            }
            this.TransactionType = transactionType;
            // to ensure "transactionDate" is required (not null)
            if (transactionDate == null)
            {
                throw new ArgumentNullException("transactionDate is a required property for LusidTradeTicket and cannot be null");
            }
            this.TransactionDate = transactionDate;
            // to ensure "settlementDate" is required (not null)
            if (settlementDate == null)
            {
                throw new ArgumentNullException("settlementDate is a required property for LusidTradeTicket and cannot be null");
            }
            this.SettlementDate = settlementDate;
            // to ensure "totalConsideration" is required (not null)
            if (totalConsideration == null)
            {
                throw new ArgumentNullException("totalConsideration is a required property for LusidTradeTicket and cannot be null");
            }
            this.TotalConsideration = totalConsideration;
            this.Units = units;
            // to ensure "instrumentIdentifiers" is required (not null)
            if (instrumentIdentifiers == null)
            {
                throw new ArgumentNullException("instrumentIdentifiers is a required property for LusidTradeTicket and cannot be null");
            }
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.TradeTicketType = tradeTicketType;
            this.Source = source;
            this.InstrumentScope = instrumentScope;
            this.InstrumentName = instrumentName;
            this.InstrumentDefinition = instrumentDefinition;
            this.CounterpartyAgreementId = counterpartyAgreementId;
            this.InstrumentProperties = instrumentProperties;
            this.TransactionProperties = transactionProperties;
        }

        /// <summary>
        /// Transaction ID. Must be unique.
        /// </summary>
        /// <value>Transaction ID. Must be unique.</value>
        [DataMember(Name = "transactionId", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Type of transaction for processing. Referenced by Transaction Configuration.
        /// </summary>
        /// <value>Type of transaction for processing. Referenced by Transaction Configuration.</value>
        [DataMember(Name = "transactionType", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Transaction Source. Referenced by Transaction Configuration.
        /// </summary>
        /// <value>Transaction Source. Referenced by Transaction Configuration.</value>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Transaction Date. Date at which transaction is known.
        /// </summary>
        /// <value>Transaction Date. Date at which transaction is known.</value>
        [DataMember(Name = "transactionDate", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionDate { get; set; }

        /// <summary>
        /// Transaction settlement. Date at which transaction is finalised and realised into the system.
        /// </summary>
        /// <value>Transaction settlement. Date at which transaction is finalised and realised into the system.</value>
        [DataMember(Name = "settlementDate", IsRequired = true, EmitDefaultValue = true)]
        public string SettlementDate { get; set; }

        /// <summary>
        /// Gets or Sets TotalConsideration
        /// </summary>
        [DataMember(Name = "totalConsideration", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyAndAmount TotalConsideration { get; set; }

        /// <summary>
        /// Number of units in the transaction. For an OTC this is somewhat interchangeable with the quantity booked in the  instrument. As M x N or N x M are equivalent it is advised a client chooses one approach and sticks to it.  Arguably either the unit or holding is best unitised.
        /// </summary>
        /// <value>Number of units in the transaction. For an OTC this is somewhat interchangeable with the quantity booked in the  instrument. As M x N or N x M are equivalent it is advised a client chooses one approach and sticks to it.  Arguably either the unit or holding is best unitised.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// Identifiers for the instrument.
        /// </summary>
        /// <value>Identifiers for the instrument.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// Scope of instrument
        /// </summary>
        /// <value>Scope of instrument</value>
        [DataMember(Name = "instrumentScope", EmitDefaultValue = true)]
        public string InstrumentScope { get; set; }

        /// <summary>
        /// Name of instrument
        /// </summary>
        /// <value>Name of instrument</value>
        [DataMember(Name = "instrumentName", EmitDefaultValue = true)]
        public string InstrumentName { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentDefinition
        /// </summary>
        [DataMember(Name = "instrumentDefinition", EmitDefaultValue = false)]
        public LusidInstrument InstrumentDefinition { get; set; }

        /// <summary>
        /// Gets or Sets CounterpartyAgreementId
        /// </summary>
        [DataMember(Name = "counterpartyAgreementId", EmitDefaultValue = false)]
        public ResourceId CounterpartyAgreementId { get; set; }

        /// <summary>
        /// Set of instrument properties (as defined by client/user).
        /// </summary>
        /// <value>Set of instrument properties (as defined by client/user).</value>
        [DataMember(Name = "instrumentProperties", EmitDefaultValue = true)]
        public List<Property> InstrumentProperties { get; set; }

        /// <summary>
        /// Set of transaction properties (as defined by client/user).
        /// </summary>
        /// <value>Set of transaction properties (as defined by client/user).</value>
        [DataMember(Name = "transactionProperties", EmitDefaultValue = true)]
        public List<Property> TransactionProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LusidTradeTicket {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  TotalConsideration: ").Append(TotalConsideration).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentScope: ").Append(InstrumentScope).Append("\n");
            sb.Append("  InstrumentName: ").Append(InstrumentName).Append("\n");
            sb.Append("  InstrumentDefinition: ").Append(InstrumentDefinition).Append("\n");
            sb.Append("  CounterpartyAgreementId: ").Append(CounterpartyAgreementId).Append("\n");
            sb.Append("  InstrumentProperties: ").Append(InstrumentProperties).Append("\n");
            sb.Append("  TransactionProperties: ").Append(TransactionProperties).Append("\n");
            sb.Append("  TradeTicketType: ").Append(TradeTicketType).Append("\n");
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
            return this.Equals(input as LusidTradeTicket);
        }

        /// <summary>
        /// Returns true if LusidTradeTicket instances are equal
        /// </summary>
        /// <param name="input">Instance of LusidTradeTicket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LusidTradeTicket input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.TotalConsideration == input.TotalConsideration ||
                    (this.TotalConsideration != null &&
                    this.TotalConsideration.Equals(input.TotalConsideration))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentScope == input.InstrumentScope ||
                    (this.InstrumentScope != null &&
                    this.InstrumentScope.Equals(input.InstrumentScope))
                ) && 
                (
                    this.InstrumentName == input.InstrumentName ||
                    (this.InstrumentName != null &&
                    this.InstrumentName.Equals(input.InstrumentName))
                ) && 
                (
                    this.InstrumentDefinition == input.InstrumentDefinition ||
                    (this.InstrumentDefinition != null &&
                    this.InstrumentDefinition.Equals(input.InstrumentDefinition))
                ) && 
                (
                    this.CounterpartyAgreementId == input.CounterpartyAgreementId ||
                    (this.CounterpartyAgreementId != null &&
                    this.CounterpartyAgreementId.Equals(input.CounterpartyAgreementId))
                ) && 
                (
                    this.InstrumentProperties == input.InstrumentProperties ||
                    this.InstrumentProperties != null &&
                    input.InstrumentProperties != null &&
                    this.InstrumentProperties.SequenceEqual(input.InstrumentProperties)
                ) && 
                (
                    this.TransactionProperties == input.TransactionProperties ||
                    this.TransactionProperties != null &&
                    input.TransactionProperties != null &&
                    this.TransactionProperties.SequenceEqual(input.TransactionProperties)
                ) && 
                (
                    this.TradeTicketType == input.TradeTicketType ||
                    this.TradeTicketType.Equals(input.TradeTicketType)
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
                if (this.TransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionId.GetHashCode();
                }
                if (this.TransactionType != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionType.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.TransactionDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionDate.GetHashCode();
                }
                if (this.SettlementDate != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementDate.GetHashCode();
                }
                if (this.TotalConsideration != null)
                {
                    hashCode = (hashCode * 59) + this.TotalConsideration.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Units.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentIdentifiers.GetHashCode();
                }
                if (this.InstrumentScope != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentScope.GetHashCode();
                }
                if (this.InstrumentName != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentName.GetHashCode();
                }
                if (this.InstrumentDefinition != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentDefinition.GetHashCode();
                }
                if (this.CounterpartyAgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.CounterpartyAgreementId.GetHashCode();
                }
                if (this.InstrumentProperties != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentProperties.GetHashCode();
                }
                if (this.TransactionProperties != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionProperties.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TradeTicketType.GetHashCode();
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
            // TransactionId (string) maxLength
            if (this.TransactionId != null && this.TransactionId.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be less than 256.", new [] { "TransactionId" });
            }

            // TransactionId (string) minLength
            if (this.TransactionId != null && this.TransactionId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be greater than 0.", new [] { "TransactionId" });
            }

            // TransactionType (string) maxLength
            if (this.TransactionType != null && this.TransactionType.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be less than 256.", new [] { "TransactionType" });
            }

            // TransactionType (string) minLength
            if (this.TransactionType != null && this.TransactionType.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be greater than 0.", new [] { "TransactionType" });
            }

            // Source (string) maxLength
            if (this.Source != null && this.Source.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be less than 256.", new [] { "Source" });
            }

            // Source (string) minLength
            if (this.Source != null && this.Source.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be greater than 0.", new [] { "Source" });
            }

            // TransactionDate (string) minLength
            if (this.TransactionDate != null && this.TransactionDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionDate, length must be greater than 1.", new [] { "TransactionDate" });
            }

            // SettlementDate (string) minLength
            if (this.SettlementDate != null && this.SettlementDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementDate, length must be greater than 1.", new [] { "SettlementDate" });
            }

            // InstrumentScope (string) maxLength
            if (this.InstrumentScope != null && this.InstrumentScope.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentScope, length must be less than 64.", new [] { "InstrumentScope" });
            }

            // InstrumentScope (string) minLength
            if (this.InstrumentScope != null && this.InstrumentScope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentScope, length must be greater than 1.", new [] { "InstrumentScope" });
            }

            // InstrumentScope (string) pattern
            Regex regexInstrumentScope = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexInstrumentScope.Match(this.InstrumentScope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentScope, must match a pattern of " + regexInstrumentScope, new [] { "InstrumentScope" });
            }

            // InstrumentName (string) maxLength
            if (this.InstrumentName != null && this.InstrumentName.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentName, length must be less than 256.", new [] { "InstrumentName" });
            }

            // InstrumentName (string) minLength
            if (this.InstrumentName != null && this.InstrumentName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstrumentName, length must be greater than 0.", new [] { "InstrumentName" });
            }

            yield break;
        }
    }
}
