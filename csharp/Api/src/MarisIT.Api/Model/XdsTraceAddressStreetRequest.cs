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
    /// XdsTraceAddressStreetRequest
    /// </summary>
    [DataContract]
    public partial class XdsTraceAddressStreetRequest :  IEquatable<XdsTraceAddressStreetRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public Province Province { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsTraceAddressStreetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XdsTraceAddressStreetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsTraceAddressStreetRequest" /> class.
        /// </summary>
        /// <param name="province">province (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="suburb">suburb (required).</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="streetName">streetName (required).</param>
        /// <param name="surname">surname.</param>
        /// <param name="reference">reference.</param>
        public XdsTraceAddressStreetRequest(Province province = default(Province), string city = default(string), string suburb = default(string), string postalCode = default(string), string streetName = default(string), string surname = default(string), string reference = default(string))
        {
            // to ensure "province" is required (not null)
            if (province == null)
            {
                throw new InvalidDataException("province is a required property for XdsTraceAddressStreetRequest and cannot be null");
            }
            else
            {
                this.Province = province;
            }

            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new InvalidDataException("city is a required property for XdsTraceAddressStreetRequest and cannot be null");
            }
            else
            {
                this.City = city;
            }

            // to ensure "suburb" is required (not null)
            if (suburb == null)
            {
                throw new InvalidDataException("suburb is a required property for XdsTraceAddressStreetRequest and cannot be null");
            }
            else
            {
                this.Suburb = suburb;
            }

            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new InvalidDataException("postalCode is a required property for XdsTraceAddressStreetRequest and cannot be null");
            }
            else
            {
                this.PostalCode = postalCode;
            }

            // to ensure "streetName" is required (not null)
            if (streetName == null)
            {
                throw new InvalidDataException("streetName is a required property for XdsTraceAddressStreetRequest and cannot be null");
            }
            else
            {
                this.StreetName = streetName;
            }

            this.Surname = surname;
            this.Reference = reference;
            this.Surname = surname;
            this.Reference = reference;
        }


        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=true)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsTraceAddressStreetRequest {\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as XdsTraceAddressStreetRequest);
        }

        /// <summary>
        /// Returns true if XdsTraceAddressStreetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsTraceAddressStreetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsTraceAddressStreetRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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
