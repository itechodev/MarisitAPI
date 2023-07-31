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
    /// TransunionConsumer118PaymentProfileNP11
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118PaymentProfileNP11 :  IEquatable<TransunionConsumer118PaymentProfileNP11>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118PaymentProfileNP11" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="supplierName">supplierName.</param>
        /// <param name="industryCode">industryCode.</param>
        /// <param name="industryDesc">industryDesc.</param>
        /// <param name="accountTypeCode">accountTypeCode.</param>
        /// <param name="accountTypeDesc">accountTypeDesc.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="subAccount">subAccount.</param>
        /// <param name="dateOpened">dateOpened.</param>
        /// <param name="openingBalance">openingBalance.</param>
        /// <param name="instalment">instalment.</param>
        /// <param name="currentBalance">currentBalance.</param>
        /// <param name="terms">terms.</param>
        /// <param name="date">date.</param>
        /// <param name="status">status.</param>
        public TransunionConsumer118PaymentProfileNP11(string consumerNo = default(string), string supplierName = default(string), string industryCode = default(string), string industryDesc = default(string), string accountTypeCode = default(string), string accountTypeDesc = default(string), string accountNumber = default(string), string subAccount = default(string), string dateOpened = default(string), string openingBalance = default(string), string instalment = default(string), string currentBalance = default(string), string terms = default(string), List<string> date = default(List<string>), List<string> status = default(List<string>))
        {
            this.ConsumerNo = consumerNo;
            this.SupplierName = supplierName;
            this.IndustryCode = industryCode;
            this.IndustryDesc = industryDesc;
            this.AccountTypeCode = accountTypeCode;
            this.AccountTypeDesc = accountTypeDesc;
            this.AccountNumber = accountNumber;
            this.SubAccount = subAccount;
            this.DateOpened = dateOpened;
            this.OpeningBalance = openingBalance;
            this.Instalment = instalment;
            this.CurrentBalance = currentBalance;
            this.Terms = terms;
            this.Date = date;
            this.Status = status;
            this.ConsumerNo = consumerNo;
            this.SupplierName = supplierName;
            this.IndustryCode = industryCode;
            this.IndustryDesc = industryDesc;
            this.AccountTypeCode = accountTypeCode;
            this.AccountTypeDesc = accountTypeDesc;
            this.AccountNumber = accountNumber;
            this.SubAccount = subAccount;
            this.DateOpened = dateOpened;
            this.OpeningBalance = openingBalance;
            this.Instalment = instalment;
            this.CurrentBalance = currentBalance;
            this.Terms = terms;
            this.Date = date;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

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
        /// Gets or Sets IndustryDesc
        /// </summary>
        [DataMember(Name="industryDesc", EmitDefaultValue=true)]
        public string IndustryDesc { get; set; }

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
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public List<string> Date { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public List<string> Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118PaymentProfileNP11 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  SupplierName: ").Append(SupplierName).Append("\n");
            sb.Append("  IndustryCode: ").Append(IndustryCode).Append("\n");
            sb.Append("  IndustryDesc: ").Append(IndustryDesc).Append("\n");
            sb.Append("  AccountTypeCode: ").Append(AccountTypeCode).Append("\n");
            sb.Append("  AccountTypeDesc: ").Append(AccountTypeDesc).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  SubAccount: ").Append(SubAccount).Append("\n");
            sb.Append("  DateOpened: ").Append(DateOpened).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  Instalment: ").Append(Instalment).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TransunionConsumer118PaymentProfileNP11);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118PaymentProfileNP11 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118PaymentProfileNP11 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118PaymentProfileNP11 input)
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
                    this.IndustryDesc == input.IndustryDesc ||
                    (this.IndustryDesc != null &&
                    this.IndustryDesc.Equals(input.IndustryDesc))
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
                    this.Date == input.Date ||
                    this.Date != null &&
                    input.Date != null &&
                    this.Date.SequenceEqual(input.Date)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
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
                if (this.SupplierName != null)
                    hashCode = hashCode * 59 + this.SupplierName.GetHashCode();
                if (this.IndustryCode != null)
                    hashCode = hashCode * 59 + this.IndustryCode.GetHashCode();
                if (this.IndustryDesc != null)
                    hashCode = hashCode * 59 + this.IndustryDesc.GetHashCode();
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
