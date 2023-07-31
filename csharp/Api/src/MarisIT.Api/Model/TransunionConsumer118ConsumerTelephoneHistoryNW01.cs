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
    /// TransunionConsumer118ConsumerTelephoneHistoryNW01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ConsumerTelephoneHistoryNW01 :  IEquatable<TransunionConsumer118ConsumerTelephoneHistoryNW01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ConsumerTelephoneHistoryNW01" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="workNumbers">workNumbers.</param>
        /// <param name="homeNumbers">homeNumbers.</param>
        /// <param name="cellNumbers">cellNumbers.</param>
        public TransunionConsumer118ConsumerTelephoneHistoryNW01(string consumerNo = default(string), List<TransunionConsumer118PhoneNumber> workNumbers = default(List<TransunionConsumer118PhoneNumber>), List<TransunionConsumer118PhoneNumber> homeNumbers = default(List<TransunionConsumer118PhoneNumber>), List<TransunionConsumer118PhoneNumber> cellNumbers = default(List<TransunionConsumer118PhoneNumber>))
        {
            this.ConsumerNo = consumerNo;
            this.WorkNumbers = workNumbers;
            this.HomeNumbers = homeNumbers;
            this.CellNumbers = cellNumbers;
            this.ConsumerNo = consumerNo;
            this.WorkNumbers = workNumbers;
            this.HomeNumbers = homeNumbers;
            this.CellNumbers = cellNumbers;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets WorkNumbers
        /// </summary>
        [DataMember(Name="workNumbers", EmitDefaultValue=true)]
        public List<TransunionConsumer118PhoneNumber> WorkNumbers { get; set; }

        /// <summary>
        /// Gets or Sets HomeNumbers
        /// </summary>
        [DataMember(Name="homeNumbers", EmitDefaultValue=true)]
        public List<TransunionConsumer118PhoneNumber> HomeNumbers { get; set; }

        /// <summary>
        /// Gets or Sets CellNumbers
        /// </summary>
        [DataMember(Name="cellNumbers", EmitDefaultValue=true)]
        public List<TransunionConsumer118PhoneNumber> CellNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ConsumerTelephoneHistoryNW01 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  WorkNumbers: ").Append(WorkNumbers).Append("\n");
            sb.Append("  HomeNumbers: ").Append(HomeNumbers).Append("\n");
            sb.Append("  CellNumbers: ").Append(CellNumbers).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ConsumerTelephoneHistoryNW01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ConsumerTelephoneHistoryNW01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ConsumerTelephoneHistoryNW01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ConsumerTelephoneHistoryNW01 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerNo == input.ConsumerNo ||
                    (this.ConsumerNo != null &&
                    this.ConsumerNo.Equals(input.ConsumerNo))
                ) && 
                (
                    this.WorkNumbers == input.WorkNumbers ||
                    this.WorkNumbers != null &&
                    input.WorkNumbers != null &&
                    this.WorkNumbers.SequenceEqual(input.WorkNumbers)
                ) && 
                (
                    this.HomeNumbers == input.HomeNumbers ||
                    this.HomeNumbers != null &&
                    input.HomeNumbers != null &&
                    this.HomeNumbers.SequenceEqual(input.HomeNumbers)
                ) && 
                (
                    this.CellNumbers == input.CellNumbers ||
                    this.CellNumbers != null &&
                    input.CellNumbers != null &&
                    this.CellNumbers.SequenceEqual(input.CellNumbers)
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
                if (this.ConsumerNo != null)
                    hashCode = hashCode * 59 + this.ConsumerNo.GetHashCode();
                if (this.WorkNumbers != null)
                    hashCode = hashCode * 59 + this.WorkNumbers.GetHashCode();
                if (this.HomeNumbers != null)
                    hashCode = hashCode * 59 + this.HomeNumbers.GetHashCode();
                if (this.CellNumbers != null)
                    hashCode = hashCode * 59 + this.CellNumbers.GetHashCode();
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
