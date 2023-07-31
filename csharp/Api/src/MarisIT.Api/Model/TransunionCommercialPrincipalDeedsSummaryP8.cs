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
    /// TransunionCommercialPrincipalDeedsSummaryP8
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialPrincipalDeedsSummaryP8 :  IEquatable<TransunionCommercialPrincipalDeedsSummaryP8>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialPrincipalDeedsSummaryP8" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="businessName">businessName.</param>
        /// <param name="registrationNumber">registrationNumber.</param>
        /// <param name="principalName">principalName.</param>
        /// <param name="dateOfBirthOrIDNumber">dateOfBirthOrIDNumber.</param>
        /// <param name="numberOfProperties">numberOfProperties.</param>
        /// <param name="purchasePrice">purchasePrice.</param>
        /// <param name="bondAmount">bondAmount.</param>
        /// <param name="bondFreeAmount">bondFreeAmount.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="message">message.</param>
        /// <param name="date">date.</param>
        /// <param name="bondCount">bondCount.</param>
        public TransunionCommercialPrincipalDeedsSummaryP8(string majorProduct = default(string), string businessName = default(string), string registrationNumber = default(string), string principalName = default(string), string dateOfBirthOrIDNumber = default(string), string numberOfProperties = default(string), string purchasePrice = default(string), string bondAmount = default(string), string bondFreeAmount = default(string), string deedsOffice = default(string), string message = default(string), string date = default(string), string bondCount = default(string))
        {
            this.MajorProduct = majorProduct;
            this.BusinessName = businessName;
            this.RegistrationNumber = registrationNumber;
            this.PrincipalName = principalName;
            this.DateOfBirthOrIDNumber = dateOfBirthOrIDNumber;
            this.NumberOfProperties = numberOfProperties;
            this.PurchasePrice = purchasePrice;
            this.BondAmount = bondAmount;
            this.BondFreeAmount = bondFreeAmount;
            this.DeedsOffice = deedsOffice;
            this.Message = message;
            this.Date = date;
            this.BondCount = bondCount;
            this.MajorProduct = majorProduct;
            this.BusinessName = businessName;
            this.RegistrationNumber = registrationNumber;
            this.PrincipalName = principalName;
            this.DateOfBirthOrIDNumber = dateOfBirthOrIDNumber;
            this.NumberOfProperties = numberOfProperties;
            this.PurchasePrice = purchasePrice;
            this.BondAmount = bondAmount;
            this.BondFreeAmount = bondFreeAmount;
            this.DeedsOffice = deedsOffice;
            this.Message = message;
            this.Date = date;
            this.BondCount = bondCount;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="businessName", EmitDefaultValue=true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNumber
        /// </summary>
        [DataMember(Name="registrationNumber", EmitDefaultValue=true)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets PrincipalName
        /// </summary>
        [DataMember(Name="principalName", EmitDefaultValue=true)]
        public string PrincipalName { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirthOrIDNumber
        /// </summary>
        [DataMember(Name="dateOfBirthOrIDNumber", EmitDefaultValue=true)]
        public string DateOfBirthOrIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfProperties
        /// </summary>
        [DataMember(Name="numberOfProperties", EmitDefaultValue=true)]
        public string NumberOfProperties { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="purchasePrice", EmitDefaultValue=true)]
        public string PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets BondAmount
        /// </summary>
        [DataMember(Name="bondAmount", EmitDefaultValue=true)]
        public string BondAmount { get; set; }

        /// <summary>
        /// Gets or Sets BondFreeAmount
        /// </summary>
        [DataMember(Name="bondFreeAmount", EmitDefaultValue=true)]
        public string BondFreeAmount { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public string DeedsOffice { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets BondCount
        /// </summary>
        [DataMember(Name="bondCount", EmitDefaultValue=true)]
        public string BondCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialPrincipalDeedsSummaryP8 {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  PrincipalName: ").Append(PrincipalName).Append("\n");
            sb.Append("  DateOfBirthOrIDNumber: ").Append(DateOfBirthOrIDNumber).Append("\n");
            sb.Append("  NumberOfProperties: ").Append(NumberOfProperties).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  BondAmount: ").Append(BondAmount).Append("\n");
            sb.Append("  BondFreeAmount: ").Append(BondFreeAmount).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  BondCount: ").Append(BondCount).Append("\n");
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
            return this.Equals(input as TransunionCommercialPrincipalDeedsSummaryP8);
        }

        /// <summary>
        /// Returns true if TransunionCommercialPrincipalDeedsSummaryP8 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialPrincipalDeedsSummaryP8 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialPrincipalDeedsSummaryP8 input)
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
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.PrincipalName == input.PrincipalName ||
                    (this.PrincipalName != null &&
                    this.PrincipalName.Equals(input.PrincipalName))
                ) && 
                (
                    this.DateOfBirthOrIDNumber == input.DateOfBirthOrIDNumber ||
                    (this.DateOfBirthOrIDNumber != null &&
                    this.DateOfBirthOrIDNumber.Equals(input.DateOfBirthOrIDNumber))
                ) && 
                (
                    this.NumberOfProperties == input.NumberOfProperties ||
                    (this.NumberOfProperties != null &&
                    this.NumberOfProperties.Equals(input.NumberOfProperties))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.BondAmount == input.BondAmount ||
                    (this.BondAmount != null &&
                    this.BondAmount.Equals(input.BondAmount))
                ) && 
                (
                    this.BondFreeAmount == input.BondFreeAmount ||
                    (this.BondFreeAmount != null &&
                    this.BondFreeAmount.Equals(input.BondFreeAmount))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.BondCount == input.BondCount ||
                    (this.BondCount != null &&
                    this.BondCount.Equals(input.BondCount))
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
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.PrincipalName != null)
                    hashCode = hashCode * 59 + this.PrincipalName.GetHashCode();
                if (this.DateOfBirthOrIDNumber != null)
                    hashCode = hashCode * 59 + this.DateOfBirthOrIDNumber.GetHashCode();
                if (this.NumberOfProperties != null)
                    hashCode = hashCode * 59 + this.NumberOfProperties.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.BondAmount != null)
                    hashCode = hashCode * 59 + this.BondAmount.GetHashCode();
                if (this.BondFreeAmount != null)
                    hashCode = hashCode * 59 + this.BondFreeAmount.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.BondCount != null)
                    hashCode = hashCode * 59 + this.BondCount.GetHashCode();
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