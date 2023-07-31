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
    /// WindeedCipcCompanyInformation
    /// </summary>
    [DataContract]
    public partial class WindeedCipcCompanyInformation :  IEquatable<WindeedCipcCompanyInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedCipcCompanyInformation" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="registrationNumber">registrationNumber.</param>
        /// <param name="companyStatus">companyStatus.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="enterpriseType">enterpriseType.</param>
        /// <param name="businessStartDate">businessStartDate.</param>
        /// <param name="oldRegistrationNumber">oldRegistrationNumber.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="translatedName">translatedName.</param>
        /// <param name="statusDate">statusDate.</param>
        /// <param name="sicCode">sicCode.</param>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="physicalAddress">physicalAddress.</param>
        /// <param name="region">region.</param>
        /// <param name="country">country.</param>
        /// <param name="countryOfOrigin">countryOfOrigin.</param>
        /// <param name="ckDate">ckDate.</param>
        /// <param name="ckDateRecieved">ckDateRecieved.</param>
        /// <param name="industry">industry.</param>
        /// <param name="typeDate">typeDate.</param>
        /// <param name="conversionNumber">conversionNumber.</param>
        public WindeedCipcCompanyInformation(string name = default(string), WindeedCipcRegistrationNumber registrationNumber = default(WindeedCipcRegistrationNumber), WindeedCipcCipcLookup companyStatus = default(WindeedCipcCipcLookup), DateTime? registrationDate = default(DateTime?), WindeedCipcCipcLookup enterpriseType = default(WindeedCipcCipcLookup), DateTime? businessStartDate = default(DateTime?), string oldRegistrationNumber = default(string), string shortName = default(string), string translatedName = default(string), DateTime? statusDate = default(DateTime?), string sicCode = default(string), WindeedCipcBasicAddress postalAddress = default(WindeedCipcBasicAddress), WindeedCipcBasicAddress physicalAddress = default(WindeedCipcBasicAddress), WindeedCipcCipcLookup region = default(WindeedCipcCipcLookup), WindeedCipcCipcLookup country = default(WindeedCipcCipcLookup), string countryOfOrigin = default(string), DateTime? ckDate = default(DateTime?), DateTime? ckDateRecieved = default(DateTime?), WindeedCipcCipcLookup industry = default(WindeedCipcCipcLookup), DateTime? typeDate = default(DateTime?), string conversionNumber = default(string))
        {
            this.Name = name;
            this.RegistrationDate = registrationDate;
            this.BusinessStartDate = businessStartDate;
            this.OldRegistrationNumber = oldRegistrationNumber;
            this.ShortName = shortName;
            this.TranslatedName = translatedName;
            this.StatusDate = statusDate;
            this.SicCode = sicCode;
            this.CountryOfOrigin = countryOfOrigin;
            this.CkDate = ckDate;
            this.CkDateRecieved = ckDateRecieved;
            this.TypeDate = typeDate;
            this.ConversionNumber = conversionNumber;
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.CompanyStatus = companyStatus;
            this.RegistrationDate = registrationDate;
            this.EnterpriseType = enterpriseType;
            this.BusinessStartDate = businessStartDate;
            this.OldRegistrationNumber = oldRegistrationNumber;
            this.ShortName = shortName;
            this.TranslatedName = translatedName;
            this.StatusDate = statusDate;
            this.SicCode = sicCode;
            this.PostalAddress = postalAddress;
            this.PhysicalAddress = physicalAddress;
            this.Region = region;
            this.Country = country;
            this.CountryOfOrigin = countryOfOrigin;
            this.CkDate = ckDate;
            this.CkDateRecieved = ckDateRecieved;
            this.Industry = industry;
            this.TypeDate = typeDate;
            this.ConversionNumber = conversionNumber;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNumber
        /// </summary>
        [DataMember(Name="registrationNumber", EmitDefaultValue=false)]
        public WindeedCipcRegistrationNumber RegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets CompanyStatus
        /// </summary>
        [DataMember(Name="companyStatus", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup CompanyStatus { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name="registrationDate", EmitDefaultValue=true)]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets EnterpriseType
        /// </summary>
        [DataMember(Name="enterpriseType", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup EnterpriseType { get; set; }

        /// <summary>
        /// Gets or Sets BusinessStartDate
        /// </summary>
        [DataMember(Name="businessStartDate", EmitDefaultValue=true)]
        public DateTime? BusinessStartDate { get; set; }

        /// <summary>
        /// Gets or Sets OldRegistrationNumber
        /// </summary>
        [DataMember(Name="oldRegistrationNumber", EmitDefaultValue=true)]
        public string OldRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="shortName", EmitDefaultValue=true)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets TranslatedName
        /// </summary>
        [DataMember(Name="translatedName", EmitDefaultValue=true)]
        public string TranslatedName { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name="statusDate", EmitDefaultValue=true)]
        public DateTime? StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=true)]
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="postalAddress", EmitDefaultValue=false)]
        public WindeedCipcBasicAddress PostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalAddress
        /// </summary>
        [DataMember(Name="physicalAddress", EmitDefaultValue=false)]
        public WindeedCipcBasicAddress PhysicalAddress { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup Region { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup Country { get; set; }

        /// <summary>
        /// Gets or Sets CountryOfOrigin
        /// </summary>
        [DataMember(Name="countryOfOrigin", EmitDefaultValue=true)]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// Gets or Sets CkDate
        /// </summary>
        [DataMember(Name="ckDate", EmitDefaultValue=true)]
        public DateTime? CkDate { get; set; }

        /// <summary>
        /// Gets or Sets CkDateRecieved
        /// </summary>
        [DataMember(Name="ckDateRecieved", EmitDefaultValue=true)]
        public DateTime? CkDateRecieved { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup Industry { get; set; }

        /// <summary>
        /// Gets or Sets TypeDate
        /// </summary>
        [DataMember(Name="typeDate", EmitDefaultValue=true)]
        public DateTime? TypeDate { get; set; }

        /// <summary>
        /// Gets or Sets ConversionNumber
        /// </summary>
        [DataMember(Name="conversionNumber", EmitDefaultValue=true)]
        public string ConversionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedCipcCompanyInformation {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  CompanyStatus: ").Append(CompanyStatus).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  EnterpriseType: ").Append(EnterpriseType).Append("\n");
            sb.Append("  BusinessStartDate: ").Append(BusinessStartDate).Append("\n");
            sb.Append("  OldRegistrationNumber: ").Append(OldRegistrationNumber).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  TranslatedName: ").Append(TranslatedName).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  PhysicalAddress: ").Append(PhysicalAddress).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
            sb.Append("  CkDate: ").Append(CkDate).Append("\n");
            sb.Append("  CkDateRecieved: ").Append(CkDateRecieved).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  TypeDate: ").Append(TypeDate).Append("\n");
            sb.Append("  ConversionNumber: ").Append(ConversionNumber).Append("\n");
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
            return this.Equals(input as WindeedCipcCompanyInformation);
        }

        /// <summary>
        /// Returns true if WindeedCipcCompanyInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedCipcCompanyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedCipcCompanyInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.CompanyStatus == input.CompanyStatus ||
                    (this.CompanyStatus != null &&
                    this.CompanyStatus.Equals(input.CompanyStatus))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.EnterpriseType == input.EnterpriseType ||
                    (this.EnterpriseType != null &&
                    this.EnterpriseType.Equals(input.EnterpriseType))
                ) && 
                (
                    this.BusinessStartDate == input.BusinessStartDate ||
                    (this.BusinessStartDate != null &&
                    this.BusinessStartDate.Equals(input.BusinessStartDate))
                ) && 
                (
                    this.OldRegistrationNumber == input.OldRegistrationNumber ||
                    (this.OldRegistrationNumber != null &&
                    this.OldRegistrationNumber.Equals(input.OldRegistrationNumber))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.TranslatedName == input.TranslatedName ||
                    (this.TranslatedName != null &&
                    this.TranslatedName.Equals(input.TranslatedName))
                ) && 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.SicCode == input.SicCode ||
                    (this.SicCode != null &&
                    this.SicCode.Equals(input.SicCode))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                ) && 
                (
                    this.PhysicalAddress == input.PhysicalAddress ||
                    (this.PhysicalAddress != null &&
                    this.PhysicalAddress.Equals(input.PhysicalAddress))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryOfOrigin == input.CountryOfOrigin ||
                    (this.CountryOfOrigin != null &&
                    this.CountryOfOrigin.Equals(input.CountryOfOrigin))
                ) && 
                (
                    this.CkDate == input.CkDate ||
                    (this.CkDate != null &&
                    this.CkDate.Equals(input.CkDate))
                ) && 
                (
                    this.CkDateRecieved == input.CkDateRecieved ||
                    (this.CkDateRecieved != null &&
                    this.CkDateRecieved.Equals(input.CkDateRecieved))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.TypeDate == input.TypeDate ||
                    (this.TypeDate != null &&
                    this.TypeDate.Equals(input.TypeDate))
                ) && 
                (
                    this.ConversionNumber == input.ConversionNumber ||
                    (this.ConversionNumber != null &&
                    this.ConversionNumber.Equals(input.ConversionNumber))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.CompanyStatus != null)
                    hashCode = hashCode * 59 + this.CompanyStatus.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.EnterpriseType != null)
                    hashCode = hashCode * 59 + this.EnterpriseType.GetHashCode();
                if (this.BusinessStartDate != null)
                    hashCode = hashCode * 59 + this.BusinessStartDate.GetHashCode();
                if (this.OldRegistrationNumber != null)
                    hashCode = hashCode * 59 + this.OldRegistrationNumber.GetHashCode();
                if (this.ShortName != null)
                    hashCode = hashCode * 59 + this.ShortName.GetHashCode();
                if (this.TranslatedName != null)
                    hashCode = hashCode * 59 + this.TranslatedName.GetHashCode();
                if (this.StatusDate != null)
                    hashCode = hashCode * 59 + this.StatusDate.GetHashCode();
                if (this.SicCode != null)
                    hashCode = hashCode * 59 + this.SicCode.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.PhysicalAddress != null)
                    hashCode = hashCode * 59 + this.PhysicalAddress.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.CountryOfOrigin != null)
                    hashCode = hashCode * 59 + this.CountryOfOrigin.GetHashCode();
                if (this.CkDate != null)
                    hashCode = hashCode * 59 + this.CkDate.GetHashCode();
                if (this.CkDateRecieved != null)
                    hashCode = hashCode * 59 + this.CkDateRecieved.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.TypeDate != null)
                    hashCode = hashCode * 59 + this.TypeDate.GetHashCode();
                if (this.ConversionNumber != null)
                    hashCode = hashCode * 59 + this.ConversionNumber.GetHashCode();
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