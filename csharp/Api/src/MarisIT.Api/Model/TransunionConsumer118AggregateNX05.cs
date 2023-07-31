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
    /// TransunionConsumer118AggregateNX05
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118AggregateNX05 :  IEquatable<TransunionConsumer118AggregateNX05>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118AggregateNX05" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="noJudgements">noJudgements.</param>
        /// <param name="noWriteOff">noWriteOff.</param>
        public TransunionConsumer118AggregateNX05(string consumerNo = default(string), string noJudgements = default(string), string noWriteOff = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.NoJudgements = noJudgements;
            this.NoWriteOff = noWriteOff;
            this.ConsumerNo = consumerNo;
            this.NoJudgements = noJudgements;
            this.NoWriteOff = noWriteOff;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets NoJudgements
        /// </summary>
        [DataMember(Name="noJudgements", EmitDefaultValue=true)]
        public string NoJudgements { get; set; }

        /// <summary>
        /// Gets or Sets NoWriteOff
        /// </summary>
        [DataMember(Name="noWriteOff", EmitDefaultValue=true)]
        public string NoWriteOff { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118AggregateNX05 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  NoJudgements: ").Append(NoJudgements).Append("\n");
            sb.Append("  NoWriteOff: ").Append(NoWriteOff).Append("\n");
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
            return this.Equals(input as TransunionConsumer118AggregateNX05);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118AggregateNX05 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118AggregateNX05 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118AggregateNX05 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerNo == input.ConsumerNo ||
                    (this.ConsumerNo != null &&
                    this.ConsumerNo.Equals(input.ConsumerNo))
                ) && 
                (
                    this.NoJudgements == input.NoJudgements ||
                    (this.NoJudgements != null &&
                    this.NoJudgements.Equals(input.NoJudgements))
                ) && 
                (
                    this.NoWriteOff == input.NoWriteOff ||
                    (this.NoWriteOff != null &&
                    this.NoWriteOff.Equals(input.NoWriteOff))
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
                if (this.ConsumerNo != null)
                    hashCode = hashCode * 59 + this.ConsumerNo.GetHashCode();
                if (this.NoJudgements != null)
                    hashCode = hashCode * 59 + this.NoJudgements.GetHashCode();
                if (this.NoWriteOff != null)
                    hashCode = hashCode * 59 + this.NoWriteOff.GetHashCode();
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