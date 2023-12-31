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
    /// XdsJudgment
    /// </summary>
    [DataContract]
    public partial class XdsJudgment :  IEquatable<XdsJudgment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsJudgment" /> class.
        /// </summary>
        /// <param name="attorneyName">attorneyName.</param>
        /// <param name="_case">_case.</param>
        /// <param name="caseFilingDate">caseFilingDate.</param>
        /// <param name="caseType">caseType.</param>
        /// <param name="plaintiffName">plaintiffName.</param>
        /// <param name="telephoneNo">telephoneNo.</param>
        /// <param name="caseReason">caseReason.</param>
        /// <param name="plaintiffContactNo">plaintiffContactNo.</param>
        /// <param name="plaintiffRegNo">plaintiffRegNo.</param>
        /// <param name="plaintiffSurname">plaintiffSurname.</param>
        /// <param name="creationDate">creationDate.</param>
        /// <param name="caseNumber">caseNumber.</param>
        /// <param name="courtName">courtName.</param>
        /// <param name="commercialName">commercialName.</param>
        /// <param name="dateLoaded">dateLoaded.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="disputeAmount">disputeAmount.</param>
        /// <param name="disputeAmt">disputeAmt.</param>
        /// <param name="comments">comments.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        public XdsJudgment(string attorneyName = default(string), string _case = default(string), string caseFilingDate = default(string), string caseType = default(string), string plaintiffName = default(string), string telephoneNo = default(string), string caseReason = default(string), string plaintiffContactNo = default(string), string plaintiffRegNo = default(string), string plaintiffSurname = default(string), string creationDate = default(string), string caseNumber = default(string), string courtName = default(string), string commercialName = default(string), string dateLoaded = default(string), string displayText = default(string), string disputeAmount = default(string), string disputeAmt = default(string), string comments = default(string), string lastUpdatedDate = default(string))
        {
            this.AttorneyName = attorneyName;
            this.Case = _case;
            this.CaseFilingDate = caseFilingDate;
            this.CaseType = caseType;
            this.PlaintiffName = plaintiffName;
            this.TelephoneNo = telephoneNo;
            this.CaseReason = caseReason;
            this.PlaintiffContactNo = plaintiffContactNo;
            this.PlaintiffRegNo = plaintiffRegNo;
            this.PlaintiffSurname = plaintiffSurname;
            this.CreationDate = creationDate;
            this.CaseNumber = caseNumber;
            this.CourtName = courtName;
            this.CommercialName = commercialName;
            this.DateLoaded = dateLoaded;
            this.DisplayText = displayText;
            this.DisputeAmount = disputeAmount;
            this.DisputeAmt = disputeAmt;
            this.Comments = comments;
            this.LastUpdatedDate = lastUpdatedDate;
            this.AttorneyName = attorneyName;
            this.Case = _case;
            this.CaseFilingDate = caseFilingDate;
            this.CaseType = caseType;
            this.PlaintiffName = plaintiffName;
            this.TelephoneNo = telephoneNo;
            this.CaseReason = caseReason;
            this.PlaintiffContactNo = plaintiffContactNo;
            this.PlaintiffRegNo = plaintiffRegNo;
            this.PlaintiffSurname = plaintiffSurname;
            this.CreationDate = creationDate;
            this.CaseNumber = caseNumber;
            this.CourtName = courtName;
            this.CommercialName = commercialName;
            this.DateLoaded = dateLoaded;
            this.DisplayText = displayText;
            this.DisputeAmount = disputeAmount;
            this.DisputeAmt = disputeAmt;
            this.Comments = comments;
            this.LastUpdatedDate = lastUpdatedDate;
        }

        /// <summary>
        /// Gets or Sets AttorneyName
        /// </summary>
        [DataMember(Name="attorneyName", EmitDefaultValue=true)]
        public string AttorneyName { get; set; }

        /// <summary>
        /// Gets or Sets Case
        /// </summary>
        [DataMember(Name="case", EmitDefaultValue=true)]
        public string Case { get; set; }

        /// <summary>
        /// Gets or Sets CaseFilingDate
        /// </summary>
        [DataMember(Name="caseFilingDate", EmitDefaultValue=true)]
        public string CaseFilingDate { get; set; }

        /// <summary>
        /// Gets or Sets CaseType
        /// </summary>
        [DataMember(Name="caseType", EmitDefaultValue=true)]
        public string CaseType { get; set; }

        /// <summary>
        /// Gets or Sets PlaintiffName
        /// </summary>
        [DataMember(Name="plaintiffName", EmitDefaultValue=true)]
        public string PlaintiffName { get; set; }

        /// <summary>
        /// Gets or Sets TelephoneNo
        /// </summary>
        [DataMember(Name="telephoneNo", EmitDefaultValue=true)]
        public string TelephoneNo { get; set; }

        /// <summary>
        /// Gets or Sets CaseReason
        /// </summary>
        [DataMember(Name="caseReason", EmitDefaultValue=true)]
        public string CaseReason { get; set; }

        /// <summary>
        /// Gets or Sets PlaintiffContactNo
        /// </summary>
        [DataMember(Name="plaintiffContactNo", EmitDefaultValue=true)]
        public string PlaintiffContactNo { get; set; }

        /// <summary>
        /// Gets or Sets PlaintiffRegNo
        /// </summary>
        [DataMember(Name="plaintiffRegNo", EmitDefaultValue=true)]
        public string PlaintiffRegNo { get; set; }

        /// <summary>
        /// Gets or Sets PlaintiffSurname
        /// </summary>
        [DataMember(Name="plaintiffSurname", EmitDefaultValue=true)]
        public string PlaintiffSurname { get; set; }

        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets CaseNumber
        /// </summary>
        [DataMember(Name="caseNumber", EmitDefaultValue=true)]
        public string CaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets CourtName
        /// </summary>
        [DataMember(Name="courtName", EmitDefaultValue=true)]
        public string CourtName { get; set; }

        /// <summary>
        /// Gets or Sets CommercialName
        /// </summary>
        [DataMember(Name="commercialName", EmitDefaultValue=true)]
        public string CommercialName { get; set; }

        /// <summary>
        /// Gets or Sets DateLoaded
        /// </summary>
        [DataMember(Name="dateLoaded", EmitDefaultValue=true)]
        public string DateLoaded { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets DisputeAmount
        /// </summary>
        [DataMember(Name="disputeAmount", EmitDefaultValue=true)]
        public string DisputeAmount { get; set; }

        /// <summary>
        /// Gets or Sets DisputeAmt
        /// </summary>
        [DataMember(Name="disputeAmt", EmitDefaultValue=true)]
        public string DisputeAmt { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=true)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsJudgment {\n");
            sb.Append("  AttorneyName: ").Append(AttorneyName).Append("\n");
            sb.Append("  Case: ").Append(Case).Append("\n");
            sb.Append("  CaseFilingDate: ").Append(CaseFilingDate).Append("\n");
            sb.Append("  CaseType: ").Append(CaseType).Append("\n");
            sb.Append("  PlaintiffName: ").Append(PlaintiffName).Append("\n");
            sb.Append("  TelephoneNo: ").Append(TelephoneNo).Append("\n");
            sb.Append("  CaseReason: ").Append(CaseReason).Append("\n");
            sb.Append("  PlaintiffContactNo: ").Append(PlaintiffContactNo).Append("\n");
            sb.Append("  PlaintiffRegNo: ").Append(PlaintiffRegNo).Append("\n");
            sb.Append("  PlaintiffSurname: ").Append(PlaintiffSurname).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  CaseNumber: ").Append(CaseNumber).Append("\n");
            sb.Append("  CourtName: ").Append(CourtName).Append("\n");
            sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
            sb.Append("  DateLoaded: ").Append(DateLoaded).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  DisputeAmount: ").Append(DisputeAmount).Append("\n");
            sb.Append("  DisputeAmt: ").Append(DisputeAmt).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
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
            return this.Equals(input as XdsJudgment);
        }

        /// <summary>
        /// Returns true if XdsJudgment instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsJudgment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsJudgment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttorneyName == input.AttorneyName ||
                    (this.AttorneyName != null &&
                    this.AttorneyName.Equals(input.AttorneyName))
                ) && 
                (
                    this.Case == input.Case ||
                    (this.Case != null &&
                    this.Case.Equals(input.Case))
                ) && 
                (
                    this.CaseFilingDate == input.CaseFilingDate ||
                    (this.CaseFilingDate != null &&
                    this.CaseFilingDate.Equals(input.CaseFilingDate))
                ) && 
                (
                    this.CaseType == input.CaseType ||
                    (this.CaseType != null &&
                    this.CaseType.Equals(input.CaseType))
                ) && 
                (
                    this.PlaintiffName == input.PlaintiffName ||
                    (this.PlaintiffName != null &&
                    this.PlaintiffName.Equals(input.PlaintiffName))
                ) && 
                (
                    this.TelephoneNo == input.TelephoneNo ||
                    (this.TelephoneNo != null &&
                    this.TelephoneNo.Equals(input.TelephoneNo))
                ) && 
                (
                    this.CaseReason == input.CaseReason ||
                    (this.CaseReason != null &&
                    this.CaseReason.Equals(input.CaseReason))
                ) && 
                (
                    this.PlaintiffContactNo == input.PlaintiffContactNo ||
                    (this.PlaintiffContactNo != null &&
                    this.PlaintiffContactNo.Equals(input.PlaintiffContactNo))
                ) && 
                (
                    this.PlaintiffRegNo == input.PlaintiffRegNo ||
                    (this.PlaintiffRegNo != null &&
                    this.PlaintiffRegNo.Equals(input.PlaintiffRegNo))
                ) && 
                (
                    this.PlaintiffSurname == input.PlaintiffSurname ||
                    (this.PlaintiffSurname != null &&
                    this.PlaintiffSurname.Equals(input.PlaintiffSurname))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.CaseNumber == input.CaseNumber ||
                    (this.CaseNumber != null &&
                    this.CaseNumber.Equals(input.CaseNumber))
                ) && 
                (
                    this.CourtName == input.CourtName ||
                    (this.CourtName != null &&
                    this.CourtName.Equals(input.CourtName))
                ) && 
                (
                    this.CommercialName == input.CommercialName ||
                    (this.CommercialName != null &&
                    this.CommercialName.Equals(input.CommercialName))
                ) && 
                (
                    this.DateLoaded == input.DateLoaded ||
                    (this.DateLoaded != null &&
                    this.DateLoaded.Equals(input.DateLoaded))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.DisputeAmount == input.DisputeAmount ||
                    (this.DisputeAmount != null &&
                    this.DisputeAmount.Equals(input.DisputeAmount))
                ) && 
                (
                    this.DisputeAmt == input.DisputeAmt ||
                    (this.DisputeAmt != null &&
                    this.DisputeAmt.Equals(input.DisputeAmt))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
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
                if (this.AttorneyName != null)
                    hashCode = hashCode * 59 + this.AttorneyName.GetHashCode();
                if (this.Case != null)
                    hashCode = hashCode * 59 + this.Case.GetHashCode();
                if (this.CaseFilingDate != null)
                    hashCode = hashCode * 59 + this.CaseFilingDate.GetHashCode();
                if (this.CaseType != null)
                    hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.PlaintiffName != null)
                    hashCode = hashCode * 59 + this.PlaintiffName.GetHashCode();
                if (this.TelephoneNo != null)
                    hashCode = hashCode * 59 + this.TelephoneNo.GetHashCode();
                if (this.CaseReason != null)
                    hashCode = hashCode * 59 + this.CaseReason.GetHashCode();
                if (this.PlaintiffContactNo != null)
                    hashCode = hashCode * 59 + this.PlaintiffContactNo.GetHashCode();
                if (this.PlaintiffRegNo != null)
                    hashCode = hashCode * 59 + this.PlaintiffRegNo.GetHashCode();
                if (this.PlaintiffSurname != null)
                    hashCode = hashCode * 59 + this.PlaintiffSurname.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CaseNumber != null)
                    hashCode = hashCode * 59 + this.CaseNumber.GetHashCode();
                if (this.CourtName != null)
                    hashCode = hashCode * 59 + this.CourtName.GetHashCode();
                if (this.CommercialName != null)
                    hashCode = hashCode * 59 + this.CommercialName.GetHashCode();
                if (this.DateLoaded != null)
                    hashCode = hashCode * 59 + this.DateLoaded.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.DisputeAmount != null)
                    hashCode = hashCode * 59 + this.DisputeAmount.GetHashCode();
                if (this.DisputeAmt != null)
                    hashCode = hashCode * 59 + this.DisputeAmt.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
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
