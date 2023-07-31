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
    /// TransunionConsumer118PaymentProfileP702
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118PaymentProfileP702 :  IEquatable<TransunionConsumer118PaymentProfileP702>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118PaymentProfileP702" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="lastUpdateDate">lastUpdateDate.</param>
        /// <param name="supplierName">supplierName.</param>
        /// <param name="industryCode">industryCode.</param>
        /// <param name="industry">industry.</param>
        /// <param name="accountTypeCode">accountTypeCode.</param>
        /// <param name="accountTypeDesc">accountTypeDesc.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="subAccount">subAccount.</param>
        /// <param name="dateOpened">dateOpened.</param>
        /// <param name="openingBalance">openingBalance.</param>
        /// <param name="instalment">instalment.</param>
        /// <param name="currentBalance">currentBalance.</param>
        /// <param name="terms">terms.</param>
        /// <param name="overdueAmount">overdueAmount.</param>
        /// <param name="ownershipType">ownershipType.</param>
        /// <param name="numberOfParticipantsInJointLoan">numberOfParticipantsInJointLoan.</param>
        /// <param name="paymentType">paymentType.</param>
        /// <param name="repaymentFrequency">repaymentFrequency.</param>
        /// <param name="deferredPaymentDate">deferredPaymentDate.</param>
        /// <param name="accSoldTo3rdParty">accSoldTo3rdParty.</param>
        /// <param name="thirdPartyName">thirdPartyName.</param>
        /// <param name="paymentHistories">paymentHistories.</param>
        public TransunionConsumer118PaymentProfileP702(string consumerNo = default(string), string lastUpdateDate = default(string), string supplierName = default(string), string industryCode = default(string), string industry = default(string), string accountTypeCode = default(string), string accountTypeDesc = default(string), string accountNumber = default(string), string subAccount = default(string), string dateOpened = default(string), string openingBalance = default(string), string instalment = default(string), string currentBalance = default(string), string terms = default(string), string overdueAmount = default(string), string ownershipType = default(string), string numberOfParticipantsInJointLoan = default(string), string paymentType = default(string), string repaymentFrequency = default(string), string deferredPaymentDate = default(string), string accSoldTo3rdParty = default(string), string thirdPartyName = default(string), List<TransunionConsumer118PaymentHistory> paymentHistories = default(List<TransunionConsumer118PaymentHistory>))
        {
            this.ConsumerNo = consumerNo;
            this.LastUpdateDate = lastUpdateDate;
            this.SupplierName = supplierName;
            this.IndustryCode = industryCode;
            this.Industry = industry;
            this.AccountTypeCode = accountTypeCode;
            this.AccountTypeDesc = accountTypeDesc;
            this.AccountNumber = accountNumber;
            this.SubAccount = subAccount;
            this.DateOpened = dateOpened;
            this.OpeningBalance = openingBalance;
            this.Instalment = instalment;
            this.CurrentBalance = currentBalance;
            this.Terms = terms;
            this.OverdueAmount = overdueAmount;
            this.OwnershipType = ownershipType;
            this.NumberOfParticipantsInJointLoan = numberOfParticipantsInJointLoan;
            this.PaymentType = paymentType;
            this.RepaymentFrequency = repaymentFrequency;
            this.DeferredPaymentDate = deferredPaymentDate;
            this.AccSoldTo3rdParty = accSoldTo3rdParty;
            this.ThirdPartyName = thirdPartyName;
            this.PaymentHistories = paymentHistories;
            this.ConsumerNo = consumerNo;
            this.LastUpdateDate = lastUpdateDate;
            this.SupplierName = supplierName;
            this.IndustryCode = industryCode;
            this.Industry = industry;
            this.AccountTypeCode = accountTypeCode;
            this.AccountTypeDesc = accountTypeDesc;
            this.AccountNumber = accountNumber;
            this.SubAccount = subAccount;
            this.DateOpened = dateOpened;
            this.OpeningBalance = openingBalance;
            this.Instalment = instalment;
            this.CurrentBalance = currentBalance;
            this.Terms = terms;
            this.OverdueAmount = overdueAmount;
            this.OwnershipType = ownershipType;
            this.NumberOfParticipantsInJointLoan = numberOfParticipantsInJointLoan;
            this.PaymentType = paymentType;
            this.RepaymentFrequency = repaymentFrequency;
            this.DeferredPaymentDate = deferredPaymentDate;
            this.AccSoldTo3rdParty = accSoldTo3rdParty;
            this.ThirdPartyName = thirdPartyName;
            this.PaymentHistories = paymentHistories;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdateDate
        /// </summary>
        [DataMember(Name="lastUpdateDate", EmitDefaultValue=true)]
        public string LastUpdateDate { get; set; }

        /// <summary>
        /// Gets or Sets SupplierName
        /// </summary>
        [DataMember(Name="supplierName", EmitDefaultValue=true)]
        public string SupplierName { get; set; }

        /// <summary>
        /// Gets or Sets IndustryCode
        /// </summary>
        [DataMember(Name="industryCode", EmitDefaultValue=true)]
        public string IndustryCode { get; set; }

        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=true)]
        public string Industry { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeCode
        /// </summary>
        [DataMember(Name="accountTypeCode", EmitDefaultValue=true)]
        public string AccountTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountTypeDesc
        /// </summary>
        [DataMember(Name="accountTypeDesc", EmitDefaultValue=true)]
        public string AccountTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets SubAccount
        /// </summary>
        [DataMember(Name="subAccount", EmitDefaultValue=true)]
        public string SubAccount { get; set; }

        /// <summary>
        /// Gets or Sets DateOpened
        /// </summary>
        [DataMember(Name="dateOpened", EmitDefaultValue=true)]
        public string DateOpened { get; set; }

        /// <summary>
        /// Gets or Sets OpeningBalance
        /// </summary>
        [DataMember(Name="openingBalance", EmitDefaultValue=true)]
        public string OpeningBalance { get; set; }

        /// <summary>
        /// Gets or Sets Instalment
        /// </summary>
        [DataMember(Name="instalment", EmitDefaultValue=true)]
        public string Instalment { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBalance
        /// </summary>
        [DataMember(Name="currentBalance", EmitDefaultValue=true)]
        public string CurrentBalance { get; set; }

        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=true)]
        public string Terms { get; set; }

        /// <summary>
        /// Gets or Sets OverdueAmount
        /// </summary>
        [DataMember(Name="overdueAmount", EmitDefaultValue=true)]
        public string OverdueAmount { get; set; }

        /// <summary>
        /// Gets or Sets OwnershipType
        /// </summary>
        [DataMember(Name="ownershipType", EmitDefaultValue=true)]
        public string OwnershipType { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfParticipantsInJointLoan
        /// </summary>
        [DataMember(Name="numberOfParticipantsInJointLoan", EmitDefaultValue=true)]
        public string NumberOfParticipantsInJointLoan { get; set; }

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name="paymentType", EmitDefaultValue=true)]
        public string PaymentType { get; set; }

        /// <summary>
        /// Gets or Sets RepaymentFrequency
        /// </summary>
        [DataMember(Name="repaymentFrequency", EmitDefaultValue=true)]
        public string RepaymentFrequency { get; set; }

        /// <summary>
        /// Gets or Sets DeferredPaymentDate
        /// </summary>
        [DataMember(Name="deferredPaymentDate", EmitDefaultValue=true)]
        public string DeferredPaymentDate { get; set; }

        /// <summary>
        /// Gets or Sets AccSoldTo3rdParty
        /// </summary>
        [DataMember(Name="accSoldTo3rdParty", EmitDefaultValue=true)]
        public string AccSoldTo3rdParty { get; set; }

        /// <summary>
        /// Gets or Sets ThirdPartyName
        /// </summary>
        [DataMember(Name="thirdPartyName", EmitDefaultValue=true)]
        public string ThirdPartyName { get; set; }

        /// <summary>
        /// Gets or Sets PaymentHistories
        /// </summary>
        [DataMember(Name="paymentHistories", EmitDefaultValue=true)]
        public List<TransunionConsumer118PaymentHistory> PaymentHistories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118PaymentProfileP702 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  IndustryCode: ").Append(IndustryCode).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  AccountTypeCode: ").Append(AccountTypeCode).Append("\n");
            sb.Append("  AccountTypeDesc: ").Append(AccountTypeDesc).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SubAccount: ").Append(SubAccount).Append("\n");
            sb.Append("  DateOpened: ").Append(DateOpened).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  Instalment: ").Append(Instalment).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  OverdueAmount: ").Append(OverdueAmount).Append("\n");
            sb.Append("  OwnershipType: ").Append(OwnershipType).Append("\n");
            sb.Append("  NumberOfParticipantsInJointLoan: ").Append(NumberOfParticipantsInJointLoan).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  RepaymentFrequency: ").Append(RepaymentFrequency).Append("\n");
            sb.Append("  DeferredPaymentDate: ").Append(DeferredPaymentDate).Append("\n");
            sb.Append("  AccSoldTo3rdParty: ").Append(AccSoldTo3rdParty).Append("\n");
            sb.Append("  ThirdPartyName: ").Append(ThirdPartyName).Append("\n");
            sb.Append("  PaymentHistories: ").Append(PaymentHistories).Append("\n");
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
            return this.Equals(input as TransunionConsumer118PaymentProfileP702);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118PaymentProfileP702 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118PaymentProfileP702 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118PaymentProfileP702 input)
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
                    this.LastUpdateDate == input.LastUpdateDate ||
                    (this.LastUpdateDate != null &&
                    this.LastUpdateDate.Equals(input.LastUpdateDate))
                ) && 
                (
                    this.SupplierName == input.SupplierName ||
                    (this.SupplierName != null &&
                    this.SupplierName.Equals(input.SupplierName))
                ) && 
                (
                    this.IndustryCode == input.IndustryCode ||
                    (this.IndustryCode != null &&
                    this.IndustryCode.Equals(input.IndustryCode))
                ) && 
                (
                    this.Industry == input.Industry ||
                    (this.Industry != null &&
                    this.Industry.Equals(input.Industry))
                ) && 
                (
                    this.AccountTypeCode == input.AccountTypeCode ||
                    (this.AccountTypeCode != null &&
                    this.AccountTypeCode.Equals(input.AccountTypeCode))
                ) && 
                (
                    this.AccountTypeDesc == input.AccountTypeDesc ||
                    (this.AccountTypeDesc != null &&
                    this.AccountTypeDesc.Equals(input.AccountTypeDesc))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.SubAccount == input.SubAccount ||
                    (this.SubAccount != null &&
                    this.SubAccount.Equals(input.SubAccount))
                ) && 
                (
                    this.DateOpened == input.DateOpened ||
                    (this.DateOpened != null &&
                    this.DateOpened.Equals(input.DateOpened))
                ) && 
                (
                    this.OpeningBalance == input.OpeningBalance ||
                    (this.OpeningBalance != null &&
                    this.OpeningBalance.Equals(input.OpeningBalance))
                ) && 
                (
                    this.Instalment == input.Instalment ||
                    (this.Instalment != null &&
                    this.Instalment.Equals(input.Instalment))
                ) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
                ) && 
                (
                    this.Terms == input.Terms ||
                    (this.Terms != null &&
                    this.Terms.Equals(input.Terms))
                ) && 
                (
                    this.OverdueAmount == input.OverdueAmount ||
                    (this.OverdueAmount != null &&
                    this.OverdueAmount.Equals(input.OverdueAmount))
                ) && 
                (
                    this.OwnershipType == input.OwnershipType ||
                    (this.OwnershipType != null &&
                    this.OwnershipType.Equals(input.OwnershipType))
                ) && 
                (
                    this.NumberOfParticipantsInJointLoan == input.NumberOfParticipantsInJointLoan ||
                    (this.NumberOfParticipantsInJointLoan != null &&
                    this.NumberOfParticipantsInJointLoan.Equals(input.NumberOfParticipantsInJointLoan))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.RepaymentFrequency == input.RepaymentFrequency ||
                    (this.RepaymentFrequency != null &&
                    this.RepaymentFrequency.Equals(input.RepaymentFrequency))
                ) && 
                (
                    this.DeferredPaymentDate == input.DeferredPaymentDate ||
                    (this.DeferredPaymentDate != null &&
                    this.DeferredPaymentDate.Equals(input.DeferredPaymentDate))
                ) && 
                (
                    this.AccSoldTo3rdParty == input.AccSoldTo3rdParty ||
                    (this.AccSoldTo3rdParty != null &&
                    this.AccSoldTo3rdParty.Equals(input.AccSoldTo3rdParty))
                ) && 
                (
                    this.ThirdPartyName == input.ThirdPartyName ||
                    (this.ThirdPartyName != null &&
                    this.ThirdPartyName.Equals(input.ThirdPartyName))
                ) && 
                (
                    this.PaymentHistories == input.PaymentHistories ||
                    this.PaymentHistories != null &&
                    input.PaymentHistories != null &&
                    this.PaymentHistories.SequenceEqual(input.PaymentHistories)
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
                if (this.LastUpdateDate != null)
                    hashCode = hashCode * 59 + this.LastUpdateDate.GetHashCode();
                if (this.SupplierName != null)
                    hashCode = hashCode * 59 + this.SupplierName.GetHashCode();
                if (this.IndustryCode != null)
                    hashCode = hashCode * 59 + this.IndustryCode.GetHashCode();
                if (this.Industry != null)
                    hashCode = hashCode * 59 + this.Industry.GetHashCode();
                if (this.AccountTypeCode != null)
                    hashCode = hashCode * 59 + this.AccountTypeCode.GetHashCode();
                if (this.AccountTypeDesc != null)
                    hashCode = hashCode * 59 + this.AccountTypeDesc.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.SubAccount != null)
                    hashCode = hashCode * 59 + this.SubAccount.GetHashCode();
                if (this.DateOpened != null)
                    hashCode = hashCode * 59 + this.DateOpened.GetHashCode();
                if (this.OpeningBalance != null)
                    hashCode = hashCode * 59 + this.OpeningBalance.GetHashCode();
                if (this.Instalment != null)
                    hashCode = hashCode * 59 + this.Instalment.GetHashCode();
                if (this.CurrentBalance != null)
                    hashCode = hashCode * 59 + this.CurrentBalance.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                if (this.OverdueAmount != null)
                    hashCode = hashCode * 59 + this.OverdueAmount.GetHashCode();
                if (this.OwnershipType != null)
                    hashCode = hashCode * 59 + this.OwnershipType.GetHashCode();
                if (this.NumberOfParticipantsInJointLoan != null)
                    hashCode = hashCode * 59 + this.NumberOfParticipantsInJointLoan.GetHashCode();
                if (this.PaymentType != null)
                    hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.RepaymentFrequency != null)
                    hashCode = hashCode * 59 + this.RepaymentFrequency.GetHashCode();
                if (this.DeferredPaymentDate != null)
                    hashCode = hashCode * 59 + this.DeferredPaymentDate.GetHashCode();
                if (this.AccSoldTo3rdParty != null)
                    hashCode = hashCode * 59 + this.AccSoldTo3rdParty.GetHashCode();
                if (this.ThirdPartyName != null)
                    hashCode = hashCode * 59 + this.ThirdPartyName.GetHashCode();
                if (this.PaymentHistories != null)
                    hashCode = hashCode * 59 + this.PaymentHistories.GetHashCode();
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
