/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3502
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
    /// UpsertInstrumentPropertyRequest
    /// </summary>
    [DataContract(Name = "UpsertInstrumentPropertyRequest")]
    public partial class UpsertInstrumentPropertyRequest : IEquatable<UpsertInstrumentPropertyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertInstrumentPropertyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertInstrumentPropertyRequest" /> class.
        /// </summary>
        /// <param name="identifierType">The unique identifier type to search for the instrument, for example &#39;Figi&#39;. (required).</param>
        /// <param name="identifier">A value of that type to identify the instrument to upsert properties for, for example &#39;BBG000BLNNV0&#39;. (required).</param>
        /// <param name="properties">A set of instrument properties and associated values to store for the instrument. Each property must be from the &#39;Instrument&#39; domain..</param>
        public UpsertInstrumentPropertyRequest(string identifierType = default(string), string identifier = default(string), List<Property> properties = default(List<Property>))
        {
            // to ensure "identifierType" is required (not null)
            this.IdentifierType = identifierType ?? throw new ArgumentNullException("identifierType is a required property for UpsertInstrumentPropertyRequest and cannot be null");
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for UpsertInstrumentPropertyRequest and cannot be null");
            this.Properties = properties;
        }

        /// <summary>
        /// The unique identifier type to search for the instrument, for example &#39;Figi&#39;.
        /// </summary>
        /// <value>The unique identifier type to search for the instrument, for example &#39;Figi&#39;.</value>
        [DataMember(Name = "identifierType", IsRequired = true, EmitDefaultValue = false)]
        public string IdentifierType { get; set; }

        /// <summary>
        /// A value of that type to identify the instrument to upsert properties for, for example &#39;BBG000BLNNV0&#39;.
        /// </summary>
        /// <value>A value of that type to identify the instrument to upsert properties for, for example &#39;BBG000BLNNV0&#39;.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; }

        /// <summary>
        /// A set of instrument properties and associated values to store for the instrument. Each property must be from the &#39;Instrument&#39; domain.
        /// </summary>
        /// <value>A set of instrument properties and associated values to store for the instrument. Each property must be from the &#39;Instrument&#39; domain.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public List<Property> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertInstrumentPropertyRequest {\n");
            sb.Append("  IdentifierType: ").Append(IdentifierType).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as UpsertInstrumentPropertyRequest);
        }

        /// <summary>
        /// Returns true if UpsertInstrumentPropertyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertInstrumentPropertyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertInstrumentPropertyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentifierType == input.IdentifierType ||
                    (this.IdentifierType != null &&
                    this.IdentifierType.Equals(input.IdentifierType))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.IdentifierType != null)
                    hashCode = hashCode * 59 + this.IdentifierType.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }

    }
}
