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
    /// VerifyMatricCertificateRequest
    /// </summary>
    [DataContract]
    public partial class VerifyMatricCertificateRequest :  IEquatable<VerifyMatricCertificateRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=false)]
        public WebDatabaseTablesProvincesEnum? Province { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyMatricCertificateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyMatricCertificateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyMatricCertificateRequest" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="contactNumber">contactNumber (required).</param>
        /// <param name="reference">reference (required).</param>
        /// <param name="callbackUrl">callbackUrl (required).</param>
        /// <param name="name">name.</param>
        /// <param name="surname">surname.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="town">town.</param>
        /// <param name="province">province.</param>
        /// <param name="certificateNumber">certificateNumber.</param>
        /// <param name="yearIssued">yearIssued.</param>
        /// <param name="certificateDocument">certificateDocument.</param>
        /// <param name="consentDocument">consentDocument.</param>
        /// <param name="verifySymbols">verifySymbols.</param>
        public VerifyMatricCertificateRequest(string email = default(string), string contactNumber = default(string), string reference = default(string), string callbackUrl = default(string), string name = default(string), string surname = default(string), string idNumber = default(string), string town = default(string), WebDatabaseTablesProvincesEnum? province = default(WebDatabaseTablesProvincesEnum?), string certificateNumber = default(string), int yearIssued = default(int), System.IO.Stream certificateDocument = default(System.IO.Stream), System.IO.Stream consentDocument = default(System.IO.Stream), bool verifySymbols = default(bool))
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new InvalidDataException("email is a required property for VerifyMatricCertificateRequest and cannot be null");
            }
            else
            {
                this.Email = email;
            }

            // to ensure "contactNumber" is required (not null)
            if (contactNumber == null)
            {
                throw new InvalidDataException("contactNumber is a required property for VerifyMatricCertificateRequest and cannot be null");
            }
            else
            {
                this.ContactNumber = contactNumber;
            }

            // to ensure "reference" is required (not null)
            if (reference == null)
            {
                throw new InvalidDataException("reference is a required property for VerifyMatricCertificateRequest and cannot be null");
            }
            else
            {
                this.Reference = reference;
            }

            // to ensure "callbackUrl" is required (not null)
            if (callbackUrl == null)
            {
                throw new InvalidDataException("callbackUrl is a required property for VerifyMatricCertificateRequest and cannot be null");
            }
            else
            {
                this.CallbackUrl = callbackUrl;
            }

            this.Name = name;
            this.Surname = surname;
            this.IdNumber = idNumber;
            this.Town = town;
            this.CertificateNumber = certificateNumber;
            this.CertificateDocument = certificateDocument;
            this.ConsentDocument = consentDocument;
            this.Name = name;
            this.Surname = surname;
            this.IdNumber = idNumber;
            this.Town = town;
            this.Province = province;
            this.CertificateNumber = certificateNumber;
            this.YearIssued = yearIssued;
            this.CertificateDocument = certificateDocument;
            this.ConsentDocument = consentDocument;
            this.VerifySymbols = verifySymbols;
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
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets Town
        /// </summary>
        [DataMember(Name="town", EmitDefaultValue=true)]
        public string Town { get; set; }


        /// <summary>
        /// Gets or Sets CertificateNumber
        /// </summary>
        [DataMember(Name="certificateNumber", EmitDefaultValue=true)]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// Gets or Sets YearIssued
        /// </summary>
        [DataMember(Name="yearIssued", EmitDefaultValue=false)]
        public int YearIssued { get; set; }

        /// <summary>
        /// Gets or Sets CertificateDocument
        /// </summary>
        [DataMember(Name="certificateDocument", EmitDefaultValue=true)]
        public System.IO.Stream CertificateDocument { get; set; }

        /// <summary>
        /// Gets or Sets ConsentDocument
        /// </summary>
        [DataMember(Name="consentDocument", EmitDefaultValue=true)]
        public System.IO.Stream ConsentDocument { get; set; }

        /// <summary>
        /// Gets or Sets VerifySymbols
        /// </summary>
        [DataMember(Name="verifySymbols", EmitDefaultValue=false)]
        public bool VerifySymbols { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyMatricCertificateRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  CertificateNumber: ").Append(CertificateNumber).Append("\n");
            sb.Append("  YearIssued: ").Append(YearIssued).Append("\n");
            sb.Append("  CertificateDocument: ").Append(CertificateDocument).Append("\n");
            sb.Append("  ConsentDocument: ").Append(ConsentDocument).Append("\n");
            sb.Append("  VerifySymbols: ").Append(VerifySymbols).Append("\n");
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
            return this.Equals(input as VerifyMatricCertificateRequest);
        }

        /// <summary>
        /// Returns true if VerifyMatricCertificateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyMatricCertificateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyMatricCertificateRequest input)
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
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.CertificateNumber == input.CertificateNumber ||
                    (this.CertificateNumber != null &&
                    this.CertificateNumber.Equals(input.CertificateNumber))
                ) && 
                (
                    this.YearIssued == input.YearIssued ||
                    (this.YearIssued != null &&
                    this.YearIssued.Equals(input.YearIssued))
                ) && 
                (
                    this.CertificateDocument == input.CertificateDocument ||
                    (this.CertificateDocument != null &&
                    this.CertificateDocument.Equals(input.CertificateDocument))
                ) && 
                (
                    this.ConsentDocument == input.ConsentDocument ||
                    (this.ConsentDocument != null &&
                    this.ConsentDocument.Equals(input.ConsentDocument))
                ) && 
                (
                    this.VerifySymbols == input.VerifySymbols ||
                    (this.VerifySymbols != null &&
                    this.VerifySymbols.Equals(input.VerifySymbols))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.CertificateNumber != null)
                    hashCode = hashCode * 59 + this.CertificateNumber.GetHashCode();
                if (this.YearIssued != null)
                    hashCode = hashCode * 59 + this.YearIssued.GetHashCode();
                if (this.CertificateDocument != null)
                    hashCode = hashCode * 59 + this.CertificateDocument.GetHashCode();
                if (this.ConsentDocument != null)
                    hashCode = hashCode * 59 + this.ConsentDocument.GetHashCode();
                if (this.VerifySymbols != null)
                    hashCode = hashCode * 59 + this.VerifySymbols.GetHashCode();
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
