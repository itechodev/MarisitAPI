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
    /// WindeedOfficeProxiesErfPortionItem
    /// </summary>
    [DataContract]
    public partial class WindeedOfficeProxiesErfPortionItem :  IEquatable<WindeedOfficeProxiesErfPortionItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedOfficeProxiesErfPortionItem" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        public WindeedOfficeProxiesErfPortionItem(string reference = default(string))
        {
            this.Reference = reference;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public string DeedsOffice { get; private set; }

        /// <summary>
        /// Gets or Sets ErfNumber
        /// </summary>
        [DataMember(Name="erfNumber", EmitDefaultValue=true)]
        public string ErfNumber { get; private set; }

        /// <summary>
        /// Gets or Sets PortionNumber
        /// </summary>
        [DataMember(Name="portionNumber", EmitDefaultValue=true)]
        public string PortionNumber { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedOfficeProxiesErfPortionItem {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  ErfNumber: ").Append(ErfNumber).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
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
            return this.Equals(input as WindeedOfficeProxiesErfPortionItem);
        }

        /// <summary>
        /// Returns true if WindeedOfficeProxiesErfPortionItem instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedOfficeProxiesErfPortionItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedOfficeProxiesErfPortionItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
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
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.ErfNumber != null)
                    hashCode = hashCode * 59 + this.ErfNumber.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
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