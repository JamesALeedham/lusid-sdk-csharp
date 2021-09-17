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
    /// CreateTransactionPortfolioRequest
    /// </summary>
    [DataContract(Name = "CreateTransactionPortfolioRequest")]
    public partial class CreateTransactionPortfolioRequest : IEquatable<CreateTransactionPortfolioRequest>
    {
        /// <summary>
        /// Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst
        /// </summary>
        /// <value>Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountingMethodEnum
        {
            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 1,

            /// <summary>
            /// Enum AverageCost for value: AverageCost
            /// </summary>
            [EnumMember(Value = "AverageCost")]
            AverageCost = 2,

            /// <summary>
            /// Enum FirstInFirstOut for value: FirstInFirstOut
            /// </summary>
            [EnumMember(Value = "FirstInFirstOut")]
            FirstInFirstOut = 3,

            /// <summary>
            /// Enum LastInFirstOut for value: LastInFirstOut
            /// </summary>
            [EnumMember(Value = "LastInFirstOut")]
            LastInFirstOut = 4,

            /// <summary>
            /// Enum HighestCostFirst for value: HighestCostFirst
            /// </summary>
            [EnumMember(Value = "HighestCostFirst")]
            HighestCostFirst = 5,

            /// <summary>
            /// Enum LowestCostFirst for value: LowestCostFirst
            /// </summary>
            [EnumMember(Value = "LowestCostFirst")]
            LowestCostFirst = 6

        }


        /// <summary>
        /// Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst
        /// </summary>
        /// <value>Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst</value>
        [DataMember(Name = "accountingMethod", EmitDefaultValue = false)]
        public AccountingMethodEnum? AccountingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionPortfolioRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTransactionPortfolioRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTransactionPortfolioRequest" /> class.
        /// </summary>
        /// <param name="displayName">The name of the transaction portfolio. (required).</param>
        /// <param name="description">A description for the transaction portfolio..</param>
        /// <param name="code">The code of the transaction portfolio. Together with the scope this uniquely identifies the transaction portfolio. (required).</param>
        /// <param name="created">The effective datetime at which to create the transaction portfolio. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified..</param>
        /// <param name="baseCurrency">The base currency of the transaction portfolio in ISO 4217 currency code format. (required).</param>
        /// <param name="corporateActionSourceId">corporateActionSourceId.</param>
        /// <param name="accountingMethod">Determines the accounting treatment given to the transaction portfolio&#39;s tax lots. The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst.</param>
        /// <param name="subHoldingKeys">A set of unique transaction properties to group the transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. Note that sub-holding keys cannot currently be added after the transaction portfolio has been created; see https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information..</param>
        /// <param name="properties">A set of unique portfolio properties to add custom data to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Note these properties must be pre-defined..</param>
        public CreateTransactionPortfolioRequest(string displayName = default(string), string description = default(string), string code = default(string), DateTimeOffset? created = default(DateTimeOffset?), string baseCurrency = default(string), ResourceId corporateActionSourceId = default(ResourceId), AccountingMethodEnum? accountingMethod = default(AccountingMethodEnum?), List<string> subHoldingKeys = default(List<string>), Dictionary<string, Property> properties = default(Dictionary<string, Property>))
        {
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for CreateTransactionPortfolioRequest and cannot be null");
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for CreateTransactionPortfolioRequest and cannot be null");
            // to ensure "baseCurrency" is required (not null)
            this.BaseCurrency = baseCurrency ?? throw new ArgumentNullException("baseCurrency is a required property for CreateTransactionPortfolioRequest and cannot be null");
            this.Description = description;
            this.Created = created;
            this.CorporateActionSourceId = corporateActionSourceId;
            this.AccountingMethod = accountingMethod;
            this.SubHoldingKeys = subHoldingKeys;
            this.Properties = properties;
        }

        /// <summary>
        /// The name of the transaction portfolio.
        /// </summary>
        /// <value>The name of the transaction portfolio.</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// A description for the transaction portfolio.
        /// </summary>
        /// <value>A description for the transaction portfolio.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The code of the transaction portfolio. Together with the scope this uniquely identifies the transaction portfolio.
        /// </summary>
        /// <value>The code of the transaction portfolio. Together with the scope this uniquely identifies the transaction portfolio.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// The effective datetime at which to create the transaction portfolio. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified.
        /// </summary>
        /// <value>The effective datetime at which to create the transaction portfolio. No transactions can be added to the transaction portfolio before this date. Defaults to the current LUSID system datetime if not specified.</value>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The base currency of the transaction portfolio in ISO 4217 currency code format.
        /// </summary>
        /// <value>The base currency of the transaction portfolio in ISO 4217 currency code format.</value>
        [DataMember(Name = "baseCurrency", IsRequired = true, EmitDefaultValue = false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CorporateActionSourceId
        /// </summary>
        [DataMember(Name = "corporateActionSourceId", EmitDefaultValue = false)]
        public ResourceId CorporateActionSourceId { get; set; }

        /// <summary>
        /// A set of unique transaction properties to group the transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. Note that sub-holding keys cannot currently be added after the transaction portfolio has been created; see https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information.
        /// </summary>
        /// <value>A set of unique transaction properties to group the transaction portfolio&#39;s holdings by, perhaps for strategy tagging. Each property must be from the &#39;Transaction&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Transaction/strategies/quantsignal&#39;. Note that sub-holding keys cannot currently be added after the transaction portfolio has been created; see https://support.lusid.com/knowledgebase/article/KA-01879/en-us for more information.</value>
        [DataMember(Name = "subHoldingKeys", EmitDefaultValue = true)]
        public List<string> SubHoldingKeys { get; set; }

        /// <summary>
        /// A set of unique portfolio properties to add custom data to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Note these properties must be pre-defined.
        /// </summary>
        /// <value>A set of unique portfolio properties to add custom data to the transaction portfolio. Each property must be from the &#39;Portfolio&#39; domain and identified by a key in the format {domain}/{scope}/{code}, for example &#39;Portfolio/Manager/Id&#39;. Note these properties must be pre-defined.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, Property> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransactionPortfolioRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  CorporateActionSourceId: ").Append(CorporateActionSourceId).Append("\n");
            sb.Append("  AccountingMethod: ").Append(AccountingMethod).Append("\n");
            sb.Append("  SubHoldingKeys: ").Append(SubHoldingKeys).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as CreateTransactionPortfolioRequest);
        }

        /// <summary>
        /// Returns true if CreateTransactionPortfolioRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTransactionPortfolioRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTransactionPortfolioRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.CorporateActionSourceId == input.CorporateActionSourceId ||
                    (this.CorporateActionSourceId != null &&
                    this.CorporateActionSourceId.Equals(input.CorporateActionSourceId))
                ) && 
                (
                    this.AccountingMethod == input.AccountingMethod ||
                    this.AccountingMethod.Equals(input.AccountingMethod)
                ) && 
                (
                    this.SubHoldingKeys == input.SubHoldingKeys ||
                    this.SubHoldingKeys != null &&
                    input.SubHoldingKeys != null &&
                    this.SubHoldingKeys.SequenceEqual(input.SubHoldingKeys)
                ) && 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    input.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.CorporateActionSourceId != null)
                    hashCode = hashCode * 59 + this.CorporateActionSourceId.GetHashCode();
                hashCode = hashCode * 59 + this.AccountingMethod.GetHashCode();
                if (this.SubHoldingKeys != null)
                    hashCode = hashCode * 59 + this.SubHoldingKeys.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }

    }
}
