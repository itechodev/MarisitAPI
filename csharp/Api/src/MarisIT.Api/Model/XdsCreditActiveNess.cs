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
    /// XdsCreditActiveNess
    /// </summary>
    [DataContract]
    public partial class XdsCreditActiveNess :  IEquatable<XdsCreditActiveNess>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsCreditActiveNess" /> class.
        /// </summary>
        /// <param name="categoryDescription">categoryDescription.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="lastActivityMonths03">lastActivityMonths03.</param>
        /// <param name="lastActivityMonths12orMore">lastActivityMonths12orMore.</param>
        /// <param name="lastActivityMonths36">lastActivityMonths36.</param>
        /// <param name="lastActivityMonths69">lastActivityMonths69.</param>
        public XdsCreditActiveNess(string categoryDescription = default(string), string displayText = default(string), string lastActivityMonths03 = default(string), string lastActivityMonths12orMore = default(string), string lastActivityMonths36 = default(string), string lastActivityMonths69 = default(string))
        {
            this.CategoryDescription = categoryDescription;
            this.DisplayText = displayText;
            this.LastActivityMonths03 = lastActivityMonths03;
            this.LastActivityMonths12orMore = lastActivityMonths12orMore;
            this.LastActivityMonths36 = lastActivityMonths36;
            this.LastActivityMonths69 = lastActivityMonths69;
            this.CategoryDescription = categoryDescription;
            this.DisplayText = displayText;
            this.LastActivityMonths03 = lastActivityMonths03;
            this.LastActivityMonths12orMore = lastActivityMonths12orMore;
            this.LastActivityMonths36 = lastActivityMonths36;
            this.LastActivityMonths69 = lastActivityMonths69;
        }

        /// <summary>
        /// Gets or Sets CategoryDescription
        /// </summary>
        [DataMember(Name="categoryDescription", EmitDefaultValue=true)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityMonths03
        /// </summary>
        [DataMember(Name="lastActivityMonths03", EmitDefaultValue=true)]
        public string LastActivityMonths03 { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityMonths12orMore
        /// </summary>
        [DataMember(Name="lastActivityMonths12orMore", EmitDefaultValue=true)]
        public string LastActivityMonths12orMore { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityMonths36
        /// </summary>
        [DataMember(Name="lastActivityMonths36", EmitDefaultValue=true)]
        public string LastActivityMonths36 { get; set; }

        /// <summary>
        /// Gets or Sets LastActivityMonths69
        /// </summary>
        [DataMember(Name="lastActivityMonths69", EmitDefaultValue=true)]
        public string LastActivityMonths69 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsCreditActiveNess {\n");
            sb.Append("  CategoryDescription: ").Append(CategoryDescription).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  LastActivityMonths03: ").Append(LastActivityMonths03).Append("\n");
            sb.Append("  LastActivityMonths12orMore: ").Append(LastActivityMonths12orMore).Append("\n");
            sb.Append("  LastActivityMonths36: ").Append(LastActivityMonths36).Append("\n");
            sb.Append("  LastActivityMonths69: ").Append(LastActivityMonths69).Append("\n");
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
            return this.Equals(input as XdsCreditActiveNess);
        }

        /// <summary>
        /// Returns true if XdsCreditActiveNess instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsCreditActiveNess to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsCreditActiveNess input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryDescription == input.CategoryDescription ||
                    (this.CategoryDescription != null &&
                    this.CategoryDescription.Equals(input.CategoryDescription))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.LastActivityMonths03 == input.LastActivityMonths03 ||
                    (this.LastActivityMonths03 != null &&
                    this.LastActivityMonths03.Equals(input.LastActivityMonths03))
                ) && 
                (
                    this.LastActivityMonths12orMore == input.LastActivityMonths12orMore ||
                    (this.LastActivityMonths12orMore != null &&
                    this.LastActivityMonths12orMore.Equals(input.LastActivityMonths12orMore))
                ) && 
                (
                    this.LastActivityMonths36 == input.LastActivityMonths36 ||
                    (this.LastActivityMonths36 != null &&
                    this.LastActivityMonths36.Equals(input.LastActivityMonths36))
                ) && 
                (
                    this.LastActivityMonths69 == input.LastActivityMonths69 ||
                    (this.LastActivityMonths69 != null &&
                    this.LastActivityMonths69.Equals(input.LastActivityMonths69))
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
                if (this.CategoryDescription != null)
                    hashCode = hashCode * 59 + this.CategoryDescription.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.LastActivityMonths03 != null)
                    hashCode = hashCode * 59 + this.LastActivityMonths03.GetHashCode();
                if (this.LastActivityMonths12orMore != null)
                    hashCode = hashCode * 59 + this.LastActivityMonths12orMore.GetHashCode();
                if (this.LastActivityMonths36 != null)
                    hashCode = hashCode * 59 + this.LastActivityMonths36.GetHashCode();
                if (this.LastActivityMonths69 != null)
                    hashCode = hashCode * 59 + this.LastActivityMonths69.GetHashCode();
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
