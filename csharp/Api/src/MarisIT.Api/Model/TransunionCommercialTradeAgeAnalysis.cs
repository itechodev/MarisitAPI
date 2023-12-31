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
    /// TransunionCommercialTradeAgeAnalysis
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialTradeAgeAnalysis :  IEquatable<TransunionCommercialTradeAgeAnalysis>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialTradeAgeAnalysis" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="ageAnalysisDetails">ageAnalysisDetails.</param>
        /// <param name="message">message.</param>
        /// <param name="date">date.</param>
        public TransunionCommercialTradeAgeAnalysis(string majorProduct = default(string), List<TransunionCommercialAgeAnalysisDetail> ageAnalysisDetails = default(List<TransunionCommercialAgeAnalysisDetail>), string message = default(string), string date = default(string))
        {
            this.MajorProduct = majorProduct;
            this.AgeAnalysisDetails = ageAnalysisDetails;
            this.Message = message;
            this.Date = date;
            this.MajorProduct = majorProduct;
            this.AgeAnalysisDetails = ageAnalysisDetails;
            this.Message = message;
            this.Date = date;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets AgeAnalysisDetails
        /// </summary>
        [DataMember(Name="ageAnalysisDetails", EmitDefaultValue=true)]
        public List<TransunionCommercialAgeAnalysisDetail> AgeAnalysisDetails { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public string Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialTradeAgeAnalysis {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  AgeAnalysisDetails: ").Append(AgeAnalysisDetails).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as TransunionCommercialTradeAgeAnalysis);
        }

        /// <summary>
        /// Returns true if TransunionCommercialTradeAgeAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialTradeAgeAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialTradeAgeAnalysis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MajorProduct == input.MajorProduct ||
                    (this.MajorProduct != null &&
                    this.MajorProduct.Equals(input.MajorProduct))
                ) && 
                (
                    this.AgeAnalysisDetails == input.AgeAnalysisDetails ||
                    this.AgeAnalysisDetails != null &&
                    input.AgeAnalysisDetails != null &&
                    this.AgeAnalysisDetails.SequenceEqual(input.AgeAnalysisDetails)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.MajorProduct != null)
                    hashCode = hashCode * 59 + this.MajorProduct.GetHashCode();
                if (this.AgeAnalysisDetails != null)
                    hashCode = hashCode * 59 + this.AgeAnalysisDetails.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
