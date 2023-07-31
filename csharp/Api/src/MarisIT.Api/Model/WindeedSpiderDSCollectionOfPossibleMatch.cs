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
    /// WindeedSpiderDSCollectionOfPossibleMatch
    /// </summary>
    [DataContract]
    public partial class WindeedSpiderDSCollectionOfPossibleMatch :  IEquatable<WindeedSpiderDSCollectionOfPossibleMatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedSpiderDSCollectionOfPossibleMatch" /> class.
        /// </summary>
        /// <param name="tooManyResults">tooManyResults.</param>
        /// <param name="items">items.</param>
        public WindeedSpiderDSCollectionOfPossibleMatch(bool tooManyResults = default(bool), List<WindeedSpiderPossibleMatch> items = default(List<WindeedSpiderPossibleMatch>))
        {
            this.Items = items;
            this.TooManyResults = tooManyResults;
            this.Items = items;
        }

        /// <summary>
        /// Gets or Sets TooManyResults
        /// </summary>
        [DataMember(Name="tooManyResults", EmitDefaultValue=false)]
        public bool TooManyResults { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=true)]
        public List<WindeedSpiderPossibleMatch> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedSpiderDSCollectionOfPossibleMatch {\n");
            sb.Append("  TooManyResults: ").Append(TooManyResults).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as WindeedSpiderDSCollectionOfPossibleMatch);
        }

        /// <summary>
        /// Returns true if WindeedSpiderDSCollectionOfPossibleMatch instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedSpiderDSCollectionOfPossibleMatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedSpiderDSCollectionOfPossibleMatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TooManyResults == input.TooManyResults ||
                    (this.TooManyResults != null &&
                    this.TooManyResults.Equals(input.TooManyResults))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.TooManyResults != null)
                    hashCode = hashCode * 59 + this.TooManyResults.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
