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
    /// XdsCommercialScoring
    /// </summary>
    [DataContract]
    public partial class XdsCommercialScoring :  IEquatable<XdsCommercialScoring>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsCommercialScoring" /> class.
        /// </summary>
        /// <param name="band">band.</param>
        /// <param name="bandx002FMessage1">bandx002FMessage1.</param>
        /// <param name="bandx002FMessage2">bandx002FMessage2.</param>
        /// <param name="bandx002FMessage3">bandx002FMessage3.</param>
        /// <param name="bandx002FMessage4">bandx002FMessage4.</param>
        /// <param name="bandx002FMessage5">bandx002FMessage5.</param>
        /// <param name="commercialID">commercialID.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="exceptionCode">exceptionCode.</param>
        /// <param name="finalScore">finalScore.</param>
        /// <param name="scoreBandRange1">scoreBandRange1.</param>
        /// <param name="scoreBandRange2">scoreBandRange2.</param>
        /// <param name="scoreBandRange3">scoreBandRange3.</param>
        /// <param name="scoreBandRange4">scoreBandRange4.</param>
        /// <param name="scoreBandRange5">scoreBandRange5.</param>
        /// <param name="scoreDate">scoreDate.</param>
        public XdsCommercialScoring(string band = default(string), string bandx002FMessage1 = default(string), string bandx002FMessage2 = default(string), string bandx002FMessage3 = default(string), string bandx002FMessage4 = default(string), string bandx002FMessage5 = default(string), string commercialID = default(string), string displayText = default(string), string exceptionCode = default(string), string finalScore = default(string), string scoreBandRange1 = default(string), string scoreBandRange2 = default(string), string scoreBandRange3 = default(string), string scoreBandRange4 = default(string), string scoreBandRange5 = default(string), string scoreDate = default(string))
        {
            this.Band = band;
            this.Bandx002FMessage1 = bandx002FMessage1;
            this.Bandx002FMessage2 = bandx002FMessage2;
            this.Bandx002FMessage3 = bandx002FMessage3;
            this.Bandx002FMessage4 = bandx002FMessage4;
            this.Bandx002FMessage5 = bandx002FMessage5;
            this.CommercialID = commercialID;
            this.DisplayText = displayText;
            this.ExceptionCode = exceptionCode;
            this.FinalScore = finalScore;
            this.ScoreBandRange1 = scoreBandRange1;
            this.ScoreBandRange2 = scoreBandRange2;
            this.ScoreBandRange3 = scoreBandRange3;
            this.ScoreBandRange4 = scoreBandRange4;
            this.ScoreBandRange5 = scoreBandRange5;
            this.ScoreDate = scoreDate;
            this.Band = band;
            this.Bandx002FMessage1 = bandx002FMessage1;
            this.Bandx002FMessage2 = bandx002FMessage2;
            this.Bandx002FMessage3 = bandx002FMessage3;
            this.Bandx002FMessage4 = bandx002FMessage4;
            this.Bandx002FMessage5 = bandx002FMessage5;
            this.CommercialID = commercialID;
            this.DisplayText = displayText;
            this.ExceptionCode = exceptionCode;
            this.FinalScore = finalScore;
            this.ScoreBandRange1 = scoreBandRange1;
            this.ScoreBandRange2 = scoreBandRange2;
            this.ScoreBandRange3 = scoreBandRange3;
            this.ScoreBandRange4 = scoreBandRange4;
            this.ScoreBandRange5 = scoreBandRange5;
            this.ScoreDate = scoreDate;
        }

        /// <summary>
        /// Gets or Sets Band
        /// </summary>
        [DataMember(Name="band", EmitDefaultValue=true)]
        public string Band { get; set; }

        /// <summary>
        /// Gets or Sets Bandx002FMessage1
        /// </summary>
        [DataMember(Name="bandx002FMessage1", EmitDefaultValue=true)]
        public string Bandx002FMessage1 { get; set; }

        /// <summary>
        /// Gets or Sets Bandx002FMessage2
        /// </summary>
        [DataMember(Name="bandx002FMessage2", EmitDefaultValue=true)]
        public string Bandx002FMessage2 { get; set; }

        /// <summary>
        /// Gets or Sets Bandx002FMessage3
        /// </summary>
        [DataMember(Name="bandx002FMessage3", EmitDefaultValue=true)]
        public string Bandx002FMessage3 { get; set; }

        /// <summary>
        /// Gets or Sets Bandx002FMessage4
        /// </summary>
        [DataMember(Name="bandx002FMessage4", EmitDefaultValue=true)]
        public string Bandx002FMessage4 { get; set; }

        /// <summary>
        /// Gets or Sets Bandx002FMessage5
        /// </summary>
        [DataMember(Name="bandx002FMessage5", EmitDefaultValue=true)]
        public string Bandx002FMessage5 { get; set; }

        /// <summary>
        /// Gets or Sets CommercialID
        /// </summary>
        [DataMember(Name="commercialID", EmitDefaultValue=true)]
        public string CommercialID { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionCode
        /// </summary>
        [DataMember(Name="exceptionCode", EmitDefaultValue=true)]
        public string ExceptionCode { get; set; }

        /// <summary>
        /// Gets or Sets FinalScore
        /// </summary>
        [DataMember(Name="finalScore", EmitDefaultValue=true)]
        public string FinalScore { get; set; }

        /// <summary>
        /// Gets or Sets ScoreBandRange1
        /// </summary>
        [DataMember(Name="scoreBandRange1", EmitDefaultValue=true)]
        public string ScoreBandRange1 { get; set; }

        /// <summary>
        /// Gets or Sets ScoreBandRange2
        /// </summary>
        [DataMember(Name="scoreBandRange2", EmitDefaultValue=true)]
        public string ScoreBandRange2 { get; set; }

        /// <summary>
        /// Gets or Sets ScoreBandRange3
        /// </summary>
        [DataMember(Name="scoreBandRange3", EmitDefaultValue=true)]
        public string ScoreBandRange3 { get; set; }

        /// <summary>
        /// Gets or Sets ScoreBandRange4
        /// </summary>
        [DataMember(Name="scoreBandRange4", EmitDefaultValue=true)]
        public string ScoreBandRange4 { get; set; }

        /// <summary>
        /// Gets or Sets ScoreBandRange5
        /// </summary>
        [DataMember(Name="scoreBandRange5", EmitDefaultValue=true)]
        public string ScoreBandRange5 { get; set; }

        /// <summary>
        /// Gets or Sets ScoreDate
        /// </summary>
        [DataMember(Name="scoreDate", EmitDefaultValue=true)]
        public string ScoreDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsCommercialScoring {\n");
            sb.Append("  Band: ").Append(Band).Append("\n");
            sb.Append("  Bandx002FMessage1: ").Append(Bandx002FMessage1).Append("\n");
            sb.Append("  Bandx002FMessage2: ").Append(Bandx002FMessage2).Append("\n");
            sb.Append("  Bandx002FMessage3: ").Append(Bandx002FMessage3).Append("\n");
            sb.Append("  Bandx002FMessage4: ").Append(Bandx002FMessage4).Append("\n");
            sb.Append("  Bandx002FMessage5: ").Append(Bandx002FMessage5).Append("\n");
            sb.Append("  CommercialID: ").Append(CommercialID).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  ExceptionCode: ").Append(ExceptionCode).Append("\n");
            sb.Append("  FinalScore: ").Append(FinalScore).Append("\n");
            sb.Append("  ScoreBandRange1: ").Append(ScoreBandRange1).Append("\n");
            sb.Append("  ScoreBandRange2: ").Append(ScoreBandRange2).Append("\n");
            sb.Append("  ScoreBandRange3: ").Append(ScoreBandRange3).Append("\n");
            sb.Append("  ScoreBandRange4: ").Append(ScoreBandRange4).Append("\n");
            sb.Append("  ScoreBandRange5: ").Append(ScoreBandRange5).Append("\n");
            sb.Append("  ScoreDate: ").Append(ScoreDate).Append("\n");
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
            return this.Equals(input as XdsCommercialScoring);
        }

        /// <summary>
        /// Returns true if XdsCommercialScoring instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsCommercialScoring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsCommercialScoring input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Band == input.Band ||
                    (this.Band != null &&
                    this.Band.Equals(input.Band))
                ) && 
                (
                    this.Bandx002FMessage1 == input.Bandx002FMessage1 ||
                    (this.Bandx002FMessage1 != null &&
                    this.Bandx002FMessage1.Equals(input.Bandx002FMessage1))
                ) && 
                (
                    this.Bandx002FMessage2 == input.Bandx002FMessage2 ||
                    (this.Bandx002FMessage2 != null &&
                    this.Bandx002FMessage2.Equals(input.Bandx002FMessage2))
                ) && 
                (
                    this.Bandx002FMessage3 == input.Bandx002FMessage3 ||
                    (this.Bandx002FMessage3 != null &&
                    this.Bandx002FMessage3.Equals(input.Bandx002FMessage3))
                ) && 
                (
                    this.Bandx002FMessage4 == input.Bandx002FMessage4 ||
                    (this.Bandx002FMessage4 != null &&
                    this.Bandx002FMessage4.Equals(input.Bandx002FMessage4))
                ) && 
                (
                    this.Bandx002FMessage5 == input.Bandx002FMessage5 ||
                    (this.Bandx002FMessage5 != null &&
                    this.Bandx002FMessage5.Equals(input.Bandx002FMessage5))
                ) && 
                (
                    this.CommercialID == input.CommercialID ||
                    (this.CommercialID != null &&
                    this.CommercialID.Equals(input.CommercialID))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.ExceptionCode == input.ExceptionCode ||
                    (this.ExceptionCode != null &&
                    this.ExceptionCode.Equals(input.ExceptionCode))
                ) && 
                (
                    this.FinalScore == input.FinalScore ||
                    (this.FinalScore != null &&
                    this.FinalScore.Equals(input.FinalScore))
                ) && 
                (
                    this.ScoreBandRange1 == input.ScoreBandRange1 ||
                    (this.ScoreBandRange1 != null &&
                    this.ScoreBandRange1.Equals(input.ScoreBandRange1))
                ) && 
                (
                    this.ScoreBandRange2 == input.ScoreBandRange2 ||
                    (this.ScoreBandRange2 != null &&
                    this.ScoreBandRange2.Equals(input.ScoreBandRange2))
                ) && 
                (
                    this.ScoreBandRange3 == input.ScoreBandRange3 ||
                    (this.ScoreBandRange3 != null &&
                    this.ScoreBandRange3.Equals(input.ScoreBandRange3))
                ) && 
                (
                    this.ScoreBandRange4 == input.ScoreBandRange4 ||
                    (this.ScoreBandRange4 != null &&
                    this.ScoreBandRange4.Equals(input.ScoreBandRange4))
                ) && 
                (
                    this.ScoreBandRange5 == input.ScoreBandRange5 ||
                    (this.ScoreBandRange5 != null &&
                    this.ScoreBandRange5.Equals(input.ScoreBandRange5))
                ) && 
                (
                    this.ScoreDate == input.ScoreDate ||
                    (this.ScoreDate != null &&
                    this.ScoreDate.Equals(input.ScoreDate))
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
                if (this.Band != null)
                    hashCode = hashCode * 59 + this.Band.GetHashCode();
                if (this.Bandx002FMessage1 != null)
                    hashCode = hashCode * 59 + this.Bandx002FMessage1.GetHashCode();
                if (this.Bandx002FMessage2 != null)
                    hashCode = hashCode * 59 + this.Bandx002FMessage2.GetHashCode();
                if (this.Bandx002FMessage3 != null)
                    hashCode = hashCode * 59 + this.Bandx002FMessage3.GetHashCode();
                if (this.Bandx002FMessage4 != null)
                    hashCode = hashCode * 59 + this.Bandx002FMessage4.GetHashCode();
                if (this.Bandx002FMessage5 != null)
                    hashCode = hashCode * 59 + this.Bandx002FMessage5.GetHashCode();
                if (this.CommercialID != null)
                    hashCode = hashCode * 59 + this.CommercialID.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.ExceptionCode != null)
                    hashCode = hashCode * 59 + this.ExceptionCode.GetHashCode();
                if (this.FinalScore != null)
                    hashCode = hashCode * 59 + this.FinalScore.GetHashCode();
                if (this.ScoreBandRange1 != null)
                    hashCode = hashCode * 59 + this.ScoreBandRange1.GetHashCode();
                if (this.ScoreBandRange2 != null)
                    hashCode = hashCode * 59 + this.ScoreBandRange2.GetHashCode();
                if (this.ScoreBandRange3 != null)
                    hashCode = hashCode * 59 + this.ScoreBandRange3.GetHashCode();
                if (this.ScoreBandRange4 != null)
                    hashCode = hashCode * 59 + this.ScoreBandRange4.GetHashCode();
                if (this.ScoreBandRange5 != null)
                    hashCode = hashCode * 59 + this.ScoreBandRange5.GetHashCode();
                if (this.ScoreDate != null)
                    hashCode = hashCode * 59 + this.ScoreDate.GetHashCode();
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
