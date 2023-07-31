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
    /// TransunionConsumer118EmpiricaEM05
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EmpiricaEM05 :  IEquatable<TransunionConsumer118EmpiricaEM05>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EmpiricaEM05" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="empiricaScore">empiricaScore.</param>
        /// <param name="exclusionCode">exclusionCode.</param>
        /// <param name="reasonCode1">reasonCode1.</param>
        /// <param name="reasonCode2">reasonCode2.</param>
        /// <param name="reasonCode3">reasonCode3.</param>
        /// <param name="reasonCode4">reasonCode4.</param>
        /// <param name="expansionScore">expansionScore.</param>
        public TransunionConsumer118EmpiricaEM05(string consumerNo = default(string), string empiricaScore = default(string), string exclusionCode = default(string), string reasonCode1 = default(string), string reasonCode2 = default(string), string reasonCode3 = default(string), string reasonCode4 = default(string), string expansionScore = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.EmpiricaScore = empiricaScore;
            this.ExclusionCode = exclusionCode;
            this.ReasonCode1 = reasonCode1;
            this.ReasonCode2 = reasonCode2;
            this.ReasonCode3 = reasonCode3;
            this.ReasonCode4 = reasonCode4;
            this.ExpansionScore = expansionScore;
            this.ConsumerNo = consumerNo;
            this.EmpiricaScore = empiricaScore;
            this.ExclusionCode = exclusionCode;
            this.ReasonCode1 = reasonCode1;
            this.ReasonCode2 = reasonCode2;
            this.ReasonCode3 = reasonCode3;
            this.ReasonCode4 = reasonCode4;
            this.ExpansionScore = expansionScore;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets EmpiricaScore
        /// </summary>
        [DataMember(Name="empiricaScore", EmitDefaultValue=true)]
        public string EmpiricaScore { get; set; }

        /// <summary>
        /// Gets or Sets ExclusionCode
        /// </summary>
        [DataMember(Name="exclusionCode", EmitDefaultValue=true)]
        public string ExclusionCode { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode1
        /// </summary>
        [DataMember(Name="reasonCode1", EmitDefaultValue=true)]
        public string ReasonCode1 { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode2
        /// </summary>
        [DataMember(Name="reasonCode2", EmitDefaultValue=true)]
        public string ReasonCode2 { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode3
        /// </summary>
        [DataMember(Name="reasonCode3", EmitDefaultValue=true)]
        public string ReasonCode3 { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode4
        /// </summary>
        [DataMember(Name="reasonCode4", EmitDefaultValue=true)]
        public string ReasonCode4 { get; set; }

        /// <summary>
        /// Gets or Sets ExpansionScore
        /// </summary>
        [DataMember(Name="expansionScore", EmitDefaultValue=true)]
        public string ExpansionScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EmpiricaEM05 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  EmpiricaScore: ").Append(EmpiricaScore).Append("\n");
            sb.Append("  ExclusionCode: ").Append(ExclusionCode).Append("\n");
            sb.Append("  ReasonCode1: ").Append(ReasonCode1).Append("\n");
            sb.Append("  ReasonCode2: ").Append(ReasonCode2).Append("\n");
            sb.Append("  ReasonCode3: ").Append(ReasonCode3).Append("\n");
            sb.Append("  ReasonCode4: ").Append(ReasonCode4).Append("\n");
            sb.Append("  ExpansionScore: ").Append(ExpansionScore).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EmpiricaEM05);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EmpiricaEM05 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EmpiricaEM05 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EmpiricaEM05 input)
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
                    this.EmpiricaScore == input.EmpiricaScore ||
                    (this.EmpiricaScore != null &&
                    this.EmpiricaScore.Equals(input.EmpiricaScore))
                ) && 
                (
                    this.ExclusionCode == input.ExclusionCode ||
                    (this.ExclusionCode != null &&
                    this.ExclusionCode.Equals(input.ExclusionCode))
                ) && 
                (
                    this.ReasonCode1 == input.ReasonCode1 ||
                    (this.ReasonCode1 != null &&
                    this.ReasonCode1.Equals(input.ReasonCode1))
                ) && 
                (
                    this.ReasonCode2 == input.ReasonCode2 ||
                    (this.ReasonCode2 != null &&
                    this.ReasonCode2.Equals(input.ReasonCode2))
                ) && 
                (
                    this.ReasonCode3 == input.ReasonCode3 ||
                    (this.ReasonCode3 != null &&
                    this.ReasonCode3.Equals(input.ReasonCode3))
                ) && 
                (
                    this.ReasonCode4 == input.ReasonCode4 ||
                    (this.ReasonCode4 != null &&
                    this.ReasonCode4.Equals(input.ReasonCode4))
                ) && 
                (
                    this.ExpansionScore == input.ExpansionScore ||
                    (this.ExpansionScore != null &&
                    this.ExpansionScore.Equals(input.ExpansionScore))
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
                if (this.EmpiricaScore != null)
                    hashCode = hashCode * 59 + this.EmpiricaScore.GetHashCode();
                if (this.ExclusionCode != null)
                    hashCode = hashCode * 59 + this.ExclusionCode.GetHashCode();
                if (this.ReasonCode1 != null)
                    hashCode = hashCode * 59 + this.ReasonCode1.GetHashCode();
                if (this.ReasonCode2 != null)
                    hashCode = hashCode * 59 + this.ReasonCode2.GetHashCode();
                if (this.ReasonCode3 != null)
                    hashCode = hashCode * 59 + this.ReasonCode3.GetHashCode();
                if (this.ReasonCode4 != null)
                    hashCode = hashCode * 59 + this.ReasonCode4.GetHashCode();
                if (this.ExpansionScore != null)
                    hashCode = hashCode * 59 + this.ExpansionScore.GetHashCode();
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
