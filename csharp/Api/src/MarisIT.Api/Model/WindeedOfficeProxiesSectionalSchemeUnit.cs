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
    /// WindeedOfficeProxiesSectionalSchemeUnit
    /// </summary>
    [DataContract]
    public partial class WindeedOfficeProxiesSectionalSchemeUnit :  IEquatable<WindeedOfficeProxiesSectionalSchemeUnit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedOfficeProxiesSectionalSchemeUnit" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        /// <param name="titleDeedNumber">titleDeedNumber.</param>
        /// <param name="number">number.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="type">type.</param>
        public WindeedOfficeProxiesSectionalSchemeUnit(string reference = default(string), string titleDeedNumber = default(string), string number = default(string), DateTime? registrationDate = default(DateTime?), string type = default(string))
        {
            this.Reference = reference;
            this.TitleDeedNumber = titleDeedNumber;
            this.Number = number;
            this.RegistrationDate = registrationDate;
            this.Type = type;
            this.Reference = reference;
            this.TitleDeedNumber = titleDeedNumber;
            this.Number = number;
            this.RegistrationDate = registrationDate;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets TitleDeedNumber
        /// </summary>
        [DataMember(Name="titleDeedNumber", EmitDefaultValue=true)]
        public string TitleDeedNumber { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name="registrationDate", EmitDefaultValue=true)]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedOfficeProxiesSectionalSchemeUnit {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  TitleDeedNumber: ").Append(TitleDeedNumber).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WindeedOfficeProxiesSectionalSchemeUnit);
        }

        /// <summary>
        /// Returns true if WindeedOfficeProxiesSectionalSchemeUnit instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedOfficeProxiesSectionalSchemeUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedOfficeProxiesSectionalSchemeUnit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.TitleDeedNumber == input.TitleDeedNumber ||
                    (this.TitleDeedNumber != null &&
                    this.TitleDeedNumber.Equals(input.TitleDeedNumber))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.TitleDeedNumber != null)
                    hashCode = hashCode * 59 + this.TitleDeedNumber.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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