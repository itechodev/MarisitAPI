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
    /// TransunionConsumer118TUVehicleFinanceDetailsVB
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TUVehicleFinanceDetailsVB :  IEquatable<TransunionConsumer118TUVehicleFinanceDetailsVB>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TUVehicleFinanceDetailsVB" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="financeHouse">financeHouse.</param>
        /// <param name="financeHouseBranch">financeHouseBranch.</param>
        /// <param name="financeHouseAccountNumber">financeHouseAccountNumber.</param>
        /// <param name="branchTelephoneCode">branchTelephoneCode.</param>
        /// <param name="branchTelephoneNumber">branchTelephoneNumber.</param>
        /// <param name="branchTelephoneExtensionNumber">branchTelephoneExtensionNumber.</param>
        /// <param name="agreementType">agreementType.</param>
        /// <param name="ownerIDNumber">ownerIDNumber.</param>
        /// <param name="ownerSurname">ownerSurname.</param>
        /// <param name="ownerForename1">ownerForename1.</param>
        /// <param name="ownerForename2">ownerForename2.</param>
        /// <param name="ownerForename3">ownerForename3.</param>
        /// <param name="ownerInitials">ownerInitials.</param>
        public TransunionConsumer118TUVehicleFinanceDetailsVB(string description = default(string), string financeHouse = default(string), string financeHouseBranch = default(string), string financeHouseAccountNumber = default(string), string branchTelephoneCode = default(string), string branchTelephoneNumber = default(string), string branchTelephoneExtensionNumber = default(string), string agreementType = default(string), string ownerIDNumber = default(string), string ownerSurname = default(string), string ownerForename1 = default(string), string ownerForename2 = default(string), string ownerForename3 = default(string), string ownerInitials = default(string))
        {
            this.Description = description;
            this.FinanceHouse = financeHouse;
            this.FinanceHouseBranch = financeHouseBranch;
            this.FinanceHouseAccountNumber = financeHouseAccountNumber;
            this.BranchTelephoneCode = branchTelephoneCode;
            this.BranchTelephoneNumber = branchTelephoneNumber;
            this.BranchTelephoneExtensionNumber = branchTelephoneExtensionNumber;
            this.AgreementType = agreementType;
            this.OwnerIDNumber = ownerIDNumber;
            this.OwnerSurname = ownerSurname;
            this.OwnerForename1 = ownerForename1;
            this.OwnerForename2 = ownerForename2;
            this.OwnerForename3 = ownerForename3;
            this.OwnerInitials = ownerInitials;
            this.Description = description;
            this.FinanceHouse = financeHouse;
            this.FinanceHouseBranch = financeHouseBranch;
            this.FinanceHouseAccountNumber = financeHouseAccountNumber;
            this.BranchTelephoneCode = branchTelephoneCode;
            this.BranchTelephoneNumber = branchTelephoneNumber;
            this.BranchTelephoneExtensionNumber = branchTelephoneExtensionNumber;
            this.AgreementType = agreementType;
            this.OwnerIDNumber = ownerIDNumber;
            this.OwnerSurname = ownerSurname;
            this.OwnerForename1 = ownerForename1;
            this.OwnerForename2 = ownerForename2;
            this.OwnerForename3 = ownerForename3;
            this.OwnerInitials = ownerInitials;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets FinanceHouse
        /// </summary>
        [DataMember(Name="financeHouse", EmitDefaultValue=true)]
        public string FinanceHouse { get; set; }

        /// <summary>
        /// Gets or Sets FinanceHouseBranch
        /// </summary>
        [DataMember(Name="financeHouseBranch", EmitDefaultValue=true)]
        public string FinanceHouseBranch { get; set; }

        /// <summary>
        /// Gets or Sets FinanceHouseAccountNumber
        /// </summary>
        [DataMember(Name="financeHouseAccountNumber", EmitDefaultValue=true)]
        public string FinanceHouseAccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets BranchTelephoneCode
        /// </summary>
        [DataMember(Name="branchTelephoneCode", EmitDefaultValue=true)]
        public string BranchTelephoneCode { get; set; }

        /// <summary>
        /// Gets or Sets BranchTelephoneNumber
        /// </summary>
        [DataMember(Name="branchTelephoneNumber", EmitDefaultValue=true)]
        public string BranchTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets BranchTelephoneExtensionNumber
        /// </summary>
        [DataMember(Name="branchTelephoneExtensionNumber", EmitDefaultValue=true)]
        public string BranchTelephoneExtensionNumber { get; set; }

        /// <summary>
        /// Gets or Sets AgreementType
        /// </summary>
        [DataMember(Name="agreementType", EmitDefaultValue=true)]
        public string AgreementType { get; set; }

        /// <summary>
        /// Gets or Sets OwnerIDNumber
        /// </summary>
        [DataMember(Name="ownerIDNumber", EmitDefaultValue=true)]
        public string OwnerIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets OwnerSurname
        /// </summary>
        [DataMember(Name="ownerSurname", EmitDefaultValue=true)]
        public string OwnerSurname { get; set; }

        /// <summary>
        /// Gets or Sets OwnerForename1
        /// </summary>
        [DataMember(Name="ownerForename1", EmitDefaultValue=true)]
        public string OwnerForename1 { get; set; }

        /// <summary>
        /// Gets or Sets OwnerForename2
        /// </summary>
        [DataMember(Name="ownerForename2", EmitDefaultValue=true)]
        public string OwnerForename2 { get; set; }

        /// <summary>
        /// Gets or Sets OwnerForename3
        /// </summary>
        [DataMember(Name="ownerForename3", EmitDefaultValue=true)]
        public string OwnerForename3 { get; set; }

        /// <summary>
        /// Gets or Sets OwnerInitials
        /// </summary>
        [DataMember(Name="ownerInitials", EmitDefaultValue=true)]
        public string OwnerInitials { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TUVehicleFinanceDetailsVB {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FinanceHouse: ").Append(FinanceHouse).Append("\n");
            sb.Append("  FinanceHouseBranch: ").Append(FinanceHouseBranch).Append("\n");
            sb.Append("  FinanceHouseAccountNumber: ").Append(FinanceHouseAccountNumber).Append("\n");
            sb.Append("  BranchTelephoneCode: ").Append(BranchTelephoneCode).Append("\n");
            sb.Append("  BranchTelephoneNumber: ").Append(BranchTelephoneNumber).Append("\n");
            sb.Append("  BranchTelephoneExtensionNumber: ").Append(BranchTelephoneExtensionNumber).Append("\n");
            sb.Append("  AgreementType: ").Append(AgreementType).Append("\n");
            sb.Append("  OwnerIDNumber: ").Append(OwnerIDNumber).Append("\n");
            sb.Append("  OwnerSurname: ").Append(OwnerSurname).Append("\n");
            sb.Append("  OwnerForename1: ").Append(OwnerForename1).Append("\n");
            sb.Append("  OwnerForename2: ").Append(OwnerForename2).Append("\n");
            sb.Append("  OwnerForename3: ").Append(OwnerForename3).Append("\n");
            sb.Append("  OwnerInitials: ").Append(OwnerInitials).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TUVehicleFinanceDetailsVB);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TUVehicleFinanceDetailsVB instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TUVehicleFinanceDetailsVB to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TUVehicleFinanceDetailsVB input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FinanceHouse == input.FinanceHouse ||
                    (this.FinanceHouse != null &&
                    this.FinanceHouse.Equals(input.FinanceHouse))
                ) && 
                (
                    this.FinanceHouseBranch == input.FinanceHouseBranch ||
                    (this.FinanceHouseBranch != null &&
                    this.FinanceHouseBranch.Equals(input.FinanceHouseBranch))
                ) && 
                (
                    this.FinanceHouseAccountNumber == input.FinanceHouseAccountNumber ||
                    (this.FinanceHouseAccountNumber != null &&
                    this.FinanceHouseAccountNumber.Equals(input.FinanceHouseAccountNumber))
                ) && 
                (
                    this.BranchTelephoneCode == input.BranchTelephoneCode ||
                    (this.BranchTelephoneCode != null &&
                    this.BranchTelephoneCode.Equals(input.BranchTelephoneCode))
                ) && 
                (
                    this.BranchTelephoneNumber == input.BranchTelephoneNumber ||
                    (this.BranchTelephoneNumber != null &&
                    this.BranchTelephoneNumber.Equals(input.BranchTelephoneNumber))
                ) && 
                (
                    this.BranchTelephoneExtensionNumber == input.BranchTelephoneExtensionNumber ||
                    (this.BranchTelephoneExtensionNumber != null &&
                    this.BranchTelephoneExtensionNumber.Equals(input.BranchTelephoneExtensionNumber))
                ) && 
                (
                    this.AgreementType == input.AgreementType ||
                    (this.AgreementType != null &&
                    this.AgreementType.Equals(input.AgreementType))
                ) && 
                (
                    this.OwnerIDNumber == input.OwnerIDNumber ||
                    (this.OwnerIDNumber != null &&
                    this.OwnerIDNumber.Equals(input.OwnerIDNumber))
                ) && 
                (
                    this.OwnerSurname == input.OwnerSurname ||
                    (this.OwnerSurname != null &&
                    this.OwnerSurname.Equals(input.OwnerSurname))
                ) && 
                (
                    this.OwnerForename1 == input.OwnerForename1 ||
                    (this.OwnerForename1 != null &&
                    this.OwnerForename1.Equals(input.OwnerForename1))
                ) && 
                (
                    this.OwnerForename2 == input.OwnerForename2 ||
                    (this.OwnerForename2 != null &&
                    this.OwnerForename2.Equals(input.OwnerForename2))
                ) && 
                (
                    this.OwnerForename3 == input.OwnerForename3 ||
                    (this.OwnerForename3 != null &&
                    this.OwnerForename3.Equals(input.OwnerForename3))
                ) && 
                (
                    this.OwnerInitials == input.OwnerInitials ||
                    (this.OwnerInitials != null &&
                    this.OwnerInitials.Equals(input.OwnerInitials))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FinanceHouse != null)
                    hashCode = hashCode * 59 + this.FinanceHouse.GetHashCode();
                if (this.FinanceHouseBranch != null)
                    hashCode = hashCode * 59 + this.FinanceHouseBranch.GetHashCode();
                if (this.FinanceHouseAccountNumber != null)
                    hashCode = hashCode * 59 + this.FinanceHouseAccountNumber.GetHashCode();
                if (this.BranchTelephoneCode != null)
                    hashCode = hashCode * 59 + this.BranchTelephoneCode.GetHashCode();
                if (this.BranchTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.BranchTelephoneNumber.GetHashCode();
                if (this.BranchTelephoneExtensionNumber != null)
                    hashCode = hashCode * 59 + this.BranchTelephoneExtensionNumber.GetHashCode();
                if (this.AgreementType != null)
                    hashCode = hashCode * 59 + this.AgreementType.GetHashCode();
                if (this.OwnerIDNumber != null)
                    hashCode = hashCode * 59 + this.OwnerIDNumber.GetHashCode();
                if (this.OwnerSurname != null)
                    hashCode = hashCode * 59 + this.OwnerSurname.GetHashCode();
                if (this.OwnerForename1 != null)
                    hashCode = hashCode * 59 + this.OwnerForename1.GetHashCode();
                if (this.OwnerForename2 != null)
                    hashCode = hashCode * 59 + this.OwnerForename2.GetHashCode();
                if (this.OwnerForename3 != null)
                    hashCode = hashCode * 59 + this.OwnerForename3.GetHashCode();
                if (this.OwnerInitials != null)
                    hashCode = hashCode * 59 + this.OwnerInitials.GetHashCode();
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
