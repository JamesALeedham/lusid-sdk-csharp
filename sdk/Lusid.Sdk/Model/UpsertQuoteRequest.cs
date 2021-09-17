/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3508
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
    /// The details of the quote including its unique identifier, value and lineage.
    /// </summary>
    [DataContract(Name = "UpsertQuoteRequest")]
    public partial class UpsertQuoteRequest : IEquatable<UpsertQuoteRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertQuoteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertQuoteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertQuoteRequest" /> class.
        /// </summary>
        /// <param name="quoteId">quoteId (required).</param>
        /// <param name="metricValue">metricValue.</param>
        /// <param name="lineage">Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;..</param>
        /// <param name="scaleFactor">An optional scale factor for non-standard scaling of quotes against the instrument. If not supplied, the default ScaleFactor is 1..</param>
        public UpsertQuoteRequest(QuoteId quoteId = default(QuoteId), MetricValue metricValue = default(MetricValue), string lineage = default(string), decimal? scaleFactor = default(decimal?))
        {
            // to ensure "quoteId" is required (not null)
            this.QuoteId = quoteId ?? throw new ArgumentNullException("quoteId is a required property for UpsertQuoteRequest and cannot be null");
            this.MetricValue = metricValue;
            this.Lineage = lineage;
            this.ScaleFactor = scaleFactor;
        }

        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name = "quoteId", IsRequired = true, EmitDefaultValue = false)]
        public QuoteId QuoteId { get; set; }

        /// <summary>
        /// Gets or Sets MetricValue
        /// </summary>
        [DataMember(Name = "metricValue", EmitDefaultValue = false)]
        public MetricValue MetricValue { get; set; }

        /// <summary>
        /// Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.
        /// </summary>
        /// <value>Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;.</value>
        [DataMember(Name = "lineage", EmitDefaultValue = true)]
        public string Lineage { get; set; }

        /// <summary>
        /// An optional scale factor for non-standard scaling of quotes against the instrument. If not supplied, the default ScaleFactor is 1.
        /// </summary>
        /// <value>An optional scale factor for non-standard scaling of quotes against the instrument. If not supplied, the default ScaleFactor is 1.</value>
        [DataMember(Name = "scaleFactor", EmitDefaultValue = true)]
        public decimal? ScaleFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertQuoteRequest {\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
            sb.Append("  MetricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  Lineage: ").Append(Lineage).Append("\n");
            sb.Append("  ScaleFactor: ").Append(ScaleFactor).Append("\n");
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
            return this.Equals(input as UpsertQuoteRequest);
        }

        /// <summary>
        /// Returns true if UpsertQuoteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertQuoteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertQuoteRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteId == input.QuoteId ||
                    (this.QuoteId != null &&
                    this.QuoteId.Equals(input.QuoteId))
                ) && 
                (
                    this.MetricValue == input.MetricValue ||
                    (this.MetricValue != null &&
                    this.MetricValue.Equals(input.MetricValue))
                ) && 
                (
                    this.Lineage == input.Lineage ||
                    (this.Lineage != null &&
                    this.Lineage.Equals(input.Lineage))
                ) && 
                (
                    this.ScaleFactor == input.ScaleFactor ||
                    (this.ScaleFactor != null &&
                    this.ScaleFactor.Equals(input.ScaleFactor))
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
                if (this.QuoteId != null)
                    hashCode = hashCode * 59 + this.QuoteId.GetHashCode();
                if (this.MetricValue != null)
                    hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                if (this.Lineage != null)
                    hashCode = hashCode * 59 + this.Lineage.GetHashCode();
                if (this.ScaleFactor != null)
                    hashCode = hashCode * 59 + this.ScaleFactor.GetHashCode();
                return hashCode;
            }
        }

    }
}
