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
    /// VericredPersonalVerification
    /// </summary>
    [DataContract]
    public partial class VericredPersonalVerification :  IEquatable<VericredPersonalVerification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VericredPersonalVerification" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="surname">surname.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="maidenName">maidenName.</param>
        /// <param name="initials">initials.</param>
        /// <param name="married">married.</param>
        /// <param name="deceased">deceased.</param>
        /// <param name="deceasedDate">deceasedDate.</param>
        /// <param name="deathPlace">deathPlace.</param>
        public VericredPersonalVerification(string error = default(string), string isValid = default(string), string dateOfBirth = default(string), string surname = default(string), string fullName = default(string), string maidenName = default(string), string initials = default(string), string married = default(string), string deceased = default(string), string deceasedDate = default(string), string deathPlace = default(string))
        {
            this.Error = error;
            this.IsValid = isValid;
            this.DateOfBirth = dateOfBirth;
            this.Surname = surname;
            this.FullName = fullName;
            this.MaidenName = maidenName;
            this.Initials = initials;
            this.Married = married;
            this.Deceased = deceased;
            this.DeceasedDate = deceasedDate;
            this.DeathPlace = deathPlace;
            this.Error = error;
            this.IsValid = isValid;
            this.DateOfBirth = dateOfBirth;
            this.Surname = surname;
            this.FullName = fullName;
            this.MaidenName = maidenName;
            this.Initials = initials;
            this.Married = married;
            this.Deceased = deceased;
            this.DeceasedDate = deceasedDate;
            this.DeathPlace = deathPlace;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name="is_Valid", EmitDefaultValue=true)]
        public string IsValid { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="date_Of_Birth", EmitDefaultValue=true)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="fullName", EmitDefaultValue=true)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets MaidenName
        /// </summary>
        [DataMember(Name="maiden_Name", EmitDefaultValue=true)]
        public string MaidenName { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=true)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets Married
        /// </summary>
        [DataMember(Name="married", EmitDefaultValue=true)]
        public string Married { get; set; }

        /// <summary>
        /// Gets or Sets Deceased
        /// </summary>
        [DataMember(Name="deceased", EmitDefaultValue=true)]
        public string Deceased { get; set; }

        /// <summary>
        /// Gets or Sets DeceasedDate
        /// </summary>
        [DataMember(Name="deceased_Date", EmitDefaultValue=true)]
        public string DeceasedDate { get; set; }

        /// <summary>
        /// Gets or Sets DeathPlace
        /// </summary>
        [DataMember(Name="death_Place", EmitDefaultValue=true)]
        public string DeathPlace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VericredPersonalVerification {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  MaidenName: ").Append(MaidenName).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  Married: ").Append(Married).Append("\n");
            sb.Append("  Deceased: ").Append(Deceased).Append("\n");
            sb.Append("  DeceasedDate: ").Append(DeceasedDate).Append("\n");
            sb.Append("  DeathPlace: ").Append(DeathPlace).Append("\n");
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
            return this.Equals(input as VericredPersonalVerification);
        }

        /// <summary>
        /// Returns true if VericredPersonalVerification instances are equal
        /// </summary>
        /// <param name="input">Instance of VericredPersonalVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VericredPersonalVerification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.MaidenName == input.MaidenName ||
                    (this.MaidenName != null &&
                    this.MaidenName.Equals(input.MaidenName))
                ) && 
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                    this.Initials.Equals(input.Initials))
                ) && 
                (
                    this.Married == input.Married ||
                    (this.Married != null &&
                    this.Married.Equals(input.Married))
                ) && 
                (
                    this.Deceased == input.Deceased ||
                    (this.Deceased != null &&
                    this.Deceased.Equals(input.Deceased))
                ) && 
                (
                    this.DeceasedDate == input.DeceasedDate ||
                    (this.DeceasedDate != null &&
                    this.DeceasedDate.Equals(input.DeceasedDate))
                ) && 
                (
                    this.DeathPlace == input.DeathPlace ||
                    (this.DeathPlace != null &&
                    this.DeathPlace.Equals(input.DeathPlace))
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.MaidenName != null)
                    hashCode = hashCode * 59 + this.MaidenName.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.Married != null)
                    hashCode = hashCode * 59 + this.Married.GetHashCode();
                if (this.Deceased != null)
                    hashCode = hashCode * 59 + this.Deceased.GetHashCode();
                if (this.DeceasedDate != null)
                    hashCode = hashCode * 59 + this.DeceasedDate.GetHashCode();
                if (this.DeathPlace != null)
                    hashCode = hashCode * 59 + this.DeathPlace.GetHashCode();
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