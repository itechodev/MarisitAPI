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
    /// XdsBusinessRescue
    /// </summary>
    [DataContract]
    public partial class XdsBusinessRescue :  IEquatable<XdsBusinessRescue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsBusinessRescue" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="businessRescuePractioner">businessRescuePractioner.</param>
        /// <param name="contactInformation">contactInformation.</param>
        /// <param name="details">details.</param>
        public XdsBusinessRescue(string date = default(string), string businessRescuePractioner = default(string), string contactInformation = default(string), string details = default(string))
        {
            this.Date = date;
            this.BusinessRescuePractioner = businessRescuePractioner;
            this.ContactInformation = contactInformation;
            this.Details = details;
            this.Date = date;
            this.BusinessRescuePractioner = businessRescuePractioner;
            this.ContactInformation = contactInformation;
            this.Details = details;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets BusinessRescuePractioner
        /// </summary>
        [DataMember(Name="businessRescuePractioner", EmitDefaultValue=true)]
        public string BusinessRescuePractioner { get; set; }

        /// <summary>
        /// Gets or Sets ContactInformation
        /// </summary>
        [DataMember(Name="contactInformation", EmitDefaultValue=true)]
        public string ContactInformation { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=true)]
        public string Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsBusinessRescue {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  BusinessRescuePractioner: ").Append(BusinessRescuePractioner).Append("\n");
            sb.Append("  ContactInformation: ").Append(ContactInformation).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as XdsBusinessRescue);
        }

        /// <summary>
        /// Returns true if XdsBusinessRescue instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsBusinessRescue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsBusinessRescue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.BusinessRescuePractioner == input.BusinessRescuePractioner ||
                    (this.BusinessRescuePractioner != null &&
                    this.BusinessRescuePractioner.Equals(input.BusinessRescuePractioner))
                ) && 
                (
                    this.ContactInformation == input.ContactInformation ||
                    (this.ContactInformation != null &&
                    this.ContactInformation.Equals(input.ContactInformation))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.BusinessRescuePractioner != null)
                    hashCode = hashCode * 59 + this.BusinessRescuePractioner.GetHashCode();
                if (this.ContactInformation != null)
                    hashCode = hashCode * 59 + this.ContactInformation.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
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