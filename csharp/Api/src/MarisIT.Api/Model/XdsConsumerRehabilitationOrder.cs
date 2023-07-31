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
    /// XdsConsumerRehabilitationOrder
    /// </summary>
    [DataContract]
    public partial class XdsConsumerRehabilitationOrder :  IEquatable<XdsConsumerRehabilitationOrder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumerRehabilitationOrder" /> class.
        /// </summary>
        /// <param name="attorneyName">attorneyName.</param>
        /// <param name="caseFilingDate">caseFilingDate.</param>
        /// <param name="caseNumber">caseNumber.</param>
        /// <param name="caseReason">caseReason.</param>
        /// <param name="caseType">caseType.</param>
        /// <param name="comments">comments.</param>
        /// <param name="courtName">courtName.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="disputeAmt">disputeAmt.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        /// <param name="plaintiffName">plaintiffName.</param>
        /// <param name="telephoneNo">telephoneNo.</param>
        public XdsConsumerRehabilitationOrder(string attorneyName = default(string), string caseFilingDate = default(string), string caseNumber = default(string), string caseReason = default(string), string caseType = default(string), string comments = default(string), string courtName = default(string), string displayText = default(string), string disputeAmt = default(string), string lastUpdatedDate = default(string), string plaintiffName = default(string), string telephoneNo = default(string))
        {
            this.AttorneyName = attorneyName;
            this.CaseFilingDate = caseFilingDate;
            this.CaseNumber = caseNumber;
            this.CaseReason = caseReason;
            this.CaseType = caseType;
            this.Comments = comments;
            this.CourtName = courtName;
            this.DisplayText = displayText;
            this.DisputeAmt = disputeAmt;
            this.LastUpdatedDate = lastUpdatedDate;
            this.PlaintiffName = plaintiffName;
            this.TelephoneNo = telephoneNo;
            this.AttorneyName = attorneyName;
            this.CaseFilingDate = caseFilingDate;
            this.CaseNumber = caseNumber;
            this.CaseReason = caseReason;
            this.CaseType = caseType;
            this.Comments = comments;
            this.CourtName = courtName;
            this.DisplayText = displayText;
            this.DisputeAmt = disputeAmt;
            this.LastUpdatedDate = lastUpdatedDate;
            this.PlaintiffName = plaintiffName;
            this.TelephoneNo = telephoneNo;
        }

        /// <summary>
        /// Gets or Sets AttorneyName
        /// </summary>
        [DataMember(Name="attorneyName", EmitDefaultValue=true)]
        public string AttorneyName { get; set; }

        /// <summary>
        /// Gets or Sets CaseFilingDate
        /// </summary>
        [DataMember(Name="caseFilingDate", EmitDefaultValue=true)]
        public string CaseFilingDate { get; set; }

        /// <summary>
        /// Gets or Sets CaseNumber
        /// </summary>
        [DataMember(Name="caseNumber", EmitDefaultValue=true)]
        public string CaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets CaseReason
        /// </summary>
        [DataMember(Name="caseReason", EmitDefaultValue=true)]
        public string CaseReason { get; set; }

        /// <summary>
        /// Gets or Sets CaseType
        /// </summary>
        [DataMember(Name="caseType", EmitDefaultValue=true)]
        public string CaseType { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets CourtName
        /// </summary>
        [DataMember(Name="courtName", EmitDefaultValue=true)]
        public string CourtName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets DisputeAmt
        /// </summary>
        [DataMember(Name="disputeAmt", EmitDefaultValue=true)]
        public string DisputeAmt { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=true)]
        public string LastUpdatedDate { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumerRehabilitationOrder {\n");
            sb.Append("  AttorneyName: ").Append(AttorneyName).Append("\n");
            sb.Append("  CaseFilingDate: ").Append(CaseFilingDate).Append("\n");
            sb.Append("  CaseNumber: ").Append(CaseNumber).Append("\n");
            sb.Append("  CaseReason: ").Append(CaseReason).Append("\n");
            sb.Append("  CaseType: ").Append(CaseType).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CourtName: ").Append(CourtName).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  DisputeAmt: ").Append(DisputeAmt).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  PlaintiffName: ").Append(PlaintiffName).Append("\n");
            sb.Append("  TelephoneNo: ").Append(TelephoneNo).Append("\n");
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
            return this.Equals(input as XdsConsumerRehabilitationOrder);
        }

        /// <summary>
        /// Returns true if XdsConsumerRehabilitationOrder instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumerRehabilitationOrder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumerRehabilitationOrder input)
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
                    this.CaseFilingDate == input.CaseFilingDate ||
                    (this.CaseFilingDate != null &&
                    this.CaseFilingDate.Equals(input.CaseFilingDate))
                ) && 
                (
                    this.CaseNumber == input.CaseNumber ||
                    (this.CaseNumber != null &&
                    this.CaseNumber.Equals(input.CaseNumber))
                ) && 
                (
                    this.CaseReason == input.CaseReason ||
                    (this.CaseReason != null &&
                    this.CaseReason.Equals(input.CaseReason))
                ) && 
                (
                    this.CaseType == input.CaseType ||
                    (this.CaseType != null &&
                    this.CaseType.Equals(input.CaseType))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CourtName == input.CourtName ||
                    (this.CourtName != null &&
                    this.CourtName.Equals(input.CourtName))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.DisputeAmt == input.DisputeAmt ||
                    (this.DisputeAmt != null &&
                    this.DisputeAmt.Equals(input.DisputeAmt))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
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
                if (this.CaseFilingDate != null)
                    hashCode = hashCode * 59 + this.CaseFilingDate.GetHashCode();
                if (this.CaseNumber != null)
                    hashCode = hashCode * 59 + this.CaseNumber.GetHashCode();
                if (this.CaseReason != null)
                    hashCode = hashCode * 59 + this.CaseReason.GetHashCode();
                if (this.CaseType != null)
                    hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CourtName != null)
                    hashCode = hashCode * 59 + this.CourtName.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.DisputeAmt != null)
                    hashCode = hashCode * 59 + this.DisputeAmt.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.PlaintiffName != null)
                    hashCode = hashCode * 59 + this.PlaintiffName.GetHashCode();
                if (this.TelephoneNo != null)
                    hashCode = hashCode * 59 + this.TelephoneNo.GetHashCode();
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