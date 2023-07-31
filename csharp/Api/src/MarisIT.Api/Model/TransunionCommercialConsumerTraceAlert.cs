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
    /// TransunionCommercialConsumerTraceAlert
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialConsumerTraceAlert :  IEquatable<TransunionCommercialConsumerTraceAlert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialConsumerTraceAlert" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="informationDate">informationDate.</param>
        /// <param name="traceTypeCode">traceTypeCode.</param>
        /// <param name="traceType">traceType.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="subscriberName">subscriberName.</param>
        /// <param name="comment1">comment1.</param>
        /// <param name="comment2">comment2.</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="message">message.</param>
        /// <param name="subscriberNumber">subscriberNumber.</param>
        public TransunionCommercialConsumerTraceAlert(string majorProduct = default(string), string consumerNo = default(string), string informationDate = default(string), string traceTypeCode = default(string), string traceType = default(string), string contactName = default(string), string contactPhone = default(string), string subscriberName = default(string), string comment1 = default(string), string comment2 = default(string), string transactionType = default(string), string message = default(string), string subscriberNumber = default(string))
        {
            this.MajorProduct = majorProduct;
            this.ConsumerNo = consumerNo;
            this.InformationDate = informationDate;
            this.TraceTypeCode = traceTypeCode;
            this.TraceType = traceType;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.SubscriberName = subscriberName;
            this.Comment1 = comment1;
            this.Comment2 = comment2;
            this.TransactionType = transactionType;
            this.Message = message;
            this.SubscriberNumber = subscriberNumber;
            this.MajorProduct = majorProduct;
            this.ConsumerNo = consumerNo;
            this.InformationDate = informationDate;
            this.TraceTypeCode = traceTypeCode;
            this.TraceType = traceType;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.SubscriberName = subscriberName;
            this.Comment1 = comment1;
            this.Comment2 = comment2;
            this.TransactionType = transactionType;
            this.Message = message;
            this.SubscriberNumber = subscriberNumber;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

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
        /// Gets or Sets TraceTypeCode
        /// </summary>
        [DataMember(Name="traceTypeCode", EmitDefaultValue=true)]
        public string TraceTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets TraceType
        /// </summary>
        [DataMember(Name="traceType", EmitDefaultValue=true)]
        public string TraceType { get; set; }

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
        /// Gets or Sets TransactionType
        /// </summary>
        [DataMember(Name="transactionType", EmitDefaultValue=true)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberNumber
        /// </summary>
        [DataMember(Name="subscriberNumber", EmitDefaultValue=true)]
        public string SubscriberNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialConsumerTraceAlert {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  InformationDate: ").Append(InformationDate).Append("\n");
            sb.Append("  TraceTypeCode: ").Append(TraceTypeCode).Append("\n");
            sb.Append("  TraceType: ").Append(TraceType).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  SubscriberName: ").Append(SubscriberName).Append("\n");
            sb.Append("  Comment1: ").Append(Comment1).Append("\n");
            sb.Append("  Comment2: ").Append(Comment2).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SubscriberNumber: ").Append(SubscriberNumber).Append("\n");
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
            return this.Equals(input as TransunionCommercialConsumerTraceAlert);
        }

        /// <summary>
        /// Returns true if TransunionCommercialConsumerTraceAlert instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialConsumerTraceAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialConsumerTraceAlert input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MajorProduct == input.MajorProduct ||
                    (this.MajorProduct != null &&
                    this.MajorProduct.Equals(input.MajorProduct))
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
                    this.TraceTypeCode == input.TraceTypeCode ||
                    (this.TraceTypeCode != null &&
                    this.TraceTypeCode.Equals(input.TraceTypeCode))
                ) && 
                (
                    this.TraceType == input.TraceType ||
                    (this.TraceType != null &&
                    this.TraceType.Equals(input.TraceType))
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
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SubscriberNumber == input.SubscriberNumber ||
                    (this.SubscriberNumber != null &&
                    this.SubscriberNumber.Equals(input.SubscriberNumber))
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
                if (this.MajorProduct != null)
                    hashCode = hashCode * 59 + this.MajorProduct.GetHashCode();
                if (this.ConsumerNo != null)
                    hashCode = hashCode * 59 + this.ConsumerNo.GetHashCode();
                if (this.InformationDate != null)
                    hashCode = hashCode * 59 + this.InformationDate.GetHashCode();
                if (this.TraceTypeCode != null)
                    hashCode = hashCode * 59 + this.TraceTypeCode.GetHashCode();
                if (this.TraceType != null)
                    hashCode = hashCode * 59 + this.TraceType.GetHashCode();
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
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SubscriberNumber != null)
                    hashCode = hashCode * 59 + this.SubscriberNumber.GetHashCode();
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
