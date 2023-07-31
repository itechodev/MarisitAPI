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
    /// TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI :  IEquatable<TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI" /> class.
        /// </summary>
        /// <param name="recordDescription">recordDescription.</param>
        /// <param name="registrationAuthority">registrationAuthority.</param>
        /// <param name="deregistrationDate">deregistrationDate.</param>
        public TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI(string recordDescription = default(string), string registrationAuthority = default(string), string deregistrationDate = default(string))
        {
            this.RecordDescription = recordDescription;
            this.RegistrationAuthority = registrationAuthority;
            this.DeregistrationDate = deregistrationDate;
            this.RecordDescription = recordDescription;
            this.RegistrationAuthority = registrationAuthority;
            this.DeregistrationDate = deregistrationDate;
        }

        /// <summary>
        /// Gets or Sets RecordDescription
        /// </summary>
        [DataMember(Name="recordDescription", EmitDefaultValue=true)]
        public string RecordDescription { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationAuthority
        /// </summary>
        [DataMember(Name="registrationAuthority", EmitDefaultValue=true)]
        public string RegistrationAuthority { get; set; }

        /// <summary>
        /// Gets or Sets DeregistrationDate
        /// </summary>
        [DataMember(Name="deregistrationDate", EmitDefaultValue=true)]
        public string DeregistrationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI {\n");
            sb.Append("  RecordDescription: ").Append(RecordDescription).Append("\n");
            sb.Append("  RegistrationAuthority: ").Append(RegistrationAuthority).Append("\n");
            sb.Append("  DeregistrationDate: ").Append(DeregistrationDate).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TUVehicleRegistrationAuthorityHistoryRecordedVI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordDescription == input.RecordDescription ||
                    (this.RecordDescription != null &&
                    this.RecordDescription.Equals(input.RecordDescription))
                ) && 
                (
                    this.RegistrationAuthority == input.RegistrationAuthority ||
                    (this.RegistrationAuthority != null &&
                    this.RegistrationAuthority.Equals(input.RegistrationAuthority))
                ) && 
                (
                    this.DeregistrationDate == input.DeregistrationDate ||
                    (this.DeregistrationDate != null &&
                    this.DeregistrationDate.Equals(input.DeregistrationDate))
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
                if (this.RecordDescription != null)
                    hashCode = hashCode * 59 + this.RecordDescription.GetHashCode();
                if (this.RegistrationAuthority != null)
                    hashCode = hashCode * 59 + this.RegistrationAuthority.GetHashCode();
                if (this.DeregistrationDate != null)
                    hashCode = hashCode * 59 + this.DeregistrationDate.GetHashCode();
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
