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
    /// XdsVehicleInformation
    /// </summary>
    [DataContract]
    public partial class XdsVehicleInformation :  IEquatable<XdsVehicleInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsVehicleInformation" /> class.
        /// </summary>
        /// <param name="vin">vin.</param>
        /// <param name="engineNo">engineNo.</param>
        /// <param name="registrationNo">registrationNo.</param>
        /// <param name="manufacturer">manufacturer.</param>
        /// <param name="model">model.</param>
        /// <param name="year">year.</param>
        /// <param name="colour">colour.</param>
        public XdsVehicleInformation(string vin = default(string), string engineNo = default(string), XdsRegistrationNo registrationNo = default(XdsRegistrationNo), string manufacturer = default(string), string model = default(string), string year = default(string), string colour = default(string))
        {
            this.Vin = vin;
            this.EngineNo = engineNo;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
            this.Colour = colour;
            this.Vin = vin;
            this.EngineNo = engineNo;
            this.RegistrationNo = registrationNo;
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
            this.Colour = colour;
        }

        /// <summary>
        /// Gets or Sets Vin
        /// </summary>
        [DataMember(Name="vin", EmitDefaultValue=true)]
        public string Vin { get; set; }

        /// <summary>
        /// Gets or Sets EngineNo
        /// </summary>
        [DataMember(Name="engineNo", EmitDefaultValue=true)]
        public string EngineNo { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNo
        /// </summary>
        [DataMember(Name="registrationNo", EmitDefaultValue=false)]
        public XdsRegistrationNo RegistrationNo { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        [DataMember(Name="manufacturer", EmitDefaultValue=true)]
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=true)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets Colour
        /// </summary>
        [DataMember(Name="colour", EmitDefaultValue=true)]
        public string Colour { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsVehicleInformation {\n");
            sb.Append("  Vin: ").Append(Vin).Append("\n");
            sb.Append("  EngineNo: ").Append(EngineNo).Append("\n");
            sb.Append("  RegistrationNo: ").Append(RegistrationNo).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Colour: ").Append(Colour).Append("\n");
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
            return this.Equals(input as XdsVehicleInformation);
        }

        /// <summary>
        /// Returns true if XdsVehicleInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsVehicleInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsVehicleInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vin == input.Vin ||
                    (this.Vin != null &&
                    this.Vin.Equals(input.Vin))
                ) && 
                (
                    this.EngineNo == input.EngineNo ||
                    (this.EngineNo != null &&
                    this.EngineNo.Equals(input.EngineNo))
                ) && 
                (
                    this.RegistrationNo == input.RegistrationNo ||
                    (this.RegistrationNo != null &&
                    this.RegistrationNo.Equals(input.RegistrationNo))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Colour == input.Colour ||
                    (this.Colour != null &&
                    this.Colour.Equals(input.Colour))
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
                if (this.Vin != null)
                    hashCode = hashCode * 59 + this.Vin.GetHashCode();
                if (this.EngineNo != null)
                    hashCode = hashCode * 59 + this.EngineNo.GetHashCode();
                if (this.RegistrationNo != null)
                    hashCode = hashCode * 59 + this.RegistrationNo.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Colour != null)
                    hashCode = hashCode * 59 + this.Colour.GetHashCode();
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
