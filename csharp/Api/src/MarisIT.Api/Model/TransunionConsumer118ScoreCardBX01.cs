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
    /// TransunionConsumer118ScoreCardBX01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ScoreCardBX01 :  IEquatable<TransunionConsumer118ScoreCardBX01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ScoreCardBX01" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="policyFilters">policyFilters.</param>
        /// <param name="indicators">indicators.</param>
        /// <param name="scoreReasons">scoreReasons.</param>
        /// <param name="riskBand">riskBand.</param>
        /// <param name="referRiskBand">referRiskBand.</param>
        /// <param name="recommended">recommended.</param>
        public TransunionConsumer118ScoreCardBX01(string consumerNo = default(string), List<string> policyFilters = default(List<string>), List<TransunionConsumer118BX01> indicators = default(List<TransunionConsumer118BX01>), List<string> scoreReasons = default(List<string>), string riskBand = default(string), string referRiskBand = default(string), string recommended = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.PolicyFilters = policyFilters;
            this.Indicators = indicators;
            this.ScoreReasons = scoreReasons;
            this.RiskBand = riskBand;
            this.ReferRiskBand = referRiskBand;
            this.Recommended = recommended;
            this.ConsumerNo = consumerNo;
            this.PolicyFilters = policyFilters;
            this.Indicators = indicators;
            this.ScoreReasons = scoreReasons;
            this.RiskBand = riskBand;
            this.ReferRiskBand = referRiskBand;
            this.Recommended = recommended;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets PolicyFilters
        /// </summary>
        [DataMember(Name="policyFilters", EmitDefaultValue=true)]
        public List<string> PolicyFilters { get; set; }

        /// <summary>
        /// Gets or Sets Indicators
        /// </summary>
        [DataMember(Name="indicators", EmitDefaultValue=true)]
        public List<TransunionConsumer118BX01> Indicators { get; set; }

        /// <summary>
        /// Gets or Sets ScoreReasons
        /// </summary>
        [DataMember(Name="scoreReasons", EmitDefaultValue=true)]
        public List<string> ScoreReasons { get; set; }

        /// <summary>
        /// Gets or Sets RiskBand
        /// </summary>
        [DataMember(Name="riskBand", EmitDefaultValue=true)]
        public string RiskBand { get; set; }

        /// <summary>
        /// Gets or Sets ReferRiskBand
        /// </summary>
        [DataMember(Name="referRiskBand", EmitDefaultValue=true)]
        public string ReferRiskBand { get; set; }

        /// <summary>
        /// Gets or Sets Recommended
        /// </summary>
        [DataMember(Name="recommended", EmitDefaultValue=true)]
        public string Recommended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ScoreCardBX01 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  PolicyFilters: ").Append(PolicyFilters).Append("\n");
            sb.Append("  Indicators: ").Append(Indicators).Append("\n");
            sb.Append("  ScoreReasons: ").Append(ScoreReasons).Append("\n");
            sb.Append("  RiskBand: ").Append(RiskBand).Append("\n");
            sb.Append("  ReferRiskBand: ").Append(ReferRiskBand).Append("\n");
            sb.Append("  Recommended: ").Append(Recommended).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ScoreCardBX01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ScoreCardBX01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ScoreCardBX01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ScoreCardBX01 input)
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
                    this.PolicyFilters == input.PolicyFilters ||
                    this.PolicyFilters != null &&
                    input.PolicyFilters != null &&
                    this.PolicyFilters.SequenceEqual(input.PolicyFilters)
                ) && 
                (
                    this.Indicators == input.Indicators ||
                    this.Indicators != null &&
                    input.Indicators != null &&
                    this.Indicators.SequenceEqual(input.Indicators)
                ) && 
                (
                    this.ScoreReasons == input.ScoreReasons ||
                    this.ScoreReasons != null &&
                    input.ScoreReasons != null &&
                    this.ScoreReasons.SequenceEqual(input.ScoreReasons)
                ) && 
                (
                    this.RiskBand == input.RiskBand ||
                    (this.RiskBand != null &&
                    this.RiskBand.Equals(input.RiskBand))
                ) && 
                (
                    this.ReferRiskBand == input.ReferRiskBand ||
                    (this.ReferRiskBand != null &&
                    this.ReferRiskBand.Equals(input.ReferRiskBand))
                ) && 
                (
                    this.Recommended == input.Recommended ||
                    (this.Recommended != null &&
                    this.Recommended.Equals(input.Recommended))
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
                if (this.PolicyFilters != null)
                    hashCode = hashCode * 59 + this.PolicyFilters.GetHashCode();
                if (this.Indicators != null)
                    hashCode = hashCode * 59 + this.Indicators.GetHashCode();
                if (this.ScoreReasons != null)
                    hashCode = hashCode * 59 + this.ScoreReasons.GetHashCode();
                if (this.RiskBand != null)
                    hashCode = hashCode * 59 + this.RiskBand.GetHashCode();
                if (this.ReferRiskBand != null)
                    hashCode = hashCode * 59 + this.ReferRiskBand.GetHashCode();
                if (this.Recommended != null)
                    hashCode = hashCode * 59 + this.Recommended.GetHashCode();
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
