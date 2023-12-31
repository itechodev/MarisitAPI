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
    /// ServicesXdsKnowYourClientPassportRequest
    /// </summary>
    [DataContract]
    public partial class ServicesXdsKnowYourClientPassportRequest :  IEquatable<ServicesXdsKnowYourClientPassportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesXdsKnowYourClientPassportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServicesXdsKnowYourClientPassportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicesXdsKnowYourClientPassportRequest" /> class.
        /// </summary>
        /// <param name="passportNumber">passportNumber (required).</param>
        /// <param name="addressLine1">addressLine1 (required).</param>
        /// <param name="addressLine2">addressLine2 (required).</param>
        /// <param name="addressLine3">addressLine3.</param>
        /// <param name="addressLine4">addressLine4.</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="reference">reference.</param>
        public ServicesXdsKnowYourClientPassportRequest(string passportNumber = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string addressLine4 = default(string), string postalCode = default(string), string reference = default(string))
        {
            // to ensure "passportNumber" is required (not null)
            if (passportNumber == null)
            {
                throw new InvalidDataException("passportNumber is a required property for ServicesXdsKnowYourClientPassportRequest and cannot be null");
            }
            else
            {
                this.PassportNumber = passportNumber;
            }

            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new InvalidDataException("addressLine1 is a required property for ServicesXdsKnowYourClientPassportRequest and cannot be null");
            }
            else
            {
                this.AddressLine1 = addressLine1;
            }

            // to ensure "addressLine2" is required (not null)
            if (addressLine2 == null)
            {
                throw new InvalidDataException("addressLine2 is a required property for ServicesXdsKnowYourClientPassportRequest and cannot be null");
            }
            else
            {
                this.AddressLine2 = addressLine2;
            }

            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new InvalidDataException("postalCode is a required property for ServicesXdsKnowYourClientPassportRequest and cannot be null");
            }
            else
            {
                this.PostalCode = postalCode;
            }

            this.Reference = reference;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets PassportNumber
        /// </summary>
        [DataMember(Name="passportNumber", EmitDefaultValue=true)]
        public string PassportNumber { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="addressLine1", EmitDefaultValue=true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=true)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine3
        /// </summary>
        [DataMember(Name="addressLine3", EmitDefaultValue=true)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine4
        /// </summary>
        [DataMember(Name="addressLine4", EmitDefaultValue=true)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=true)]
        public string PostalCode { get; set; }

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
            sb.Append("class ServicesXdsKnowYourClientPassportRequest {\n");
            sb.Append("  PassportNumber: ").Append(PassportNumber).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as ServicesXdsKnowYourClientPassportRequest);
        }

        /// <summary>
        /// Returns true if ServicesXdsKnowYourClientPassportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ServicesXdsKnowYourClientPassportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServicesXdsKnowYourClientPassportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PassportNumber == input.PassportNumber ||
                    (this.PassportNumber != null &&
                    this.PassportNumber.Equals(input.PassportNumber))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.AddressLine4 == input.AddressLine4 ||
                    (this.AddressLine4 != null &&
                    this.AddressLine4.Equals(input.AddressLine4))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.PassportNumber != null)
                    hashCode = hashCode * 59 + this.PassportNumber.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.AddressLine4 != null)
                    hashCode = hashCode * 59 + this.AddressLine4.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
            yield break;
        }
    }

}
