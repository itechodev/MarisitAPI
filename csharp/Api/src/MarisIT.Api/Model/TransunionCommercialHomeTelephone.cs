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
    /// TransunionCommercialHomeTelephone
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialHomeTelephone :  IEquatable<TransunionCommercialHomeTelephone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialHomeTelephone" /> class.
        /// </summary>
        /// <param name="homeTelephoneCode">homeTelephoneCode.</param>
        /// <param name="homeTelephoneNumber">homeTelephoneNumber.</param>
        public TransunionCommercialHomeTelephone(string homeTelephoneCode = default(string), string homeTelephoneNumber = default(string))
        {
            this.HomeTelephoneCode = homeTelephoneCode;
            this.HomeTelephoneNumber = homeTelephoneNumber;
            this.HomeTelephoneCode = homeTelephoneCode;
            this.HomeTelephoneNumber = homeTelephoneNumber;
        }

        /// <summary>
        /// Gets or Sets HomeTelephoneCode
        /// </summary>
        [DataMember(Name="homeTelephoneCode", EmitDefaultValue=true)]
        public string HomeTelephoneCode { get; set; }

        /// <summary>
        /// Gets or Sets HomeTelephoneNumber
        /// </summary>
        [DataMember(Name="homeTelephoneNumber", EmitDefaultValue=true)]
        public string HomeTelephoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialHomeTelephone {\n");
            sb.Append("  HomeTelephoneCode: ").Append(HomeTelephoneCode).Append("\n");
            sb.Append("  HomeTelephoneNumber: ").Append(HomeTelephoneNumber).Append("\n");
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
            return this.Equals(input as TransunionCommercialHomeTelephone);
        }

        /// <summary>
        /// Returns true if TransunionCommercialHomeTelephone instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialHomeTelephone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialHomeTelephone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HomeTelephoneCode == input.HomeTelephoneCode ||
                    (this.HomeTelephoneCode != null &&
                    this.HomeTelephoneCode.Equals(input.HomeTelephoneCode))
                ) && 
                (
                    this.HomeTelephoneNumber == input.HomeTelephoneNumber ||
                    (this.HomeTelephoneNumber != null &&
                    this.HomeTelephoneNumber.Equals(input.HomeTelephoneNumber))
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
                if (this.HomeTelephoneCode != null)
                    hashCode = hashCode * 59 + this.HomeTelephoneCode.GetHashCode();
                if (this.HomeTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.HomeTelephoneNumber.GetHashCode();
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
