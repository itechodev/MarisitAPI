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
    /// TransunionConsumer118ForensicLinkagesDefaultsFF
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118ForensicLinkagesDefaultsFF :  IEquatable<TransunionConsumer118ForensicLinkagesDefaultsFF>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118ForensicLinkagesDefaultsFF" /> class.
        /// </summary>
        /// <param name="statusDate">statusDate.</param>
        /// <param name="supplier">supplier.</param>
        /// <param name="contactName">contactName.</param>
        /// <param name="contactTelephoneCode">contactTelephoneCode.</param>
        /// <param name="contactTelephoneNumber">contactTelephoneNumber.</param>
        /// <param name="branch">branch.</param>
        /// <param name="account">account.</param>
        /// <param name="subAccount">subAccount.</param>
        /// <param name="defaultType">defaultType.</param>
        /// <param name="amount">amount.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="numberOfParties">numberOfParties.</param>
        /// <param name="forensicLinkagesDefaultsAssociates">forensicLinkagesDefaultsAssociates.</param>
        /// <param name="message">message.</param>
        public TransunionConsumer118ForensicLinkagesDefaultsFF(string statusDate = default(string), string supplier = default(string), string contactName = default(string), string contactTelephoneCode = default(string), string contactTelephoneNumber = default(string), string branch = default(string), string account = default(string), string subAccount = default(string), string defaultType = default(string), string amount = default(string), string remarks = default(string), string numberOfParties = default(string), List<TransunionConsumer118ForensicLinkagesDefaultsAssociates> forensicLinkagesDefaultsAssociates = default(List<TransunionConsumer118ForensicLinkagesDefaultsAssociates>), string message = default(string))
        {
            this.StatusDate = statusDate;
            this.Supplier = supplier;
            this.ContactName = contactName;
            this.ContactTelephoneCode = contactTelephoneCode;
            this.ContactTelephoneNumber = contactTelephoneNumber;
            this.Branch = branch;
            this.Account = account;
            this.SubAccount = subAccount;
            this.DefaultType = defaultType;
            this.Amount = amount;
            this.Remarks = remarks;
            this.NumberOfParties = numberOfParties;
            this.ForensicLinkagesDefaultsAssociates = forensicLinkagesDefaultsAssociates;
            this.Message = message;
            this.StatusDate = statusDate;
            this.Supplier = supplier;
            this.ContactName = contactName;
            this.ContactTelephoneCode = contactTelephoneCode;
            this.ContactTelephoneNumber = contactTelephoneNumber;
            this.Branch = branch;
            this.Account = account;
            this.SubAccount = subAccount;
            this.DefaultType = defaultType;
            this.Amount = amount;
            this.Remarks = remarks;
            this.NumberOfParties = numberOfParties;
            this.ForensicLinkagesDefaultsAssociates = forensicLinkagesDefaultsAssociates;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name="statusDate", EmitDefaultValue=true)]
        public string StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets Supplier
        /// </summary>
        [DataMember(Name="supplier", EmitDefaultValue=true)]
        public string Supplier { get; set; }

        /// <summary>
        /// Gets or Sets ContactName
        /// </summary>
        [DataMember(Name="contactName", EmitDefaultValue=true)]
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or Sets ContactTelephoneCode
        /// </summary>
        [DataMember(Name="contactTelephoneCode", EmitDefaultValue=true)]
        public string ContactTelephoneCode { get; set; }

        /// <summary>
        /// Gets or Sets ContactTelephoneNumber
        /// </summary>
        [DataMember(Name="contactTelephoneNumber", EmitDefaultValue=true)]
        public string ContactTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="branch", EmitDefaultValue=true)]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=true)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets SubAccount
        /// </summary>
        [DataMember(Name="subAccount", EmitDefaultValue=true)]
        public string SubAccount { get; set; }

        /// <summary>
        /// Gets or Sets DefaultType
        /// </summary>
        [DataMember(Name="defaultType", EmitDefaultValue=true)]
        public string DefaultType { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="remarks", EmitDefaultValue=true)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfParties
        /// </summary>
        [DataMember(Name="numberOfParties", EmitDefaultValue=true)]
        public string NumberOfParties { get; set; }

        /// <summary>
        /// Gets or Sets ForensicLinkagesDefaultsAssociates
        /// </summary>
        [DataMember(Name="forensicLinkagesDefaultsAssociates", EmitDefaultValue=true)]
        public List<TransunionConsumer118ForensicLinkagesDefaultsAssociates> ForensicLinkagesDefaultsAssociates { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118ForensicLinkagesDefaultsFF {\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  Supplier: ").Append(Supplier).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactTelephoneCode: ").Append(ContactTelephoneCode).Append("\n");
            sb.Append("  ContactTelephoneNumber: ").Append(ContactTelephoneNumber).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  SubAccount: ").Append(SubAccount).Append("\n");
            sb.Append("  DefaultType: ").Append(DefaultType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  NumberOfParties: ").Append(NumberOfParties).Append("\n");
            sb.Append("  ForensicLinkagesDefaultsAssociates: ").Append(ForensicLinkagesDefaultsAssociates).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as TransunionConsumer118ForensicLinkagesDefaultsFF);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118ForensicLinkagesDefaultsFF instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118ForensicLinkagesDefaultsFF to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118ForensicLinkagesDefaultsFF input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.Supplier == input.Supplier ||
                    (this.Supplier != null &&
                    this.Supplier.Equals(input.Supplier))
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.ContactTelephoneCode == input.ContactTelephoneCode ||
                    (this.ContactTelephoneCode != null &&
                    this.ContactTelephoneCode.Equals(input.ContactTelephoneCode))
                ) && 
                (
                    this.ContactTelephoneNumber == input.ContactTelephoneNumber ||
                    (this.ContactTelephoneNumber != null &&
                    this.ContactTelephoneNumber.Equals(input.ContactTelephoneNumber))
                ) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.SubAccount == input.SubAccount ||
                    (this.SubAccount != null &&
                    this.SubAccount.Equals(input.SubAccount))
                ) && 
                (
                    this.DefaultType == input.DefaultType ||
                    (this.DefaultType != null &&
                    this.DefaultType.Equals(input.DefaultType))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.NumberOfParties == input.NumberOfParties ||
                    (this.NumberOfParties != null &&
                    this.NumberOfParties.Equals(input.NumberOfParties))
                ) && 
                (
                    this.ForensicLinkagesDefaultsAssociates == input.ForensicLinkagesDefaultsAssociates ||
                    this.ForensicLinkagesDefaultsAssociates != null &&
                    input.ForensicLinkagesDefaultsAssociates != null &&
                    this.ForensicLinkagesDefaultsAssociates.SequenceEqual(input.ForensicLinkagesDefaultsAssociates)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.StatusDate != null)
                    hashCode = hashCode * 59 + this.StatusDate.GetHashCode();
                if (this.Supplier != null)
                    hashCode = hashCode * 59 + this.Supplier.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.ContactTelephoneCode != null)
                    hashCode = hashCode * 59 + this.ContactTelephoneCode.GetHashCode();
                if (this.ContactTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.ContactTelephoneNumber.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.SubAccount != null)
                    hashCode = hashCode * 59 + this.SubAccount.GetHashCode();
                if (this.DefaultType != null)
                    hashCode = hashCode * 59 + this.DefaultType.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.NumberOfParties != null)
                    hashCode = hashCode * 59 + this.NumberOfParties.GetHashCode();
                if (this.ForensicLinkagesDefaultsAssociates != null)
                    hashCode = hashCode * 59 + this.ForensicLinkagesDefaultsAssociates.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
