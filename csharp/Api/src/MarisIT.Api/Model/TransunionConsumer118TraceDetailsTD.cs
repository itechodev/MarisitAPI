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
    /// TransunionConsumer118TraceDetailsTD
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TraceDetailsTD :  IEquatable<TransunionConsumer118TraceDetailsTD>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TraceDetailsTD" /> class.
        /// </summary>
        /// <param name="oConsumerNumber">oConsumerNumber.</param>
        /// <param name="oIdentityNumber">oIdentityNumber.</param>
        /// <param name="oForename">oForename.</param>
        /// <param name="oSurname">oSurname.</param>
        /// <param name="oTelephoneAreaCode">oTelephoneAreaCode.</param>
        /// <param name="oTelephoneNumber">oTelephoneNumber.</param>
        /// <param name="oCellphoneNumber">oCellphoneNumber.</param>
        /// <param name="oDateOfBirth">oDateOfBirth.</param>
        /// <param name="oGender">oGender.</param>
        /// <param name="oEmailAddress">oEmailAddress.</param>
        /// <param name="oEmployer">oEmployer.</param>
        /// <param name="oAddress">oAddress.</param>
        /// <param name="oExactMatch">oExactMatch.</param>
        public TransunionConsumer118TraceDetailsTD(string oConsumerNumber = default(string), string oIdentityNumber = default(string), string oForename = default(string), string oSurname = default(string), string oTelephoneAreaCode = default(string), string oTelephoneNumber = default(string), string oCellphoneNumber = default(string), string oDateOfBirth = default(string), string oGender = default(string), string oEmailAddress = default(string), string oEmployer = default(string), string oAddress = default(string), string oExactMatch = default(string))
        {
            this.OConsumerNumber = oConsumerNumber;
            this.OIdentityNumber = oIdentityNumber;
            this.OForename = oForename;
            this.OSurname = oSurname;
            this.OTelephoneAreaCode = oTelephoneAreaCode;
            this.OTelephoneNumber = oTelephoneNumber;
            this.OCellphoneNumber = oCellphoneNumber;
            this.ODateOfBirth = oDateOfBirth;
            this.OGender = oGender;
            this.OEmailAddress = oEmailAddress;
            this.OEmployer = oEmployer;
            this.OAddress = oAddress;
            this.OExactMatch = oExactMatch;
            this.OConsumerNumber = oConsumerNumber;
            this.OIdentityNumber = oIdentityNumber;
            this.OForename = oForename;
            this.OSurname = oSurname;
            this.OTelephoneAreaCode = oTelephoneAreaCode;
            this.OTelephoneNumber = oTelephoneNumber;
            this.OCellphoneNumber = oCellphoneNumber;
            this.ODateOfBirth = oDateOfBirth;
            this.OGender = oGender;
            this.OEmailAddress = oEmailAddress;
            this.OEmployer = oEmployer;
            this.OAddress = oAddress;
            this.OExactMatch = oExactMatch;
        }

        /// <summary>
        /// Gets or Sets OConsumerNumber
        /// </summary>
        [DataMember(Name="oConsumerNumber", EmitDefaultValue=true)]
        public string OConsumerNumber { get; set; }

        /// <summary>
        /// Gets or Sets OIdentityNumber
        /// </summary>
        [DataMember(Name="oIdentityNumber", EmitDefaultValue=true)]
        public string OIdentityNumber { get; set; }

        /// <summary>
        /// Gets or Sets OForename
        /// </summary>
        [DataMember(Name="oForename", EmitDefaultValue=true)]
        public string OForename { get; set; }

        /// <summary>
        /// Gets or Sets OSurname
        /// </summary>
        [DataMember(Name="oSurname", EmitDefaultValue=true)]
        public string OSurname { get; set; }

        /// <summary>
        /// Gets or Sets OTelephoneAreaCode
        /// </summary>
        [DataMember(Name="oTelephoneAreaCode", EmitDefaultValue=true)]
        public string OTelephoneAreaCode { get; set; }

        /// <summary>
        /// Gets or Sets OTelephoneNumber
        /// </summary>
        [DataMember(Name="oTelephoneNumber", EmitDefaultValue=true)]
        public string OTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets OCellphoneNumber
        /// </summary>
        [DataMember(Name="oCellphoneNumber", EmitDefaultValue=true)]
        public string OCellphoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ODateOfBirth
        /// </summary>
        [DataMember(Name="oDateOfBirth", EmitDefaultValue=true)]
        public string ODateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets OGender
        /// </summary>
        [DataMember(Name="oGender", EmitDefaultValue=true)]
        public string OGender { get; set; }

        /// <summary>
        /// Gets or Sets OEmailAddress
        /// </summary>
        [DataMember(Name="oEmailAddress", EmitDefaultValue=true)]
        public string OEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets OEmployer
        /// </summary>
        [DataMember(Name="oEmployer", EmitDefaultValue=true)]
        public string OEmployer { get; set; }

        /// <summary>
        /// Gets or Sets OAddress
        /// </summary>
        [DataMember(Name="oAddress", EmitDefaultValue=true)]
        public string OAddress { get; set; }

        /// <summary>
        /// Gets or Sets OExactMatch
        /// </summary>
        [DataMember(Name="oExactMatch", EmitDefaultValue=true)]
        public string OExactMatch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TraceDetailsTD {\n");
            sb.Append("  OConsumerNumber: ").Append(OConsumerNumber).Append("\n");
            sb.Append("  OIdentityNumber: ").Append(OIdentityNumber).Append("\n");
            sb.Append("  OForename: ").Append(OForename).Append("\n");
            sb.Append("  OSurname: ").Append(OSurname).Append("\n");
            sb.Append("  OTelephoneAreaCode: ").Append(OTelephoneAreaCode).Append("\n");
            sb.Append("  OTelephoneNumber: ").Append(OTelephoneNumber).Append("\n");
            sb.Append("  OCellphoneNumber: ").Append(OCellphoneNumber).Append("\n");
            sb.Append("  ODateOfBirth: ").Append(ODateOfBirth).Append("\n");
            sb.Append("  OGender: ").Append(OGender).Append("\n");
            sb.Append("  OEmailAddress: ").Append(OEmailAddress).Append("\n");
            sb.Append("  OEmployer: ").Append(OEmployer).Append("\n");
            sb.Append("  OAddress: ").Append(OAddress).Append("\n");
            sb.Append("  OExactMatch: ").Append(OExactMatch).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TraceDetailsTD);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TraceDetailsTD instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TraceDetailsTD to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TraceDetailsTD input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OConsumerNumber == input.OConsumerNumber ||
                    (this.OConsumerNumber != null &&
                    this.OConsumerNumber.Equals(input.OConsumerNumber))
                ) && 
                (
                    this.OIdentityNumber == input.OIdentityNumber ||
                    (this.OIdentityNumber != null &&
                    this.OIdentityNumber.Equals(input.OIdentityNumber))
                ) && 
                (
                    this.OForename == input.OForename ||
                    (this.OForename != null &&
                    this.OForename.Equals(input.OForename))
                ) && 
                (
                    this.OSurname == input.OSurname ||
                    (this.OSurname != null &&
                    this.OSurname.Equals(input.OSurname))
                ) && 
                (
                    this.OTelephoneAreaCode == input.OTelephoneAreaCode ||
                    (this.OTelephoneAreaCode != null &&
                    this.OTelephoneAreaCode.Equals(input.OTelephoneAreaCode))
                ) && 
                (
                    this.OTelephoneNumber == input.OTelephoneNumber ||
                    (this.OTelephoneNumber != null &&
                    this.OTelephoneNumber.Equals(input.OTelephoneNumber))
                ) && 
                (
                    this.OCellphoneNumber == input.OCellphoneNumber ||
                    (this.OCellphoneNumber != null &&
                    this.OCellphoneNumber.Equals(input.OCellphoneNumber))
                ) && 
                (
                    this.ODateOfBirth == input.ODateOfBirth ||
                    (this.ODateOfBirth != null &&
                    this.ODateOfBirth.Equals(input.ODateOfBirth))
                ) && 
                (
                    this.OGender == input.OGender ||
                    (this.OGender != null &&
                    this.OGender.Equals(input.OGender))
                ) && 
                (
                    this.OEmailAddress == input.OEmailAddress ||
                    (this.OEmailAddress != null &&
                    this.OEmailAddress.Equals(input.OEmailAddress))
                ) && 
                (
                    this.OEmployer == input.OEmployer ||
                    (this.OEmployer != null &&
                    this.OEmployer.Equals(input.OEmployer))
                ) && 
                (
                    this.OAddress == input.OAddress ||
                    (this.OAddress != null &&
                    this.OAddress.Equals(input.OAddress))
                ) && 
                (
                    this.OExactMatch == input.OExactMatch ||
                    (this.OExactMatch != null &&
                    this.OExactMatch.Equals(input.OExactMatch))
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
                if (this.OConsumerNumber != null)
                    hashCode = hashCode * 59 + this.OConsumerNumber.GetHashCode();
                if (this.OIdentityNumber != null)
                    hashCode = hashCode * 59 + this.OIdentityNumber.GetHashCode();
                if (this.OForename != null)
                    hashCode = hashCode * 59 + this.OForename.GetHashCode();
                if (this.OSurname != null)
                    hashCode = hashCode * 59 + this.OSurname.GetHashCode();
                if (this.OTelephoneAreaCode != null)
                    hashCode = hashCode * 59 + this.OTelephoneAreaCode.GetHashCode();
                if (this.OTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.OTelephoneNumber.GetHashCode();
                if (this.OCellphoneNumber != null)
                    hashCode = hashCode * 59 + this.OCellphoneNumber.GetHashCode();
                if (this.ODateOfBirth != null)
                    hashCode = hashCode * 59 + this.ODateOfBirth.GetHashCode();
                if (this.OGender != null)
                    hashCode = hashCode * 59 + this.OGender.GetHashCode();
                if (this.OEmailAddress != null)
                    hashCode = hashCode * 59 + this.OEmailAddress.GetHashCode();
                if (this.OEmployer != null)
                    hashCode = hashCode * 59 + this.OEmployer.GetHashCode();
                if (this.OAddress != null)
                    hashCode = hashCode * 59 + this.OAddress.GetHashCode();
                if (this.OExactMatch != null)
                    hashCode = hashCode * 59 + this.OExactMatch.GetHashCode();
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
