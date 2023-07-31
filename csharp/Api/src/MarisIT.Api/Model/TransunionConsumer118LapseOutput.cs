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
    /// TransunionConsumer118LapseOutput
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118LapseOutput :  IEquatable<TransunionConsumer118LapseOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118LapseOutput" /> class.
        /// </summary>
        /// <param name="extensionData">extensionData.</param>
        /// <param name="applicationID">applicationID.</param>
        /// <param name="consumerNumber">consumerNumber.</param>
        /// <param name="dob">dob.</param>
        /// <param name="errorDescription">errorDescription.</param>
        /// <param name="forename">forename.</param>
        /// <param name="genericLapseScore">genericLapseScore.</param>
        /// <param name="genericLapseScoreBand">genericLapseScoreBand.</param>
        /// <param name="idNumber">idNumber.</param>
        /// <param name="otherID">otherID.</param>
        /// <param name="policyFilter1">policyFilter1.</param>
        /// <param name="policyFilter2">policyFilter2.</param>
        /// <param name="policyFilter3">policyFilter3.</param>
        /// <param name="reason">reason.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="status">status.</param>
        /// <param name="surname">surname.</param>
        public TransunionConsumer118LapseOutput(Object extensionData = default(Object), string applicationID = default(string), string consumerNumber = default(string), string dob = default(string), string errorDescription = default(string), string forename = default(string), int genericLapseScore = default(int), string genericLapseScoreBand = default(string), string idNumber = default(string), string otherID = default(string), int policyFilter1 = default(int), int policyFilter2 = default(int), int policyFilter3 = default(int), string reason = default(string), string reasonCode = default(string), string status = default(string), string surname = default(string))
        {
            this.ApplicationID = applicationID;
            this.ConsumerNumber = consumerNumber;
            this.Dob = dob;
            this.ErrorDescription = errorDescription;
            this.Forename = forename;
            this.GenericLapseScoreBand = genericLapseScoreBand;
            this.IdNumber = idNumber;
            this.OtherID = otherID;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.Status = status;
            this.Surname = surname;
            this.ExtensionData = extensionData;
            this.ApplicationID = applicationID;
            this.ConsumerNumber = consumerNumber;
            this.Dob = dob;
            this.ErrorDescription = errorDescription;
            this.Forename = forename;
            this.GenericLapseScore = genericLapseScore;
            this.GenericLapseScoreBand = genericLapseScoreBand;
            this.IdNumber = idNumber;
            this.OtherID = otherID;
            this.PolicyFilter1 = policyFilter1;
            this.PolicyFilter2 = policyFilter2;
            this.PolicyFilter3 = policyFilter3;
            this.Reason = reason;
            this.ReasonCode = reasonCode;
            this.Status = status;
            this.Surname = surname;
        }

        /// <summary>
        /// Gets or Sets ExtensionData
        /// </summary>
        [DataMember(Name="extensionData", EmitDefaultValue=false)]
        public Object ExtensionData { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationID
        /// </summary>
        [DataMember(Name="applicationID", EmitDefaultValue=true)]
        public string ApplicationID { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerNumber
        /// </summary>
        [DataMember(Name="consumerNumber", EmitDefaultValue=true)]
        public string ConsumerNumber { get; set; }

        /// <summary>
        /// Gets or Sets Dob
        /// </summary>
        [DataMember(Name="dob", EmitDefaultValue=true)]
        public string Dob { get; set; }

        /// <summary>
        /// Gets or Sets ErrorDescription
        /// </summary>
        [DataMember(Name="errorDescription", EmitDefaultValue=true)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or Sets Forename
        /// </summary>
        [DataMember(Name="forename", EmitDefaultValue=true)]
        public string Forename { get; set; }

        /// <summary>
        /// Gets or Sets GenericLapseScore
        /// </summary>
        [DataMember(Name="genericLapseScore", EmitDefaultValue=false)]
        public int GenericLapseScore { get; set; }

        /// <summary>
        /// Gets or Sets GenericLapseScoreBand
        /// </summary>
        [DataMember(Name="genericLapseScoreBand", EmitDefaultValue=true)]
        public string GenericLapseScoreBand { get; set; }

        /// <summary>
        /// Gets or Sets IdNumber
        /// </summary>
        [DataMember(Name="idNumber", EmitDefaultValue=true)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Gets or Sets OtherID
        /// </summary>
        [DataMember(Name="otherID", EmitDefaultValue=true)]
        public string OtherID { get; set; }

        /// <summary>
        /// Gets or Sets PolicyFilter1
        /// </summary>
        [DataMember(Name="policyFilter1", EmitDefaultValue=false)]
        public int PolicyFilter1 { get; set; }

        /// <summary>
        /// Gets or Sets PolicyFilter2
        /// </summary>
        [DataMember(Name="policyFilter2", EmitDefaultValue=false)]
        public int PolicyFilter2 { get; set; }

        /// <summary>
        /// Gets or Sets PolicyFilter3
        /// </summary>
        [DataMember(Name="policyFilter3", EmitDefaultValue=false)]
        public int PolicyFilter3 { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=true)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="reasonCode", EmitDefaultValue=true)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public string Status { get; set; }

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
            sb.Append("class TransunionConsumer118LapseOutput {\n");
            sb.Append("  ExtensionData: ").Append(ExtensionData).Append("\n");
            sb.Append("  ApplicationID: ").Append(ApplicationID).Append("\n");
            sb.Append("  ConsumerNumber: ").Append(ConsumerNumber).Append("\n");
            sb.Append("  Dob: ").Append(Dob).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  Forename: ").Append(Forename).Append("\n");
            sb.Append("  GenericLapseScore: ").Append(GenericLapseScore).Append("\n");
            sb.Append("  GenericLapseScoreBand: ").Append(GenericLapseScoreBand).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  OtherID: ").Append(OtherID).Append("\n");
            sb.Append("  PolicyFilter1: ").Append(PolicyFilter1).Append("\n");
            sb.Append("  PolicyFilter2: ").Append(PolicyFilter2).Append("\n");
            sb.Append("  PolicyFilter3: ").Append(PolicyFilter3).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TransunionConsumer118LapseOutput);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118LapseOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118LapseOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118LapseOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtensionData == input.ExtensionData ||
                    (this.ExtensionData != null &&
                    this.ExtensionData.Equals(input.ExtensionData))
                ) && 
                (
                    this.ApplicationID == input.ApplicationID ||
                    (this.ApplicationID != null &&
                    this.ApplicationID.Equals(input.ApplicationID))
                ) && 
                (
                    this.ConsumerNumber == input.ConsumerNumber ||
                    (this.ConsumerNumber != null &&
                    this.ConsumerNumber.Equals(input.ConsumerNumber))
                ) && 
                (
                    this.Dob == input.Dob ||
                    (this.Dob != null &&
                    this.Dob.Equals(input.Dob))
                ) && 
                (
                    this.ErrorDescription == input.ErrorDescription ||
                    (this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(input.ErrorDescription))
                ) && 
                (
                    this.Forename == input.Forename ||
                    (this.Forename != null &&
                    this.Forename.Equals(input.Forename))
                ) && 
                (
                    this.GenericLapseScore == input.GenericLapseScore ||
                    (this.GenericLapseScore != null &&
                    this.GenericLapseScore.Equals(input.GenericLapseScore))
                ) && 
                (
                    this.GenericLapseScoreBand == input.GenericLapseScoreBand ||
                    (this.GenericLapseScoreBand != null &&
                    this.GenericLapseScoreBand.Equals(input.GenericLapseScoreBand))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.OtherID == input.OtherID ||
                    (this.OtherID != null &&
                    this.OtherID.Equals(input.OtherID))
                ) && 
                (
                    this.PolicyFilter1 == input.PolicyFilter1 ||
                    (this.PolicyFilter1 != null &&
                    this.PolicyFilter1.Equals(input.PolicyFilter1))
                ) && 
                (
                    this.PolicyFilter2 == input.PolicyFilter2 ||
                    (this.PolicyFilter2 != null &&
                    this.PolicyFilter2.Equals(input.PolicyFilter2))
                ) && 
                (
                    this.PolicyFilter3 == input.PolicyFilter3 ||
                    (this.PolicyFilter3 != null &&
                    this.PolicyFilter3.Equals(input.PolicyFilter3))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.ReasonCode == input.ReasonCode ||
                    (this.ReasonCode != null &&
                    this.ReasonCode.Equals(input.ReasonCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ExtensionData != null)
                    hashCode = hashCode * 59 + this.ExtensionData.GetHashCode();
                if (this.ApplicationID != null)
                    hashCode = hashCode * 59 + this.ApplicationID.GetHashCode();
                if (this.ConsumerNumber != null)
                    hashCode = hashCode * 59 + this.ConsumerNumber.GetHashCode();
                if (this.Dob != null)
                    hashCode = hashCode * 59 + this.Dob.GetHashCode();
                if (this.ErrorDescription != null)
                    hashCode = hashCode * 59 + this.ErrorDescription.GetHashCode();
                if (this.Forename != null)
                    hashCode = hashCode * 59 + this.Forename.GetHashCode();
                if (this.GenericLapseScore != null)
                    hashCode = hashCode * 59 + this.GenericLapseScore.GetHashCode();
                if (this.GenericLapseScoreBand != null)
                    hashCode = hashCode * 59 + this.GenericLapseScoreBand.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.OtherID != null)
                    hashCode = hashCode * 59 + this.OtherID.GetHashCode();
                if (this.PolicyFilter1 != null)
                    hashCode = hashCode * 59 + this.PolicyFilter1.GetHashCode();
                if (this.PolicyFilter2 != null)
                    hashCode = hashCode * 59 + this.PolicyFilter2.GetHashCode();
                if (this.PolicyFilter3 != null)
                    hashCode = hashCode * 59 + this.PolicyFilter3.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.ReasonCode != null)
                    hashCode = hashCode * 59 + this.ReasonCode.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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