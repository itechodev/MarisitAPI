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
    /// TransunionCommercialBusinessRescueDetail
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialBusinessRescueDetail :  IEquatable<TransunionCommercialBusinessRescueDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialBusinessRescueDetail" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="registrationInfoDate">registrationInfoDate.</param>
        /// <param name="registrationStatusCode">registrationStatusCode.</param>
        /// <param name="businessRescueType">businessRescueType.</param>
        /// <param name="practitionerName">practitionerName.</param>
        /// <param name="practitionerDate">practitionerDate.</param>
        /// <param name="practitionerContactDetails">practitionerContactDetails.</param>
        /// <param name="rescuePlan">rescuePlan.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="businessRescueDate">businessRescueDate.</param>
        /// <param name="businessRescueComment">businessRescueComment.</param>
        public TransunionCommercialBusinessRescueDetail(string majorProduct = default(string), string registrationInfoDate = default(string), string registrationStatusCode = default(string), string businessRescueType = default(string), string practitionerName = default(string), string practitionerDate = default(string), string practitionerContactDetails = default(string), string rescuePlan = default(string), string endDate = default(string), string businessRescueDate = default(string), string businessRescueComment = default(string))
        {
            this.MajorProduct = majorProduct;
            this.RegistrationInfoDate = registrationInfoDate;
            this.RegistrationStatusCode = registrationStatusCode;
            this.BusinessRescueType = businessRescueType;
            this.PractitionerName = practitionerName;
            this.PractitionerDate = practitionerDate;
            this.PractitionerContactDetails = practitionerContactDetails;
            this.RescuePlan = rescuePlan;
            this.EndDate = endDate;
            this.BusinessRescueDate = businessRescueDate;
            this.BusinessRescueComment = businessRescueComment;
            this.MajorProduct = majorProduct;
            this.RegistrationInfoDate = registrationInfoDate;
            this.RegistrationStatusCode = registrationStatusCode;
            this.BusinessRescueType = businessRescueType;
            this.PractitionerName = practitionerName;
            this.PractitionerDate = practitionerDate;
            this.PractitionerContactDetails = practitionerContactDetails;
            this.RescuePlan = rescuePlan;
            this.EndDate = endDate;
            this.BusinessRescueDate = businessRescueDate;
            this.BusinessRescueComment = businessRescueComment;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationInfoDate
        /// </summary>
        [DataMember(Name="registrationInfoDate", EmitDefaultValue=true)]
        public string RegistrationInfoDate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationStatusCode
        /// </summary>
        [DataMember(Name="registrationStatusCode", EmitDefaultValue=true)]
        public string RegistrationStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets BusinessRescueType
        /// </summary>
        [DataMember(Name="businessRescueType", EmitDefaultValue=true)]
        public string BusinessRescueType { get; set; }

        /// <summary>
        /// Gets or Sets PractitionerName
        /// </summary>
        [DataMember(Name="practitionerName", EmitDefaultValue=true)]
        public string PractitionerName { get; set; }

        /// <summary>
        /// Gets or Sets PractitionerDate
        /// </summary>
        [DataMember(Name="practitionerDate", EmitDefaultValue=true)]
        public string PractitionerDate { get; set; }

        /// <summary>
        /// Gets or Sets PractitionerContactDetails
        /// </summary>
        [DataMember(Name="practitionerContactDetails", EmitDefaultValue=true)]
        public string PractitionerContactDetails { get; set; }

        /// <summary>
        /// Gets or Sets RescuePlan
        /// </summary>
        [DataMember(Name="rescuePlan", EmitDefaultValue=true)]
        public string RescuePlan { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=true)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets BusinessRescueDate
        /// </summary>
        [DataMember(Name="businessRescueDate", EmitDefaultValue=true)]
        public string BusinessRescueDate { get; set; }

        /// <summary>
        /// Gets or Sets BusinessRescueComment
        /// </summary>
        [DataMember(Name="businessRescueComment", EmitDefaultValue=true)]
        public string BusinessRescueComment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialBusinessRescueDetail {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  RegistrationInfoDate: ").Append(RegistrationInfoDate).Append("\n");
            sb.Append("  RegistrationStatusCode: ").Append(RegistrationStatusCode).Append("\n");
            sb.Append("  BusinessRescueType: ").Append(BusinessRescueType).Append("\n");
            sb.Append("  PractitionerName: ").Append(PractitionerName).Append("\n");
            sb.Append("  PractitionerDate: ").Append(PractitionerDate).Append("\n");
            sb.Append("  PractitionerContactDetails: ").Append(PractitionerContactDetails).Append("\n");
            sb.Append("  RescuePlan: ").Append(RescuePlan).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  BusinessRescueDate: ").Append(BusinessRescueDate).Append("\n");
            sb.Append("  BusinessRescueComment: ").Append(BusinessRescueComment).Append("\n");
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
            return this.Equals(input as TransunionCommercialBusinessRescueDetail);
        }

        /// <summary>
        /// Returns true if TransunionCommercialBusinessRescueDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialBusinessRescueDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialBusinessRescueDetail input)
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
                    this.RegistrationInfoDate == input.RegistrationInfoDate ||
                    (this.RegistrationInfoDate != null &&
                    this.RegistrationInfoDate.Equals(input.RegistrationInfoDate))
                ) && 
                (
                    this.RegistrationStatusCode == input.RegistrationStatusCode ||
                    (this.RegistrationStatusCode != null &&
                    this.RegistrationStatusCode.Equals(input.RegistrationStatusCode))
                ) && 
                (
                    this.BusinessRescueType == input.BusinessRescueType ||
                    (this.BusinessRescueType != null &&
                    this.BusinessRescueType.Equals(input.BusinessRescueType))
                ) && 
                (
                    this.PractitionerName == input.PractitionerName ||
                    (this.PractitionerName != null &&
                    this.PractitionerName.Equals(input.PractitionerName))
                ) && 
                (
                    this.PractitionerDate == input.PractitionerDate ||
                    (this.PractitionerDate != null &&
                    this.PractitionerDate.Equals(input.PractitionerDate))
                ) && 
                (
                    this.PractitionerContactDetails == input.PractitionerContactDetails ||
                    (this.PractitionerContactDetails != null &&
                    this.PractitionerContactDetails.Equals(input.PractitionerContactDetails))
                ) && 
                (
                    this.RescuePlan == input.RescuePlan ||
                    (this.RescuePlan != null &&
                    this.RescuePlan.Equals(input.RescuePlan))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.BusinessRescueDate == input.BusinessRescueDate ||
                    (this.BusinessRescueDate != null &&
                    this.BusinessRescueDate.Equals(input.BusinessRescueDate))
                ) && 
                (
                    this.BusinessRescueComment == input.BusinessRescueComment ||
                    (this.BusinessRescueComment != null &&
                    this.BusinessRescueComment.Equals(input.BusinessRescueComment))
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
                if (this.RegistrationInfoDate != null)
                    hashCode = hashCode * 59 + this.RegistrationInfoDate.GetHashCode();
                if (this.RegistrationStatusCode != null)
                    hashCode = hashCode * 59 + this.RegistrationStatusCode.GetHashCode();
                if (this.BusinessRescueType != null)
                    hashCode = hashCode * 59 + this.BusinessRescueType.GetHashCode();
                if (this.PractitionerName != null)
                    hashCode = hashCode * 59 + this.PractitionerName.GetHashCode();
                if (this.PractitionerDate != null)
                    hashCode = hashCode * 59 + this.PractitionerDate.GetHashCode();
                if (this.PractitionerContactDetails != null)
                    hashCode = hashCode * 59 + this.PractitionerContactDetails.GetHashCode();
                if (this.RescuePlan != null)
                    hashCode = hashCode * 59 + this.RescuePlan.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.BusinessRescueDate != null)
                    hashCode = hashCode * 59 + this.BusinessRescueDate.GetHashCode();
                if (this.BusinessRescueComment != null)
                    hashCode = hashCode * 59 + this.BusinessRescueComment.GetHashCode();
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
