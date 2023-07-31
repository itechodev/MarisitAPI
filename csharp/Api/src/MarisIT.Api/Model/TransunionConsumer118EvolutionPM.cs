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
    /// TransunionConsumer118EvolutionPM
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EvolutionPM :  IEquatable<TransunionConsumer118EvolutionPM>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EvolutionPM" /> class.
        /// </summary>
        /// <param name="openingBalance">openingBalance.</param>
        /// <param name="currentBalance">currentBalance.</param>
        /// <param name="overdueAmount">overdueAmount.</param>
        /// <param name="instalment">instalment.</param>
        /// <param name="transactionMonth">transactionMonth.</param>
        public TransunionConsumer118EvolutionPM(string openingBalance = default(string), string currentBalance = default(string), string overdueAmount = default(string), string instalment = default(string), string transactionMonth = default(string))
        {
            this.OpeningBalance = openingBalance;
            this.CurrentBalance = currentBalance;
            this.OverdueAmount = overdueAmount;
            this.Instalment = instalment;
            this.TransactionMonth = transactionMonth;
            this.OpeningBalance = openingBalance;
            this.CurrentBalance = currentBalance;
            this.OverdueAmount = overdueAmount;
            this.Instalment = instalment;
            this.TransactionMonth = transactionMonth;
        }

        /// <summary>
        /// Gets or Sets OpeningBalance
        /// </summary>
        [DataMember(Name="opening_balance", EmitDefaultValue=true)]
        public string OpeningBalance { get; set; }

        /// <summary>
        /// Gets or Sets CurrentBalance
        /// </summary>
        [DataMember(Name="current_balance", EmitDefaultValue=true)]
        public string CurrentBalance { get; set; }

        /// <summary>
        /// Gets or Sets OverdueAmount
        /// </summary>
        [DataMember(Name="overdue_amount", EmitDefaultValue=true)]
        public string OverdueAmount { get; set; }

        /// <summary>
        /// Gets or Sets Instalment
        /// </summary>
        [DataMember(Name="instalment", EmitDefaultValue=true)]
        public string Instalment { get; set; }

        /// <summary>
        /// Gets or Sets TransactionMonth
        /// </summary>
        [DataMember(Name="transaction_month", EmitDefaultValue=true)]
        public string TransactionMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EvolutionPM {\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  CurrentBalance: ").Append(CurrentBalance).Append("\n");
            sb.Append("  OverdueAmount: ").Append(OverdueAmount).Append("\n");
            sb.Append("  Instalment: ").Append(Instalment).Append("\n");
            sb.Append("  TransactionMonth: ").Append(TransactionMonth).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EvolutionPM);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EvolutionPM instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EvolutionPM to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EvolutionPM input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpeningBalance == input.OpeningBalance ||
                    (this.OpeningBalance != null &&
                    this.OpeningBalance.Equals(input.OpeningBalance))
                ) && 
                (
                    this.CurrentBalance == input.CurrentBalance ||
                    (this.CurrentBalance != null &&
                    this.CurrentBalance.Equals(input.CurrentBalance))
                ) && 
                (
                    this.OverdueAmount == input.OverdueAmount ||
                    (this.OverdueAmount != null &&
                    this.OverdueAmount.Equals(input.OverdueAmount))
                ) && 
                (
                    this.Instalment == input.Instalment ||
                    (this.Instalment != null &&
                    this.Instalment.Equals(input.Instalment))
                ) && 
                (
                    this.TransactionMonth == input.TransactionMonth ||
                    (this.TransactionMonth != null &&
                    this.TransactionMonth.Equals(input.TransactionMonth))
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
                if (this.OpeningBalance != null)
                    hashCode = hashCode * 59 + this.OpeningBalance.GetHashCode();
                if (this.CurrentBalance != null)
                    hashCode = hashCode * 59 + this.CurrentBalance.GetHashCode();
                if (this.OverdueAmount != null)
                    hashCode = hashCode * 59 + this.OverdueAmount.GetHashCode();
                if (this.Instalment != null)
                    hashCode = hashCode * 59 + this.Instalment.GetHashCode();
                if (this.TransactionMonth != null)
                    hashCode = hashCode * 59 + this.TransactionMonth.GetHashCode();
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
