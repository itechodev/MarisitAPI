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
    /// TransunionCommercialAccountVerificationVA
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialAccountVerificationVA :  IEquatable<TransunionCommercialAccountVerificationVA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialAccountVerificationVA" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="bankName">bankName.</param>
        /// <param name="branchCode">branchCode.</param>
        /// <param name="branchName">branchName.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="accountHolder">accountHolder.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="verified">verified.</param>
        /// <param name="verifiedDated">verifiedDated.</param>
        /// <param name="accountFound">accountFound.</param>
        /// <param name="idMatch">idMatch.</param>
        /// <param name="surnameMatch">surnameMatch.</param>
        /// <param name="accountOpen">accountOpen.</param>
        /// <param name="accountDormant">accountDormant.</param>
        /// <param name="accountOpen3Months">accountOpen3Months.</param>
        /// <param name="accountAcceptsDebits">accountAcceptsDebits.</param>
        /// <param name="accountAcceptsCredits">accountAcceptsCredits.</param>
        /// <param name="errorReason">errorReason.</param>
        /// <param name="comment">comment.</param>
        public TransunionCommercialAccountVerificationVA(string majorProduct = default(string), string bankName = default(string), string branchCode = default(string), string branchName = default(string), string accountNumber = default(string), string accountType = default(string), string accountHolder = default(string), string startDate = default(string), string verified = default(string), string verifiedDated = default(string), string accountFound = default(string), string idMatch = default(string), string surnameMatch = default(string), string accountOpen = default(string), string accountDormant = default(string), string accountOpen3Months = default(string), string accountAcceptsDebits = default(string), string accountAcceptsCredits = default(string), string errorReason = default(string), string comment = default(string))
        {
            this.MajorProduct = majorProduct;
            this.BankName = bankName;
            this.BranchCode = branchCode;
            this.BranchName = branchName;
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.AccountHolder = accountHolder;
            this.StartDate = startDate;
            this.Verified = verified;
            this.VerifiedDated = verifiedDated;
            this.AccountFound = accountFound;
            this.IdMatch = idMatch;
            this.SurnameMatch = surnameMatch;
            this.AccountOpen = accountOpen;
            this.AccountDormant = accountDormant;
            this.AccountOpen3Months = accountOpen3Months;
            this.AccountAcceptsDebits = accountAcceptsDebits;
            this.AccountAcceptsCredits = accountAcceptsCredits;
            this.ErrorReason = errorReason;
            this.Comment = comment;
            this.MajorProduct = majorProduct;
            this.BankName = bankName;
            this.BranchCode = branchCode;
            this.BranchName = branchName;
            this.AccountNumber = accountNumber;
            this.AccountType = accountType;
            this.AccountHolder = accountHolder;
            this.StartDate = startDate;
            this.Verified = verified;
            this.VerifiedDated = verifiedDated;
            this.AccountFound = accountFound;
            this.IdMatch = idMatch;
            this.SurnameMatch = surnameMatch;
            this.AccountOpen = accountOpen;
            this.AccountDormant = accountDormant;
            this.AccountOpen3Months = accountOpen3Months;
            this.AccountAcceptsDebits = accountAcceptsDebits;
            this.AccountAcceptsCredits = accountAcceptsCredits;
            this.ErrorReason = errorReason;
            this.Comment = comment;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bankName", EmitDefaultValue=true)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name="branchCode", EmitDefaultValue=true)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets BranchName
        /// </summary>
        [DataMember(Name="branchName", EmitDefaultValue=true)]
        public string BranchName { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=true)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets AccountHolder
        /// </summary>
        [DataMember(Name="accountHolder", EmitDefaultValue=true)]
        public string AccountHolder { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=true)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name="verified", EmitDefaultValue=true)]
        public string Verified { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedDated
        /// </summary>
        [DataMember(Name="verifiedDated", EmitDefaultValue=true)]
        public string VerifiedDated { get; set; }

        /// <summary>
        /// Gets or Sets AccountFound
        /// </summary>
        [DataMember(Name="accountFound", EmitDefaultValue=true)]
        public string AccountFound { get; set; }

        /// <summary>
        /// Gets or Sets IdMatch
        /// </summary>
        [DataMember(Name="idMatch", EmitDefaultValue=true)]
        public string IdMatch { get; set; }

        /// <summary>
        /// Gets or Sets SurnameMatch
        /// </summary>
        [DataMember(Name="surnameMatch", EmitDefaultValue=true)]
        public string SurnameMatch { get; set; }

        /// <summary>
        /// Gets or Sets AccountOpen
        /// </summary>
        [DataMember(Name="accountOpen", EmitDefaultValue=true)]
        public string AccountOpen { get; set; }

        /// <summary>
        /// Gets or Sets AccountDormant
        /// </summary>
        [DataMember(Name="accountDormant", EmitDefaultValue=true)]
        public string AccountDormant { get; set; }

        /// <summary>
        /// Gets or Sets AccountOpen3Months
        /// </summary>
        [DataMember(Name="accountOpen3Months", EmitDefaultValue=true)]
        public string AccountOpen3Months { get; set; }

        /// <summary>
        /// Gets or Sets AccountAcceptsDebits
        /// </summary>
        [DataMember(Name="accountAcceptsDebits", EmitDefaultValue=true)]
        public string AccountAcceptsDebits { get; set; }

        /// <summary>
        /// Gets or Sets AccountAcceptsCredits
        /// </summary>
        [DataMember(Name="accountAcceptsCredits", EmitDefaultValue=true)]
        public string AccountAcceptsCredits { get; set; }

        /// <summary>
        /// Gets or Sets ErrorReason
        /// </summary>
        [DataMember(Name="errorReason", EmitDefaultValue=true)]
        public string ErrorReason { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialAccountVerificationVA {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  BranchName: ").Append(BranchName).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
            sb.Append("  VerifiedDated: ").Append(VerifiedDated).Append("\n");
            sb.Append("  AccountFound: ").Append(AccountFound).Append("\n");
            sb.Append("  IdMatch: ").Append(IdMatch).Append("\n");
            sb.Append("  SurnameMatch: ").Append(SurnameMatch).Append("\n");
            sb.Append("  AccountOpen: ").Append(AccountOpen).Append("\n");
            sb.Append("  AccountDormant: ").Append(AccountDormant).Append("\n");
            sb.Append("  AccountOpen3Months: ").Append(AccountOpen3Months).Append("\n");
            sb.Append("  AccountAcceptsDebits: ").Append(AccountAcceptsDebits).Append("\n");
            sb.Append("  AccountAcceptsCredits: ").Append(AccountAcceptsCredits).Append("\n");
            sb.Append("  ErrorReason: ").Append(ErrorReason).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(input as TransunionCommercialAccountVerificationVA);
        }

        /// <summary>
        /// Returns true if TransunionCommercialAccountVerificationVA instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialAccountVerificationVA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialAccountVerificationVA input)
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
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.BranchName == input.BranchName ||
                    (this.BranchName != null &&
                    this.BranchName.Equals(input.BranchName))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.AccountHolder == input.AccountHolder ||
                    (this.AccountHolder != null &&
                    this.AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Verified == input.Verified ||
                    (this.Verified != null &&
                    this.Verified.Equals(input.Verified))
                ) && 
                (
                    this.VerifiedDated == input.VerifiedDated ||
                    (this.VerifiedDated != null &&
                    this.VerifiedDated.Equals(input.VerifiedDated))
                ) && 
                (
                    this.AccountFound == input.AccountFound ||
                    (this.AccountFound != null &&
                    this.AccountFound.Equals(input.AccountFound))
                ) && 
                (
                    this.IdMatch == input.IdMatch ||
                    (this.IdMatch != null &&
                    this.IdMatch.Equals(input.IdMatch))
                ) && 
                (
                    this.SurnameMatch == input.SurnameMatch ||
                    (this.SurnameMatch != null &&
                    this.SurnameMatch.Equals(input.SurnameMatch))
                ) && 
                (
                    this.AccountOpen == input.AccountOpen ||
                    (this.AccountOpen != null &&
                    this.AccountOpen.Equals(input.AccountOpen))
                ) && 
                (
                    this.AccountDormant == input.AccountDormant ||
                    (this.AccountDormant != null &&
                    this.AccountDormant.Equals(input.AccountDormant))
                ) && 
                (
                    this.AccountOpen3Months == input.AccountOpen3Months ||
                    (this.AccountOpen3Months != null &&
                    this.AccountOpen3Months.Equals(input.AccountOpen3Months))
                ) && 
                (
                    this.AccountAcceptsDebits == input.AccountAcceptsDebits ||
                    (this.AccountAcceptsDebits != null &&
                    this.AccountAcceptsDebits.Equals(input.AccountAcceptsDebits))
                ) && 
                (
                    this.AccountAcceptsCredits == input.AccountAcceptsCredits ||
                    (this.AccountAcceptsCredits != null &&
                    this.AccountAcceptsCredits.Equals(input.AccountAcceptsCredits))
                ) && 
                (
                    this.ErrorReason == input.ErrorReason ||
                    (this.ErrorReason != null &&
                    this.ErrorReason.Equals(input.ErrorReason))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BranchCode != null)
                    hashCode = hashCode * 59 + this.BranchCode.GetHashCode();
                if (this.BranchName != null)
                    hashCode = hashCode * 59 + this.BranchName.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.AccountHolder != null)
                    hashCode = hashCode * 59 + this.AccountHolder.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Verified != null)
                    hashCode = hashCode * 59 + this.Verified.GetHashCode();
                if (this.VerifiedDated != null)
                    hashCode = hashCode * 59 + this.VerifiedDated.GetHashCode();
                if (this.AccountFound != null)
                    hashCode = hashCode * 59 + this.AccountFound.GetHashCode();
                if (this.IdMatch != null)
                    hashCode = hashCode * 59 + this.IdMatch.GetHashCode();
                if (this.SurnameMatch != null)
                    hashCode = hashCode * 59 + this.SurnameMatch.GetHashCode();
                if (this.AccountOpen != null)
                    hashCode = hashCode * 59 + this.AccountOpen.GetHashCode();
                if (this.AccountDormant != null)
                    hashCode = hashCode * 59 + this.AccountDormant.GetHashCode();
                if (this.AccountOpen3Months != null)
                    hashCode = hashCode * 59 + this.AccountOpen3Months.GetHashCode();
                if (this.AccountAcceptsDebits != null)
                    hashCode = hashCode * 59 + this.AccountAcceptsDebits.GetHashCode();
                if (this.AccountAcceptsCredits != null)
                    hashCode = hashCode * 59 + this.AccountAcceptsCredits.GetHashCode();
                if (this.ErrorReason != null)
                    hashCode = hashCode * 59 + this.ErrorReason.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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
