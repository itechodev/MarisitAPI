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
    /// XdsDirectorDefaultAlert
    /// </summary>
    [DataContract]
    public partial class XdsDirectorDefaultAlert :  IEquatable<XdsDirectorDefaultAlert>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsDirectorDefaultAlert" /> class.
        /// </summary>
        /// <param name="accountNo">accountNo.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="amount">amount.</param>
        /// <param name="comment">comment.</param>
        /// <param name="comments">comments.</param>
        /// <param name="company">company.</param>
        /// <param name="dateLoaded">dateLoaded.</param>
        /// <param name="directorID">directorID.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="idNo">idNo.</param>
        /// <param name="statusDate">statusDate.</param>
        /// <param name="statuscode">statuscode.</param>
        /// <param name="subscriberID">subscriberID.</param>
        /// <param name="surname">surname.</param>
        public XdsDirectorDefaultAlert(string accountNo = default(string), string accountType = default(string), string amount = default(string), string comment = default(string), string comments = default(string), string company = default(string), string dateLoaded = default(string), string directorID = default(string), string displayText = default(string), string firstName = default(string), string idNo = default(string), string statusDate = default(string), string statuscode = default(string), string subscriberID = default(string), string surname = default(string))
        {
            this.AccountNo = accountNo;
            this.AccountType = accountType;
            this.Amount = amount;
            this.Comment = comment;
            this.Comments = comments;
            this.Company = company;
            this.DateLoaded = dateLoaded;
            this.DirectorID = directorID;
            this.DisplayText = displayText;
            this.FirstName = firstName;
            this.IdNo = idNo;
            this.StatusDate = statusDate;
            this.Statuscode = statuscode;
            this.SubscriberID = subscriberID;
            this.Surname = surname;
            this.AccountNo = accountNo;
            this.AccountType = accountType;
            this.Amount = amount;
            this.Comment = comment;
            this.Comments = comments;
            this.Company = company;
            this.DateLoaded = dateLoaded;
            this.DirectorID = directorID;
            this.DisplayText = displayText;
            this.FirstName = firstName;
            this.IdNo = idNo;
            this.StatusDate = statusDate;
            this.Statuscode = statuscode;
            this.SubscriberID = subscriberID;
            this.Surname = surname;
        }

        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=true)]
        public string AccountNo { get; set; }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=true)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=true)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets DateLoaded
        /// </summary>
        [DataMember(Name="dateLoaded", EmitDefaultValue=true)]
        public string DateLoaded { get; set; }

        /// <summary>
        /// Gets or Sets DirectorID
        /// </summary>
        [DataMember(Name="directorID", EmitDefaultValue=true)]
        public string DirectorID { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets IdNo
        /// </summary>
        [DataMember(Name="idNo", EmitDefaultValue=true)]
        public string IdNo { get; set; }

        /// <summary>
        /// Gets or Sets StatusDate
        /// </summary>
        [DataMember(Name="statusDate", EmitDefaultValue=true)]
        public string StatusDate { get; set; }

        /// <summary>
        /// Gets or Sets Statuscode
        /// </summary>
        [DataMember(Name="statuscode", EmitDefaultValue=true)]
        public string Statuscode { get; set; }

        /// <summary>
        /// Gets or Sets SubscriberID
        /// </summary>
        [DataMember(Name="subscriberID", EmitDefaultValue=true)]
        public string SubscriberID { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsDirectorDefaultAlert {\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  DateLoaded: ").Append(DateLoaded).Append("\n");
            sb.Append("  DirectorID: ").Append(DirectorID).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  IdNo: ").Append(IdNo).Append("\n");
            sb.Append("  StatusDate: ").Append(StatusDate).Append("\n");
            sb.Append("  Statuscode: ").Append(Statuscode).Append("\n");
            sb.Append("  SubscriberID: ").Append(SubscriberID).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
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
            return this.Equals(input as XdsDirectorDefaultAlert);
        }

        /// <summary>
        /// Returns true if XdsDirectorDefaultAlert instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsDirectorDefaultAlert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsDirectorDefaultAlert input)
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
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.DateLoaded == input.DateLoaded ||
                    (this.DateLoaded != null &&
                    this.DateLoaded.Equals(input.DateLoaded))
                ) && 
                (
                    this.DirectorID == input.DirectorID ||
                    (this.DirectorID != null &&
                    this.DirectorID.Equals(input.DirectorID))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.IdNo == input.IdNo ||
                    (this.IdNo != null &&
                    this.IdNo.Equals(input.IdNo))
                ) && 
                (
                    this.StatusDate == input.StatusDate ||
                    (this.StatusDate != null &&
                    this.StatusDate.Equals(input.StatusDate))
                ) && 
                (
                    this.Statuscode == input.Statuscode ||
                    (this.Statuscode != null &&
                    this.Statuscode.Equals(input.Statuscode))
                ) && 
                (
                    this.SubscriberID == input.SubscriberID ||
                    (this.SubscriberID != null &&
                    this.SubscriberID.Equals(input.SubscriberID))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
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
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.DateLoaded != null)
                    hashCode = hashCode * 59 + this.DateLoaded.GetHashCode();
                if (this.DirectorID != null)
                    hashCode = hashCode * 59 + this.DirectorID.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.IdNo != null)
                    hashCode = hashCode * 59 + this.IdNo.GetHashCode();
                if (this.StatusDate != null)
                    hashCode = hashCode * 59 + this.StatusDate.GetHashCode();
                if (this.Statuscode != null)
                    hashCode = hashCode * 59 + this.Statuscode.GetHashCode();
                if (this.SubscriberID != null)
                    hashCode = hashCode * 59 + this.SubscriberID.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
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