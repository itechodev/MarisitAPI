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
    /// XdsConsumerAccountStatus
    /// </summary>
    [DataContract]
    public partial class XdsConsumerAccountStatus :  IEquatable<XdsConsumerAccountStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumerAccountStatus" /> class.
        /// </summary>
        /// <param name="accountNo">accountNo.</param>
        /// <param name="accountOpenedDate">accountOpenedDate.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="arrearsAmt">arrearsAmt.</param>
        /// <param name="arrearsTypeInd">arrearsTypeInd.</param>
        /// <param name="consumerAccountID">consumerAccountID.</param>
        /// <param name="creditLimitAmt">creditLimitAmt.</param>
        /// <param name="currentBalanceAmt">currentBalanceAmt.</param>
        /// <param name="deferredPaymentDate">deferredPaymentDate.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="lastPaymentDate">lastPaymentDate.</param>
        /// <param name="monthlyInstalmentAmt">monthlyInstalmentAmt.</param>
        /// <param name="statusCodeDesc">statusCodeDesc.</param>
        /// <param name="subAccountNo">subAccountNo.</param>
        /// <param name="subscriberID">subscriberID.</param>
        /// <param name="subscriberName">subscriberName.</param>
        /// <param name="thirdPartyName">thirdPartyName.</param>
        public XdsConsumerAccountStatus(string accountNo = default(string), string accountOpenedDate = default(string), string accountType = default(string), string arrearsAmt = default(string), string arrearsTypeInd = default(string), string consumerAccountID = default(string), string creditLimitAmt = default(string), string currentBalanceAmt = default(string), string deferredPaymentDate = default(string), string displayText = default(string), string lastPaymentDate = default(string), string monthlyInstalmentAmt = default(string), string statusCodeDesc = default(string), string subAccountNo = default(string), string subscriberID = default(string), string subscriberName = default(string), string thirdPartyName = default(string))
        {
            this.AccountNo = accountNo;
            this.AccountOpenedDate = accountOpenedDate;
            this.AccountType = accountType;
            this.ArrearsAmt = arrearsAmt;
            this.ArrearsTypeInd = arrearsTypeInd;
            this.ConsumerAccountID = consumerAccountID;
            this.CreditLimitAmt = creditLimitAmt;
            this.CurrentBalanceAmt = currentBalanceAmt;
            this.DeferredPaymentDate = deferredPaymentDate;
            this.DisplayText = displayText;
            this.LastPaymentDate = lastPaymentDate;
            this.MonthlyInstalmentAmt = monthlyInstalmentAmt;
            this.StatusCodeDesc = statusCodeDesc;
            this.SubAccountNo = subAccountNo;
            this.SubscriberID = subscriberID;
            this.SubscriberName = subscriberName;
            this.ThirdPartyName = thirdPartyName;
            this.AccountNo = accountNo;
            this.AccountOpenedDate = accountOpenedDate;
            this.AccountType = accountType;
            this.ArrearsAmt = arrearsAmt;
            this.ArrearsTypeInd = arrearsTypeInd;
            this.ConsumerAccountID = consumerAccountID;
            this.CreditLimitAmt = creditLimitAmt;
            this.CurrentBalanceAmt = currentBalanceAmt;
            this.DeferredPaymentDate = deferredPaymentDate;
            this.DisplayText = displayText;
            this.LastPaymentDate = lastPaymentDate;
            this.MonthlyInstalmentAmt = monthlyInstalmentAmt;
            this.StatusCodeDesc = statusCodeDesc;
            this.SubAccountNo = subAccountNo;
            this.SubscriberID = subscriberID;
            this.SubscriberName = subscriberName;
            this.ThirdPartyName = thirdPartyName;
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
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=true)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets ArrearsAmt
        /// </summary>
        [DataMember(Name="arrearsAmt", EmitDefaultValue=true)]
        public string ArrearsAmt { get; set; }

        /// <summary>
        /// Gets or Sets ArrearsTypeInd
        /// </summary>
        [DataMember(Name="arrearsTypeInd", EmitDefaultValue=true)]
        public string ArrearsTypeInd { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerAccountID
        /// </summary>
        [DataMember(Name="consumerAccountID", EmitDefaultValue=true)]
        public string ConsumerAccountID { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimitAmt
        /// </summary>
        [DataMember(Name="creditLimitAmt", EmitDefaultValue=true)]
        public string CreditLimitAmt { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBalanceAmt
        /// </summary>
        [DataMember(Name="currentBalanceAmt", EmitDefaultValue=true)]
        public string CurrentBalanceAmt { get; set; }

        /// <summary>
        /// Gets or Sets DeferredPaymentDate
        /// </summary>
        [DataMember(Name="deferredPaymentDate", EmitDefaultValue=true)]
        public string DeferredPaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets LastPaymentDate
        /// </summary>
        [DataMember(Name="lastPaymentDate", EmitDefaultValue=true)]
        public string LastPaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstalmentAmt
        /// </summary>
        [DataMember(Name="monthlyInstalmentAmt", EmitDefaultValue=true)]
        public string MonthlyInstalmentAmt { get; set; }

        /// <summary>
        /// Gets or Sets StatusCodeDesc
        /// </summary>
        [DataMember(Name="statusCodeDesc", EmitDefaultValue=true)]
        public string StatusCodeDesc { get; set; }

        /// <summary>
        /// Gets or Sets SubAccountNo
        /// </summary>
        [DataMember(Name="subAccountNo", EmitDefaultValue=true)]
        public string SubAccountNo { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberID
        /// </summary>
        [DataMember(Name="subscriberID", EmitDefaultValue=true)]
        public string SubscriberID { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberName
        /// </summary>
        [DataMember(Name="subscriberName", EmitDefaultValue=true)]
        public string SubscriberName { get; set; }

        /// <summary>
        /// Gets or Sets ThirdPartyName
        /// </summary>
        [DataMember(Name="thirdPartyName", EmitDefaultValue=true)]
        public string ThirdPartyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumerAccountStatus {\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  AccountOpenedDate: ").Append(AccountOpenedDate).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  ArrearsAmt: ").Append(ArrearsAmt).Append("\n");
            sb.Append("  ArrearsTypeInd: ").Append(ArrearsTypeInd).Append("\n");
            sb.Append("  ConsumerAccountID: ").Append(ConsumerAccountID).Append("\n");
            sb.Append("  CreditLimitAmt: ").Append(CreditLimitAmt).Append("\n");
            sb.Append("  CurrentBalanceAmt: ").Append(CurrentBalanceAmt).Append("\n");
            sb.Append("  DeferredPaymentDate: ").Append(DeferredPaymentDate).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  LastPaymentDate: ").Append(LastPaymentDate).Append("\n");
            sb.Append("  MonthlyInstalmentAmt: ").Append(MonthlyInstalmentAmt).Append("\n");
            sb.Append("  StatusCodeDesc: ").Append(StatusCodeDesc).Append("\n");
            sb.Append("  SubAccountNo: ").Append(SubAccountNo).Append("\n");
            sb.Append("  SubscriberID: ").Append(SubscriberID).Append("\n");
            sb.Append("  SubscriberName: ").Append(SubscriberName).Append("\n");
            sb.Append("  ThirdPartyName: ").Append(ThirdPartyName).Append("\n");
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
            return this.Equals(input as XdsConsumerAccountStatus);
        }

        /// <summary>
        /// Returns true if XdsConsumerAccountStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumerAccountStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumerAccountStatus input)
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
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.ArrearsAmt == input.ArrearsAmt ||
                    (this.ArrearsAmt != null &&
                    this.ArrearsAmt.Equals(input.ArrearsAmt))
                ) && 
                (
                    this.ArrearsTypeInd == input.ArrearsTypeInd ||
                    (this.ArrearsTypeInd != null &&
                    this.ArrearsTypeInd.Equals(input.ArrearsTypeInd))
                ) && 
                (
                    this.ConsumerAccountID == input.ConsumerAccountID ||
                    (this.ConsumerAccountID != null &&
                    this.ConsumerAccountID.Equals(input.ConsumerAccountID))
                ) && 
                (
                    this.CreditLimitAmt == input.CreditLimitAmt ||
                    (this.CreditLimitAmt != null &&
                    this.CreditLimitAmt.Equals(input.CreditLimitAmt))
                ) && 
                (
                    this.CurrentBalanceAmt == input.CurrentBalanceAmt ||
                    (this.CurrentBalanceAmt != null &&
                    this.CurrentBalanceAmt.Equals(input.CurrentBalanceAmt))
                ) && 
                (
                    this.DeferredPaymentDate == input.DeferredPaymentDate ||
                    (this.DeferredPaymentDate != null &&
                    this.DeferredPaymentDate.Equals(input.DeferredPaymentDate))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.LastPaymentDate == input.LastPaymentDate ||
                    (this.LastPaymentDate != null &&
                    this.LastPaymentDate.Equals(input.LastPaymentDate))
                ) && 
                (
                    this.MonthlyInstalmentAmt == input.MonthlyInstalmentAmt ||
                    (this.MonthlyInstalmentAmt != null &&
                    this.MonthlyInstalmentAmt.Equals(input.MonthlyInstalmentAmt))
                ) && 
                (
                    this.StatusCodeDesc == input.StatusCodeDesc ||
                    (this.StatusCodeDesc != null &&
                    this.StatusCodeDesc.Equals(input.StatusCodeDesc))
                ) && 
                (
                    this.SubAccountNo == input.SubAccountNo ||
                    (this.SubAccountNo != null &&
                    this.SubAccountNo.Equals(input.SubAccountNo))
                ) && 
                (
                    this.SubscriberID == input.SubscriberID ||
                    (this.SubscriberID != null &&
                    this.SubscriberID.Equals(input.SubscriberID))
                ) && 
                (
                    this.SubscriberName == input.SubscriberName ||
                    (this.SubscriberName != null &&
                    this.SubscriberName.Equals(input.SubscriberName))
                ) && 
                (
                    this.ThirdPartyName == input.ThirdPartyName ||
                    (this.ThirdPartyName != null &&
                    this.ThirdPartyName.Equals(input.ThirdPartyName))
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
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.ArrearsAmt != null)
                    hashCode = hashCode * 59 + this.ArrearsAmt.GetHashCode();
                if (this.ArrearsTypeInd != null)
                    hashCode = hashCode * 59 + this.ArrearsTypeInd.GetHashCode();
                if (this.ConsumerAccountID != null)
                    hashCode = hashCode * 59 + this.ConsumerAccountID.GetHashCode();
                if (this.CreditLimitAmt != null)
                    hashCode = hashCode * 59 + this.CreditLimitAmt.GetHashCode();
                if (this.CurrentBalanceAmt != null)
                    hashCode = hashCode * 59 + this.CurrentBalanceAmt.GetHashCode();
                if (this.DeferredPaymentDate != null)
                    hashCode = hashCode * 59 + this.DeferredPaymentDate.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.LastPaymentDate != null)
                    hashCode = hashCode * 59 + this.LastPaymentDate.GetHashCode();
                if (this.MonthlyInstalmentAmt != null)
                    hashCode = hashCode * 59 + this.MonthlyInstalmentAmt.GetHashCode();
                if (this.StatusCodeDesc != null)
                    hashCode = hashCode * 59 + this.StatusCodeDesc.GetHashCode();
                if (this.SubAccountNo != null)
                    hashCode = hashCode * 59 + this.SubAccountNo.GetHashCode();
                if (this.SubscriberID != null)
                    hashCode = hashCode * 59 + this.SubscriberID.GetHashCode();
                if (this.SubscriberName != null)
                    hashCode = hashCode * 59 + this.SubscriberName.GetHashCode();
                if (this.ThirdPartyName != null)
                    hashCode = hashCode * 59 + this.ThirdPartyName.GetHashCode();
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