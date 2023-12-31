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
    /// XdsLinkageSearch
    /// </summary>
    [DataContract]
    public partial class XdsLinkageSearch :  IEquatable<XdsLinkageSearch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsLinkageSearch" /> class.
        /// </summary>
        /// <param name="consumersA">consumersA.</param>
        /// <param name="consumersB">consumersB.</param>
        public XdsLinkageSearch(List<ConsumerSearch> consumersA = default(List<ConsumerSearch>), List<ConsumerSearch> consumersB = default(List<ConsumerSearch>))
        {
            this.ConsumersA = consumersA;
            this.ConsumersB = consumersB;
            this.ConsumersA = consumersA;
            this.ConsumersB = consumersB;
        }

        /// <summary>
        /// Gets or Sets ConsumersA
        /// </summary>
        [DataMember(Name="consumersA", EmitDefaultValue=true)]
        public List<ConsumerSearch> ConsumersA { get; set; }

        /// <summary>
        /// Gets or Sets ConsumersB
        /// </summary>
        [DataMember(Name="consumersB", EmitDefaultValue=true)]
        public List<ConsumerSearch> ConsumersB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsLinkageSearch {\n");
            sb.Append("  ConsumersA: ").Append(ConsumersA).Append("\n");
            sb.Append("  ConsumersB: ").Append(ConsumersB).Append("\n");
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
            return this.Equals(input as XdsLinkageSearch);
        }

        /// <summary>
        /// Returns true if XdsLinkageSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsLinkageSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsLinkageSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumersA == input.ConsumersA ||
                    this.ConsumersA != null &&
                    input.ConsumersA != null &&
                    this.ConsumersA.SequenceEqual(input.ConsumersA)
                ) && 
                (
                    this.ConsumersB == input.ConsumersB ||
                    this.ConsumersB != null &&
                    input.ConsumersB != null &&
                    this.ConsumersB.SequenceEqual(input.ConsumersB)
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
                if (this.ConsumersA != null)
                    hashCode = hashCode * 59 + this.ConsumersA.GetHashCode();
                if (this.ConsumersB != null)
                    hashCode = hashCode * 59 + this.ConsumersB.GetHashCode();
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
