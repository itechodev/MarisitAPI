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
    /// CompuscanCOMPAUDINFO
    /// </summary>
    [DataContract]
    public partial class CompuscanCOMPAUDINFO :  IEquatable<CompuscanCOMPAUDINFO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompuscanCOMPAUDINFO" /> class.
        /// </summary>
        /// <param name="auditorname">auditorname.</param>
        /// <param name="audtype">audtype.</param>
        /// <param name="bussadrs">bussadrs.</param>
        /// <param name="posadrs">posadrs.</param>
        /// <param name="profession">profession.</param>
        /// <param name="professioncode">professioncode.</param>
        /// <param name="professionnumber">professionnumber.</param>
        /// <param name="status">status.</param>
        /// <param name="statuscode">statuscode.</param>
        /// <param name="typecode">typecode.</param>
        public CompuscanCOMPAUDINFO(string auditorname = default(string), string audtype = default(string), string bussadrs = default(string), string posadrs = default(string), string profession = default(string), string professioncode = default(string), string professionnumber = default(string), string status = default(string), string statuscode = default(string), string typecode = default(string))
        {
            this.Auditorname = auditorname;
            this.Audtype = audtype;
            this.Bussadrs = bussadrs;
            this.Posadrs = posadrs;
            this.Profession = profession;
            this.Professioncode = professioncode;
            this.Professionnumber = professionnumber;
            this.Status = status;
            this.Statuscode = statuscode;
            this.Typecode = typecode;
            this.Auditorname = auditorname;
            this.Audtype = audtype;
            this.Bussadrs = bussadrs;
            this.Posadrs = posadrs;
            this.Profession = profession;
            this.Professioncode = professioncode;
            this.Professionnumber = professionnumber;
            this.Status = status;
            this.Statuscode = statuscode;
            this.Typecode = typecode;
        }

        /// <summary>
        /// Gets or Sets Auditorname
        /// </summary>
        [DataMember(Name="auditorname", EmitDefaultValue=true)]
        public string Auditorname { get; set; }

        /// <summary>
        /// Gets or Sets Audtype
        /// </summary>
        [DataMember(Name="audtype", EmitDefaultValue=true)]
        public string Audtype { get; set; }

        /// <summary>
        /// Gets or Sets Bussadrs
        /// </summary>
        [DataMember(Name="bussadrs", EmitDefaultValue=true)]
        public string Bussadrs { get; set; }

        /// <summary>
        /// Gets or Sets Posadrs
        /// </summary>
        [DataMember(Name="posadrs", EmitDefaultValue=true)]
        public string Posadrs { get; set; }

        /// <summary>
        /// Gets or Sets Profession
        /// </summary>
        [DataMember(Name="profession", EmitDefaultValue=true)]
        public string Profession { get; set; }

        /// <summary>
        /// Gets or Sets Professioncode
        /// </summary>
        [DataMember(Name="professioncode", EmitDefaultValue=true)]
        public string Professioncode { get; set; }

        /// <summary>
        /// Gets or Sets Professionnumber
        /// </summary>
        [DataMember(Name="professionnumber", EmitDefaultValue=true)]
        public string Professionnumber { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Statuscode
        /// </summary>
        [DataMember(Name="statuscode", EmitDefaultValue=true)]
        public string Statuscode { get; set; }

        /// <summary>
        /// Gets or Sets Typecode
        /// </summary>
        [DataMember(Name="typecode", EmitDefaultValue=true)]
        public string Typecode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompuscanCOMPAUDINFO {\n");
            sb.Append("  Auditorname: ").Append(Auditorname).Append("\n");
            sb.Append("  Audtype: ").Append(Audtype).Append("\n");
            sb.Append("  Bussadrs: ").Append(Bussadrs).Append("\n");
            sb.Append("  Posadrs: ").Append(Posadrs).Append("\n");
            sb.Append("  Profession: ").Append(Profession).Append("\n");
            sb.Append("  Professioncode: ").Append(Professioncode).Append("\n");
            sb.Append("  Professionnumber: ").Append(Professionnumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Statuscode: ").Append(Statuscode).Append("\n");
            sb.Append("  Typecode: ").Append(Typecode).Append("\n");
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
            return this.Equals(input as CompuscanCOMPAUDINFO);
        }

        /// <summary>
        /// Returns true if CompuscanCOMPAUDINFO instances are equal
        /// </summary>
        /// <param name="input">Instance of CompuscanCOMPAUDINFO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompuscanCOMPAUDINFO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Auditorname == input.Auditorname ||
                    (this.Auditorname != null &&
                    this.Auditorname.Equals(input.Auditorname))
                ) && 
                (
                    this.Audtype == input.Audtype ||
                    (this.Audtype != null &&
                    this.Audtype.Equals(input.Audtype))
                ) && 
                (
                    this.Bussadrs == input.Bussadrs ||
                    (this.Bussadrs != null &&
                    this.Bussadrs.Equals(input.Bussadrs))
                ) && 
                (
                    this.Posadrs == input.Posadrs ||
                    (this.Posadrs != null &&
                    this.Posadrs.Equals(input.Posadrs))
                ) && 
                (
                    this.Profession == input.Profession ||
                    (this.Profession != null &&
                    this.Profession.Equals(input.Profession))
                ) && 
                (
                    this.Professioncode == input.Professioncode ||
                    (this.Professioncode != null &&
                    this.Professioncode.Equals(input.Professioncode))
                ) && 
                (
                    this.Professionnumber == input.Professionnumber ||
                    (this.Professionnumber != null &&
                    this.Professionnumber.Equals(input.Professionnumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Statuscode == input.Statuscode ||
                    (this.Statuscode != null &&
                    this.Statuscode.Equals(input.Statuscode))
                ) && 
                (
                    this.Typecode == input.Typecode ||
                    (this.Typecode != null &&
                    this.Typecode.Equals(input.Typecode))
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
                if (this.Auditorname != null)
                    hashCode = hashCode * 59 + this.Auditorname.GetHashCode();
                if (this.Audtype != null)
                    hashCode = hashCode * 59 + this.Audtype.GetHashCode();
                if (this.Bussadrs != null)
                    hashCode = hashCode * 59 + this.Bussadrs.GetHashCode();
                if (this.Posadrs != null)
                    hashCode = hashCode * 59 + this.Posadrs.GetHashCode();
                if (this.Profession != null)
                    hashCode = hashCode * 59 + this.Profession.GetHashCode();
                if (this.Professioncode != null)
                    hashCode = hashCode * 59 + this.Professioncode.GetHashCode();
                if (this.Professionnumber != null)
                    hashCode = hashCode * 59 + this.Professionnumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Statuscode != null)
                    hashCode = hashCode * 59 + this.Statuscode.GetHashCode();
                if (this.Typecode != null)
                    hashCode = hashCode * 59 + this.Typecode.GetHashCode();
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
