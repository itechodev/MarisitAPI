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
    /// TransunionConsumer118ForensicLinkagesJudgementsAssociates
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ForensicLinkagesJudgementsAssociates :  IEquatable<TransunionConsumer118ForensicLinkagesJudgementsAssociates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ForensicLinkagesJudgementsAssociates" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="consumerNumber">consumerNumber.</param>
        /// <param name="identityNumber">identityNumber.</param>
        public TransunionConsumer118ForensicLinkagesJudgementsAssociates(string name = default(string), string consumerNumber = default(string), string identityNumber = default(string))
        {
            this.Name = name;
            this.ConsumerNumber = consumerNumber;
            this.IdentityNumber = identityNumber;
            this.Name = name;
            this.ConsumerNumber = consumerNumber;
            this.IdentityNumber = identityNumber;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerNumber
        /// </summary>
        [DataMember(Name="consumerNumber", EmitDefaultValue=true)]
        public string ConsumerNumber { get; set; }

        /// <summary>
        /// Gets or Sets IdentityNumber
        /// </summary>
        [DataMember(Name="identityNumber", EmitDefaultValue=true)]
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ForensicLinkagesJudgementsAssociates {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConsumerNumber: ").Append(ConsumerNumber).Append("\n");
            sb.Append("  IdentityNumber: ").Append(IdentityNumber).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ForensicLinkagesJudgementsAssociates);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ForensicLinkagesJudgementsAssociates instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ForensicLinkagesJudgementsAssociates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ForensicLinkagesJudgementsAssociates input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ConsumerNumber == input.ConsumerNumber ||
                    (this.ConsumerNumber != null &&
                    this.ConsumerNumber.Equals(input.ConsumerNumber))
                ) && 
                (
                    this.IdentityNumber == input.IdentityNumber ||
                    (this.IdentityNumber != null &&
                    this.IdentityNumber.Equals(input.IdentityNumber))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ConsumerNumber != null)
                    hashCode = hashCode * 59 + this.ConsumerNumber.GetHashCode();
                if (this.IdentityNumber != null)
                    hashCode = hashCode * 59 + this.IdentityNumber.GetHashCode();
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
