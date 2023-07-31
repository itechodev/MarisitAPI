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
    /// TransunionCommercialCurrentLiabilities
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialCurrentLiabilities :  IEquatable<TransunionCommercialCurrentLiabilities>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialCurrentLiabilities" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="currentLiabilityTotal">currentLiabilityTotal.</param>
        /// <param name="currentLiabilityItem">currentLiabilityItem.</param>
        /// <param name="currentLiabilityItemAmt">currentLiabilityItemAmt.</param>
        public TransunionCommercialCurrentLiabilities(string majorProduct = default(string), string currentLiabilityTotal = default(string), List<string> currentLiabilityItem = default(List<string>), List<string> currentLiabilityItemAmt = default(List<string>))
        {
            this.MajorProduct = majorProduct;
            this.CurrentLiabilityTotal = currentLiabilityTotal;
            this.CurrentLiabilityItem = currentLiabilityItem;
            this.CurrentLiabilityItemAmt = currentLiabilityItemAmt;
            this.MajorProduct = majorProduct;
            this.CurrentLiabilityTotal = currentLiabilityTotal;
            this.CurrentLiabilityItem = currentLiabilityItem;
            this.CurrentLiabilityItemAmt = currentLiabilityItemAmt;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets CurrentLiabilityTotal
        /// </summary>
        [DataMember(Name="currentLiabilityTotal", EmitDefaultValue=true)]
        public string CurrentLiabilityTotal { get; set; }

        /// <summary>
        /// Gets or Sets CurrentLiabilityItem
        /// </summary>
        [DataMember(Name="currentLiabilityItem", EmitDefaultValue=true)]
        public List<string> CurrentLiabilityItem { get; set; }

        /// <summary>
        /// Gets or Sets CurrentLiabilityItemAmt
        /// </summary>
        [DataMember(Name="currentLiabilityItemAmt", EmitDefaultValue=true)]
        public List<string> CurrentLiabilityItemAmt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialCurrentLiabilities {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  CurrentLiabilityTotal: ").Append(CurrentLiabilityTotal).Append("\n");
            sb.Append("  CurrentLiabilityItem: ").Append(CurrentLiabilityItem).Append("\n");
            sb.Append("  CurrentLiabilityItemAmt: ").Append(CurrentLiabilityItemAmt).Append("\n");
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
            return this.Equals(input as TransunionCommercialCurrentLiabilities);
        }

        /// <summary>
        /// Returns true if TransunionCommercialCurrentLiabilities instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialCurrentLiabilities to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialCurrentLiabilities input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MajorProduct == input.MajorProduct ||
                    (this.MajorProduct != null &&
                    this.MajorProduct.Equals(input.MajorProduct))
                ) && 
                (
                    this.CurrentLiabilityTotal == input.CurrentLiabilityTotal ||
                    (this.CurrentLiabilityTotal != null &&
                    this.CurrentLiabilityTotal.Equals(input.CurrentLiabilityTotal))
                ) && 
                (
                    this.CurrentLiabilityItem == input.CurrentLiabilityItem ||
                    this.CurrentLiabilityItem != null &&
                    input.CurrentLiabilityItem != null &&
                    this.CurrentLiabilityItem.SequenceEqual(input.CurrentLiabilityItem)
                ) && 
                (
                    this.CurrentLiabilityItemAmt == input.CurrentLiabilityItemAmt ||
                    this.CurrentLiabilityItemAmt != null &&
                    input.CurrentLiabilityItemAmt != null &&
                    this.CurrentLiabilityItemAmt.SequenceEqual(input.CurrentLiabilityItemAmt)
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
                if (this.MajorProduct != null)
                    hashCode = hashCode * 59 + this.MajorProduct.GetHashCode();
                if (this.CurrentLiabilityTotal != null)
                    hashCode = hashCode * 59 + this.CurrentLiabilityTotal.GetHashCode();
                if (this.CurrentLiabilityItem != null)
                    hashCode = hashCode * 59 + this.CurrentLiabilityItem.GetHashCode();
                if (this.CurrentLiabilityItemAmt != null)
                    hashCode = hashCode * 59 + this.CurrentLiabilityItemAmt.GetHashCode();
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