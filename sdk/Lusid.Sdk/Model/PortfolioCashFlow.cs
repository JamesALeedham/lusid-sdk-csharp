/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3507
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
    /// The details for the cashflow for a given portfolio.
    /// </summary>
    [DataContract(Name = "PortfolioCashFlow")]
    public partial class PortfolioCashFlow : IEquatable<PortfolioCashFlow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioCashFlow" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioCashFlow() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioCashFlow" /> class.
        /// </summary>
        /// <param name="groupById">The groupBy subHoldings and currency. (required).</param>
        /// <param name="sequenceNumber">Sequence number determining the order of the cash flow records. (required).</param>
        /// <param name="effectiveDate">Indicates the date when the cash-flow settles..</param>
        /// <param name="subHoldingKeys">The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created..</param>
        /// <param name="type">Indicates the record type (Closed, Open, Activity). (required).</param>
        /// <param name="movementName">Indicates the specific movement of the transaction that generated this cash flow. (required).</param>
        /// <param name="cashflow">cashflow (required).</param>
        /// <param name="balance">balance (required).</param>
        /// <param name="fxRate">Exchange rate between the currency of this cash flow and the reporting currency. (required).</param>
        /// <param name="cashflowReportingCurrency">cashflowReportingCurrency (required).</param>
        /// <param name="balanceReportingCurrency">balanceReportingCurrency (required).</param>
        /// <param name="translationGainLoss">translationGainLoss (required).</param>
        /// <param name="costBasisReportingCurrency">costBasisReportingCurrency (required).</param>
        /// <param name="transaction">transaction.</param>
        /// <param name="links">Collection of links..</param>
        public PortfolioCashFlow(int groupById = default(int), int sequenceNumber = default(int), DateTimeOffset effectiveDate = default(DateTimeOffset), Dictionary<string, PerpetualProperty> subHoldingKeys = default(Dictionary<string, PerpetualProperty>), string type = default(string), string movementName = default(string), CurrencyAndAmount cashflow = default(CurrencyAndAmount), CurrencyAndAmount balance = default(CurrencyAndAmount), decimal fxRate = default(decimal), CurrencyAndAmount cashflowReportingCurrency = default(CurrencyAndAmount), CurrencyAndAmount balanceReportingCurrency = default(CurrencyAndAmount), CurrencyAndAmount translationGainLoss = default(CurrencyAndAmount), CurrencyAndAmount costBasisReportingCurrency = default(CurrencyAndAmount), Transaction transaction = default(Transaction), List<Link> links = default(List<Link>))
        {
            this.GroupById = groupById;
            this.SequenceNumber = sequenceNumber;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PortfolioCashFlow and cannot be null");
            // to ensure "movementName" is required (not null)
            this.MovementName = movementName ?? throw new ArgumentNullException("movementName is a required property for PortfolioCashFlow and cannot be null");
            // to ensure "cashflow" is required (not null)
            this.Cashflow = cashflow ?? throw new ArgumentNullException("cashflow is a required property for PortfolioCashFlow and cannot be null");
            // to ensure "balance" is required (not null)
            this.Balance = balance ?? throw new ArgumentNullException("balance is a required property for PortfolioCashFlow and cannot be null");
            this.FxRate = fxRate;
            // to ensure "cashflowReportingCurrency" is required (not null)
            this.CashflowReportingCurrency = cashflowReportingCurrency ?? throw new ArgumentNullException("cashflowReportingCurrency is a required property for PortfolioCashFlow and cannot be null");
            // to ensure "balanceReportingCurrency" is required (not null)
            this.BalanceReportingCurrency = balanceReportingCurrency ?? throw new ArgumentNullException("balanceReportingCurrency is a required property for PortfolioCashFlow and cannot be null");
            // to ensure "translationGainLoss" is required (not null)
            this.TranslationGainLoss = translationGainLoss ?? throw new ArgumentNullException("translationGainLoss is a required property for PortfolioCashFlow and cannot be null");
            // to ensure "costBasisReportingCurrency" is required (not null)
            this.CostBasisReportingCurrency = costBasisReportingCurrency ?? throw new ArgumentNullException("costBasisReportingCurrency is a required property for PortfolioCashFlow and cannot be null");
            this.EffectiveDate = effectiveDate;
            this.SubHoldingKeys = subHoldingKeys;
            this.Transaction = transaction;
            this.Links = links;
        }

        /// <summary>
        /// The groupBy subHoldings and currency.
        /// </summary>
        /// <value>The groupBy subHoldings and currency.</value>
        [DataMember(Name = "groupById", IsRequired = true, EmitDefaultValue = true)]
        public int GroupById { get; set; }

        /// <summary>
        /// Sequence number determining the order of the cash flow records.
        /// </summary>
        /// <value>Sequence number determining the order of the cash flow records.</value>
        [DataMember(Name = "sequenceNumber", IsRequired = true, EmitDefaultValue = true)]
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Indicates the date when the cash-flow settles.
        /// </summary>
        /// <value>Indicates the date when the cash-flow settles.</value>
        [DataMember(Name = "effectiveDate", EmitDefaultValue = false)]
        public DateTimeOffset EffectiveDate { get; set; }

        /// <summary>
        /// The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created.
        /// </summary>
        /// <value>The sub-holding properties which identify the holding. Each property will be from the &#39;Transaction&#39; domain. These are configured when a transaction portfolio is created.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> SubHoldingKeys { get; set; }

        /// <summary>
        /// Indicates the record type (Closed, Open, Activity).
        /// </summary>
        /// <value>Indicates the record type (Closed, Open, Activity).</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Indicates the specific movement of the transaction that generated this cash flow.
        /// </summary>
        /// <value>Indicates the specific movement of the transaction that generated this cash flow.</value>
        [DataMember(Name = "movementName", IsRequired = true, EmitDefaultValue = false)]
        public string MovementName { get; set; }

        /// <summary>
        /// Gets or Sets Cashflow
        /// </summary>
        [DataMember(Name = "cashflow", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount Cashflow { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount Balance { get; set; }

        /// <summary>
        /// Exchange rate between the currency of this cash flow and the reporting currency.
        /// </summary>
        /// <value>Exchange rate between the currency of this cash flow and the reporting currency.</value>
        [DataMember(Name = "fxRate", IsRequired = true, EmitDefaultValue = true)]
        public decimal FxRate { get; set; }

        /// <summary>
        /// Gets or Sets CashflowReportingCurrency
        /// </summary>
        [DataMember(Name = "cashflowReportingCurrency", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount CashflowReportingCurrency { get; set; }

        /// <summary>
        /// Gets or Sets BalanceReportingCurrency
        /// </summary>
        [DataMember(Name = "balanceReportingCurrency", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount BalanceReportingCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TranslationGainLoss
        /// </summary>
        [DataMember(Name = "translationGainLoss", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount TranslationGainLoss { get; set; }

        /// <summary>
        /// Gets or Sets CostBasisReportingCurrency
        /// </summary>
        [DataMember(Name = "costBasisReportingCurrency", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount CostBasisReportingCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Collection of links.
        /// </summary>
        /// <value>Collection of links.</value>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortfolioCashFlow {\n");
            sb.Append("  GroupById: ").Append(GroupById).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MovementName: ").Append(MovementName).Append("\n");
            sb.Append("  Cashflow: ").Append(Cashflow).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  FxRate: ").Append(FxRate).Append("\n");
            sb.Append("  CashflowReportingCurrency: ").Append(CashflowReportingCurrency).Append("\n");
            sb.Append("  BalanceReportingCurrency: ").Append(BalanceReportingCurrency).Append("\n");
            sb.Append("  TranslationGainLoss: ").Append(TranslationGainLoss).Append("\n");
            sb.Append("  CostBasisReportingCurrency: ").Append(CostBasisReportingCurrency).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PortfolioCashFlow);
        }

        /// <summary>
        /// Returns true if PortfolioCashFlow instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioCashFlow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioCashFlow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupById == input.GroupById ||
                    this.GroupById.Equals(input.GroupById)
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    this.SequenceNumber.Equals(input.SequenceNumber)
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.MovementName == input.MovementName ||
                    (this.MovementName != null &&
                    this.MovementName.Equals(input.MovementName))
                ) && 
                (
                    this.Cashflow == input.Cashflow ||
                    (this.Cashflow != null &&
                    this.Cashflow.Equals(input.Cashflow))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.FxRate == input.FxRate ||
                    this.FxRate.Equals(input.FxRate)
                ) && 
                (
                    this.CashflowReportingCurrency == input.CashflowReportingCurrency ||
                    (this.CashflowReportingCurrency != null &&
                    this.CashflowReportingCurrency.Equals(input.CashflowReportingCurrency))
                ) && 
                (
                    this.BalanceReportingCurrency == input.BalanceReportingCurrency ||
                    (this.BalanceReportingCurrency != null &&
                    this.BalanceReportingCurrency.Equals(input.BalanceReportingCurrency))
                ) && 
                (
                    this.TranslationGainLoss == input.TranslationGainLoss ||
                    (this.TranslationGainLoss != null &&
                    this.TranslationGainLoss.Equals(input.TranslationGainLoss))
                ) && 
                (
                    this.CostBasisReportingCurrency == input.CostBasisReportingCurrency ||
                    (this.CostBasisReportingCurrency != null &&
                    this.CostBasisReportingCurrency.Equals(input.CostBasisReportingCurrency))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                hashCode = hashCode * 59 + this.GroupById.GetHashCode();
                hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MovementName != null)
                    hashCode = hashCode * 59 + this.MovementName.GetHashCode();
                if (this.Cashflow != null)
                    hashCode = hashCode * 59 + this.Cashflow.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                hashCode = hashCode * 59 + this.FxRate.GetHashCode();
                if (this.CashflowReportingCurrency != null)
                    hashCode = hashCode * 59 + this.CashflowReportingCurrency.GetHashCode();
                if (this.BalanceReportingCurrency != null)
                    hashCode = hashCode * 59 + this.BalanceReportingCurrency.GetHashCode();
                if (this.TranslationGainLoss != null)
                    hashCode = hashCode * 59 + this.TranslationGainLoss.GetHashCode();
                if (this.CostBasisReportingCurrency != null)
                    hashCode = hashCode * 59 + this.CostBasisReportingCurrency.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
