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
    /// TransunionConsumer118InputIdentificationRiskAddressIA
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118InputIdentificationRiskAddressIA :  IEquatable<TransunionConsumer118InputIdentificationRiskAddressIA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118InputIdentificationRiskAddressIA" /> class.
        /// </summary>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="province">province.</param>
        /// <param name="postalCode">postalCode.</param>
        public TransunionConsumer118InputIdentificationRiskAddressIA(string addressLine2 = default(string), string suburb = default(string), string province = default(string), string postalCode = default(string))
        {
            this.AddressLine2 = addressLine2;
            this.Suburb = suburb;
            this.Province = province;
            this.PostalCode = postalCode;
            this.AddressLine2 = addressLine2;
            this.Suburb = suburb;
            this.Province = province;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=true)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118InputIdentificationRiskAddressIA {\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as TransunionConsumer118InputIdentificationRiskAddressIA);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118InputIdentificationRiskAddressIA instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118InputIdentificationRiskAddressIA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118InputIdentificationRiskAddressIA input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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