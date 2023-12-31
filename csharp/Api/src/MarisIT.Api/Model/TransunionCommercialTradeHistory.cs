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
    /// TransunionCommercialTradeHistory
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialTradeHistory :  IEquatable<TransunionCommercialTradeHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialTradeHistory" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="dateOfRef">dateOfRef.</param>
        /// <param name="yearsKnown">yearsKnown.</param>
        /// <param name="monthsKnown">monthsKnown.</param>
        /// <param name="creditLimit">creditLimit.</param>
        /// <param name="unlimited">unlimited.</param>
        /// <param name="purchases">purchases.</param>
        /// <param name="termsTaken">termsTaken.</param>
        /// <param name="termsGiven">termsGiven.</param>
        /// <param name="discount">discount.</param>
        /// <param name="referenceName">referenceName.</param>
        /// <param name="insurance">insurance.</param>
        /// <param name="insuranceDesc">insuranceDesc.</param>
        /// <param name="comment">comment.</param>
        /// <param name="assuredValue">assuredValue.</param>
        /// <param name="obtained">obtained.</param>
        public TransunionCommercialTradeHistory(string majorProduct = default(string), string dateOfRef = default(string), string yearsKnown = default(string), string monthsKnown = default(string), string creditLimit = default(string), string unlimited = default(string), string purchases = default(string), string termsTaken = default(string), string termsGiven = default(string), string discount = default(string), string referenceName = default(string), string insurance = default(string), string insuranceDesc = default(string), string comment = default(string), string assuredValue = default(string), string obtained = default(string))
        {
            this.MajorProduct = majorProduct;
            this.DateOfRef = dateOfRef;
            this.YearsKnown = yearsKnown;
            this.MonthsKnown = monthsKnown;
            this.CreditLimit = creditLimit;
            this.Unlimited = unlimited;
            this.Purchases = purchases;
            this.TermsTaken = termsTaken;
            this.TermsGiven = termsGiven;
            this.Discount = discount;
            this.ReferenceName = referenceName;
            this.Insurance = insurance;
            this.InsuranceDesc = insuranceDesc;
            this.Comment = comment;
            this.AssuredValue = assuredValue;
            this.Obtained = obtained;
            this.MajorProduct = majorProduct;
            this.DateOfRef = dateOfRef;
            this.YearsKnown = yearsKnown;
            this.MonthsKnown = monthsKnown;
            this.CreditLimit = creditLimit;
            this.Unlimited = unlimited;
            this.Purchases = purchases;
            this.TermsTaken = termsTaken;
            this.TermsGiven = termsGiven;
            this.Discount = discount;
            this.ReferenceName = referenceName;
            this.Insurance = insurance;
            this.InsuranceDesc = insuranceDesc;
            this.Comment = comment;
            this.AssuredValue = assuredValue;
            this.Obtained = obtained;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets DateOfRef
        /// </summary>
        [DataMember(Name="dateOfRef", EmitDefaultValue=true)]
        public string DateOfRef { get; set; }

        /// <summary>
        /// Gets or Sets YearsKnown
        /// </summary>
        [DataMember(Name="yearsKnown", EmitDefaultValue=true)]
        public string YearsKnown { get; set; }

        /// <summary>
        /// Gets or Sets MonthsKnown
        /// </summary>
        [DataMember(Name="monthsKnown", EmitDefaultValue=true)]
        public string MonthsKnown { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [DataMember(Name="creditLimit", EmitDefaultValue=true)]
        public string CreditLimit { get; set; }

        /// <summary>
        /// Gets or Sets Unlimited
        /// </summary>
        [DataMember(Name="unlimited", EmitDefaultValue=true)]
        public string Unlimited { get; set; }

        /// <summary>
        /// Gets or Sets Purchases
        /// </summary>
        [DataMember(Name="purchases", EmitDefaultValue=true)]
        public string Purchases { get; set; }

        /// <summary>
        /// Gets or Sets TermsTaken
        /// </summary>
        [DataMember(Name="termsTaken", EmitDefaultValue=true)]
        public string TermsTaken { get; set; }

        /// <summary>
        /// Gets or Sets TermsGiven
        /// </summary>
        [DataMember(Name="termsGiven", EmitDefaultValue=true)]
        public string TermsGiven { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=true)]
        public string Discount { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceName
        /// </summary>
        [DataMember(Name="referenceName", EmitDefaultValue=true)]
        public string ReferenceName { get; set; }

        /// <summary>
        /// Gets or Sets Insurance
        /// </summary>
        [DataMember(Name="insurance", EmitDefaultValue=true)]
        public string Insurance { get; set; }

        /// <summary>
        /// Gets or Sets InsuranceDesc
        /// </summary>
        [DataMember(Name="insuranceDesc", EmitDefaultValue=true)]
        public string InsuranceDesc { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets AssuredValue
        /// </summary>
        [DataMember(Name="assuredValue", EmitDefaultValue=true)]
        public string AssuredValue { get; set; }

        /// <summary>
        /// Gets or Sets Obtained
        /// </summary>
        [DataMember(Name="obtained", EmitDefaultValue=true)]
        public string Obtained { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialTradeHistory {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  DateOfRef: ").Append(DateOfRef).Append("\n");
            sb.Append("  YearsKnown: ").Append(YearsKnown).Append("\n");
            sb.Append("  MonthsKnown: ").Append(MonthsKnown).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  Unlimited: ").Append(Unlimited).Append("\n");
            sb.Append("  Purchases: ").Append(Purchases).Append("\n");
            sb.Append("  TermsTaken: ").Append(TermsTaken).Append("\n");
            sb.Append("  TermsGiven: ").Append(TermsGiven).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  ReferenceName: ").Append(ReferenceName).Append("\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  InsuranceDesc: ").Append(InsuranceDesc).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  AssuredValue: ").Append(AssuredValue).Append("\n");
            sb.Append("  Obtained: ").Append(Obtained).Append("\n");
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
            return this.Equals(input as TransunionCommercialTradeHistory);
        }

        /// <summary>
        /// Returns true if TransunionCommercialTradeHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialTradeHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialTradeHistory input)
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
                    this.DateOfRef == input.DateOfRef ||
                    (this.DateOfRef != null &&
                    this.DateOfRef.Equals(input.DateOfRef))
                ) && 
                (
                    this.YearsKnown == input.YearsKnown ||
                    (this.YearsKnown != null &&
                    this.YearsKnown.Equals(input.YearsKnown))
                ) && 
                (
                    this.MonthsKnown == input.MonthsKnown ||
                    (this.MonthsKnown != null &&
                    this.MonthsKnown.Equals(input.MonthsKnown))
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    (this.CreditLimit != null &&
                    this.CreditLimit.Equals(input.CreditLimit))
                ) && 
                (
                    this.Unlimited == input.Unlimited ||
                    (this.Unlimited != null &&
                    this.Unlimited.Equals(input.Unlimited))
                ) && 
                (
                    this.Purchases == input.Purchases ||
                    (this.Purchases != null &&
                    this.Purchases.Equals(input.Purchases))
                ) && 
                (
                    this.TermsTaken == input.TermsTaken ||
                    (this.TermsTaken != null &&
                    this.TermsTaken.Equals(input.TermsTaken))
                ) && 
                (
                    this.TermsGiven == input.TermsGiven ||
                    (this.TermsGiven != null &&
                    this.TermsGiven.Equals(input.TermsGiven))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.ReferenceName == input.ReferenceName ||
                    (this.ReferenceName != null &&
                    this.ReferenceName.Equals(input.ReferenceName))
                ) && 
                (
                    this.Insurance == input.Insurance ||
                    (this.Insurance != null &&
                    this.Insurance.Equals(input.Insurance))
                ) && 
                (
                    this.InsuranceDesc == input.InsuranceDesc ||
                    (this.InsuranceDesc != null &&
                    this.InsuranceDesc.Equals(input.InsuranceDesc))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.AssuredValue == input.AssuredValue ||
                    (this.AssuredValue != null &&
                    this.AssuredValue.Equals(input.AssuredValue))
                ) && 
                (
                    this.Obtained == input.Obtained ||
                    (this.Obtained != null &&
                    this.Obtained.Equals(input.Obtained))
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
                if (this.DateOfRef != null)
                    hashCode = hashCode * 59 + this.DateOfRef.GetHashCode();
                if (this.YearsKnown != null)
                    hashCode = hashCode * 59 + this.YearsKnown.GetHashCode();
                if (this.MonthsKnown != null)
                    hashCode = hashCode * 59 + this.MonthsKnown.GetHashCode();
                if (this.CreditLimit != null)
                    hashCode = hashCode * 59 + this.CreditLimit.GetHashCode();
                if (this.Unlimited != null)
                    hashCode = hashCode * 59 + this.Unlimited.GetHashCode();
                if (this.Purchases != null)
                    hashCode = hashCode * 59 + this.Purchases.GetHashCode();
                if (this.TermsTaken != null)
                    hashCode = hashCode * 59 + this.TermsTaken.GetHashCode();
                if (this.TermsGiven != null)
                    hashCode = hashCode * 59 + this.TermsGiven.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.ReferenceName != null)
                    hashCode = hashCode * 59 + this.ReferenceName.GetHashCode();
                if (this.Insurance != null)
                    hashCode = hashCode * 59 + this.Insurance.GetHashCode();
                if (this.InsuranceDesc != null)
                    hashCode = hashCode * 59 + this.InsuranceDesc.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.AssuredValue != null)
                    hashCode = hashCode * 59 + this.AssuredValue.GetHashCode();
                if (this.Obtained != null)
                    hashCode = hashCode * 59 + this.Obtained.GetHashCode();
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
