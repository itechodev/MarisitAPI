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
    /// TransunionCommercialDeedsMultipleBond
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialDeedsMultipleBond :  IEquatable<TransunionCommercialDeedsMultipleBond>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialDeedsMultipleBond" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="actionDate">actionDate.</param>
        /// <param name="comment">comment.</param>
        /// <param name="bondNumber">bondNumber.</param>
        /// <param name="bondHolder">bondHolder.</param>
        /// <param name="bondAmount">bondAmount.</param>
        /// <param name="bondDate">bondDate.</param>
        /// <param name="bondBuyerID">bondBuyerID.</param>
        /// <param name="bondBuyerName">bondBuyerName.</param>
        /// <param name="rowID">rowID.</param>
        public TransunionCommercialDeedsMultipleBond(string majorProduct = default(string), string actionDate = default(string), string comment = default(string), string bondNumber = default(string), string bondHolder = default(string), string bondAmount = default(string), string bondDate = default(string), string bondBuyerID = default(string), string bondBuyerName = default(string), string rowID = default(string))
        {
            this.MajorProduct = majorProduct;
            this.ActionDate = actionDate;
            this.Comment = comment;
            this.BondNumber = bondNumber;
            this.BondHolder = bondHolder;
            this.BondAmount = bondAmount;
            this.BondDate = bondDate;
            this.BondBuyerID = bondBuyerID;
            this.BondBuyerName = bondBuyerName;
            this.RowID = rowID;
            this.MajorProduct = majorProduct;
            this.ActionDate = actionDate;
            this.Comment = comment;
            this.BondNumber = bondNumber;
            this.BondHolder = bondHolder;
            this.BondAmount = bondAmount;
            this.BondDate = bondDate;
            this.BondBuyerID = bondBuyerID;
            this.BondBuyerName = bondBuyerName;
            this.RowID = rowID;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets ActionDate
        /// </summary>
        [DataMember(Name="actionDate", EmitDefaultValue=true)]
        public string ActionDate { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets BondNumber
        /// </summary>
        [DataMember(Name="bondNumber", EmitDefaultValue=true)]
        public string BondNumber { get; set; }

        /// <summary>
        /// Gets or Sets BondHolder
        /// </summary>
        [DataMember(Name="bondHolder", EmitDefaultValue=true)]
        public string BondHolder { get; set; }

        /// <summary>
        /// Gets or Sets BondAmount
        /// </summary>
        [DataMember(Name="bondAmount", EmitDefaultValue=true)]
        public string BondAmount { get; set; }

        /// <summary>
        /// Gets or Sets BondDate
        /// </summary>
        [DataMember(Name="bondDate", EmitDefaultValue=true)]
        public string BondDate { get; set; }

        /// <summary>
        /// Gets or Sets BondBuyerID
        /// </summary>
        [DataMember(Name="bondBuyerID", EmitDefaultValue=true)]
        public string BondBuyerID { get; set; }

        /// <summary>
        /// Gets or Sets BondBuyerName
        /// </summary>
        [DataMember(Name="bondBuyerName", EmitDefaultValue=true)]
        public string BondBuyerName { get; set; }

        /// <summary>
        /// Gets or Sets RowID
        /// </summary>
        [DataMember(Name="rowID", EmitDefaultValue=true)]
        public string RowID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialDeedsMultipleBond {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  ActionDate: ").Append(ActionDate).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  BondNumber: ").Append(BondNumber).Append("\n");
            sb.Append("  BondHolder: ").Append(BondHolder).Append("\n");
            sb.Append("  BondAmount: ").Append(BondAmount).Append("\n");
            sb.Append("  BondDate: ").Append(BondDate).Append("\n");
            sb.Append("  BondBuyerID: ").Append(BondBuyerID).Append("\n");
            sb.Append("  BondBuyerName: ").Append(BondBuyerName).Append("\n");
            sb.Append("  RowID: ").Append(RowID).Append("\n");
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
            return this.Equals(input as TransunionCommercialDeedsMultipleBond);
        }

        /// <summary>
        /// Returns true if TransunionCommercialDeedsMultipleBond instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialDeedsMultipleBond to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialDeedsMultipleBond input)
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
                    this.ActionDate == input.ActionDate ||
                    (this.ActionDate != null &&
                    this.ActionDate.Equals(input.ActionDate))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.BondNumber == input.BondNumber ||
                    (this.BondNumber != null &&
                    this.BondNumber.Equals(input.BondNumber))
                ) && 
                (
                    this.BondHolder == input.BondHolder ||
                    (this.BondHolder != null &&
                    this.BondHolder.Equals(input.BondHolder))
                ) && 
                (
                    this.BondAmount == input.BondAmount ||
                    (this.BondAmount != null &&
                    this.BondAmount.Equals(input.BondAmount))
                ) && 
                (
                    this.BondDate == input.BondDate ||
                    (this.BondDate != null &&
                    this.BondDate.Equals(input.BondDate))
                ) && 
                (
                    this.BondBuyerID == input.BondBuyerID ||
                    (this.BondBuyerID != null &&
                    this.BondBuyerID.Equals(input.BondBuyerID))
                ) && 
                (
                    this.BondBuyerName == input.BondBuyerName ||
                    (this.BondBuyerName != null &&
                    this.BondBuyerName.Equals(input.BondBuyerName))
                ) && 
                (
                    this.RowID == input.RowID ||
                    (this.RowID != null &&
                    this.RowID.Equals(input.RowID))
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
                if (this.ActionDate != null)
                    hashCode = hashCode * 59 + this.ActionDate.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.BondNumber != null)
                    hashCode = hashCode * 59 + this.BondNumber.GetHashCode();
                if (this.BondHolder != null)
                    hashCode = hashCode * 59 + this.BondHolder.GetHashCode();
                if (this.BondAmount != null)
                    hashCode = hashCode * 59 + this.BondAmount.GetHashCode();
                if (this.BondDate != null)
                    hashCode = hashCode * 59 + this.BondDate.GetHashCode();
                if (this.BondBuyerID != null)
                    hashCode = hashCode * 59 + this.BondBuyerID.GetHashCode();
                if (this.BondBuyerName != null)
                    hashCode = hashCode * 59 + this.BondBuyerName.GetHashCode();
                if (this.RowID != null)
                    hashCode = hashCode * 59 + this.RowID.GetHashCode();
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
