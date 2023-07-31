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
    /// CompuscanCOMPPROPERTIES
    /// </summary>
    [DataContract]
    public partial class CompuscanCOMPPROPERTIES :  IEquatable<CompuscanCOMPPROPERTIES>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompuscanCOMPPROPERTIES" /> class.
        /// </summary>
        /// <param name="activeindicator">activeindicator.</param>
        /// <param name="erfno">erfno.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="municipality">municipality.</param>
        /// <param name="portion">portion.</param>
        /// <param name="propertyid">propertyid.</param>
        /// <param name="propertytype">propertytype.</param>
        /// <param name="sectschemename">sectschemename.</param>
        /// <param name="unit">unit.</param>
        public CompuscanCOMPPROPERTIES(string activeindicator = default(string), string erfno = default(string), string latitude = default(string), string longitude = default(string), string municipality = default(string), string portion = default(string), string propertyid = default(string), string propertytype = default(string), string sectschemename = default(string), string unit = default(string))
        {
            this.Activeindicator = activeindicator;
            this.Erfno = erfno;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Municipality = municipality;
            this.Portion = portion;
            this.Propertyid = propertyid;
            this.Propertytype = propertytype;
            this.Sectschemename = sectschemename;
            this.Unit = unit;
            this.Activeindicator = activeindicator;
            this.Erfno = erfno;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Municipality = municipality;
            this.Portion = portion;
            this.Propertyid = propertyid;
            this.Propertytype = propertytype;
            this.Sectschemename = sectschemename;
            this.Unit = unit;
        }

        /// <summary>
        /// Gets or Sets Activeindicator
        /// </summary>
        [DataMember(Name="activeindicator", EmitDefaultValue=true)]
        public string Activeindicator { get; set; }

        /// <summary>
        /// Gets or Sets Erfno
        /// </summary>
        [DataMember(Name="erfno", EmitDefaultValue=true)]
        public string Erfno { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=true)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=true)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Municipality
        /// </summary>
        [DataMember(Name="municipality", EmitDefaultValue=true)]
        public string Municipality { get; set; }

        /// <summary>
        /// Gets or Sets Portion
        /// </summary>
        [DataMember(Name="portion", EmitDefaultValue=true)]
        public string Portion { get; set; }

        /// <summary>
        /// Gets or Sets Propertyid
        /// </summary>
        [DataMember(Name="propertyid", EmitDefaultValue=true)]
        public string Propertyid { get; set; }

        /// <summary>
        /// Gets or Sets Propertytype
        /// </summary>
        [DataMember(Name="propertytype", EmitDefaultValue=true)]
        public string Propertytype { get; set; }

        /// <summary>
        /// Gets or Sets Sectschemename
        /// </summary>
        [DataMember(Name="sectschemename", EmitDefaultValue=true)]
        public string Sectschemename { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompuscanCOMPPROPERTIES {\n");
            sb.Append("  Activeindicator: ").Append(Activeindicator).Append("\n");
            sb.Append("  Erfno: ").Append(Erfno).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Municipality: ").Append(Municipality).Append("\n");
            sb.Append("  Portion: ").Append(Portion).Append("\n");
            sb.Append("  Propertyid: ").Append(Propertyid).Append("\n");
            sb.Append("  Propertytype: ").Append(Propertytype).Append("\n");
            sb.Append("  Sectschemename: ").Append(Sectschemename).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as CompuscanCOMPPROPERTIES);
        }

        /// <summary>
        /// Returns true if CompuscanCOMPPROPERTIES instances are equal
        /// </summary>
        /// <param name="input">Instance of CompuscanCOMPPROPERTIES to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompuscanCOMPPROPERTIES input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Activeindicator == input.Activeindicator ||
                    (this.Activeindicator != null &&
                    this.Activeindicator.Equals(input.Activeindicator))
                ) && 
                (
                    this.Erfno == input.Erfno ||
                    (this.Erfno != null &&
                    this.Erfno.Equals(input.Erfno))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Municipality == input.Municipality ||
                    (this.Municipality != null &&
                    this.Municipality.Equals(input.Municipality))
                ) && 
                (
                    this.Portion == input.Portion ||
                    (this.Portion != null &&
                    this.Portion.Equals(input.Portion))
                ) && 
                (
                    this.Propertyid == input.Propertyid ||
                    (this.Propertyid != null &&
                    this.Propertyid.Equals(input.Propertyid))
                ) && 
                (
                    this.Propertytype == input.Propertytype ||
                    (this.Propertytype != null &&
                    this.Propertytype.Equals(input.Propertytype))
                ) && 
                (
                    this.Sectschemename == input.Sectschemename ||
                    (this.Sectschemename != null &&
                    this.Sectschemename.Equals(input.Sectschemename))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Activeindicator != null)
                    hashCode = hashCode * 59 + this.Activeindicator.GetHashCode();
                if (this.Erfno != null)
                    hashCode = hashCode * 59 + this.Erfno.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Municipality != null)
                    hashCode = hashCode * 59 + this.Municipality.GetHashCode();
                if (this.Portion != null)
                    hashCode = hashCode * 59 + this.Portion.GetHashCode();
                if (this.Propertyid != null)
                    hashCode = hashCode * 59 + this.Propertyid.GetHashCode();
                if (this.Propertytype != null)
                    hashCode = hashCode * 59 + this.Propertytype.GetHashCode();
                if (this.Sectschemename != null)
                    hashCode = hashCode * 59 + this.Sectschemename.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
