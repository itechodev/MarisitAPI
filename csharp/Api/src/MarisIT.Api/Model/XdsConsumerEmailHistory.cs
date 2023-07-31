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
    /// XdsConsumerEmailHistory
    /// </summary>
    [DataContract]
    public partial class XdsConsumerEmailHistory :  IEquatable<XdsConsumerEmailHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumerEmailHistory" /> class.
        /// </summary>
        /// <param name="displayText">displayText.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        public XdsConsumerEmailHistory(string displayText = default(string), string emailAddress = default(string), string lastUpdatedDate = default(string))
        {
            this.DisplayText = displayText;
            this.EmailAddress = emailAddress;
            this.LastUpdatedDate = lastUpdatedDate;
            this.DisplayText = displayText;
            this.EmailAddress = emailAddress;
            this.LastUpdatedDate = lastUpdatedDate;
        }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=true)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumerEmailHistory {\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
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
            return this.Equals(input as XdsConsumerEmailHistory);
        }

        /// <summary>
        /// Returns true if XdsConsumerEmailHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumerEmailHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumerEmailHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
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
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
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