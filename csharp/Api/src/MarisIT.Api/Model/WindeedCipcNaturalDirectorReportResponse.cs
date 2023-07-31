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
    /// WindeedCipcNaturalDirectorReportResponse
    /// </summary>
    [DataContract]
    public partial class WindeedCipcNaturalDirectorReportResponse :  IEquatable<WindeedCipcNaturalDirectorReportResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedCipcNaturalDirectorReportResponse" /> class.
        /// </summary>
        /// <param name="dbKey">dbKey.</param>
        /// <param name="country">country.</param>
        /// <param name="southAfricanResident">southAfricanResident.</param>
        /// <param name="associatedCompanies">associatedCompanies.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="maidenName">maidenName.</param>
        /// <param name="surnameParticular">surnameParticular.</param>
        public WindeedCipcNaturalDirectorReportResponse(int dbKey = default(int), WindeedCipcCipcLookup country = default(WindeedCipcCipcLookup), bool? southAfricanResident = default(bool?), List<WindeedCipcAssociatedCompany> associatedCompanies = default(List<WindeedCipcAssociatedCompany>), WindeedCipcCipcLookup nationality = default(WindeedCipcCipcLookup), DateTime? dateOfBirth = default(DateTime?), string firstName = default(string), string lastName = default(string), string idNumber = default(string), string maidenName = default(string), string surnameParticular = default(string))
        {
            this.SouthAfricanResident = southAfricanResident;
            this.AssociatedCompanies = associatedCompanies;
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdNumber = idNumber;
            this.MaidenName = maidenName;
            this.SurnameParticular = surnameParticular;
            this.DbKey = dbKey;
            this.Country = country;
            this.SouthAfricanResident = southAfricanResident;
            this.AssociatedCompanies = associatedCompanies;
            this.Nationality = nationality;
            this.DateOfBirth = dateOfBirth;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdNumber = idNumber;
            this.MaidenName = maidenName;
            this.SurnameParticular = surnameParticular;
        }

        /// <summary>
        /// Gets or Sets DbKey
        /// </summary>
        [DataMember(Name="dbKey", EmitDefaultValue=false)]
        public int DbKey { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup Country { get; set; }

        /// <summary>
        /// Gets or Sets SouthAfricanResident
        /// </summary>
        [DataMember(Name="southAfricanResident", EmitDefaultValue=true)]
        public bool? SouthAfricanResident { get; set; }

        /// <summary>
        /// Gets or Sets AssociatedCompanies
        /// </summary>
        [DataMember(Name="associatedCompanies", EmitDefaultValue=true)]
        public List<WindeedCipcAssociatedCompany> AssociatedCompanies { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name="nationality", EmitDefaultValue=false)]
        public WindeedCipcCipcLookup Nationality { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=true)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets MaidenName
        /// </summary>
        [DataMember(Name="maidenName", EmitDefaultValue=true)]
        public string MaidenName { get; set; }

        /// <summary>
        /// Gets or Sets SurnameParticular
        /// </summary>
        [DataMember(Name="surnameParticular", EmitDefaultValue=true)]
        public string SurnameParticular { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedCipcNaturalDirectorReportResponse {\n");
            sb.Append("  DbKey: ").Append(DbKey).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  SouthAfricanResident: ").Append(SouthAfricanResident).Append("\n");
            sb.Append("  AssociatedCompanies: ").Append(AssociatedCompanies).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  MaidenName: ").Append(MaidenName).Append("\n");
            sb.Append("  SurnameParticular: ").Append(SurnameParticular).Append("\n");
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
            return this.Equals(input as WindeedCipcNaturalDirectorReportResponse);
        }

        /// <summary>
        /// Returns true if WindeedCipcNaturalDirectorReportResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedCipcNaturalDirectorReportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedCipcNaturalDirectorReportResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbKey == input.DbKey ||
                    (this.DbKey != null &&
                    this.DbKey.Equals(input.DbKey))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.SouthAfricanResident == input.SouthAfricanResident ||
                    (this.SouthAfricanResident != null &&
                    this.SouthAfricanResident.Equals(input.SouthAfricanResident))
                ) && 
                (
                    this.AssociatedCompanies == input.AssociatedCompanies ||
                    this.AssociatedCompanies != null &&
                    input.AssociatedCompanies != null &&
                    this.AssociatedCompanies.SequenceEqual(input.AssociatedCompanies)
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.MaidenName == input.MaidenName ||
                    (this.MaidenName != null &&
                    this.MaidenName.Equals(input.MaidenName))
                ) && 
                (
                    this.SurnameParticular == input.SurnameParticular ||
                    (this.SurnameParticular != null &&
                    this.SurnameParticular.Equals(input.SurnameParticular))
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
                if (this.DbKey != null)
                    hashCode = hashCode * 59 + this.DbKey.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.SouthAfricanResident != null)
                    hashCode = hashCode * 59 + this.SouthAfricanResident.GetHashCode();
                if (this.AssociatedCompanies != null)
                    hashCode = hashCode * 59 + this.AssociatedCompanies.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.MaidenName != null)
                    hashCode = hashCode * 59 + this.MaidenName.GetHashCode();
                if (this.SurnameParticular != null)
                    hashCode = hashCode * 59 + this.SurnameParticular.GetHashCode();
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