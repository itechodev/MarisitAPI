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
    /// WindeedLightstoneFreehold
    /// </summary>
    [DataContract]
    public partial class WindeedLightstoneFreehold :  IEquatable<WindeedLightstoneFreehold>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=false)]
        public WindeedLightstoneRegistrar? DeedsOffice { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedLightstoneFreehold" /> class.
        /// </summary>
        /// <param name="lpiCode">lpiCode.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="portionNumber">portionNumber.</param>
        /// <param name="cadastralExtent">cadastralExtent.</param>
        /// <param name="registeredExtent">registeredExtent.</param>
        /// <param name="zoningUsage">zoningUsage.</param>
        /// <param name="province">province.</param>
        /// <param name="localAuthority">localAuthority.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="township">township.</param>
        /// <param name="erfNumber">erfNumber.</param>
        /// <param name="address">address.</param>
        public WindeedLightstoneFreehold(string lpiCode = default(string), WindeedLightstoneRegistrar? deedsOffice = default(WindeedLightstoneRegistrar?), double latitude = default(double), double longitude = default(double), int portionNumber = default(int), int? cadastralExtent = default(int?), int registeredExtent = default(int), string zoningUsage = default(string), string province = default(string), string localAuthority = default(string), string suburb = default(string), string township = default(string), int erfNumber = default(int), string address = default(string))
        {
            this.LpiCode = lpiCode;
            this.CadastralExtent = cadastralExtent;
            this.ZoningUsage = zoningUsage;
            this.Province = province;
            this.LocalAuthority = localAuthority;
            this.Suburb = suburb;
            this.Township = township;
            this.Address = address;
            this.LpiCode = lpiCode;
            this.DeedsOffice = deedsOffice;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PortionNumber = portionNumber;
            this.CadastralExtent = cadastralExtent;
            this.RegisteredExtent = registeredExtent;
            this.ZoningUsage = zoningUsage;
            this.Province = province;
            this.LocalAuthority = localAuthority;
            this.Suburb = suburb;
            this.Township = township;
            this.ErfNumber = erfNumber;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets LpiCode
        /// </summary>
        [DataMember(Name="lpiCode", EmitDefaultValue=true)]
        public string LpiCode { get; set; }


        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or Sets PortionNumber
        /// </summary>
        [DataMember(Name="portionNumber", EmitDefaultValue=false)]
        public int PortionNumber { get; set; }

        /// <summary>
        /// Gets or Sets CadastralExtent
        /// </summary>
        [DataMember(Name="cadastralExtent", EmitDefaultValue=true)]
        public int? CadastralExtent { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredExtent
        /// </summary>
        [DataMember(Name="registeredExtent", EmitDefaultValue=false)]
        public int RegisteredExtent { get; set; }

        /// <summary>
        /// Gets or Sets ZoningUsage
        /// </summary>
        [DataMember(Name="zoningUsage", EmitDefaultValue=true)]
        public string ZoningUsage { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets LocalAuthority
        /// </summary>
        [DataMember(Name="localAuthority", EmitDefaultValue=true)]
        public string LocalAuthority { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Township
        /// </summary>
        [DataMember(Name="township", EmitDefaultValue=true)]
        public string Township { get; set; }

        /// <summary>
        /// Gets or Sets ErfNumber
        /// </summary>
        [DataMember(Name="erfNumber", EmitDefaultValue=false)]
        public int ErfNumber { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedLightstoneFreehold {\n");
            sb.Append("  LpiCode: ").Append(LpiCode).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
            sb.Append("  CadastralExtent: ").Append(CadastralExtent).Append("\n");
            sb.Append("  RegisteredExtent: ").Append(RegisteredExtent).Append("\n");
            sb.Append("  ZoningUsage: ").Append(ZoningUsage).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  LocalAuthority: ").Append(LocalAuthority).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Township: ").Append(Township).Append("\n");
            sb.Append("  ErfNumber: ").Append(ErfNumber).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as WindeedLightstoneFreehold);
        }

        /// <summary>
        /// Returns true if WindeedLightstoneFreehold instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedLightstoneFreehold to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedLightstoneFreehold input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LpiCode == input.LpiCode ||
                    (this.LpiCode != null &&
                    this.LpiCode.Equals(input.LpiCode))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
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
                    this.PortionNumber == input.PortionNumber ||
                    (this.PortionNumber != null &&
                    this.PortionNumber.Equals(input.PortionNumber))
                ) && 
                (
                    this.CadastralExtent == input.CadastralExtent ||
                    (this.CadastralExtent != null &&
                    this.CadastralExtent.Equals(input.CadastralExtent))
                ) && 
                (
                    this.RegisteredExtent == input.RegisteredExtent ||
                    (this.RegisteredExtent != null &&
                    this.RegisteredExtent.Equals(input.RegisteredExtent))
                ) && 
                (
                    this.ZoningUsage == input.ZoningUsage ||
                    (this.ZoningUsage != null &&
                    this.ZoningUsage.Equals(input.ZoningUsage))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.LocalAuthority == input.LocalAuthority ||
                    (this.LocalAuthority != null &&
                    this.LocalAuthority.Equals(input.LocalAuthority))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Township == input.Township ||
                    (this.Township != null &&
                    this.Township.Equals(input.Township))
                ) && 
                (
                    this.ErfNumber == input.ErfNumber ||
                    (this.ErfNumber != null &&
                    this.ErfNumber.Equals(input.ErfNumber))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.LpiCode != null)
                    hashCode = hashCode * 59 + this.LpiCode.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
                if (this.CadastralExtent != null)
                    hashCode = hashCode * 59 + this.CadastralExtent.GetHashCode();
                if (this.RegisteredExtent != null)
                    hashCode = hashCode * 59 + this.RegisteredExtent.GetHashCode();
                if (this.ZoningUsage != null)
                    hashCode = hashCode * 59 + this.ZoningUsage.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.LocalAuthority != null)
                    hashCode = hashCode * 59 + this.LocalAuthority.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Township != null)
                    hashCode = hashCode * 59 + this.Township.GetHashCode();
                if (this.ErfNumber != null)
                    hashCode = hashCode * 59 + this.ErfNumber.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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
