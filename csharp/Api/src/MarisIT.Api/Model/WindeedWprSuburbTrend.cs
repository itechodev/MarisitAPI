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
    /// WindeedWprSuburbTrend
    /// </summary>
    [DataContract]
    public partial class WindeedWprSuburbTrend :  IEquatable<WindeedWprSuburbTrend>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedWprSuburbTrend" /> class.
        /// </summary>
        /// <param name="year">year.</param>
        /// <param name="month">month.</param>
        /// <param name="trendData">trendData.</param>
        public WindeedWprSuburbTrend(int year = default(int), int month = default(int), List<WindeedWprTrendDataForPropertyTypes> trendData = default(List<WindeedWprTrendDataForPropertyTypes>))
        {
            this.TrendData = trendData;
            this.Year = year;
            this.Month = month;
            this.TrendData = trendData;
        }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public int Month { get; set; }

        /// <summary>
        /// Gets or Sets TrendData
        /// </summary>
        [DataMember(Name="trendData", EmitDefaultValue=true)]
        public List<WindeedWprTrendDataForPropertyTypes> TrendData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedWprSuburbTrend {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  TrendData: ").Append(TrendData).Append("\n");
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
            return this.Equals(input as WindeedWprSuburbTrend);
        }

        /// <summary>
        /// Returns true if WindeedWprSuburbTrend instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedWprSuburbTrend to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedWprSuburbTrend input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.TrendData == input.TrendData ||
                    this.TrendData != null &&
                    input.TrendData != null &&
                    this.TrendData.SequenceEqual(input.TrendData)
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.TrendData != null)
                    hashCode = hashCode * 59 + this.TrendData.GetHashCode();
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