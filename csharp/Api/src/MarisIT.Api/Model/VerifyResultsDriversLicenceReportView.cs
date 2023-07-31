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
    /// VerifyResultsDriversLicenceReportView
    /// </summary>
    [DataContract]
    public partial class VerifyResultsDriversLicenceReportView :  IEquatable<VerifyResultsDriversLicenceReportView>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        public WebDatabaseTablesDriversResult? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyResultsDriversLicenceReportView" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        /// <param name="name">name.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="result">result.</param>
        /// <param name="code">code.</param>
        /// <param name="prDP">prDP.</param>
        /// <param name="prDPDate">prDPDate.</param>
        /// <param name="issued">issued.</param>
        /// <param name="expire">expire.</param>
        /// <param name="note">note.</param>
        public VerifyResultsDriversLicenceReportView(string reference = default(string), string name = default(string), string idNumber = default(string), WebDatabaseTablesDriversResult? result = default(WebDatabaseTablesDriversResult?), string code = default(string), bool prDP = default(bool), string prDPDate = default(string), string issued = default(string), string expire = default(string), string note = default(string))
        {
            this.Reference = reference;
            this.Name = name;
            this.IdNumber = idNumber;
            this.Code = code;
            this.PrDPDate = prDPDate;
            this.Issued = issued;
            this.Expire = expire;
            this.Note = note;
            this.Reference = reference;
            this.Name = name;
            this.IdNumber = idNumber;
            this.Result = result;
            this.Code = code;
            this.PrDP = prDP;
            this.PrDPDate = prDPDate;
            this.Issued = issued;
            this.Expire = expire;
            this.Note = note;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }


        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets PrDP
        /// </summary>
        [DataMember(Name="prDP", EmitDefaultValue=false)]
        public bool PrDP { get; set; }

        /// <summary>
        /// Gets or Sets PrDPDate
        /// </summary>
        [DataMember(Name="prDPDate", EmitDefaultValue=true)]
        public string PrDPDate { get; set; }

        /// <summary>
        /// Gets or Sets Issued
        /// </summary>
        [DataMember(Name="issued", EmitDefaultValue=true)]
        public string Issued { get; set; }

        /// <summary>
        /// Gets or Sets Expire
        /// </summary>
        [DataMember(Name="expire", EmitDefaultValue=true)]
        public string Expire { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyResultsDriversLicenceReportView {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  PrDP: ").Append(PrDP).Append("\n");
            sb.Append("  PrDPDate: ").Append(PrDPDate).Append("\n");
            sb.Append("  Issued: ").Append(Issued).Append("\n");
            sb.Append("  Expire: ").Append(Expire).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as VerifyResultsDriversLicenceReportView);
        }

        /// <summary>
        /// Returns true if VerifyResultsDriversLicenceReportView instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyResultsDriversLicenceReportView to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyResultsDriversLicenceReportView input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.PrDP == input.PrDP ||
                    (this.PrDP != null &&
                    this.PrDP.Equals(input.PrDP))
                ) && 
                (
                    this.PrDPDate == input.PrDPDate ||
                    (this.PrDPDate != null &&
                    this.PrDPDate.Equals(input.PrDPDate))
                ) && 
                (
                    this.Issued == input.Issued ||
                    (this.Issued != null &&
                    this.Issued.Equals(input.Issued))
                ) && 
                (
                    this.Expire == input.Expire ||
                    (this.Expire != null &&
                    this.Expire.Equals(input.Expire))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.PrDP != null)
                    hashCode = hashCode * 59 + this.PrDP.GetHashCode();
                if (this.PrDPDate != null)
                    hashCode = hashCode * 59 + this.PrDPDate.GetHashCode();
                if (this.Issued != null)
                    hashCode = hashCode * 59 + this.Issued.GetHashCode();
                if (this.Expire != null)
                    hashCode = hashCode * 59 + this.Expire.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
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