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
    /// TransunionConsumer118EmploymentNM04
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EmploymentNM04 :  IEquatable<TransunionConsumer118EmploymentNM04>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EmploymentNM04" /> class.
        /// </summary>
        /// <param name="recordSeq">recordSeq.</param>
        /// <param name="part">part.</param>
        /// <param name="partSeq">partSeq.</param>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="informationDate">informationDate.</param>
        /// <param name="occupation">occupation.</param>
        /// <param name="employerName">employerName.</param>
        /// <param name="employmentPeriod">employmentPeriod.</param>
        public TransunionConsumer118EmploymentNM04(string recordSeq = default(string), string part = default(string), string partSeq = default(string), string consumerNo = default(string), string informationDate = default(string), string occupation = default(string), string employerName = default(string), string employmentPeriod = default(string))
        {
            this.RecordSeq = recordSeq;
            this.Part = part;
            this.PartSeq = partSeq;
            this.ConsumerNo = consumerNo;
            this.InformationDate = informationDate;
            this.Occupation = occupation;
            this.EmployerName = employerName;
            this.EmploymentPeriod = employmentPeriod;
            this.RecordSeq = recordSeq;
            this.Part = part;
            this.PartSeq = partSeq;
            this.ConsumerNo = consumerNo;
            this.InformationDate = informationDate;
            this.Occupation = occupation;
            this.EmployerName = employerName;
            this.EmploymentPeriod = employmentPeriod;
        }

        /// <summary>
        /// Gets or Sets RecordSeq
        /// </summary>
        [DataMember(Name="recordSeq", EmitDefaultValue=true)]
        public string RecordSeq { get; set; }

        /// <summary>
        /// Gets or Sets Part
        /// </summary>
        [DataMember(Name="part", EmitDefaultValue=true)]
        public string Part { get; set; }

        /// <summary>
        /// Gets or Sets PartSeq
        /// </summary>
        [DataMember(Name="partSeq", EmitDefaultValue=true)]
        public string PartSeq { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets InformationDate
        /// </summary>
        [DataMember(Name="informationDate", EmitDefaultValue=true)]
        public string InformationDate { get; set; }

        /// <summary>
        /// Gets or Sets Occupation
        /// </summary>
        [DataMember(Name="occupation", EmitDefaultValue=true)]
        public string Occupation { get; set; }

        /// <summary>
        /// Gets or Sets EmployerName
        /// </summary>
        [DataMember(Name="employerName", EmitDefaultValue=true)]
        public string EmployerName { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentPeriod
        /// </summary>
        [DataMember(Name="employmentPeriod", EmitDefaultValue=true)]
        public string EmploymentPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EmploymentNM04 {\n");
            sb.Append("  RecordSeq: ").Append(RecordSeq).Append("\n");
            sb.Append("  Part: ").Append(Part).Append("\n");
            sb.Append("  PartSeq: ").Append(PartSeq).Append("\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  InformationDate: ").Append(InformationDate).Append("\n");
            sb.Append("  Occupation: ").Append(Occupation).Append("\n");
            sb.Append("  EmployerName: ").Append(EmployerName).Append("\n");
            sb.Append("  EmploymentPeriod: ").Append(EmploymentPeriod).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EmploymentNM04);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EmploymentNM04 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EmploymentNM04 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EmploymentNM04 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordSeq == input.RecordSeq ||
                    (this.RecordSeq != null &&
                    this.RecordSeq.Equals(input.RecordSeq))
                ) && 
                (
                    this.Part == input.Part ||
                    (this.Part != null &&
                    this.Part.Equals(input.Part))
                ) && 
                (
                    this.PartSeq == input.PartSeq ||
                    (this.PartSeq != null &&
                    this.PartSeq.Equals(input.PartSeq))
                ) && 
                (
                    this.ConsumerNo == input.ConsumerNo ||
                    (this.ConsumerNo != null &&
                    this.ConsumerNo.Equals(input.ConsumerNo))
                ) && 
                (
                    this.InformationDate == input.InformationDate ||
                    (this.InformationDate != null &&
                    this.InformationDate.Equals(input.InformationDate))
                ) && 
                (
                    this.Occupation == input.Occupation ||
                    (this.Occupation != null &&
                    this.Occupation.Equals(input.Occupation))
                ) && 
                (
                    this.EmployerName == input.EmployerName ||
                    (this.EmployerName != null &&
                    this.EmployerName.Equals(input.EmployerName))
                ) && 
                (
                    this.EmploymentPeriod == input.EmploymentPeriod ||
                    (this.EmploymentPeriod != null &&
                    this.EmploymentPeriod.Equals(input.EmploymentPeriod))
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
                if (this.RecordSeq != null)
                    hashCode = hashCode * 59 + this.RecordSeq.GetHashCode();
                if (this.Part != null)
                    hashCode = hashCode * 59 + this.Part.GetHashCode();
                if (this.PartSeq != null)
                    hashCode = hashCode * 59 + this.PartSeq.GetHashCode();
                if (this.ConsumerNo != null)
                    hashCode = hashCode * 59 + this.ConsumerNo.GetHashCode();
                if (this.InformationDate != null)
                    hashCode = hashCode * 59 + this.InformationDate.GetHashCode();
                if (this.Occupation != null)
                    hashCode = hashCode * 59 + this.Occupation.GetHashCode();
                if (this.EmployerName != null)
                    hashCode = hashCode * 59 + this.EmployerName.GetHashCode();
                if (this.EmploymentPeriod != null)
                    hashCode = hashCode * 59 + this.EmploymentPeriod.GetHashCode();
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
