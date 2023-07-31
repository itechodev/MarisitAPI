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
    /// TransunionCommercialEnquiryHistory
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialEnquiryHistory :  IEquatable<TransunionCommercialEnquiryHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialEnquiryHistory" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="dateOfEnquiry">dateOfEnquiry.</param>
        /// <param name="reason">reason.</param>
        /// <param name="subscriber">subscriber.</param>
        /// <param name="amount">amount.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactPhone">contactPhone.</param>
        /// <param name="subscriberNumber">subscriberNumber.</param>
        public TransunionCommercialEnquiryHistory(string majorProduct = default(string), string dateOfEnquiry = default(string), string reason = default(string), string subscriber = default(string), string amount = default(string), string contactName = default(string), string contactPhone = default(string), string subscriberNumber = default(string))
        {
            this.MajorProduct = majorProduct;
            this.DateOfEnquiry = dateOfEnquiry;
            this.Reason = reason;
            this.Subscriber = subscriber;
            this.Amount = amount;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.SubscriberNumber = subscriberNumber;
            this.MajorProduct = majorProduct;
            this.DateOfEnquiry = dateOfEnquiry;
            this.Reason = reason;
            this.Subscriber = subscriber;
            this.Amount = amount;
            this.ContactName = contactName;
            this.ContactPhone = contactPhone;
            this.SubscriberNumber = subscriberNumber;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets DateOfEnquiry
        /// </summary>
        [DataMember(Name="dateOfEnquiry", EmitDefaultValue=true)]
        public string DateOfEnquiry { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Subscriber
        /// </summary>
        [DataMember(Name="subscriber", EmitDefaultValue=true)]
        public string Subscriber { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

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
            sb.Append("class TransunionCommercialEnquiryHistory {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  DateOfEnquiry: ").Append(DateOfEnquiry).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Subscriber: ").Append(Subscriber).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
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
            return this.Equals(input as TransunionCommercialEnquiryHistory);
        }

        /// <summary>
        /// Returns true if TransunionCommercialEnquiryHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialEnquiryHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialEnquiryHistory input)
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
                    this.DateOfEnquiry == input.DateOfEnquiry ||
                    (this.DateOfEnquiry != null &&
                    this.DateOfEnquiry.Equals(input.DateOfEnquiry))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Subscriber == input.Subscriber ||
                    (this.Subscriber != null &&
                    this.Subscriber.Equals(input.Subscriber))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.DateOfEnquiry != null)
                    hashCode = hashCode * 59 + this.DateOfEnquiry.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Subscriber != null)
                    hashCode = hashCode * 59 + this.Subscriber.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.ContactPhone != null)
                    hashCode = hashCode * 59 + this.ContactPhone.GetHashCode();
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
