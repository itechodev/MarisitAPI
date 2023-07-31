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
    /// WindeedFarmSearchRequest
    /// </summary>
    [DataContract]
    public partial class WindeedFarmSearchRequest :  IEquatable<WindeedFarmSearchRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Office
        /// </summary>
        [DataMember(Name="office", EmitDefaultValue=true)]
        public WindeedDeedsOffice Office { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedFarmSearchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindeedFarmSearchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedFarmSearchRequest" /> class.
        /// </summary>
        /// <param name="farmName">farmName (required).</param>
        /// <param name="farmNumber">farmNumber (required).</param>
        /// <param name="registrationDivision">registrationDivision (required).</param>
        /// <param name="portionNumber">portionNumber (required).</param>
        /// <param name="office">office (required).</param>
        /// <param name="reference">reference.</param>
        public WindeedFarmSearchRequest(string farmName = default(string), int farmNumber = default(int), string registrationDivision = default(string), string portionNumber = default(string), WindeedDeedsOffice office = default(WindeedDeedsOffice), string reference = default(string))
        {
            // to ensure "farmName" is required (not null)
            if (farmName == null)
            {
                throw new InvalidDataException("farmName is a required property for WindeedFarmSearchRequest and cannot be null");
            }
            else
            {
                this.FarmName = farmName;
            }

            // to ensure "farmNumber" is required (not null)
            if (farmNumber == null)
            {
                throw new InvalidDataException("farmNumber is a required property for WindeedFarmSearchRequest and cannot be null");
            }
            else
            {
                this.FarmNumber = farmNumber;
            }

            // to ensure "registrationDivision" is required (not null)
            if (registrationDivision == null)
            {
                throw new InvalidDataException("registrationDivision is a required property for WindeedFarmSearchRequest and cannot be null");
            }
            else
            {
                this.RegistrationDivision = registrationDivision;
            }

            // to ensure "portionNumber" is required (not null)
            if (portionNumber == null)
            {
                throw new InvalidDataException("portionNumber is a required property for WindeedFarmSearchRequest and cannot be null");
            }
            else
            {
                this.PortionNumber = portionNumber;
            }

            // to ensure "office" is required (not null)
            if (office == null)
            {
                throw new InvalidDataException("office is a required property for WindeedFarmSearchRequest and cannot be null");
            }
            else
            {
                this.Office = office;
            }

            this.Reference = reference;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets FarmName
        /// </summary>
        [DataMember(Name="farmName", EmitDefaultValue=true)]
        public string FarmName { get; set; }

        /// <summary>
        /// Gets or Sets FarmNumber
        /// </summary>
        [DataMember(Name="farmNumber", EmitDefaultValue=true)]
        public int FarmNumber { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDivision
        /// </summary>
        [DataMember(Name="registrationDivision", EmitDefaultValue=true)]
        public string RegistrationDivision { get; set; }

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
            sb.Append("class WindeedFarmSearchRequest {\n");
            sb.Append("  FarmName: ").Append(FarmName).Append("\n");
            sb.Append("  FarmNumber: ").Append(FarmNumber).Append("\n");
            sb.Append("  RegistrationDivision: ").Append(RegistrationDivision).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
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
            return this.Equals(input as WindeedFarmSearchRequest);
        }

        /// <summary>
        /// Returns true if WindeedFarmSearchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedFarmSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedFarmSearchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FarmName == input.FarmName ||
                    (this.FarmName != null &&
                    this.FarmName.Equals(input.FarmName))
                ) && 
                (
                    this.FarmNumber == input.FarmNumber ||
                    (this.FarmNumber != null &&
                    this.FarmNumber.Equals(input.FarmNumber))
                ) && 
                (
                    this.RegistrationDivision == input.RegistrationDivision ||
                    (this.RegistrationDivision != null &&
                    this.RegistrationDivision.Equals(input.RegistrationDivision))
                ) && 
                (
                    this.PortionNumber == input.PortionNumber ||
                    (this.PortionNumber != null &&
                    this.PortionNumber.Equals(input.PortionNumber))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
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
                if (this.FarmName != null)
                    hashCode = hashCode * 59 + this.FarmName.GetHashCode();
                if (this.FarmNumber != null)
                    hashCode = hashCode * 59 + this.FarmNumber.GetHashCode();
                if (this.RegistrationDivision != null)
                    hashCode = hashCode * 59 + this.RegistrationDivision.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
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