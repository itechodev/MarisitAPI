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
    /// WindeedOfficeProperty
    /// </summary>
    [DataContract]
    public partial class WindeedOfficeProperty :  IEquatable<WindeedOfficeProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedOfficeProperty" /> class.
        /// </summary>
        /// <param name="localAuthority">localAuthority.</param>
        /// <param name="extent">extent.</param>
        /// <param name="extentUnit">extentUnit.</param>
        /// <param name="previousDescription">previousDescription.</param>
        /// <param name="province">province.</param>
        /// <param name="remainingExtent">remainingExtent.</param>
        /// <param name="diagramDeedNumber">diagramDeedNumber.</param>
        /// <param name="registrationDivision">registrationDivision.</param>
        /// <param name="lpiCode">lpiCode.</param>
        /// <param name="bfsNumber">bfsNumber.</param>
        public WindeedOfficeProperty(string localAuthority = default(string), string extent = default(string), string extentUnit = default(string), string previousDescription = default(string), string province = default(string), string remainingExtent = default(string), string diagramDeedNumber = default(string), string registrationDivision = default(string), string lpiCode = default(string), string bfsNumber = default(string))
        {
            this.LocalAuthority = localAuthority;
            this.Extent = extent;
            this.ExtentUnit = extentUnit;
            this.PreviousDescription = previousDescription;
            this.Province = province;
            this.RemainingExtent = remainingExtent;
            this.DiagramDeedNumber = diagramDeedNumber;
            this.RegistrationDivision = registrationDivision;
            this.LpiCode = lpiCode;
            this.BfsNumber = bfsNumber;
            this.LocalAuthority = localAuthority;
            this.Extent = extent;
            this.ExtentUnit = extentUnit;
            this.PreviousDescription = previousDescription;
            this.Province = province;
            this.RemainingExtent = remainingExtent;
            this.DiagramDeedNumber = diagramDeedNumber;
            this.RegistrationDivision = registrationDivision;
            this.LpiCode = lpiCode;
            this.BfsNumber = bfsNumber;
        }

        /// <summary>
        /// Gets or Sets LocalAuthority
        /// </summary>
        [DataMember(Name="localAuthority", EmitDefaultValue=true)]
        public string LocalAuthority { get; set; }

        /// <summary>
        /// Gets or Sets Extent
        /// </summary>
        [DataMember(Name="extent", EmitDefaultValue=true)]
        public string Extent { get; set; }

        /// <summary>
        /// Gets or Sets ExtentUnit
        /// </summary>
        [DataMember(Name="extentUnit", EmitDefaultValue=true)]
        public string ExtentUnit { get; set; }

        /// <summary>
        /// Gets or Sets PreviousDescription
        /// </summary>
        [DataMember(Name="previousDescription", EmitDefaultValue=true)]
        public string PreviousDescription { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets RemainingExtent
        /// </summary>
        [DataMember(Name="remainingExtent", EmitDefaultValue=true)]
        public string RemainingExtent { get; set; }

        /// <summary>
        /// Gets or Sets DiagramDeedNumber
        /// </summary>
        [DataMember(Name="diagramDeedNumber", EmitDefaultValue=true)]
        public string DiagramDeedNumber { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDivision
        /// </summary>
        [DataMember(Name="registrationDivision", EmitDefaultValue=true)]
        public string RegistrationDivision { get; set; }

        /// <summary>
        /// Gets or Sets LpiCode
        /// </summary>
        [DataMember(Name="lpiCode", EmitDefaultValue=true)]
        public string LpiCode { get; set; }

        /// <summary>
        /// Gets or Sets BfsNumber
        /// </summary>
        [DataMember(Name="bfsNumber", EmitDefaultValue=true)]
        public string BfsNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedOfficeProperty {\n");
            sb.Append("  LocalAuthority: ").Append(LocalAuthority).Append("\n");
            sb.Append("  Extent: ").Append(Extent).Append("\n");
            sb.Append("  ExtentUnit: ").Append(ExtentUnit).Append("\n");
            sb.Append("  PreviousDescription: ").Append(PreviousDescription).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  RemainingExtent: ").Append(RemainingExtent).Append("\n");
            sb.Append("  DiagramDeedNumber: ").Append(DiagramDeedNumber).Append("\n");
            sb.Append("  RegistrationDivision: ").Append(RegistrationDivision).Append("\n");
            sb.Append("  LpiCode: ").Append(LpiCode).Append("\n");
            sb.Append("  BfsNumber: ").Append(BfsNumber).Append("\n");
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
            return this.Equals(input as WindeedOfficeProperty);
        }

        /// <summary>
        /// Returns true if WindeedOfficeProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedOfficeProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedOfficeProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocalAuthority == input.LocalAuthority ||
                    (this.LocalAuthority != null &&
                    this.LocalAuthority.Equals(input.LocalAuthority))
                ) && 
                (
                    this.Extent == input.Extent ||
                    (this.Extent != null &&
                    this.Extent.Equals(input.Extent))
                ) && 
                (
                    this.ExtentUnit == input.ExtentUnit ||
                    (this.ExtentUnit != null &&
                    this.ExtentUnit.Equals(input.ExtentUnit))
                ) && 
                (
                    this.PreviousDescription == input.PreviousDescription ||
                    (this.PreviousDescription != null &&
                    this.PreviousDescription.Equals(input.PreviousDescription))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.RemainingExtent == input.RemainingExtent ||
                    (this.RemainingExtent != null &&
                    this.RemainingExtent.Equals(input.RemainingExtent))
                ) && 
                (
                    this.DiagramDeedNumber == input.DiagramDeedNumber ||
                    (this.DiagramDeedNumber != null &&
                    this.DiagramDeedNumber.Equals(input.DiagramDeedNumber))
                ) && 
                (
                    this.RegistrationDivision == input.RegistrationDivision ||
                    (this.RegistrationDivision != null &&
                    this.RegistrationDivision.Equals(input.RegistrationDivision))
                ) && 
                (
                    this.LpiCode == input.LpiCode ||
                    (this.LpiCode != null &&
                    this.LpiCode.Equals(input.LpiCode))
                ) && 
                (
                    this.BfsNumber == input.BfsNumber ||
                    (this.BfsNumber != null &&
                    this.BfsNumber.Equals(input.BfsNumber))
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
                if (this.LocalAuthority != null)
                    hashCode = hashCode * 59 + this.LocalAuthority.GetHashCode();
                if (this.Extent != null)
                    hashCode = hashCode * 59 + this.Extent.GetHashCode();
                if (this.ExtentUnit != null)
                    hashCode = hashCode * 59 + this.ExtentUnit.GetHashCode();
                if (this.PreviousDescription != null)
                    hashCode = hashCode * 59 + this.PreviousDescription.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.RemainingExtent != null)
                    hashCode = hashCode * 59 + this.RemainingExtent.GetHashCode();
                if (this.DiagramDeedNumber != null)
                    hashCode = hashCode * 59 + this.DiagramDeedNumber.GetHashCode();
                if (this.RegistrationDivision != null)
                    hashCode = hashCode * 59 + this.RegistrationDivision.GetHashCode();
                if (this.LpiCode != null)
                    hashCode = hashCode * 59 + this.LpiCode.GetHashCode();
                if (this.BfsNumber != null)
                    hashCode = hashCode * 59 + this.BfsNumber.GetHashCode();
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