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
    /// TransunionCommercialCurrentAsset
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialCurrentAsset :  IEquatable<TransunionCommercialCurrentAsset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialCurrentAsset" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="currentAssTotal">currentAssTotal.</param>
        /// <param name="currentAssItem">currentAssItem.</param>
        /// <param name="currentAssItemAmt">currentAssItemAmt.</param>
        public TransunionCommercialCurrentAsset(string majorProduct = default(string), string currentAssTotal = default(string), List<string> currentAssItem = default(List<string>), List<string> currentAssItemAmt = default(List<string>))
        {
            this.MajorProduct = majorProduct;
            this.CurrentAssTotal = currentAssTotal;
            this.CurrentAssItem = currentAssItem;
            this.CurrentAssItemAmt = currentAssItemAmt;
            this.MajorProduct = majorProduct;
            this.CurrentAssTotal = currentAssTotal;
            this.CurrentAssItem = currentAssItem;
            this.CurrentAssItemAmt = currentAssItemAmt;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAssTotal
        /// </summary>
        [DataMember(Name="currentAssTotal", EmitDefaultValue=true)]
        public string CurrentAssTotal { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAssItem
        /// </summary>
        [DataMember(Name="currentAssItem", EmitDefaultValue=true)]
        public List<string> CurrentAssItem { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAssItemAmt
        /// </summary>
        [DataMember(Name="currentAssItemAmt", EmitDefaultValue=true)]
        public List<string> CurrentAssItemAmt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialCurrentAsset {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  CurrentAssTotal: ").Append(CurrentAssTotal).Append("\n");
            sb.Append("  CurrentAssItem: ").Append(CurrentAssItem).Append("\n");
            sb.Append("  CurrentAssItemAmt: ").Append(CurrentAssItemAmt).Append("\n");
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
            return this.Equals(input as TransunionCommercialCurrentAsset);
        }

        /// <summary>
        /// Returns true if TransunionCommercialCurrentAsset instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialCurrentAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialCurrentAsset input)
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
                    this.CurrentAssTotal == input.CurrentAssTotal ||
                    (this.CurrentAssTotal != null &&
                    this.CurrentAssTotal.Equals(input.CurrentAssTotal))
                ) && 
                (
                    this.CurrentAssItem == input.CurrentAssItem ||
                    this.CurrentAssItem != null &&
                    input.CurrentAssItem != null &&
                    this.CurrentAssItem.SequenceEqual(input.CurrentAssItem)
                ) && 
                (
                    this.CurrentAssItemAmt == input.CurrentAssItemAmt ||
                    this.CurrentAssItemAmt != null &&
                    input.CurrentAssItemAmt != null &&
                    this.CurrentAssItemAmt.SequenceEqual(input.CurrentAssItemAmt)
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
                if (this.CurrentAssTotal != null)
                    hashCode = hashCode * 59 + this.CurrentAssTotal.GetHashCode();
                if (this.CurrentAssItem != null)
                    hashCode = hashCode * 59 + this.CurrentAssItem.GetHashCode();
                if (this.CurrentAssItemAmt != null)
                    hashCode = hashCode * 59 + this.CurrentAssItemAmt.GetHashCode();
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
