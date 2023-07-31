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
    /// TransunionConsumer118ConsumerCountersNC04
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ConsumerCountersNC04 :  IEquatable<TransunionConsumer118ConsumerCountersNC04>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ConsumerCountersNC04" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="ownEnquiries1YrBack">ownEnquiries1YrBack.</param>
        /// <param name="ownEnquiries2YrsBack">ownEnquiries2YrsBack.</param>
        /// <param name="ownEnquiriesMoreThen2YrsBack">ownEnquiriesMoreThen2YrsBack.</param>
        /// <param name="otherEnquiries1YrBack">otherEnquiries1YrBack.</param>
        /// <param name="otherEnquiries2YrsBack">otherEnquiries2YrsBack.</param>
        /// <param name="otherEnquiriesMoreThen2YrsBack">otherEnquiriesMoreThen2YrsBack.</param>
        /// <param name="judgements1YrBack">judgements1YrBack.</param>
        /// <param name="judgements2YrsBack">judgements2YrsBack.</param>
        /// <param name="judgementsMoreThen2YrsBack">judgementsMoreThen2YrsBack.</param>
        /// <param name="notices1YrBack">notices1YrBack.</param>
        /// <param name="notices2YrsBack">notices2YrsBack.</param>
        /// <param name="noticesMoreThen2YrsBack">noticesMoreThen2YrsBack.</param>
        /// <param name="defaults1YrBack">defaults1YrBack.</param>
        /// <param name="defaults2YrsBack">defaults2YrsBack.</param>
        /// <param name="defaultsMoreThen2YrsBack">defaultsMoreThen2YrsBack.</param>
        /// <param name="paymentProfiles1YrBack">paymentProfiles1YrBack.</param>
        /// <param name="paymentProfiles2YrsBack">paymentProfiles2YrsBack.</param>
        /// <param name="paymentProfilesMoreThen2YrsBack">paymentProfilesMoreThen2YrsBack.</param>
        /// <param name="traceAlerts1YrBack">traceAlerts1YrBack.</param>
        /// <param name="traceAlerts2YrsBack">traceAlerts2YrsBack.</param>
        /// <param name="traceAlertsMoreThen2YrsBack">traceAlertsMoreThen2YrsBack.</param>
        public TransunionConsumer118ConsumerCountersNC04(string consumerNo = default(string), string ownEnquiries1YrBack = default(string), string ownEnquiries2YrsBack = default(string), string ownEnquiriesMoreThen2YrsBack = default(string), string otherEnquiries1YrBack = default(string), string otherEnquiries2YrsBack = default(string), string otherEnquiriesMoreThen2YrsBack = default(string), string judgements1YrBack = default(string), string judgements2YrsBack = default(string), string judgementsMoreThen2YrsBack = default(string), string notices1YrBack = default(string), string notices2YrsBack = default(string), string noticesMoreThen2YrsBack = default(string), string defaults1YrBack = default(string), string defaults2YrsBack = default(string), string defaultsMoreThen2YrsBack = default(string), string paymentProfiles1YrBack = default(string), string paymentProfiles2YrsBack = default(string), string paymentProfilesMoreThen2YrsBack = default(string), string traceAlerts1YrBack = default(string), string traceAlerts2YrsBack = default(string), string traceAlertsMoreThen2YrsBack = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.OwnEnquiries1YrBack = ownEnquiries1YrBack;
            this.OwnEnquiries2YrsBack = ownEnquiries2YrsBack;
            this.OwnEnquiriesMoreThen2YrsBack = ownEnquiriesMoreThen2YrsBack;
            this.OtherEnquiries1YrBack = otherEnquiries1YrBack;
            this.OtherEnquiries2YrsBack = otherEnquiries2YrsBack;
            this.OtherEnquiriesMoreThen2YrsBack = otherEnquiriesMoreThen2YrsBack;
            this.Judgements1YrBack = judgements1YrBack;
            this.Judgements2YrsBack = judgements2YrsBack;
            this.JudgementsMoreThen2YrsBack = judgementsMoreThen2YrsBack;
            this.Notices1YrBack = notices1YrBack;
            this.Notices2YrsBack = notices2YrsBack;
            this.NoticesMoreThen2YrsBack = noticesMoreThen2YrsBack;
            this.Defaults1YrBack = defaults1YrBack;
            this.Defaults2YrsBack = defaults2YrsBack;
            this.DefaultsMoreThen2YrsBack = defaultsMoreThen2YrsBack;
            this.PaymentProfiles1YrBack = paymentProfiles1YrBack;
            this.PaymentProfiles2YrsBack = paymentProfiles2YrsBack;
            this.PaymentProfilesMoreThen2YrsBack = paymentProfilesMoreThen2YrsBack;
            this.TraceAlerts1YrBack = traceAlerts1YrBack;
            this.TraceAlerts2YrsBack = traceAlerts2YrsBack;
            this.TraceAlertsMoreThen2YrsBack = traceAlertsMoreThen2YrsBack;
            this.ConsumerNo = consumerNo;
            this.OwnEnquiries1YrBack = ownEnquiries1YrBack;
            this.OwnEnquiries2YrsBack = ownEnquiries2YrsBack;
            this.OwnEnquiriesMoreThen2YrsBack = ownEnquiriesMoreThen2YrsBack;
            this.OtherEnquiries1YrBack = otherEnquiries1YrBack;
            this.OtherEnquiries2YrsBack = otherEnquiries2YrsBack;
            this.OtherEnquiriesMoreThen2YrsBack = otherEnquiriesMoreThen2YrsBack;
            this.Judgements1YrBack = judgements1YrBack;
            this.Judgements2YrsBack = judgements2YrsBack;
            this.JudgementsMoreThen2YrsBack = judgementsMoreThen2YrsBack;
            this.Notices1YrBack = notices1YrBack;
            this.Notices2YrsBack = notices2YrsBack;
            this.NoticesMoreThen2YrsBack = noticesMoreThen2YrsBack;
            this.Defaults1YrBack = defaults1YrBack;
            this.Defaults2YrsBack = defaults2YrsBack;
            this.DefaultsMoreThen2YrsBack = defaultsMoreThen2YrsBack;
            this.PaymentProfiles1YrBack = paymentProfiles1YrBack;
            this.PaymentProfiles2YrsBack = paymentProfiles2YrsBack;
            this.PaymentProfilesMoreThen2YrsBack = paymentProfilesMoreThen2YrsBack;
            this.TraceAlerts1YrBack = traceAlerts1YrBack;
            this.TraceAlerts2YrsBack = traceAlerts2YrsBack;
            this.TraceAlertsMoreThen2YrsBack = traceAlertsMoreThen2YrsBack;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets OwnEnquiries1YrBack
        /// </summary>
        [DataMember(Name="ownEnquiries1YrBack", EmitDefaultValue=true)]
        public string OwnEnquiries1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets OwnEnquiries2YrsBack
        /// </summary>
        [DataMember(Name="ownEnquiries2YrsBack", EmitDefaultValue=true)]
        public string OwnEnquiries2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets OwnEnquiriesMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="ownEnquiriesMoreThen2YrsBack", EmitDefaultValue=true)]
        public string OwnEnquiriesMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets OtherEnquiries1YrBack
        /// </summary>
        [DataMember(Name="otherEnquiries1YrBack", EmitDefaultValue=true)]
        public string OtherEnquiries1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets OtherEnquiries2YrsBack
        /// </summary>
        [DataMember(Name="otherEnquiries2YrsBack", EmitDefaultValue=true)]
        public string OtherEnquiries2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets OtherEnquiriesMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="otherEnquiriesMoreThen2YrsBack", EmitDefaultValue=true)]
        public string OtherEnquiriesMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets Judgements1YrBack
        /// </summary>
        [DataMember(Name="judgements1YrBack", EmitDefaultValue=true)]
        public string Judgements1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets Judgements2YrsBack
        /// </summary>
        [DataMember(Name="judgements2YrsBack", EmitDefaultValue=true)]
        public string Judgements2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets JudgementsMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="judgementsMoreThen2YrsBack", EmitDefaultValue=true)]
        public string JudgementsMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets Notices1YrBack
        /// </summary>
        [DataMember(Name="notices1YrBack", EmitDefaultValue=true)]
        public string Notices1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets Notices2YrsBack
        /// </summary>
        [DataMember(Name="notices2YrsBack", EmitDefaultValue=true)]
        public string Notices2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets NoticesMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="noticesMoreThen2YrsBack", EmitDefaultValue=true)]
        public string NoticesMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets Defaults1YrBack
        /// </summary>
        [DataMember(Name="defaults1YrBack", EmitDefaultValue=true)]
        public string Defaults1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets Defaults2YrsBack
        /// </summary>
        [DataMember(Name="defaults2YrsBack", EmitDefaultValue=true)]
        public string Defaults2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets DefaultsMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="defaultsMoreThen2YrsBack", EmitDefaultValue=true)]
        public string DefaultsMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets PaymentProfiles1YrBack
        /// </summary>
        [DataMember(Name="paymentProfiles1YrBack", EmitDefaultValue=true)]
        public string PaymentProfiles1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets PaymentProfiles2YrsBack
        /// </summary>
        [DataMember(Name="paymentProfiles2YrsBack", EmitDefaultValue=true)]
        public string PaymentProfiles2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets PaymentProfilesMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="paymentProfilesMoreThen2YrsBack", EmitDefaultValue=true)]
        public string PaymentProfilesMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets TraceAlerts1YrBack
        /// </summary>
        [DataMember(Name="traceAlerts1YrBack", EmitDefaultValue=true)]
        public string TraceAlerts1YrBack { get; set; }

        /// <summary>
        /// Gets or Sets TraceAlerts2YrsBack
        /// </summary>
        [DataMember(Name="traceAlerts2YrsBack", EmitDefaultValue=true)]
        public string TraceAlerts2YrsBack { get; set; }

        /// <summary>
        /// Gets or Sets TraceAlertsMoreThen2YrsBack
        /// </summary>
        [DataMember(Name="traceAlertsMoreThen2YrsBack", EmitDefaultValue=true)]
        public string TraceAlertsMoreThen2YrsBack { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ConsumerCountersNC04 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  OwnEnquiries1YrBack: ").Append(OwnEnquiries1YrBack).Append("\n");
            sb.Append("  OwnEnquiries2YrsBack: ").Append(OwnEnquiries2YrsBack).Append("\n");
            sb.Append("  OwnEnquiriesMoreThen2YrsBack: ").Append(OwnEnquiriesMoreThen2YrsBack).Append("\n");
            sb.Append("  OtherEnquiries1YrBack: ").Append(OtherEnquiries1YrBack).Append("\n");
            sb.Append("  OtherEnquiries2YrsBack: ").Append(OtherEnquiries2YrsBack).Append("\n");
            sb.Append("  OtherEnquiriesMoreThen2YrsBack: ").Append(OtherEnquiriesMoreThen2YrsBack).Append("\n");
            sb.Append("  Judgements1YrBack: ").Append(Judgements1YrBack).Append("\n");
            sb.Append("  Judgements2YrsBack: ").Append(Judgements2YrsBack).Append("\n");
            sb.Append("  JudgementsMoreThen2YrsBack: ").Append(JudgementsMoreThen2YrsBack).Append("\n");
            sb.Append("  Notices1YrBack: ").Append(Notices1YrBack).Append("\n");
            sb.Append("  Notices2YrsBack: ").Append(Notices2YrsBack).Append("\n");
            sb.Append("  NoticesMoreThen2YrsBack: ").Append(NoticesMoreThen2YrsBack).Append("\n");
            sb.Append("  Defaults1YrBack: ").Append(Defaults1YrBack).Append("\n");
            sb.Append("  Defaults2YrsBack: ").Append(Defaults2YrsBack).Append("\n");
            sb.Append("  DefaultsMoreThen2YrsBack: ").Append(DefaultsMoreThen2YrsBack).Append("\n");
            sb.Append("  PaymentProfiles1YrBack: ").Append(PaymentProfiles1YrBack).Append("\n");
            sb.Append("  PaymentProfiles2YrsBack: ").Append(PaymentProfiles2YrsBack).Append("\n");
            sb.Append("  PaymentProfilesMoreThen2YrsBack: ").Append(PaymentProfilesMoreThen2YrsBack).Append("\n");
            sb.Append("  TraceAlerts1YrBack: ").Append(TraceAlerts1YrBack).Append("\n");
            sb.Append("  TraceAlerts2YrsBack: ").Append(TraceAlerts2YrsBack).Append("\n");
            sb.Append("  TraceAlertsMoreThen2YrsBack: ").Append(TraceAlertsMoreThen2YrsBack).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ConsumerCountersNC04);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ConsumerCountersNC04 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ConsumerCountersNC04 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ConsumerCountersNC04 input)
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
                    this.OwnEnquiries1YrBack == input.OwnEnquiries1YrBack ||
                    (this.OwnEnquiries1YrBack != null &&
                    this.OwnEnquiries1YrBack.Equals(input.OwnEnquiries1YrBack))
                ) && 
                (
                    this.OwnEnquiries2YrsBack == input.OwnEnquiries2YrsBack ||
                    (this.OwnEnquiries2YrsBack != null &&
                    this.OwnEnquiries2YrsBack.Equals(input.OwnEnquiries2YrsBack))
                ) && 
                (
                    this.OwnEnquiriesMoreThen2YrsBack == input.OwnEnquiriesMoreThen2YrsBack ||
                    (this.OwnEnquiriesMoreThen2YrsBack != null &&
                    this.OwnEnquiriesMoreThen2YrsBack.Equals(input.OwnEnquiriesMoreThen2YrsBack))
                ) && 
                (
                    this.OtherEnquiries1YrBack == input.OtherEnquiries1YrBack ||
                    (this.OtherEnquiries1YrBack != null &&
                    this.OtherEnquiries1YrBack.Equals(input.OtherEnquiries1YrBack))
                ) && 
                (
                    this.OtherEnquiries2YrsBack == input.OtherEnquiries2YrsBack ||
                    (this.OtherEnquiries2YrsBack != null &&
                    this.OtherEnquiries2YrsBack.Equals(input.OtherEnquiries2YrsBack))
                ) && 
                (
                    this.OtherEnquiriesMoreThen2YrsBack == input.OtherEnquiriesMoreThen2YrsBack ||
                    (this.OtherEnquiriesMoreThen2YrsBack != null &&
                    this.OtherEnquiriesMoreThen2YrsBack.Equals(input.OtherEnquiriesMoreThen2YrsBack))
                ) && 
                (
                    this.Judgements1YrBack == input.Judgements1YrBack ||
                    (this.Judgements1YrBack != null &&
                    this.Judgements1YrBack.Equals(input.Judgements1YrBack))
                ) && 
                (
                    this.Judgements2YrsBack == input.Judgements2YrsBack ||
                    (this.Judgements2YrsBack != null &&
                    this.Judgements2YrsBack.Equals(input.Judgements2YrsBack))
                ) && 
                (
                    this.JudgementsMoreThen2YrsBack == input.JudgementsMoreThen2YrsBack ||
                    (this.JudgementsMoreThen2YrsBack != null &&
                    this.JudgementsMoreThen2YrsBack.Equals(input.JudgementsMoreThen2YrsBack))
                ) && 
                (
                    this.Notices1YrBack == input.Notices1YrBack ||
                    (this.Notices1YrBack != null &&
                    this.Notices1YrBack.Equals(input.Notices1YrBack))
                ) && 
                (
                    this.Notices2YrsBack == input.Notices2YrsBack ||
                    (this.Notices2YrsBack != null &&
                    this.Notices2YrsBack.Equals(input.Notices2YrsBack))
                ) && 
                (
                    this.NoticesMoreThen2YrsBack == input.NoticesMoreThen2YrsBack ||
                    (this.NoticesMoreThen2YrsBack != null &&
                    this.NoticesMoreThen2YrsBack.Equals(input.NoticesMoreThen2YrsBack))
                ) && 
                (
                    this.Defaults1YrBack == input.Defaults1YrBack ||
                    (this.Defaults1YrBack != null &&
                    this.Defaults1YrBack.Equals(input.Defaults1YrBack))
                ) && 
                (
                    this.Defaults2YrsBack == input.Defaults2YrsBack ||
                    (this.Defaults2YrsBack != null &&
                    this.Defaults2YrsBack.Equals(input.Defaults2YrsBack))
                ) && 
                (
                    this.DefaultsMoreThen2YrsBack == input.DefaultsMoreThen2YrsBack ||
                    (this.DefaultsMoreThen2YrsBack != null &&
                    this.DefaultsMoreThen2YrsBack.Equals(input.DefaultsMoreThen2YrsBack))
                ) && 
                (
                    this.PaymentProfiles1YrBack == input.PaymentProfiles1YrBack ||
                    (this.PaymentProfiles1YrBack != null &&
                    this.PaymentProfiles1YrBack.Equals(input.PaymentProfiles1YrBack))
                ) && 
                (
                    this.PaymentProfiles2YrsBack == input.PaymentProfiles2YrsBack ||
                    (this.PaymentProfiles2YrsBack != null &&
                    this.PaymentProfiles2YrsBack.Equals(input.PaymentProfiles2YrsBack))
                ) && 
                (
                    this.PaymentProfilesMoreThen2YrsBack == input.PaymentProfilesMoreThen2YrsBack ||
                    (this.PaymentProfilesMoreThen2YrsBack != null &&
                    this.PaymentProfilesMoreThen2YrsBack.Equals(input.PaymentProfilesMoreThen2YrsBack))
                ) && 
                (
                    this.TraceAlerts1YrBack == input.TraceAlerts1YrBack ||
                    (this.TraceAlerts1YrBack != null &&
                    this.TraceAlerts1YrBack.Equals(input.TraceAlerts1YrBack))
                ) && 
                (
                    this.TraceAlerts2YrsBack == input.TraceAlerts2YrsBack ||
                    (this.TraceAlerts2YrsBack != null &&
                    this.TraceAlerts2YrsBack.Equals(input.TraceAlerts2YrsBack))
                ) && 
                (
                    this.TraceAlertsMoreThen2YrsBack == input.TraceAlertsMoreThen2YrsBack ||
                    (this.TraceAlertsMoreThen2YrsBack != null &&
                    this.TraceAlertsMoreThen2YrsBack.Equals(input.TraceAlertsMoreThen2YrsBack))
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
                if (this.OwnEnquiries1YrBack != null)
                    hashCode = hashCode * 59 + this.OwnEnquiries1YrBack.GetHashCode();
                if (this.OwnEnquiries2YrsBack != null)
                    hashCode = hashCode * 59 + this.OwnEnquiries2YrsBack.GetHashCode();
                if (this.OwnEnquiriesMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.OwnEnquiriesMoreThen2YrsBack.GetHashCode();
                if (this.OtherEnquiries1YrBack != null)
                    hashCode = hashCode * 59 + this.OtherEnquiries1YrBack.GetHashCode();
                if (this.OtherEnquiries2YrsBack != null)
                    hashCode = hashCode * 59 + this.OtherEnquiries2YrsBack.GetHashCode();
                if (this.OtherEnquiriesMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.OtherEnquiriesMoreThen2YrsBack.GetHashCode();
                if (this.Judgements1YrBack != null)
                    hashCode = hashCode * 59 + this.Judgements1YrBack.GetHashCode();
                if (this.Judgements2YrsBack != null)
                    hashCode = hashCode * 59 + this.Judgements2YrsBack.GetHashCode();
                if (this.JudgementsMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.JudgementsMoreThen2YrsBack.GetHashCode();
                if (this.Notices1YrBack != null)
                    hashCode = hashCode * 59 + this.Notices1YrBack.GetHashCode();
                if (this.Notices2YrsBack != null)
                    hashCode = hashCode * 59 + this.Notices2YrsBack.GetHashCode();
                if (this.NoticesMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.NoticesMoreThen2YrsBack.GetHashCode();
                if (this.Defaults1YrBack != null)
                    hashCode = hashCode * 59 + this.Defaults1YrBack.GetHashCode();
                if (this.Defaults2YrsBack != null)
                    hashCode = hashCode * 59 + this.Defaults2YrsBack.GetHashCode();
                if (this.DefaultsMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.DefaultsMoreThen2YrsBack.GetHashCode();
                if (this.PaymentProfiles1YrBack != null)
                    hashCode = hashCode * 59 + this.PaymentProfiles1YrBack.GetHashCode();
                if (this.PaymentProfiles2YrsBack != null)
                    hashCode = hashCode * 59 + this.PaymentProfiles2YrsBack.GetHashCode();
                if (this.PaymentProfilesMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.PaymentProfilesMoreThen2YrsBack.GetHashCode();
                if (this.TraceAlerts1YrBack != null)
                    hashCode = hashCode * 59 + this.TraceAlerts1YrBack.GetHashCode();
                if (this.TraceAlerts2YrsBack != null)
                    hashCode = hashCode * 59 + this.TraceAlerts2YrsBack.GetHashCode();
                if (this.TraceAlertsMoreThen2YrsBack != null)
                    hashCode = hashCode * 59 + this.TraceAlertsMoreThen2YrsBack.GetHashCode();
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
