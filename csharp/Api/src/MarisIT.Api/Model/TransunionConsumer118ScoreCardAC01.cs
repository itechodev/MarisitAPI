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
    /// TransunionConsumer118ScoreCardAC01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ScoreCardAC01 :  IEquatable<TransunionConsumer118ScoreCardAC01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ScoreCardAC01" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="scoreType">scoreType.</param>
        /// <param name="creditScore">creditScore.</param>
        /// <param name="affordabilityReferTrigger">affordabilityReferTrigger.</param>
        /// <param name="installmentDifferenceDebitCreditIndicator">installmentDifferenceDebitCreditIndicator.</param>
        /// <param name="installmentDifference">installmentDifference.</param>
        /// <param name="utilisationScore">utilisationScore.</param>
        public TransunionConsumer118ScoreCardAC01(int consumerNo = default(int), string scoreType = default(string), int creditScore = default(int), string affordabilityReferTrigger = default(string), string installmentDifferenceDebitCreditIndicator = default(string), int installmentDifference = default(int), int utilisationScore = default(int))
        {
            this.ScoreType = scoreType;
            this.AffordabilityReferTrigger = affordabilityReferTrigger;
            this.InstallmentDifferenceDebitCreditIndicator = installmentDifferenceDebitCreditIndicator;
            this.ConsumerNo = consumerNo;
            this.ScoreType = scoreType;
            this.CreditScore = creditScore;
            this.AffordabilityReferTrigger = affordabilityReferTrigger;
            this.InstallmentDifferenceDebitCreditIndicator = installmentDifferenceDebitCreditIndicator;
            this.InstallmentDifference = installmentDifference;
            this.UtilisationScore = utilisationScore;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=false)]
        public int ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets ScoreType
        /// </summary>
        [DataMember(Name="scoreType", EmitDefaultValue=true)]
        public string ScoreType { get; set; }

        /// <summary>
        /// Gets or Sets CreditScore
        /// </summary>
        [DataMember(Name="creditScore", EmitDefaultValue=false)]
        public int CreditScore { get; set; }

        /// <summary>
        /// Gets or Sets AffordabilityReferTrigger
        /// </summary>
        [DataMember(Name="affordabilityReferTrigger", EmitDefaultValue=true)]
        public string AffordabilityReferTrigger { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentDifferenceDebitCreditIndicator
        /// </summary>
        [DataMember(Name="installmentDifferenceDebitCreditIndicator", EmitDefaultValue=true)]
        public string InstallmentDifferenceDebitCreditIndicator { get; set; }

        /// <summary>
        /// Gets or Sets InstallmentDifference
        /// </summary>
        [DataMember(Name="installmentDifference", EmitDefaultValue=false)]
        public int InstallmentDifference { get; set; }

        /// <summary>
        /// Gets or Sets UtilisationScore
        /// </summary>
        [DataMember(Name="utilisationScore", EmitDefaultValue=false)]
        public int UtilisationScore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ScoreCardAC01 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  ScoreType: ").Append(ScoreType).Append("\n");
            sb.Append("  CreditScore: ").Append(CreditScore).Append("\n");
            sb.Append("  AffordabilityReferTrigger: ").Append(AffordabilityReferTrigger).Append("\n");
            sb.Append("  InstallmentDifferenceDebitCreditIndicator: ").Append(InstallmentDifferenceDebitCreditIndicator).Append("\n");
            sb.Append("  InstallmentDifference: ").Append(InstallmentDifference).Append("\n");
            sb.Append("  UtilisationScore: ").Append(UtilisationScore).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ScoreCardAC01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ScoreCardAC01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ScoreCardAC01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ScoreCardAC01 input)
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
                    this.ScoreType == input.ScoreType ||
                    (this.ScoreType != null &&
                    this.ScoreType.Equals(input.ScoreType))
                ) && 
                (
                    this.CreditScore == input.CreditScore ||
                    (this.CreditScore != null &&
                    this.CreditScore.Equals(input.CreditScore))
                ) && 
                (
                    this.AffordabilityReferTrigger == input.AffordabilityReferTrigger ||
                    (this.AffordabilityReferTrigger != null &&
                    this.AffordabilityReferTrigger.Equals(input.AffordabilityReferTrigger))
                ) && 
                (
                    this.InstallmentDifferenceDebitCreditIndicator == input.InstallmentDifferenceDebitCreditIndicator ||
                    (this.InstallmentDifferenceDebitCreditIndicator != null &&
                    this.InstallmentDifferenceDebitCreditIndicator.Equals(input.InstallmentDifferenceDebitCreditIndicator))
                ) && 
                (
                    this.InstallmentDifference == input.InstallmentDifference ||
                    (this.InstallmentDifference != null &&
                    this.InstallmentDifference.Equals(input.InstallmentDifference))
                ) && 
                (
                    this.UtilisationScore == input.UtilisationScore ||
                    (this.UtilisationScore != null &&
                    this.UtilisationScore.Equals(input.UtilisationScore))
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
                if (this.ScoreType != null)
                    hashCode = hashCode * 59 + this.ScoreType.GetHashCode();
                if (this.CreditScore != null)
                    hashCode = hashCode * 59 + this.CreditScore.GetHashCode();
                if (this.AffordabilityReferTrigger != null)
                    hashCode = hashCode * 59 + this.AffordabilityReferTrigger.GetHashCode();
                if (this.InstallmentDifferenceDebitCreditIndicator != null)
                    hashCode = hashCode * 59 + this.InstallmentDifferenceDebitCreditIndicator.GetHashCode();
                if (this.InstallmentDifference != null)
                    hashCode = hashCode * 59 + this.InstallmentDifference.GetHashCode();
                if (this.UtilisationScore != null)
                    hashCode = hashCode * 59 + this.UtilisationScore.GetHashCode();
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
