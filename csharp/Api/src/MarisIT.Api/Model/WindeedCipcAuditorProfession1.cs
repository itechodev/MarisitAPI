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
    /// WindeedCipcAuditorProfession1
    /// </summary>
    [DataContract]
    public partial class WindeedCipcAuditorProfession1 :  IEquatable<WindeedCipcAuditorProfession1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedCipcAuditorProfession1" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="description">description.</param>
        /// <param name="professionNumber">professionNumber.</param>
        public WindeedCipcAuditorProfession1(string code = default(string), string description = default(string), string professionNumber = default(string))
        {
            this.Code = code;
            this.Description = description;
            this.ProfessionNumber = professionNumber;
            this.Code = code;
            this.Description = description;
            this.ProfessionNumber = professionNumber;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ProfessionNumber
        /// </summary>
        [DataMember(Name="professionNumber", EmitDefaultValue=true)]
        public string ProfessionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedCipcAuditorProfession1 {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProfessionNumber: ").Append(ProfessionNumber).Append("\n");
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
            return this.Equals(input as WindeedCipcAuditorProfession1);
        }

        /// <summary>
        /// Returns true if WindeedCipcAuditorProfession1 instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedCipcAuditorProfession1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedCipcAuditorProfession1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProfessionNumber == input.ProfessionNumber ||
                    (this.ProfessionNumber != null &&
                    this.ProfessionNumber.Equals(input.ProfessionNumber))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProfessionNumber != null)
                    hashCode = hashCode * 59 + this.ProfessionNumber.GetHashCode();
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
