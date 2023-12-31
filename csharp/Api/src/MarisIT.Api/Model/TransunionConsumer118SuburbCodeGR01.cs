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
    /// TransunionConsumer118SuburbCodeGR01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118SuburbCodeGR01 :  IEquatable<TransunionConsumer118SuburbCodeGR01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118SuburbCodeGR01" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="suburbCode">suburbCode.</param>
        /// <param name="dataDate">dataDate.</param>
        /// <param name="loadDate">loadDate.</param>
        /// <param name="codes">codes.</param>
        public TransunionConsumer118SuburbCodeGR01(string consumerNo = default(string), string suburbCode = default(string), string dataDate = default(string), string loadDate = default(string), List<string> codes = default(List<string>))
        {
            this.ConsumerNo = consumerNo;
            this.SuburbCode = suburbCode;
            this.DataDate = dataDate;
            this.LoadDate = loadDate;
            this.Codes = codes;
            this.ConsumerNo = consumerNo;
            this.SuburbCode = suburbCode;
            this.DataDate = dataDate;
            this.LoadDate = loadDate;
            this.Codes = codes;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets SuburbCode
        /// </summary>
        [DataMember(Name="suburbCode", EmitDefaultValue=true)]
        public string SuburbCode { get; set; }

        /// <summary>
        /// Gets or Sets DataDate
        /// </summary>
        [DataMember(Name="dataDate", EmitDefaultValue=true)]
        public string DataDate { get; set; }

        /// <summary>
        /// Gets or Sets LoadDate
        /// </summary>
        [DataMember(Name="loadDate", EmitDefaultValue=true)]
        public string LoadDate { get; set; }

        /// <summary>
        /// Gets or Sets Codes
        /// </summary>
        [DataMember(Name="codes", EmitDefaultValue=true)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118SuburbCodeGR01 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  SuburbCode: ").Append(SuburbCode).Append("\n");
            sb.Append("  DataDate: ").Append(DataDate).Append("\n");
            sb.Append("  LoadDate: ").Append(LoadDate).Append("\n");
            sb.Append("  Codes: ").Append(Codes).Append("\n");
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
            return this.Equals(input as TransunionConsumer118SuburbCodeGR01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118SuburbCodeGR01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118SuburbCodeGR01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118SuburbCodeGR01 input)
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
                    this.SuburbCode == input.SuburbCode ||
                    (this.SuburbCode != null &&
                    this.SuburbCode.Equals(input.SuburbCode))
                ) && 
                (
                    this.DataDate == input.DataDate ||
                    (this.DataDate != null &&
                    this.DataDate.Equals(input.DataDate))
                ) && 
                (
                    this.LoadDate == input.LoadDate ||
                    (this.LoadDate != null &&
                    this.LoadDate.Equals(input.LoadDate))
                ) && 
                (
                    this.Codes == input.Codes ||
                    this.Codes != null &&
                    input.Codes != null &&
                    this.Codes.SequenceEqual(input.Codes)
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
                if (this.SuburbCode != null)
                    hashCode = hashCode * 59 + this.SuburbCode.GetHashCode();
                if (this.DataDate != null)
                    hashCode = hashCode * 59 + this.DataDate.GetHashCode();
                if (this.LoadDate != null)
                    hashCode = hashCode * 59 + this.LoadDate.GetHashCode();
                if (this.Codes != null)
                    hashCode = hashCode * 59 + this.Codes.GetHashCode();
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
