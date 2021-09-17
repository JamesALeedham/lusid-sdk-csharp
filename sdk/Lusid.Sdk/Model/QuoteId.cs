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
    /// The unique identifier of the quote.
    /// </summary>
    [DataContract(Name = "QuoteId")]
    public partial class QuoteId : IEquatable<QuoteId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuoteId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteId" /> class.
        /// </summary>
        /// <param name="quoteSeriesId">quoteSeriesId (required).</param>
        /// <param name="effectiveAt">The effective datetime or cut label at which the quote is valid from. (required).</param>
        public QuoteId(QuoteSeriesId quoteSeriesId = default(QuoteSeriesId), DateTimeOrCutLabel effectiveAt = default(DateTimeOrCutLabel))
        {
            // to ensure "quoteSeriesId" is required (not null)
            this.QuoteSeriesId = quoteSeriesId ?? throw new ArgumentNullException("quoteSeriesId is a required property for QuoteId and cannot be null");
            // to ensure "effectiveAt" is required (not null)
            this.EffectiveAt = effectiveAt ?? throw new ArgumentNullException("effectiveAt is a required property for QuoteId and cannot be null");
        }

        /// <summary>
        /// Gets or Sets QuoteSeriesId
        /// </summary>
        [DataMember(Name = "quoteSeriesId", IsRequired = true, EmitDefaultValue = false)]
        public QuoteSeriesId QuoteSeriesId { get; set; }

        /// <summary>
        /// The effective datetime or cut label at which the quote is valid from.
        /// </summary>
        /// <value>The effective datetime or cut label at which the quote is valid from.</value>
        [DataMember(Name = "effectiveAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOrCutLabel EffectiveAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuoteId {\n");
            sb.Append("  QuoteSeriesId: ").Append(QuoteSeriesId).Append("\n");
            sb.Append("  EffectiveAt: ").Append(EffectiveAt).Append("\n");
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
            return this.Equals(input as QuoteId);
        }

        /// <summary>
        /// Returns true if QuoteId instances are equal
        /// </summary>
        /// <param name="input">Instance of QuoteId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuoteId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuoteSeriesId == input.QuoteSeriesId ||
                    (this.QuoteSeriesId != null &&
                    this.QuoteSeriesId.Equals(input.QuoteSeriesId))
                ) && 
                (
                    this.EffectiveAt == input.EffectiveAt ||
                    (this.EffectiveAt != null &&
                    this.EffectiveAt.Equals(input.EffectiveAt))
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
                if (this.QuoteSeriesId != null)
                    hashCode = hashCode * 59 + this.QuoteSeriesId.GetHashCode();
                if (this.EffectiveAt != null)
                    hashCode = hashCode * 59 + this.EffectiveAt.GetHashCode();
                return hashCode;
            }
        }

    }
}
