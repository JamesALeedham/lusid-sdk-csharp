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
    /// Request to create or update an legal entity
    /// </summary>
    [DataContract(Name = "UpsertLegalEntityRequest")]
    public partial class UpsertLegalEntityRequest : IEquatable<UpsertLegalEntityRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertLegalEntityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertLegalEntityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertLegalEntityRequest" /> class.
        /// </summary>
        /// <param name="identifiers">The identifiers the legal entity will be upserted with.The provided keys should be idTypeScope, idTypeCode, code (required).</param>
        /// <param name="properties">A set of properties associated to the Legal Entity..</param>
        /// <param name="displayName">The display name of the Legal Entity (required).</param>
        /// <param name="description">The description of the Legal Entity.</param>
        /// <param name="counterpartyRiskInformation">counterpartyRiskInformation.</param>
        public UpsertLegalEntityRequest(Dictionary<string, Property> identifiers = default(Dictionary<string, Property>), Dictionary<string, Property> properties = default(Dictionary<string, Property>), string displayName = default(string), string description = default(string), CounterpartyRiskInformation counterpartyRiskInformation = default(CounterpartyRiskInformation))
        {
            // to ensure "identifiers" is required (not null)
            this.Identifiers = identifiers ?? throw new ArgumentNullException("identifiers is a required property for UpsertLegalEntityRequest and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for UpsertLegalEntityRequest and cannot be null");
            this.Properties = properties;
            this.Description = description;
            this.CounterpartyRiskInformation = counterpartyRiskInformation;
        }

        /// <summary>
        /// The identifiers the legal entity will be upserted with.The provided keys should be idTypeScope, idTypeCode, code
        /// </summary>
        /// <value>The identifiers the legal entity will be upserted with.The provided keys should be idTypeScope, idTypeCode, code</value>
        [DataMember(Name = "identifiers", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Property> Identifiers { get; set; }

        /// <summary>
        /// A set of properties associated to the Legal Entity.
        /// </summary>
        /// <value>A set of properties associated to the Legal Entity.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// The display name of the Legal Entity
        /// </summary>
        /// <value>The display name of the Legal Entity</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The description of the Legal Entity
        /// </summary>
        /// <value>The description of the Legal Entity</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets CounterpartyRiskInformation
        /// </summary>
        [DataMember(Name = "counterpartyRiskInformation", EmitDefaultValue = false)]
        public CounterpartyRiskInformation CounterpartyRiskInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertLegalEntityRequest {\n");
            sb.Append("  Identifiers: ").Append(Identifiers).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CounterpartyRiskInformation: ").Append(CounterpartyRiskInformation).Append("\n");
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
            return this.Equals(input as UpsertLegalEntityRequest);
        }

        /// <summary>
        /// Returns true if UpsertLegalEntityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpsertLegalEntityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertLegalEntityRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifiers == input.Identifiers ||
                    this.Identifiers != null &&
                    input.Identifiers != null &&
                    this.Identifiers.SequenceEqual(input.Identifiers)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CounterpartyRiskInformation == input.CounterpartyRiskInformation ||
                    (this.CounterpartyRiskInformation != null &&
                    this.CounterpartyRiskInformation.Equals(input.CounterpartyRiskInformation))
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
                if (this.Identifiers != null)
                    hashCode = hashCode * 59 + this.Identifiers.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CounterpartyRiskInformation != null)
                    hashCode = hashCode * 59 + this.CounterpartyRiskInformation.GetHashCode();
                return hashCode;
            }
        }

    }
}
