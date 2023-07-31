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
    /// TransunionConsumer118IdvNI01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118IdvNI01 :  IEquatable<TransunionConsumer118IdvNI01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118IdvNI01" /> class.
        /// </summary>
        /// <param name="idVerifiedCode">idVerifiedCode.</param>
        /// <param name="idVerifiedDesc">idVerifiedDesc.</param>
        /// <param name="idWarning">idWarning.</param>
        /// <param name="idDesc">idDesc.</param>
        /// <param name="verifiedSurname">verifiedSurname.</param>
        /// <param name="verifiedForename1">verifiedForename1.</param>
        /// <param name="verifiedForename2">verifiedForename2.</param>
        /// <param name="deceasedDate">deceasedDate.</param>
        public TransunionConsumer118IdvNI01(string idVerifiedCode = default(string), string idVerifiedDesc = default(string), string idWarning = default(string), string idDesc = default(string), string verifiedSurname = default(string), string verifiedForename1 = default(string), string verifiedForename2 = default(string), string deceasedDate = default(string))
        {
            this.IdVerifiedCode = idVerifiedCode;
            this.IdVerifiedDesc = idVerifiedDesc;
            this.IdWarning = idWarning;
            this.IdDesc = idDesc;
            this.VerifiedSurname = verifiedSurname;
            this.VerifiedForename1 = verifiedForename1;
            this.VerifiedForename2 = verifiedForename2;
            this.DeceasedDate = deceasedDate;
            this.IdVerifiedCode = idVerifiedCode;
            this.IdVerifiedDesc = idVerifiedDesc;
            this.IdWarning = idWarning;
            this.IdDesc = idDesc;
            this.VerifiedSurname = verifiedSurname;
            this.VerifiedForename1 = verifiedForename1;
            this.VerifiedForename2 = verifiedForename2;
            this.DeceasedDate = deceasedDate;
        }

        /// <summary>
        /// Gets or Sets IdVerifiedCode
        /// </summary>
        [DataMember(Name="idVerifiedCode", EmitDefaultValue=true)]
        public string IdVerifiedCode { get; set; }

        /// <summary>
        /// Gets or Sets IdVerifiedDesc
        /// </summary>
        [DataMember(Name="idVerifiedDesc", EmitDefaultValue=true)]
        public string IdVerifiedDesc { get; set; }

        /// <summary>
        /// Gets or Sets IdWarning
        /// </summary>
        [DataMember(Name="idWarning", EmitDefaultValue=true)]
        public string IdWarning { get; set; }

        /// <summary>
        /// Gets or Sets IdDesc
        /// </summary>
        [DataMember(Name="idDesc", EmitDefaultValue=true)]
        public string IdDesc { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedSurname
        /// </summary>
        [DataMember(Name="verifiedSurname", EmitDefaultValue=true)]
        public string VerifiedSurname { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedForename1
        /// </summary>
        [DataMember(Name="verifiedForename1", EmitDefaultValue=true)]
        public string VerifiedForename1 { get; set; }

        /// <summary>
        /// Gets or Sets VerifiedForename2
        /// </summary>
        [DataMember(Name="verifiedForename2", EmitDefaultValue=true)]
        public string VerifiedForename2 { get; set; }

        /// <summary>
        /// Gets or Sets DeceasedDate
        /// </summary>
        [DataMember(Name="deceasedDate", EmitDefaultValue=true)]
        public string DeceasedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118IdvNI01 {\n");
            sb.Append("  IdVerifiedCode: ").Append(IdVerifiedCode).Append("\n");
            sb.Append("  IdVerifiedDesc: ").Append(IdVerifiedDesc).Append("\n");
            sb.Append("  IdWarning: ").Append(IdWarning).Append("\n");
            sb.Append("  IdDesc: ").Append(IdDesc).Append("\n");
            sb.Append("  VerifiedSurname: ").Append(VerifiedSurname).Append("\n");
            sb.Append("  VerifiedForename1: ").Append(VerifiedForename1).Append("\n");
            sb.Append("  VerifiedForename2: ").Append(VerifiedForename2).Append("\n");
            sb.Append("  DeceasedDate: ").Append(DeceasedDate).Append("\n");
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
            return this.Equals(input as TransunionConsumer118IdvNI01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118IdvNI01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118IdvNI01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118IdvNI01 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdVerifiedCode == input.IdVerifiedCode ||
                    (this.IdVerifiedCode != null &&
                    this.IdVerifiedCode.Equals(input.IdVerifiedCode))
                ) && 
                (
                    this.IdVerifiedDesc == input.IdVerifiedDesc ||
                    (this.IdVerifiedDesc != null &&
                    this.IdVerifiedDesc.Equals(input.IdVerifiedDesc))
                ) && 
                (
                    this.IdWarning == input.IdWarning ||
                    (this.IdWarning != null &&
                    this.IdWarning.Equals(input.IdWarning))
                ) && 
                (
                    this.IdDesc == input.IdDesc ||
                    (this.IdDesc != null &&
                    this.IdDesc.Equals(input.IdDesc))
                ) && 
                (
                    this.VerifiedSurname == input.VerifiedSurname ||
                    (this.VerifiedSurname != null &&
                    this.VerifiedSurname.Equals(input.VerifiedSurname))
                ) && 
                (
                    this.VerifiedForename1 == input.VerifiedForename1 ||
                    (this.VerifiedForename1 != null &&
                    this.VerifiedForename1.Equals(input.VerifiedForename1))
                ) && 
                (
                    this.VerifiedForename2 == input.VerifiedForename2 ||
                    (this.VerifiedForename2 != null &&
                    this.VerifiedForename2.Equals(input.VerifiedForename2))
                ) && 
                (
                    this.DeceasedDate == input.DeceasedDate ||
                    (this.DeceasedDate != null &&
                    this.DeceasedDate.Equals(input.DeceasedDate))
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
                if (this.IdVerifiedCode != null)
                    hashCode = hashCode * 59 + this.IdVerifiedCode.GetHashCode();
                if (this.IdVerifiedDesc != null)
                    hashCode = hashCode * 59 + this.IdVerifiedDesc.GetHashCode();
                if (this.IdWarning != null)
                    hashCode = hashCode * 59 + this.IdWarning.GetHashCode();
                if (this.IdDesc != null)
                    hashCode = hashCode * 59 + this.IdDesc.GetHashCode();
                if (this.VerifiedSurname != null)
                    hashCode = hashCode * 59 + this.VerifiedSurname.GetHashCode();
                if (this.VerifiedForename1 != null)
                    hashCode = hashCode * 59 + this.VerifiedForename1.GetHashCode();
                if (this.VerifiedForename2 != null)
                    hashCode = hashCode * 59 + this.VerifiedForename2.GetHashCode();
                if (this.DeceasedDate != null)
                    hashCode = hashCode * 59 + this.DeceasedDate.GetHashCode();
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