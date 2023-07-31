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
    /// TransunionConsumer118Agreement
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118Agreement :  IEquatable<TransunionConsumer118Agreement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118Agreement" /> class.
        /// </summary>
        /// <param name="agreementNumber">agreementNumber.</param>
        public TransunionConsumer118Agreement(string agreementNumber = default(string))
        {
            this.AgreementNumber = agreementNumber;
            this.AgreementNumber = agreementNumber;
        }

        /// <summary>
        /// Gets or Sets AgreementNumber
        /// </summary>
        [DataMember(Name="agreementNumber", EmitDefaultValue=true)]
        public string AgreementNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118Agreement {\n");
            sb.Append("  AgreementNumber: ").Append(AgreementNumber).Append("\n");
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
            return this.Equals(input as TransunionConsumer118Agreement);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118Agreement instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118Agreement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118Agreement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgreementNumber == input.AgreementNumber ||
                    (this.AgreementNumber != null &&
                    this.AgreementNumber.Equals(input.AgreementNumber))
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
                if (this.AgreementNumber != null)
                    hashCode = hashCode * 59 + this.AgreementNumber.GetHashCode();
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
