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
    /// XdsKYCOnline
    /// </summary>
    [DataContract]
    public partial class XdsKYCOnline :  IEquatable<XdsKYCOnline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsKYCOnline" /> class.
        /// </summary>
        /// <param name="consumerDetail">consumerDetail.</param>
        /// <param name="kycResult">kycResult.</param>
        /// <param name="subscriberInputDetails">subscriberInputDetails.</param>
        public XdsKYCOnline(XdsConsumerDetail consumerDetail = default(XdsConsumerDetail), XdsKYCResult kycResult = default(XdsKYCResult), XdsSubscriberInputDetails subscriberInputDetails = default(XdsSubscriberInputDetails))
        {
            this.ConsumerDetail = consumerDetail;
            this.KycResult = kycResult;
            this.SubscriberInputDetails = subscriberInputDetails;
        }

        /// <summary>
        /// Gets or Sets ConsumerDetail
        /// </summary>
        [DataMember(Name="consumerDetail", EmitDefaultValue=false)]
        public XdsConsumerDetail ConsumerDetail { get; set; }

        /// <summary>
        /// Gets or Sets KycResult
        /// </summary>
        [DataMember(Name="kycResult", EmitDefaultValue=false)]
        public XdsKYCResult KycResult { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberInputDetails
        /// </summary>
        [DataMember(Name="subscriberInputDetails", EmitDefaultValue=false)]
        public XdsSubscriberInputDetails SubscriberInputDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsKYCOnline {\n");
            sb.Append("  ConsumerDetail: ").Append(ConsumerDetail).Append("\n");
            sb.Append("  KycResult: ").Append(KycResult).Append("\n");
            sb.Append("  SubscriberInputDetails: ").Append(SubscriberInputDetails).Append("\n");
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
            return this.Equals(input as XdsKYCOnline);
        }

        /// <summary>
        /// Returns true if XdsKYCOnline instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsKYCOnline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsKYCOnline input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerDetail == input.ConsumerDetail ||
                    (this.ConsumerDetail != null &&
                    this.ConsumerDetail.Equals(input.ConsumerDetail))
                ) && 
                (
                    this.KycResult == input.KycResult ||
                    (this.KycResult != null &&
                    this.KycResult.Equals(input.KycResult))
                ) && 
                (
                    this.SubscriberInputDetails == input.SubscriberInputDetails ||
                    (this.SubscriberInputDetails != null &&
                    this.SubscriberInputDetails.Equals(input.SubscriberInputDetails))
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
                if (this.ConsumerDetail != null)
                    hashCode = hashCode * 59 + this.ConsumerDetail.GetHashCode();
                if (this.KycResult != null)
                    hashCode = hashCode * 59 + this.KycResult.GetHashCode();
                if (this.SubscriberInputDetails != null)
                    hashCode = hashCode * 59 + this.SubscriberInputDetails.GetHashCode();
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
