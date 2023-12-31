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
    /// TransunionConsumer118BusinessDeedsSummaryDA
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118BusinessDeedsSummaryDA :  IEquatable<TransunionConsumer118BusinessDeedsSummaryDA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118BusinessDeedsSummaryDA" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="numberProperties">numberProperties.</param>
        /// <param name="totalValue">totalValue.</param>
        /// <param name="totalBond">totalBond.</param>
        /// <param name="totalOwned">totalOwned.</param>
        /// <param name="comment">comment.</param>
        /// <param name="oldestPropertyDate">oldestPropertyDate.</param>
        /// <param name="oldestPropertyValue">oldestPropertyValue.</param>
        /// <param name="bondCount">bondCount.</param>
        public TransunionConsumer118BusinessDeedsSummaryDA(string majorProduct = default(string), string deedsOffice = default(string), string numberProperties = default(string), string totalValue = default(string), string totalBond = default(string), string totalOwned = default(string), string comment = default(string), string oldestPropertyDate = default(string), string oldestPropertyValue = default(string), string bondCount = default(string))
        {
            this.MajorProduct = majorProduct;
            this.DeedsOffice = deedsOffice;
            this.NumberProperties = numberProperties;
            this.TotalValue = totalValue;
            this.TotalBond = totalBond;
            this.TotalOwned = totalOwned;
            this.Comment = comment;
            this.OldestPropertyDate = oldestPropertyDate;
            this.OldestPropertyValue = oldestPropertyValue;
            this.BondCount = bondCount;
            this.MajorProduct = majorProduct;
            this.DeedsOffice = deedsOffice;
            this.NumberProperties = numberProperties;
            this.TotalValue = totalValue;
            this.TotalBond = totalBond;
            this.TotalOwned = totalOwned;
            this.Comment = comment;
            this.OldestPropertyDate = oldestPropertyDate;
            this.OldestPropertyValue = oldestPropertyValue;
            this.BondCount = bondCount;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public string DeedsOffice { get; set; }

        /// <summary>
        /// Gets or Sets NumberProperties
        /// </summary>
        [DataMember(Name="numberProperties", EmitDefaultValue=true)]
        public string NumberProperties { get; set; }

        /// <summary>
        /// Gets or Sets TotalValue
        /// </summary>
        [DataMember(Name="totalValue", EmitDefaultValue=true)]
        public string TotalValue { get; set; }

        /// <summary>
        /// Gets or Sets TotalBond
        /// </summary>
        [DataMember(Name="totalBond", EmitDefaultValue=true)]
        public string TotalBond { get; set; }

        /// <summary>
        /// Gets or Sets TotalOwned
        /// </summary>
        [DataMember(Name="totalOwned", EmitDefaultValue=true)]
        public string TotalOwned { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets OldestPropertyDate
        /// </summary>
        [DataMember(Name="oldestPropertyDate", EmitDefaultValue=true)]
        public string OldestPropertyDate { get; set; }

        /// <summary>
        /// Gets or Sets OldestPropertyValue
        /// </summary>
        [DataMember(Name="oldestPropertyValue", EmitDefaultValue=true)]
        public string OldestPropertyValue { get; set; }

        /// <summary>
        /// Gets or Sets BondCount
        /// </summary>
        [DataMember(Name="bondCount", EmitDefaultValue=true)]
        public string BondCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118BusinessDeedsSummaryDA {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  NumberProperties: ").Append(NumberProperties).Append("\n");
            sb.Append("  TotalValue: ").Append(TotalValue).Append("\n");
            sb.Append("  TotalBond: ").Append(TotalBond).Append("\n");
            sb.Append("  TotalOwned: ").Append(TotalOwned).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  OldestPropertyDate: ").Append(OldestPropertyDate).Append("\n");
            sb.Append("  OldestPropertyValue: ").Append(OldestPropertyValue).Append("\n");
            sb.Append("  BondCount: ").Append(BondCount).Append("\n");
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
            return this.Equals(input as TransunionConsumer118BusinessDeedsSummaryDA);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118BusinessDeedsSummaryDA instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118BusinessDeedsSummaryDA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118BusinessDeedsSummaryDA input)
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
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.NumberProperties == input.NumberProperties ||
                    (this.NumberProperties != null &&
                    this.NumberProperties.Equals(input.NumberProperties))
                ) && 
                (
                    this.TotalValue == input.TotalValue ||
                    (this.TotalValue != null &&
                    this.TotalValue.Equals(input.TotalValue))
                ) && 
                (
                    this.TotalBond == input.TotalBond ||
                    (this.TotalBond != null &&
                    this.TotalBond.Equals(input.TotalBond))
                ) && 
                (
                    this.TotalOwned == input.TotalOwned ||
                    (this.TotalOwned != null &&
                    this.TotalOwned.Equals(input.TotalOwned))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.OldestPropertyDate == input.OldestPropertyDate ||
                    (this.OldestPropertyDate != null &&
                    this.OldestPropertyDate.Equals(input.OldestPropertyDate))
                ) && 
                (
                    this.OldestPropertyValue == input.OldestPropertyValue ||
                    (this.OldestPropertyValue != null &&
                    this.OldestPropertyValue.Equals(input.OldestPropertyValue))
                ) && 
                (
                    this.BondCount == input.BondCount ||
                    (this.BondCount != null &&
                    this.BondCount.Equals(input.BondCount))
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
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.NumberProperties != null)
                    hashCode = hashCode * 59 + this.NumberProperties.GetHashCode();
                if (this.TotalValue != null)
                    hashCode = hashCode * 59 + this.TotalValue.GetHashCode();
                if (this.TotalBond != null)
                    hashCode = hashCode * 59 + this.TotalBond.GetHashCode();
                if (this.TotalOwned != null)
                    hashCode = hashCode * 59 + this.TotalOwned.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.OldestPropertyDate != null)
                    hashCode = hashCode * 59 + this.OldestPropertyDate.GetHashCode();
                if (this.OldestPropertyValue != null)
                    hashCode = hashCode * 59 + this.OldestPropertyValue.GetHashCode();
                if (this.BondCount != null)
                    hashCode = hashCode * 59 + this.BondCount.GetHashCode();
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
