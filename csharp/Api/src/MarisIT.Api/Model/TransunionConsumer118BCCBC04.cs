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
    /// TransunionConsumer118BCCBC04
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118BCCBC04 :  IEquatable<TransunionConsumer118BCCBC04>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118BCCBC04" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="bcCs">bcCs.</param>
        public TransunionConsumer118BCCBC04(string consumerNo = default(string), List<TransunionConsumer118BCC04> bcCs = default(List<TransunionConsumer118BCC04>))
        {
            this.ConsumerNo = consumerNo;
            this.BcCs = bcCs;
            this.ConsumerNo = consumerNo;
            this.BcCs = bcCs;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets BcCs
        /// </summary>
        [DataMember(Name="bcCs", EmitDefaultValue=true)]
        public List<TransunionConsumer118BCC04> BcCs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118BCCBC04 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  BcCs: ").Append(BcCs).Append("\n");
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
            return this.Equals(input as TransunionConsumer118BCCBC04);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118BCCBC04 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118BCCBC04 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118BCCBC04 input)
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
                    this.BcCs == input.BcCs ||
                    this.BcCs != null &&
                    input.BcCs != null &&
                    this.BcCs.SequenceEqual(input.BcCs)
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
                if (this.BcCs != null)
                    hashCode = hashCode * 59 + this.BcCs.GetHashCode();
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
