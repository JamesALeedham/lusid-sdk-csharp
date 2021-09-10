/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3472
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
    /// RealisedGainLoss
    /// </summary>
    [DataContract(Name = "RealisedGainLoss")]
    public partial class RealisedGainLoss : IEquatable<RealisedGainLoss>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealisedGainLoss" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RealisedGainLoss() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RealisedGainLoss" /> class.
        /// </summary>
        /// <param name="instrumentUid">The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with. (required).</param>
        /// <param name="units">The number of units of the associated instrument against which the gain or loss has been realised. (required).</param>
        /// <param name="purchasePrice">The purchase price of each unit associated with this gain or loss..</param>
        /// <param name="costTradeCcy">costTradeCcy (required).</param>
        /// <param name="costPortfolioCcy">costPortfolioCcy (required).</param>
        /// <param name="realisedTradeCcy">realisedTradeCcy (required).</param>
        /// <param name="realisedTotal">realisedTotal (required).</param>
        /// <param name="realisedMarket">realisedMarket.</param>
        /// <param name="realisedCurrency">realisedCurrency.</param>
        public RealisedGainLoss(string instrumentUid = default(string), decimal units = default(decimal), decimal? purchasePrice = default(decimal?), CurrencyAndAmount costTradeCcy = default(CurrencyAndAmount), CurrencyAndAmount costPortfolioCcy = default(CurrencyAndAmount), CurrencyAndAmount realisedTradeCcy = default(CurrencyAndAmount), CurrencyAndAmount realisedTotal = default(CurrencyAndAmount), CurrencyAndAmount realisedMarket = default(CurrencyAndAmount), CurrencyAndAmount realisedCurrency = default(CurrencyAndAmount))
        {
            // to ensure "instrumentUid" is required (not null)
            this.InstrumentUid = instrumentUid ?? throw new ArgumentNullException("instrumentUid is a required property for RealisedGainLoss and cannot be null");
            this.Units = units;
            // to ensure "costTradeCcy" is required (not null)
            this.CostTradeCcy = costTradeCcy ?? throw new ArgumentNullException("costTradeCcy is a required property for RealisedGainLoss and cannot be null");
            // to ensure "costPortfolioCcy" is required (not null)
            this.CostPortfolioCcy = costPortfolioCcy ?? throw new ArgumentNullException("costPortfolioCcy is a required property for RealisedGainLoss and cannot be null");
            // to ensure "realisedTradeCcy" is required (not null)
            this.RealisedTradeCcy = realisedTradeCcy ?? throw new ArgumentNullException("realisedTradeCcy is a required property for RealisedGainLoss and cannot be null");
            // to ensure "realisedTotal" is required (not null)
            this.RealisedTotal = realisedTotal ?? throw new ArgumentNullException("realisedTotal is a required property for RealisedGainLoss and cannot be null");
            this.PurchasePrice = purchasePrice;
            this.RealisedMarket = realisedMarket;
            this.RealisedCurrency = realisedCurrency;
        }

        /// <summary>
        /// The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with.
        /// </summary>
        /// <value>The unqiue Lusid Instrument Id (LUID) of the instrument that this gain or loss is associated with.</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// The number of units of the associated instrument against which the gain or loss has been realised.
        /// </summary>
        /// <value>The number of units of the associated instrument against which the gain or loss has been realised.</value>
        [DataMember(Name = "units", IsRequired = true, EmitDefaultValue = true)]
        public decimal Units { get; set; }

        /// <summary>
        /// The effective datetime that the units associated with this gain or loss where originally purchased.
        /// </summary>
        /// <value>The effective datetime that the units associated with this gain or loss where originally purchased.</value>
        [DataMember(Name = "purchaseTradeDate", EmitDefaultValue = true)]
        public DateTimeOffset? PurchaseTradeDate { get; private set; }

        /// <summary>
        /// Returns false as PurchaseTradeDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePurchaseTradeDate()
        {
            return false;
        }

        /// <summary>
        /// The effective datetime that the units associated with this gain or loss where originally settled.
        /// </summary>
        /// <value>The effective datetime that the units associated with this gain or loss where originally settled.</value>
        [DataMember(Name = "purchaseSettlementDate", EmitDefaultValue = true)]
        public DateTimeOffset? PurchaseSettlementDate { get; private set; }

        /// <summary>
        /// Returns false as PurchaseSettlementDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePurchaseSettlementDate()
        {
            return false;
        }

        /// <summary>
        /// The purchase price of each unit associated with this gain or loss.
        /// </summary>
        /// <value>The purchase price of each unit associated with this gain or loss.</value>
        [DataMember(Name = "purchasePrice", EmitDefaultValue = true)]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets CostTradeCcy
        /// </summary>
        [DataMember(Name = "costTradeCcy", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount CostTradeCcy { get; set; }

        /// <summary>
        /// Gets or Sets CostPortfolioCcy
        /// </summary>
        [DataMember(Name = "costPortfolioCcy", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount CostPortfolioCcy { get; set; }

        /// <summary>
        /// Gets or Sets RealisedTradeCcy
        /// </summary>
        [DataMember(Name = "realisedTradeCcy", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount RealisedTradeCcy { get; set; }

        /// <summary>
        /// Gets or Sets RealisedTotal
        /// </summary>
        [DataMember(Name = "realisedTotal", IsRequired = true, EmitDefaultValue = false)]
        public CurrencyAndAmount RealisedTotal { get; set; }

        /// <summary>
        /// Gets or Sets RealisedMarket
        /// </summary>
        [DataMember(Name = "realisedMarket", EmitDefaultValue = false)]
        public CurrencyAndAmount RealisedMarket { get; set; }

        /// <summary>
        /// Gets or Sets RealisedCurrency
        /// </summary>
        [DataMember(Name = "realisedCurrency", EmitDefaultValue = false)]
        public CurrencyAndAmount RealisedCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RealisedGainLoss {\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  PurchaseTradeDate: ").Append(PurchaseTradeDate).Append("\n");
            sb.Append("  PurchaseSettlementDate: ").Append(PurchaseSettlementDate).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  CostTradeCcy: ").Append(CostTradeCcy).Append("\n");
            sb.Append("  CostPortfolioCcy: ").Append(CostPortfolioCcy).Append("\n");
            sb.Append("  RealisedTradeCcy: ").Append(RealisedTradeCcy).Append("\n");
            sb.Append("  RealisedTotal: ").Append(RealisedTotal).Append("\n");
            sb.Append("  RealisedMarket: ").Append(RealisedMarket).Append("\n");
            sb.Append("  RealisedCurrency: ").Append(RealisedCurrency).Append("\n");
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
            return this.Equals(input as RealisedGainLoss);
        }

        /// <summary>
        /// Returns true if RealisedGainLoss instances are equal
        /// </summary>
        /// <param name="input">Instance of RealisedGainLoss to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RealisedGainLoss input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
                ) && 
                (
                    this.PurchaseTradeDate == input.PurchaseTradeDate ||
                    (this.PurchaseTradeDate != null &&
                    this.PurchaseTradeDate.Equals(input.PurchaseTradeDate))
                ) && 
                (
                    this.PurchaseSettlementDate == input.PurchaseSettlementDate ||
                    (this.PurchaseSettlementDate != null &&
                    this.PurchaseSettlementDate.Equals(input.PurchaseSettlementDate))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.CostTradeCcy == input.CostTradeCcy ||
                    (this.CostTradeCcy != null &&
                    this.CostTradeCcy.Equals(input.CostTradeCcy))
                ) && 
                (
                    this.CostPortfolioCcy == input.CostPortfolioCcy ||
                    (this.CostPortfolioCcy != null &&
                    this.CostPortfolioCcy.Equals(input.CostPortfolioCcy))
                ) && 
                (
                    this.RealisedTradeCcy == input.RealisedTradeCcy ||
                    (this.RealisedTradeCcy != null &&
                    this.RealisedTradeCcy.Equals(input.RealisedTradeCcy))
                ) && 
                (
                    this.RealisedTotal == input.RealisedTotal ||
                    (this.RealisedTotal != null &&
                    this.RealisedTotal.Equals(input.RealisedTotal))
                ) && 
                (
                    this.RealisedMarket == input.RealisedMarket ||
                    (this.RealisedMarket != null &&
                    this.RealisedMarket.Equals(input.RealisedMarket))
                ) && 
                (
                    this.RealisedCurrency == input.RealisedCurrency ||
                    (this.RealisedCurrency != null &&
                    this.RealisedCurrency.Equals(input.RealisedCurrency))
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
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.PurchaseTradeDate != null)
                    hashCode = hashCode * 59 + this.PurchaseTradeDate.GetHashCode();
                if (this.PurchaseSettlementDate != null)
                    hashCode = hashCode * 59 + this.PurchaseSettlementDate.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.CostTradeCcy != null)
                    hashCode = hashCode * 59 + this.CostTradeCcy.GetHashCode();
                if (this.CostPortfolioCcy != null)
                    hashCode = hashCode * 59 + this.CostPortfolioCcy.GetHashCode();
                if (this.RealisedTradeCcy != null)
                    hashCode = hashCode * 59 + this.RealisedTradeCcy.GetHashCode();
                if (this.RealisedTotal != null)
                    hashCode = hashCode * 59 + this.RealisedTotal.GetHashCode();
                if (this.RealisedMarket != null)
                    hashCode = hashCode * 59 + this.RealisedMarket.GetHashCode();
                if (this.RealisedCurrency != null)
                    hashCode = hashCode * 59 + this.RealisedCurrency.GetHashCode();
                return hashCode;
            }
        }

    }
}
