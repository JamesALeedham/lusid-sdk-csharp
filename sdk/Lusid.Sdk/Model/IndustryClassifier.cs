/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3500
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
    /// Object describing a particular industry classifier,  which comprises a classification code and the name of the classification system to which the code belongs.
    /// </summary>
    [DataContract(Name = "IndustryClassifier")]
    public partial class IndustryClassifier : IEquatable<IndustryClassifier>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryClassifier" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IndustryClassifier() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryClassifier" /> class.
        /// </summary>
        /// <param name="classificationSystemName">The name of the classification system to which the classification code belongs (e.g. GICS). (required).</param>
        /// <param name="classificationCode">The specific industry classification code assigned to the legal entity. (required).</param>
        public IndustryClassifier(string classificationSystemName = default(string), string classificationCode = default(string))
        {
            // to ensure "classificationSystemName" is required (not null)
            this.ClassificationSystemName = classificationSystemName ?? throw new ArgumentNullException("classificationSystemName is a required property for IndustryClassifier and cannot be null");
            // to ensure "classificationCode" is required (not null)
            this.ClassificationCode = classificationCode ?? throw new ArgumentNullException("classificationCode is a required property for IndustryClassifier and cannot be null");
        }

        /// <summary>
        /// The name of the classification system to which the classification code belongs (e.g. GICS).
        /// </summary>
        /// <value>The name of the classification system to which the classification code belongs (e.g. GICS).</value>
        [DataMember(Name = "classificationSystemName", IsRequired = true, EmitDefaultValue = false)]
        public string ClassificationSystemName { get; set; }

        /// <summary>
        /// The specific industry classification code assigned to the legal entity.
        /// </summary>
        /// <value>The specific industry classification code assigned to the legal entity.</value>
        [DataMember(Name = "classificationCode", IsRequired = true, EmitDefaultValue = false)]
        public string ClassificationCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndustryClassifier {\n");
            sb.Append("  ClassificationSystemName: ").Append(ClassificationSystemName).Append("\n");
            sb.Append("  ClassificationCode: ").Append(ClassificationCode).Append("\n");
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
            return this.Equals(input as IndustryClassifier);
        }

        /// <summary>
        /// Returns true if IndustryClassifier instances are equal
        /// </summary>
        /// <param name="input">Instance of IndustryClassifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndustryClassifier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassificationSystemName == input.ClassificationSystemName ||
                    (this.ClassificationSystemName != null &&
                    this.ClassificationSystemName.Equals(input.ClassificationSystemName))
                ) && 
                (
                    this.ClassificationCode == input.ClassificationCode ||
                    (this.ClassificationCode != null &&
                    this.ClassificationCode.Equals(input.ClassificationCode))
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
                if (this.ClassificationSystemName != null)
                    hashCode = hashCode * 59 + this.ClassificationSystemName.GetHashCode();
                if (this.ClassificationCode != null)
                    hashCode = hashCode * 59 + this.ClassificationCode.GetHashCode();
                return hashCode;
            }
        }

    }
}
