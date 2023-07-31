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
    /// TransunionBusinessSearchDunsRequest
    /// </summary>
    [DataContract]
    public partial class TransunionBusinessSearchDunsRequest :  IEquatable<TransunionBusinessSearchDunsRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public TransunionCommercialEnquiryReason Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionBusinessSearchDunsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransunionBusinessSearchDunsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionBusinessSearchDunsRequest" /> class.
        /// </summary>
        /// <param name="dunsNumber">dunsNumber (required).</param>
        /// <param name="reason">reason (required).</param>
        /// <param name="reference">reference.</param>
        public TransunionBusinessSearchDunsRequest(string dunsNumber = default(string), TransunionCommercialEnquiryReason reason = default(TransunionCommercialEnquiryReason), string reference = default(string))
        {
            // to ensure "dunsNumber" is required (not null)
            if (dunsNumber == null)
            {
                throw new InvalidDataException("dunsNumber is a required property for TransunionBusinessSearchDunsRequest and cannot be null");
            }
            else
            {
                this.DunsNumber = dunsNumber;
            }

            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new InvalidDataException("reason is a required property for TransunionBusinessSearchDunsRequest and cannot be null");
            }
            else
            {
                this.Reason = reason;
            }

            this.Reference = reference;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets DunsNumber
        /// </summary>
        [DataMember(Name="dunsNumber", EmitDefaultValue=true)]
        public string DunsNumber { get; set; }


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
            sb.Append("class TransunionBusinessSearchDunsRequest {\n");
            sb.Append("  DunsNumber: ").Append(DunsNumber).Append("\n");
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
            return this.Equals(input as TransunionBusinessSearchDunsRequest);
        }

        /// <summary>
        /// Returns true if TransunionBusinessSearchDunsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionBusinessSearchDunsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionBusinessSearchDunsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DunsNumber == input.DunsNumber ||
                    (this.DunsNumber != null &&
                    this.DunsNumber.Equals(input.DunsNumber))
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
                if (this.DunsNumber != null)
                    hashCode = hashCode * 59 + this.DunsNumber.GetHashCode();
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
            yield break;
        }
    }

}