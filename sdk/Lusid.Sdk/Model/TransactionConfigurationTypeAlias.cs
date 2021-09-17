/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3507
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
    /// TransactionConfigurationTypeAlias
    /// </summary>
    [DataContract(Name = "TransactionConfigurationTypeAlias")]
    public partial class TransactionConfigurationTypeAlias : IEquatable<TransactionConfigurationTypeAlias>
    {
        /// <summary>
        /// . The available values are: None, LongLonger, LongShorter, ShortShorter, Shorter, ShortLonger, Longer, AllRoles
        /// </summary>
        /// <value>. The available values are: None, LongLonger, LongShorter, ShortShorter, Shorter, ShortLonger, Longer, AllRoles</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransactionRolesEnum
        {
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 1,

            /// <summary>
            /// Enum LongLonger for value: LongLonger
            /// </summary>
            [EnumMember(Value = "LongLonger")]
            LongLonger = 2,

            /// <summary>
            /// Enum LongShorter for value: LongShorter
            /// </summary>
            [EnumMember(Value = "LongShorter")]
            LongShorter = 3,

            /// <summary>
            /// Enum ShortShorter for value: ShortShorter
            /// </summary>
            [EnumMember(Value = "ShortShorter")]
            ShortShorter = 4,

            /// <summary>
            /// Enum Shorter for value: Shorter
            /// </summary>
            [EnumMember(Value = "Shorter")]
            Shorter = 5,

            /// <summary>
            /// Enum ShortLonger for value: ShortLonger
            /// </summary>
            [EnumMember(Value = "ShortLonger")]
            ShortLonger = 6,

            /// <summary>
            /// Enum Longer for value: Longer
            /// </summary>
            [EnumMember(Value = "Longer")]
            Longer = 7,

            /// <summary>
            /// Enum AllRoles for value: AllRoles
            /// </summary>
            [EnumMember(Value = "AllRoles")]
            AllRoles = 8

        }


        /// <summary>
        /// . The available values are: None, LongLonger, LongShorter, ShortShorter, Shorter, ShortLonger, Longer, AllRoles
        /// </summary>
        /// <value>. The available values are: None, LongLonger, LongShorter, ShortShorter, Shorter, ShortLonger, Longer, AllRoles</value>
        [DataMember(Name = "transactionRoles", IsRequired = true, EmitDefaultValue = false)]
        public TransactionRolesEnum TransactionRoles { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationTypeAlias" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionConfigurationTypeAlias() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionConfigurationTypeAlias" /> class.
        /// </summary>
        /// <param name="type">The transaction type (required).</param>
        /// <param name="description">Brief description of the transaction (required).</param>
        /// <param name="transactionClass">Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut (required).</param>
        /// <param name="transactionGroup">Group is a set of codes related to a source, or sync (required).</param>
        /// <param name="transactionRoles">. The available values are: None, LongLonger, LongShorter, ShortShorter, Shorter, ShortLonger, Longer, AllRoles (required).</param>
        public TransactionConfigurationTypeAlias(string type = default(string), string description = default(string), string transactionClass = default(string), string transactionGroup = default(string), TransactionRolesEnum transactionRoles = default(TransactionRolesEnum))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TransactionConfigurationTypeAlias and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for TransactionConfigurationTypeAlias and cannot be null");
            // to ensure "transactionClass" is required (not null)
            this.TransactionClass = transactionClass ?? throw new ArgumentNullException("transactionClass is a required property for TransactionConfigurationTypeAlias and cannot be null");
            // to ensure "transactionGroup" is required (not null)
            this.TransactionGroup = transactionGroup ?? throw new ArgumentNullException("transactionGroup is a required property for TransactionConfigurationTypeAlias and cannot be null");
            this.TransactionRoles = transactionRoles;
        }

        /// <summary>
        /// The transaction type
        /// </summary>
        /// <value>The transaction type</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Brief description of the transaction
        /// </summary>
        /// <value>Brief description of the transaction</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut
        /// </summary>
        /// <value>Relates types of a similar class. E.g. Buy/Sell, StockIn/StockOut</value>
        [DataMember(Name = "transactionClass", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionClass { get; set; }

        /// <summary>
        /// Group is a set of codes related to a source, or sync
        /// </summary>
        /// <value>Group is a set of codes related to a source, or sync</value>
        [DataMember(Name = "transactionGroup", IsRequired = true, EmitDefaultValue = false)]
        public string TransactionGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionConfigurationTypeAlias {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TransactionClass: ").Append(TransactionClass).Append("\n");
            sb.Append("  TransactionGroup: ").Append(TransactionGroup).Append("\n");
            sb.Append("  TransactionRoles: ").Append(TransactionRoles).Append("\n");
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
            return this.Equals(input as TransactionConfigurationTypeAlias);
        }

        /// <summary>
        /// Returns true if TransactionConfigurationTypeAlias instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionConfigurationTypeAlias to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionConfigurationTypeAlias input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TransactionClass == input.TransactionClass ||
                    (this.TransactionClass != null &&
                    this.TransactionClass.Equals(input.TransactionClass))
                ) && 
                (
                    this.TransactionGroup == input.TransactionGroup ||
                    (this.TransactionGroup != null &&
                    this.TransactionGroup.Equals(input.TransactionGroup))
                ) && 
                (
                    this.TransactionRoles == input.TransactionRoles ||
                    this.TransactionRoles.Equals(input.TransactionRoles)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TransactionClass != null)
                    hashCode = hashCode * 59 + this.TransactionClass.GetHashCode();
                if (this.TransactionGroup != null)
                    hashCode = hashCode * 59 + this.TransactionGroup.GetHashCode();
                hashCode = hashCode * 59 + this.TransactionRoles.GetHashCode();
                return hashCode;
            }
        }

    }
}
