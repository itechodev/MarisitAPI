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
    /// XdsEasyTraceRequest
    /// </summary>
    [DataContract]
    public partial class XdsEasyTraceRequest :  IEquatable<XdsEasyTraceRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SearchType
        /// </summary>
        [DataMember(Name="searchType", EmitDefaultValue=false)]
        public XdsEasySearchType? SearchType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsEasyTraceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XdsEasyTraceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsEasyTraceRequest" /> class.
        /// </summary>
        /// <param name="searchType">searchType.</param>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="surname">surname (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="deviation">deviation.</param>
        /// <param name="reference">reference.</param>
        public XdsEasyTraceRequest(XdsEasySearchType? searchType = default(XdsEasySearchType?), string firstName = default(string), string surname = default(string), int year = default(int), int? deviation = default(int?), string reference = default(string))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for XdsEasyTraceRequest and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }

            // to ensure "surname" is required (not null)
            if (surname == null)
            {
                throw new InvalidDataException("surname is a required property for XdsEasyTraceRequest and cannot be null");
            }
            else
            {
                this.Surname = surname;
            }

            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for XdsEasyTraceRequest and cannot be null");
            }
            else
            {
                this.Year = year;
            }

            this.Deviation = deviation;
            this.Reference = reference;
            this.SearchType = searchType;
            this.Deviation = deviation;
            this.Reference = reference;
        }


        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public int Year { get; set; }

        /// <summary>
        /// Gets or Sets Deviation
        /// </summary>
        [DataMember(Name="deviation", EmitDefaultValue=true)]
        public int? Deviation { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsEasyTraceRequest {\n");
            sb.Append("  SearchType: ").Append(SearchType).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Deviation: ").Append(Deviation).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as XdsEasyTraceRequest);
        }

        /// <summary>
        /// Returns true if XdsEasyTraceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsEasyTraceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsEasyTraceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchType == input.SearchType ||
                    (this.SearchType != null &&
                    this.SearchType.Equals(input.SearchType))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Deviation == input.Deviation ||
                    (this.Deviation != null &&
                    this.Deviation.Equals(input.Deviation))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.SearchType != null)
                    hashCode = hashCode * 59 + this.SearchType.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Deviation != null)
                    hashCode = hashCode * 59 + this.Deviation.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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