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
    /// WindeedErfValuationRequest
    /// </summary>
    [DataContract]
    public partial class WindeedErfValuationRequest :  IEquatable<WindeedErfValuationRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Office
        /// </summary>
        [DataMember(Name="office", EmitDefaultValue=true)]
        public WindeedDeedsOffice Office { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedErfValuationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindeedErfValuationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedErfValuationRequest" /> class.
        /// </summary>
        /// <param name="office">office (required).</param>
        /// <param name="erfNumber">erfNumber (required).</param>
        /// <param name="portionNumber">portionNumber.</param>
        /// <param name="township">township (required).</param>
        /// <param name="reference">reference.</param>
        public WindeedErfValuationRequest(WindeedDeedsOffice office = default(WindeedDeedsOffice), int erfNumber = default(int), int? portionNumber = default(int?), string township = default(string), string reference = default(string))
        {
            // to ensure "office" is required (not null)
            if (office == null)
            {
                throw new InvalidDataException("office is a required property for WindeedErfValuationRequest and cannot be null");
            }
            else
            {
                this.Office = office;
            }

            // to ensure "erfNumber" is required (not null)
            if (erfNumber == null)
            {
                throw new InvalidDataException("erfNumber is a required property for WindeedErfValuationRequest and cannot be null");
            }
            else
            {
                this.ErfNumber = erfNumber;
            }

            this.PortionNumber = portionNumber;
            // to ensure "township" is required (not null)
            if (township == null)
            {
                throw new InvalidDataException("township is a required property for WindeedErfValuationRequest and cannot be null");
            }
            else
            {
                this.Township = township;
            }

            this.Reference = reference;
            this.PortionNumber = portionNumber;
            this.Reference = reference;
        }


        /// <summary>
        /// Gets or Sets ErfNumber
        /// </summary>
        [DataMember(Name="erfNumber", EmitDefaultValue=true)]
        public int ErfNumber { get; set; }

        /// <summary>
        /// Gets or Sets PortionNumber
        /// </summary>
        [DataMember(Name="portionNumber", EmitDefaultValue=true)]
        public int? PortionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Township
        /// </summary>
        [DataMember(Name="township", EmitDefaultValue=true)]
        public string Township { get; set; }

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
            sb.Append("class WindeedErfValuationRequest {\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  ErfNumber: ").Append(ErfNumber).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
            sb.Append("  Township: ").Append(Township).Append("\n");
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
            return this.Equals(input as WindeedErfValuationRequest);
        }

        /// <summary>
        /// Returns true if WindeedErfValuationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedErfValuationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedErfValuationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.ErfNumber == input.ErfNumber ||
                    (this.ErfNumber != null &&
                    this.ErfNumber.Equals(input.ErfNumber))
                ) && 
                (
                    this.PortionNumber == input.PortionNumber ||
                    (this.PortionNumber != null &&
                    this.PortionNumber.Equals(input.PortionNumber))
                ) && 
                (
                    this.Township == input.Township ||
                    (this.Township != null &&
                    this.Township.Equals(input.Township))
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
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.ErfNumber != null)
                    hashCode = hashCode * 59 + this.ErfNumber.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
                if (this.Township != null)
                    hashCode = hashCode * 59 + this.Township.GetHashCode();
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
