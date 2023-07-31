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
    /// TransunionConsumer118EnquiriesNE09
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EnquiriesNE09 :  IEquatable<TransunionConsumer118EnquiriesNE09>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EnquiriesNE09" /> class.
        /// </summary>
        /// <param name="recordSeq">recordSeq.</param>
        /// <param name="part">part.</param>
        /// <param name="partSeq">partSeq.</param>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="dateOfEnquiry">dateOfEnquiry.</param>
        /// <param name="subscriber">subscriber.</param>
        /// <param name="contact">contact.</param>
        /// <param name="enquiryAmount">enquiryAmount.</param>
        /// <param name="enquiryTypeCode">enquiryTypeCode.</param>
        /// <param name="enquiryType">enquiryType.</param>
        public TransunionConsumer118EnquiriesNE09(string recordSeq = default(string), string part = default(string), string partSeq = default(string), string consumerNo = default(string), string dateOfEnquiry = default(string), string subscriber = default(string), string contact = default(string), string enquiryAmount = default(string), string enquiryTypeCode = default(string), string enquiryType = default(string))
        {
            this.RecordSeq = recordSeq;
            this.Part = part;
            this.PartSeq = partSeq;
            this.ConsumerNo = consumerNo;
            this.DateOfEnquiry = dateOfEnquiry;
            this.Subscriber = subscriber;
            this.Contact = contact;
            this.EnquiryAmount = enquiryAmount;
            this.EnquiryTypeCode = enquiryTypeCode;
            this.EnquiryType = enquiryType;
            this.RecordSeq = recordSeq;
            this.Part = part;
            this.PartSeq = partSeq;
            this.ConsumerNo = consumerNo;
            this.DateOfEnquiry = dateOfEnquiry;
            this.Subscriber = subscriber;
            this.Contact = contact;
            this.EnquiryAmount = enquiryAmount;
            this.EnquiryTypeCode = enquiryTypeCode;
            this.EnquiryType = enquiryType;
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
        /// Gets or Sets DateOfEnquiry
        /// </summary>
        [DataMember(Name="dateOfEnquiry", EmitDefaultValue=true)]
        public string DateOfEnquiry { get; set; }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name="subscriber", EmitDefaultValue=true)]
        public string Subscriber { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=true)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryAmount
        /// </summary>
        [DataMember(Name="enquiryAmount", EmitDefaultValue=true)]
        public string EnquiryAmount { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryTypeCode
        /// </summary>
        [DataMember(Name="enquiryTypeCode", EmitDefaultValue=true)]
        public string EnquiryTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryType
        /// </summary>
        [DataMember(Name="enquiryType", EmitDefaultValue=true)]
        public string EnquiryType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EnquiriesNE09 {\n");
            sb.Append("  RecordSeq: ").Append(RecordSeq).Append("\n");
            sb.Append("  Part: ").Append(Part).Append("\n");
            sb.Append("  PartSeq: ").Append(PartSeq).Append("\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  DateOfEnquiry: ").Append(DateOfEnquiry).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  EnquiryAmount: ").Append(EnquiryAmount).Append("\n");
            sb.Append("  EnquiryTypeCode: ").Append(EnquiryTypeCode).Append("\n");
            sb.Append("  EnquiryType: ").Append(EnquiryType).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EnquiriesNE09);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EnquiriesNE09 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EnquiriesNE09 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EnquiriesNE09 input)
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
                    this.DateOfEnquiry == input.DateOfEnquiry ||
                    (this.DateOfEnquiry != null &&
                    this.DateOfEnquiry.Equals(input.DateOfEnquiry))
                ) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.EnquiryAmount == input.EnquiryAmount ||
                    (this.EnquiryAmount != null &&
                    this.EnquiryAmount.Equals(input.EnquiryAmount))
                ) && 
                (
                    this.EnquiryTypeCode == input.EnquiryTypeCode ||
                    (this.EnquiryTypeCode != null &&
                    this.EnquiryTypeCode.Equals(input.EnquiryTypeCode))
                ) && 
                (
                    this.EnquiryType == input.EnquiryType ||
                    (this.EnquiryType != null &&
                    this.EnquiryType.Equals(input.EnquiryType))
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
                if (this.DateOfEnquiry != null)
                    hashCode = hashCode * 59 + this.DateOfEnquiry.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.EnquiryAmount != null)
                    hashCode = hashCode * 59 + this.EnquiryAmount.GetHashCode();
                if (this.EnquiryTypeCode != null)
                    hashCode = hashCode * 59 + this.EnquiryTypeCode.GetHashCode();
                if (this.EnquiryType != null)
                    hashCode = hashCode * 59 + this.EnquiryType.GetHashCode();
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
