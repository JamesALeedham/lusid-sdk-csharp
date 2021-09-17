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
    /// The time invariant unique identifier of the quote. Combined with the effective datetime of the quote this  uniquely identifies the quote. This can be thought of as a unique identifier for a time series of quotes.
    /// </summary>
    [DataContract(Name = "QuoteSeriesId")]
    public partial class QuoteSeriesId : IEquatable<QuoteSeriesId>
    {
        /// <summary>
        /// The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. The available values are: LusidInstrumentId, Figi, RIC, QuotePermId, Isin, CurrencyPair, ClientInternal
        /// </summary>
        /// <value>The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. The available values are: LusidInstrumentId, Figi, RIC, QuotePermId, Isin, CurrencyPair, ClientInternal</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InstrumentIdTypeEnum
        {
            /// <summary>
            /// Enum LusidInstrumentId for value: LusidInstrumentId
            /// </summary>
            [EnumMember(Value = "LusidInstrumentId")]
            LusidInstrumentId = 1,

            /// <summary>
            /// Enum Figi for value: Figi
            /// </summary>
            [EnumMember(Value = "Figi")]
            Figi = 2,

            /// <summary>
            /// Enum RIC for value: RIC
            /// </summary>
            [EnumMember(Value = "RIC")]
            RIC = 3,

            /// <summary>
            /// Enum QuotePermId for value: QuotePermId
            /// </summary>
            [EnumMember(Value = "QuotePermId")]
            QuotePermId = 4,

            /// <summary>
            /// Enum Isin for value: Isin
            /// </summary>
            [EnumMember(Value = "Isin")]
            Isin = 5,

            /// <summary>
            /// Enum CurrencyPair for value: CurrencyPair
            /// </summary>
            [EnumMember(Value = "CurrencyPair")]
            CurrencyPair = 6,

            /// <summary>
            /// Enum ClientInternal for value: ClientInternal
            /// </summary>
            [EnumMember(Value = "ClientInternal")]
            ClientInternal = 7

        }


        /// <summary>
        /// The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. The available values are: LusidInstrumentId, Figi, RIC, QuotePermId, Isin, CurrencyPair, ClientInternal
        /// </summary>
        /// <value>The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. The available values are: LusidInstrumentId, Figi, RIC, QuotePermId, Isin, CurrencyPair, ClientInternal</value>
        [DataMember(Name = "instrumentIdType", IsRequired = true, EmitDefaultValue = true)]
        public InstrumentIdTypeEnum InstrumentIdType { get; set; }
        /// <summary>
        /// The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. The available values are: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront
        /// </summary>
        /// <value>The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. The available values are: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QuoteTypeEnum
        {
            /// <summary>
            /// Enum Price for value: Price
            /// </summary>
            [EnumMember(Value = "Price")]
            Price = 1,

            /// <summary>
            /// Enum Spread for value: Spread
            /// </summary>
            [EnumMember(Value = "Spread")]
            Spread = 2,

            /// <summary>
            /// Enum Rate for value: Rate
            /// </summary>
            [EnumMember(Value = "Rate")]
            Rate = 3,

            /// <summary>
            /// Enum LogNormalVol for value: LogNormalVol
            /// </summary>
            [EnumMember(Value = "LogNormalVol")]
            LogNormalVol = 4,

            /// <summary>
            /// Enum NormalVol for value: NormalVol
            /// </summary>
            [EnumMember(Value = "NormalVol")]
            NormalVol = 5,

            /// <summary>
            /// Enum ParSpread for value: ParSpread
            /// </summary>
            [EnumMember(Value = "ParSpread")]
            ParSpread = 6,

            /// <summary>
            /// Enum IsdaSpread for value: IsdaSpread
            /// </summary>
            [EnumMember(Value = "IsdaSpread")]
            IsdaSpread = 7,

            /// <summary>
            /// Enum Upfront for value: Upfront
            /// </summary>
            [EnumMember(Value = "Upfront")]
            Upfront = 8

        }


        /// <summary>
        /// The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. The available values are: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront
        /// </summary>
        /// <value>The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. The available values are: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront</value>
        [DataMember(Name = "quoteType", IsRequired = true, EmitDefaultValue = true)]
        public QuoteTypeEnum QuoteType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSeriesId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteSeriesId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteSeriesId" /> class.
        /// </summary>
        /// <param name="provider">The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc. (required).</param>
        /// <param name="priceSource">The source or originator of the quote, e.g. a bank or financial institution..</param>
        /// <param name="instrumentId">The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;. (required).</param>
        /// <param name="instrumentIdType">The type of instrument identifier used to uniquely identify the instrument that the quote is for, e.g. &#39;Figi&#39;. The available values are: LusidInstrumentId, Figi, RIC, QuotePermId, Isin, CurrencyPair, ClientInternal (required).</param>
        /// <param name="quoteType">The type of the quote. This allows for quotes other than prices e.g. rates or spreads to be used. The available values are: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront (required).</param>
        /// <param name="field">The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider. (required).</param>
        public QuoteSeriesId(string provider = default(string), string priceSource = default(string), string instrumentId = default(string), InstrumentIdTypeEnum instrumentIdType = default(InstrumentIdTypeEnum), QuoteTypeEnum quoteType = default(QuoteTypeEnum), string field = default(string))
        {
            // to ensure "provider" is required (not null)
            this.Provider = provider ?? throw new ArgumentNullException("provider is a required property for QuoteSeriesId and cannot be null");
            // to ensure "instrumentId" is required (not null)
            this.InstrumentId = instrumentId ?? throw new ArgumentNullException("instrumentId is a required property for QuoteSeriesId and cannot be null");
            this.InstrumentIdType = instrumentIdType;
            this.QuoteType = quoteType;
            // to ensure "field" is required (not null)
            this.Field = field ?? throw new ArgumentNullException("field is a required property for QuoteSeriesId and cannot be null");
            this.PriceSource = priceSource;
        }

        /// <summary>
        /// The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc.
        /// </summary>
        /// <value>The platform or vendor that provided the quote, e.g. &#39;DataScope&#39;, &#39;LUSID&#39; etc.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// The source or originator of the quote, e.g. a bank or financial institution.
        /// </summary>
        /// <value>The source or originator of the quote, e.g. a bank or financial institution.</value>
        [DataMember(Name = "priceSource", EmitDefaultValue = true)]
        public string PriceSource { get; set; }

        /// <summary>
        /// The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;.
        /// </summary>
        /// <value>The value of the instrument identifier that uniquely identifies the instrument that the quote is for, e.g. &#39;BBG00JX0P539&#39;.</value>
        [DataMember(Name = "instrumentId", IsRequired = true, EmitDefaultValue = false)]
        public string InstrumentId { get; set; }

        /// <summary>
        /// The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider.
        /// </summary>
        /// <value>The field of the quote e.g. bid, mid, ask etc. This should be consistent across a time series of quotes. The allowed values are dependant on the specified Provider.</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteSeriesId {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  PriceSource: ").Append(PriceSource).Append("\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  InstrumentIdType: ").Append(InstrumentIdType).Append("\n");
            sb.Append("  QuoteType: ").Append(QuoteType).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as QuoteSeriesId);
        }

        /// <summary>
        /// Returns true if QuoteSeriesId instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteSeriesId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteSeriesId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.PriceSource == input.PriceSource ||
                    (this.PriceSource != null &&
                    this.PriceSource.Equals(input.PriceSource))
                ) && 
                (
                    this.InstrumentId == input.InstrumentId ||
                    (this.InstrumentId != null &&
                    this.InstrumentId.Equals(input.InstrumentId))
                ) && 
                (
                    this.InstrumentIdType == input.InstrumentIdType ||
                    this.InstrumentIdType.Equals(input.InstrumentIdType)
                ) && 
                (
                    this.QuoteType == input.QuoteType ||
                    this.QuoteType.Equals(input.QuoteType)
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.PriceSource != null)
                    hashCode = hashCode * 59 + this.PriceSource.GetHashCode();
                if (this.InstrumentId != null)
                    hashCode = hashCode * 59 + this.InstrumentId.GetHashCode();
                hashCode = hashCode * 59 + this.InstrumentIdType.GetHashCode();
                hashCode = hashCode * 59 + this.QuoteType.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                return hashCode;
            }
        }

    }
}
