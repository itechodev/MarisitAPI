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
    /// TransunionCommercialConsumerEnquiry
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialConsumerEnquiry :  IEquatable<TransunionCommercialConsumerEnquiry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialConsumerEnquiry" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="enquiryDate">enquiryDate.</param>
        /// <param name="subscriber">subscriber.</param>
        /// <param name="contact">contact.</param>
        /// <param name="type">type.</param>
        /// <param name="transType">transType.</param>
        public TransunionCommercialConsumerEnquiry(string majorProduct = default(string), string consumerNo = default(string), string enquiryDate = default(string), string subscriber = default(string), string contact = default(string), string type = default(string), string transType = default(string))
        {
            this.MajorProduct = majorProduct;
            this.ConsumerNo = consumerNo;
            this.EnquiryDate = enquiryDate;
            this.Subscriber = subscriber;
            this.Contact = contact;
            this.Type = type;
            this.TransType = transType;
            this.MajorProduct = majorProduct;
            this.ConsumerNo = consumerNo;
            this.EnquiryDate = enquiryDate;
            this.Subscriber = subscriber;
            this.Contact = contact;
            this.Type = type;
            this.TransType = transType;
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
        /// Gets or Sets EnquiryDate
        /// </summary>
        [DataMember(Name="enquiryDate", EmitDefaultValue=true)]
        public string EnquiryDate { get; set; }

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
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TransType
        /// </summary>
        [DataMember(Name="transType", EmitDefaultValue=true)]
        public string TransType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialConsumerEnquiry {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  EnquiryDate: ").Append(EnquiryDate).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TransType: ").Append(TransType).Append("\n");
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
            return this.Equals(input as TransunionCommercialConsumerEnquiry);
        }

        /// <summary>
        /// Returns true if TransunionCommercialConsumerEnquiry instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialConsumerEnquiry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialConsumerEnquiry input)
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
                    this.EnquiryDate == input.EnquiryDate ||
                    (this.EnquiryDate != null &&
                    this.EnquiryDate.Equals(input.EnquiryDate))
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TransType == input.TransType ||
                    (this.TransType != null &&
                    this.TransType.Equals(input.TransType))
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
                if (this.EnquiryDate != null)
                    hashCode = hashCode * 59 + this.EnquiryDate.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TransType != null)
                    hashCode = hashCode * 59 + this.TransType.GetHashCode();
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
