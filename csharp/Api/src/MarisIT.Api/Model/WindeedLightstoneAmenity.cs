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
    /// WindeedLightstoneAmenity
    /// </summary>
    [DataContract]
    public partial class WindeedLightstoneAmenity :  IEquatable<WindeedLightstoneAmenity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedLightstoneAmenity" /> class.
        /// </summary>
        /// <param name="amenityName">amenityName.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="distance">distance.</param>
        public WindeedLightstoneAmenity(string amenityName = default(string), string suburb = default(string), double distance = default(double))
        {
            this.AmenityName = amenityName;
            this.Suburb = suburb;
            this.AmenityName = amenityName;
            this.Suburb = suburb;
            this.Distance = distance;
        }

        /// <summary>
        /// Gets or Sets AmenityName
        /// </summary>
        [DataMember(Name="amenityName", EmitDefaultValue=true)]
        public string AmenityName { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public double Distance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedLightstoneAmenity {\n");
            sb.Append("  AmenityName: ").Append(AmenityName).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
            return this.Equals(input as WindeedLightstoneAmenity);
        }

        /// <summary>
        /// Returns true if WindeedLightstoneAmenity instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedLightstoneAmenity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedLightstoneAmenity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AmenityName == input.AmenityName ||
                    (this.AmenityName != null &&
                    this.AmenityName.Equals(input.AmenityName))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
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
                if (this.AmenityName != null)
                    hashCode = hashCode * 59 + this.AmenityName.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
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
