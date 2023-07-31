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
    /// XdsCommercialBusinessInformation
    /// </summary>
    [DataContract]
    public partial class XdsCommercialBusinessInformation :  IEquatable<XdsCommercialBusinessInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsCommercialBusinessInformation" /> class.
        /// </summary>
        /// <param name="displayText">displayText.</param>
        /// <param name="commercialName">commercialName.</param>
        /// <param name="registrationNo">registrationNo.</param>
        /// <param name="businessStartDate">businessStartDate.</param>
        /// <param name="financialYearEnd">financialYearEnd.</param>
        /// <param name="registrationNoOld">registrationNoOld.</param>
        /// <param name="commercialStatus">commercialStatus.</param>
        /// <param name="commercialType">commercialType.</param>
        /// <param name="sic">sic.</param>
        /// <param name="taxNo">taxNo.</param>
        /// <param name="referenceNo">referenceNo.</param>
        /// <param name="externalReference">externalReference.</param>
        /// <param name="tradeName">tradeName.</param>
        /// <param name="previousBussName">previousBussName.</param>
        /// <param name="physicalAddress">physicalAddress.</param>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="businessDesc">businessDesc.</param>
        /// <param name="telephoneNo">telephoneNo.</param>
        /// <param name="faxNo">faxNo.</param>
        /// <param name="bussEmail">bussEmail.</param>
        /// <param name="bussWebsite">bussWebsite.</param>
        /// <param name="noOfEnquiries">noOfEnquiries.</param>
        /// <param name="nameChangeDate">nameChangeDate.</param>
        /// <param name="ageofBusiness">ageofBusiness.</param>
        /// <param name="authorisedCapitalAmt">authorisedCapitalAmt.</param>
        /// <param name="issuedNoOfShares">issuedNoOfShares.</param>
        /// <param name="registrationNoConverted">registrationNoConverted.</param>
        /// <param name="financialEffectiveDate">financialEffectiveDate.</param>
        /// <param name="authorisedNoOfShares">authorisedNoOfShares.</param>
        /// <param name="issuedCapitalAmt">issuedCapitalAmt.</param>
        /// <param name="commercialStatusDate">commercialStatusDate.</param>
        /// <param name="directorCount">directorCount.</param>
        /// <param name="vatNo">vatNo.</param>
        public XdsCommercialBusinessInformation(string displayText = default(string), string commercialName = default(string), string registrationNo = default(string), string businessStartDate = default(string), string financialYearEnd = default(string), string registrationNoOld = default(string), string commercialStatus = default(string), string commercialType = default(string), string sic = default(string), string taxNo = default(string), string referenceNo = default(string), string externalReference = default(string), string tradeName = default(string), string previousBussName = default(string), string physicalAddress = default(string), string postalAddress = default(string), string registrationDate = default(string), string businessDesc = default(string), string telephoneNo = default(string), string faxNo = default(string), string bussEmail = default(string), string bussWebsite = default(string), string noOfEnquiries = default(string), string nameChangeDate = default(string), string ageofBusiness = default(string), string authorisedCapitalAmt = default(string), string issuedNoOfShares = default(string), string registrationNoConverted = default(string), string financialEffectiveDate = default(string), string authorisedNoOfShares = default(string), string issuedCapitalAmt = default(string), string commercialStatusDate = default(string), string directorCount = default(string), string vatNo = default(string))
        {
            this.DisplayText = displayText;
            this.CommercialName = commercialName;
            this.RegistrationNo = registrationNo;
            this.BusinessStartDate = businessStartDate;
            this.FinancialYearEnd = financialYearEnd;
            this.RegistrationNoOld = registrationNoOld;
            this.CommercialStatus = commercialStatus;
            this.CommercialType = commercialType;
            this.Sic = sic;
            this.TaxNo = taxNo;
            this.ReferenceNo = referenceNo;
            this.ExternalReference = externalReference;
            this.TradeName = tradeName;
            this.PreviousBussName = previousBussName;
            this.PhysicalAddress = physicalAddress;
            this.PostalAddress = postalAddress;
            this.RegistrationDate = registrationDate;
            this.BusinessDesc = businessDesc;
            this.TelephoneNo = telephoneNo;
            this.FaxNo = faxNo;
            this.BussEmail = bussEmail;
            this.BussWebsite = bussWebsite;
            this.NoOfEnquiries = noOfEnquiries;
            this.NameChangeDate = nameChangeDate;
            this.AgeofBusiness = ageofBusiness;
            this.AuthorisedCapitalAmt = authorisedCapitalAmt;
            this.IssuedNoOfShares = issuedNoOfShares;
            this.RegistrationNoConverted = registrationNoConverted;
            this.FinancialEffectiveDate = financialEffectiveDate;
            this.AuthorisedNoOfShares = authorisedNoOfShares;
            this.IssuedCapitalAmt = issuedCapitalAmt;
            this.CommercialStatusDate = commercialStatusDate;
            this.DirectorCount = directorCount;
            this.VatNo = vatNo;
            this.DisplayText = displayText;
            this.CommercialName = commercialName;
            this.RegistrationNo = registrationNo;
            this.BusinessStartDate = businessStartDate;
            this.FinancialYearEnd = financialYearEnd;
            this.RegistrationNoOld = registrationNoOld;
            this.CommercialStatus = commercialStatus;
            this.CommercialType = commercialType;
            this.Sic = sic;
            this.TaxNo = taxNo;
            this.ReferenceNo = referenceNo;
            this.ExternalReference = externalReference;
            this.TradeName = tradeName;
            this.PreviousBussName = previousBussName;
            this.PhysicalAddress = physicalAddress;
            this.PostalAddress = postalAddress;
            this.RegistrationDate = registrationDate;
            this.BusinessDesc = businessDesc;
            this.TelephoneNo = telephoneNo;
            this.FaxNo = faxNo;
            this.BussEmail = bussEmail;
            this.BussWebsite = bussWebsite;
            this.NoOfEnquiries = noOfEnquiries;
            this.NameChangeDate = nameChangeDate;
            this.AgeofBusiness = ageofBusiness;
            this.AuthorisedCapitalAmt = authorisedCapitalAmt;
            this.IssuedNoOfShares = issuedNoOfShares;
            this.RegistrationNoConverted = registrationNoConverted;
            this.FinancialEffectiveDate = financialEffectiveDate;
            this.AuthorisedNoOfShares = authorisedNoOfShares;
            this.IssuedCapitalAmt = issuedCapitalAmt;
            this.CommercialStatusDate = commercialStatusDate;
            this.DirectorCount = directorCount;
            this.VatNo = vatNo;
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
        /// Gets or Sets RegistrationNoOld
        /// </summary>
        [DataMember(Name="registrationNoOld", EmitDefaultValue=true)]
        public string RegistrationNoOld { get; set; }

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
        /// Gets or Sets PreviousBussName
        /// </summary>
        [DataMember(Name="previousBussName", EmitDefaultValue=true)]
        public string PreviousBussName { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalAddress
        /// </summary>
        [DataMember(Name="physicalAddress", EmitDefaultValue=true)]
        public string PhysicalAddress { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="postalAddress", EmitDefaultValue=true)]
        public string PostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name="registrationDate", EmitDefaultValue=true)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets BusinessDesc
        /// </summary>
        [DataMember(Name="businessDesc", EmitDefaultValue=true)]
        public string BusinessDesc { get; set; }

        /// <summary>
        /// Gets or Sets TelephoneNo
        /// </summary>
        [DataMember(Name="telephoneNo", EmitDefaultValue=true)]
        public string TelephoneNo { get; set; }

        /// <summary>
        /// Gets or Sets FaxNo
        /// </summary>
        [DataMember(Name="faxNo", EmitDefaultValue=true)]
        public string FaxNo { get; set; }

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
        /// Gets or Sets NoOfEnquiries
        /// </summary>
        [DataMember(Name="noOfEnquiries", EmitDefaultValue=true)]
        public string NoOfEnquiries { get; set; }

        /// <summary>
        /// Gets or Sets NameChangeDate
        /// </summary>
        [DataMember(Name="nameChangeDate", EmitDefaultValue=true)]
        public string NameChangeDate { get; set; }

        /// <summary>
        /// Gets or Sets AgeofBusiness
        /// </summary>
        [DataMember(Name="ageofBusiness", EmitDefaultValue=true)]
        public string AgeofBusiness { get; set; }

        /// <summary>
        /// Gets or Sets AuthorisedCapitalAmt
        /// </summary>
        [DataMember(Name="authorisedCapitalAmt", EmitDefaultValue=true)]
        public string AuthorisedCapitalAmt { get; set; }

        /// <summary>
        /// Gets or Sets IssuedNoOfShares
        /// </summary>
        [DataMember(Name="issuedNoOfShares", EmitDefaultValue=true)]
        public string IssuedNoOfShares { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNoConverted
        /// </summary>
        [DataMember(Name="registrationNoConverted", EmitDefaultValue=true)]
        public string RegistrationNoConverted { get; set; }

        /// <summary>
        /// Gets or Sets FinancialEffectiveDate
        /// </summary>
        [DataMember(Name="financialEffectiveDate", EmitDefaultValue=true)]
        public string FinancialEffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets AuthorisedNoOfShares
        /// </summary>
        [DataMember(Name="authorisedNoOfShares", EmitDefaultValue=true)]
        public string AuthorisedNoOfShares { get; set; }

        /// <summary>
        /// Gets or Sets IssuedCapitalAmt
        /// </summary>
        [DataMember(Name="issuedCapitalAmt", EmitDefaultValue=true)]
        public string IssuedCapitalAmt { get; set; }

        /// <summary>
        /// Gets or Sets CommercialStatusDate
        /// </summary>
        [DataMember(Name="commercialStatusDate", EmitDefaultValue=true)]
        public string CommercialStatusDate { get; set; }

        /// <summary>
        /// Gets or Sets DirectorCount
        /// </summary>
        [DataMember(Name="directorCount", EmitDefaultValue=true)]
        public string DirectorCount { get; set; }

        /// <summary>
        /// Gets or Sets VatNo
        /// </summary>
        [DataMember(Name="vatNo", EmitDefaultValue=true)]
        public string VatNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsCommercialBusinessInformation {\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
            sb.Append("  RegistrationNo: ").Append(RegistrationNo).Append("\n");
            sb.Append("  BusinessStartDate: ").Append(BusinessStartDate).Append("\n");
            sb.Append("  FinancialYearEnd: ").Append(FinancialYearEnd).Append("\n");
            sb.Append("  RegistrationNoOld: ").Append(RegistrationNoOld).Append("\n");
            sb.Append("  CommercialStatus: ").Append(CommercialStatus).Append("\n");
            sb.Append("  CommercialType: ").Append(CommercialType).Append("\n");
            sb.Append("  Sic: ").Append(Sic).Append("\n");
            sb.Append("  TaxNo: ").Append(TaxNo).Append("\n");
            sb.Append("  ReferenceNo: ").Append(ReferenceNo).Append("\n");
            sb.Append("  ExternalReference: ").Append(ExternalReference).Append("\n");
            sb.Append("  TradeName: ").Append(TradeName).Append("\n");
            sb.Append("  PreviousBussName: ").Append(PreviousBussName).Append("\n");
            sb.Append("  PhysicalAddress: ").Append(PhysicalAddress).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  BusinessDesc: ").Append(BusinessDesc).Append("\n");
            sb.Append("  TelephoneNo: ").Append(TelephoneNo).Append("\n");
            sb.Append("  FaxNo: ").Append(FaxNo).Append("\n");
            sb.Append("  BussEmail: ").Append(BussEmail).Append("\n");
            sb.Append("  BussWebsite: ").Append(BussWebsite).Append("\n");
            sb.Append("  NoOfEnquiries: ").Append(NoOfEnquiries).Append("\n");
            sb.Append("  NameChangeDate: ").Append(NameChangeDate).Append("\n");
            sb.Append("  AgeofBusiness: ").Append(AgeofBusiness).Append("\n");
            sb.Append("  AuthorisedCapitalAmt: ").Append(AuthorisedCapitalAmt).Append("\n");
            sb.Append("  IssuedNoOfShares: ").Append(IssuedNoOfShares).Append("\n");
            sb.Append("  RegistrationNoConverted: ").Append(RegistrationNoConverted).Append("\n");
            sb.Append("  FinancialEffectiveDate: ").Append(FinancialEffectiveDate).Append("\n");
            sb.Append("  AuthorisedNoOfShares: ").Append(AuthorisedNoOfShares).Append("\n");
            sb.Append("  IssuedCapitalAmt: ").Append(IssuedCapitalAmt).Append("\n");
            sb.Append("  CommercialStatusDate: ").Append(CommercialStatusDate).Append("\n");
            sb.Append("  DirectorCount: ").Append(DirectorCount).Append("\n");
            sb.Append("  VatNo: ").Append(VatNo).Append("\n");
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
            return this.Equals(input as XdsCommercialBusinessInformation);
        }

        /// <summary>
        /// Returns true if XdsCommercialBusinessInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsCommercialBusinessInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsCommercialBusinessInformation input)
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
                    this.RegistrationNoOld == input.RegistrationNoOld ||
                    (this.RegistrationNoOld != null &&
                    this.RegistrationNoOld.Equals(input.RegistrationNoOld))
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
                    this.PreviousBussName == input.PreviousBussName ||
                    (this.PreviousBussName != null &&
                    this.PreviousBussName.Equals(input.PreviousBussName))
                ) && 
                (
                    this.PhysicalAddress == input.PhysicalAddress ||
                    (this.PhysicalAddress != null &&
                    this.PhysicalAddress.Equals(input.PhysicalAddress))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.BusinessDesc == input.BusinessDesc ||
                    (this.BusinessDesc != null &&
                    this.BusinessDesc.Equals(input.BusinessDesc))
                ) && 
                (
                    this.TelephoneNo == input.TelephoneNo ||
                    (this.TelephoneNo != null &&
                    this.TelephoneNo.Equals(input.TelephoneNo))
                ) && 
                (
                    this.FaxNo == input.FaxNo ||
                    (this.FaxNo != null &&
                    this.FaxNo.Equals(input.FaxNo))
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
                    this.NoOfEnquiries == input.NoOfEnquiries ||
                    (this.NoOfEnquiries != null &&
                    this.NoOfEnquiries.Equals(input.NoOfEnquiries))
                ) && 
                (
                    this.NameChangeDate == input.NameChangeDate ||
                    (this.NameChangeDate != null &&
                    this.NameChangeDate.Equals(input.NameChangeDate))
                ) && 
                (
                    this.AgeofBusiness == input.AgeofBusiness ||
                    (this.AgeofBusiness != null &&
                    this.AgeofBusiness.Equals(input.AgeofBusiness))
                ) && 
                (
                    this.AuthorisedCapitalAmt == input.AuthorisedCapitalAmt ||
                    (this.AuthorisedCapitalAmt != null &&
                    this.AuthorisedCapitalAmt.Equals(input.AuthorisedCapitalAmt))
                ) && 
                (
                    this.IssuedNoOfShares == input.IssuedNoOfShares ||
                    (this.IssuedNoOfShares != null &&
                    this.IssuedNoOfShares.Equals(input.IssuedNoOfShares))
                ) && 
                (
                    this.RegistrationNoConverted == input.RegistrationNoConverted ||
                    (this.RegistrationNoConverted != null &&
                    this.RegistrationNoConverted.Equals(input.RegistrationNoConverted))
                ) && 
                (
                    this.FinancialEffectiveDate == input.FinancialEffectiveDate ||
                    (this.FinancialEffectiveDate != null &&
                    this.FinancialEffectiveDate.Equals(input.FinancialEffectiveDate))
                ) && 
                (
                    this.AuthorisedNoOfShares == input.AuthorisedNoOfShares ||
                    (this.AuthorisedNoOfShares != null &&
                    this.AuthorisedNoOfShares.Equals(input.AuthorisedNoOfShares))
                ) && 
                (
                    this.IssuedCapitalAmt == input.IssuedCapitalAmt ||
                    (this.IssuedCapitalAmt != null &&
                    this.IssuedCapitalAmt.Equals(input.IssuedCapitalAmt))
                ) && 
                (
                    this.CommercialStatusDate == input.CommercialStatusDate ||
                    (this.CommercialStatusDate != null &&
                    this.CommercialStatusDate.Equals(input.CommercialStatusDate))
                ) && 
                (
                    this.DirectorCount == input.DirectorCount ||
                    (this.DirectorCount != null &&
                    this.DirectorCount.Equals(input.DirectorCount))
                ) && 
                (
                    this.VatNo == input.VatNo ||
                    (this.VatNo != null &&
                    this.VatNo.Equals(input.VatNo))
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
                if (this.BusinessStartDate != null)
                    hashCode = hashCode * 59 + this.BusinessStartDate.GetHashCode();
                if (this.FinancialYearEnd != null)
                    hashCode = hashCode * 59 + this.FinancialYearEnd.GetHashCode();
                if (this.RegistrationNoOld != null)
                    hashCode = hashCode * 59 + this.RegistrationNoOld.GetHashCode();
                if (this.CommercialStatus != null)
                    hashCode = hashCode * 59 + this.CommercialStatus.GetHashCode();
                if (this.CommercialType != null)
                    hashCode = hashCode * 59 + this.CommercialType.GetHashCode();
                if (this.Sic != null)
                    hashCode = hashCode * 59 + this.Sic.GetHashCode();
                if (this.TaxNo != null)
                    hashCode = hashCode * 59 + this.TaxNo.GetHashCode();
                if (this.ReferenceNo != null)
                    hashCode = hashCode * 59 + this.ReferenceNo.GetHashCode();
                if (this.ExternalReference != null)
                    hashCode = hashCode * 59 + this.ExternalReference.GetHashCode();
                if (this.TradeName != null)
                    hashCode = hashCode * 59 + this.TradeName.GetHashCode();
                if (this.PreviousBussName != null)
                    hashCode = hashCode * 59 + this.PreviousBussName.GetHashCode();
                if (this.PhysicalAddress != null)
                    hashCode = hashCode * 59 + this.PhysicalAddress.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.BusinessDesc != null)
                    hashCode = hashCode * 59 + this.BusinessDesc.GetHashCode();
                if (this.TelephoneNo != null)
                    hashCode = hashCode * 59 + this.TelephoneNo.GetHashCode();
                if (this.FaxNo != null)
                    hashCode = hashCode * 59 + this.FaxNo.GetHashCode();
                if (this.BussEmail != null)
                    hashCode = hashCode * 59 + this.BussEmail.GetHashCode();
                if (this.BussWebsite != null)
                    hashCode = hashCode * 59 + this.BussWebsite.GetHashCode();
                if (this.NoOfEnquiries != null)
                    hashCode = hashCode * 59 + this.NoOfEnquiries.GetHashCode();
                if (this.NameChangeDate != null)
                    hashCode = hashCode * 59 + this.NameChangeDate.GetHashCode();
                if (this.AgeofBusiness != null)
                    hashCode = hashCode * 59 + this.AgeofBusiness.GetHashCode();
                if (this.AuthorisedCapitalAmt != null)
                    hashCode = hashCode * 59 + this.AuthorisedCapitalAmt.GetHashCode();
                if (this.IssuedNoOfShares != null)
                    hashCode = hashCode * 59 + this.IssuedNoOfShares.GetHashCode();
                if (this.RegistrationNoConverted != null)
                    hashCode = hashCode * 59 + this.RegistrationNoConverted.GetHashCode();
                if (this.FinancialEffectiveDate != null)
                    hashCode = hashCode * 59 + this.FinancialEffectiveDate.GetHashCode();
                if (this.AuthorisedNoOfShares != null)
                    hashCode = hashCode * 59 + this.AuthorisedNoOfShares.GetHashCode();
                if (this.IssuedCapitalAmt != null)
                    hashCode = hashCode * 59 + this.IssuedCapitalAmt.GetHashCode();
                if (this.CommercialStatusDate != null)
                    hashCode = hashCode * 59 + this.CommercialStatusDate.GetHashCode();
                if (this.DirectorCount != null)
                    hashCode = hashCode * 59 + this.DirectorCount.GetHashCode();
                if (this.VatNo != null)
                    hashCode = hashCode * 59 + this.VatNo.GetHashCode();
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