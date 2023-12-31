/*
 * MarisIT API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v6
 * Contact: development@marisit.co.za
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MarisIT.Api.Client.OpenAPIDateConverter;

namespace MarisIT.Api.Model
{
    /// <summary>
    /// XdsCommercialJudgmentSummary
    /// </summary>
    [DataContract]
    public partial class XdsCommercialJudgmentSummary :  IEquatable<XdsCommercialJudgmentSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsCommercialJudgmentSummary" /> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="judgmentType">judgmentType.</param>
        public XdsCommercialJudgmentSummary(string count = default(string), string displayText = default(string), string judgmentType = default(string))
        {
            this.Count = count;
            this.DisplayText = displayText;
            this.JudgmentType = judgmentType;
            this.Count = count;
            this.DisplayText = displayText;
            this.JudgmentType = judgmentType;
        }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=true)]
        public string Count { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets JudgmentType
        /// </summary>
        [DataMember(Name="judgmentType", EmitDefaultValue=true)]
        public string JudgmentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsCommercialJudgmentSummary {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  JudgmentType: ").Append(JudgmentType).Append("\n");
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
            return this.Equals(input as XdsCommercialJudgmentSummary);
        }

        /// <summary>
        /// Returns true if XdsCommercialJudgmentSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsCommercialJudgmentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsCommercialJudgmentSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.JudgmentType == input.JudgmentType ||
                    (this.JudgmentType != null &&
                    this.JudgmentType.Equals(input.JudgmentType))
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.JudgmentType != null)
                    hashCode = hashCode * 59 + this.JudgmentType.GetHashCode();
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
            yield break;
        }
    }

}
