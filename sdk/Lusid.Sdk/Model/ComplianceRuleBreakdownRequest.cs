/*
 * LUSID API
 *
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
    /// ComplianceRuleBreakdownRequest
    /// </summary>
    [DataContract(Name = "ComplianceRuleBreakdownRequest")]
    public partial class ComplianceRuleBreakdownRequest : IEquatable<ComplianceRuleBreakdownRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceRuleBreakdownRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ComplianceRuleBreakdownRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceRuleBreakdownRequest" /> class.
        /// </summary>
        /// <param name="groupStatus">groupStatus (required).</param>
        /// <param name="resultsUsed">resultsUsed (required).</param>
        /// <param name="propertiesUsed">propertiesUsed (required).</param>
        /// <param name="missingDataInformation">missingDataInformation (required).</param>
        public ComplianceRuleBreakdownRequest(string groupStatus = default(string), Dictionary<string, decimal> resultsUsed = default(Dictionary<string, decimal>), Dictionary<string, List<Property>> propertiesUsed = default(Dictionary<string, List<Property>>), List<string> missingDataInformation = default(List<string>))
        {
            // to ensure "groupStatus" is required (not null)
            if (groupStatus == null)
            {
                throw new ArgumentNullException("groupStatus is a required property for ComplianceRuleBreakdownRequest and cannot be null");
            }
            this.GroupStatus = groupStatus;
            // to ensure "resultsUsed" is required (not null)
            if (resultsUsed == null)
            {
                throw new ArgumentNullException("resultsUsed is a required property for ComplianceRuleBreakdownRequest and cannot be null");
            }
            this.ResultsUsed = resultsUsed;
            // to ensure "propertiesUsed" is required (not null)
            if (propertiesUsed == null)
            {
                throw new ArgumentNullException("propertiesUsed is a required property for ComplianceRuleBreakdownRequest and cannot be null");
            }
            this.PropertiesUsed = propertiesUsed;
            // to ensure "missingDataInformation" is required (not null)
            if (missingDataInformation == null)
            {
                throw new ArgumentNullException("missingDataInformation is a required property for ComplianceRuleBreakdownRequest and cannot be null");
            }
            this.MissingDataInformation = missingDataInformation;
        }

        /// <summary>
        /// Gets or Sets GroupStatus
        /// </summary>
        [DataMember(Name = "groupStatus", IsRequired = true, EmitDefaultValue = true)]
        public string GroupStatus { get; set; }

        /// <summary>
        /// Gets or Sets ResultsUsed
        /// </summary>
        [DataMember(Name = "resultsUsed", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, decimal> ResultsUsed { get; set; }

        /// <summary>
        /// Gets or Sets PropertiesUsed
        /// </summary>
        [DataMember(Name = "propertiesUsed", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, List<Property>> PropertiesUsed { get; set; }

        /// <summary>
        /// Gets or Sets MissingDataInformation
        /// </summary>
        [DataMember(Name = "missingDataInformation", IsRequired = true, EmitDefaultValue = true)]
        public List<string> MissingDataInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ComplianceRuleBreakdownRequest {\n");
            sb.Append("  GroupStatus: ").Append(GroupStatus).Append("\n");
            sb.Append("  ResultsUsed: ").Append(ResultsUsed).Append("\n");
            sb.Append("  PropertiesUsed: ").Append(PropertiesUsed).Append("\n");
            sb.Append("  MissingDataInformation: ").Append(MissingDataInformation).Append("\n");
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
            return this.Equals(input as ComplianceRuleBreakdownRequest);
        }

        /// <summary>
        /// Returns true if ComplianceRuleBreakdownRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplianceRuleBreakdownRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplianceRuleBreakdownRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupStatus == input.GroupStatus ||
                    (this.GroupStatus != null &&
                    this.GroupStatus.Equals(input.GroupStatus))
                ) && 
                (
                    this.ResultsUsed == input.ResultsUsed ||
                    this.ResultsUsed != null &&
                    input.ResultsUsed != null &&
                    this.ResultsUsed.SequenceEqual(input.ResultsUsed)
                ) && 
                (
                    this.PropertiesUsed == input.PropertiesUsed ||
                    this.PropertiesUsed != null &&
                    input.PropertiesUsed != null &&
                    this.PropertiesUsed.SequenceEqual(input.PropertiesUsed)
                ) && 
                (
                    this.MissingDataInformation == input.MissingDataInformation ||
                    this.MissingDataInformation != null &&
                    input.MissingDataInformation != null &&
                    this.MissingDataInformation.SequenceEqual(input.MissingDataInformation)
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
                if (this.GroupStatus != null)
                {
                    hashCode = (hashCode * 59) + this.GroupStatus.GetHashCode();
                }
                if (this.ResultsUsed != null)
                {
                    hashCode = (hashCode * 59) + this.ResultsUsed.GetHashCode();
                }
                if (this.PropertiesUsed != null)
                {
                    hashCode = (hashCode * 59) + this.PropertiesUsed.GetHashCode();
                }
                if (this.MissingDataInformation != null)
                {
                    hashCode = (hashCode * 59) + this.MissingDataInformation.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // GroupStatus (string) maxLength
            if (this.GroupStatus != null && this.GroupStatus.Length > 6000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupStatus, length must be less than 6000.", new [] { "GroupStatus" });
            }

            // GroupStatus (string) minLength
            if (this.GroupStatus != null && this.GroupStatus.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupStatus, length must be greater than 0.", new [] { "GroupStatus" });
            }

            yield break;
        }
    }
}
