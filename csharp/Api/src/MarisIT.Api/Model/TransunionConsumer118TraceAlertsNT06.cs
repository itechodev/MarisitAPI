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
    /// TransunionConsumer118TraceAlertsNT06
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TraceAlertsNT06 :  IEquatable<TransunionConsumer118TraceAlertsNT06>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TraceAlertsNT06" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="traceTypeCode">traceTypeCode.</param>
        /// <param name="traceTypeDesc">traceTypeDesc.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="subscriberName">subscriberName.</param>
        /// <param name="comment1">comment1.</param>
        /// <param name="comment2">comment2.</param>
        public TransunionConsumer118TraceAlertsNT06(string consumerNo = default(string), string traceTypeCode = default(string), string traceTypeDesc = default(string), string contactName = default(string), string contactPhone = default(string), string subscriberName = default(string), string comment1 = default(string), string comment2 = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.TraceTypeCode = traceTypeCode;
            this.TraceTypeDesc = traceTypeDesc;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.SubscriberName = subscriberName;
            this.Comment1 = comment1;
            this.Comment2 = comment2;
            this.ConsumerNo = consumerNo;
            this.TraceTypeCode = traceTypeCode;
            this.TraceTypeDesc = traceTypeDesc;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.SubscriberName = subscriberName;
            this.Comment1 = comment1;
            this.Comment2 = comment2;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets TraceTypeCode
        /// </summary>
        [DataMember(Name="traceTypeCode", EmitDefaultValue=true)]
        public string TraceTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets TraceTypeDesc
        /// </summary>
        [DataMember(Name="traceTypeDesc", EmitDefaultValue=true)]
        public string TraceTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="contactName", EmitDefaultValue=true)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name="contactPhone", EmitDefaultValue=true)]
        public string ContactPhone { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberName
        /// </summary>
        [DataMember(Name="subscriberName", EmitDefaultValue=true)]
        public string SubscriberName { get; set; }

        /// <summary>
        /// Gets or Sets Comment1
        /// </summary>
        [DataMember(Name="comment1", EmitDefaultValue=true)]
        public string Comment1 { get; set; }

        /// <summary>
        /// Gets or Sets Comment2
        /// </summary>
        [DataMember(Name="comment2", EmitDefaultValue=true)]
        public string Comment2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TraceAlertsNT06 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  TraceTypeCode: ").Append(TraceTypeCode).Append("\n");
            sb.Append("  TraceTypeDesc: ").Append(TraceTypeDesc).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  SubscriberName: ").Append(SubscriberName).Append("\n");
            sb.Append("  Comment1: ").Append(Comment1).Append("\n");
            sb.Append("  Comment2: ").Append(Comment2).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TraceAlertsNT06);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TraceAlertsNT06 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TraceAlertsNT06 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TraceAlertsNT06 input)
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
                    this.TraceTypeCode == input.TraceTypeCode ||
                    (this.TraceTypeCode != null &&
                    this.TraceTypeCode.Equals(input.TraceTypeCode))
                ) && 
                (
                    this.TraceTypeDesc == input.TraceTypeDesc ||
                    (this.TraceTypeDesc != null &&
                    this.TraceTypeDesc.Equals(input.TraceTypeDesc))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactPhone == input.ContactPhone ||
                    (this.ContactPhone != null &&
                    this.ContactPhone.Equals(input.ContactPhone))
                ) && 
                (
                    this.SubscriberName == input.SubscriberName ||
                    (this.SubscriberName != null &&
                    this.SubscriberName.Equals(input.SubscriberName))
                ) && 
                (
                    this.Comment1 == input.Comment1 ||
                    (this.Comment1 != null &&
                    this.Comment1.Equals(input.Comment1))
                ) && 
                (
                    this.Comment2 == input.Comment2 ||
                    (this.Comment2 != null &&
                    this.Comment2.Equals(input.Comment2))
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
                if (this.TraceTypeCode != null)
                    hashCode = hashCode * 59 + this.TraceTypeCode.GetHashCode();
                if (this.TraceTypeDesc != null)
                    hashCode = hashCode * 59 + this.TraceTypeDesc.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.ContactPhone != null)
                    hashCode = hashCode * 59 + this.ContactPhone.GetHashCode();
                if (this.SubscriberName != null)
                    hashCode = hashCode * 59 + this.SubscriberName.GetHashCode();
                if (this.Comment1 != null)
                    hashCode = hashCode * 59 + this.Comment1.GetHashCode();
                if (this.Comment2 != null)
                    hashCode = hashCode * 59 + this.Comment2.GetHashCode();
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
