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
    /// XdsAccountTypeLegend
    /// </summary>
    [DataContract]
    public partial class XdsAccountTypeLegend :  IEquatable<XdsAccountTypeLegend>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsAccountTypeLegend" /> class.
        /// </summary>
        /// <param name="accountTypeCode">accountTypeCode.</param>
        /// <param name="accountTypeDesc">accountTypeDesc.</param>
        /// <param name="displayText">displayText.</param>
        public XdsAccountTypeLegend(string accountTypeCode = default(string), string accountTypeDesc = default(string), string displayText = default(string))
        {
            this.AccountTypeCode = accountTypeCode;
            this.AccountTypeDesc = accountTypeDesc;
            this.DisplayText = displayText;
            this.AccountTypeCode = accountTypeCode;
            this.AccountTypeDesc = accountTypeDesc;
            this.DisplayText = displayText;
        }

        /// <summary>
        /// Gets or Sets AccountTypeCode
        /// </summary>
        [DataMember(Name="accountTypeCode", EmitDefaultValue=true)]
        public string AccountTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeDesc
        /// </summary>
        [DataMember(Name="accountTypeDesc", EmitDefaultValue=true)]
        public string AccountTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsAccountTypeLegend {\n");
            sb.Append("  AccountTypeCode: ").Append(AccountTypeCode).Append("\n");
            sb.Append("  AccountTypeDesc: ").Append(AccountTypeDesc).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
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
            return this.Equals(input as XdsAccountTypeLegend);
        }

        /// <summary>
        /// Returns true if XdsAccountTypeLegend instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsAccountTypeLegend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsAccountTypeLegend input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountTypeCode == input.AccountTypeCode ||
                    (this.AccountTypeCode != null &&
                    this.AccountTypeCode.Equals(input.AccountTypeCode))
                ) && 
                (
                    this.AccountTypeDesc == input.AccountTypeDesc ||
                    (this.AccountTypeDesc != null &&
                    this.AccountTypeDesc.Equals(input.AccountTypeDesc))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
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
                if (this.AccountTypeCode != null)
                    hashCode = hashCode * 59 + this.AccountTypeCode.GetHashCode();
                if (this.AccountTypeDesc != null)
                    hashCode = hashCode * 59 + this.AccountTypeDesc.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
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