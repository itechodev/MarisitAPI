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
    /// CompuscanCOMPSRCHCRIT
    /// </summary>
    [DataContract]
    public partial class CompuscanCOMPSRCHCRIT :  IEquatable<CompuscanCOMPSRCHCRIT>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompuscanCOMPSRCHCRIT" /> class.
        /// </summary>
        /// <param name="companyname">companyname.</param>
        /// <param name="companyregnumber">companyregnumber.</param>
        /// <param name="createdby">createdby.</param>
        /// <param name="enqdate">enqdate.</param>
        /// <param name="enqshrtdate">enqshrtdate.</param>
        /// <param name="oldregistrationnumber">oldregistrationnumber.</param>
        public CompuscanCOMPSRCHCRIT(string companyname = default(string), string companyregnumber = default(string), string createdby = default(string), string enqdate = default(string), string enqshrtdate = default(string), string oldregistrationnumber = default(string))
        {
            this.Companyname = companyname;
            this.Companyregnumber = companyregnumber;
            this.Createdby = createdby;
            this.Enqdate = enqdate;
            this.Enqshrtdate = enqshrtdate;
            this.Oldregistrationnumber = oldregistrationnumber;
            this.Companyname = companyname;
            this.Companyregnumber = companyregnumber;
            this.Createdby = createdby;
            this.Enqdate = enqdate;
            this.Enqshrtdate = enqshrtdate;
            this.Oldregistrationnumber = oldregistrationnumber;
        }

        /// <summary>
        /// Gets or Sets Companyname
        /// </summary>
        [DataMember(Name="companyname", EmitDefaultValue=true)]
        public string Companyname { get; set; }

        /// <summary>
        /// Gets or Sets Companyregnumber
        /// </summary>
        [DataMember(Name="companyregnumber", EmitDefaultValue=true)]
        public string Companyregnumber { get; set; }

        /// <summary>
        /// Gets or Sets Createdby
        /// </summary>
        [DataMember(Name="createdby", EmitDefaultValue=true)]
        public string Createdby { get; set; }

        /// <summary>
        /// Gets or Sets Enqdate
        /// </summary>
        [DataMember(Name="enqdate", EmitDefaultValue=true)]
        public string Enqdate { get; set; }

        /// <summary>
        /// Gets or Sets Enqshrtdate
        /// </summary>
        [DataMember(Name="enqshrtdate", EmitDefaultValue=true)]
        public string Enqshrtdate { get; set; }

        /// <summary>
        /// Gets or Sets Oldregistrationnumber
        /// </summary>
        [DataMember(Name="oldregistrationnumber", EmitDefaultValue=true)]
        public string Oldregistrationnumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompuscanCOMPSRCHCRIT {\n");
            sb.Append("  Companyname: ").Append(Companyname).Append("\n");
            sb.Append("  Companyregnumber: ").Append(Companyregnumber).Append("\n");
            sb.Append("  Createdby: ").Append(Createdby).Append("\n");
            sb.Append("  Enqdate: ").Append(Enqdate).Append("\n");
            sb.Append("  Enqshrtdate: ").Append(Enqshrtdate).Append("\n");
            sb.Append("  Oldregistrationnumber: ").Append(Oldregistrationnumber).Append("\n");
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
            return this.Equals(input as CompuscanCOMPSRCHCRIT);
        }

        /// <summary>
        /// Returns true if CompuscanCOMPSRCHCRIT instances are equal
        /// </summary>
        /// <param name="input">Instance of CompuscanCOMPSRCHCRIT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompuscanCOMPSRCHCRIT input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Companyname == input.Companyname ||
                    (this.Companyname != null &&
                    this.Companyname.Equals(input.Companyname))
                ) && 
                (
                    this.Companyregnumber == input.Companyregnumber ||
                    (this.Companyregnumber != null &&
                    this.Companyregnumber.Equals(input.Companyregnumber))
                ) && 
                (
                    this.Createdby == input.Createdby ||
                    (this.Createdby != null &&
                    this.Createdby.Equals(input.Createdby))
                ) && 
                (
                    this.Enqdate == input.Enqdate ||
                    (this.Enqdate != null &&
                    this.Enqdate.Equals(input.Enqdate))
                ) && 
                (
                    this.Enqshrtdate == input.Enqshrtdate ||
                    (this.Enqshrtdate != null &&
                    this.Enqshrtdate.Equals(input.Enqshrtdate))
                ) && 
                (
                    this.Oldregistrationnumber == input.Oldregistrationnumber ||
                    (this.Oldregistrationnumber != null &&
                    this.Oldregistrationnumber.Equals(input.Oldregistrationnumber))
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
                if (this.Companyname != null)
                    hashCode = hashCode * 59 + this.Companyname.GetHashCode();
                if (this.Companyregnumber != null)
                    hashCode = hashCode * 59 + this.Companyregnumber.GetHashCode();
                if (this.Createdby != null)
                    hashCode = hashCode * 59 + this.Createdby.GetHashCode();
                if (this.Enqdate != null)
                    hashCode = hashCode * 59 + this.Enqdate.GetHashCode();
                if (this.Enqshrtdate != null)
                    hashCode = hashCode * 59 + this.Enqshrtdate.GetHashCode();
                if (this.Oldregistrationnumber != null)
                    hashCode = hashCode * 59 + this.Oldregistrationnumber.GetHashCode();
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
