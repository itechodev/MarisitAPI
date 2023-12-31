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
    /// TransunionConsumer118TraceMoreDetailsTM
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TraceMoreDetailsTM :  IEquatable<TransunionConsumer118TraceMoreDetailsTM>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TraceMoreDetailsTM" /> class.
        /// </summary>
        /// <param name="oCounter">oCounter.</param>
        /// <param name="oMoreCount">oMoreCount.</param>
        public TransunionConsumer118TraceMoreDetailsTM(string oCounter = default(string), string oMoreCount = default(string))
        {
            this.OCounter = oCounter;
            this.OMoreCount = oMoreCount;
            this.OCounter = oCounter;
            this.OMoreCount = oMoreCount;
        }

        /// <summary>
        /// Gets or Sets OCounter
        /// </summary>
        [DataMember(Name="oCounter", EmitDefaultValue=true)]
        public string OCounter { get; set; }

        /// <summary>
        /// Gets or Sets OMoreCount
        /// </summary>
        [DataMember(Name="oMoreCount", EmitDefaultValue=true)]
        public string OMoreCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TraceMoreDetailsTM {\n");
            sb.Append("  OCounter: ").Append(OCounter).Append("\n");
            sb.Append("  OMoreCount: ").Append(OMoreCount).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TraceMoreDetailsTM);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TraceMoreDetailsTM instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TraceMoreDetailsTM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TraceMoreDetailsTM input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OCounter == input.OCounter ||
                    (this.OCounter != null &&
                    this.OCounter.Equals(input.OCounter))
                ) && 
                (
                    this.OMoreCount == input.OMoreCount ||
                    (this.OMoreCount != null &&
                    this.OMoreCount.Equals(input.OMoreCount))
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
                if (this.OCounter != null)
                    hashCode = hashCode * 59 + this.OCounter.GetHashCode();
                if (this.OMoreCount != null)
                    hashCode = hashCode * 59 + this.OMoreCount.GetHashCode();
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
