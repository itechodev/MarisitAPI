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
    /// TransunionConsumer118CustomisedScorecardGS01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118CustomisedScorecardGS01 :  IEquatable<TransunionConsumer118CustomisedScorecardGS01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118CustomisedScorecardGS01" /> class.
        /// </summary>
        /// <param name="consumerNumber">consumerNumber.</param>
        /// <param name="policyFilters">policyFilters.</param>
        /// <param name="scorecardID">scorecardID.</param>
        /// <param name="score">score.</param>
        /// <param name="riskBand">riskBand.</param>
        /// <param name="scorecardVariables">scorecardVariables.</param>
        public TransunionConsumer118CustomisedScorecardGS01(string consumerNumber = default(string), List<TransunionConsumer118PolicyFilters> policyFilters = default(List<TransunionConsumer118PolicyFilters>), string scorecardID = default(string), string score = default(string), string riskBand = default(string), List<TransunionConsumer118ScorecardVariables> scorecardVariables = default(List<TransunionConsumer118ScorecardVariables>))
        {
            this.ConsumerNumber = consumerNumber;
            this.PolicyFilters = policyFilters;
            this.ScorecardID = scorecardID;
            this.Score = score;
            this.RiskBand = riskBand;
            this.ScorecardVariables = scorecardVariables;
            this.ConsumerNumber = consumerNumber;
            this.PolicyFilters = policyFilters;
            this.ScorecardID = scorecardID;
            this.Score = score;
            this.RiskBand = riskBand;
            this.ScorecardVariables = scorecardVariables;
        }

        /// <summary>
        /// Gets or Sets ConsumerNumber
        /// </summary>
        [DataMember(Name="consumerNumber", EmitDefaultValue=true)]
        public string ConsumerNumber { get; set; }

        /// <summary>
        /// Gets or Sets PolicyFilters
        /// </summary>
        [DataMember(Name="policyFilters", EmitDefaultValue=true)]
        public List<TransunionConsumer118PolicyFilters> PolicyFilters { get; set; }

        /// <summary>
        /// Gets or Sets ScorecardID
        /// </summary>
        [DataMember(Name="scorecardID", EmitDefaultValue=true)]
        public string ScorecardID { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=true)]
        public string Score { get; set; }

        /// <summary>
        /// Gets or Sets RiskBand
        /// </summary>
        [DataMember(Name="riskBand", EmitDefaultValue=true)]
        public string RiskBand { get; set; }

        /// <summary>
        /// Gets or Sets ScorecardVariables
        /// </summary>
        [DataMember(Name="scorecardVariables", EmitDefaultValue=true)]
        public List<TransunionConsumer118ScorecardVariables> ScorecardVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118CustomisedScorecardGS01 {\n");
            sb.Append("  ConsumerNumber: ").Append(ConsumerNumber).Append("\n");
            sb.Append("  PolicyFilters: ").Append(PolicyFilters).Append("\n");
            sb.Append("  ScorecardID: ").Append(ScorecardID).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  RiskBand: ").Append(RiskBand).Append("\n");
            sb.Append("  ScorecardVariables: ").Append(ScorecardVariables).Append("\n");
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
            return this.Equals(input as TransunionConsumer118CustomisedScorecardGS01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118CustomisedScorecardGS01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118CustomisedScorecardGS01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118CustomisedScorecardGS01 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerNumber == input.ConsumerNumber ||
                    (this.ConsumerNumber != null &&
                    this.ConsumerNumber.Equals(input.ConsumerNumber))
                ) && 
                (
                    this.PolicyFilters == input.PolicyFilters ||
                    this.PolicyFilters != null &&
                    input.PolicyFilters != null &&
                    this.PolicyFilters.SequenceEqual(input.PolicyFilters)
                ) && 
                (
                    this.ScorecardID == input.ScorecardID ||
                    (this.ScorecardID != null &&
                    this.ScorecardID.Equals(input.ScorecardID))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.RiskBand == input.RiskBand ||
                    (this.RiskBand != null &&
                    this.RiskBand.Equals(input.RiskBand))
                ) && 
                (
                    this.ScorecardVariables == input.ScorecardVariables ||
                    this.ScorecardVariables != null &&
                    input.ScorecardVariables != null &&
                    this.ScorecardVariables.SequenceEqual(input.ScorecardVariables)
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
                if (this.ConsumerNumber != null)
                    hashCode = hashCode * 59 + this.ConsumerNumber.GetHashCode();
                if (this.PolicyFilters != null)
                    hashCode = hashCode * 59 + this.PolicyFilters.GetHashCode();
                if (this.ScorecardID != null)
                    hashCode = hashCode * 59 + this.ScorecardID.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.RiskBand != null)
                    hashCode = hashCode * 59 + this.RiskBand.GetHashCode();
                if (this.ScorecardVariables != null)
                    hashCode = hashCode * 59 + this.ScorecardVariables.GetHashCode();
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
