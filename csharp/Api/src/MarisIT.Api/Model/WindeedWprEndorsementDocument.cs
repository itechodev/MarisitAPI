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
    /// WindeedWprEndorsementDocument
    /// </summary>
    [DataContract]
    public partial class WindeedWprEndorsementDocument :  IEquatable<WindeedWprEndorsementDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedWprEndorsementDocument" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="typeDescription">typeDescription.</param>
        /// <param name="documentNumber">documentNumber.</param>
        /// <param name="typeCode">typeCode.</param>
        /// <param name="holder">holder.</param>
        public WindeedWprEndorsementDocument(double? amount = default(double?), string typeDescription = default(string), string documentNumber = default(string), string typeCode = default(string), string holder = default(string))
        {
            this.Amount = amount;
            this.TypeDescription = typeDescription;
            this.DocumentNumber = documentNumber;
            this.TypeCode = typeCode;
            this.Holder = holder;
            this.Amount = amount;
            this.TypeDescription = typeDescription;
            this.DocumentNumber = documentNumber;
            this.TypeCode = typeCode;
            this.Holder = holder;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public double? Amount { get; set; }

        /// <summary>
        /// Gets or Sets TypeDescription
        /// </summary>
        [DataMember(Name="typeDescription", EmitDefaultValue=true)]
        public string TypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [DataMember(Name="documentNumber", EmitDefaultValue=true)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets TypeCode
        /// </summary>
        [DataMember(Name="typeCode", EmitDefaultValue=true)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or Sets Holder
        /// </summary>
        [DataMember(Name="holder", EmitDefaultValue=true)]
        public string Holder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedWprEndorsementDocument {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TypeDescription: ").Append(TypeDescription).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  Holder: ").Append(Holder).Append("\n");
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
            return this.Equals(input as WindeedWprEndorsementDocument);
        }

        /// <summary>
        /// Returns true if WindeedWprEndorsementDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedWprEndorsementDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedWprEndorsementDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.TypeDescription == input.TypeDescription ||
                    (this.TypeDescription != null &&
                    this.TypeDescription.Equals(input.TypeDescription))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.TypeCode == input.TypeCode ||
                    (this.TypeCode != null &&
                    this.TypeCode.Equals(input.TypeCode))
                ) && 
                (
                    this.Holder == input.Holder ||
                    (this.Holder != null &&
                    this.Holder.Equals(input.Holder))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TypeDescription != null)
                    hashCode = hashCode * 59 + this.TypeDescription.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.TypeCode != null)
                    hashCode = hashCode * 59 + this.TypeCode.GetHashCode();
                if (this.Holder != null)
                    hashCode = hashCode * 59 + this.Holder.GetHashCode();
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
