/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3494
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
    /// An Allocation of a certain quantity of a specific instrument against an originating  Order.
    /// </summary>
    [DataContract(Name = "Allocation")]
    public partial class Allocation : IEquatable<Allocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Allocation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Allocation" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="allocatedOrderId">allocatedOrderId (required).</param>
        /// <param name="portfolioId">portfolioId (required).</param>
        /// <param name="quantity">The quantity of given instrument allocated. (required).</param>
        /// <param name="instrumentIdentifiers">The instrument allocated. (required).</param>
        /// <param name="version">version.</param>
        /// <param name="properties">Client-defined properties associated with this allocation..</param>
        /// <param name="lusidInstrumentId">The LUSID instrument id for the instrument allocated. (required).</param>
        /// <param name="placementIds">A placement - also known as an order placed in the market - associated with this allocation..</param>
        /// <param name="state">The state of this allocation..</param>
        /// <param name="side">The side of this allocation (examples: Buy, Sell, ...)..</param>
        /// <param name="type">The type of order associated with this allocation (examples: Limit, Market, ...)..</param>
        /// <param name="settlementDate">The settlement date for this allocation..</param>
        /// <param name="date">The date of this allocation..</param>
        /// <param name="price">price.</param>
        /// <param name="settlementCurrency">The settlement currency of this allocation..</param>
        /// <param name="settlementCurrencyFxRate">The settlement currency to allocation currency FX rate..</param>
        /// <param name="counterparty">The counterparty for this allocation..</param>
        /// <param name="links">Collection of links..</param>
        public Allocation(ResourceId id = default(ResourceId), ResourceId allocatedOrderId = default(ResourceId), ResourceId portfolioId = default(ResourceId), int quantity = default(int), Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), Version version = default(Version), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), string lusidInstrumentId = default(string), List<ResourceId> placementIds = default(List<ResourceId>), string state = default(string), string side = default(string), string type = default(string), DateTimeOffset settlementDate = default(DateTimeOffset), DateTimeOffset date = default(DateTimeOffset), CurrencyAndAmount price = default(CurrencyAndAmount), string settlementCurrency = default(string), decimal settlementCurrencyFxRate = default(decimal), string counterparty = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Allocation and cannot be null");
            // to ensure "allocatedOrderId" is required (not null)
            this.AllocatedOrderId = allocatedOrderId ?? throw new ArgumentNullException("allocatedOrderId is a required property for Allocation and cannot be null");
            // to ensure "portfolioId" is required (not null)
            this.PortfolioId = portfolioId ?? throw new ArgumentNullException("portfolioId is a required property for Allocation and cannot be null");
            this.Quantity = quantity;
            // to ensure "instrumentIdentifiers" is required (not null)
            this.InstrumentIdentifiers = instrumentIdentifiers ?? throw new ArgumentNullException("instrumentIdentifiers is a required property for Allocation and cannot be null");
            // to ensure "lusidInstrumentId" is required (not null)
            this.LusidInstrumentId = lusidInstrumentId ?? throw new ArgumentNullException("lusidInstrumentId is a required property for Allocation and cannot be null");
            this.Version = version;
            this.Properties = properties;
            this.PlacementIds = placementIds;
            this.State = state;
            this.Side = side;
            this.Type = type;
            this.SettlementDate = settlementDate;
            this.Date = date;
            this.Price = price;
            this.SettlementCurrency = settlementCurrency;
            this.SettlementCurrencyFxRate = settlementCurrencyFxRate;
            this.Counterparty = counterparty;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Gets or Sets AllocatedOrderId
        /// </summary>
        [DataMember(Name = "allocatedOrderId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId AllocatedOrderId { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioId
        /// </summary>
        [DataMember(Name = "portfolioId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId PortfolioId { get; set; }

        /// <summary>
        /// The quantity of given instrument allocated.
        /// </summary>
        /// <value>The quantity of given instrument allocated.</value>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// The instrument allocated.
        /// </summary>
        /// <value>The instrument allocated.</value>
        [DataMember(Name = "instrumentIdentifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// Client-defined properties associated with this allocation.
        /// </summary>
        /// <value>Client-defined properties associated with this allocation.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// The LUSID instrument id for the instrument allocated.
        /// </summary>
        /// <value>The LUSID instrument id for the instrument allocated.</value>
        [DataMember(Name = "lusidInstrumentId", IsRequired = true, EmitDefaultValue = false)]
        public string LusidInstrumentId { get; set; }

        /// <summary>
        /// A placement - also known as an order placed in the market - associated with this allocation.
        /// </summary>
        /// <value>A placement - also known as an order placed in the market - associated with this allocation.</value>
        [DataMember(Name = "placementIds", EmitDefaultValue = true)]
        public List<ResourceId> PlacementIds { get; set; }

        /// <summary>
        /// The state of this allocation.
        /// </summary>
        /// <value>The state of this allocation.</value>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The side of this allocation (examples: Buy, Sell, ...).
        /// </summary>
        /// <value>The side of this allocation (examples: Buy, Sell, ...).</value>
        [DataMember(Name = "side", EmitDefaultValue = true)]
        public string Side { get; set; }

        /// <summary>
        /// The type of order associated with this allocation (examples: Limit, Market, ...).
        /// </summary>
        /// <value>The type of order associated with this allocation (examples: Limit, Market, ...).</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The settlement date for this allocation.
        /// </summary>
        /// <value>The settlement date for this allocation.</value>
        [DataMember(Name = "settlementDate", EmitDefaultValue = false)]
        public DateTimeOffset SettlementDate { get; set; }

        /// <summary>
        /// The date of this allocation.
        /// </summary>
        /// <value>The date of this allocation.</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public CurrencyAndAmount Price { get; set; }

        /// <summary>
        /// The settlement currency of this allocation.
        /// </summary>
        /// <value>The settlement currency of this allocation.</value>
        [DataMember(Name = "settlementCurrency", EmitDefaultValue = true)]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// The settlement currency to allocation currency FX rate.
        /// </summary>
        /// <value>The settlement currency to allocation currency FX rate.</value>
        [DataMember(Name = "settlementCurrencyFxRate", EmitDefaultValue = true)]
        public decimal SettlementCurrencyFxRate { get; set; }

        /// <summary>
        /// The counterparty for this allocation.
        /// </summary>
        /// <value>The counterparty for this allocation.</value>
        [DataMember(Name = "counterparty", EmitDefaultValue = true)]
        public string Counterparty { get; set; }

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
            sb.Append("class Allocation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AllocatedOrderId: ").Append(AllocatedOrderId).Append("\n");
            sb.Append("  PortfolioId: ").Append(PortfolioId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  LusidInstrumentId: ").Append(LusidInstrumentId).Append("\n");
            sb.Append("  PlacementIds: ").Append(PlacementIds).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SettlementCurrency: ").Append(SettlementCurrency).Append("\n");
            sb.Append("  SettlementCurrencyFxRate: ").Append(SettlementCurrencyFxRate).Append("\n");
            sb.Append("  Counterparty: ").Append(Counterparty).Append("\n");
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
            return this.Equals(input as Allocation);
        }

        /// <summary>
        /// Returns true if Allocation instances are equal
        /// </summary>
        /// <param name="input">Instance of Allocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Allocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AllocatedOrderId == input.AllocatedOrderId ||
                    (this.AllocatedOrderId != null &&
                    this.AllocatedOrderId.Equals(input.AllocatedOrderId))
                ) && 
                (
                    this.PortfolioId == input.PortfolioId ||
                    (this.PortfolioId != null &&
                    this.PortfolioId.Equals(input.PortfolioId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.LusidInstrumentId == input.LusidInstrumentId ||
                    (this.LusidInstrumentId != null &&
                    this.LusidInstrumentId.Equals(input.LusidInstrumentId))
                ) && 
                (
                    this.PlacementIds == input.PlacementIds ||
                    this.PlacementIds != null &&
                    input.PlacementIds != null &&
                    this.PlacementIds.SequenceEqual(input.PlacementIds)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SettlementDate == input.SettlementDate ||
                    (this.SettlementDate != null &&
                    this.SettlementDate.Equals(input.SettlementDate))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.SettlementCurrency == input.SettlementCurrency ||
                    (this.SettlementCurrency != null &&
                    this.SettlementCurrency.Equals(input.SettlementCurrency))
                ) && 
                (
                    this.SettlementCurrencyFxRate == input.SettlementCurrencyFxRate ||
                    this.SettlementCurrencyFxRate.Equals(input.SettlementCurrencyFxRate)
                ) && 
                (
                    this.Counterparty == input.Counterparty ||
                    (this.Counterparty != null &&
                    this.Counterparty.Equals(input.Counterparty))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AllocatedOrderId != null)
                    hashCode = hashCode * 59 + this.AllocatedOrderId.GetHashCode();
                if (this.PortfolioId != null)
                    hashCode = hashCode * 59 + this.PortfolioId.GetHashCode();
                hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.LusidInstrumentId != null)
                    hashCode = hashCode * 59 + this.LusidInstrumentId.GetHashCode();
                if (this.PlacementIds != null)
                    hashCode = hashCode * 59 + this.PlacementIds.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SettlementDate != null)
                    hashCode = hashCode * 59 + this.SettlementDate.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.SettlementCurrency != null)
                    hashCode = hashCode * 59 + this.SettlementCurrency.GetHashCode();
                hashCode = hashCode * 59 + this.SettlementCurrencyFxRate.GetHashCode();
                if (this.Counterparty != null)
                    hashCode = hashCode * 59 + this.Counterparty.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
