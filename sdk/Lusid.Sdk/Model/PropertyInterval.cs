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
    /// PropertyInterval
    /// </summary>
    [DataContract(Name = "PropertyInterval")]
    public partial class PropertyInterval : IEquatable<PropertyInterval>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyInterval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInterval" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="effectiveRange">effectiveRange (required).</param>
        /// <param name="asAtRange">asAtRange (required).</param>
        /// <param name="status">Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity (required).</param>
        public PropertyInterval(PropertyValue value = default(PropertyValue), DateRange effectiveRange = default(DateRange), DateRange asAtRange = default(DateRange), string status = default(string))
        {
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for PropertyInterval and cannot be null");
            // to ensure "effectiveRange" is required (not null)
            this.EffectiveRange = effectiveRange ?? throw new ArgumentNullException("effectiveRange is a required property for PropertyInterval and cannot be null");
            // to ensure "asAtRange" is required (not null)
            this.AsAtRange = asAtRange ?? throw new ArgumentNullException("asAtRange is a required property for PropertyInterval and cannot be null");
            // to ensure "status" is required (not null)
            this.Status = status ?? throw new ArgumentNullException("status is a required property for PropertyInterval and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public PropertyValue Value { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveRange
        /// </summary>
        [DataMember(Name = "effectiveRange", IsRequired = true, EmitDefaultValue = false)]
        public DateRange EffectiveRange { get; set; }

        /// <summary>
        /// Gets or Sets AsAtRange
        /// </summary>
        [DataMember(Name = "asAtRange", IsRequired = true, EmitDefaultValue = false)]
        public DateRange AsAtRange { get; set; }

        /// <summary>
        /// Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity
        /// </summary>
        /// <value>Indicates whether the value is part of the prevailing effective date timeline for the requested asAt date, or whether it has been superseded by correctional activity</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyInterval {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EffectiveRange: ").Append(EffectiveRange).Append("\n");
            sb.Append("  AsAtRange: ").Append(AsAtRange).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PropertyInterval);
        }

        /// <summary>
        /// Returns true if PropertyInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyInterval input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.EffectiveRange == input.EffectiveRange ||
                    (this.EffectiveRange != null &&
                    this.EffectiveRange.Equals(input.EffectiveRange))
                ) && 
                (
                    this.AsAtRange == input.AsAtRange ||
                    (this.AsAtRange != null &&
                    this.AsAtRange.Equals(input.AsAtRange))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.EffectiveRange != null)
                    hashCode = hashCode * 59 + this.EffectiveRange.GetHashCode();
                if (this.AsAtRange != null)
                    hashCode = hashCode * 59 + this.AsAtRange.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

    }
}
