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
    /// CompuscanCOMPTRADEHISTORYBRANDS
    /// </summary>
    [DataContract]
    public partial class CompuscanCOMPTRADEHISTORYBRANDS :  IEquatable<CompuscanCOMPTRADEHISTORYBRANDS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompuscanCOMPTRADEHISTORYBRANDS" /> class.
        /// </summary>
        /// <param name="createddttm">createddttm.</param>
        /// <param name="createdby">createdby.</param>
        /// <param name="companyname">companyname.</param>
        /// <param name="companyreg">companyreg.</param>
        /// <param name="tradestartdate">tradestartdate.</param>
        /// <param name="modifieddttm">modifieddttm.</param>
        /// <param name="modifiedby">modifiedby.</param>
        public CompuscanCOMPTRADEHISTORYBRANDS(string createddttm = default(string), string createdby = default(string), string companyname = default(string), string companyreg = default(string), string tradestartdate = default(string), string modifieddttm = default(string), string modifiedby = default(string))
        {
            this.Createddttm = createddttm;
            this.Createdby = createdby;
            this.Companyname = companyname;
            this.Companyreg = companyreg;
            this.Tradestartdate = tradestartdate;
            this.Modifieddttm = modifieddttm;
            this.Modifiedby = modifiedby;
            this.Createddttm = createddttm;
            this.Createdby = createdby;
            this.Companyname = companyname;
            this.Companyreg = companyreg;
            this.Tradestartdate = tradestartdate;
            this.Modifieddttm = modifieddttm;
            this.Modifiedby = modifiedby;
        }

        /// <summary>
        /// Gets or Sets Createddttm
        /// </summary>
        [DataMember(Name="createddttm", EmitDefaultValue=true)]
        public string Createddttm { get; set; }

        /// <summary>
        /// Gets or Sets Createdby
        /// </summary>
        [DataMember(Name="createdby", EmitDefaultValue=true)]
        public string Createdby { get; set; }

        /// <summary>
        /// Gets or Sets Companyname
        /// </summary>
        [DataMember(Name="companyname", EmitDefaultValue=true)]
        public string Companyname { get; set; }

        /// <summary>
        /// Gets or Sets Companyreg
        /// </summary>
        [DataMember(Name="companyreg", EmitDefaultValue=true)]
        public string Companyreg { get; set; }

        /// <summary>
        /// Gets or Sets Tradestartdate
        /// </summary>
        [DataMember(Name="tradestartdate", EmitDefaultValue=true)]
        public string Tradestartdate { get; set; }

        /// <summary>
        /// Gets or Sets Modifieddttm
        /// </summary>
        [DataMember(Name="modifieddttm", EmitDefaultValue=true)]
        public string Modifieddttm { get; set; }

        /// <summary>
        /// Gets or Sets Modifiedby
        /// </summary>
        [DataMember(Name="modifiedby", EmitDefaultValue=true)]
        public string Modifiedby { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompuscanCOMPTRADEHISTORYBRANDS {\n");
            sb.Append("  Createddttm: ").Append(Createddttm).Append("\n");
            sb.Append("  Createdby: ").Append(Createdby).Append("\n");
            sb.Append("  Companyname: ").Append(Companyname).Append("\n");
            sb.Append("  Companyreg: ").Append(Companyreg).Append("\n");
            sb.Append("  Tradestartdate: ").Append(Tradestartdate).Append("\n");
            sb.Append("  Modifieddttm: ").Append(Modifieddttm).Append("\n");
            sb.Append("  Modifiedby: ").Append(Modifiedby).Append("\n");
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
            return this.Equals(input as CompuscanCOMPTRADEHISTORYBRANDS);
        }

        /// <summary>
        /// Returns true if CompuscanCOMPTRADEHISTORYBRANDS instances are equal
        /// </summary>
        /// <param name="input">Instance of CompuscanCOMPTRADEHISTORYBRANDS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompuscanCOMPTRADEHISTORYBRANDS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Createddttm == input.Createddttm ||
                    (this.Createddttm != null &&
                    this.Createddttm.Equals(input.Createddttm))
                ) && 
                (
                    this.Createdby == input.Createdby ||
                    (this.Createdby != null &&
                    this.Createdby.Equals(input.Createdby))
                ) && 
                (
                    this.Companyname == input.Companyname ||
                    (this.Companyname != null &&
                    this.Companyname.Equals(input.Companyname))
                ) && 
                (
                    this.Companyreg == input.Companyreg ||
                    (this.Companyreg != null &&
                    this.Companyreg.Equals(input.Companyreg))
                ) && 
                (
                    this.Tradestartdate == input.Tradestartdate ||
                    (this.Tradestartdate != null &&
                    this.Tradestartdate.Equals(input.Tradestartdate))
                ) && 
                (
                    this.Modifieddttm == input.Modifieddttm ||
                    (this.Modifieddttm != null &&
                    this.Modifieddttm.Equals(input.Modifieddttm))
                ) && 
                (
                    this.Modifiedby == input.Modifiedby ||
                    (this.Modifiedby != null &&
                    this.Modifiedby.Equals(input.Modifiedby))
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
                if (this.Createddttm != null)
                    hashCode = hashCode * 59 + this.Createddttm.GetHashCode();
                if (this.Createdby != null)
                    hashCode = hashCode * 59 + this.Createdby.GetHashCode();
                if (this.Companyname != null)
                    hashCode = hashCode * 59 + this.Companyname.GetHashCode();
                if (this.Companyreg != null)
                    hashCode = hashCode * 59 + this.Companyreg.GetHashCode();
                if (this.Tradestartdate != null)
                    hashCode = hashCode * 59 + this.Tradestartdate.GetHashCode();
                if (this.Modifieddttm != null)
                    hashCode = hashCode * 59 + this.Modifieddttm.GetHashCode();
                if (this.Modifiedby != null)
                    hashCode = hashCode * 59 + this.Modifiedby.GetHashCode();
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
