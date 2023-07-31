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
    /// TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1 :  IEquatable<TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1" /> class.
        /// </summary>
        /// <param name="claimIndicator">claimIndicator.</param>
        /// <param name="requestIndicator">requestIndicator.</param>
        /// <param name="insurerName">insurerName.</param>
        /// <param name="policyNo">policyNo.</param>
        /// <param name="dateofLoss">dateofLoss.</param>
        /// <param name="claimNumber">claimNumber.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="claimStatusDate">claimStatusDate.</param>
        /// <param name="repudiationReason">repudiationReason.</param>
        /// <param name="claimClass1">claimClass1.</param>
        /// <param name="causeofLoss1">causeofLoss1.</param>
        /// <param name="initialAmount1">initialAmount1.</param>
        /// <param name="finalAmount1">finalAmount1.</param>
        /// <param name="claimClass2">claimClass2.</param>
        /// <param name="causeofLoss2">causeofLoss2.</param>
        /// <param name="initialAmount2">initialAmount2.</param>
        /// <param name="finalAmount2">finalAmount2.</param>
        /// <param name="claimClass3">claimClass3.</param>
        /// <param name="causeofLoss3">causeofLoss3.</param>
        /// <param name="initialAmount3">initialAmount3.</param>
        /// <param name="finalAmount3">finalAmount3.</param>
        public TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1(string claimIndicator = default(string), string requestIndicator = default(string), string insurerName = default(string), string policyNo = default(string), string dateofLoss = default(string), string claimNumber = default(string), string claimStatus = default(string), string claimStatusDate = default(string), string repudiationReason = default(string), string claimClass1 = default(string), string causeofLoss1 = default(string), string initialAmount1 = default(string), string finalAmount1 = default(string), string claimClass2 = default(string), string causeofLoss2 = default(string), string initialAmount2 = default(string), string finalAmount2 = default(string), string claimClass3 = default(string), string causeofLoss3 = default(string), string initialAmount3 = default(string), string finalAmount3 = default(string))
        {
            this.ClaimIndicator = claimIndicator;
            this.RequestIndicator = requestIndicator;
            this.InsurerName = insurerName;
            this.PolicyNo = policyNo;
            this.DateofLoss = dateofLoss;
            this.ClaimNumber = claimNumber;
            this.ClaimStatus = claimStatus;
            this.ClaimStatusDate = claimStatusDate;
            this.RepudiationReason = repudiationReason;
            this.ClaimClass1 = claimClass1;
            this.CauseofLoss1 = causeofLoss1;
            this.InitialAmount1 = initialAmount1;
            this.FinalAmount1 = finalAmount1;
            this.ClaimClass2 = claimClass2;
            this.CauseofLoss2 = causeofLoss2;
            this.InitialAmount2 = initialAmount2;
            this.FinalAmount2 = finalAmount2;
            this.ClaimClass3 = claimClass3;
            this.CauseofLoss3 = causeofLoss3;
            this.InitialAmount3 = initialAmount3;
            this.FinalAmount3 = finalAmount3;
            this.ClaimIndicator = claimIndicator;
            this.RequestIndicator = requestIndicator;
            this.InsurerName = insurerName;
            this.PolicyNo = policyNo;
            this.DateofLoss = dateofLoss;
            this.ClaimNumber = claimNumber;
            this.ClaimStatus = claimStatus;
            this.ClaimStatusDate = claimStatusDate;
            this.RepudiationReason = repudiationReason;
            this.ClaimClass1 = claimClass1;
            this.CauseofLoss1 = causeofLoss1;
            this.InitialAmount1 = initialAmount1;
            this.FinalAmount1 = finalAmount1;
            this.ClaimClass2 = claimClass2;
            this.CauseofLoss2 = causeofLoss2;
            this.InitialAmount2 = initialAmount2;
            this.FinalAmount2 = finalAmount2;
            this.ClaimClass3 = claimClass3;
            this.CauseofLoss3 = causeofLoss3;
            this.InitialAmount3 = initialAmount3;
            this.FinalAmount3 = finalAmount3;
        }

        /// <summary>
        /// Gets or Sets ClaimIndicator
        /// </summary>
        [DataMember(Name="claimIndicator", EmitDefaultValue=true)]
        public string ClaimIndicator { get; set; }

        /// <summary>
        /// Gets or Sets RequestIndicator
        /// </summary>
        [DataMember(Name="requestIndicator", EmitDefaultValue=true)]
        public string RequestIndicator { get; set; }

        /// <summary>
        /// Gets or Sets InsurerName
        /// </summary>
        [DataMember(Name="insurerName", EmitDefaultValue=true)]
        public string InsurerName { get; set; }

        /// <summary>
        /// Gets or Sets PolicyNo
        /// </summary>
        [DataMember(Name="policyNo", EmitDefaultValue=true)]
        public string PolicyNo { get; set; }

        /// <summary>
        /// Gets or Sets DateofLoss
        /// </summary>
        [DataMember(Name="dateofLoss", EmitDefaultValue=true)]
        public string DateofLoss { get; set; }

        /// <summary>
        /// Gets or Sets ClaimNumber
        /// </summary>
        [DataMember(Name="claimNumber", EmitDefaultValue=true)]
        public string ClaimNumber { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatus
        /// </summary>
        [DataMember(Name="claimStatus", EmitDefaultValue=true)]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatusDate
        /// </summary>
        [DataMember(Name="claimStatusDate", EmitDefaultValue=true)]
        public string ClaimStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets RepudiationReason
        /// </summary>
        [DataMember(Name="repudiationReason", EmitDefaultValue=true)]
        public string RepudiationReason { get; set; }

        /// <summary>
        /// Gets or Sets ClaimClass1
        /// </summary>
        [DataMember(Name="claimClass1", EmitDefaultValue=true)]
        public string ClaimClass1 { get; set; }

        /// <summary>
        /// Gets or Sets CauseofLoss1
        /// </summary>
        [DataMember(Name="causeofLoss1", EmitDefaultValue=true)]
        public string CauseofLoss1 { get; set; }

        /// <summary>
        /// Gets or Sets InitialAmount1
        /// </summary>
        [DataMember(Name="initialAmount1", EmitDefaultValue=true)]
        public string InitialAmount1 { get; set; }

        /// <summary>
        /// Gets or Sets FinalAmount1
        /// </summary>
        [DataMember(Name="finalAmount1", EmitDefaultValue=true)]
        public string FinalAmount1 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimClass2
        /// </summary>
        [DataMember(Name="claimClass2", EmitDefaultValue=true)]
        public string ClaimClass2 { get; set; }

        /// <summary>
        /// Gets or Sets CauseofLoss2
        /// </summary>
        [DataMember(Name="causeofLoss2", EmitDefaultValue=true)]
        public string CauseofLoss2 { get; set; }

        /// <summary>
        /// Gets or Sets InitialAmount2
        /// </summary>
        [DataMember(Name="initialAmount2", EmitDefaultValue=true)]
        public string InitialAmount2 { get; set; }

        /// <summary>
        /// Gets or Sets FinalAmount2
        /// </summary>
        [DataMember(Name="finalAmount2", EmitDefaultValue=true)]
        public string FinalAmount2 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimClass3
        /// </summary>
        [DataMember(Name="claimClass3", EmitDefaultValue=true)]
        public string ClaimClass3 { get; set; }

        /// <summary>
        /// Gets or Sets CauseofLoss3
        /// </summary>
        [DataMember(Name="causeofLoss3", EmitDefaultValue=true)]
        public string CauseofLoss3 { get; set; }

        /// <summary>
        /// Gets or Sets InitialAmount3
        /// </summary>
        [DataMember(Name="initialAmount3", EmitDefaultValue=true)]
        public string InitialAmount3 { get; set; }

        /// <summary>
        /// Gets or Sets FinalAmount3
        /// </summary>
        [DataMember(Name="finalAmount3", EmitDefaultValue=true)]
        public string FinalAmount3 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1 {\n");
            sb.Append("  ClaimIndicator: ").Append(ClaimIndicator).Append("\n");
            sb.Append("  RequestIndicator: ").Append(RequestIndicator).Append("\n");
            sb.Append("  InsurerName: ").Append(InsurerName).Append("\n");
            sb.Append("  PolicyNo: ").Append(PolicyNo).Append("\n");
            sb.Append("  DateofLoss: ").Append(DateofLoss).Append("\n");
            sb.Append("  ClaimNumber: ").Append(ClaimNumber).Append("\n");
            sb.Append("  ClaimStatus: ").Append(ClaimStatus).Append("\n");
            sb.Append("  ClaimStatusDate: ").Append(ClaimStatusDate).Append("\n");
            sb.Append("  RepudiationReason: ").Append(RepudiationReason).Append("\n");
            sb.Append("  ClaimClass1: ").Append(ClaimClass1).Append("\n");
            sb.Append("  CauseofLoss1: ").Append(CauseofLoss1).Append("\n");
            sb.Append("  InitialAmount1: ").Append(InitialAmount1).Append("\n");
            sb.Append("  FinalAmount1: ").Append(FinalAmount1).Append("\n");
            sb.Append("  ClaimClass2: ").Append(ClaimClass2).Append("\n");
            sb.Append("  CauseofLoss2: ").Append(CauseofLoss2).Append("\n");
            sb.Append("  InitialAmount2: ").Append(InitialAmount2).Append("\n");
            sb.Append("  FinalAmount2: ").Append(FinalAmount2).Append("\n");
            sb.Append("  ClaimClass3: ").Append(ClaimClass3).Append("\n");
            sb.Append("  CauseofLoss3: ").Append(CauseofLoss3).Append("\n");
            sb.Append("  InitialAmount3: ").Append(InitialAmount3).Append("\n");
            sb.Append("  FinalAmount3: ").Append(FinalAmount3).Append("\n");
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
            return this.Equals(input as TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118IndivualOwnOtherClaimDetails0to3yearsI1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClaimIndicator == input.ClaimIndicator ||
                    (this.ClaimIndicator != null &&
                    this.ClaimIndicator.Equals(input.ClaimIndicator))
                ) && 
                (
                    this.RequestIndicator == input.RequestIndicator ||
                    (this.RequestIndicator != null &&
                    this.RequestIndicator.Equals(input.RequestIndicator))
                ) && 
                (
                    this.InsurerName == input.InsurerName ||
                    (this.InsurerName != null &&
                    this.InsurerName.Equals(input.InsurerName))
                ) && 
                (
                    this.PolicyNo == input.PolicyNo ||
                    (this.PolicyNo != null &&
                    this.PolicyNo.Equals(input.PolicyNo))
                ) && 
                (
                    this.DateofLoss == input.DateofLoss ||
                    (this.DateofLoss != null &&
                    this.DateofLoss.Equals(input.DateofLoss))
                ) && 
                (
                    this.ClaimNumber == input.ClaimNumber ||
                    (this.ClaimNumber != null &&
                    this.ClaimNumber.Equals(input.ClaimNumber))
                ) && 
                (
                    this.ClaimStatus == input.ClaimStatus ||
                    (this.ClaimStatus != null &&
                    this.ClaimStatus.Equals(input.ClaimStatus))
                ) && 
                (
                    this.ClaimStatusDate == input.ClaimStatusDate ||
                    (this.ClaimStatusDate != null &&
                    this.ClaimStatusDate.Equals(input.ClaimStatusDate))
                ) && 
                (
                    this.RepudiationReason == input.RepudiationReason ||
                    (this.RepudiationReason != null &&
                    this.RepudiationReason.Equals(input.RepudiationReason))
                ) && 
                (
                    this.ClaimClass1 == input.ClaimClass1 ||
                    (this.ClaimClass1 != null &&
                    this.ClaimClass1.Equals(input.ClaimClass1))
                ) && 
                (
                    this.CauseofLoss1 == input.CauseofLoss1 ||
                    (this.CauseofLoss1 != null &&
                    this.CauseofLoss1.Equals(input.CauseofLoss1))
                ) && 
                (
                    this.InitialAmount1 == input.InitialAmount1 ||
                    (this.InitialAmount1 != null &&
                    this.InitialAmount1.Equals(input.InitialAmount1))
                ) && 
                (
                    this.FinalAmount1 == input.FinalAmount1 ||
                    (this.FinalAmount1 != null &&
                    this.FinalAmount1.Equals(input.FinalAmount1))
                ) && 
                (
                    this.ClaimClass2 == input.ClaimClass2 ||
                    (this.ClaimClass2 != null &&
                    this.ClaimClass2.Equals(input.ClaimClass2))
                ) && 
                (
                    this.CauseofLoss2 == input.CauseofLoss2 ||
                    (this.CauseofLoss2 != null &&
                    this.CauseofLoss2.Equals(input.CauseofLoss2))
                ) && 
                (
                    this.InitialAmount2 == input.InitialAmount2 ||
                    (this.InitialAmount2 != null &&
                    this.InitialAmount2.Equals(input.InitialAmount2))
                ) && 
                (
                    this.FinalAmount2 == input.FinalAmount2 ||
                    (this.FinalAmount2 != null &&
                    this.FinalAmount2.Equals(input.FinalAmount2))
                ) && 
                (
                    this.ClaimClass3 == input.ClaimClass3 ||
                    (this.ClaimClass3 != null &&
                    this.ClaimClass3.Equals(input.ClaimClass3))
                ) && 
                (
                    this.CauseofLoss3 == input.CauseofLoss3 ||
                    (this.CauseofLoss3 != null &&
                    this.CauseofLoss3.Equals(input.CauseofLoss3))
                ) && 
                (
                    this.InitialAmount3 == input.InitialAmount3 ||
                    (this.InitialAmount3 != null &&
                    this.InitialAmount3.Equals(input.InitialAmount3))
                ) && 
                (
                    this.FinalAmount3 == input.FinalAmount3 ||
                    (this.FinalAmount3 != null &&
                    this.FinalAmount3.Equals(input.FinalAmount3))
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
                if (this.ClaimIndicator != null)
                    hashCode = hashCode * 59 + this.ClaimIndicator.GetHashCode();
                if (this.RequestIndicator != null)
                    hashCode = hashCode * 59 + this.RequestIndicator.GetHashCode();
                if (this.InsurerName != null)
                    hashCode = hashCode * 59 + this.InsurerName.GetHashCode();
                if (this.PolicyNo != null)
                    hashCode = hashCode * 59 + this.PolicyNo.GetHashCode();
                if (this.DateofLoss != null)
                    hashCode = hashCode * 59 + this.DateofLoss.GetHashCode();
                if (this.ClaimNumber != null)
                    hashCode = hashCode * 59 + this.ClaimNumber.GetHashCode();
                if (this.ClaimStatus != null)
                    hashCode = hashCode * 59 + this.ClaimStatus.GetHashCode();
                if (this.ClaimStatusDate != null)
                    hashCode = hashCode * 59 + this.ClaimStatusDate.GetHashCode();
                if (this.RepudiationReason != null)
                    hashCode = hashCode * 59 + this.RepudiationReason.GetHashCode();
                if (this.ClaimClass1 != null)
                    hashCode = hashCode * 59 + this.ClaimClass1.GetHashCode();
                if (this.CauseofLoss1 != null)
                    hashCode = hashCode * 59 + this.CauseofLoss1.GetHashCode();
                if (this.InitialAmount1 != null)
                    hashCode = hashCode * 59 + this.InitialAmount1.GetHashCode();
                if (this.FinalAmount1 != null)
                    hashCode = hashCode * 59 + this.FinalAmount1.GetHashCode();
                if (this.ClaimClass2 != null)
                    hashCode = hashCode * 59 + this.ClaimClass2.GetHashCode();
                if (this.CauseofLoss2 != null)
                    hashCode = hashCode * 59 + this.CauseofLoss2.GetHashCode();
                if (this.InitialAmount2 != null)
                    hashCode = hashCode * 59 + this.InitialAmount2.GetHashCode();
                if (this.FinalAmount2 != null)
                    hashCode = hashCode * 59 + this.FinalAmount2.GetHashCode();
                if (this.ClaimClass3 != null)
                    hashCode = hashCode * 59 + this.ClaimClass3.GetHashCode();
                if (this.CauseofLoss3 != null)
                    hashCode = hashCode * 59 + this.CauseofLoss3.GetHashCode();
                if (this.InitialAmount3 != null)
                    hashCode = hashCode * 59 + this.InitialAmount3.GetHashCode();
                if (this.FinalAmount3 != null)
                    hashCode = hashCode * 59 + this.FinalAmount3.GetHashCode();
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
