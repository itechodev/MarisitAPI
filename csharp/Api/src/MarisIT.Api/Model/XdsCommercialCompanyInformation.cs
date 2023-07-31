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
    /// XdsCommercialCompanyInformation
    /// </summary>
    [DataContract]
    public partial class XdsCommercialCompanyInformation :  IEquatable<XdsCommercialCompanyInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsCommercialCompanyInformation" /> class.
        /// </summary>
        /// <param name="displayText">displayText.</param>
        /// <param name="commercialName">commercialName.</param>
        /// <param name="registrationNo">registrationNo.</param>
        /// <param name="registrationNoOld">registrationNoOld.</param>
        /// <param name="businessStartDate">businessStartDate.</param>
        /// <param name="financialYearEnd">financialYearEnd.</param>
        /// <param name="commercialStatus">commercialStatus.</param>
        /// <param name="commercialType">commercialType.</param>
        /// <param name="sic">sic.</param>
        /// <param name="taxNo">taxNo.</param>
        /// <param name="directorCount">directorCount.</param>
        /// <param name="referenceNo">referenceNo.</param>
        /// <param name="externalReference">externalReference.</param>
        /// <param name="tradeName">tradeName.</param>
        /// <param name="vatNo">vatNo.</param>
        /// <param name="previousBussName">previousBussName.</param>
        /// <param name="nameChangeDate">nameChangeDate.</param>
        /// <param name="bussEmail">bussEmail.</param>
        /// <param name="bussWebsite">bussWebsite.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        public XdsCommercialCompanyInformation(string displayText = default(string), string commercialName = default(string), string registrationNo = default(string), string registrationNoOld = default(string), string businessStartDate = default(string), string financialYearEnd = default(string), string commercialStatus = default(string), string commercialType = default(string), string sic = default(string), string taxNo = default(string), string directorCount = default(string), string referenceNo = default(string), string externalReference = default(string), string tradeName = default(string), string vatNo = default(string), string previousBussName = default(string), string nameChangeDate = default(string), string bussEmail = default(string), string bussWebsite = default(string), string lastUpdatedDate = default(string))
        {
            this.DisplayText = displayText;
            this.CommercialName = commercialName;
            this.RegistrationNo = registrationNo;
            this.RegistrationNoOld = registrationNoOld;
            this.BusinessStartDate = businessStartDate;
            this.FinancialYearEnd = financialYearEnd;
            this.CommercialStatus = commercialStatus;
            this.CommercialType = commercialType;
            this.Sic = sic;
            this.TaxNo = taxNo;
            this.DirectorCount = directorCount;
            this.ReferenceNo = referenceNo;
            this.ExternalReference = externalReference;
            this.TradeName = tradeName;
            this.VatNo = vatNo;
            this.PreviousBussName = previousBussName;
            this.NameChangeDate = nameChangeDate;
            this.BussEmail = bussEmail;
            this.BussWebsite = bussWebsite;
            this.LastUpdatedDate = lastUpdatedDate;
            this.DisplayText = displayText;
            this.CommercialName = commercialName;
            this.RegistrationNo = registrationNo;
            this.RegistrationNoOld = registrationNoOld;
            this.BusinessStartDate = businessStartDate;
            this.FinancialYearEnd = financialYearEnd;
            this.CommercialStatus = commercialStatus;
            this.CommercialType = commercialType;
            this.Sic = sic;
            this.TaxNo = taxNo;
            this.DirectorCount = directorCount;
            this.ReferenceNo = referenceNo;
            this.ExternalReference = externalReference;
            this.TradeName = tradeName;
            this.VatNo = vatNo;
            this.PreviousBussName = previousBussName;
            this.NameChangeDate = nameChangeDate;
            this.BussEmail = bussEmail;
            this.BussWebsite = bussWebsite;
            this.LastUpdatedDate = lastUpdatedDate;
        }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets CommercialName
        /// </summary>
        [DataMember(Name="commercialName", EmitDefaultValue=true)]
        public string CommercialName { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNo
        /// </summary>
        [DataMember(Name="registrationNo", EmitDefaultValue=true)]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNoOld
        /// </summary>
        [DataMember(Name="registrationNoOld", EmitDefaultValue=true)]
        public string RegistrationNoOld { get; set; }

        /// <summary>
        /// Gets or Sets BusinessStartDate
        /// </summary>
        [DataMember(Name="businessStartDate", EmitDefaultValue=true)]
        public string BusinessStartDate { get; set; }

        /// <summary>
        /// Gets or Sets FinancialYearEnd
        /// </summary>
        [DataMember(Name="financialYearEnd", EmitDefaultValue=true)]
        public string FinancialYearEnd { get; set; }

        /// <summary>
        /// Gets or Sets CommercialStatus
        /// </summary>
        [DataMember(Name="commercialStatus", EmitDefaultValue=true)]
        public string CommercialStatus { get; set; }

        /// <summary>
        /// Gets or Sets CommercialType
        /// </summary>
        [DataMember(Name="commercialType", EmitDefaultValue=true)]
        public string CommercialType { get; set; }

        /// <summary>
        /// Gets or Sets Sic
        /// </summary>
        [DataMember(Name="sic", EmitDefaultValue=true)]
        public string Sic { get; set; }

        /// <summary>
        /// Gets or Sets TaxNo
        /// </summary>
        [DataMember(Name="taxNo", EmitDefaultValue=true)]
        public string TaxNo { get; set; }

        /// <summary>
        /// Gets or Sets DirectorCount
        /// </summary>
        [DataMember(Name="directorCount", EmitDefaultValue=true)]
        public string DirectorCount { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNo
        /// </summary>
        [DataMember(Name="referenceNo", EmitDefaultValue=true)]
        public string ReferenceNo { get; set; }

        /// <summary>
        /// Gets or Sets ExternalReference
        /// </summary>
        [DataMember(Name="externalReference", EmitDefaultValue=true)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Gets or Sets TradeName
        /// </summary>
        [DataMember(Name="tradeName", EmitDefaultValue=true)]
        public string TradeName { get; set; }

        /// <summary>
        /// Gets or Sets VatNo
        /// </summary>
        [DataMember(Name="vatNo", EmitDefaultValue=true)]
        public string VatNo { get; set; }

        /// <summary>
        /// Gets or Sets PreviousBussName
        /// </summary>
        [DataMember(Name="previousBussName", EmitDefaultValue=true)]
        public string PreviousBussName { get; set; }

        /// <summary>
        /// Gets or Sets NameChangeDate
        /// </summary>
        [DataMember(Name="nameChangeDate", EmitDefaultValue=true)]
        public string NameChangeDate { get; set; }

        /// <summary>
        /// Gets or Sets BussEmail
        /// </summary>
        [DataMember(Name="bussEmail", EmitDefaultValue=true)]
        public string BussEmail { get; set; }

        /// <summary>
        /// Gets or Sets BussWebsite
        /// </summary>
        [DataMember(Name="bussWebsite", EmitDefaultValue=true)]
        public string BussWebsite { get; set; }

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
            sb.Append("class XdsCommercialCompanyInformation {\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
            sb.Append("  RegistrationNo: ").Append(RegistrationNo).Append("\n");
            sb.Append("  RegistrationNoOld: ").Append(RegistrationNoOld).Append("\n");
            sb.Append("  BusinessStartDate: ").Append(BusinessStartDate).Append("\n");
            sb.Append("  FinancialYearEnd: ").Append(FinancialYearEnd).Append("\n");
            sb.Append("  CommercialStatus: ").Append(CommercialStatus).Append("\n");
            sb.Append("  CommercialType: ").Append(CommercialType).Append("\n");
            sb.Append("  Sic: ").Append(Sic).Append("\n");
            sb.Append("  TaxNo: ").Append(TaxNo).Append("\n");
            sb.Append("  DirectorCount: ").Append(DirectorCount).Append("\n");
            sb.Append("  ReferenceNo: ").Append(ReferenceNo).Append("\n");
            sb.Append("  ExternalReference: ").Append(ExternalReference).Append("\n");
            sb.Append("  TradeName: ").Append(TradeName).Append("\n");
            sb.Append("  VatNo: ").Append(VatNo).Append("\n");
            sb.Append("  PreviousBussName: ").Append(PreviousBussName).Append("\n");
            sb.Append("  NameChangeDate: ").Append(NameChangeDate).Append("\n");
            sb.Append("  BussEmail: ").Append(BussEmail).Append("\n");
            sb.Append("  BussWebsite: ").Append(BussWebsite).Append("\n");
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
            return this.Equals(input as XdsCommercialCompanyInformation);
        }

        /// <summary>
        /// Returns true if XdsCommercialCompanyInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsCommercialCompanyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsCommercialCompanyInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.CommercialName == input.CommercialName ||
                    (this.CommercialName != null &&
                    this.CommercialName.Equals(input.CommercialName))
                ) && 
                (
                    this.RegistrationNo == input.RegistrationNo ||
                    (this.RegistrationNo != null &&
                    this.RegistrationNo.Equals(input.RegistrationNo))
                ) && 
                (
                    this.RegistrationNoOld == input.RegistrationNoOld ||
                    (this.RegistrationNoOld != null &&
                    this.RegistrationNoOld.Equals(input.RegistrationNoOld))
                ) && 
                (
                    this.BusinessStartDate == input.BusinessStartDate ||
                    (this.BusinessStartDate != null &&
                    this.BusinessStartDate.Equals(input.BusinessStartDate))
                ) && 
                (
                    this.FinancialYearEnd == input.FinancialYearEnd ||
                    (this.FinancialYearEnd != null &&
                    this.FinancialYearEnd.Equals(input.FinancialYearEnd))
                ) && 
                (
                    this.CommercialStatus == input.CommercialStatus ||
                    (this.CommercialStatus != null &&
                    this.CommercialStatus.Equals(input.CommercialStatus))
                ) && 
                (
                    this.CommercialType == input.CommercialType ||
                    (this.CommercialType != null &&
                    this.CommercialType.Equals(input.CommercialType))
                ) && 
                (
                    this.Sic == input.Sic ||
                    (this.Sic != null &&
                    this.Sic.Equals(input.Sic))
                ) && 
                (
                    this.TaxNo == input.TaxNo ||
                    (this.TaxNo != null &&
                    this.TaxNo.Equals(input.TaxNo))
                ) && 
                (
                    this.DirectorCount == input.DirectorCount ||
                    (this.DirectorCount != null &&
                    this.DirectorCount.Equals(input.DirectorCount))
                ) && 
                (
                    this.ReferenceNo == input.ReferenceNo ||
                    (this.ReferenceNo != null &&
                    this.ReferenceNo.Equals(input.ReferenceNo))
                ) && 
                (
                    this.ExternalReference == input.ExternalReference ||
                    (this.ExternalReference != null &&
                    this.ExternalReference.Equals(input.ExternalReference))
                ) && 
                (
                    this.TradeName == input.TradeName ||
                    (this.TradeName != null &&
                    this.TradeName.Equals(input.TradeName))
                ) && 
                (
                    this.VatNo == input.VatNo ||
                    (this.VatNo != null &&
                    this.VatNo.Equals(input.VatNo))
                ) && 
                (
                    this.PreviousBussName == input.PreviousBussName ||
                    (this.PreviousBussName != null &&
                    this.PreviousBussName.Equals(input.PreviousBussName))
                ) && 
                (
                    this.NameChangeDate == input.NameChangeDate ||
                    (this.NameChangeDate != null &&
                    this.NameChangeDate.Equals(input.NameChangeDate))
                ) && 
                (
                    this.BussEmail == input.BussEmail ||
                    (this.BussEmail != null &&
                    this.BussEmail.Equals(input.BussEmail))
                ) && 
                (
                    this.BussWebsite == input.BussWebsite ||
                    (this.BussWebsite != null &&
                    this.BussWebsite.Equals(input.BussWebsite))
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
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.CommercialName != null)
                    hashCode = hashCode * 59 + this.CommercialName.GetHashCode();
                if (this.RegistrationNo != null)
                    hashCode = hashCode * 59 + this.RegistrationNo.GetHashCode();
                if (this.RegistrationNoOld != null)
                    hashCode = hashCode * 59 + this.RegistrationNoOld.GetHashCode();
                if (this.BusinessStartDate != null)
                    hashCode = hashCode * 59 + this.BusinessStartDate.GetHashCode();
                if (this.FinancialYearEnd != null)
                    hashCode = hashCode * 59 + this.FinancialYearEnd.GetHashCode();
                if (this.CommercialStatus != null)
                    hashCode = hashCode * 59 + this.CommercialStatus.GetHashCode();
                if (this.CommercialType != null)
                    hashCode = hashCode * 59 + this.CommercialType.GetHashCode();
                if (this.Sic != null)
                    hashCode = hashCode * 59 + this.Sic.GetHashCode();
                if (this.TaxNo != null)
                    hashCode = hashCode * 59 + this.TaxNo.GetHashCode();
                if (this.DirectorCount != null)
                    hashCode = hashCode * 59 + this.DirectorCount.GetHashCode();
                if (this.ReferenceNo != null)
                    hashCode = hashCode * 59 + this.ReferenceNo.GetHashCode();
                if (this.ExternalReference != null)
                    hashCode = hashCode * 59 + this.ExternalReference.GetHashCode();
                if (this.TradeName != null)
                    hashCode = hashCode * 59 + this.TradeName.GetHashCode();
                if (this.VatNo != null)
                    hashCode = hashCode * 59 + this.VatNo.GetHashCode();
                if (this.PreviousBussName != null)
                    hashCode = hashCode * 59 + this.PreviousBussName.GetHashCode();
                if (this.NameChangeDate != null)
                    hashCode = hashCode * 59 + this.NameChangeDate.GetHashCode();
                if (this.BussEmail != null)
                    hashCode = hashCode * 59 + this.BussEmail.GetHashCode();
                if (this.BussWebsite != null)
                    hashCode = hashCode * 59 + this.BussWebsite.GetHashCode();
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