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
    /// ActionId
    /// </summary>
    [DataContract(Name = "ActionId")]
    public partial class ActionId : IEquatable<ActionId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionId" /> class.
        /// </summary>
        /// <param name="scope">scope (required).</param>
        /// <param name="activity">activity (required).</param>
        /// <param name="entity">entity (required).</param>
        public ActionId(string scope = default(string), string activity = default(string), string entity = default(string))
        {
            // to ensure "scope" is required (not null)
            this.Scope = scope ?? throw new ArgumentNullException("scope is a required property for ActionId and cannot be null");
            // to ensure "activity" is required (not null)
            this.Activity = activity ?? throw new ArgumentNullException("activity is a required property for ActionId and cannot be null");
            // to ensure "entity" is required (not null)
            this.Entity = entity ?? throw new ArgumentNullException("entity is a required property for ActionId and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]
        public string Scope { get; set; }

        /// <summary>
        /// Gets or Sets Activity
        /// </summary>
        [DataMember(Name = "activity", IsRequired = true, EmitDefaultValue = false)]
        public string Activity { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", IsRequired = true, EmitDefaultValue = false)]
        public string Entity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionId {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Activity: ").Append(Activity).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
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
            return this.Equals(input as ActionId);
        }

        /// <summary>
        /// Returns true if ActionId instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Activity == input.Activity ||
                    (this.Activity != null &&
                    this.Activity.Equals(input.Activity))
                ) && 
                (
                    this.Entity == input.Entity ||
                    (this.Entity != null &&
                    this.Entity.Equals(input.Entity))
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
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Activity != null)
                    hashCode = hashCode * 59 + this.Activity.GetHashCode();
                if (this.Entity != null)
                    hashCode = hashCode * 59 + this.Entity.GetHashCode();
                return hashCode;
            }
        }

    }
}
