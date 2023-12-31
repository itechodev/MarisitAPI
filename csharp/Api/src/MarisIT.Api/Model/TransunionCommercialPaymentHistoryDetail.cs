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
    /// TransunionCommercialPaymentHistoryDetail
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialPaymentHistoryDetail :  IEquatable<TransunionCommercialPaymentHistoryDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialPaymentHistoryDetail" /> class.
        /// </summary>
        /// <param name="period">period.</param>
        /// <param name="numberSuppliers">numberSuppliers.</param>
        /// <param name="creditLimit">creditLimit.</param>
        /// <param name="totalCreditLimit">totalCreditLimit.</param>
        /// <param name="totalOverduePercentage">totalOverduePercentage.</param>
        /// <param name="totalCurrentPercentage">totalCurrentPercentage.</param>
        /// <param name="days30Percentage">days30Percentage.</param>
        /// <param name="days60Percentage">days60Percentage.</param>
        /// <param name="days90Percentage">days90Percentage.</param>
        /// <param name="days120Percentage">days120Percentage.</param>
        public TransunionCommercialPaymentHistoryDetail(string period = default(string), string numberSuppliers = default(string), string creditLimit = default(string), string totalCreditLimit = default(string), string totalOverduePercentage = default(string), string totalCurrentPercentage = default(string), string days30Percentage = default(string), string days60Percentage = default(string), string days90Percentage = default(string), string days120Percentage = default(string))
        {
            this.Period = period;
            this.NumberSuppliers = numberSuppliers;
            this.CreditLimit = creditLimit;
            this.TotalCreditLimit = totalCreditLimit;
            this.TotalOverduePercentage = totalOverduePercentage;
            this.TotalCurrentPercentage = totalCurrentPercentage;
            this.Days30Percentage = days30Percentage;
            this.Days60Percentage = days60Percentage;
            this.Days90Percentage = days90Percentage;
            this.Days120Percentage = days120Percentage;
            this.Period = period;
            this.NumberSuppliers = numberSuppliers;
            this.CreditLimit = creditLimit;
            this.TotalCreditLimit = totalCreditLimit;
            this.TotalOverduePercentage = totalOverduePercentage;
            this.TotalCurrentPercentage = totalCurrentPercentage;
            this.Days30Percentage = days30Percentage;
            this.Days60Percentage = days60Percentage;
            this.Days90Percentage = days90Percentage;
            this.Days120Percentage = days120Percentage;
        }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=true)]
        public string Period { get; set; }

        /// <summary>
        /// Gets or Sets NumberSuppliers
        /// </summary>
        [DataMember(Name="numberSuppliers", EmitDefaultValue=true)]
        public string NumberSuppliers { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [DataMember(Name="creditLimit", EmitDefaultValue=true)]
        public string CreditLimit { get; set; }

        /// <summary>
        /// Gets or Sets TotalCreditLimit
        /// </summary>
        [DataMember(Name="totalCreditLimit", EmitDefaultValue=true)]
        public string TotalCreditLimit { get; set; }

        /// <summary>
        /// Gets or Sets TotalOverduePercentage
        /// </summary>
        [DataMember(Name="totalOverduePercentage", EmitDefaultValue=true)]
        public string TotalOverduePercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalCurrentPercentage
        /// </summary>
        [DataMember(Name="totalCurrentPercentage", EmitDefaultValue=true)]
        public string TotalCurrentPercentage { get; set; }

        /// <summary>
        /// Gets or Sets Days30Percentage
        /// </summary>
        [DataMember(Name="days30Percentage", EmitDefaultValue=true)]
        public string Days30Percentage { get; set; }

        /// <summary>
        /// Gets or Sets Days60Percentage
        /// </summary>
        [DataMember(Name="days60Percentage", EmitDefaultValue=true)]
        public string Days60Percentage { get; set; }

        /// <summary>
        /// Gets or Sets Days90Percentage
        /// </summary>
        [DataMember(Name="days90Percentage", EmitDefaultValue=true)]
        public string Days90Percentage { get; set; }

        /// <summary>
        /// Gets or Sets Days120Percentage
        /// </summary>
        [DataMember(Name="days120Percentage", EmitDefaultValue=true)]
        public string Days120Percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialPaymentHistoryDetail {\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  NumberSuppliers: ").Append(NumberSuppliers).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  TotalCreditLimit: ").Append(TotalCreditLimit).Append("\n");
            sb.Append("  TotalOverduePercentage: ").Append(TotalOverduePercentage).Append("\n");
            sb.Append("  TotalCurrentPercentage: ").Append(TotalCurrentPercentage).Append("\n");
            sb.Append("  Days30Percentage: ").Append(Days30Percentage).Append("\n");
            sb.Append("  Days60Percentage: ").Append(Days60Percentage).Append("\n");
            sb.Append("  Days90Percentage: ").Append(Days90Percentage).Append("\n");
            sb.Append("  Days120Percentage: ").Append(Days120Percentage).Append("\n");
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
            return this.Equals(input as TransunionCommercialPaymentHistoryDetail);
        }

        /// <summary>
        /// Returns true if TransunionCommercialPaymentHistoryDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialPaymentHistoryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialPaymentHistoryDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.NumberSuppliers == input.NumberSuppliers ||
                    (this.NumberSuppliers != null &&
                    this.NumberSuppliers.Equals(input.NumberSuppliers))
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    (this.CreditLimit != null &&
                    this.CreditLimit.Equals(input.CreditLimit))
                ) && 
                (
                    this.TotalCreditLimit == input.TotalCreditLimit ||
                    (this.TotalCreditLimit != null &&
                    this.TotalCreditLimit.Equals(input.TotalCreditLimit))
                ) && 
                (
                    this.TotalOverduePercentage == input.TotalOverduePercentage ||
                    (this.TotalOverduePercentage != null &&
                    this.TotalOverduePercentage.Equals(input.TotalOverduePercentage))
                ) && 
                (
                    this.TotalCurrentPercentage == input.TotalCurrentPercentage ||
                    (this.TotalCurrentPercentage != null &&
                    this.TotalCurrentPercentage.Equals(input.TotalCurrentPercentage))
                ) && 
                (
                    this.Days30Percentage == input.Days30Percentage ||
                    (this.Days30Percentage != null &&
                    this.Days30Percentage.Equals(input.Days30Percentage))
                ) && 
                (
                    this.Days60Percentage == input.Days60Percentage ||
                    (this.Days60Percentage != null &&
                    this.Days60Percentage.Equals(input.Days60Percentage))
                ) && 
                (
                    this.Days90Percentage == input.Days90Percentage ||
                    (this.Days90Percentage != null &&
                    this.Days90Percentage.Equals(input.Days90Percentage))
                ) && 
                (
                    this.Days120Percentage == input.Days120Percentage ||
                    (this.Days120Percentage != null &&
                    this.Days120Percentage.Equals(input.Days120Percentage))
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
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.NumberSuppliers != null)
                    hashCode = hashCode * 59 + this.NumberSuppliers.GetHashCode();
                if (this.CreditLimit != null)
                    hashCode = hashCode * 59 + this.CreditLimit.GetHashCode();
                if (this.TotalCreditLimit != null)
                    hashCode = hashCode * 59 + this.TotalCreditLimit.GetHashCode();
                if (this.TotalOverduePercentage != null)
                    hashCode = hashCode * 59 + this.TotalOverduePercentage.GetHashCode();
                if (this.TotalCurrentPercentage != null)
                    hashCode = hashCode * 59 + this.TotalCurrentPercentage.GetHashCode();
                if (this.Days30Percentage != null)
                    hashCode = hashCode * 59 + this.Days30Percentage.GetHashCode();
                if (this.Days60Percentage != null)
                    hashCode = hashCode * 59 + this.Days60Percentage.GetHashCode();
                if (this.Days90Percentage != null)
                    hashCode = hashCode * 59 + this.Days90Percentage.GetHashCode();
                if (this.Days120Percentage != null)
                    hashCode = hashCode * 59 + this.Days120Percentage.GetHashCode();
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
