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
    /// TransunionCommercialBankCodes
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialBankCodes :  IEquatable<TransunionCommercialBankCodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialBankCodes" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="accountNo">accountNo.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="branch">branch.</param>
        /// <param name="bankCode">bankCode.</param>
        /// <param name="bankCodeDesc">bankCodeDesc.</param>
        /// <param name="comment">comment.</param>
        /// <param name="amount">amount.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="terms">terms.</param>
        /// <param name="date">date.</param>
        public TransunionCommercialBankCodes(string majorProduct = default(string), string accountNo = default(string), string bankName = default(string), string branch = default(string), string bankCode = default(string), string bankCodeDesc = default(string), List<string> comment = default(List<string>), string amount = default(string), string startDate = default(string), string terms = default(string), string date = default(string))
        {
            this.MajorProduct = majorProduct;
            this.AccountNo = accountNo;
            this.BankName = bankName;
            this.Branch = branch;
            this.BankCode = bankCode;
            this.BankCodeDesc = bankCodeDesc;
            this.Comment = comment;
            this.Amount = amount;
            this.StartDate = startDate;
            this.Terms = terms;
            this.Date = date;
            this.MajorProduct = majorProduct;
            this.AccountNo = accountNo;
            this.BankName = bankName;
            this.Branch = branch;
            this.BankCode = bankCode;
            this.BankCodeDesc = bankCodeDesc;
            this.Comment = comment;
            this.Amount = amount;
            this.StartDate = startDate;
            this.Terms = terms;
            this.Date = date;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=true)]
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bankName", EmitDefaultValue=true)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="branch", EmitDefaultValue=true)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>
        [DataMember(Name="bankCode", EmitDefaultValue=true)]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or Sets BankCodeDesc
        /// </summary>
        [DataMember(Name="bankCodeDesc", EmitDefaultValue=true)]
        public string BankCodeDesc { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public List<string> Comment { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=true)]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public string Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialBankCodes {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankCodeDesc: ").Append(BankCodeDesc).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as TransunionCommercialBankCodes);
        }

        /// <summary>
        /// Returns true if TransunionCommercialBankCodes instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialBankCodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialBankCodes input)
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
                    this.AccountNo == input.AccountNo ||
                    (this.AccountNo != null &&
                    this.AccountNo.Equals(input.AccountNo))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.BankCodeDesc == input.BankCodeDesc ||
                    (this.BankCodeDesc != null &&
                    this.BankCodeDesc.Equals(input.BankCodeDesc))
                ) && 
                (
                    this.Comment == input.Comment ||
                    this.Comment != null &&
                    input.Comment != null &&
                    this.Comment.SequenceEqual(input.Comment)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.AccountNo != null)
                    hashCode = hashCode * 59 + this.AccountNo.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
                if (this.BankCodeDesc != null)
                    hashCode = hashCode * 59 + this.BankCodeDesc.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
