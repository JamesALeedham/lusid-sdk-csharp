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
    /// The value of the property.
    /// </summary>
    [DataContract(Name = "PropertyValue")]
    public partial class PropertyValue : IEquatable<PropertyValue>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyValue" /> class.
        /// </summary>
        /// <param name="labelValue">The text value of a property defined as having the &#39;Label&#39; type..</param>
        /// <param name="metricValue">metricValue.</param>
        /// <param name="labelValueSet">labelValueSet.</param>
        public PropertyValue(string labelValue = default(string), MetricValue metricValue = default(MetricValue), LabelValueSet labelValueSet = default(LabelValueSet))
        {
            this.LabelValue = labelValue;
            this.MetricValue = metricValue;
            this.LabelValueSet = labelValueSet;
        }

        /// <summary>
        /// The text value of a property defined as having the &#39;Label&#39; type.
        /// </summary>
        /// <value>The text value of a property defined as having the &#39;Label&#39; type.</value>
        [DataMember(Name = "labelValue", EmitDefaultValue = true)]
        public string LabelValue { get; set; }

        /// <summary>
        /// Gets or Sets MetricValue
        /// </summary>
        [DataMember(Name = "metricValue", EmitDefaultValue = false)]
        public MetricValue MetricValue { get; set; }

        /// <summary>
        /// Gets or Sets LabelValueSet
        /// </summary>
        [DataMember(Name = "labelValueSet", EmitDefaultValue = false)]
        public LabelValueSet LabelValueSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyValue {\n");
            sb.Append("  LabelValue: ").Append(LabelValue).Append("\n");
            sb.Append("  MetricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  LabelValueSet: ").Append(LabelValueSet).Append("\n");
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
            return this.Equals(input as PropertyValue);
        }

        /// <summary>
        /// Returns true if PropertyValue instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LabelValue == input.LabelValue ||
                    (this.LabelValue != null &&
                    this.LabelValue.Equals(input.LabelValue))
                ) && 
                (
                    this.MetricValue == input.MetricValue ||
                    (this.MetricValue != null &&
                    this.MetricValue.Equals(input.MetricValue))
                ) && 
                (
                    this.LabelValueSet == input.LabelValueSet ||
                    (this.LabelValueSet != null &&
                    this.LabelValueSet.Equals(input.LabelValueSet))
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
                if (this.LabelValue != null)
                    hashCode = hashCode * 59 + this.LabelValue.GetHashCode();
                if (this.MetricValue != null)
                    hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                if (this.LabelValueSet != null)
                    hashCode = hashCode * 59 + this.LabelValueSet.GetHashCode();
                return hashCode;
            }
        }

    }
}
