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
    /// TransunionCommercialTradex
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialTradex :  IEquatable<TransunionCommercialTradex>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialTradex" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="debtorName">debtorName.</param>
        /// <param name="calculationPeriod">calculationPeriod.</param>
        /// <param name="totalInvoices">totalInvoices.</param>
        /// <param name="totalInvoiceAmount">totalInvoiceAmount.</param>
        /// <param name="averageDaysEarlyLate">averageDaysEarlyLate.</param>
        /// <param name="creditBands">creditBands.</param>
        /// <param name="dateCreated">dateCreated.</param>
        /// <param name="globalScore">globalScore.</param>
        /// <param name="totalOverdueInvoices">totalOverdueInvoices.</param>
        /// <param name="totalOverdueAmount">totalOverdueAmount.</param>
        /// <param name="scoreCriteria">scoreCriteria.</param>
        public TransunionCommercialTradex(string majorProduct = default(string), string debtorName = default(string), string calculationPeriod = default(string), string totalInvoices = default(string), string totalInvoiceAmount = default(string), string averageDaysEarlyLate = default(string), List<TransunionCommercialCreditBand> creditBands = default(List<TransunionCommercialCreditBand>), string dateCreated = default(string), string globalScore = default(string), string totalOverdueInvoices = default(string), string totalOverdueAmount = default(string), string scoreCriteria = default(string))
        {
            this.MajorProduct = majorProduct;
            this.DebtorName = debtorName;
            this.CalculationPeriod = calculationPeriod;
            this.TotalInvoices = totalInvoices;
            this.TotalInvoiceAmount = totalInvoiceAmount;
            this.AverageDaysEarlyLate = averageDaysEarlyLate;
            this.CreditBands = creditBands;
            this.DateCreated = dateCreated;
            this.GlobalScore = globalScore;
            this.TotalOverdueInvoices = totalOverdueInvoices;
            this.TotalOverdueAmount = totalOverdueAmount;
            this.ScoreCriteria = scoreCriteria;
            this.MajorProduct = majorProduct;
            this.DebtorName = debtorName;
            this.CalculationPeriod = calculationPeriod;
            this.TotalInvoices = totalInvoices;
            this.TotalInvoiceAmount = totalInvoiceAmount;
            this.AverageDaysEarlyLate = averageDaysEarlyLate;
            this.CreditBands = creditBands;
            this.DateCreated = dateCreated;
            this.GlobalScore = globalScore;
            this.TotalOverdueInvoices = totalOverdueInvoices;
            this.TotalOverdueAmount = totalOverdueAmount;
            this.ScoreCriteria = scoreCriteria;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets DebtorName
        /// </summary>
        [DataMember(Name="debtorName", EmitDefaultValue=true)]
        public string DebtorName { get; set; }

        /// <summary>
        /// Gets or Sets CalculationPeriod
        /// </summary>
        [DataMember(Name="calculationPeriod", EmitDefaultValue=true)]
        public string CalculationPeriod { get; set; }

        /// <summary>
        /// Gets or Sets TotalInvoices
        /// </summary>
        [DataMember(Name="totalInvoices", EmitDefaultValue=true)]
        public string TotalInvoices { get; set; }

        /// <summary>
        /// Gets or Sets TotalInvoiceAmount
        /// </summary>
        [DataMember(Name="totalInvoiceAmount", EmitDefaultValue=true)]
        public string TotalInvoiceAmount { get; set; }

        /// <summary>
        /// Gets or Sets AverageDaysEarlyLate
        /// </summary>
        [DataMember(Name="averageDaysEarlyLate", EmitDefaultValue=true)]
        public string AverageDaysEarlyLate { get; set; }

        /// <summary>
        /// Gets or Sets CreditBands
        /// </summary>
        [DataMember(Name="creditBands", EmitDefaultValue=true)]
        public List<TransunionCommercialCreditBand> CreditBands { get; set; }

        /// <summary>
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=true)]
        public string DateCreated { get; set; }

        /// <summary>
        /// Gets or Sets GlobalScore
        /// </summary>
        [DataMember(Name="globalScore", EmitDefaultValue=true)]
        public string GlobalScore { get; set; }

        /// <summary>
        /// Gets or Sets TotalOverdueInvoices
        /// </summary>
        [DataMember(Name="totalOverdueInvoices", EmitDefaultValue=true)]
        public string TotalOverdueInvoices { get; set; }

        /// <summary>
        /// Gets or Sets TotalOverdueAmount
        /// </summary>
        [DataMember(Name="totalOverdueAmount", EmitDefaultValue=true)]
        public string TotalOverdueAmount { get; set; }

        /// <summary>
        /// Gets or Sets ScoreCriteria
        /// </summary>
        [DataMember(Name="scoreCriteria", EmitDefaultValue=true)]
        public string ScoreCriteria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialTradex {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  DebtorName: ").Append(DebtorName).Append("\n");
            sb.Append("  CalculationPeriod: ").Append(CalculationPeriod).Append("\n");
            sb.Append("  TotalInvoices: ").Append(TotalInvoices).Append("\n");
            sb.Append("  TotalInvoiceAmount: ").Append(TotalInvoiceAmount).Append("\n");
            sb.Append("  AverageDaysEarlyLate: ").Append(AverageDaysEarlyLate).Append("\n");
            sb.Append("  CreditBands: ").Append(CreditBands).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  GlobalScore: ").Append(GlobalScore).Append("\n");
            sb.Append("  TotalOverdueInvoices: ").Append(TotalOverdueInvoices).Append("\n");
            sb.Append("  TotalOverdueAmount: ").Append(TotalOverdueAmount).Append("\n");
            sb.Append("  ScoreCriteria: ").Append(ScoreCriteria).Append("\n");
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
            return this.Equals(input as TransunionCommercialTradex);
        }

        /// <summary>
        /// Returns true if TransunionCommercialTradex instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialTradex to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialTradex input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MajorProduct == input.MajorProduct ||
                    (this.MajorProduct != null &&
                    this.MajorProduct.Equals(input.MajorProduct))
                ) && 
                (
                    this.DebtorName == input.DebtorName ||
                    (this.DebtorName != null &&
                    this.DebtorName.Equals(input.DebtorName))
                ) && 
                (
                    this.CalculationPeriod == input.CalculationPeriod ||
                    (this.CalculationPeriod != null &&
                    this.CalculationPeriod.Equals(input.CalculationPeriod))
                ) && 
                (
                    this.TotalInvoices == input.TotalInvoices ||
                    (this.TotalInvoices != null &&
                    this.TotalInvoices.Equals(input.TotalInvoices))
                ) && 
                (
                    this.TotalInvoiceAmount == input.TotalInvoiceAmount ||
                    (this.TotalInvoiceAmount != null &&
                    this.TotalInvoiceAmount.Equals(input.TotalInvoiceAmount))
                ) && 
                (
                    this.AverageDaysEarlyLate == input.AverageDaysEarlyLate ||
                    (this.AverageDaysEarlyLate != null &&
                    this.AverageDaysEarlyLate.Equals(input.AverageDaysEarlyLate))
                ) && 
                (
                    this.CreditBands == input.CreditBands ||
                    this.CreditBands != null &&
                    input.CreditBands != null &&
                    this.CreditBands.SequenceEqual(input.CreditBands)
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.GlobalScore == input.GlobalScore ||
                    (this.GlobalScore != null &&
                    this.GlobalScore.Equals(input.GlobalScore))
                ) && 
                (
                    this.TotalOverdueInvoices == input.TotalOverdueInvoices ||
                    (this.TotalOverdueInvoices != null &&
                    this.TotalOverdueInvoices.Equals(input.TotalOverdueInvoices))
                ) && 
                (
                    this.TotalOverdueAmount == input.TotalOverdueAmount ||
                    (this.TotalOverdueAmount != null &&
                    this.TotalOverdueAmount.Equals(input.TotalOverdueAmount))
                ) && 
                (
                    this.ScoreCriteria == input.ScoreCriteria ||
                    (this.ScoreCriteria != null &&
                    this.ScoreCriteria.Equals(input.ScoreCriteria))
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
                if (this.MajorProduct != null)
                    hashCode = hashCode * 59 + this.MajorProduct.GetHashCode();
                if (this.DebtorName != null)
                    hashCode = hashCode * 59 + this.DebtorName.GetHashCode();
                if (this.CalculationPeriod != null)
                    hashCode = hashCode * 59 + this.CalculationPeriod.GetHashCode();
                if (this.TotalInvoices != null)
                    hashCode = hashCode * 59 + this.TotalInvoices.GetHashCode();
                if (this.TotalInvoiceAmount != null)
                    hashCode = hashCode * 59 + this.TotalInvoiceAmount.GetHashCode();
                if (this.AverageDaysEarlyLate != null)
                    hashCode = hashCode * 59 + this.AverageDaysEarlyLate.GetHashCode();
                if (this.CreditBands != null)
                    hashCode = hashCode * 59 + this.CreditBands.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.GlobalScore != null)
                    hashCode = hashCode * 59 + this.GlobalScore.GetHashCode();
                if (this.TotalOverdueInvoices != null)
                    hashCode = hashCode * 59 + this.TotalOverdueInvoices.GetHashCode();
                if (this.TotalOverdueAmount != null)
                    hashCode = hashCode * 59 + this.TotalOverdueAmount.GetHashCode();
                if (this.ScoreCriteria != null)
                    hashCode = hashCode * 59 + this.ScoreCriteria.GetHashCode();
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