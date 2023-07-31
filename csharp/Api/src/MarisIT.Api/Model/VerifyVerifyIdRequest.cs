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
    /// VerifyVerifyIdRequest
    /// </summary>
    [DataContract]
    public partial class VerifyVerifyIdRequest :  IEquatable<VerifyVerifyIdRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyVerifyIdRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyVerifyIdRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyVerifyIdRequest" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="contactNumber">contactNumber (required).</param>
        /// <param name="reference">reference (required).</param>
        /// <param name="callbackUrl">callbackUrl (required).</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="surname">surname (required).</param>
        public VerifyVerifyIdRequest(string email = default(string), string contactNumber = default(string), string reference = default(string), string callbackUrl = default(string), string idNumber = default(string), string firstName = default(string), string surname = default(string))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for VerifyVerifyIdRequest and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // to ensure "contactNumber" is required (not null)
            if (contactNumber == null)
            {
                throw new InvalidDataException("contactNumber is a required property for VerifyVerifyIdRequest and cannot be null");
            }
            else
            {
                this.ContactNumber = contactNumber;
            }

            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for VerifyVerifyIdRequest and cannot be null");
            }
            else
            {
                this.Reference = reference;
            }

            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new InvalidDataException("callbackUrl is a required property for VerifyVerifyIdRequest and cannot be null");
            }
            else
            {
                this.CallbackUrl = callbackUrl;
            }

            this.IdNumber = idNumber;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for VerifyVerifyIdRequest and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }

            // to ensure "surname" is required (not null)
            if (surname == null)
            {
                throw new InvalidDataException("surname is a required property for VerifyVerifyIdRequest and cannot be null");
            }
            else
            {
                this.Surname = surname;
            }

            this.IdNumber = idNumber;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumber
        /// </summary>
        [DataMember(Name="contactNumber", EmitDefaultValue=true)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets CallbackUrl
        /// </summary>
        [DataMember(Name="callbackUrl", EmitDefaultValue=true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyVerifyIdRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
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
            return this.Equals(input as VerifyVerifyIdRequest);
        }

        /// <summary>
        /// Returns true if VerifyVerifyIdRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyVerifyIdRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyVerifyIdRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.CallbackUrl == input.CallbackUrl ||
                    (this.CallbackUrl != null &&
                    this.CallbackUrl.Equals(input.CallbackUrl))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.CallbackUrl != null)
                    hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
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