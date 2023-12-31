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
    /// SafpsIncident
    /// </summary>
    [DataContract]
    public partial class SafpsIncident :  IEquatable<SafpsIncident>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SafpsIncident" /> class.
        /// </summary>
        /// <param name="memberReference">memberReference.</param>
        /// <param name="member">member.</param>
        /// <param name="reportedBy">reportedBy.</param>
        /// <param name="savings">savings.</param>
        /// <param name="loss">loss.</param>
        /// <param name="details">details.</param>
        /// <param name="incidentReference">incidentReference.</param>
        /// <param name="incidentCategory">incidentCategory.</param>
        /// <param name="incidentDate">incidentDate.</param>
        /// <param name="idDocuments">idDocuments.</param>
        /// <param name="contactNumbers">contactNumbers.</param>
        /// <param name="addresses">addresses.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        /// <param name="bankAccounts">bankAccounts.</param>
        /// <param name="employers">employers.</param>
        public SafpsIncident(string memberReference = default(string), string member = default(string), string reportedBy = default(string), string savings = default(string), string loss = default(string), string details = default(string), string incidentReference = default(string), string incidentCategory = default(string), string incidentDate = default(string), List<string> idDocuments = default(List<string>), List<string> contactNumbers = default(List<string>), List<string> addresses = default(List<string>), List<string> emailAddresses = default(List<string>), List<string> bankAccounts = default(List<string>), List<string> employers = default(List<string>))
        {
            this.MemberReference = memberReference;
            this.Member = member;
            this.ReportedBy = reportedBy;
            this.Savings = savings;
            this.Loss = loss;
            this.Details = details;
            this.IncidentReference = incidentReference;
            this.IncidentCategory = incidentCategory;
            this.IncidentDate = incidentDate;
            this.IdDocuments = idDocuments;
            this.ContactNumbers = contactNumbers;
            this.Addresses = addresses;
            this.EmailAddresses = emailAddresses;
            this.BankAccounts = bankAccounts;
            this.Employers = employers;
            this.MemberReference = memberReference;
            this.Member = member;
            this.ReportedBy = reportedBy;
            this.Savings = savings;
            this.Loss = loss;
            this.Details = details;
            this.IncidentReference = incidentReference;
            this.IncidentCategory = incidentCategory;
            this.IncidentDate = incidentDate;
            this.IdDocuments = idDocuments;
            this.ContactNumbers = contactNumbers;
            this.Addresses = addresses;
            this.EmailAddresses = emailAddresses;
            this.BankAccounts = bankAccounts;
            this.Employers = employers;
        }

        /// <summary>
        /// Gets or Sets MemberReference
        /// </summary>
        [DataMember(Name="memberReference", EmitDefaultValue=true)]
        public string MemberReference { get; set; }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name="member", EmitDefaultValue=true)]
        public string Member { get; set; }

        /// <summary>
        /// Gets or Sets ReportedBy
        /// </summary>
        [DataMember(Name="reportedBy", EmitDefaultValue=true)]
        public string ReportedBy { get; set; }

        /// <summary>
        /// Gets or Sets Savings
        /// </summary>
        [DataMember(Name="savings", EmitDefaultValue=true)]
        public string Savings { get; set; }

        /// <summary>
        /// Gets or Sets Loss
        /// </summary>
        [DataMember(Name="loss", EmitDefaultValue=true)]
        public string Loss { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=true)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets IncidentReference
        /// </summary>
        [DataMember(Name="incidentReference", EmitDefaultValue=true)]
        public string IncidentReference { get; set; }

        /// <summary>
        /// Gets or Sets IncidentCategory
        /// </summary>
        [DataMember(Name="incidentCategory", EmitDefaultValue=true)]
        public string IncidentCategory { get; set; }

        /// <summary>
        /// Gets or Sets IncidentDate
        /// </summary>
        [DataMember(Name="incidentDate", EmitDefaultValue=true)]
        public string IncidentDate { get; set; }

        /// <summary>
        /// Gets or Sets IdDocuments
        /// </summary>
        [DataMember(Name="idDocuments", EmitDefaultValue=true)]
        public List<string> IdDocuments { get; set; }

        /// <summary>
        /// Gets or Sets ContactNumbers
        /// </summary>
        [DataMember(Name="contactNumbers", EmitDefaultValue=true)]
        public List<string> ContactNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=true)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name="emailAddresses", EmitDefaultValue=true)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets BankAccounts
        /// </summary>
        [DataMember(Name="bankAccounts", EmitDefaultValue=true)]
        public List<string> BankAccounts { get; set; }

        /// <summary>
        /// Gets or Sets Employers
        /// </summary>
        [DataMember(Name="employers", EmitDefaultValue=true)]
        public List<string> Employers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SafpsIncident {\n");
            sb.Append("  MemberReference: ").Append(MemberReference).Append("\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  ReportedBy: ").Append(ReportedBy).Append("\n");
            sb.Append("  Savings: ").Append(Savings).Append("\n");
            sb.Append("  Loss: ").Append(Loss).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  IncidentReference: ").Append(IncidentReference).Append("\n");
            sb.Append("  IncidentCategory: ").Append(IncidentCategory).Append("\n");
            sb.Append("  IncidentDate: ").Append(IncidentDate).Append("\n");
            sb.Append("  IdDocuments: ").Append(IdDocuments).Append("\n");
            sb.Append("  ContactNumbers: ").Append(ContactNumbers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
            sb.Append("  Employers: ").Append(Employers).Append("\n");
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
            return this.Equals(input as SafpsIncident);
        }

        /// <summary>
        /// Returns true if SafpsIncident instances are equal
        /// </summary>
        /// <param name="input">Instance of SafpsIncident to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SafpsIncident input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MemberReference == input.MemberReference ||
                    (this.MemberReference != null &&
                    this.MemberReference.Equals(input.MemberReference))
                ) && 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    this.ReportedBy == input.ReportedBy ||
                    (this.ReportedBy != null &&
                    this.ReportedBy.Equals(input.ReportedBy))
                ) && 
                (
                    this.Savings == input.Savings ||
                    (this.Savings != null &&
                    this.Savings.Equals(input.Savings))
                ) && 
                (
                    this.Loss == input.Loss ||
                    (this.Loss != null &&
                    this.Loss.Equals(input.Loss))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.IncidentReference == input.IncidentReference ||
                    (this.IncidentReference != null &&
                    this.IncidentReference.Equals(input.IncidentReference))
                ) && 
                (
                    this.IncidentCategory == input.IncidentCategory ||
                    (this.IncidentCategory != null &&
                    this.IncidentCategory.Equals(input.IncidentCategory))
                ) && 
                (
                    this.IncidentDate == input.IncidentDate ||
                    (this.IncidentDate != null &&
                    this.IncidentDate.Equals(input.IncidentDate))
                ) && 
                (
                    this.IdDocuments == input.IdDocuments ||
                    this.IdDocuments != null &&
                    input.IdDocuments != null &&
                    this.IdDocuments.SequenceEqual(input.IdDocuments)
                ) && 
                (
                    this.ContactNumbers == input.ContactNumbers ||
                    this.ContactNumbers != null &&
                    input.ContactNumbers != null &&
                    this.ContactNumbers.SequenceEqual(input.ContactNumbers)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.BankAccounts == input.BankAccounts ||
                    this.BankAccounts != null &&
                    input.BankAccounts != null &&
                    this.BankAccounts.SequenceEqual(input.BankAccounts)
                ) && 
                (
                    this.Employers == input.Employers ||
                    this.Employers != null &&
                    input.Employers != null &&
                    this.Employers.SequenceEqual(input.Employers)
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
                if (this.MemberReference != null)
                    hashCode = hashCode * 59 + this.MemberReference.GetHashCode();
                if (this.Member != null)
                    hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.ReportedBy != null)
                    hashCode = hashCode * 59 + this.ReportedBy.GetHashCode();
                if (this.Savings != null)
                    hashCode = hashCode * 59 + this.Savings.GetHashCode();
                if (this.Loss != null)
                    hashCode = hashCode * 59 + this.Loss.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.IncidentReference != null)
                    hashCode = hashCode * 59 + this.IncidentReference.GetHashCode();
                if (this.IncidentCategory != null)
                    hashCode = hashCode * 59 + this.IncidentCategory.GetHashCode();
                if (this.IncidentDate != null)
                    hashCode = hashCode * 59 + this.IncidentDate.GetHashCode();
                if (this.IdDocuments != null)
                    hashCode = hashCode * 59 + this.IdDocuments.GetHashCode();
                if (this.ContactNumbers != null)
                    hashCode = hashCode * 59 + this.ContactNumbers.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.EmailAddresses != null)
                    hashCode = hashCode * 59 + this.EmailAddresses.GetHashCode();
                if (this.BankAccounts != null)
                    hashCode = hashCode * 59 + this.BankAccounts.GetHashCode();
                if (this.Employers != null)
                    hashCode = hashCode * 59 + this.Employers.GetHashCode();
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
