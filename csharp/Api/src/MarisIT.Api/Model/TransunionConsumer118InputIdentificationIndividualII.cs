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
    /// TransunionConsumer118InputIdentificationIndividualII
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118InputIdentificationIndividualII :  IEquatable<TransunionConsumer118InputIdentificationIndividualII>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118InputIdentificationIndividualII" /> class.
        /// </summary>
        /// <param name="surname">surname.</param>
        /// <param name="forename">forename.</param>
        /// <param name="idNumber">idNumber.</param>
        public TransunionConsumer118InputIdentificationIndividualII(string surname = default(string), string forename = default(string), string idNumber = default(string))
        {
            this.Surname = surname;
            this.Forename = forename;
            this.IdNumber = idNumber;
            this.Surname = surname;
            this.Forename = forename;
            this.IdNumber = idNumber;
        }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Forename
        /// </summary>
        [DataMember(Name="forename", EmitDefaultValue=true)]
        public string Forename { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118InputIdentificationIndividualII {\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Forename: ").Append(Forename).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
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
            return this.Equals(input as TransunionConsumer118InputIdentificationIndividualII);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118InputIdentificationIndividualII instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118InputIdentificationIndividualII to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118InputIdentificationIndividualII input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Forename == input.Forename ||
                    (this.Forename != null &&
                    this.Forename.Equals(input.Forename))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
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
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Forename != null)
                    hashCode = hashCode * 59 + this.Forename.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
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