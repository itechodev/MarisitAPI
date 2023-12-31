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
    /// TransunionConsumer118NLRCounterSegmentMC50
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118NLRCounterSegmentMC50 :  IEquatable<TransunionConsumer118NLRCounterSegmentMC50>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118NLRCounterSegmentMC50" /> class.
        /// </summary>
        /// <param name="segmentCode">segmentCode.</param>
        /// <param name="consumerNumber">consumerNumber.</param>
        /// <param name="currentYearEnquiriesClient">currentYearEnquiriesClient.</param>
        /// <param name="currentYearEnquiriesOtherSubscribers">currentYearEnquiriesOtherSubscribers.</param>
        /// <param name="currentYearPositiveNLRLoans">currentYearPositiveNLRLoans.</param>
        /// <param name="currentYearHighestMonthsInArrears">currentYearHighestMonthsInArrears.</param>
        /// <param name="previousYearEnquiriesClient">previousYearEnquiriesClient.</param>
        /// <param name="previousYearEnquiriesOtherSubscribers">previousYearEnquiriesOtherSubscribers.</param>
        /// <param name="previousYearPositiveNLRLoans">previousYearPositiveNLRLoans.</param>
        /// <param name="previousYearHighestMonthsInArrears">previousYearHighestMonthsInArrears.</param>
        /// <param name="allOtherYearEnquiriesClient">allOtherYearEnquiriesClient.</param>
        /// <param name="allOtherYearEnquiriesOtherSubscribers">allOtherYearEnquiriesOtherSubscribers.</param>
        /// <param name="allOtherYearPositiveNLRLoans">allOtherYearPositiveNLRLoans.</param>
        /// <param name="allOtherYearsHighestMonthsInArrears">allOtherYearsHighestMonthsInArrears.</param>
        /// <param name="cumulativeInstalmentValue">cumulativeInstalmentValue.</param>
        /// <param name="cumulativeOutstandingBalance">cumulativeOutstandingBalance.</param>
        /// <param name="worstMonthInArrearsEver">worstMonthInArrearsEver.</param>
        public TransunionConsumer118NLRCounterSegmentMC50(string segmentCode = default(string), string consumerNumber = default(string), string currentYearEnquiriesClient = default(string), string currentYearEnquiriesOtherSubscribers = default(string), string currentYearPositiveNLRLoans = default(string), string currentYearHighestMonthsInArrears = default(string), string previousYearEnquiriesClient = default(string), string previousYearEnquiriesOtherSubscribers = default(string), string previousYearPositiveNLRLoans = default(string), string previousYearHighestMonthsInArrears = default(string), string allOtherYearEnquiriesClient = default(string), string allOtherYearEnquiriesOtherSubscribers = default(string), string allOtherYearPositiveNLRLoans = default(string), string allOtherYearsHighestMonthsInArrears = default(string), string cumulativeInstalmentValue = default(string), string cumulativeOutstandingBalance = default(string), string worstMonthInArrearsEver = default(string))
        {
            this.SegmentCode = segmentCode;
            this.ConsumerNumber = consumerNumber;
            this.CurrentYearEnquiriesClient = currentYearEnquiriesClient;
            this.CurrentYearEnquiriesOtherSubscribers = currentYearEnquiriesOtherSubscribers;
            this.CurrentYearPositiveNLRLoans = currentYearPositiveNLRLoans;
            this.CurrentYearHighestMonthsInArrears = currentYearHighestMonthsInArrears;
            this.PreviousYearEnquiriesClient = previousYearEnquiriesClient;
            this.PreviousYearEnquiriesOtherSubscribers = previousYearEnquiriesOtherSubscribers;
            this.PreviousYearPositiveNLRLoans = previousYearPositiveNLRLoans;
            this.PreviousYearHighestMonthsInArrears = previousYearHighestMonthsInArrears;
            this.AllOtherYearEnquiriesClient = allOtherYearEnquiriesClient;
            this.AllOtherYearEnquiriesOtherSubscribers = allOtherYearEnquiriesOtherSubscribers;
            this.AllOtherYearPositiveNLRLoans = allOtherYearPositiveNLRLoans;
            this.AllOtherYearsHighestMonthsInArrears = allOtherYearsHighestMonthsInArrears;
            this.CumulativeInstalmentValue = cumulativeInstalmentValue;
            this.CumulativeOutstandingBalance = cumulativeOutstandingBalance;
            this.WorstMonthInArrearsEver = worstMonthInArrearsEver;
            this.SegmentCode = segmentCode;
            this.ConsumerNumber = consumerNumber;
            this.CurrentYearEnquiriesClient = currentYearEnquiriesClient;
            this.CurrentYearEnquiriesOtherSubscribers = currentYearEnquiriesOtherSubscribers;
            this.CurrentYearPositiveNLRLoans = currentYearPositiveNLRLoans;
            this.CurrentYearHighestMonthsInArrears = currentYearHighestMonthsInArrears;
            this.PreviousYearEnquiriesClient = previousYearEnquiriesClient;
            this.PreviousYearEnquiriesOtherSubscribers = previousYearEnquiriesOtherSubscribers;
            this.PreviousYearPositiveNLRLoans = previousYearPositiveNLRLoans;
            this.PreviousYearHighestMonthsInArrears = previousYearHighestMonthsInArrears;
            this.AllOtherYearEnquiriesClient = allOtherYearEnquiriesClient;
            this.AllOtherYearEnquiriesOtherSubscribers = allOtherYearEnquiriesOtherSubscribers;
            this.AllOtherYearPositiveNLRLoans = allOtherYearPositiveNLRLoans;
            this.AllOtherYearsHighestMonthsInArrears = allOtherYearsHighestMonthsInArrears;
            this.CumulativeInstalmentValue = cumulativeInstalmentValue;
            this.CumulativeOutstandingBalance = cumulativeOutstandingBalance;
            this.WorstMonthInArrearsEver = worstMonthInArrearsEver;
        }

        /// <summary>
        /// Gets or Sets SegmentCode
        /// </summary>
        [DataMember(Name="segmentCode", EmitDefaultValue=true)]
        public string SegmentCode { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerNumber
        /// </summary>
        [DataMember(Name="consumerNumber", EmitDefaultValue=true)]
        public string ConsumerNumber { get; set; }

        /// <summary>
        /// Gets or Sets CurrentYearEnquiriesClient
        /// </summary>
        [DataMember(Name="currentYearEnquiriesClient", EmitDefaultValue=true)]
        public string CurrentYearEnquiriesClient { get; set; }

        /// <summary>
        /// Gets or Sets CurrentYearEnquiriesOtherSubscribers
        /// </summary>
        [DataMember(Name="currentYearEnquiriesOtherSubscribers", EmitDefaultValue=true)]
        public string CurrentYearEnquiriesOtherSubscribers { get; set; }

        /// <summary>
        /// Gets or Sets CurrentYearPositiveNLRLoans
        /// </summary>
        [DataMember(Name="currentYearPositiveNLRLoans", EmitDefaultValue=true)]
        public string CurrentYearPositiveNLRLoans { get; set; }

        /// <summary>
        /// Gets or Sets CurrentYearHighestMonthsInArrears
        /// </summary>
        [DataMember(Name="currentYearHighestMonthsInArrears", EmitDefaultValue=true)]
        public string CurrentYearHighestMonthsInArrears { get; set; }

        /// <summary>
        /// Gets or Sets PreviousYearEnquiriesClient
        /// </summary>
        [DataMember(Name="previousYearEnquiriesClient", EmitDefaultValue=true)]
        public string PreviousYearEnquiriesClient { get; set; }

        /// <summary>
        /// Gets or Sets PreviousYearEnquiriesOtherSubscribers
        /// </summary>
        [DataMember(Name="previousYearEnquiriesOtherSubscribers", EmitDefaultValue=true)]
        public string PreviousYearEnquiriesOtherSubscribers { get; set; }

        /// <summary>
        /// Gets or Sets PreviousYearPositiveNLRLoans
        /// </summary>
        [DataMember(Name="previousYearPositiveNLRLoans", EmitDefaultValue=true)]
        public string PreviousYearPositiveNLRLoans { get; set; }

        /// <summary>
        /// Gets or Sets PreviousYearHighestMonthsInArrears
        /// </summary>
        [DataMember(Name="previousYearHighestMonthsInArrears", EmitDefaultValue=true)]
        public string PreviousYearHighestMonthsInArrears { get; set; }

        /// <summary>
        /// Gets or Sets AllOtherYearEnquiriesClient
        /// </summary>
        [DataMember(Name="allOtherYearEnquiriesClient", EmitDefaultValue=true)]
        public string AllOtherYearEnquiriesClient { get; set; }

        /// <summary>
        /// Gets or Sets AllOtherYearEnquiriesOtherSubscribers
        /// </summary>
        [DataMember(Name="allOtherYearEnquiriesOtherSubscribers", EmitDefaultValue=true)]
        public string AllOtherYearEnquiriesOtherSubscribers { get; set; }

        /// <summary>
        /// Gets or Sets AllOtherYearPositiveNLRLoans
        /// </summary>
        [DataMember(Name="allOtherYearPositiveNLRLoans", EmitDefaultValue=true)]
        public string AllOtherYearPositiveNLRLoans { get; set; }

        /// <summary>
        /// Gets or Sets AllOtherYearsHighestMonthsInArrears
        /// </summary>
        [DataMember(Name="allOtherYearsHighestMonthsInArrears", EmitDefaultValue=true)]
        public string AllOtherYearsHighestMonthsInArrears { get; set; }

        /// <summary>
        /// Gets or Sets CumulativeInstalmentValue
        /// </summary>
        [DataMember(Name="cumulativeInstalmentValue", EmitDefaultValue=true)]
        public string CumulativeInstalmentValue { get; set; }

        /// <summary>
        /// Gets or Sets CumulativeOutstandingBalance
        /// </summary>
        [DataMember(Name="cumulativeOutstandingBalance", EmitDefaultValue=true)]
        public string CumulativeOutstandingBalance { get; set; }

        /// <summary>
        /// Gets or Sets WorstMonthInArrearsEver
        /// </summary>
        [DataMember(Name="worstMonthInArrearsEver", EmitDefaultValue=true)]
        public string WorstMonthInArrearsEver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118NLRCounterSegmentMC50 {\n");
            sb.Append("  SegmentCode: ").Append(SegmentCode).Append("\n");
            sb.Append("  ConsumerNumber: ").Append(ConsumerNumber).Append("\n");
            sb.Append("  CurrentYearEnquiriesClient: ").Append(CurrentYearEnquiriesClient).Append("\n");
            sb.Append("  CurrentYearEnquiriesOtherSubscribers: ").Append(CurrentYearEnquiriesOtherSubscribers).Append("\n");
            sb.Append("  CurrentYearPositiveNLRLoans: ").Append(CurrentYearPositiveNLRLoans).Append("\n");
            sb.Append("  CurrentYearHighestMonthsInArrears: ").Append(CurrentYearHighestMonthsInArrears).Append("\n");
            sb.Append("  PreviousYearEnquiriesClient: ").Append(PreviousYearEnquiriesClient).Append("\n");
            sb.Append("  PreviousYearEnquiriesOtherSubscribers: ").Append(PreviousYearEnquiriesOtherSubscribers).Append("\n");
            sb.Append("  PreviousYearPositiveNLRLoans: ").Append(PreviousYearPositiveNLRLoans).Append("\n");
            sb.Append("  PreviousYearHighestMonthsInArrears: ").Append(PreviousYearHighestMonthsInArrears).Append("\n");
            sb.Append("  AllOtherYearEnquiriesClient: ").Append(AllOtherYearEnquiriesClient).Append("\n");
            sb.Append("  AllOtherYearEnquiriesOtherSubscribers: ").Append(AllOtherYearEnquiriesOtherSubscribers).Append("\n");
            sb.Append("  AllOtherYearPositiveNLRLoans: ").Append(AllOtherYearPositiveNLRLoans).Append("\n");
            sb.Append("  AllOtherYearsHighestMonthsInArrears: ").Append(AllOtherYearsHighestMonthsInArrears).Append("\n");
            sb.Append("  CumulativeInstalmentValue: ").Append(CumulativeInstalmentValue).Append("\n");
            sb.Append("  CumulativeOutstandingBalance: ").Append(CumulativeOutstandingBalance).Append("\n");
            sb.Append("  WorstMonthInArrearsEver: ").Append(WorstMonthInArrearsEver).Append("\n");
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
            return this.Equals(input as TransunionConsumer118NLRCounterSegmentMC50);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118NLRCounterSegmentMC50 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118NLRCounterSegmentMC50 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118NLRCounterSegmentMC50 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SegmentCode == input.SegmentCode ||
                    (this.SegmentCode != null &&
                    this.SegmentCode.Equals(input.SegmentCode))
                ) && 
                (
                    this.ConsumerNumber == input.ConsumerNumber ||
                    (this.ConsumerNumber != null &&
                    this.ConsumerNumber.Equals(input.ConsumerNumber))
                ) && 
                (
                    this.CurrentYearEnquiriesClient == input.CurrentYearEnquiriesClient ||
                    (this.CurrentYearEnquiriesClient != null &&
                    this.CurrentYearEnquiriesClient.Equals(input.CurrentYearEnquiriesClient))
                ) && 
                (
                    this.CurrentYearEnquiriesOtherSubscribers == input.CurrentYearEnquiriesOtherSubscribers ||
                    (this.CurrentYearEnquiriesOtherSubscribers != null &&
                    this.CurrentYearEnquiriesOtherSubscribers.Equals(input.CurrentYearEnquiriesOtherSubscribers))
                ) && 
                (
                    this.CurrentYearPositiveNLRLoans == input.CurrentYearPositiveNLRLoans ||
                    (this.CurrentYearPositiveNLRLoans != null &&
                    this.CurrentYearPositiveNLRLoans.Equals(input.CurrentYearPositiveNLRLoans))
                ) && 
                (
                    this.CurrentYearHighestMonthsInArrears == input.CurrentYearHighestMonthsInArrears ||
                    (this.CurrentYearHighestMonthsInArrears != null &&
                    this.CurrentYearHighestMonthsInArrears.Equals(input.CurrentYearHighestMonthsInArrears))
                ) && 
                (
                    this.PreviousYearEnquiriesClient == input.PreviousYearEnquiriesClient ||
                    (this.PreviousYearEnquiriesClient != null &&
                    this.PreviousYearEnquiriesClient.Equals(input.PreviousYearEnquiriesClient))
                ) && 
                (
                    this.PreviousYearEnquiriesOtherSubscribers == input.PreviousYearEnquiriesOtherSubscribers ||
                    (this.PreviousYearEnquiriesOtherSubscribers != null &&
                    this.PreviousYearEnquiriesOtherSubscribers.Equals(input.PreviousYearEnquiriesOtherSubscribers))
                ) && 
                (
                    this.PreviousYearPositiveNLRLoans == input.PreviousYearPositiveNLRLoans ||
                    (this.PreviousYearPositiveNLRLoans != null &&
                    this.PreviousYearPositiveNLRLoans.Equals(input.PreviousYearPositiveNLRLoans))
                ) && 
                (
                    this.PreviousYearHighestMonthsInArrears == input.PreviousYearHighestMonthsInArrears ||
                    (this.PreviousYearHighestMonthsInArrears != null &&
                    this.PreviousYearHighestMonthsInArrears.Equals(input.PreviousYearHighestMonthsInArrears))
                ) && 
                (
                    this.AllOtherYearEnquiriesClient == input.AllOtherYearEnquiriesClient ||
                    (this.AllOtherYearEnquiriesClient != null &&
                    this.AllOtherYearEnquiriesClient.Equals(input.AllOtherYearEnquiriesClient))
                ) && 
                (
                    this.AllOtherYearEnquiriesOtherSubscribers == input.AllOtherYearEnquiriesOtherSubscribers ||
                    (this.AllOtherYearEnquiriesOtherSubscribers != null &&
                    this.AllOtherYearEnquiriesOtherSubscribers.Equals(input.AllOtherYearEnquiriesOtherSubscribers))
                ) && 
                (
                    this.AllOtherYearPositiveNLRLoans == input.AllOtherYearPositiveNLRLoans ||
                    (this.AllOtherYearPositiveNLRLoans != null &&
                    this.AllOtherYearPositiveNLRLoans.Equals(input.AllOtherYearPositiveNLRLoans))
                ) && 
                (
                    this.AllOtherYearsHighestMonthsInArrears == input.AllOtherYearsHighestMonthsInArrears ||
                    (this.AllOtherYearsHighestMonthsInArrears != null &&
                    this.AllOtherYearsHighestMonthsInArrears.Equals(input.AllOtherYearsHighestMonthsInArrears))
                ) && 
                (
                    this.CumulativeInstalmentValue == input.CumulativeInstalmentValue ||
                    (this.CumulativeInstalmentValue != null &&
                    this.CumulativeInstalmentValue.Equals(input.CumulativeInstalmentValue))
                ) && 
                (
                    this.CumulativeOutstandingBalance == input.CumulativeOutstandingBalance ||
                    (this.CumulativeOutstandingBalance != null &&
                    this.CumulativeOutstandingBalance.Equals(input.CumulativeOutstandingBalance))
                ) && 
                (
                    this.WorstMonthInArrearsEver == input.WorstMonthInArrearsEver ||
                    (this.WorstMonthInArrearsEver != null &&
                    this.WorstMonthInArrearsEver.Equals(input.WorstMonthInArrearsEver))
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
                if (this.SegmentCode != null)
                    hashCode = hashCode * 59 + this.SegmentCode.GetHashCode();
                if (this.ConsumerNumber != null)
                    hashCode = hashCode * 59 + this.ConsumerNumber.GetHashCode();
                if (this.CurrentYearEnquiriesClient != null)
                    hashCode = hashCode * 59 + this.CurrentYearEnquiriesClient.GetHashCode();
                if (this.CurrentYearEnquiriesOtherSubscribers != null)
                    hashCode = hashCode * 59 + this.CurrentYearEnquiriesOtherSubscribers.GetHashCode();
                if (this.CurrentYearPositiveNLRLoans != null)
                    hashCode = hashCode * 59 + this.CurrentYearPositiveNLRLoans.GetHashCode();
                if (this.CurrentYearHighestMonthsInArrears != null)
                    hashCode = hashCode * 59 + this.CurrentYearHighestMonthsInArrears.GetHashCode();
                if (this.PreviousYearEnquiriesClient != null)
                    hashCode = hashCode * 59 + this.PreviousYearEnquiriesClient.GetHashCode();
                if (this.PreviousYearEnquiriesOtherSubscribers != null)
                    hashCode = hashCode * 59 + this.PreviousYearEnquiriesOtherSubscribers.GetHashCode();
                if (this.PreviousYearPositiveNLRLoans != null)
                    hashCode = hashCode * 59 + this.PreviousYearPositiveNLRLoans.GetHashCode();
                if (this.PreviousYearHighestMonthsInArrears != null)
                    hashCode = hashCode * 59 + this.PreviousYearHighestMonthsInArrears.GetHashCode();
                if (this.AllOtherYearEnquiriesClient != null)
                    hashCode = hashCode * 59 + this.AllOtherYearEnquiriesClient.GetHashCode();
                if (this.AllOtherYearEnquiriesOtherSubscribers != null)
                    hashCode = hashCode * 59 + this.AllOtherYearEnquiriesOtherSubscribers.GetHashCode();
                if (this.AllOtherYearPositiveNLRLoans != null)
                    hashCode = hashCode * 59 + this.AllOtherYearPositiveNLRLoans.GetHashCode();
                if (this.AllOtherYearsHighestMonthsInArrears != null)
                    hashCode = hashCode * 59 + this.AllOtherYearsHighestMonthsInArrears.GetHashCode();
                if (this.CumulativeInstalmentValue != null)
                    hashCode = hashCode * 59 + this.CumulativeInstalmentValue.GetHashCode();
                if (this.CumulativeOutstandingBalance != null)
                    hashCode = hashCode * 59 + this.CumulativeOutstandingBalance.GetHashCode();
                if (this.WorstMonthInArrearsEver != null)
                    hashCode = hashCode * 59 + this.WorstMonthInArrearsEver.GetHashCode();
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
