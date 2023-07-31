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
    /// WindeedAgriculturalSearchRequest
    /// </summary>
    [DataContract]
    public partial class WindeedAgriculturalSearchRequest :  IEquatable<WindeedAgriculturalSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public WindeedDeedsOffice DeedsOffice { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedAgriculturalSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindeedAgriculturalSearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedAgriculturalSearchRequest" /> class.
        /// </summary>
        /// <param name="holdingName">holdingName (required).</param>
        /// <param name="holdingNumber">holdingNumber (required).</param>
        /// <param name="portionNumber">portionNumber.</param>
        /// <param name="deedsOffice">deedsOffice (required).</param>
        /// <param name="reference">reference.</param>
        public WindeedAgriculturalSearchRequest(string holdingName = default(string), int holdingNumber = default(int), string portionNumber = default(string), WindeedDeedsOffice deedsOffice = default(WindeedDeedsOffice), string reference = default(string))
        {
            // to ensure "holdingName" is required (not null)
            if (holdingName == null)
            {
                throw new InvalidDataException("holdingName is a required property for WindeedAgriculturalSearchRequest and cannot be null");
            }
            else
            {
                this.HoldingName = holdingName;
            }

            // to ensure "holdingNumber" is required (not null)
            if (holdingNumber == null)
            {
                throw new InvalidDataException("holdingNumber is a required property for WindeedAgriculturalSearchRequest and cannot be null");
            }
            else
            {
                this.HoldingNumber = holdingNumber;
            }

            this.PortionNumber = portionNumber;
            // to ensure "deedsOffice" is required (not null)
            if (deedsOffice == null)
            {
                throw new InvalidDataException("deedsOffice is a required property for WindeedAgriculturalSearchRequest and cannot be null");
            }
            else
            {
                this.DeedsOffice = deedsOffice;
            }

            this.Reference = reference;
            this.PortionNumber = portionNumber;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets HoldingName
        /// </summary>
        [DataMember(Name="holdingName", EmitDefaultValue=true)]
        public string HoldingName { get; set; }

        /// <summary>
        /// Gets or Sets HoldingNumber
        /// </summary>
        [DataMember(Name="holdingNumber", EmitDefaultValue=true)]
        public int HoldingNumber { get; set; }

        /// <summary>
        /// Gets or Sets PortionNumber
        /// </summary>
        [DataMember(Name="portionNumber", EmitDefaultValue=true)]
        public string PortionNumber { get; set; }


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
            sb.Append("class WindeedAgriculturalSearchRequest {\n");
            sb.Append("  HoldingName: ").Append(HoldingName).Append("\n");
            sb.Append("  HoldingNumber: ").Append(HoldingNumber).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
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
            return this.Equals(input as WindeedAgriculturalSearchRequest);
        }

        /// <summary>
        /// Returns true if WindeedAgriculturalSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedAgriculturalSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedAgriculturalSearchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HoldingName == input.HoldingName ||
                    (this.HoldingName != null &&
                    this.HoldingName.Equals(input.HoldingName))
                ) && 
                (
                    this.HoldingNumber == input.HoldingNumber ||
                    (this.HoldingNumber != null &&
                    this.HoldingNumber.Equals(input.HoldingNumber))
                ) && 
                (
                    this.PortionNumber == input.PortionNumber ||
                    (this.PortionNumber != null &&
                    this.PortionNumber.Equals(input.PortionNumber))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
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
                if (this.HoldingName != null)
                    hashCode = hashCode * 59 + this.HoldingName.GetHashCode();
                if (this.HoldingNumber != null)
                    hashCode = hashCode * 59 + this.HoldingNumber.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
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