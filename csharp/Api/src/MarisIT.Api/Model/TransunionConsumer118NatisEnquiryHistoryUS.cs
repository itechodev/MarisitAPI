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
    /// TransunionConsumer118NatisEnquiryHistoryUS
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118NatisEnquiryHistoryUS :  IEquatable<TransunionConsumer118NatisEnquiryHistoryUS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118NatisEnquiryHistoryUS" /> class.
        /// </summary>
        /// <param name="consumerRole">consumerRole.</param>
        /// <param name="insuranceCompanyName">insuranceCompanyName.</param>
        /// <param name="insuranceCompanyClaimNumber">insuranceCompanyClaimNumber.</param>
        /// <param name="brokerName">brokerName.</param>
        /// <param name="brokerClaimNumber">brokerClaimNumber.</param>
        /// <param name="estimatedCost">estimatedCost.</param>
        /// <param name="grossSettlement">grossSettlement.</param>
        /// <param name="nettSettlement">nettSettlement.</param>
        /// <param name="dateOfLoss">dateOfLoss.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="claimClass">claimClass.</param>
        /// <param name="causeOfLoss">causeOfLoss.</param>
        /// <param name="repudiationReason">repudiationReason.</param>
        /// <param name="itemInceptionDate">itemInceptionDate.</param>
        /// <param name="dateOfEnquiry">dateOfEnquiry.</param>
        /// <param name="enquiryReason">enquiryReason.</param>
        /// <param name="subcriber">subcriber.</param>
        /// <param name="contact">contact.</param>
        /// <param name="enquiryType">enquiryType.</param>
        /// <param name="matchedToIndividual">matchedToIndividual.</param>
        /// <param name="matchedToVehicle">matchedToVehicle.</param>
        public TransunionConsumer118NatisEnquiryHistoryUS(string consumerRole = default(string), string insuranceCompanyName = default(string), string insuranceCompanyClaimNumber = default(string), string brokerName = default(string), string brokerClaimNumber = default(string), string estimatedCost = default(string), string grossSettlement = default(string), string nettSettlement = default(string), string dateOfLoss = default(string), string claimStatus = default(string), string claimClass = default(string), string causeOfLoss = default(string), string repudiationReason = default(string), string itemInceptionDate = default(string), string dateOfEnquiry = default(string), string enquiryReason = default(string), string subcriber = default(string), string contact = default(string), string enquiryType = default(string), string matchedToIndividual = default(string), string matchedToVehicle = default(string))
        {
            this.ConsumerRole = consumerRole;
            this.InsuranceCompanyName = insuranceCompanyName;
            this.InsuranceCompanyClaimNumber = insuranceCompanyClaimNumber;
            this.BrokerName = brokerName;
            this.BrokerClaimNumber = brokerClaimNumber;
            this.EstimatedCost = estimatedCost;
            this.GrossSettlement = grossSettlement;
            this.NettSettlement = nettSettlement;
            this.DateOfLoss = dateOfLoss;
            this.ClaimStatus = claimStatus;
            this.ClaimClass = claimClass;
            this.CauseOfLoss = causeOfLoss;
            this.RepudiationReason = repudiationReason;
            this.ItemInceptionDate = itemInceptionDate;
            this.DateOfEnquiry = dateOfEnquiry;
            this.EnquiryReason = enquiryReason;
            this.Subcriber = subcriber;
            this.Contact = contact;
            this.EnquiryType = enquiryType;
            this.MatchedToIndividual = matchedToIndividual;
            this.MatchedToVehicle = matchedToVehicle;
            this.ConsumerRole = consumerRole;
            this.InsuranceCompanyName = insuranceCompanyName;
            this.InsuranceCompanyClaimNumber = insuranceCompanyClaimNumber;
            this.BrokerName = brokerName;
            this.BrokerClaimNumber = brokerClaimNumber;
            this.EstimatedCost = estimatedCost;
            this.GrossSettlement = grossSettlement;
            this.NettSettlement = nettSettlement;
            this.DateOfLoss = dateOfLoss;
            this.ClaimStatus = claimStatus;
            this.ClaimClass = claimClass;
            this.CauseOfLoss = causeOfLoss;
            this.RepudiationReason = repudiationReason;
            this.ItemInceptionDate = itemInceptionDate;
            this.DateOfEnquiry = dateOfEnquiry;
            this.EnquiryReason = enquiryReason;
            this.Subcriber = subcriber;
            this.Contact = contact;
            this.EnquiryType = enquiryType;
            this.MatchedToIndividual = matchedToIndividual;
            this.MatchedToVehicle = matchedToVehicle;
        }

        /// <summary>
        /// Gets or Sets ConsumerRole
        /// </summary>
        [DataMember(Name="consumerRole", EmitDefaultValue=true)]
        public string ConsumerRole { get; set; }

        /// <summary>
        /// Gets or Sets InsuranceCompanyName
        /// </summary>
        [DataMember(Name="insuranceCompanyName", EmitDefaultValue=true)]
        public string InsuranceCompanyName { get; set; }

        /// <summary>
        /// Gets or Sets InsuranceCompanyClaimNumber
        /// </summary>
        [DataMember(Name="insuranceCompanyClaimNumber", EmitDefaultValue=true)]
        public string InsuranceCompanyClaimNumber { get; set; }

        /// <summary>
        /// Gets or Sets BrokerName
        /// </summary>
        [DataMember(Name="brokerName", EmitDefaultValue=true)]
        public string BrokerName { get; set; }

        /// <summary>
        /// Gets or Sets BrokerClaimNumber
        /// </summary>
        [DataMember(Name="brokerClaimNumber", EmitDefaultValue=true)]
        public string BrokerClaimNumber { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedCost
        /// </summary>
        [DataMember(Name="estimatedCost", EmitDefaultValue=true)]
        public string EstimatedCost { get; set; }

        /// <summary>
        /// Gets or Sets GrossSettlement
        /// </summary>
        [DataMember(Name="grossSettlement", EmitDefaultValue=true)]
        public string GrossSettlement { get; set; }

        /// <summary>
        /// Gets or Sets NettSettlement
        /// </summary>
        [DataMember(Name="nettSettlement", EmitDefaultValue=true)]
        public string NettSettlement { get; set; }

        /// <summary>
        /// Gets or Sets DateOfLoss
        /// </summary>
        [DataMember(Name="dateOfLoss", EmitDefaultValue=true)]
        public string DateOfLoss { get; set; }

        /// <summary>
        /// Gets or Sets ClaimStatus
        /// </summary>
        [DataMember(Name="claimStatus", EmitDefaultValue=true)]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// Gets or Sets ClaimClass
        /// </summary>
        [DataMember(Name="claimClass", EmitDefaultValue=true)]
        public string ClaimClass { get; set; }

        /// <summary>
        /// Gets or Sets CauseOfLoss
        /// </summary>
        [DataMember(Name="causeOfLoss", EmitDefaultValue=true)]
        public string CauseOfLoss { get; set; }

        /// <summary>
        /// Gets or Sets RepudiationReason
        /// </summary>
        [DataMember(Name="repudiationReason", EmitDefaultValue=true)]
        public string RepudiationReason { get; set; }

        /// <summary>
        /// Gets or Sets ItemInceptionDate
        /// </summary>
        [DataMember(Name="itemInceptionDate", EmitDefaultValue=true)]
        public string ItemInceptionDate { get; set; }

        /// <summary>
        /// Gets or Sets DateOfEnquiry
        /// </summary>
        [DataMember(Name="dateOfEnquiry", EmitDefaultValue=true)]
        public string DateOfEnquiry { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryReason
        /// </summary>
        [DataMember(Name="enquiryReason", EmitDefaultValue=true)]
        public string EnquiryReason { get; set; }

        /// <summary>
        /// Gets or Sets Subcriber
        /// </summary>
        [DataMember(Name="subcriber", EmitDefaultValue=true)]
        public string Subcriber { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=true)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryType
        /// </summary>
        [DataMember(Name="enquiryType", EmitDefaultValue=true)]
        public string EnquiryType { get; set; }

        /// <summary>
        /// Gets or Sets MatchedToIndividual
        /// </summary>
        [DataMember(Name="matchedToIndividual", EmitDefaultValue=true)]
        public string MatchedToIndividual { get; set; }

        /// <summary>
        /// Gets or Sets MatchedToVehicle
        /// </summary>
        [DataMember(Name="matchedToVehicle", EmitDefaultValue=true)]
        public string MatchedToVehicle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118NatisEnquiryHistoryUS {\n");
            sb.Append("  ConsumerRole: ").Append(ConsumerRole).Append("\n");
            sb.Append("  InsuranceCompanyName: ").Append(InsuranceCompanyName).Append("\n");
            sb.Append("  InsuranceCompanyClaimNumber: ").Append(InsuranceCompanyClaimNumber).Append("\n");
            sb.Append("  BrokerName: ").Append(BrokerName).Append("\n");
            sb.Append("  BrokerClaimNumber: ").Append(BrokerClaimNumber).Append("\n");
            sb.Append("  EstimatedCost: ").Append(EstimatedCost).Append("\n");
            sb.Append("  GrossSettlement: ").Append(GrossSettlement).Append("\n");
            sb.Append("  NettSettlement: ").Append(NettSettlement).Append("\n");
            sb.Append("  DateOfLoss: ").Append(DateOfLoss).Append("\n");
            sb.Append("  ClaimStatus: ").Append(ClaimStatus).Append("\n");
            sb.Append("  ClaimClass: ").Append(ClaimClass).Append("\n");
            sb.Append("  CauseOfLoss: ").Append(CauseOfLoss).Append("\n");
            sb.Append("  RepudiationReason: ").Append(RepudiationReason).Append("\n");
            sb.Append("  ItemInceptionDate: ").Append(ItemInceptionDate).Append("\n");
            sb.Append("  DateOfEnquiry: ").Append(DateOfEnquiry).Append("\n");
            sb.Append("  EnquiryReason: ").Append(EnquiryReason).Append("\n");
            sb.Append("  Subcriber: ").Append(Subcriber).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  EnquiryType: ").Append(EnquiryType).Append("\n");
            sb.Append("  MatchedToIndividual: ").Append(MatchedToIndividual).Append("\n");
            sb.Append("  MatchedToVehicle: ").Append(MatchedToVehicle).Append("\n");
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
            return this.Equals(input as TransunionConsumer118NatisEnquiryHistoryUS);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118NatisEnquiryHistoryUS instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118NatisEnquiryHistoryUS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118NatisEnquiryHistoryUS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerRole == input.ConsumerRole ||
                    (this.ConsumerRole != null &&
                    this.ConsumerRole.Equals(input.ConsumerRole))
                ) && 
                (
                    this.InsuranceCompanyName == input.InsuranceCompanyName ||
                    (this.InsuranceCompanyName != null &&
                    this.InsuranceCompanyName.Equals(input.InsuranceCompanyName))
                ) && 
                (
                    this.InsuranceCompanyClaimNumber == input.InsuranceCompanyClaimNumber ||
                    (this.InsuranceCompanyClaimNumber != null &&
                    this.InsuranceCompanyClaimNumber.Equals(input.InsuranceCompanyClaimNumber))
                ) && 
                (
                    this.BrokerName == input.BrokerName ||
                    (this.BrokerName != null &&
                    this.BrokerName.Equals(input.BrokerName))
                ) && 
                (
                    this.BrokerClaimNumber == input.BrokerClaimNumber ||
                    (this.BrokerClaimNumber != null &&
                    this.BrokerClaimNumber.Equals(input.BrokerClaimNumber))
                ) && 
                (
                    this.EstimatedCost == input.EstimatedCost ||
                    (this.EstimatedCost != null &&
                    this.EstimatedCost.Equals(input.EstimatedCost))
                ) && 
                (
                    this.GrossSettlement == input.GrossSettlement ||
                    (this.GrossSettlement != null &&
                    this.GrossSettlement.Equals(input.GrossSettlement))
                ) && 
                (
                    this.NettSettlement == input.NettSettlement ||
                    (this.NettSettlement != null &&
                    this.NettSettlement.Equals(input.NettSettlement))
                ) && 
                (
                    this.DateOfLoss == input.DateOfLoss ||
                    (this.DateOfLoss != null &&
                    this.DateOfLoss.Equals(input.DateOfLoss))
                ) && 
                (
                    this.ClaimStatus == input.ClaimStatus ||
                    (this.ClaimStatus != null &&
                    this.ClaimStatus.Equals(input.ClaimStatus))
                ) && 
                (
                    this.ClaimClass == input.ClaimClass ||
                    (this.ClaimClass != null &&
                    this.ClaimClass.Equals(input.ClaimClass))
                ) && 
                (
                    this.CauseOfLoss == input.CauseOfLoss ||
                    (this.CauseOfLoss != null &&
                    this.CauseOfLoss.Equals(input.CauseOfLoss))
                ) && 
                (
                    this.RepudiationReason == input.RepudiationReason ||
                    (this.RepudiationReason != null &&
                    this.RepudiationReason.Equals(input.RepudiationReason))
                ) && 
                (
                    this.ItemInceptionDate == input.ItemInceptionDate ||
                    (this.ItemInceptionDate != null &&
                    this.ItemInceptionDate.Equals(input.ItemInceptionDate))
                ) && 
                (
                    this.DateOfEnquiry == input.DateOfEnquiry ||
                    (this.DateOfEnquiry != null &&
                    this.DateOfEnquiry.Equals(input.DateOfEnquiry))
                ) && 
                (
                    this.EnquiryReason == input.EnquiryReason ||
                    (this.EnquiryReason != null &&
                    this.EnquiryReason.Equals(input.EnquiryReason))
                ) && 
                (
                    this.Subcriber == input.Subcriber ||
                    (this.Subcriber != null &&
                    this.Subcriber.Equals(input.Subcriber))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.EnquiryType == input.EnquiryType ||
                    (this.EnquiryType != null &&
                    this.EnquiryType.Equals(input.EnquiryType))
                ) && 
                (
                    this.MatchedToIndividual == input.MatchedToIndividual ||
                    (this.MatchedToIndividual != null &&
                    this.MatchedToIndividual.Equals(input.MatchedToIndividual))
                ) && 
                (
                    this.MatchedToVehicle == input.MatchedToVehicle ||
                    (this.MatchedToVehicle != null &&
                    this.MatchedToVehicle.Equals(input.MatchedToVehicle))
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
                if (this.ConsumerRole != null)
                    hashCode = hashCode * 59 + this.ConsumerRole.GetHashCode();
                if (this.InsuranceCompanyName != null)
                    hashCode = hashCode * 59 + this.InsuranceCompanyName.GetHashCode();
                if (this.InsuranceCompanyClaimNumber != null)
                    hashCode = hashCode * 59 + this.InsuranceCompanyClaimNumber.GetHashCode();
                if (this.BrokerName != null)
                    hashCode = hashCode * 59 + this.BrokerName.GetHashCode();
                if (this.BrokerClaimNumber != null)
                    hashCode = hashCode * 59 + this.BrokerClaimNumber.GetHashCode();
                if (this.EstimatedCost != null)
                    hashCode = hashCode * 59 + this.EstimatedCost.GetHashCode();
                if (this.GrossSettlement != null)
                    hashCode = hashCode * 59 + this.GrossSettlement.GetHashCode();
                if (this.NettSettlement != null)
                    hashCode = hashCode * 59 + this.NettSettlement.GetHashCode();
                if (this.DateOfLoss != null)
                    hashCode = hashCode * 59 + this.DateOfLoss.GetHashCode();
                if (this.ClaimStatus != null)
                    hashCode = hashCode * 59 + this.ClaimStatus.GetHashCode();
                if (this.ClaimClass != null)
                    hashCode = hashCode * 59 + this.ClaimClass.GetHashCode();
                if (this.CauseOfLoss != null)
                    hashCode = hashCode * 59 + this.CauseOfLoss.GetHashCode();
                if (this.RepudiationReason != null)
                    hashCode = hashCode * 59 + this.RepudiationReason.GetHashCode();
                if (this.ItemInceptionDate != null)
                    hashCode = hashCode * 59 + this.ItemInceptionDate.GetHashCode();
                if (this.DateOfEnquiry != null)
                    hashCode = hashCode * 59 + this.DateOfEnquiry.GetHashCode();
                if (this.EnquiryReason != null)
                    hashCode = hashCode * 59 + this.EnquiryReason.GetHashCode();
                if (this.Subcriber != null)
                    hashCode = hashCode * 59 + this.Subcriber.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.EnquiryType != null)
                    hashCode = hashCode * 59 + this.EnquiryType.GetHashCode();
                if (this.MatchedToIndividual != null)
                    hashCode = hashCode * 59 + this.MatchedToIndividual.GetHashCode();
                if (this.MatchedToVehicle != null)
                    hashCode = hashCode * 59 + this.MatchedToVehicle.GetHashCode();
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
