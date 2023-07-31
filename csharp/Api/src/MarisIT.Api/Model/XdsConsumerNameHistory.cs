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
    /// XdsConsumerNameHistory
    /// </summary>
    [DataContract]
    public partial class XdsConsumerNameHistory :  IEquatable<XdsConsumerNameHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumerNameHistory" /> class.
        /// </summary>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="idNo">idNo.</param>
        /// <param name="initials">initials.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        /// <param name="passportNo">passportNo.</param>
        /// <param name="secondName">secondName.</param>
        /// <param name="surname">surname.</param>
        /// <param name="titleDesc">titleDesc.</param>
        public XdsConsumerNameHistory(string birthDate = default(string), string firstName = default(string), string idNo = default(string), string initials = default(string), string lastUpdatedDate = default(string), string passportNo = default(string), string secondName = default(string), string surname = default(string), string titleDesc = default(string))
        {
            this.BirthDate = birthDate;
            this.FirstName = firstName;
            this.IdNo = idNo;
            this.Initials = initials;
            this.LastUpdatedDate = lastUpdatedDate;
            this.PassportNo = passportNo;
            this.SecondName = secondName;
            this.Surname = surname;
            this.TitleDesc = titleDesc;
            this.BirthDate = birthDate;
            this.FirstName = firstName;
            this.IdNo = idNo;
            this.Initials = initials;
            this.LastUpdatedDate = lastUpdatedDate;
            this.PassportNo = passportNo;
            this.SecondName = secondName;
            this.Surname = surname;
            this.TitleDesc = titleDesc;
        }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name="birthDate", EmitDefaultValue=true)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets IdNo
        /// </summary>
        [DataMember(Name="idNo", EmitDefaultValue=true)]
        public string IdNo { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=true)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=true)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Gets or Sets PassportNo
        /// </summary>
        [DataMember(Name="passportNo", EmitDefaultValue=true)]
        public string PassportNo { get; set; }

        /// <summary>
        /// Gets or Sets SecondName
        /// </summary>
        [DataMember(Name="secondName", EmitDefaultValue=true)]
        public string SecondName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets TitleDesc
        /// </summary>
        [DataMember(Name="titleDesc", EmitDefaultValue=true)]
        public string TitleDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumerNameHistory {\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  IdNo: ").Append(IdNo).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  PassportNo: ").Append(PassportNo).Append("\n");
            sb.Append("  SecondName: ").Append(SecondName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  TitleDesc: ").Append(TitleDesc).Append("\n");
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
            return this.Equals(input as XdsConsumerNameHistory);
        }

        /// <summary>
        /// Returns true if XdsConsumerNameHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumerNameHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumerNameHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.IdNo == input.IdNo ||
                    (this.IdNo != null &&
                    this.IdNo.Equals(input.IdNo))
                ) && 
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                    this.Initials.Equals(input.Initials))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) && 
                (
                    this.PassportNo == input.PassportNo ||
                    (this.PassportNo != null &&
                    this.PassportNo.Equals(input.PassportNo))
                ) && 
                (
                    this.SecondName == input.SecondName ||
                    (this.SecondName != null &&
                    this.SecondName.Equals(input.SecondName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.TitleDesc == input.TitleDesc ||
                    (this.TitleDesc != null &&
                    this.TitleDesc.Equals(input.TitleDesc))
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
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.IdNo != null)
                    hashCode = hashCode * 59 + this.IdNo.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.PassportNo != null)
                    hashCode = hashCode * 59 + this.PassportNo.GetHashCode();
                if (this.SecondName != null)
                    hashCode = hashCode * 59 + this.SecondName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.TitleDesc != null)
                    hashCode = hashCode * 59 + this.TitleDesc.GetHashCode();
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
