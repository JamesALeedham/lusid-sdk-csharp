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
    /// ReferencePortfolioConstituent
    /// </summary>
    [DataContract(Name = "ReferencePortfolioConstituent")]
    public partial class ReferencePortfolioConstituent : IEquatable<ReferencePortfolioConstituent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePortfolioConstituent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReferencePortfolioConstituent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferencePortfolioConstituent" /> class.
        /// </summary>
        /// <param name="instrumentIdentifiers">Unique instrument identifiers.</param>
        /// <param name="instrumentUid">LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers (required).</param>
        /// <param name="currency">currency (required).</param>
        /// <param name="properties">Properties associated with the constituent.</param>
        /// <param name="weight">weight (required).</param>
        /// <param name="floatingWeight">floatingWeight.</param>
        public ReferencePortfolioConstituent(Dictionary<string, string> instrumentIdentifiers = default(Dictionary<string, string>), string instrumentUid = default(string), string currency = default(string), Dictionary<string, PerpetualProperty> properties = default(Dictionary<string, PerpetualProperty>), decimal weight = default(decimal), decimal? floatingWeight = default(decimal?))
        {
            // to ensure "instrumentUid" is required (not null)
            this.InstrumentUid = instrumentUid ?? throw new ArgumentNullException("instrumentUid is a required property for ReferencePortfolioConstituent and cannot be null");
            // to ensure "currency" is required (not null)
            this.Currency = currency ?? throw new ArgumentNullException("currency is a required property for ReferencePortfolioConstituent and cannot be null");
            this.Weight = weight;
            this.InstrumentIdentifiers = instrumentIdentifiers;
            this.Properties = properties;
            this.FloatingWeight = floatingWeight;
        }

        /// <summary>
        /// Unique instrument identifiers
        /// </summary>
        /// <value>Unique instrument identifiers</value>
        [DataMember(Name = "instrumentIdentifiers", EmitDefaultValue = true)]
        public Dictionary<string, string> InstrumentIdentifiers { get; set; }

        /// <summary>
        /// LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers
        /// </summary>
        /// <value>LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers</value>
        [DataMember(Name = "instrumentUid", IsRequired = true, EmitDefaultValue = false)]
        public string InstrumentUid { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Properties associated with the constituent
        /// </summary>
        /// <value>Properties associated with the constituent</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, PerpetualProperty> Properties { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or Sets FloatingWeight
        /// </summary>
        [DataMember(Name = "floatingWeight", EmitDefaultValue = true)]
        public decimal? FloatingWeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferencePortfolioConstituent {\n");
            sb.Append("  InstrumentIdentifiers: ").Append(InstrumentIdentifiers).Append("\n");
            sb.Append("  InstrumentUid: ").Append(InstrumentUid).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  FloatingWeight: ").Append(FloatingWeight).Append("\n");
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
            return this.Equals(input as ReferencePortfolioConstituent);
        }

        /// <summary>
        /// Returns true if ReferencePortfolioConstituent instances are equal
        /// </summary>
        /// <param name="input">Instance of ReferencePortfolioConstituent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferencePortfolioConstituent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstrumentIdentifiers == input.InstrumentIdentifiers ||
                    this.InstrumentIdentifiers != null &&
                    input.InstrumentIdentifiers != null &&
                    this.InstrumentIdentifiers.SequenceEqual(input.InstrumentIdentifiers)
                ) && 
                (
                    this.InstrumentUid == input.InstrumentUid ||
                    (this.InstrumentUid != null &&
                    this.InstrumentUid.Equals(input.InstrumentUid))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.FloatingWeight == input.FloatingWeight ||
                    (this.FloatingWeight != null &&
                    this.FloatingWeight.Equals(input.FloatingWeight))
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
                if (this.InstrumentIdentifiers != null)
                    hashCode = hashCode * 59 + this.InstrumentIdentifiers.GetHashCode();
                if (this.InstrumentUid != null)
                    hashCode = hashCode * 59 + this.InstrumentUid.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.FloatingWeight != null)
                    hashCode = hashCode * 59 + this.FloatingWeight.GetHashCode();
                return hashCode;
            }
        }

    }
}
