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
    /// TransunionConsumer118ClaimDetailsCR
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ClaimDetailsCR :  IEquatable<TransunionConsumer118ClaimDetailsCR>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ClaimDetailsCR" /> class.
        /// </summary>
        /// <param name="supplierName">supplierName.</param>
        /// <param name="claimNumber">claimNumber.</param>
        /// <param name="claimSubNumber">claimSubNumber.</param>
        /// <param name="classOfClaim1">classOfClaim1.</param>
        /// <param name="classOfClaim2">classOfClaim2.</param>
        /// <param name="causeOfLoss">causeOfLoss.</param>
        /// <param name="dateOfLoss">dateOfLoss.</param>
        /// <param name="areaOfLoss">areaOfLoss.</param>
        /// <param name="sapsStation">sapsStation.</param>
        /// <param name="sapsCaseNumber">sapsCaseNumber.</param>
        /// <param name="estimatedCostOfClaim">estimatedCostOfClaim.</param>
        /// <param name="costOfClaimGrossSettlement">costOfClaimGrossSettlement.</param>
        /// <param name="costOfClaimNettSettlement">costOfClaimNettSettlement.</param>
        /// <param name="claimStatusDate">claimStatusDate.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="claimStatusRepudiatedIndicator">claimStatusRepudiatedIndicator.</param>
        /// <param name="repudiatedReasonCode">repudiatedReasonCode.</param>
        /// <param name="claimantAtFault">claimantAtFault.</param>
        /// <param name="policyNumber">policyNumber.</param>
        /// <param name="claimPosition1">claimPosition1.</param>
        /// <param name="claimPosition2">claimPosition2.</param>
        /// <param name="claimPosition3">claimPosition3.</param>
        /// <param name="claimPosition4">claimPosition4.</param>
        /// <param name="itemInceptionDate">itemInceptionDate.</param>
        public TransunionConsumer118ClaimDetailsCR(string supplierName = default(string), string claimNumber = default(string), string claimSubNumber = default(string), string classOfClaim1 = default(string), string classOfClaim2 = default(string), string causeOfLoss = default(string), string dateOfLoss = default(string), string areaOfLoss = default(string), string sapsStation = default(string), string sapsCaseNumber = default(string), string estimatedCostOfClaim = default(string), string costOfClaimGrossSettlement = default(string), string costOfClaimNettSettlement = default(string), string claimStatusDate = default(string), string claimStatus = default(string), string claimStatusRepudiatedIndicator = default(string), string repudiatedReasonCode = default(string), string claimantAtFault = default(string), string policyNumber = default(string), string claimPosition1 = default(string), string claimPosition2 = default(string), string claimPosition3 = default(string), string claimPosition4 = default(string), string itemInceptionDate = default(string))
        {
            this.SupplierName = supplierName;
            this.ClaimNumber = claimNumber;
            this.ClaimSubNumber = claimSubNumber;
            this.ClassOfClaim1 = classOfClaim1;
            this.ClassOfClaim2 = classOfClaim2;
            this.CauseOfLoss = causeOfLoss;
            this.DateOfLoss = dateOfLoss;
            this.AreaOfLoss = areaOfLoss;
            this.SapsStation = sapsStation;
            this.SapsCaseNumber = sapsCaseNumber;
            this.EstimatedCostOfClaim = estimatedCostOfClaim;
            this.CostOfClaimGrossSettlement = costOfClaimGrossSettlement;
            this.CostOfClaimNettSettlement = costOfClaimNettSettlement;
            this.ClaimStatusDate = claimStatusDate;
            this.ClaimStatus = claimStatus;
            this.ClaimStatusRepudiatedIndicator = claimStatusRepudiatedIndicator;
            this.RepudiatedReasonCode = repudiatedReasonCode;
            this.ClaimantAtFault = claimantAtFault;
            this.PolicyNumber = policyNumber;
            this.ClaimPosition1 = claimPosition1;
            this.ClaimPosition2 = claimPosition2;
            this.ClaimPosition3 = claimPosition3;
            this.ClaimPosition4 = claimPosition4;
            this.ItemInceptionDate = itemInceptionDate;
            this.SupplierName = supplierName;
            this.ClaimNumber = claimNumber;
            this.ClaimSubNumber = claimSubNumber;
            this.ClassOfClaim1 = classOfClaim1;
            this.ClassOfClaim2 = classOfClaim2;
            this.CauseOfLoss = causeOfLoss;
            this.DateOfLoss = dateOfLoss;
            this.AreaOfLoss = areaOfLoss;
            this.SapsStation = sapsStation;
            this.SapsCaseNumber = sapsCaseNumber;
            this.EstimatedCostOfClaim = estimatedCostOfClaim;
            this.CostOfClaimGrossSettlement = costOfClaimGrossSettlement;
            this.CostOfClaimNettSettlement = costOfClaimNettSettlement;
            this.ClaimStatusDate = claimStatusDate;
            this.ClaimStatus = claimStatus;
            this.ClaimStatusRepudiatedIndicator = claimStatusRepudiatedIndicator;
            this.RepudiatedReasonCode = repudiatedReasonCode;
            this.ClaimantAtFault = claimantAtFault;
            this.PolicyNumber = policyNumber;
            this.ClaimPosition1 = claimPosition1;
            this.ClaimPosition2 = claimPosition2;
            this.ClaimPosition3 = claimPosition3;
            this.ClaimPosition4 = claimPosition4;
            this.ItemInceptionDate = itemInceptionDate;
        }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name="supplierName", EmitDefaultValue=true)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets ClaimNumber
        /// </summary>
        [DataMember(Name="claimNumber", EmitDefaultValue=true)]
        public string ClaimNumber { get; set; }

        /// <summary>
        /// Gets or Sets ClaimSubNumber
        /// </summary>
        [DataMember(Name="claimSubNumber", EmitDefaultValue=true)]
        public string ClaimSubNumber { get; set; }

        /// <summary>
        /// Gets or Sets ClassOfClaim1
        /// </summary>
        [DataMember(Name="classOfClaim1", EmitDefaultValue=true)]
        public string ClassOfClaim1 { get; set; }

        /// <summary>
        /// Gets or Sets ClassOfClaim2
        /// </summary>
        [DataMember(Name="classOfClaim2", EmitDefaultValue=true)]
        public string ClassOfClaim2 { get; set; }

        /// <summary>
        /// Gets or Sets CauseOfLoss
        /// </summary>
        [DataMember(Name="causeOfLoss", EmitDefaultValue=true)]
        public string CauseOfLoss { get; set; }

        /// <summary>
        /// Gets or Sets DateOfLoss
        /// </summary>
        [DataMember(Name="dateOfLoss", EmitDefaultValue=true)]
        public string DateOfLoss { get; set; }

        /// <summary>
        /// Gets or Sets AreaOfLoss
        /// </summary>
        [DataMember(Name="areaOfLoss", EmitDefaultValue=true)]
        public string AreaOfLoss { get; set; }

        /// <summary>
        /// Gets or Sets SapsStation
        /// </summary>
        [DataMember(Name="sapsStation", EmitDefaultValue=true)]
        public string SapsStation { get; set; }

        /// <summary>
        /// Gets or Sets SapsCaseNumber
        /// </summary>
        [DataMember(Name="sapsCaseNumber", EmitDefaultValue=true)]
        public string SapsCaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCostOfClaim
        /// </summary>
        [DataMember(Name="estimatedCostOfClaim", EmitDefaultValue=true)]
        public string EstimatedCostOfClaim { get; set; }

        /// <summary>
        /// Gets or Sets CostOfClaimGrossSettlement
        /// </summary>
        [DataMember(Name="costOfClaimGrossSettlement", EmitDefaultValue=true)]
        public string CostOfClaimGrossSettlement { get; set; }

        /// <summary>
        /// Gets or Sets CostOfClaimNettSettlement
        /// </summary>
        [DataMember(Name="costOfClaimNettSettlement", EmitDefaultValue=true)]
        public string CostOfClaimNettSettlement { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatusDate
        /// </summary>
        [DataMember(Name="claimStatusDate", EmitDefaultValue=true)]
        public string ClaimStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatus
        /// </summary>
        [DataMember(Name="claimStatus", EmitDefaultValue=true)]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatusRepudiatedIndicator
        /// </summary>
        [DataMember(Name="claimStatusRepudiatedIndicator", EmitDefaultValue=true)]
        public string ClaimStatusRepudiatedIndicator { get; set; }

        /// <summary>
        /// Gets or Sets RepudiatedReasonCode
        /// </summary>
        [DataMember(Name="repudiatedReasonCode", EmitDefaultValue=true)]
        public string RepudiatedReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ClaimantAtFault
        /// </summary>
        [DataMember(Name="claimantAtFault", EmitDefaultValue=true)]
        public string ClaimantAtFault { get; set; }

        /// <summary>
        /// Gets or Sets PolicyNumber
        /// </summary>
        [DataMember(Name="policyNumber", EmitDefaultValue=true)]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// Gets or Sets ClaimPosition1
        /// </summary>
        [DataMember(Name="claimPosition1", EmitDefaultValue=true)]
        public string ClaimPosition1 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimPosition2
        /// </summary>
        [DataMember(Name="claimPosition2", EmitDefaultValue=true)]
        public string ClaimPosition2 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimPosition3
        /// </summary>
        [DataMember(Name="claimPosition3", EmitDefaultValue=true)]
        public string ClaimPosition3 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimPosition4
        /// </summary>
        [DataMember(Name="claimPosition4", EmitDefaultValue=true)]
        public string ClaimPosition4 { get; set; }

        /// <summary>
        /// Gets or Sets ItemInceptionDate
        /// </summary>
        [DataMember(Name="itemInceptionDate", EmitDefaultValue=true)]
        public string ItemInceptionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ClaimDetailsCR {\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  ClaimNumber: ").Append(ClaimNumber).Append("\n");
            sb.Append("  ClaimSubNumber: ").Append(ClaimSubNumber).Append("\n");
            sb.Append("  ClassOfClaim1: ").Append(ClassOfClaim1).Append("\n");
            sb.Append("  ClassOfClaim2: ").Append(ClassOfClaim2).Append("\n");
            sb.Append("  CauseOfLoss: ").Append(CauseOfLoss).Append("\n");
            sb.Append("  DateOfLoss: ").Append(DateOfLoss).Append("\n");
            sb.Append("  AreaOfLoss: ").Append(AreaOfLoss).Append("\n");
            sb.Append("  SapsStation: ").Append(SapsStation).Append("\n");
            sb.Append("  SapsCaseNumber: ").Append(SapsCaseNumber).Append("\n");
            sb.Append("  EstimatedCostOfClaim: ").Append(EstimatedCostOfClaim).Append("\n");
            sb.Append("  CostOfClaimGrossSettlement: ").Append(CostOfClaimGrossSettlement).Append("\n");
            sb.Append("  CostOfClaimNettSettlement: ").Append(CostOfClaimNettSettlement).Append("\n");
            sb.Append("  ClaimStatusDate: ").Append(ClaimStatusDate).Append("\n");
            sb.Append("  ClaimStatus: ").Append(ClaimStatus).Append("\n");
            sb.Append("  ClaimStatusRepudiatedIndicator: ").Append(ClaimStatusRepudiatedIndicator).Append("\n");
            sb.Append("  RepudiatedReasonCode: ").Append(RepudiatedReasonCode).Append("\n");
            sb.Append("  ClaimantAtFault: ").Append(ClaimantAtFault).Append("\n");
            sb.Append("  PolicyNumber: ").Append(PolicyNumber).Append("\n");
            sb.Append("  ClaimPosition1: ").Append(ClaimPosition1).Append("\n");
            sb.Append("  ClaimPosition2: ").Append(ClaimPosition2).Append("\n");
            sb.Append("  ClaimPosition3: ").Append(ClaimPosition3).Append("\n");
            sb.Append("  ClaimPosition4: ").Append(ClaimPosition4).Append("\n");
            sb.Append("  ItemInceptionDate: ").Append(ItemInceptionDate).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ClaimDetailsCR);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ClaimDetailsCR instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ClaimDetailsCR to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ClaimDetailsCR input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupplierName == input.SupplierName ||
                    (this.SupplierName != null &&
                    this.SupplierName.Equals(input.SupplierName))
                ) && 
                (
                    this.ClaimNumber == input.ClaimNumber ||
                    (this.ClaimNumber != null &&
                    this.ClaimNumber.Equals(input.ClaimNumber))
                ) && 
                (
                    this.ClaimSubNumber == input.ClaimSubNumber ||
                    (this.ClaimSubNumber != null &&
                    this.ClaimSubNumber.Equals(input.ClaimSubNumber))
                ) && 
                (
                    this.ClassOfClaim1 == input.ClassOfClaim1 ||
                    (this.ClassOfClaim1 != null &&
                    this.ClassOfClaim1.Equals(input.ClassOfClaim1))
                ) && 
                (
                    this.ClassOfClaim2 == input.ClassOfClaim2 ||
                    (this.ClassOfClaim2 != null &&
                    this.ClassOfClaim2.Equals(input.ClassOfClaim2))
                ) && 
                (
                    this.CauseOfLoss == input.CauseOfLoss ||
                    (this.CauseOfLoss != null &&
                    this.CauseOfLoss.Equals(input.CauseOfLoss))
                ) && 
                (
                    this.DateOfLoss == input.DateOfLoss ||
                    (this.DateOfLoss != null &&
                    this.DateOfLoss.Equals(input.DateOfLoss))
                ) && 
                (
                    this.AreaOfLoss == input.AreaOfLoss ||
                    (this.AreaOfLoss != null &&
                    this.AreaOfLoss.Equals(input.AreaOfLoss))
                ) && 
                (
                    this.SapsStation == input.SapsStation ||
                    (this.SapsStation != null &&
                    this.SapsStation.Equals(input.SapsStation))
                ) && 
                (
                    this.SapsCaseNumber == input.SapsCaseNumber ||
                    (this.SapsCaseNumber != null &&
                    this.SapsCaseNumber.Equals(input.SapsCaseNumber))
                ) && 
                (
                    this.EstimatedCostOfClaim == input.EstimatedCostOfClaim ||
                    (this.EstimatedCostOfClaim != null &&
                    this.EstimatedCostOfClaim.Equals(input.EstimatedCostOfClaim))
                ) && 
                (
                    this.CostOfClaimGrossSettlement == input.CostOfClaimGrossSettlement ||
                    (this.CostOfClaimGrossSettlement != null &&
                    this.CostOfClaimGrossSettlement.Equals(input.CostOfClaimGrossSettlement))
                ) && 
                (
                    this.CostOfClaimNettSettlement == input.CostOfClaimNettSettlement ||
                    (this.CostOfClaimNettSettlement != null &&
                    this.CostOfClaimNettSettlement.Equals(input.CostOfClaimNettSettlement))
                ) && 
                (
                    this.ClaimStatusDate == input.ClaimStatusDate ||
                    (this.ClaimStatusDate != null &&
                    this.ClaimStatusDate.Equals(input.ClaimStatusDate))
                ) && 
                (
                    this.ClaimStatus == input.ClaimStatus ||
                    (this.ClaimStatus != null &&
                    this.ClaimStatus.Equals(input.ClaimStatus))
                ) && 
                (
                    this.ClaimStatusRepudiatedIndicator == input.ClaimStatusRepudiatedIndicator ||
                    (this.ClaimStatusRepudiatedIndicator != null &&
                    this.ClaimStatusRepudiatedIndicator.Equals(input.ClaimStatusRepudiatedIndicator))
                ) && 
                (
                    this.RepudiatedReasonCode == input.RepudiatedReasonCode ||
                    (this.RepudiatedReasonCode != null &&
                    this.RepudiatedReasonCode.Equals(input.RepudiatedReasonCode))
                ) && 
                (
                    this.ClaimantAtFault == input.ClaimantAtFault ||
                    (this.ClaimantAtFault != null &&
                    this.ClaimantAtFault.Equals(input.ClaimantAtFault))
                ) && 
                (
                    this.PolicyNumber == input.PolicyNumber ||
                    (this.PolicyNumber != null &&
                    this.PolicyNumber.Equals(input.PolicyNumber))
                ) && 
                (
                    this.ClaimPosition1 == input.ClaimPosition1 ||
                    (this.ClaimPosition1 != null &&
                    this.ClaimPosition1.Equals(input.ClaimPosition1))
                ) && 
                (
                    this.ClaimPosition2 == input.ClaimPosition2 ||
                    (this.ClaimPosition2 != null &&
                    this.ClaimPosition2.Equals(input.ClaimPosition2))
                ) && 
                (
                    this.ClaimPosition3 == input.ClaimPosition3 ||
                    (this.ClaimPosition3 != null &&
                    this.ClaimPosition3.Equals(input.ClaimPosition3))
                ) && 
                (
                    this.ClaimPosition4 == input.ClaimPosition4 ||
                    (this.ClaimPosition4 != null &&
                    this.ClaimPosition4.Equals(input.ClaimPosition4))
                ) && 
                (
                    this.ItemInceptionDate == input.ItemInceptionDate ||
                    (this.ItemInceptionDate != null &&
                    this.ItemInceptionDate.Equals(input.ItemInceptionDate))
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
                if (this.SupplierName != null)
                    hashCode = hashCode * 59 + this.SupplierName.GetHashCode();
                if (this.ClaimNumber != null)
                    hashCode = hashCode * 59 + this.ClaimNumber.GetHashCode();
                if (this.ClaimSubNumber != null)
                    hashCode = hashCode * 59 + this.ClaimSubNumber.GetHashCode();
                if (this.ClassOfClaim1 != null)
                    hashCode = hashCode * 59 + this.ClassOfClaim1.GetHashCode();
                if (this.ClassOfClaim2 != null)
                    hashCode = hashCode * 59 + this.ClassOfClaim2.GetHashCode();
                if (this.CauseOfLoss != null)
                    hashCode = hashCode * 59 + this.CauseOfLoss.GetHashCode();
                if (this.DateOfLoss != null)
                    hashCode = hashCode * 59 + this.DateOfLoss.GetHashCode();
                if (this.AreaOfLoss != null)
                    hashCode = hashCode * 59 + this.AreaOfLoss.GetHashCode();
                if (this.SapsStation != null)
                    hashCode = hashCode * 59 + this.SapsStation.GetHashCode();
                if (this.SapsCaseNumber != null)
                    hashCode = hashCode * 59 + this.SapsCaseNumber.GetHashCode();
                if (this.EstimatedCostOfClaim != null)
                    hashCode = hashCode * 59 + this.EstimatedCostOfClaim.GetHashCode();
                if (this.CostOfClaimGrossSettlement != null)
                    hashCode = hashCode * 59 + this.CostOfClaimGrossSettlement.GetHashCode();
                if (this.CostOfClaimNettSettlement != null)
                    hashCode = hashCode * 59 + this.CostOfClaimNettSettlement.GetHashCode();
                if (this.ClaimStatusDate != null)
                    hashCode = hashCode * 59 + this.ClaimStatusDate.GetHashCode();
                if (this.ClaimStatus != null)
                    hashCode = hashCode * 59 + this.ClaimStatus.GetHashCode();
                if (this.ClaimStatusRepudiatedIndicator != null)
                    hashCode = hashCode * 59 + this.ClaimStatusRepudiatedIndicator.GetHashCode();
                if (this.RepudiatedReasonCode != null)
                    hashCode = hashCode * 59 + this.RepudiatedReasonCode.GetHashCode();
                if (this.ClaimantAtFault != null)
                    hashCode = hashCode * 59 + this.ClaimantAtFault.GetHashCode();
                if (this.PolicyNumber != null)
                    hashCode = hashCode * 59 + this.PolicyNumber.GetHashCode();
                if (this.ClaimPosition1 != null)
                    hashCode = hashCode * 59 + this.ClaimPosition1.GetHashCode();
                if (this.ClaimPosition2 != null)
                    hashCode = hashCode * 59 + this.ClaimPosition2.GetHashCode();
                if (this.ClaimPosition3 != null)
                    hashCode = hashCode * 59 + this.ClaimPosition3.GetHashCode();
                if (this.ClaimPosition4 != null)
                    hashCode = hashCode * 59 + this.ClaimPosition4.GetHashCode();
                if (this.ItemInceptionDate != null)
                    hashCode = hashCode * 59 + this.ItemInceptionDate.GetHashCode();
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
