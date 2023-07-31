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
    /// XdsRealTimeMaritalCheck
    /// </summary>
    [DataContract]
    public partial class XdsRealTimeMaritalCheck :  IEquatable<XdsRealTimeMaritalCheck>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsRealTimeMaritalCheck" /> class.
        /// </summary>
        /// <param name="haDateOfBirth">haDateOfBirth.</param>
        /// <param name="haErrorDescription">haErrorDescription.</param>
        /// <param name="haidno">haidno.</param>
        /// <param name="haMaritalStatus">haMaritalStatus.</param>
        /// <param name="haMarriageDate">haMarriageDate.</param>
        /// <param name="haNames">haNames.</param>
        /// <param name="haSurname">haSurname.</param>
        /// <param name="idnoMatchStatus">idnoMatchStatus.</param>
        /// <param name="inputIDNO">inputIDNO.</param>
        public XdsRealTimeMaritalCheck(string haDateOfBirth = default(string), string haErrorDescription = default(string), string haidno = default(string), string haMaritalStatus = default(string), string haMarriageDate = default(string), string haNames = default(string), string haSurname = default(string), string idnoMatchStatus = default(string), string inputIDNO = default(string))
        {
            this.HaDateOfBirth = haDateOfBirth;
            this.HaErrorDescription = haErrorDescription;
            this.Haidno = haidno;
            this.HaMaritalStatus = haMaritalStatus;
            this.HaMarriageDate = haMarriageDate;
            this.HaNames = haNames;
            this.HaSurname = haSurname;
            this.IdnoMatchStatus = idnoMatchStatus;
            this.InputIDNO = inputIDNO;
            this.HaDateOfBirth = haDateOfBirth;
            this.HaErrorDescription = haErrorDescription;
            this.Haidno = haidno;
            this.HaMaritalStatus = haMaritalStatus;
            this.HaMarriageDate = haMarriageDate;
            this.HaNames = haNames;
            this.HaSurname = haSurname;
            this.IdnoMatchStatus = idnoMatchStatus;
            this.InputIDNO = inputIDNO;
        }

        /// <summary>
        /// Gets or Sets HaDateOfBirth
        /// </summary>
        [DataMember(Name="haDateOfBirth", EmitDefaultValue=true)]
        public string HaDateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets HaErrorDescription
        /// </summary>
        [DataMember(Name="haErrorDescription", EmitDefaultValue=true)]
        public string HaErrorDescription { get; set; }

        /// <summary>
        /// Gets or Sets Haidno
        /// </summary>
        [DataMember(Name="haidno", EmitDefaultValue=true)]
        public string Haidno { get; set; }

        /// <summary>
        /// Gets or Sets HaMaritalStatus
        /// </summary>
        [DataMember(Name="haMaritalStatus", EmitDefaultValue=true)]
        public string HaMaritalStatus { get; set; }

        /// <summary>
        /// Gets or Sets HaMarriageDate
        /// </summary>
        [DataMember(Name="haMarriageDate", EmitDefaultValue=true)]
        public string HaMarriageDate { get; set; }

        /// <summary>
        /// Gets or Sets HaNames
        /// </summary>
        [DataMember(Name="haNames", EmitDefaultValue=true)]
        public string HaNames { get; set; }

        /// <summary>
        /// Gets or Sets HaSurname
        /// </summary>
        [DataMember(Name="haSurname", EmitDefaultValue=true)]
        public string HaSurname { get; set; }

        /// <summary>
        /// Gets or Sets IdnoMatchStatus
        /// </summary>
        [DataMember(Name="idnoMatchStatus", EmitDefaultValue=true)]
        public string IdnoMatchStatus { get; set; }

        /// <summary>
        /// Gets or Sets InputIDNO
        /// </summary>
        [DataMember(Name="inputIDNO", EmitDefaultValue=true)]
        public string InputIDNO { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsRealTimeMaritalCheck {\n");
            sb.Append("  HaDateOfBirth: ").Append(HaDateOfBirth).Append("\n");
            sb.Append("  HaErrorDescription: ").Append(HaErrorDescription).Append("\n");
            sb.Append("  Haidno: ").Append(Haidno).Append("\n");
            sb.Append("  HaMaritalStatus: ").Append(HaMaritalStatus).Append("\n");
            sb.Append("  HaMarriageDate: ").Append(HaMarriageDate).Append("\n");
            sb.Append("  HaNames: ").Append(HaNames).Append("\n");
            sb.Append("  HaSurname: ").Append(HaSurname).Append("\n");
            sb.Append("  IdnoMatchStatus: ").Append(IdnoMatchStatus).Append("\n");
            sb.Append("  InputIDNO: ").Append(InputIDNO).Append("\n");
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
            return this.Equals(input as XdsRealTimeMaritalCheck);
        }

        /// <summary>
        /// Returns true if XdsRealTimeMaritalCheck instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsRealTimeMaritalCheck to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsRealTimeMaritalCheck input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HaDateOfBirth == input.HaDateOfBirth ||
                    (this.HaDateOfBirth != null &&
                    this.HaDateOfBirth.Equals(input.HaDateOfBirth))
                ) && 
                (
                    this.HaErrorDescription == input.HaErrorDescription ||
                    (this.HaErrorDescription != null &&
                    this.HaErrorDescription.Equals(input.HaErrorDescription))
                ) && 
                (
                    this.Haidno == input.Haidno ||
                    (this.Haidno != null &&
                    this.Haidno.Equals(input.Haidno))
                ) && 
                (
                    this.HaMaritalStatus == input.HaMaritalStatus ||
                    (this.HaMaritalStatus != null &&
                    this.HaMaritalStatus.Equals(input.HaMaritalStatus))
                ) && 
                (
                    this.HaMarriageDate == input.HaMarriageDate ||
                    (this.HaMarriageDate != null &&
                    this.HaMarriageDate.Equals(input.HaMarriageDate))
                ) && 
                (
                    this.HaNames == input.HaNames ||
                    (this.HaNames != null &&
                    this.HaNames.Equals(input.HaNames))
                ) && 
                (
                    this.HaSurname == input.HaSurname ||
                    (this.HaSurname != null &&
                    this.HaSurname.Equals(input.HaSurname))
                ) && 
                (
                    this.IdnoMatchStatus == input.IdnoMatchStatus ||
                    (this.IdnoMatchStatus != null &&
                    this.IdnoMatchStatus.Equals(input.IdnoMatchStatus))
                ) && 
                (
                    this.InputIDNO == input.InputIDNO ||
                    (this.InputIDNO != null &&
                    this.InputIDNO.Equals(input.InputIDNO))
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
                if (this.HaDateOfBirth != null)
                    hashCode = hashCode * 59 + this.HaDateOfBirth.GetHashCode();
                if (this.HaErrorDescription != null)
                    hashCode = hashCode * 59 + this.HaErrorDescription.GetHashCode();
                if (this.Haidno != null)
                    hashCode = hashCode * 59 + this.Haidno.GetHashCode();
                if (this.HaMaritalStatus != null)
                    hashCode = hashCode * 59 + this.HaMaritalStatus.GetHashCode();
                if (this.HaMarriageDate != null)
                    hashCode = hashCode * 59 + this.HaMarriageDate.GetHashCode();
                if (this.HaNames != null)
                    hashCode = hashCode * 59 + this.HaNames.GetHashCode();
                if (this.HaSurname != null)
                    hashCode = hashCode * 59 + this.HaSurname.GetHashCode();
                if (this.IdnoMatchStatus != null)
                    hashCode = hashCode * 59 + this.IdnoMatchStatus.GetHashCode();
                if (this.InputIDNO != null)
                    hashCode = hashCode * 59 + this.InputIDNO.GetHashCode();
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
