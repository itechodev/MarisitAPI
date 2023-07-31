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
    /// TransunionCommercialRegistrationDetails
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialRegistrationDetails :  IEquatable<TransunionCommercialRegistrationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialRegistrationDetails" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="registrationStatusCode">registrationStatusCode.</param>
        /// <param name="registrationStatusDesc">registrationStatusDesc.</param>
        /// <param name="liquidationDate">liquidationDate.</param>
        /// <param name="registrationNo">registrationNo.</param>
        /// <param name="companyTypeCode">companyTypeCode.</param>
        /// <param name="companyTypeDesc">companyTypeDesc.</param>
        /// <param name="registrationCountry">registrationCountry.</param>
        /// <param name="previousRegistrationNo">previousRegistrationNo.</param>
        /// <param name="auditors">auditors.</param>
        /// <param name="registeredAddress">registeredAddress.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="authorisedCapital">authorisedCapital.</param>
        /// <param name="shareInfo">shareInfo.</param>
        /// <param name="issuedCapital">issuedCapital.</param>
        /// <param name="statedCapital">statedCapital.</param>
        /// <param name="capitalInfo">capitalInfo.</param>
        /// <param name="regStatusReason">regStatusReason.</param>
        /// <param name="regInfoDate">regInfoDate.</param>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="postalPostCode">postalPostCode.</param>
        /// <param name="financialYearEnd">financialYearEnd.</param>
        /// <param name="auditorType">auditorType.</param>
        /// <param name="auditorStatus">auditorStatus.</param>
        public TransunionCommercialRegistrationDetails(string majorProduct = default(string), string registrationDate = default(string), string registrationStatusCode = default(string), string registrationStatusDesc = default(string), string liquidationDate = default(string), string registrationNo = default(string), string companyTypeCode = default(string), string companyTypeDesc = default(string), string registrationCountry = default(string), List<string> previousRegistrationNo = default(List<string>), string auditors = default(string), string registeredAddress = default(string), string suburb = default(string), string city = default(string), string country = default(string), string postCode = default(string), string authorisedCapital = default(string), List<TransunionCommercialShareInfo> shareInfo = default(List<TransunionCommercialShareInfo>), string issuedCapital = default(string), string statedCapital = default(string), List<TransunionCommercialCapitalInfo> capitalInfo = default(List<TransunionCommercialCapitalInfo>), string regStatusReason = default(string), string regInfoDate = default(string), List<string> postalAddress = default(List<string>), string postalPostCode = default(string), string financialYearEnd = default(string), string auditorType = default(string), string auditorStatus = default(string))
        {
            this.MajorProduct = majorProduct;
            this.RegistrationDate = registrationDate;
            this.RegistrationStatusCode = registrationStatusCode;
            this.RegistrationStatusDesc = registrationStatusDesc;
            this.LiquidationDate = liquidationDate;
            this.RegistrationNo = registrationNo;
            this.CompanyTypeCode = companyTypeCode;
            this.CompanyTypeDesc = companyTypeDesc;
            this.RegistrationCountry = registrationCountry;
            this.PreviousRegistrationNo = previousRegistrationNo;
            this.Auditors = auditors;
            this.RegisteredAddress = registeredAddress;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
            this.PostCode = postCode;
            this.AuthorisedCapital = authorisedCapital;
            this.ShareInfo = shareInfo;
            this.IssuedCapital = issuedCapital;
            this.StatedCapital = statedCapital;
            this.CapitalInfo = capitalInfo;
            this.RegStatusReason = regStatusReason;
            this.RegInfoDate = regInfoDate;
            this.PostalAddress = postalAddress;
            this.PostalPostCode = postalPostCode;
            this.FinancialYearEnd = financialYearEnd;
            this.AuditorType = auditorType;
            this.AuditorStatus = auditorStatus;
            this.MajorProduct = majorProduct;
            this.RegistrationDate = registrationDate;
            this.RegistrationStatusCode = registrationStatusCode;
            this.RegistrationStatusDesc = registrationStatusDesc;
            this.LiquidationDate = liquidationDate;
            this.RegistrationNo = registrationNo;
            this.CompanyTypeCode = companyTypeCode;
            this.CompanyTypeDesc = companyTypeDesc;
            this.RegistrationCountry = registrationCountry;
            this.PreviousRegistrationNo = previousRegistrationNo;
            this.Auditors = auditors;
            this.RegisteredAddress = registeredAddress;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
            this.PostCode = postCode;
            this.AuthorisedCapital = authorisedCapital;
            this.ShareInfo = shareInfo;
            this.IssuedCapital = issuedCapital;
            this.StatedCapital = statedCapital;
            this.CapitalInfo = capitalInfo;
            this.RegStatusReason = regStatusReason;
            this.RegInfoDate = regInfoDate;
            this.PostalAddress = postalAddress;
            this.PostalPostCode = postalPostCode;
            this.FinancialYearEnd = financialYearEnd;
            this.AuditorType = auditorType;
            this.AuditorStatus = auditorStatus;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name="registrationDate", EmitDefaultValue=true)]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationStatusCode
        /// </summary>
        [DataMember(Name="registrationStatusCode", EmitDefaultValue=true)]
        public string RegistrationStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationStatusDesc
        /// </summary>
        [DataMember(Name="registrationStatusDesc", EmitDefaultValue=true)]
        public string RegistrationStatusDesc { get; set; }

        /// <summary>
        /// Gets or Sets LiquidationDate
        /// </summary>
        [DataMember(Name="liquidationDate", EmitDefaultValue=true)]
        public string LiquidationDate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNo
        /// </summary>
        [DataMember(Name="registrationNo", EmitDefaultValue=true)]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// Gets or Sets CompanyTypeCode
        /// </summary>
        [DataMember(Name="companyTypeCode", EmitDefaultValue=true)]
        public string CompanyTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets CompanyTypeDesc
        /// </summary>
        [DataMember(Name="companyTypeDesc", EmitDefaultValue=true)]
        public string CompanyTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationCountry
        /// </summary>
        [DataMember(Name="registrationCountry", EmitDefaultValue=true)]
        public string RegistrationCountry { get; set; }

        /// <summary>
        /// Gets or Sets PreviousRegistrationNo
        /// </summary>
        [DataMember(Name="previousRegistrationNo", EmitDefaultValue=true)]
        public List<string> PreviousRegistrationNo { get; set; }

        /// <summary>
        /// Gets or Sets Auditors
        /// </summary>
        [DataMember(Name="auditors", EmitDefaultValue=true)]
        public string Auditors { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredAddress
        /// </summary>
        [DataMember(Name="registeredAddress", EmitDefaultValue=true)]
        public string RegisteredAddress { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=true)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets AuthorisedCapital
        /// </summary>
        [DataMember(Name="authorisedCapital", EmitDefaultValue=true)]
        public string AuthorisedCapital { get; set; }

        /// <summary>
        /// Gets or Sets ShareInfo
        /// </summary>
        [DataMember(Name="shareInfo", EmitDefaultValue=true)]
        public List<TransunionCommercialShareInfo> ShareInfo { get; set; }

        /// <summary>
        /// Gets or Sets IssuedCapital
        /// </summary>
        [DataMember(Name="issuedCapital", EmitDefaultValue=true)]
        public string IssuedCapital { get; set; }

        /// <summary>
        /// Gets or Sets StatedCapital
        /// </summary>
        [DataMember(Name="statedCapital", EmitDefaultValue=true)]
        public string StatedCapital { get; set; }

        /// <summary>
        /// Gets or Sets CapitalInfo
        /// </summary>
        [DataMember(Name="capitalInfo", EmitDefaultValue=true)]
        public List<TransunionCommercialCapitalInfo> CapitalInfo { get; set; }

        /// <summary>
        /// Gets or Sets RegStatusReason
        /// </summary>
        [DataMember(Name="reg_Status_Reason", EmitDefaultValue=true)]
        public string RegStatusReason { get; set; }

        /// <summary>
        /// Gets or Sets RegInfoDate
        /// </summary>
        [DataMember(Name="reg_Info_Date", EmitDefaultValue=true)]
        public string RegInfoDate { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="postalAddress", EmitDefaultValue=true)]
        public List<string> PostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets PostalPostCode
        /// </summary>
        [DataMember(Name="postalPostCode", EmitDefaultValue=true)]
        public string PostalPostCode { get; set; }

        /// <summary>
        /// Gets or Sets FinancialYearEnd
        /// </summary>
        [DataMember(Name="financialYearEnd", EmitDefaultValue=true)]
        public string FinancialYearEnd { get; set; }

        /// <summary>
        /// Gets or Sets AuditorType
        /// </summary>
        [DataMember(Name="auditorType", EmitDefaultValue=true)]
        public string AuditorType { get; set; }

        /// <summary>
        /// Gets or Sets AuditorStatus
        /// </summary>
        [DataMember(Name="auditorStatus", EmitDefaultValue=true)]
        public string AuditorStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialRegistrationDetails {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  RegistrationStatusCode: ").Append(RegistrationStatusCode).Append("\n");
            sb.Append("  RegistrationStatusDesc: ").Append(RegistrationStatusDesc).Append("\n");
            sb.Append("  LiquidationDate: ").Append(LiquidationDate).Append("\n");
            sb.Append("  RegistrationNo: ").Append(RegistrationNo).Append("\n");
            sb.Append("  CompanyTypeCode: ").Append(CompanyTypeCode).Append("\n");
            sb.Append("  CompanyTypeDesc: ").Append(CompanyTypeDesc).Append("\n");
            sb.Append("  RegistrationCountry: ").Append(RegistrationCountry).Append("\n");
            sb.Append("  PreviousRegistrationNo: ").Append(PreviousRegistrationNo).Append("\n");
            sb.Append("  Auditors: ").Append(Auditors).Append("\n");
            sb.Append("  RegisteredAddress: ").Append(RegisteredAddress).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  AuthorisedCapital: ").Append(AuthorisedCapital).Append("\n");
            sb.Append("  ShareInfo: ").Append(ShareInfo).Append("\n");
            sb.Append("  IssuedCapital: ").Append(IssuedCapital).Append("\n");
            sb.Append("  StatedCapital: ").Append(StatedCapital).Append("\n");
            sb.Append("  CapitalInfo: ").Append(CapitalInfo).Append("\n");
            sb.Append("  RegStatusReason: ").Append(RegStatusReason).Append("\n");
            sb.Append("  RegInfoDate: ").Append(RegInfoDate).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  PostalPostCode: ").Append(PostalPostCode).Append("\n");
            sb.Append("  FinancialYearEnd: ").Append(FinancialYearEnd).Append("\n");
            sb.Append("  AuditorType: ").Append(AuditorType).Append("\n");
            sb.Append("  AuditorStatus: ").Append(AuditorStatus).Append("\n");
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
            return this.Equals(input as TransunionCommercialRegistrationDetails);
        }

        /// <summary>
        /// Returns true if TransunionCommercialRegistrationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialRegistrationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialRegistrationDetails input)
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
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.RegistrationStatusCode == input.RegistrationStatusCode ||
                    (this.RegistrationStatusCode != null &&
                    this.RegistrationStatusCode.Equals(input.RegistrationStatusCode))
                ) && 
                (
                    this.RegistrationStatusDesc == input.RegistrationStatusDesc ||
                    (this.RegistrationStatusDesc != null &&
                    this.RegistrationStatusDesc.Equals(input.RegistrationStatusDesc))
                ) && 
                (
                    this.LiquidationDate == input.LiquidationDate ||
                    (this.LiquidationDate != null &&
                    this.LiquidationDate.Equals(input.LiquidationDate))
                ) && 
                (
                    this.RegistrationNo == input.RegistrationNo ||
                    (this.RegistrationNo != null &&
                    this.RegistrationNo.Equals(input.RegistrationNo))
                ) && 
                (
                    this.CompanyTypeCode == input.CompanyTypeCode ||
                    (this.CompanyTypeCode != null &&
                    this.CompanyTypeCode.Equals(input.CompanyTypeCode))
                ) && 
                (
                    this.CompanyTypeDesc == input.CompanyTypeDesc ||
                    (this.CompanyTypeDesc != null &&
                    this.CompanyTypeDesc.Equals(input.CompanyTypeDesc))
                ) && 
                (
                    this.RegistrationCountry == input.RegistrationCountry ||
                    (this.RegistrationCountry != null &&
                    this.RegistrationCountry.Equals(input.RegistrationCountry))
                ) && 
                (
                    this.PreviousRegistrationNo == input.PreviousRegistrationNo ||
                    this.PreviousRegistrationNo != null &&
                    input.PreviousRegistrationNo != null &&
                    this.PreviousRegistrationNo.SequenceEqual(input.PreviousRegistrationNo)
                ) && 
                (
                    this.Auditors == input.Auditors ||
                    (this.Auditors != null &&
                    this.Auditors.Equals(input.Auditors))
                ) && 
                (
                    this.RegisteredAddress == input.RegisteredAddress ||
                    (this.RegisteredAddress != null &&
                    this.RegisteredAddress.Equals(input.RegisteredAddress))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.AuthorisedCapital == input.AuthorisedCapital ||
                    (this.AuthorisedCapital != null &&
                    this.AuthorisedCapital.Equals(input.AuthorisedCapital))
                ) && 
                (
                    this.ShareInfo == input.ShareInfo ||
                    this.ShareInfo != null &&
                    input.ShareInfo != null &&
                    this.ShareInfo.SequenceEqual(input.ShareInfo)
                ) && 
                (
                    this.IssuedCapital == input.IssuedCapital ||
                    (this.IssuedCapital != null &&
                    this.IssuedCapital.Equals(input.IssuedCapital))
                ) && 
                (
                    this.StatedCapital == input.StatedCapital ||
                    (this.StatedCapital != null &&
                    this.StatedCapital.Equals(input.StatedCapital))
                ) && 
                (
                    this.CapitalInfo == input.CapitalInfo ||
                    this.CapitalInfo != null &&
                    input.CapitalInfo != null &&
                    this.CapitalInfo.SequenceEqual(input.CapitalInfo)
                ) && 
                (
                    this.RegStatusReason == input.RegStatusReason ||
                    (this.RegStatusReason != null &&
                    this.RegStatusReason.Equals(input.RegStatusReason))
                ) && 
                (
                    this.RegInfoDate == input.RegInfoDate ||
                    (this.RegInfoDate != null &&
                    this.RegInfoDate.Equals(input.RegInfoDate))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    this.PostalAddress != null &&
                    input.PostalAddress != null &&
                    this.PostalAddress.SequenceEqual(input.PostalAddress)
                ) && 
                (
                    this.PostalPostCode == input.PostalPostCode ||
                    (this.PostalPostCode != null &&
                    this.PostalPostCode.Equals(input.PostalPostCode))
                ) && 
                (
                    this.FinancialYearEnd == input.FinancialYearEnd ||
                    (this.FinancialYearEnd != null &&
                    this.FinancialYearEnd.Equals(input.FinancialYearEnd))
                ) && 
                (
                    this.AuditorType == input.AuditorType ||
                    (this.AuditorType != null &&
                    this.AuditorType.Equals(input.AuditorType))
                ) && 
                (
                    this.AuditorStatus == input.AuditorStatus ||
                    (this.AuditorStatus != null &&
                    this.AuditorStatus.Equals(input.AuditorStatus))
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
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.RegistrationStatusCode != null)
                    hashCode = hashCode * 59 + this.RegistrationStatusCode.GetHashCode();
                if (this.RegistrationStatusDesc != null)
                    hashCode = hashCode * 59 + this.RegistrationStatusDesc.GetHashCode();
                if (this.LiquidationDate != null)
                    hashCode = hashCode * 59 + this.LiquidationDate.GetHashCode();
                if (this.RegistrationNo != null)
                    hashCode = hashCode * 59 + this.RegistrationNo.GetHashCode();
                if (this.CompanyTypeCode != null)
                    hashCode = hashCode * 59 + this.CompanyTypeCode.GetHashCode();
                if (this.CompanyTypeDesc != null)
                    hashCode = hashCode * 59 + this.CompanyTypeDesc.GetHashCode();
                if (this.RegistrationCountry != null)
                    hashCode = hashCode * 59 + this.RegistrationCountry.GetHashCode();
                if (this.PreviousRegistrationNo != null)
                    hashCode = hashCode * 59 + this.PreviousRegistrationNo.GetHashCode();
                if (this.Auditors != null)
                    hashCode = hashCode * 59 + this.Auditors.GetHashCode();
                if (this.RegisteredAddress != null)
                    hashCode = hashCode * 59 + this.RegisteredAddress.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.AuthorisedCapital != null)
                    hashCode = hashCode * 59 + this.AuthorisedCapital.GetHashCode();
                if (this.ShareInfo != null)
                    hashCode = hashCode * 59 + this.ShareInfo.GetHashCode();
                if (this.IssuedCapital != null)
                    hashCode = hashCode * 59 + this.IssuedCapital.GetHashCode();
                if (this.StatedCapital != null)
                    hashCode = hashCode * 59 + this.StatedCapital.GetHashCode();
                if (this.CapitalInfo != null)
                    hashCode = hashCode * 59 + this.CapitalInfo.GetHashCode();
                if (this.RegStatusReason != null)
                    hashCode = hashCode * 59 + this.RegStatusReason.GetHashCode();
                if (this.RegInfoDate != null)
                    hashCode = hashCode * 59 + this.RegInfoDate.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.PostalPostCode != null)
                    hashCode = hashCode * 59 + this.PostalPostCode.GetHashCode();
                if (this.FinancialYearEnd != null)
                    hashCode = hashCode * 59 + this.FinancialYearEnd.GetHashCode();
                if (this.AuditorType != null)
                    hashCode = hashCode * 59 + this.AuditorType.GetHashCode();
                if (this.AuditorStatus != null)
                    hashCode = hashCode * 59 + this.AuditorStatus.GetHashCode();
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