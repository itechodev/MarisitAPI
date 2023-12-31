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
    /// TransunionCommercialUnmatchedNotarialBond
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialUnmatchedNotarialBond :  IEquatable<TransunionCommercialUnmatchedNotarialBond>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialUnmatchedNotarialBond" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="numberFound">numberFound.</param>
        /// <param name="bondDate">bondDate.</param>
        /// <param name="mortgagor">mortgagor.</param>
        /// <param name="tradeStyle">tradeStyle.</param>
        /// <param name="address">address.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="bondNumber">bondNumber.</param>
        /// <param name="bondAmount">bondAmount.</param>
        /// <param name="bondPercent">bondPercent.</param>
        /// <param name="bondDistrict">bondDistrict.</param>
        /// <param name="mortgagee">mortgagee.</param>
        /// <param name="dateCancelled">dateCancelled.</param>
        /// <param name="message">message.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="mortgagorDistrict">mortgagorDistrict.</param>
        public TransunionCommercialUnmatchedNotarialBond(string majorProduct = default(string), string numberFound = default(string), string bondDate = default(string), string mortgagor = default(string), string tradeStyle = default(string), string address = default(string), string suburb = default(string), string city = default(string), string country = default(string), string postCode = default(string), string bondNumber = default(string), string bondAmount = default(string), string bondPercent = default(string), string bondDistrict = default(string), string mortgagee = default(string), string dateCancelled = default(string), string message = default(string), string serialNumber = default(string), string mortgagorDistrict = default(string))
        {
            this.MajorProduct = majorProduct;
            this.NumberFound = numberFound;
            this.BondDate = bondDate;
            this.Mortgagor = mortgagor;
            this.TradeStyle = tradeStyle;
            this.Address = address;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
            this.PostCode = postCode;
            this.BondNumber = bondNumber;
            this.BondAmount = bondAmount;
            this.BondPercent = bondPercent;
            this.BondDistrict = bondDistrict;
            this.Mortgagee = mortgagee;
            this.DateCancelled = dateCancelled;
            this.Message = message;
            this.SerialNumber = serialNumber;
            this.MortgagorDistrict = mortgagorDistrict;
            this.MajorProduct = majorProduct;
            this.NumberFound = numberFound;
            this.BondDate = bondDate;
            this.Mortgagor = mortgagor;
            this.TradeStyle = tradeStyle;
            this.Address = address;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
            this.PostCode = postCode;
            this.BondNumber = bondNumber;
            this.BondAmount = bondAmount;
            this.BondPercent = bondPercent;
            this.BondDistrict = bondDistrict;
            this.Mortgagee = mortgagee;
            this.DateCancelled = dateCancelled;
            this.Message = message;
            this.SerialNumber = serialNumber;
            this.MortgagorDistrict = mortgagorDistrict;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets NumberFound
        /// </summary>
        [DataMember(Name="numberFound", EmitDefaultValue=true)]
        public string NumberFound { get; set; }

        /// <summary>
        /// Gets or Sets BondDate
        /// </summary>
        [DataMember(Name="bondDate", EmitDefaultValue=true)]
        public string BondDate { get; set; }

        /// <summary>
        /// Gets or Sets Mortgagor
        /// </summary>
        [DataMember(Name="mortgagor", EmitDefaultValue=true)]
        public string Mortgagor { get; set; }

        /// <summary>
        /// Gets or Sets TradeStyle
        /// </summary>
        [DataMember(Name="tradeStyle", EmitDefaultValue=true)]
        public string TradeStyle { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=true)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=true)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets BondNumber
        /// </summary>
        [DataMember(Name="bondNumber", EmitDefaultValue=true)]
        public string BondNumber { get; set; }

        /// <summary>
        /// Gets or Sets BondAmount
        /// </summary>
        [DataMember(Name="bondAmount", EmitDefaultValue=true)]
        public string BondAmount { get; set; }

        /// <summary>
        /// Gets or Sets BondPercent
        /// </summary>
        [DataMember(Name="bondPercent", EmitDefaultValue=true)]
        public string BondPercent { get; set; }

        /// <summary>
        /// Gets or Sets BondDistrict
        /// </summary>
        [DataMember(Name="bondDistrict", EmitDefaultValue=true)]
        public string BondDistrict { get; set; }

        /// <summary>
        /// Gets or Sets Mortgagee
        /// </summary>
        [DataMember(Name="mortgagee", EmitDefaultValue=true)]
        public string Mortgagee { get; set; }

        /// <summary>
        /// Gets or Sets DateCancelled
        /// </summary>
        [DataMember(Name="dateCancelled", EmitDefaultValue=true)]
        public string DateCancelled { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="serialNumber", EmitDefaultValue=true)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets MortgagorDistrict
        /// </summary>
        [DataMember(Name="mortgagorDistrict", EmitDefaultValue=true)]
        public string MortgagorDistrict { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialUnmatchedNotarialBond {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  NumberFound: ").Append(NumberFound).Append("\n");
            sb.Append("  BondDate: ").Append(BondDate).Append("\n");
            sb.Append("  Mortgagor: ").Append(Mortgagor).Append("\n");
            sb.Append("  TradeStyle: ").Append(TradeStyle).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  BondNumber: ").Append(BondNumber).Append("\n");
            sb.Append("  BondAmount: ").Append(BondAmount).Append("\n");
            sb.Append("  BondPercent: ").Append(BondPercent).Append("\n");
            sb.Append("  BondDistrict: ").Append(BondDistrict).Append("\n");
            sb.Append("  Mortgagee: ").Append(Mortgagee).Append("\n");
            sb.Append("  DateCancelled: ").Append(DateCancelled).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  MortgagorDistrict: ").Append(MortgagorDistrict).Append("\n");
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
            return this.Equals(input as TransunionCommercialUnmatchedNotarialBond);
        }

        /// <summary>
        /// Returns true if TransunionCommercialUnmatchedNotarialBond instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialUnmatchedNotarialBond to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialUnmatchedNotarialBond input)
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
                    this.NumberFound == input.NumberFound ||
                    (this.NumberFound != null &&
                    this.NumberFound.Equals(input.NumberFound))
                ) && 
                (
                    this.BondDate == input.BondDate ||
                    (this.BondDate != null &&
                    this.BondDate.Equals(input.BondDate))
                ) && 
                (
                    this.Mortgagor == input.Mortgagor ||
                    (this.Mortgagor != null &&
                    this.Mortgagor.Equals(input.Mortgagor))
                ) && 
                (
                    this.TradeStyle == input.TradeStyle ||
                    (this.TradeStyle != null &&
                    this.TradeStyle.Equals(input.TradeStyle))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
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
                ) && 
                (
                    this.BondPercent == input.BondPercent ||
                    (this.BondPercent != null &&
                    this.BondPercent.Equals(input.BondPercent))
                ) && 
                (
                    this.BondDistrict == input.BondDistrict ||
                    (this.BondDistrict != null &&
                    this.BondDistrict.Equals(input.BondDistrict))
                ) && 
                (
                    this.Mortgagee == input.Mortgagee ||
                    (this.Mortgagee != null &&
                    this.Mortgagee.Equals(input.Mortgagee))
                ) && 
                (
                    this.DateCancelled == input.DateCancelled ||
                    (this.DateCancelled != null &&
                    this.DateCancelled.Equals(input.DateCancelled))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.MortgagorDistrict == input.MortgagorDistrict ||
                    (this.MortgagorDistrict != null &&
                    this.MortgagorDistrict.Equals(input.MortgagorDistrict))
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
                if (this.NumberFound != null)
                    hashCode = hashCode * 59 + this.NumberFound.GetHashCode();
                if (this.BondDate != null)
                    hashCode = hashCode * 59 + this.BondDate.GetHashCode();
                if (this.Mortgagor != null)
                    hashCode = hashCode * 59 + this.Mortgagor.GetHashCode();
                if (this.TradeStyle != null)
                    hashCode = hashCode * 59 + this.TradeStyle.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.BondNumber != null)
                    hashCode = hashCode * 59 + this.BondNumber.GetHashCode();
                if (this.BondAmount != null)
                    hashCode = hashCode * 59 + this.BondAmount.GetHashCode();
                if (this.BondPercent != null)
                    hashCode = hashCode * 59 + this.BondPercent.GetHashCode();
                if (this.BondDistrict != null)
                    hashCode = hashCode * 59 + this.BondDistrict.GetHashCode();
                if (this.Mortgagee != null)
                    hashCode = hashCode * 59 + this.Mortgagee.GetHashCode();
                if (this.DateCancelled != null)
                    hashCode = hashCode * 59 + this.DateCancelled.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.MortgagorDistrict != null)
                    hashCode = hashCode * 59 + this.MortgagorDistrict.GetHashCode();
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
