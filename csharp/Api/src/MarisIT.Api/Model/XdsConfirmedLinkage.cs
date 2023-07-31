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
    /// XdsConfirmedLinkage
    /// </summary>
    [DataContract]
    public partial class XdsConfirmedLinkage :  IEquatable<XdsConfirmedLinkage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConfirmedLinkage" /> class.
        /// </summary>
        /// <param name="consumerRecordDate">consumerRecordDate.</param>
        /// <param name="consumerRecordType">consumerRecordType.</param>
        /// <param name="linkageCategory">linkageCategory.</param>
        /// <param name="matchedData">matchedData.</param>
        /// <param name="otherRecordDate">otherRecordDate.</param>
        /// <param name="otherRecordType">otherRecordType.</param>
        public XdsConfirmedLinkage(string consumerRecordDate = default(string), string consumerRecordType = default(string), string linkageCategory = default(string), string matchedData = default(string), string otherRecordDate = default(string), string otherRecordType = default(string))
        {
            this.ConsumerRecordDate = consumerRecordDate;
            this.ConsumerRecordType = consumerRecordType;
            this.LinkageCategory = linkageCategory;
            this.MatchedData = matchedData;
            this.OtherRecordDate = otherRecordDate;
            this.OtherRecordType = otherRecordType;
            this.ConsumerRecordDate = consumerRecordDate;
            this.ConsumerRecordType = consumerRecordType;
            this.LinkageCategory = linkageCategory;
            this.MatchedData = matchedData;
            this.OtherRecordDate = otherRecordDate;
            this.OtherRecordType = otherRecordType;
        }

        /// <summary>
        /// Gets or Sets ConsumerRecordDate
        /// </summary>
        [DataMember(Name="consumerRecordDate", EmitDefaultValue=true)]
        public string ConsumerRecordDate { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerRecordType
        /// </summary>
        [DataMember(Name="consumerRecordType", EmitDefaultValue=true)]
        public string ConsumerRecordType { get; set; }

        /// <summary>
        /// Gets or Sets LinkageCategory
        /// </summary>
        [DataMember(Name="linkageCategory", EmitDefaultValue=true)]
        public string LinkageCategory { get; set; }

        /// <summary>
        /// Gets or Sets MatchedData
        /// </summary>
        [DataMember(Name="matchedData", EmitDefaultValue=true)]
        public string MatchedData { get; set; }

        /// <summary>
        /// Gets or Sets OtherRecordDate
        /// </summary>
        [DataMember(Name="otherRecordDate", EmitDefaultValue=true)]
        public string OtherRecordDate { get; set; }

        /// <summary>
        /// Gets or Sets OtherRecordType
        /// </summary>
        [DataMember(Name="otherRecordType", EmitDefaultValue=true)]
        public string OtherRecordType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConfirmedLinkage {\n");
            sb.Append("  ConsumerRecordDate: ").Append(ConsumerRecordDate).Append("\n");
            sb.Append("  ConsumerRecordType: ").Append(ConsumerRecordType).Append("\n");
            sb.Append("  LinkageCategory: ").Append(LinkageCategory).Append("\n");
            sb.Append("  MatchedData: ").Append(MatchedData).Append("\n");
            sb.Append("  OtherRecordDate: ").Append(OtherRecordDate).Append("\n");
            sb.Append("  OtherRecordType: ").Append(OtherRecordType).Append("\n");
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
            return this.Equals(input as XdsConfirmedLinkage);
        }

        /// <summary>
        /// Returns true if XdsConfirmedLinkage instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConfirmedLinkage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConfirmedLinkage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerRecordDate == input.ConsumerRecordDate ||
                    (this.ConsumerRecordDate != null &&
                    this.ConsumerRecordDate.Equals(input.ConsumerRecordDate))
                ) && 
                (
                    this.ConsumerRecordType == input.ConsumerRecordType ||
                    (this.ConsumerRecordType != null &&
                    this.ConsumerRecordType.Equals(input.ConsumerRecordType))
                ) && 
                (
                    this.LinkageCategory == input.LinkageCategory ||
                    (this.LinkageCategory != null &&
                    this.LinkageCategory.Equals(input.LinkageCategory))
                ) && 
                (
                    this.MatchedData == input.MatchedData ||
                    (this.MatchedData != null &&
                    this.MatchedData.Equals(input.MatchedData))
                ) && 
                (
                    this.OtherRecordDate == input.OtherRecordDate ||
                    (this.OtherRecordDate != null &&
                    this.OtherRecordDate.Equals(input.OtherRecordDate))
                ) && 
                (
                    this.OtherRecordType == input.OtherRecordType ||
                    (this.OtherRecordType != null &&
                    this.OtherRecordType.Equals(input.OtherRecordType))
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
                if (this.ConsumerRecordDate != null)
                    hashCode = hashCode * 59 + this.ConsumerRecordDate.GetHashCode();
                if (this.ConsumerRecordType != null)
                    hashCode = hashCode * 59 + this.ConsumerRecordType.GetHashCode();
                if (this.LinkageCategory != null)
                    hashCode = hashCode * 59 + this.LinkageCategory.GetHashCode();
                if (this.MatchedData != null)
                    hashCode = hashCode * 59 + this.MatchedData.GetHashCode();
                if (this.OtherRecordDate != null)
                    hashCode = hashCode * 59 + this.OtherRecordDate.GetHashCode();
                if (this.OtherRecordType != null)
                    hashCode = hashCode * 59 + this.OtherRecordType.GetHashCode();
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