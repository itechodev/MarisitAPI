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
    /// TransunionConsumer118DebtCounsellingDC01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118DebtCounsellingDC01 :  IEquatable<TransunionConsumer118DebtCounsellingDC01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118DebtCounsellingDC01" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="debtCounsellingDate">debtCounsellingDate.</param>
        /// <param name="debtCounsellingCode">debtCounsellingCode.</param>
        /// <param name="debtCounsellingDescription">debtCounsellingDescription.</param>
        public TransunionConsumer118DebtCounsellingDC01(string consumerNo = default(string), string debtCounsellingDate = default(string), string debtCounsellingCode = default(string), string debtCounsellingDescription = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.DebtCounsellingDate = debtCounsellingDate;
            this.DebtCounsellingCode = debtCounsellingCode;
            this.DebtCounsellingDescription = debtCounsellingDescription;
            this.ConsumerNo = consumerNo;
            this.DebtCounsellingDate = debtCounsellingDate;
            this.DebtCounsellingCode = debtCounsellingCode;
            this.DebtCounsellingDescription = debtCounsellingDescription;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets DebtCounsellingDate
        /// </summary>
        [DataMember(Name="debtCounsellingDate", EmitDefaultValue=true)]
        public string DebtCounsellingDate { get; set; }

        /// <summary>
        /// Gets or Sets DebtCounsellingCode
        /// </summary>
        [DataMember(Name="debtCounsellingCode", EmitDefaultValue=true)]
        public string DebtCounsellingCode { get; set; }

        /// <summary>
        /// Gets or Sets DebtCounsellingDescription
        /// </summary>
        [DataMember(Name="debtCounsellingDescription", EmitDefaultValue=true)]
        public string DebtCounsellingDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118DebtCounsellingDC01 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  DebtCounsellingDate: ").Append(DebtCounsellingDate).Append("\n");
            sb.Append("  DebtCounsellingCode: ").Append(DebtCounsellingCode).Append("\n");
            sb.Append("  DebtCounsellingDescription: ").Append(DebtCounsellingDescription).Append("\n");
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
            return this.Equals(input as TransunionConsumer118DebtCounsellingDC01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118DebtCounsellingDC01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118DebtCounsellingDC01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118DebtCounsellingDC01 input)
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
                    this.DebtCounsellingDate == input.DebtCounsellingDate ||
                    (this.DebtCounsellingDate != null &&
                    this.DebtCounsellingDate.Equals(input.DebtCounsellingDate))
                ) && 
                (
                    this.DebtCounsellingCode == input.DebtCounsellingCode ||
                    (this.DebtCounsellingCode != null &&
                    this.DebtCounsellingCode.Equals(input.DebtCounsellingCode))
                ) && 
                (
                    this.DebtCounsellingDescription == input.DebtCounsellingDescription ||
                    (this.DebtCounsellingDescription != null &&
                    this.DebtCounsellingDescription.Equals(input.DebtCounsellingDescription))
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
                if (this.DebtCounsellingDate != null)
                    hashCode = hashCode * 59 + this.DebtCounsellingDate.GetHashCode();
                if (this.DebtCounsellingCode != null)
                    hashCode = hashCode * 59 + this.DebtCounsellingCode.GetHashCode();
                if (this.DebtCounsellingDescription != null)
                    hashCode = hashCode * 59 + this.DebtCounsellingDescription.GetHashCode();
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
