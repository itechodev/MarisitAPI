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
    /// TransunionConsumer118HistoricContactDetailsHQ
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118HistoricContactDetailsHQ :  IEquatable<TransunionConsumer118HistoricContactDetailsHQ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118HistoricContactDetailsHQ" /> class.
        /// </summary>
        /// <param name="historyDataType1">historyDataType1.</param>
        /// <param name="historyAddressDate">historyAddressDate.</param>
        /// <param name="historyAddressPeriod">historyAddressPeriod.</param>
        /// <param name="historyAddressLine">historyAddressLine.</param>
        /// <param name="historyTelephoneNumber">historyTelephoneNumber.</param>
        /// <param name="historyTelephoneDate">historyTelephoneDate.</param>
        /// <param name="historyTelephonePeriod">historyTelephonePeriod.</param>
        public TransunionConsumer118HistoricContactDetailsHQ(string historyDataType1 = default(string), string historyAddressDate = default(string), string historyAddressPeriod = default(string), string historyAddressLine = default(string), string historyTelephoneNumber = default(string), string historyTelephoneDate = default(string), string historyTelephonePeriod = default(string))
        {
            this.HistoryDataType1 = historyDataType1;
            this.HistoryAddressDate = historyAddressDate;
            this.HistoryAddressPeriod = historyAddressPeriod;
            this.HistoryAddressLine = historyAddressLine;
            this.HistoryTelephoneNumber = historyTelephoneNumber;
            this.HistoryTelephoneDate = historyTelephoneDate;
            this.HistoryTelephonePeriod = historyTelephonePeriod;
            this.HistoryDataType1 = historyDataType1;
            this.HistoryAddressDate = historyAddressDate;
            this.HistoryAddressPeriod = historyAddressPeriod;
            this.HistoryAddressLine = historyAddressLine;
            this.HistoryTelephoneNumber = historyTelephoneNumber;
            this.HistoryTelephoneDate = historyTelephoneDate;
            this.HistoryTelephonePeriod = historyTelephonePeriod;
        }

        /// <summary>
        /// Gets or Sets HistoryDataType1
        /// </summary>
        [DataMember(Name="historyDataType1", EmitDefaultValue=true)]
        public string HistoryDataType1 { get; set; }

        /// <summary>
        /// Gets or Sets HistoryAddressDate
        /// </summary>
        [DataMember(Name="historyAddressDate", EmitDefaultValue=true)]
        public string HistoryAddressDate { get; set; }

        /// <summary>
        /// Gets or Sets HistoryAddressPeriod
        /// </summary>
        [DataMember(Name="historyAddressPeriod", EmitDefaultValue=true)]
        public string HistoryAddressPeriod { get; set; }

        /// <summary>
        /// Gets or Sets HistoryAddressLine
        /// </summary>
        [DataMember(Name="historyAddressLine", EmitDefaultValue=true)]
        public string HistoryAddressLine { get; set; }

        /// <summary>
        /// Gets or Sets HistoryTelephoneNumber
        /// </summary>
        [DataMember(Name="historyTelephoneNumber", EmitDefaultValue=true)]
        public string HistoryTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets HistoryTelephoneDate
        /// </summary>
        [DataMember(Name="historyTelephoneDate", EmitDefaultValue=true)]
        public string HistoryTelephoneDate { get; set; }

        /// <summary>
        /// Gets or Sets HistoryTelephonePeriod
        /// </summary>
        [DataMember(Name="historyTelephonePeriod", EmitDefaultValue=true)]
        public string HistoryTelephonePeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118HistoricContactDetailsHQ {\n");
            sb.Append("  HistoryDataType1: ").Append(HistoryDataType1).Append("\n");
            sb.Append("  HistoryAddressDate: ").Append(HistoryAddressDate).Append("\n");
            sb.Append("  HistoryAddressPeriod: ").Append(HistoryAddressPeriod).Append("\n");
            sb.Append("  HistoryAddressLine: ").Append(HistoryAddressLine).Append("\n");
            sb.Append("  HistoryTelephoneNumber: ").Append(HistoryTelephoneNumber).Append("\n");
            sb.Append("  HistoryTelephoneDate: ").Append(HistoryTelephoneDate).Append("\n");
            sb.Append("  HistoryTelephonePeriod: ").Append(HistoryTelephonePeriod).Append("\n");
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
            return this.Equals(input as TransunionConsumer118HistoricContactDetailsHQ);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118HistoricContactDetailsHQ instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118HistoricContactDetailsHQ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118HistoricContactDetailsHQ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoryDataType1 == input.HistoryDataType1 ||
                    (this.HistoryDataType1 != null &&
                    this.HistoryDataType1.Equals(input.HistoryDataType1))
                ) && 
                (
                    this.HistoryAddressDate == input.HistoryAddressDate ||
                    (this.HistoryAddressDate != null &&
                    this.HistoryAddressDate.Equals(input.HistoryAddressDate))
                ) && 
                (
                    this.HistoryAddressPeriod == input.HistoryAddressPeriod ||
                    (this.HistoryAddressPeriod != null &&
                    this.HistoryAddressPeriod.Equals(input.HistoryAddressPeriod))
                ) && 
                (
                    this.HistoryAddressLine == input.HistoryAddressLine ||
                    (this.HistoryAddressLine != null &&
                    this.HistoryAddressLine.Equals(input.HistoryAddressLine))
                ) && 
                (
                    this.HistoryTelephoneNumber == input.HistoryTelephoneNumber ||
                    (this.HistoryTelephoneNumber != null &&
                    this.HistoryTelephoneNumber.Equals(input.HistoryTelephoneNumber))
                ) && 
                (
                    this.HistoryTelephoneDate == input.HistoryTelephoneDate ||
                    (this.HistoryTelephoneDate != null &&
                    this.HistoryTelephoneDate.Equals(input.HistoryTelephoneDate))
                ) && 
                (
                    this.HistoryTelephonePeriod == input.HistoryTelephonePeriod ||
                    (this.HistoryTelephonePeriod != null &&
                    this.HistoryTelephonePeriod.Equals(input.HistoryTelephonePeriod))
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
                if (this.HistoryDataType1 != null)
                    hashCode = hashCode * 59 + this.HistoryDataType1.GetHashCode();
                if (this.HistoryAddressDate != null)
                    hashCode = hashCode * 59 + this.HistoryAddressDate.GetHashCode();
                if (this.HistoryAddressPeriod != null)
                    hashCode = hashCode * 59 + this.HistoryAddressPeriod.GetHashCode();
                if (this.HistoryAddressLine != null)
                    hashCode = hashCode * 59 + this.HistoryAddressLine.GetHashCode();
                if (this.HistoryTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.HistoryTelephoneNumber.GetHashCode();
                if (this.HistoryTelephoneDate != null)
                    hashCode = hashCode * 59 + this.HistoryTelephoneDate.GetHashCode();
                if (this.HistoryTelephonePeriod != null)
                    hashCode = hashCode * 59 + this.HistoryTelephonePeriod.GetHashCode();
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