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
    /// SchemeSearch
    /// </summary>
    [DataContract]
    public partial class SchemeSearch :  IEquatable<SchemeSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemeSearch" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        /// <param name="schemeName">schemeName.</param>
        /// <param name="schemeNumber">schemeNumber.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="town">town.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="township">township.</param>
        public SchemeSearch(string reference = default(string), string schemeName = default(string), string schemeNumber = default(string), string suburb = default(string), string town = default(string), string deedsOffice = default(string), string township = default(string))
        {
            this.Reference = reference;
            this.SchemeName = schemeName;
            this.SchemeNumber = schemeNumber;
            this.Suburb = suburb;
            this.Town = town;
            this.DeedsOffice = deedsOffice;
            this.Township = township;
            this.Reference = reference;
            this.SchemeName = schemeName;
            this.SchemeNumber = schemeNumber;
            this.Suburb = suburb;
            this.Town = town;
            this.DeedsOffice = deedsOffice;
            this.Township = township;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets SchemeName
        /// </summary>
        [DataMember(Name="schemeName", EmitDefaultValue=true)]
        public string SchemeName { get; set; }

        /// <summary>
        /// Gets or Sets SchemeNumber
        /// </summary>
        [DataMember(Name="schemeNumber", EmitDefaultValue=true)]
        public string SchemeNumber { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Town
        /// </summary>
        [DataMember(Name="town", EmitDefaultValue=true)]
        public string Town { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public string DeedsOffice { get; set; }

        /// <summary>
        /// Gets or Sets Township
        /// </summary>
        [DataMember(Name="township", EmitDefaultValue=true)]
        public string Township { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchemeSearch {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
            sb.Append("  SchemeNumber: ").Append(SchemeNumber).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  Township: ").Append(Township).Append("\n");
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
            return this.Equals(input as SchemeSearch);
        }

        /// <summary>
        /// Returns true if SchemeSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of SchemeSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchemeSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SchemeName == input.SchemeName ||
                    (this.SchemeName != null &&
                    this.SchemeName.Equals(input.SchemeName))
                ) && 
                (
                    this.SchemeNumber == input.SchemeNumber ||
                    (this.SchemeNumber != null &&
                    this.SchemeNumber.Equals(input.SchemeNumber))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.Township == input.Township ||
                    (this.Township != null &&
                    this.Township.Equals(input.Township))
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
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SchemeName != null)
                    hashCode = hashCode * 59 + this.SchemeName.GetHashCode();
                if (this.SchemeNumber != null)
                    hashCode = hashCode * 59 + this.SchemeNumber.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.Township != null)
                    hashCode = hashCode * 59 + this.Township.GetHashCode();
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
