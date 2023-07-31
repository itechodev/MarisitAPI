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
    /// TransunionConsumer118EmployeeDTO
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EmployeeDTO :  IEquatable<TransunionConsumer118EmployeeDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EmployeeDTO" /> class.
        /// </summary>
        /// <param name="identityNumber">identityNumber.</param>
        /// <param name="title">title.</param>
        /// <param name="initials">initials.</param>
        /// <param name="fullNames">fullNames.</param>
        /// <param name="surname">surname.</param>
        /// <param name="demographics">demographics.</param>
        public TransunionConsumer118EmployeeDTO(string identityNumber = default(string), string title = default(string), string initials = default(string), string fullNames = default(string), string surname = default(string), List<TransunionConsumer118DemographicsDTO> demographics = default(List<TransunionConsumer118DemographicsDTO>))
        {
            this.IdentityNumber = identityNumber;
            this.Title = title;
            this.Initials = initials;
            this.FullNames = fullNames;
            this.Surname = surname;
            this.Demographics = demographics;
            this.IdentityNumber = identityNumber;
            this.Title = title;
            this.Initials = initials;
            this.FullNames = fullNames;
            this.Surname = surname;
            this.Demographics = demographics;
        }

        /// <summary>
        /// Gets or Sets IdentityNumber
        /// </summary>
        [DataMember(Name="identityNumber", EmitDefaultValue=true)]
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=true)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets FullNames
        /// </summary>
        [DataMember(Name="fullNames", EmitDefaultValue=true)]
        public string FullNames { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name="demographics", EmitDefaultValue=true)]
        public List<TransunionConsumer118DemographicsDTO> Demographics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EmployeeDTO {\n");
            sb.Append("  IdentityNumber: ").Append(IdentityNumber).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  FullNames: ").Append(FullNames).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EmployeeDTO);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EmployeeDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EmployeeDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EmployeeDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityNumber == input.IdentityNumber ||
                    (this.IdentityNumber != null &&
                    this.IdentityNumber.Equals(input.IdentityNumber))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                    this.Initials.Equals(input.Initials))
                ) && 
                (
                    this.FullNames == input.FullNames ||
                    (this.FullNames != null &&
                    this.FullNames.Equals(input.FullNames))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Demographics == input.Demographics ||
                    this.Demographics != null &&
                    input.Demographics != null &&
                    this.Demographics.SequenceEqual(input.Demographics)
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
                if (this.IdentityNumber != null)
                    hashCode = hashCode * 59 + this.IdentityNumber.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.FullNames != null)
                    hashCode = hashCode * 59 + this.FullNames.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Demographics != null)
                    hashCode = hashCode * 59 + this.Demographics.GetHashCode();
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