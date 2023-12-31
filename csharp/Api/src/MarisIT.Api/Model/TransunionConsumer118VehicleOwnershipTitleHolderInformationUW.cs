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
    /// TransunionConsumer118VehicleOwnershipTitleHolderInformationUW
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118VehicleOwnershipTitleHolderInformationUW :  IEquatable<TransunionConsumer118VehicleOwnershipTitleHolderInformationUW>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118VehicleOwnershipTitleHolderInformationUW" /> class.
        /// </summary>
        /// <param name="naTISVehicleOwnerVerificationIndicator">naTISVehicleOwnerVerificationIndicator.</param>
        /// <param name="nameOfCurrentOwner">nameOfCurrentOwner.</param>
        /// <param name="vehicleTitleHolderVerificationIndicator">vehicleTitleHolderVerificationIndicator.</param>
        /// <param name="nameOfCurrentTitleHolder">nameOfCurrentTitleHolder.</param>
        public TransunionConsumer118VehicleOwnershipTitleHolderInformationUW(string naTISVehicleOwnerVerificationIndicator = default(string), string nameOfCurrentOwner = default(string), string vehicleTitleHolderVerificationIndicator = default(string), string nameOfCurrentTitleHolder = default(string))
        {
            this.NaTISVehicleOwnerVerificationIndicator = naTISVehicleOwnerVerificationIndicator;
            this.NameOfCurrentOwner = nameOfCurrentOwner;
            this.VehicleTitleHolderVerificationIndicator = vehicleTitleHolderVerificationIndicator;
            this.NameOfCurrentTitleHolder = nameOfCurrentTitleHolder;
            this.NaTISVehicleOwnerVerificationIndicator = naTISVehicleOwnerVerificationIndicator;
            this.NameOfCurrentOwner = nameOfCurrentOwner;
            this.VehicleTitleHolderVerificationIndicator = vehicleTitleHolderVerificationIndicator;
            this.NameOfCurrentTitleHolder = nameOfCurrentTitleHolder;
        }

        /// <summary>
        /// Gets or Sets NaTISVehicleOwnerVerificationIndicator
        /// </summary>
        [DataMember(Name="naTIS_Vehicle_Owner_Verification_Indicator", EmitDefaultValue=true)]
        public string NaTISVehicleOwnerVerificationIndicator { get; set; }

        /// <summary>
        /// Gets or Sets NameOfCurrentOwner
        /// </summary>
        [DataMember(Name="name_of_Current_Owner", EmitDefaultValue=true)]
        public string NameOfCurrentOwner { get; set; }

        /// <summary>
        /// Gets or Sets VehicleTitleHolderVerificationIndicator
        /// </summary>
        [DataMember(Name="vehicle_Title_Holder_Verification_Indicator", EmitDefaultValue=true)]
        public string VehicleTitleHolderVerificationIndicator { get; set; }

        /// <summary>
        /// Gets or Sets NameOfCurrentTitleHolder
        /// </summary>
        [DataMember(Name="name_of_Current_Title_Holder", EmitDefaultValue=true)]
        public string NameOfCurrentTitleHolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118VehicleOwnershipTitleHolderInformationUW {\n");
            sb.Append("  NaTISVehicleOwnerVerificationIndicator: ").Append(NaTISVehicleOwnerVerificationIndicator).Append("\n");
            sb.Append("  NameOfCurrentOwner: ").Append(NameOfCurrentOwner).Append("\n");
            sb.Append("  VehicleTitleHolderVerificationIndicator: ").Append(VehicleTitleHolderVerificationIndicator).Append("\n");
            sb.Append("  NameOfCurrentTitleHolder: ").Append(NameOfCurrentTitleHolder).Append("\n");
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
            return this.Equals(input as TransunionConsumer118VehicleOwnershipTitleHolderInformationUW);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118VehicleOwnershipTitleHolderInformationUW instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118VehicleOwnershipTitleHolderInformationUW to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118VehicleOwnershipTitleHolderInformationUW input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NaTISVehicleOwnerVerificationIndicator == input.NaTISVehicleOwnerVerificationIndicator ||
                    (this.NaTISVehicleOwnerVerificationIndicator != null &&
                    this.NaTISVehicleOwnerVerificationIndicator.Equals(input.NaTISVehicleOwnerVerificationIndicator))
                ) && 
                (
                    this.NameOfCurrentOwner == input.NameOfCurrentOwner ||
                    (this.NameOfCurrentOwner != null &&
                    this.NameOfCurrentOwner.Equals(input.NameOfCurrentOwner))
                ) && 
                (
                    this.VehicleTitleHolderVerificationIndicator == input.VehicleTitleHolderVerificationIndicator ||
                    (this.VehicleTitleHolderVerificationIndicator != null &&
                    this.VehicleTitleHolderVerificationIndicator.Equals(input.VehicleTitleHolderVerificationIndicator))
                ) && 
                (
                    this.NameOfCurrentTitleHolder == input.NameOfCurrentTitleHolder ||
                    (this.NameOfCurrentTitleHolder != null &&
                    this.NameOfCurrentTitleHolder.Equals(input.NameOfCurrentTitleHolder))
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
                if (this.NaTISVehicleOwnerVerificationIndicator != null)
                    hashCode = hashCode * 59 + this.NaTISVehicleOwnerVerificationIndicator.GetHashCode();
                if (this.NameOfCurrentOwner != null)
                    hashCode = hashCode * 59 + this.NameOfCurrentOwner.GetHashCode();
                if (this.VehicleTitleHolderVerificationIndicator != null)
                    hashCode = hashCode * 59 + this.VehicleTitleHolderVerificationIndicator.GetHashCode();
                if (this.NameOfCurrentTitleHolder != null)
                    hashCode = hashCode * 59 + this.NameOfCurrentTitleHolder.GetHashCode();
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
