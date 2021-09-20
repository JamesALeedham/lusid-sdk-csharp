/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3514
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
    /// A paginated list of resource that can be returned from a request.
    /// </summary>
    [DataContract(Name = "PagedResourceListOfOrder")]
    public partial class PagedResourceListOfOrder : IEquatable<PagedResourceListOfOrder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResourceListOfOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PagedResourceListOfOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResourceListOfOrder" /> class.
        /// </summary>
        /// <param name="nextPage">The next page of results..</param>
        /// <param name="previousPage">The previous page of results..</param>
        /// <param name="values">The resources to list. (required).</param>
        /// <param name="href">The URI of the resource list..</param>
        /// <param name="links">Collection of links..</param>
        public PagedResourceListOfOrder(string nextPage = default(string), string previousPage = default(string), List<Order> values = default(List<Order>), string href = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "values" is required (not null)
            this.Values = values ?? throw new ArgumentNullException("values is a required property for PagedResourceListOfOrder and cannot be null");
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
            this.Href = href;
            this.Links = links;
        }

        /// <summary>
        /// The next page of results.
        /// </summary>
        /// <value>The next page of results.</value>
        [DataMember(Name = "nextPage", EmitDefaultValue = true)]
        public string NextPage { get; set; }

        /// <summary>
        /// The previous page of results.
        /// </summary>
        /// <value>The previous page of results.</value>
        [DataMember(Name = "previousPage", EmitDefaultValue = true)]
        public string PreviousPage { get; set; }

        /// <summary>
        /// The resources to list.
        /// </summary>
        /// <value>The resources to list.</value>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = false)]
        public List<Order> Values { get; set; }

        /// <summary>
        /// The URI of the resource list.
        /// </summary>
        /// <value>The URI of the resource list.</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

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
            sb.Append("class PagedResourceListOfOrder {\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(input as PagedResourceListOfOrder);
        }

        /// <summary>
        /// Returns true if PagedResourceListOfOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of PagedResourceListOfOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PagedResourceListOfOrder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PreviousPage == input.PreviousPage ||
                    (this.PreviousPage != null &&
                    this.PreviousPage.Equals(input.PreviousPage))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PreviousPage != null)
                    hashCode = hashCode * 59 + this.PreviousPage.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
