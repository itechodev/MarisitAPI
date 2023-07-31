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
    /// TransunionBusinessSearchRegistrationRequest
    /// </summary>
    [DataContract]
    public partial class TransunionBusinessSearchRegistrationRequest :  IEquatable<TransunionBusinessSearchRegistrationRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public TransunionCommercialEnquiryReason Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionBusinessSearchRegistrationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransunionBusinessSearchRegistrationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionBusinessSearchRegistrationRequest" /> class.
        /// </summary>
        /// <param name="registrationNumber">registrationNumber (required).</param>
        /// <param name="reason">reason (required).</param>
        /// <param name="reference">reference.</param>
        public TransunionBusinessSearchRegistrationRequest(string registrationNumber = default(string), TransunionCommercialEnquiryReason reason = default(TransunionCommercialEnquiryReason), string reference = default(string))
        {
            // to ensure "registrationNumber" is required (not null)
            if (registrationNumber == null)
            {
                throw new InvalidDataException("registrationNumber is a required property for TransunionBusinessSearchRegistrationRequest and cannot be null");
            }
            else
            {
                this.RegistrationNumber = registrationNumber;
            }

            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for TransunionBusinessSearchRegistrationRequest and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }

            this.Reference = reference;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets RegistrationNumber
        /// </summary>
        [DataMember(Name="registrationNumber", EmitDefaultValue=true)]
        public string RegistrationNumber { get; set; }


        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionBusinessSearchRegistrationRequest {\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as TransunionBusinessSearchRegistrationRequest);
        }

        /// <summary>
        /// Returns true if TransunionBusinessSearchRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionBusinessSearchRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionBusinessSearchRegistrationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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
            // RegistrationNumber (string) maxLength
            if(this.RegistrationNumber != null && this.RegistrationNumber.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegistrationNumber, length must be less than 12.", new [] { "RegistrationNumber" });
            }

            // RegistrationNumber (string) minLength
            if(this.RegistrationNumber != null && this.RegistrationNumber.Length < 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegistrationNumber, length must be greater than 12.", new [] { "RegistrationNumber" });
            }

            // RegistrationNumber (string) pattern
            Regex regexRegistrationNumber = new Regex(@"^[0-9]*$", RegexOptions.CultureInvariant);
            if (false == regexRegistrationNumber.Match(this.RegistrationNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegistrationNumber, must match a pattern of " + regexRegistrationNumber, new [] { "RegistrationNumber" });
            }

            yield break;
        }
    }

}