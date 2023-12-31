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
    /// WindeedWprUpdatablePropertyConfiguration
    /// </summary>
    [DataContract]
    public partial class WindeedWprUpdatablePropertyConfiguration :  IEquatable<WindeedWprUpdatablePropertyConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Zoning
        /// </summary>
        [DataMember(Name="zoning", EmitDefaultValue=false)]
        public WindeedWprPropertyZone? Zoning { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedWprUpdatablePropertyConfiguration" /> class.
        /// </summary>
        /// <param name="isVacantLand">isVacantLand.</param>
        /// <param name="zoning">zoning.</param>
        /// <param name="estateName">estateName.</param>
        /// <param name="roomConfiguration">roomConfiguration.</param>
        /// <param name="generalInformation">generalInformation.</param>
        /// <param name="otherImprovements">otherImprovements.</param>
        /// <param name="propertyValue">propertyValue.</param>
        public WindeedWprUpdatablePropertyConfiguration(bool isVacantLand = default(bool), WindeedWprPropertyZone? zoning = default(WindeedWprPropertyZone?), string estateName = default(string), WindeedWprRoomConfiguration roomConfiguration = default(WindeedWprRoomConfiguration), WindeedWprGeneralInformation generalInformation = default(WindeedWprGeneralInformation), WindeedWprOtherImprovements otherImprovements = default(WindeedWprOtherImprovements), double? propertyValue = default(double?))
        {
            this.EstateName = estateName;
            this.PropertyValue = propertyValue;
            this.IsVacantLand = isVacantLand;
            this.Zoning = zoning;
            this.EstateName = estateName;
            this.RoomConfiguration = roomConfiguration;
            this.GeneralInformation = generalInformation;
            this.OtherImprovements = otherImprovements;
            this.PropertyValue = propertyValue;
        }

        /// <summary>
        /// Gets or Sets IsVacantLand
        /// </summary>
        [DataMember(Name="isVacantLand", EmitDefaultValue=false)]
        public bool IsVacantLand { get; set; }


        /// <summary>
        /// Gets or Sets EstateName
        /// </summary>
        [DataMember(Name="estateName", EmitDefaultValue=true)]
        public string EstateName { get; set; }

        /// <summary>
        /// Gets or Sets RoomConfiguration
        /// </summary>
        [DataMember(Name="roomConfiguration", EmitDefaultValue=false)]
        public WindeedWprRoomConfiguration RoomConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets GeneralInformation
        /// </summary>
        [DataMember(Name="generalInformation", EmitDefaultValue=false)]
        public WindeedWprGeneralInformation GeneralInformation { get; set; }

        /// <summary>
        /// Gets or Sets OtherImprovements
        /// </summary>
        [DataMember(Name="otherImprovements", EmitDefaultValue=false)]
        public WindeedWprOtherImprovements OtherImprovements { get; set; }

        /// <summary>
        /// Gets or Sets PropertyValue
        /// </summary>
        [DataMember(Name="propertyValue", EmitDefaultValue=true)]
        public double? PropertyValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedWprUpdatablePropertyConfiguration {\n");
            sb.Append("  IsVacantLand: ").Append(IsVacantLand).Append("\n");
            sb.Append("  Zoning: ").Append(Zoning).Append("\n");
            sb.Append("  EstateName: ").Append(EstateName).Append("\n");
            sb.Append("  RoomConfiguration: ").Append(RoomConfiguration).Append("\n");
            sb.Append("  GeneralInformation: ").Append(GeneralInformation).Append("\n");
            sb.Append("  OtherImprovements: ").Append(OtherImprovements).Append("\n");
            sb.Append("  PropertyValue: ").Append(PropertyValue).Append("\n");
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
            return this.Equals(input as WindeedWprUpdatablePropertyConfiguration);
        }

        /// <summary>
        /// Returns true if WindeedWprUpdatablePropertyConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedWprUpdatablePropertyConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedWprUpdatablePropertyConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsVacantLand == input.IsVacantLand ||
                    (this.IsVacantLand != null &&
                    this.IsVacantLand.Equals(input.IsVacantLand))
                ) && 
                (
                    this.Zoning == input.Zoning ||
                    (this.Zoning != null &&
                    this.Zoning.Equals(input.Zoning))
                ) && 
                (
                    this.EstateName == input.EstateName ||
                    (this.EstateName != null &&
                    this.EstateName.Equals(input.EstateName))
                ) && 
                (
                    this.RoomConfiguration == input.RoomConfiguration ||
                    (this.RoomConfiguration != null &&
                    this.RoomConfiguration.Equals(input.RoomConfiguration))
                ) && 
                (
                    this.GeneralInformation == input.GeneralInformation ||
                    (this.GeneralInformation != null &&
                    this.GeneralInformation.Equals(input.GeneralInformation))
                ) && 
                (
                    this.OtherImprovements == input.OtherImprovements ||
                    (this.OtherImprovements != null &&
                    this.OtherImprovements.Equals(input.OtherImprovements))
                ) && 
                (
                    this.PropertyValue == input.PropertyValue ||
                    (this.PropertyValue != null &&
                    this.PropertyValue.Equals(input.PropertyValue))
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
                if (this.IsVacantLand != null)
                    hashCode = hashCode * 59 + this.IsVacantLand.GetHashCode();
                if (this.Zoning != null)
                    hashCode = hashCode * 59 + this.Zoning.GetHashCode();
                if (this.EstateName != null)
                    hashCode = hashCode * 59 + this.EstateName.GetHashCode();
                if (this.RoomConfiguration != null)
                    hashCode = hashCode * 59 + this.RoomConfiguration.GetHashCode();
                if (this.GeneralInformation != null)
                    hashCode = hashCode * 59 + this.GeneralInformation.GetHashCode();
                if (this.OtherImprovements != null)
                    hashCode = hashCode * 59 + this.OtherImprovements.GetHashCode();
                if (this.PropertyValue != null)
                    hashCode = hashCode * 59 + this.PropertyValue.GetHashCode();
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
