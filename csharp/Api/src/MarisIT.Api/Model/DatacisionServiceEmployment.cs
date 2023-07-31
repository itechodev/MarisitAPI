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
    /// DatacisionServiceEmployment
    /// </summary>
    [DataContract]
    public partial class DatacisionServiceEmployment :  IEquatable<DatacisionServiceEmployment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatacisionServiceEmployment" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="employer">employer.</param>
        /// <param name="job">job.</param>
        public DatacisionServiceEmployment(DateTime? date = default(DateTime?), string employer = default(string), string job = default(string))
        {
            this.Date = date;
            this.Employer = employer;
            this.Job = job;
            this.Date = date;
            this.Employer = employer;
            this.Job = job;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets Employer
        /// </summary>
        [DataMember(Name="employer", EmitDefaultValue=true)]
        public string Employer { get; set; }

        /// <summary>
        /// Gets or Sets Job
        /// </summary>
        [DataMember(Name="job", EmitDefaultValue=true)]
        public string Job { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatacisionServiceEmployment {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Employer: ").Append(Employer).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
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
            return this.Equals(input as DatacisionServiceEmployment);
        }

        /// <summary>
        /// Returns true if DatacisionServiceEmployment instances are equal
        /// </summary>
        /// <param name="input">Instance of DatacisionServiceEmployment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatacisionServiceEmployment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Employer == input.Employer ||
                    (this.Employer != null &&
                    this.Employer.Equals(input.Employer))
                ) && 
                (
                    this.Job == input.Job ||
                    (this.Job != null &&
                    this.Job.Equals(input.Job))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Employer != null)
                    hashCode = hashCode * 59 + this.Employer.GetHashCode();
                if (this.Job != null)
                    hashCode = hashCode * 59 + this.Job.GetHashCode();
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