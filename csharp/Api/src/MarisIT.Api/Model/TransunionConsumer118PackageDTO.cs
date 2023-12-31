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
    /// TransunionConsumer118PackageDTO
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118PackageDTO :  IEquatable<TransunionConsumer118PackageDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118PackageDTO" /> class.
        /// </summary>
        /// <param name="payslipDate">payslipDate.</param>
        /// <param name="payslipCurrency">payslipCurrency.</param>
        /// <param name="totalCostToCompany">totalCostToCompany.</param>
        /// <param name="basicSalary">basicSalary.</param>
        /// <param name="breakdown">breakdown.</param>
        /// <param name="totalIncome">totalIncome.</param>
        /// <param name="totalPAYE">totalPAYE.</param>
        /// <param name="nettSalary">nettSalary.</param>
        public TransunionConsumer118PackageDTO(string payslipDate = default(string), string payslipCurrency = default(string), double totalCostToCompany = default(double), double basicSalary = default(double), TransunionConsumer118BreakdownDTO breakdown = default(TransunionConsumer118BreakdownDTO), double totalIncome = default(double), double totalPAYE = default(double), double nettSalary = default(double))
        {
            this.PayslipDate = payslipDate;
            this.PayslipCurrency = payslipCurrency;
            this.PayslipDate = payslipDate;
            this.PayslipCurrency = payslipCurrency;
            this.TotalCostToCompany = totalCostToCompany;
            this.BasicSalary = basicSalary;
            this.Breakdown = breakdown;
            this.TotalIncome = totalIncome;
            this.TotalPAYE = totalPAYE;
            this.NettSalary = nettSalary;
        }

        /// <summary>
        /// Gets or Sets PayslipDate
        /// </summary>
        [DataMember(Name="payslipDate", EmitDefaultValue=true)]
        public string PayslipDate { get; set; }

        /// <summary>
        /// Gets or Sets PayslipCurrency
        /// </summary>
        [DataMember(Name="payslipCurrency", EmitDefaultValue=true)]
        public string PayslipCurrency { get; set; }

        /// <summary>
        /// Gets or Sets TotalCostToCompany
        /// </summary>
        [DataMember(Name="totalCostToCompany", EmitDefaultValue=false)]
        public double TotalCostToCompany { get; set; }

        /// <summary>
        /// Gets or Sets BasicSalary
        /// </summary>
        [DataMember(Name="basicSalary", EmitDefaultValue=false)]
        public double BasicSalary { get; set; }

        /// <summary>
        /// Gets or Sets Breakdown
        /// </summary>
        [DataMember(Name="breakdown", EmitDefaultValue=false)]
        public TransunionConsumer118BreakdownDTO Breakdown { get; set; }

        /// <summary>
        /// Gets or Sets TotalIncome
        /// </summary>
        [DataMember(Name="totalIncome", EmitDefaultValue=false)]
        public double TotalIncome { get; set; }

        /// <summary>
        /// Gets or Sets TotalPAYE
        /// </summary>
        [DataMember(Name="totalPAYE", EmitDefaultValue=false)]
        public double TotalPAYE { get; set; }

        /// <summary>
        /// Gets or Sets NettSalary
        /// </summary>
        [DataMember(Name="nettSalary", EmitDefaultValue=false)]
        public double NettSalary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118PackageDTO {\n");
            sb.Append("  PayslipDate: ").Append(PayslipDate).Append("\n");
            sb.Append("  PayslipCurrency: ").Append(PayslipCurrency).Append("\n");
            sb.Append("  TotalCostToCompany: ").Append(TotalCostToCompany).Append("\n");
            sb.Append("  BasicSalary: ").Append(BasicSalary).Append("\n");
            sb.Append("  Breakdown: ").Append(Breakdown).Append("\n");
            sb.Append("  TotalIncome: ").Append(TotalIncome).Append("\n");
            sb.Append("  TotalPAYE: ").Append(TotalPAYE).Append("\n");
            sb.Append("  NettSalary: ").Append(NettSalary).Append("\n");
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
            return this.Equals(input as TransunionConsumer118PackageDTO);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118PackageDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118PackageDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118PackageDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayslipDate == input.PayslipDate ||
                    (this.PayslipDate != null &&
                    this.PayslipDate.Equals(input.PayslipDate))
                ) && 
                (
                    this.PayslipCurrency == input.PayslipCurrency ||
                    (this.PayslipCurrency != null &&
                    this.PayslipCurrency.Equals(input.PayslipCurrency))
                ) && 
                (
                    this.TotalCostToCompany == input.TotalCostToCompany ||
                    (this.TotalCostToCompany != null &&
                    this.TotalCostToCompany.Equals(input.TotalCostToCompany))
                ) && 
                (
                    this.BasicSalary == input.BasicSalary ||
                    (this.BasicSalary != null &&
                    this.BasicSalary.Equals(input.BasicSalary))
                ) && 
                (
                    this.Breakdown == input.Breakdown ||
                    (this.Breakdown != null &&
                    this.Breakdown.Equals(input.Breakdown))
                ) && 
                (
                    this.TotalIncome == input.TotalIncome ||
                    (this.TotalIncome != null &&
                    this.TotalIncome.Equals(input.TotalIncome))
                ) && 
                (
                    this.TotalPAYE == input.TotalPAYE ||
                    (this.TotalPAYE != null &&
                    this.TotalPAYE.Equals(input.TotalPAYE))
                ) && 
                (
                    this.NettSalary == input.NettSalary ||
                    (this.NettSalary != null &&
                    this.NettSalary.Equals(input.NettSalary))
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
                if (this.PayslipDate != null)
                    hashCode = hashCode * 59 + this.PayslipDate.GetHashCode();
                if (this.PayslipCurrency != null)
                    hashCode = hashCode * 59 + this.PayslipCurrency.GetHashCode();
                if (this.TotalCostToCompany != null)
                    hashCode = hashCode * 59 + this.TotalCostToCompany.GetHashCode();
                if (this.BasicSalary != null)
                    hashCode = hashCode * 59 + this.BasicSalary.GetHashCode();
                if (this.Breakdown != null)
                    hashCode = hashCode * 59 + this.Breakdown.GetHashCode();
                if (this.TotalIncome != null)
                    hashCode = hashCode * 59 + this.TotalIncome.GetHashCode();
                if (this.TotalPAYE != null)
                    hashCode = hashCode * 59 + this.TotalPAYE.GetHashCode();
                if (this.NettSalary != null)
                    hashCode = hashCode * 59 + this.NettSalary.GetHashCode();
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
