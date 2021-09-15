/*
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3492
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
    /// TransactionQueryParameters
    /// </summary>
    [DataContract(Name = "TransactionQueryParameters")]
    public partial class TransactionQueryParameters : IEquatable<TransactionQueryParameters>
    {
        /// <summary>
        /// The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate
        /// </summary>
        /// <value>The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum QueryModeEnum
        {
            /// <summary>
            /// Enum TradeDate for value: TradeDate
            /// </summary>
            [EnumMember(Value = "TradeDate")]
            TradeDate = 1,

            /// <summary>
            /// Enum SettleDate for value: SettleDate
            /// </summary>
            [EnumMember(Value = "SettleDate")]
            SettleDate = 2

        }


        /// <summary>
        /// The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate
        /// </summary>
        /// <value>The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate</value>
        [DataMember(Name = "queryMode", EmitDefaultValue = false)]
        public QueryModeEnum? QueryMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueryParameters" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionQueryParameters() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionQueryParameters" /> class.
        /// </summary>
        /// <param name="startDate">The lower bound effective datetime or cut label (inclusive) from which to build the transactions. (required).</param>
        /// <param name="endDate">The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions. (required).</param>
        /// <param name="queryMode">The date to compare against the upper and lower bounds for the effective datetime or cut label. Defaults to &#39;TradeDate&#39; if not specified. The available values are: TradeDate, SettleDate.</param>
        /// <param name="showCancelledTransactions">Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified..</param>
        public TransactionQueryParameters(DateTimeOrCutLabel startDate = default(DateTimeOrCutLabel), DateTimeOrCutLabel endDate = default(DateTimeOrCutLabel), QueryModeEnum? queryMode = default(QueryModeEnum?), bool showCancelledTransactions = default(bool))
        {
            // to ensure "startDate" is required (not null)
            this.StartDate = startDate ?? throw new ArgumentNullException("startDate is a required property for TransactionQueryParameters and cannot be null");
            // to ensure "endDate" is required (not null)
            this.EndDate = endDate ?? throw new ArgumentNullException("endDate is a required property for TransactionQueryParameters and cannot be null");
            this.QueryMode = queryMode;
            this.ShowCancelledTransactions = showCancelledTransactions;
        }

        /// <summary>
        /// The lower bound effective datetime or cut label (inclusive) from which to build the transactions.
        /// </summary>
        /// <value>The lower bound effective datetime or cut label (inclusive) from which to build the transactions.</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOrCutLabel StartDate { get; set; }

        /// <summary>
        /// The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.
        /// </summary>
        /// <value>The upper bound effective datetime or cut label (inclusive) from which to retrieve transactions.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOrCutLabel EndDate { get; set; }

        /// <summary>
        /// Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified.
        /// </summary>
        /// <value>Option to specify whether or not to include cancelled transactions in the output. Defaults to False if not specified.</value>
        [DataMember(Name = "showCancelledTransactions", EmitDefaultValue = true)]
        public bool ShowCancelledTransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionQueryParameters {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  QueryMode: ").Append(QueryMode).Append("\n");
            sb.Append("  ShowCancelledTransactions: ").Append(ShowCancelledTransactions).Append("\n");
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
            return this.Equals(input as TransactionQueryParameters);
        }

        /// <summary>
        /// Returns true if TransactionQueryParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionQueryParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionQueryParameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.QueryMode == input.QueryMode ||
                    this.QueryMode.Equals(input.QueryMode)
                ) && 
                (
                    this.ShowCancelledTransactions == input.ShowCancelledTransactions ||
                    this.ShowCancelledTransactions.Equals(input.ShowCancelledTransactions)
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.QueryMode.GetHashCode();
                hashCode = hashCode * 59 + this.ShowCancelledTransactions.GetHashCode();
                return hashCode;
            }
        }

    }
}
