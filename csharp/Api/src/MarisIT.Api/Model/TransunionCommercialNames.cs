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
    /// TransunionCommercialNames
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialNames :  IEquatable<TransunionCommercialNames>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialNames" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="businessName">businessName.</param>
        /// <param name="akaName">akaName.</param>
        /// <param name="divisionalNames">divisionalNames.</param>
        /// <param name="previousNames">previousNames.</param>
        /// <param name="previousNameDates">previousNameDates.</param>
        /// <param name="tradeStyles">tradeStyles.</param>
        public TransunionCommercialNames(string majorProduct = default(string), string businessName = default(string), string akaName = default(string), List<string> divisionalNames = default(List<string>), List<string> previousNames = default(List<string>), List<string> previousNameDates = default(List<string>), List<string> tradeStyles = default(List<string>))
        {
            this.MajorProduct = majorProduct;
            this.BusinessName = businessName;
            this.AkaName = akaName;
            this.DivisionalNames = divisionalNames;
            this.PreviousNames = previousNames;
            this.PreviousNameDates = previousNameDates;
            this.TradeStyles = tradeStyles;
            this.MajorProduct = majorProduct;
            this.BusinessName = businessName;
            this.AkaName = akaName;
            this.DivisionalNames = divisionalNames;
            this.PreviousNames = previousNames;
            this.PreviousNameDates = previousNameDates;
            this.TradeStyles = tradeStyles;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="businessName", EmitDefaultValue=true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets AkaName
        /// </summary>
        [DataMember(Name="akaName", EmitDefaultValue=true)]
        public string AkaName { get; set; }

        /// <summary>
        /// Gets or Sets DivisionalNames
        /// </summary>
        [DataMember(Name="divisionalNames", EmitDefaultValue=true)]
        public List<string> DivisionalNames { get; set; }

        /// <summary>
        /// Gets or Sets PreviousNames
        /// </summary>
        [DataMember(Name="previousNames", EmitDefaultValue=true)]
        public List<string> PreviousNames { get; set; }

        /// <summary>
        /// Gets or Sets PreviousNameDates
        /// </summary>
        [DataMember(Name="previousNameDates", EmitDefaultValue=true)]
        public List<string> PreviousNameDates { get; set; }

        /// <summary>
        /// Gets or Sets TradeStyles
        /// </summary>
        [DataMember(Name="tradeStyles", EmitDefaultValue=true)]
        public List<string> TradeStyles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialNames {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  AkaName: ").Append(AkaName).Append("\n");
            sb.Append("  DivisionalNames: ").Append(DivisionalNames).Append("\n");
            sb.Append("  PreviousNames: ").Append(PreviousNames).Append("\n");
            sb.Append("  PreviousNameDates: ").Append(PreviousNameDates).Append("\n");
            sb.Append("  TradeStyles: ").Append(TradeStyles).Append("\n");
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
            return this.Equals(input as TransunionCommercialNames);
        }

        /// <summary>
        /// Returns true if TransunionCommercialNames instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialNames to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialNames input)
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
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.AkaName == input.AkaName ||
                    (this.AkaName != null &&
                    this.AkaName.Equals(input.AkaName))
                ) && 
                (
                    this.DivisionalNames == input.DivisionalNames ||
                    this.DivisionalNames != null &&
                    input.DivisionalNames != null &&
                    this.DivisionalNames.SequenceEqual(input.DivisionalNames)
                ) && 
                (
                    this.PreviousNames == input.PreviousNames ||
                    this.PreviousNames != null &&
                    input.PreviousNames != null &&
                    this.PreviousNames.SequenceEqual(input.PreviousNames)
                ) && 
                (
                    this.PreviousNameDates == input.PreviousNameDates ||
                    this.PreviousNameDates != null &&
                    input.PreviousNameDates != null &&
                    this.PreviousNameDates.SequenceEqual(input.PreviousNameDates)
                ) && 
                (
                    this.TradeStyles == input.TradeStyles ||
                    this.TradeStyles != null &&
                    input.TradeStyles != null &&
                    this.TradeStyles.SequenceEqual(input.TradeStyles)
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
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.AkaName != null)
                    hashCode = hashCode * 59 + this.AkaName.GetHashCode();
                if (this.DivisionalNames != null)
                    hashCode = hashCode * 59 + this.DivisionalNames.GetHashCode();
                if (this.PreviousNames != null)
                    hashCode = hashCode * 59 + this.PreviousNames.GetHashCode();
                if (this.PreviousNameDates != null)
                    hashCode = hashCode * 59 + this.PreviousNameDates.GetHashCode();
                if (this.TradeStyles != null)
                    hashCode = hashCode * 59 + this.TradeStyles.GetHashCode();
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
