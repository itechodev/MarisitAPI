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
    /// WindeedWprOtherImprovements
    /// </summary>
    [DataContract]
    public partial class WindeedWprOtherImprovements :  IEquatable<WindeedWprOtherImprovements>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedWprOtherImprovements" /> class.
        /// </summary>
        /// <param name="garages">garages.</param>
        /// <param name="garden">garden.</param>
        /// <param name="pool">pool.</param>
        /// <param name="grannyFlat">grannyFlat.</param>
        public WindeedWprOtherImprovements(double? garages = default(double?), bool? garden = default(bool?), bool? pool = default(bool?), bool? grannyFlat = default(bool?))
        {
            this.Garages = garages;
            this.Garden = garden;
            this.Pool = pool;
            this.GrannyFlat = grannyFlat;
            this.Garages = garages;
            this.Garden = garden;
            this.Pool = pool;
            this.GrannyFlat = grannyFlat;
        }

        /// <summary>
        /// Gets or Sets Garages
        /// </summary>
        [DataMember(Name="garages", EmitDefaultValue=true)]
        public double? Garages { get; set; }

        /// <summary>
        /// Gets or Sets Garden
        /// </summary>
        [DataMember(Name="garden", EmitDefaultValue=true)]
        public bool? Garden { get; set; }

        /// <summary>
        /// Gets or Sets Pool
        /// </summary>
        [DataMember(Name="pool", EmitDefaultValue=true)]
        public bool? Pool { get; set; }

        /// <summary>
        /// Gets or Sets GrannyFlat
        /// </summary>
        [DataMember(Name="grannyFlat", EmitDefaultValue=true)]
        public bool? GrannyFlat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedWprOtherImprovements {\n");
            sb.Append("  Garages: ").Append(Garages).Append("\n");
            sb.Append("  Garden: ").Append(Garden).Append("\n");
            sb.Append("  Pool: ").Append(Pool).Append("\n");
            sb.Append("  GrannyFlat: ").Append(GrannyFlat).Append("\n");
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
            return this.Equals(input as WindeedWprOtherImprovements);
        }

        /// <summary>
        /// Returns true if WindeedWprOtherImprovements instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedWprOtherImprovements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedWprOtherImprovements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Garages == input.Garages ||
                    (this.Garages != null &&
                    this.Garages.Equals(input.Garages))
                ) && 
                (
                    this.Garden == input.Garden ||
                    (this.Garden != null &&
                    this.Garden.Equals(input.Garden))
                ) && 
                (
                    this.Pool == input.Pool ||
                    (this.Pool != null &&
                    this.Pool.Equals(input.Pool))
                ) && 
                (
                    this.GrannyFlat == input.GrannyFlat ||
                    (this.GrannyFlat != null &&
                    this.GrannyFlat.Equals(input.GrannyFlat))
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
                if (this.Garages != null)
                    hashCode = hashCode * 59 + this.Garages.GetHashCode();
                if (this.Garden != null)
                    hashCode = hashCode * 59 + this.Garden.GetHashCode();
                if (this.Pool != null)
                    hashCode = hashCode * 59 + this.Pool.GetHashCode();
                if (this.GrannyFlat != null)
                    hashCode = hashCode * 59 + this.GrannyFlat.GetHashCode();
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
