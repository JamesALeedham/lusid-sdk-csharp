/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3438
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
    /// PortfolioGroupSearchResult
    /// </summary>
    [DataContract(Name = "PortfolioGroupSearchResult")]
    public partial class PortfolioGroupSearchResult : IEquatable<PortfolioGroupSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupSearchResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PortfolioGroupSearchResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioGroupSearchResult" /> class.
        /// </summary>
        /// <param name="href">The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime..</param>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">The name of the portfolio group. (required).</param>
        /// <param name="description">The long form description of the portfolio group..</param>
        /// <param name="created">The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date..</param>
        /// <param name="portfolios">The collection of resource identifiers for the portfolios contained in the portfolio group..</param>
        /// <param name="subGroups">The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups..</param>
        /// <param name="version">version.</param>
        /// <param name="links">Collection of links..</param>
        public PortfolioGroupSearchResult(string href = default(string), ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), DateTimeOffset created = default(DateTimeOffset), List<ResourceId> portfolios = default(List<ResourceId>), List<ResourceId> subGroups = default(List<ResourceId>), Version version = default(Version), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for PortfolioGroupSearchResult and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for PortfolioGroupSearchResult and cannot be null");
            this.Href = href;
            this.Description = description;
            this.Created = created;
            this.Portfolios = portfolios;
            this.SubGroups = subGroups;
            this.Version = version;
            this.Links = links;
        }

        /// <summary>
        /// The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.
        /// </summary>
        /// <value>The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// The name of the portfolio group.
        /// </summary>
        /// <value>The name of the portfolio group.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The long form description of the portfolio group.
        /// </summary>
        /// <value>The long form description of the portfolio group.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date.
        /// </summary>
        /// <value>The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date.</value>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTimeOffset Created { get; set; }

        /// <summary>
        /// The collection of resource identifiers for the portfolios contained in the portfolio group.
        /// </summary>
        /// <value>The collection of resource identifiers for the portfolios contained in the portfolio group.</value>
        [DataMember(Name = "portfolios", EmitDefaultValue = true)]
        public List<ResourceId> Portfolios { get; set; }

        /// <summary>
        /// The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups.
        /// </summary>
        /// <value>The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups.</value>
        [DataMember(Name = "subGroups", EmitDefaultValue = true)]
        public List<ResourceId> SubGroups { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

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
            sb.Append("class PortfolioGroupSearchResult {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Portfolios: ").Append(Portfolios).Append("\n");
            sb.Append("  SubGroups: ").Append(SubGroups).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PortfolioGroupSearchResult);
        }

        /// <summary>
        /// Returns true if PortfolioGroupSearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of PortfolioGroupSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortfolioGroupSearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Portfolios == input.Portfolios ||
                    this.Portfolios != null &&
                    input.Portfolios != null &&
                    this.Portfolios.SequenceEqual(input.Portfolios)
                ) && 
                (
                    this.SubGroups == input.SubGroups ||
                    this.SubGroups != null &&
                    input.SubGroups != null &&
                    this.SubGroups.SequenceEqual(input.SubGroups)
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Portfolios != null)
                    hashCode = hashCode * 59 + this.Portfolios.GetHashCode();
                if (this.SubGroups != null)
                    hashCode = hashCode * 59 + this.SubGroups.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
