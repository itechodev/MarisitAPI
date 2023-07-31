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
    /// CompuscanContactTelephone
    /// </summary>
    [DataContract]
    public partial class CompuscanContactTelephone :  IEquatable<CompuscanContactTelephone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompuscanContactTelephone" /> class.
        /// </summary>
        /// <param name="telephone">telephone.</param>
        /// <param name="telephoneType">telephoneType.</param>
        /// <param name="lastUpdated">lastUpdated.</param>
        /// <param name="createdDate">createdDate.</param>
        public CompuscanContactTelephone(string telephone = default(string), string telephoneType = default(string), string lastUpdated = default(string), string createdDate = default(string))
        {
            this.Telephone = telephone;
            this.TelephoneType = telephoneType;
            this.LastUpdated = lastUpdated;
            this.CreatedDate = createdDate;
            this.Telephone = telephone;
            this.TelephoneType = telephoneType;
            this.LastUpdated = lastUpdated;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Gets or Sets Telephone
        /// </summary>
        [DataMember(Name="telephone", EmitDefaultValue=true)]
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or Sets TelephoneType
        /// </summary>
        [DataMember(Name="telephoneType", EmitDefaultValue=true)]
        public string TelephoneType { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name="lastUpdated", EmitDefaultValue=true)]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDate
        /// </summary>
        [DataMember(Name="createdDate", EmitDefaultValue=true)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompuscanContactTelephone {\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  TelephoneType: ").Append(TelephoneType).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
            return this.Equals(input as CompuscanContactTelephone);
        }

        /// <summary>
        /// Returns true if CompuscanContactTelephone instances are equal
        /// </summary>
        /// <param name="input">Instance of CompuscanContactTelephone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompuscanContactTelephone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.TelephoneType == input.TelephoneType ||
                    (this.TelephoneType != null &&
                    this.TelephoneType.Equals(input.TelephoneType))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
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
                if (this.Telephone != null)
                    hashCode = hashCode * 59 + this.Telephone.GetHashCode();
                if (this.TelephoneType != null)
                    hashCode = hashCode * 59 + this.TelephoneType.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
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
