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
    /// TransunionCommercialRegisteredPrincipal
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialRegisteredPrincipal :  IEquatable<TransunionCommercialRegisteredPrincipal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialRegisteredPrincipal" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="surname">surname.</param>
        /// <param name="initials">initials.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="memberContribution">memberContribution.</param>
        /// <param name="memberContributionPerc">memberContributionPerc.</param>
        /// <param name="rpDate">rpDate.</param>
        public TransunionCommercialRegisteredPrincipal(string majorProduct = default(string), string surname = default(string), string initials = default(string), string idNumber = default(string), string memberContribution = default(string), string memberContributionPerc = default(string), string rpDate = default(string))
        {
            this.MajorProduct = majorProduct;
            this.Surname = surname;
            this.Initials = initials;
            this.IdNumber = idNumber;
            this.MemberContribution = memberContribution;
            this.MemberContributionPerc = memberContributionPerc;
            this.RpDate = rpDate;
            this.MajorProduct = majorProduct;
            this.Surname = surname;
            this.Initials = initials;
            this.IdNumber = idNumber;
            this.MemberContribution = memberContribution;
            this.MemberContributionPerc = memberContributionPerc;
            this.RpDate = rpDate;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=true)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets MemberContribution
        /// </summary>
        [DataMember(Name="memberContribution", EmitDefaultValue=true)]
        public string MemberContribution { get; set; }

        /// <summary>
        /// Gets or Sets MemberContributionPerc
        /// </summary>
        [DataMember(Name="memberContributionPerc", EmitDefaultValue=true)]
        public string MemberContributionPerc { get; set; }

        /// <summary>
        /// Gets or Sets RpDate
        /// </summary>
        [DataMember(Name="rpDate", EmitDefaultValue=true)]
        public string RpDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialRegisteredPrincipal {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  MemberContribution: ").Append(MemberContribution).Append("\n");
            sb.Append("  MemberContributionPerc: ").Append(MemberContributionPerc).Append("\n");
            sb.Append("  RpDate: ").Append(RpDate).Append("\n");
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
            return this.Equals(input as TransunionCommercialRegisteredPrincipal);
        }

        /// <summary>
        /// Returns true if TransunionCommercialRegisteredPrincipal instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialRegisteredPrincipal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialRegisteredPrincipal input)
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
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                    this.Initials.Equals(input.Initials))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.MemberContribution == input.MemberContribution ||
                    (this.MemberContribution != null &&
                    this.MemberContribution.Equals(input.MemberContribution))
                ) && 
                (
                    this.MemberContributionPerc == input.MemberContributionPerc ||
                    (this.MemberContributionPerc != null &&
                    this.MemberContributionPerc.Equals(input.MemberContributionPerc))
                ) && 
                (
                    this.RpDate == input.RpDate ||
                    (this.RpDate != null &&
                    this.RpDate.Equals(input.RpDate))
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
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.MemberContribution != null)
                    hashCode = hashCode * 59 + this.MemberContribution.GetHashCode();
                if (this.MemberContributionPerc != null)
                    hashCode = hashCode * 59 + this.MemberContributionPerc.GetHashCode();
                if (this.RpDate != null)
                    hashCode = hashCode * 59 + this.RpDate.GetHashCode();
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
