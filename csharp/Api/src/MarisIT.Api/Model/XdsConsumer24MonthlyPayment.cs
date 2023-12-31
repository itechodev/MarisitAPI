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
    /// XdsConsumer24MonthlyPayment
    /// </summary>
    [DataContract]
    public partial class XdsConsumer24MonthlyPayment :  IEquatable<XdsConsumer24MonthlyPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumer24MonthlyPayment" /> class.
        /// </summary>
        /// <param name="accountNo">accountNo.</param>
        /// <param name="accountOpenedDate">accountOpenedDate.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="m01">m01.</param>
        /// <param name="m02">m02.</param>
        /// <param name="m03">m03.</param>
        /// <param name="m04">m04.</param>
        /// <param name="m05">m05.</param>
        /// <param name="m06">m06.</param>
        /// <param name="m07">m07.</param>
        /// <param name="m08">m08.</param>
        /// <param name="m09">m09.</param>
        /// <param name="m10">m10.</param>
        /// <param name="m11">m11.</param>
        /// <param name="m12">m12.</param>
        /// <param name="m13">m13.</param>
        /// <param name="m14">m14.</param>
        /// <param name="m15">m15.</param>
        /// <param name="m16">m16.</param>
        /// <param name="m17">m17.</param>
        /// <param name="m18">m18.</param>
        /// <param name="m19">m19.</param>
        /// <param name="m20">m20.</param>
        /// <param name="m21">m21.</param>
        /// <param name="m22">m22.</param>
        /// <param name="m23">m23.</param>
        /// <param name="m24">m24.</param>
        /// <param name="subAccountNo">subAccountNo.</param>
        /// <param name="subscriberName">subscriberName.</param>
        public XdsConsumer24MonthlyPayment(string accountNo = default(string), string accountOpenedDate = default(string), string displayText = default(string), string m01 = default(string), string m02 = default(string), string m03 = default(string), string m04 = default(string), string m05 = default(string), string m06 = default(string), string m07 = default(string), string m08 = default(string), string m09 = default(string), string m10 = default(string), string m11 = default(string), string m12 = default(string), string m13 = default(string), string m14 = default(string), string m15 = default(string), string m16 = default(string), string m17 = default(string), string m18 = default(string), string m19 = default(string), string m20 = default(string), string m21 = default(string), string m22 = default(string), string m23 = default(string), string m24 = default(string), string subAccountNo = default(string), string subscriberName = default(string))
        {
            this.AccountNo = accountNo;
            this.AccountOpenedDate = accountOpenedDate;
            this.DisplayText = displayText;
            this.M01 = m01;
            this.M02 = m02;
            this.M03 = m03;
            this.M04 = m04;
            this.M05 = m05;
            this.M06 = m06;
            this.M07 = m07;
            this.M08 = m08;
            this.M09 = m09;
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.M13 = m13;
            this.M14 = m14;
            this.M15 = m15;
            this.M16 = m16;
            this.M17 = m17;
            this.M18 = m18;
            this.M19 = m19;
            this.M20 = m20;
            this.M21 = m21;
            this.M22 = m22;
            this.M23 = m23;
            this.M24 = m24;
            this.SubAccountNo = subAccountNo;
            this.SubscriberName = subscriberName;
            this.AccountNo = accountNo;
            this.AccountOpenedDate = accountOpenedDate;
            this.DisplayText = displayText;
            this.M01 = m01;
            this.M02 = m02;
            this.M03 = m03;
            this.M04 = m04;
            this.M05 = m05;
            this.M06 = m06;
            this.M07 = m07;
            this.M08 = m08;
            this.M09 = m09;
            this.M10 = m10;
            this.M11 = m11;
            this.M12 = m12;
            this.M13 = m13;
            this.M14 = m14;
            this.M15 = m15;
            this.M16 = m16;
            this.M17 = m17;
            this.M18 = m18;
            this.M19 = m19;
            this.M20 = m20;
            this.M21 = m21;
            this.M22 = m22;
            this.M23 = m23;
            this.M24 = m24;
            this.SubAccountNo = subAccountNo;
            this.SubscriberName = subscriberName;
        }

        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=true)]
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or Sets AccountOpenedDate
        /// </summary>
        [DataMember(Name="accountOpenedDate", EmitDefaultValue=true)]
        public string AccountOpenedDate { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets M01
        /// </summary>
        [DataMember(Name="m01", EmitDefaultValue=true)]
        public string M01 { get; set; }

        /// <summary>
        /// Gets or Sets M02
        /// </summary>
        [DataMember(Name="m02", EmitDefaultValue=true)]
        public string M02 { get; set; }

        /// <summary>
        /// Gets or Sets M03
        /// </summary>
        [DataMember(Name="m03", EmitDefaultValue=true)]
        public string M03 { get; set; }

        /// <summary>
        /// Gets or Sets M04
        /// </summary>
        [DataMember(Name="m04", EmitDefaultValue=true)]
        public string M04 { get; set; }

        /// <summary>
        /// Gets or Sets M05
        /// </summary>
        [DataMember(Name="m05", EmitDefaultValue=true)]
        public string M05 { get; set; }

        /// <summary>
        /// Gets or Sets M06
        /// </summary>
        [DataMember(Name="m06", EmitDefaultValue=true)]
        public string M06 { get; set; }

        /// <summary>
        /// Gets or Sets M07
        /// </summary>
        [DataMember(Name="m07", EmitDefaultValue=true)]
        public string M07 { get; set; }

        /// <summary>
        /// Gets or Sets M08
        /// </summary>
        [DataMember(Name="m08", EmitDefaultValue=true)]
        public string M08 { get; set; }

        /// <summary>
        /// Gets or Sets M09
        /// </summary>
        [DataMember(Name="m09", EmitDefaultValue=true)]
        public string M09 { get; set; }

        /// <summary>
        /// Gets or Sets M10
        /// </summary>
        [DataMember(Name="m10", EmitDefaultValue=true)]
        public string M10 { get; set; }

        /// <summary>
        /// Gets or Sets M11
        /// </summary>
        [DataMember(Name="m11", EmitDefaultValue=true)]
        public string M11 { get; set; }

        /// <summary>
        /// Gets or Sets M12
        /// </summary>
        [DataMember(Name="m12", EmitDefaultValue=true)]
        public string M12 { get; set; }

        /// <summary>
        /// Gets or Sets M13
        /// </summary>
        [DataMember(Name="m13", EmitDefaultValue=true)]
        public string M13 { get; set; }

        /// <summary>
        /// Gets or Sets M14
        /// </summary>
        [DataMember(Name="m14", EmitDefaultValue=true)]
        public string M14 { get; set; }

        /// <summary>
        /// Gets or Sets M15
        /// </summary>
        [DataMember(Name="m15", EmitDefaultValue=true)]
        public string M15 { get; set; }

        /// <summary>
        /// Gets or Sets M16
        /// </summary>
        [DataMember(Name="m16", EmitDefaultValue=true)]
        public string M16 { get; set; }

        /// <summary>
        /// Gets or Sets M17
        /// </summary>
        [DataMember(Name="m17", EmitDefaultValue=true)]
        public string M17 { get; set; }

        /// <summary>
        /// Gets or Sets M18
        /// </summary>
        [DataMember(Name="m18", EmitDefaultValue=true)]
        public string M18 { get; set; }

        /// <summary>
        /// Gets or Sets M19
        /// </summary>
        [DataMember(Name="m19", EmitDefaultValue=true)]
        public string M19 { get; set; }

        /// <summary>
        /// Gets or Sets M20
        /// </summary>
        [DataMember(Name="m20", EmitDefaultValue=true)]
        public string M20 { get; set; }

        /// <summary>
        /// Gets or Sets M21
        /// </summary>
        [DataMember(Name="m21", EmitDefaultValue=true)]
        public string M21 { get; set; }

        /// <summary>
        /// Gets or Sets M22
        /// </summary>
        [DataMember(Name="m22", EmitDefaultValue=true)]
        public string M22 { get; set; }

        /// <summary>
        /// Gets or Sets M23
        /// </summary>
        [DataMember(Name="m23", EmitDefaultValue=true)]
        public string M23 { get; set; }

        /// <summary>
        /// Gets or Sets M24
        /// </summary>
        [DataMember(Name="m24", EmitDefaultValue=true)]
        public string M24 { get; set; }

        /// <summary>
        /// Gets or Sets SubAccountNo
        /// </summary>
        [DataMember(Name="subAccountNo", EmitDefaultValue=true)]
        public string SubAccountNo { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberName
        /// </summary>
        [DataMember(Name="subscriberName", EmitDefaultValue=true)]
        public string SubscriberName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumer24MonthlyPayment {\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  AccountOpenedDate: ").Append(AccountOpenedDate).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  M01: ").Append(M01).Append("\n");
            sb.Append("  M02: ").Append(M02).Append("\n");
            sb.Append("  M03: ").Append(M03).Append("\n");
            sb.Append("  M04: ").Append(M04).Append("\n");
            sb.Append("  M05: ").Append(M05).Append("\n");
            sb.Append("  M06: ").Append(M06).Append("\n");
            sb.Append("  M07: ").Append(M07).Append("\n");
            sb.Append("  M08: ").Append(M08).Append("\n");
            sb.Append("  M09: ").Append(M09).Append("\n");
            sb.Append("  M10: ").Append(M10).Append("\n");
            sb.Append("  M11: ").Append(M11).Append("\n");
            sb.Append("  M12: ").Append(M12).Append("\n");
            sb.Append("  M13: ").Append(M13).Append("\n");
            sb.Append("  M14: ").Append(M14).Append("\n");
            sb.Append("  M15: ").Append(M15).Append("\n");
            sb.Append("  M16: ").Append(M16).Append("\n");
            sb.Append("  M17: ").Append(M17).Append("\n");
            sb.Append("  M18: ").Append(M18).Append("\n");
            sb.Append("  M19: ").Append(M19).Append("\n");
            sb.Append("  M20: ").Append(M20).Append("\n");
            sb.Append("  M21: ").Append(M21).Append("\n");
            sb.Append("  M22: ").Append(M22).Append("\n");
            sb.Append("  M23: ").Append(M23).Append("\n");
            sb.Append("  M24: ").Append(M24).Append("\n");
            sb.Append("  SubAccountNo: ").Append(SubAccountNo).Append("\n");
            sb.Append("  SubscriberName: ").Append(SubscriberName).Append("\n");
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
            return this.Equals(input as XdsConsumer24MonthlyPayment);
        }

        /// <summary>
        /// Returns true if XdsConsumer24MonthlyPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumer24MonthlyPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumer24MonthlyPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountNo == input.AccountNo ||
                    (this.AccountNo != null &&
                    this.AccountNo.Equals(input.AccountNo))
                ) && 
                (
                    this.AccountOpenedDate == input.AccountOpenedDate ||
                    (this.AccountOpenedDate != null &&
                    this.AccountOpenedDate.Equals(input.AccountOpenedDate))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.M01 == input.M01 ||
                    (this.M01 != null &&
                    this.M01.Equals(input.M01))
                ) && 
                (
                    this.M02 == input.M02 ||
                    (this.M02 != null &&
                    this.M02.Equals(input.M02))
                ) && 
                (
                    this.M03 == input.M03 ||
                    (this.M03 != null &&
                    this.M03.Equals(input.M03))
                ) && 
                (
                    this.M04 == input.M04 ||
                    (this.M04 != null &&
                    this.M04.Equals(input.M04))
                ) && 
                (
                    this.M05 == input.M05 ||
                    (this.M05 != null &&
                    this.M05.Equals(input.M05))
                ) && 
                (
                    this.M06 == input.M06 ||
                    (this.M06 != null &&
                    this.M06.Equals(input.M06))
                ) && 
                (
                    this.M07 == input.M07 ||
                    (this.M07 != null &&
                    this.M07.Equals(input.M07))
                ) && 
                (
                    this.M08 == input.M08 ||
                    (this.M08 != null &&
                    this.M08.Equals(input.M08))
                ) && 
                (
                    this.M09 == input.M09 ||
                    (this.M09 != null &&
                    this.M09.Equals(input.M09))
                ) && 
                (
                    this.M10 == input.M10 ||
                    (this.M10 != null &&
                    this.M10.Equals(input.M10))
                ) && 
                (
                    this.M11 == input.M11 ||
                    (this.M11 != null &&
                    this.M11.Equals(input.M11))
                ) && 
                (
                    this.M12 == input.M12 ||
                    (this.M12 != null &&
                    this.M12.Equals(input.M12))
                ) && 
                (
                    this.M13 == input.M13 ||
                    (this.M13 != null &&
                    this.M13.Equals(input.M13))
                ) && 
                (
                    this.M14 == input.M14 ||
                    (this.M14 != null &&
                    this.M14.Equals(input.M14))
                ) && 
                (
                    this.M15 == input.M15 ||
                    (this.M15 != null &&
                    this.M15.Equals(input.M15))
                ) && 
                (
                    this.M16 == input.M16 ||
                    (this.M16 != null &&
                    this.M16.Equals(input.M16))
                ) && 
                (
                    this.M17 == input.M17 ||
                    (this.M17 != null &&
                    this.M17.Equals(input.M17))
                ) && 
                (
                    this.M18 == input.M18 ||
                    (this.M18 != null &&
                    this.M18.Equals(input.M18))
                ) && 
                (
                    this.M19 == input.M19 ||
                    (this.M19 != null &&
                    this.M19.Equals(input.M19))
                ) && 
                (
                    this.M20 == input.M20 ||
                    (this.M20 != null &&
                    this.M20.Equals(input.M20))
                ) && 
                (
                    this.M21 == input.M21 ||
                    (this.M21 != null &&
                    this.M21.Equals(input.M21))
                ) && 
                (
                    this.M22 == input.M22 ||
                    (this.M22 != null &&
                    this.M22.Equals(input.M22))
                ) && 
                (
                    this.M23 == input.M23 ||
                    (this.M23 != null &&
                    this.M23.Equals(input.M23))
                ) && 
                (
                    this.M24 == input.M24 ||
                    (this.M24 != null &&
                    this.M24.Equals(input.M24))
                ) && 
                (
                    this.SubAccountNo == input.SubAccountNo ||
                    (this.SubAccountNo != null &&
                    this.SubAccountNo.Equals(input.SubAccountNo))
                ) && 
                (
                    this.SubscriberName == input.SubscriberName ||
                    (this.SubscriberName != null &&
                    this.SubscriberName.Equals(input.SubscriberName))
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
                if (this.AccountNo != null)
                    hashCode = hashCode * 59 + this.AccountNo.GetHashCode();
                if (this.AccountOpenedDate != null)
                    hashCode = hashCode * 59 + this.AccountOpenedDate.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.M01 != null)
                    hashCode = hashCode * 59 + this.M01.GetHashCode();
                if (this.M02 != null)
                    hashCode = hashCode * 59 + this.M02.GetHashCode();
                if (this.M03 != null)
                    hashCode = hashCode * 59 + this.M03.GetHashCode();
                if (this.M04 != null)
                    hashCode = hashCode * 59 + this.M04.GetHashCode();
                if (this.M05 != null)
                    hashCode = hashCode * 59 + this.M05.GetHashCode();
                if (this.M06 != null)
                    hashCode = hashCode * 59 + this.M06.GetHashCode();
                if (this.M07 != null)
                    hashCode = hashCode * 59 + this.M07.GetHashCode();
                if (this.M08 != null)
                    hashCode = hashCode * 59 + this.M08.GetHashCode();
                if (this.M09 != null)
                    hashCode = hashCode * 59 + this.M09.GetHashCode();
                if (this.M10 != null)
                    hashCode = hashCode * 59 + this.M10.GetHashCode();
                if (this.M11 != null)
                    hashCode = hashCode * 59 + this.M11.GetHashCode();
                if (this.M12 != null)
                    hashCode = hashCode * 59 + this.M12.GetHashCode();
                if (this.M13 != null)
                    hashCode = hashCode * 59 + this.M13.GetHashCode();
                if (this.M14 != null)
                    hashCode = hashCode * 59 + this.M14.GetHashCode();
                if (this.M15 != null)
                    hashCode = hashCode * 59 + this.M15.GetHashCode();
                if (this.M16 != null)
                    hashCode = hashCode * 59 + this.M16.GetHashCode();
                if (this.M17 != null)
                    hashCode = hashCode * 59 + this.M17.GetHashCode();
                if (this.M18 != null)
                    hashCode = hashCode * 59 + this.M18.GetHashCode();
                if (this.M19 != null)
                    hashCode = hashCode * 59 + this.M19.GetHashCode();
                if (this.M20 != null)
                    hashCode = hashCode * 59 + this.M20.GetHashCode();
                if (this.M21 != null)
                    hashCode = hashCode * 59 + this.M21.GetHashCode();
                if (this.M22 != null)
                    hashCode = hashCode * 59 + this.M22.GetHashCode();
                if (this.M23 != null)
                    hashCode = hashCode * 59 + this.M23.GetHashCode();
                if (this.M24 != null)
                    hashCode = hashCode * 59 + this.M24.GetHashCode();
                if (this.SubAccountNo != null)
                    hashCode = hashCode * 59 + this.SubAccountNo.GetHashCode();
                if (this.SubscriberName != null)
                    hashCode = hashCode * 59 + this.SubscriberName.GetHashCode();
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
