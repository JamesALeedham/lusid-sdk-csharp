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
    /// A resource to which access can be controlled
    /// </summary>
    [DataContract(Name = "AccessControlledResource")]
    public partial class AccessControlledResource : IEquatable<AccessControlledResource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessControlledResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlledResource" /> class.
        /// </summary>
        /// <param name="application">The application to which this resource belongs.</param>
        /// <param name="name">The display name of the resource.</param>
        /// <param name="description">The description of the resource (required).</param>
        /// <param name="actions">The actions acceptable for this type of resource (required).</param>
        /// <param name="identifierParts">The constituent parts of a valid identifier for this resource.</param>
        /// <param name="links">Collection of links..</param>
        public AccessControlledResource(string application = default(string), string name = default(string), string description = default(string), List<AccessControlledAction> actions = default(List<AccessControlledAction>), List<IdentifierPartSchema> identifierParts = default(List<IdentifierPartSchema>), List<Link> links = default(List<Link>))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for AccessControlledResource and cannot be null");
            // to ensure "actions" is required (not null)
            this.Actions = actions ?? throw new ArgumentNullException("actions is a required property for AccessControlledResource and cannot be null");
            this.Application = application;
            this.Name = name;
            this.IdentifierParts = identifierParts;
            this.Links = links;
        }

        /// <summary>
        /// The application to which this resource belongs
        /// </summary>
        /// <value>The application to which this resource belongs</value>
        [DataMember(Name = "application", EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// The display name of the resource
        /// </summary>
        /// <value>The display name of the resource</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the resource
        /// </summary>
        /// <value>The description of the resource</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The actions acceptable for this type of resource
        /// </summary>
        /// <value>The actions acceptable for this type of resource</value>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = false)]
        public List<AccessControlledAction> Actions { get; set; }

        /// <summary>
        /// The constituent parts of a valid identifier for this resource
        /// </summary>
        /// <value>The constituent parts of a valid identifier for this resource</value>
        [DataMember(Name = "identifierParts", EmitDefaultValue = true)]
        public List<IdentifierPartSchema> IdentifierParts { get; set; }

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
            sb.Append("class AccessControlledResource {\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  IdentifierParts: ").Append(IdentifierParts).Append("\n");
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
            return this.Equals(input as AccessControlledResource);
        }

        /// <summary>
        /// Returns true if AccessControlledResource instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessControlledResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessControlledResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.IdentifierParts == input.IdentifierParts ||
                    this.IdentifierParts != null &&
                    input.IdentifierParts != null &&
                    this.IdentifierParts.SequenceEqual(input.IdentifierParts)
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
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Actions != null)
                    hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.IdentifierParts != null)
                    hashCode = hashCode * 59 + this.IdentifierParts.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
