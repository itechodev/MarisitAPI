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
    /// TransunionCommercialPrincipalClearance
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialPrincipalClearance :  IEquatable<TransunionCommercialPrincipalClearance>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Established
        /// </summary>
        [DataMember(Name="established", EmitDefaultValue=false)]
        public TransunionCommercialEstablished? Established { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialPrincipalClearance" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="surname">surname.</param>
        /// <param name="forename1">forename1.</param>
        /// <param name="forename2">forename2.</param>
        /// <param name="forename3">forename3.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="established">established.</param>
        /// <param name="civilCourtCount">civilCourtCount.</param>
        /// <param name="defaultCount">defaultCount.</param>
        /// <param name="noticeNotarialCount">noticeNotarialCount.</param>
        /// <param name="disputeDate">disputeDate.</param>
        /// <param name="debtCouncilDate">debtCouncilDate.</param>
        /// <param name="debtCouncilDesc">debtCouncilDesc.</param>
        public TransunionCommercialPrincipalClearance(string majorProduct = default(string), string surname = default(string), string forename1 = default(string), string forename2 = default(string), string forename3 = default(string), string idNumber = default(string), string dateOfBirth = default(string), TransunionCommercialEstablished? established = default(TransunionCommercialEstablished?), string civilCourtCount = default(string), string defaultCount = default(string), string noticeNotarialCount = default(string), string disputeDate = default(string), string debtCouncilDate = default(string), string debtCouncilDesc = default(string))
        {
            this.MajorProduct = majorProduct;
            this.Surname = surname;
            this.Forename1 = forename1;
            this.Forename2 = forename2;
            this.Forename3 = forename3;
            this.IdNumber = idNumber;
            this.DateOfBirth = dateOfBirth;
            this.CivilCourtCount = civilCourtCount;
            this.DefaultCount = defaultCount;
            this.NoticeNotarialCount = noticeNotarialCount;
            this.DisputeDate = disputeDate;
            this.DebtCouncilDate = debtCouncilDate;
            this.DebtCouncilDesc = debtCouncilDesc;
            this.MajorProduct = majorProduct;
            this.Surname = surname;
            this.Forename1 = forename1;
            this.Forename2 = forename2;
            this.Forename3 = forename3;
            this.IdNumber = idNumber;
            this.DateOfBirth = dateOfBirth;
            this.Established = established;
            this.CivilCourtCount = civilCourtCount;
            this.DefaultCount = defaultCount;
            this.NoticeNotarialCount = noticeNotarialCount;
            this.DisputeDate = disputeDate;
            this.DebtCouncilDate = debtCouncilDate;
            this.DebtCouncilDesc = debtCouncilDesc;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Forename1
        /// </summary>
        [DataMember(Name="forename1", EmitDefaultValue=true)]
        public string Forename1 { get; set; }

        /// <summary>
        /// Gets or Sets Forename2
        /// </summary>
        [DataMember(Name="forename2", EmitDefaultValue=true)]
        public string Forename2 { get; set; }

        /// <summary>
        /// Gets or Sets Forename3
        /// </summary>
        [DataMember(Name="forename3", EmitDefaultValue=true)]
        public string Forename3 { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=true)]
        public string DateOfBirth { get; set; }


        /// <summary>
        /// Gets or Sets CivilCourtCount
        /// </summary>
        [DataMember(Name="civilCourtCount", EmitDefaultValue=true)]
        public string CivilCourtCount { get; set; }

        /// <summary>
        /// Gets or Sets DefaultCount
        /// </summary>
        [DataMember(Name="defaultCount", EmitDefaultValue=true)]
        public string DefaultCount { get; set; }

        /// <summary>
        /// Gets or Sets NoticeNotarialCount
        /// </summary>
        [DataMember(Name="noticeNotarialCount", EmitDefaultValue=true)]
        public string NoticeNotarialCount { get; set; }

        /// <summary>
        /// Gets or Sets DisputeDate
        /// </summary>
        [DataMember(Name="disputeDate", EmitDefaultValue=true)]
        public string DisputeDate { get; set; }

        /// <summary>
        /// Gets or Sets DebtCouncilDate
        /// </summary>
        [DataMember(Name="debtCouncilDate", EmitDefaultValue=true)]
        public string DebtCouncilDate { get; set; }

        /// <summary>
        /// Gets or Sets DebtCouncilDesc
        /// </summary>
        [DataMember(Name="debtCouncilDesc", EmitDefaultValue=true)]
        public string DebtCouncilDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialPrincipalClearance {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Forename1: ").Append(Forename1).Append("\n");
            sb.Append("  Forename2: ").Append(Forename2).Append("\n");
            sb.Append("  Forename3: ").Append(Forename3).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Established: ").Append(Established).Append("\n");
            sb.Append("  CivilCourtCount: ").Append(CivilCourtCount).Append("\n");
            sb.Append("  DefaultCount: ").Append(DefaultCount).Append("\n");
            sb.Append("  NoticeNotarialCount: ").Append(NoticeNotarialCount).Append("\n");
            sb.Append("  DisputeDate: ").Append(DisputeDate).Append("\n");
            sb.Append("  DebtCouncilDate: ").Append(DebtCouncilDate).Append("\n");
            sb.Append("  DebtCouncilDesc: ").Append(DebtCouncilDesc).Append("\n");
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
            return this.Equals(input as TransunionCommercialPrincipalClearance);
        }

        /// <summary>
        /// Returns true if TransunionCommercialPrincipalClearance instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialPrincipalClearance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialPrincipalClearance input)
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
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Forename1 == input.Forename1 ||
                    (this.Forename1 != null &&
                    this.Forename1.Equals(input.Forename1))
                ) && 
                (
                    this.Forename2 == input.Forename2 ||
                    (this.Forename2 != null &&
                    this.Forename2.Equals(input.Forename2))
                ) && 
                (
                    this.Forename3 == input.Forename3 ||
                    (this.Forename3 != null &&
                    this.Forename3.Equals(input.Forename3))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Established == input.Established ||
                    (this.Established != null &&
                    this.Established.Equals(input.Established))
                ) && 
                (
                    this.CivilCourtCount == input.CivilCourtCount ||
                    (this.CivilCourtCount != null &&
                    this.CivilCourtCount.Equals(input.CivilCourtCount))
                ) && 
                (
                    this.DefaultCount == input.DefaultCount ||
                    (this.DefaultCount != null &&
                    this.DefaultCount.Equals(input.DefaultCount))
                ) && 
                (
                    this.NoticeNotarialCount == input.NoticeNotarialCount ||
                    (this.NoticeNotarialCount != null &&
                    this.NoticeNotarialCount.Equals(input.NoticeNotarialCount))
                ) && 
                (
                    this.DisputeDate == input.DisputeDate ||
                    (this.DisputeDate != null &&
                    this.DisputeDate.Equals(input.DisputeDate))
                ) && 
                (
                    this.DebtCouncilDate == input.DebtCouncilDate ||
                    (this.DebtCouncilDate != null &&
                    this.DebtCouncilDate.Equals(input.DebtCouncilDate))
                ) && 
                (
                    this.DebtCouncilDesc == input.DebtCouncilDesc ||
                    (this.DebtCouncilDesc != null &&
                    this.DebtCouncilDesc.Equals(input.DebtCouncilDesc))
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
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Forename1 != null)
                    hashCode = hashCode * 59 + this.Forename1.GetHashCode();
                if (this.Forename2 != null)
                    hashCode = hashCode * 59 + this.Forename2.GetHashCode();
                if (this.Forename3 != null)
                    hashCode = hashCode * 59 + this.Forename3.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.Established != null)
                    hashCode = hashCode * 59 + this.Established.GetHashCode();
                if (this.CivilCourtCount != null)
                    hashCode = hashCode * 59 + this.CivilCourtCount.GetHashCode();
                if (this.DefaultCount != null)
                    hashCode = hashCode * 59 + this.DefaultCount.GetHashCode();
                if (this.NoticeNotarialCount != null)
                    hashCode = hashCode * 59 + this.NoticeNotarialCount.GetHashCode();
                if (this.DisputeDate != null)
                    hashCode = hashCode * 59 + this.DisputeDate.GetHashCode();
                if (this.DebtCouncilDate != null)
                    hashCode = hashCode * 59 + this.DebtCouncilDate.GetHashCode();
                if (this.DebtCouncilDesc != null)
                    hashCode = hashCode * 59 + this.DebtCouncilDesc.GetHashCode();
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
