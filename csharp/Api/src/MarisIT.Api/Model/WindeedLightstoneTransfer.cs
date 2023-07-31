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
    /// WindeedLightstoneTransfer
    /// </summary>
    [DataContract]
    public partial class WindeedLightstoneTransfer :  IEquatable<WindeedLightstoneTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedLightstoneTransfer" /> class.
        /// </summary>
        /// <param name="buyerName">buyerName.</param>
        /// <param name="sellerName">sellerName.</param>
        /// <param name="registrationDate">registrationDate.</param>
        /// <param name="purchaseDate">purchaseDate.</param>
        /// <param name="purchasePrice">purchasePrice.</param>
        /// <param name="documentNumber">documentNumber.</param>
        /// <param name="institution">institution.</param>
        /// <param name="bondNumber">bondNumber.</param>
        /// <param name="bondAmount">bondAmount.</param>
        public WindeedLightstoneTransfer(string buyerName = default(string), string sellerName = default(string), DateTime? registrationDate = default(DateTime?), DateTime? purchaseDate = default(DateTime?), double? purchasePrice = default(double?), string documentNumber = default(string), string institution = default(string), string bondNumber = default(string), double? bondAmount = default(double?))
        {
            this.BuyerName = buyerName;
            this.SellerName = sellerName;
            this.RegistrationDate = registrationDate;
            this.PurchaseDate = purchaseDate;
            this.PurchasePrice = purchasePrice;
            this.DocumentNumber = documentNumber;
            this.Institution = institution;
            this.BondNumber = bondNumber;
            this.BondAmount = bondAmount;
            this.BuyerName = buyerName;
            this.SellerName = sellerName;
            this.RegistrationDate = registrationDate;
            this.PurchaseDate = purchaseDate;
            this.PurchasePrice = purchasePrice;
            this.DocumentNumber = documentNumber;
            this.Institution = institution;
            this.BondNumber = bondNumber;
            this.BondAmount = bondAmount;
        }

        /// <summary>
        /// Gets or Sets BuyerName
        /// </summary>
        [DataMember(Name="buyerName", EmitDefaultValue=true)]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets or Sets SellerName
        /// </summary>
        [DataMember(Name="sellerName", EmitDefaultValue=true)]
        public string SellerName { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDate
        /// </summary>
        [DataMember(Name="registrationDate", EmitDefaultValue=true)]
        public DateTime? RegistrationDate { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDate
        /// </summary>
        [DataMember(Name="purchaseDate", EmitDefaultValue=true)]
        public DateTime? PurchaseDate { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="purchasePrice", EmitDefaultValue=true)]
        public double? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [DataMember(Name="documentNumber", EmitDefaultValue=true)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets Institution
        /// </summary>
        [DataMember(Name="institution", EmitDefaultValue=true)]
        public string Institution { get; set; }

        /// <summary>
        /// Gets or Sets BondNumber
        /// </summary>
        [DataMember(Name="bondNumber", EmitDefaultValue=true)]
        public string BondNumber { get; set; }

        /// <summary>
        /// Gets or Sets BondAmount
        /// </summary>
        [DataMember(Name="bondAmount", EmitDefaultValue=true)]
        public double? BondAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedLightstoneTransfer {\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  SellerName: ").Append(SellerName).Append("\n");
            sb.Append("  RegistrationDate: ").Append(RegistrationDate).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Institution: ").Append(Institution).Append("\n");
            sb.Append("  BondNumber: ").Append(BondNumber).Append("\n");
            sb.Append("  BondAmount: ").Append(BondAmount).Append("\n");
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
            return this.Equals(input as WindeedLightstoneTransfer);
        }

        /// <summary>
        /// Returns true if WindeedLightstoneTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedLightstoneTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedLightstoneTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) && 
                (
                    this.SellerName == input.SellerName ||
                    (this.SellerName != null &&
                    this.SellerName.Equals(input.SellerName))
                ) && 
                (
                    this.RegistrationDate == input.RegistrationDate ||
                    (this.RegistrationDate != null &&
                    this.RegistrationDate.Equals(input.RegistrationDate))
                ) && 
                (
                    this.PurchaseDate == input.PurchaseDate ||
                    (this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(input.PurchaseDate))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.DocumentNumber == input.DocumentNumber ||
                    (this.DocumentNumber != null &&
                    this.DocumentNumber.Equals(input.DocumentNumber))
                ) && 
                (
                    this.Institution == input.Institution ||
                    (this.Institution != null &&
                    this.Institution.Equals(input.Institution))
                ) && 
                (
                    this.BondNumber == input.BondNumber ||
                    (this.BondNumber != null &&
                    this.BondNumber.Equals(input.BondNumber))
                ) && 
                (
                    this.BondAmount == input.BondAmount ||
                    (this.BondAmount != null &&
                    this.BondAmount.Equals(input.BondAmount))
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
                if (this.BuyerName != null)
                    hashCode = hashCode * 59 + this.BuyerName.GetHashCode();
                if (this.SellerName != null)
                    hashCode = hashCode * 59 + this.SellerName.GetHashCode();
                if (this.RegistrationDate != null)
                    hashCode = hashCode * 59 + this.RegistrationDate.GetHashCode();
                if (this.PurchaseDate != null)
                    hashCode = hashCode * 59 + this.PurchaseDate.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.DocumentNumber != null)
                    hashCode = hashCode * 59 + this.DocumentNumber.GetHashCode();
                if (this.Institution != null)
                    hashCode = hashCode * 59 + this.Institution.GetHashCode();
                if (this.BondNumber != null)
                    hashCode = hashCode * 59 + this.BondNumber.GetHashCode();
                if (this.BondAmount != null)
                    hashCode = hashCode * 59 + this.BondAmount.GetHashCode();
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