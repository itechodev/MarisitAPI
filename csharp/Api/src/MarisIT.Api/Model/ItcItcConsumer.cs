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
    /// ItcItcConsumer
    /// </summary>
    [DataContract]
    public partial class ItcItcConsumer :  IEquatable<ItcItcConsumer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItcItcConsumer" /> class.
        /// </summary>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="name">name.</param>
        /// <param name="surname">surname.</param>
        /// <param name="emails">emails.</param>
        /// <param name="gender">gender.</param>
        /// <param name="contactNumbers">contactNumbers.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="employers">employers.</param>
        public ItcItcConsumer(string idNumber = default(string), string name = default(string), string surname = default(string), List<string> emails = default(List<string>), string gender = default(string), List<ItcItcContactNumber> contactNumbers = default(List<ItcItcContactNumber>), List<ItcItcAddress> addresses = default(List<ItcItcAddress>), List<ItcItcEmployer> employers = default(List<ItcItcEmployer>))
        {
            this.IdNumber = idNumber;
            this.Name = name;
            this.Surname = surname;
            this.Emails = emails;
            this.Gender = gender;
            this.ContactNumbers = contactNumbers;
            this.Addresses = addresses;
            this.Employers = employers;
            this.IdNumber = idNumber;
            this.Name = name;
            this.Surname = surname;
            this.Emails = emails;
            this.Gender = gender;
            this.ContactNumbers = contactNumbers;
            this.Addresses = addresses;
            this.Employers = employers;
        }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=true)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=true)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumbers
        /// </summary>
        [DataMember(Name="contactNumbers", EmitDefaultValue=true)]
        public List<ItcItcContactNumber> ContactNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=true)]
        public List<ItcItcAddress> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Employers
        /// </summary>
        [DataMember(Name="employers", EmitDefaultValue=true)]
        public List<ItcItcEmployer> Employers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItcItcConsumer {\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  ContactNumbers: ").Append(ContactNumbers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Employers: ").Append(Employers).Append("\n");
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
            return this.Equals(input as ItcItcConsumer);
        }

        /// <summary>
        /// Returns true if ItcItcConsumer instances are equal
        /// </summary>
        /// <param name="input">Instance of ItcItcConsumer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItcItcConsumer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.ContactNumbers == input.ContactNumbers ||
                    this.ContactNumbers != null &&
                    input.ContactNumbers != null &&
                    this.ContactNumbers.SequenceEqual(input.ContactNumbers)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Employers == input.Employers ||
                    this.Employers != null &&
                    input.Employers != null &&
                    this.Employers.SequenceEqual(input.Employers)
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
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.ContactNumbers != null)
                    hashCode = hashCode * 59 + this.ContactNumbers.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Employers != null)
                    hashCode = hashCode * 59 + this.Employers.GetHashCode();
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
