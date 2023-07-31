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
    /// TransunionCommercialModule
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialModule :  IEquatable<TransunionCommercialModule>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public TransunionCommercialProductType? ProductType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialModule" /> class.
        /// </summary>
        /// <param name="productCode">productCode.</param>
        /// <param name="productDesc">productDesc.</param>
        /// <param name="productType">productType.</param>
        /// <param name="hours">hours.</param>
        public TransunionCommercialModule(string productCode = default(string), string productDesc = default(string), TransunionCommercialProductType? productType = default(TransunionCommercialProductType?), float hours = default(float))
        {
            this.ProductCode = productCode;
            this.ProductDesc = productDesc;
            this.ProductCode = productCode;
            this.ProductDesc = productDesc;
            this.ProductType = productType;
            this.Hours = hours;
        }

        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name="productCode", EmitDefaultValue=true)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or Sets ProductDesc
        /// </summary>
        [DataMember(Name="productDesc", EmitDefaultValue=true)]
        public string ProductDesc { get; set; }


        /// <summary>
        /// Gets or Sets Hours
        /// </summary>
        [DataMember(Name="hours", EmitDefaultValue=false)]
        public float Hours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialModule {\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  ProductDesc: ").Append(ProductDesc).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
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
            return this.Equals(input as TransunionCommercialModule);
        }

        /// <summary>
        /// Returns true if TransunionCommercialModule instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialModule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.ProductDesc == input.ProductDesc ||
                    (this.ProductDesc != null &&
                    this.ProductDesc.Equals(input.ProductDesc))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.Hours == input.Hours ||
                    (this.Hours != null &&
                    this.Hours.Equals(input.Hours))
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
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.ProductDesc != null)
                    hashCode = hashCode * 59 + this.ProductDesc.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.Hours != null)
                    hashCode = hashCode * 59 + this.Hours.GetHashCode();
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