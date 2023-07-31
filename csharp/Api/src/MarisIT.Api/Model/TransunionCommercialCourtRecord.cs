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
    /// TransunionCommercialCourtRecord
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialCourtRecord :  IEquatable<TransunionCommercialCourtRecord>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialCourtRecord" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="numberFound">numberFound.</param>
        /// <param name="actionDate">actionDate.</param>
        /// <param name="typeCode">typeCode.</param>
        /// <param name="claimAmount">claimAmount.</param>
        /// <param name="typeDesc">typeDesc.</param>
        /// <param name="defendantName">defendantName.</param>
        /// <param name="defendantTradeStyle">defendantTradeStyle.</param>
        /// <param name="courtRecordAddress">courtRecordAddress.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="natureOfDebt">natureOfDebt.</param>
        /// <param name="defendantDistrict">defendantDistrict.</param>
        /// <param name="caseNumber">caseNumber.</param>
        /// <param name="courtDistrict">courtDistrict.</param>
        /// <param name="courtType">courtType.</param>
        /// <param name="plaintiffName">plaintiffName.</param>
        /// <param name="attorney">attorney.</param>
        /// <param name="comment">comment.</param>
        /// <param name="abandonDate">abandonDate.</param>
        /// <param name="returnDate">returnDate.</param>
        /// <param name="message">message.</param>
        /// <param name="serialNumber">serialNumber.</param>
        /// <param name="paidInFullIndicator">paidInFullIndicator.</param>
        /// <param name="paidInFullDate">paidInFullDate.</param>
        /// <param name="itNumber">itNumber.</param>
        public TransunionCommercialCourtRecord(string majorProduct = default(string), string numberFound = default(string), string actionDate = default(string), string typeCode = default(string), string claimAmount = default(string), string typeDesc = default(string), string defendantName = default(string), string defendantTradeStyle = default(string), string courtRecordAddress = default(string), string suburb = default(string), string city = default(string), string country = default(string), string postCode = default(string), string natureOfDebt = default(string), string defendantDistrict = default(string), string caseNumber = default(string), string courtDistrict = default(string), string courtType = default(string), string plaintiffName = default(string), string attorney = default(string), string comment = default(string), string abandonDate = default(string), string returnDate = default(string), string message = default(string), string serialNumber = default(string), string paidInFullIndicator = default(string), string paidInFullDate = default(string), string itNumber = default(string))
        {
            this.MajorProduct = majorProduct;
            this.NumberFound = numberFound;
            this.ActionDate = actionDate;
            this.TypeCode = typeCode;
            this.ClaimAmount = claimAmount;
            this.TypeDesc = typeDesc;
            this.DefendantName = defendantName;
            this.DefendantTradeStyle = defendantTradeStyle;
            this.CourtRecordAddress = courtRecordAddress;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
            this.PostCode = postCode;
            this.NatureOfDebt = natureOfDebt;
            this.DefendantDistrict = defendantDistrict;
            this.CaseNumber = caseNumber;
            this.CourtDistrict = courtDistrict;
            this.CourtType = courtType;
            this.PlaintiffName = plaintiffName;
            this.Attorney = attorney;
            this.Comment = comment;
            this.AbandonDate = abandonDate;
            this.ReturnDate = returnDate;
            this.Message = message;
            this.SerialNumber = serialNumber;
            this.PaidInFullIndicator = paidInFullIndicator;
            this.PaidInFullDate = paidInFullDate;
            this.ItNumber = itNumber;
            this.MajorProduct = majorProduct;
            this.NumberFound = numberFound;
            this.ActionDate = actionDate;
            this.TypeCode = typeCode;
            this.ClaimAmount = claimAmount;
            this.TypeDesc = typeDesc;
            this.DefendantName = defendantName;
            this.DefendantTradeStyle = defendantTradeStyle;
            this.CourtRecordAddress = courtRecordAddress;
            this.Suburb = suburb;
            this.City = city;
            this.Country = country;
            this.PostCode = postCode;
            this.NatureOfDebt = natureOfDebt;
            this.DefendantDistrict = defendantDistrict;
            this.CaseNumber = caseNumber;
            this.CourtDistrict = courtDistrict;
            this.CourtType = courtType;
            this.PlaintiffName = plaintiffName;
            this.Attorney = attorney;
            this.Comment = comment;
            this.AbandonDate = abandonDate;
            this.ReturnDate = returnDate;
            this.Message = message;
            this.SerialNumber = serialNumber;
            this.PaidInFullIndicator = paidInFullIndicator;
            this.PaidInFullDate = paidInFullDate;
            this.ItNumber = itNumber;
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
        /// Gets or Sets ActionDate
        /// </summary>
        [DataMember(Name="actionDate", EmitDefaultValue=true)]
        public string ActionDate { get; set; }

        /// <summary>
        /// Gets or Sets TypeCode
        /// </summary>
        [DataMember(Name="typeCode", EmitDefaultValue=true)]
        public string TypeCode { get; set; }

        /// <summary>
        /// Gets or Sets ClaimAmount
        /// </summary>
        [DataMember(Name="claimAmount", EmitDefaultValue=true)]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// Gets or Sets TypeDesc
        /// </summary>
        [DataMember(Name="typeDesc", EmitDefaultValue=true)]
        public string TypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets DefendantName
        /// </summary>
        [DataMember(Name="defendantName", EmitDefaultValue=true)]
        public string DefendantName { get; set; }

        /// <summary>
        /// Gets or Sets DefendantTradeStyle
        /// </summary>
        [DataMember(Name="defendantTradeStyle", EmitDefaultValue=true)]
        public string DefendantTradeStyle { get; set; }

        /// <summary>
        /// Gets or Sets CourtRecordAddress
        /// </summary>
        [DataMember(Name="courtRecordAddress", EmitDefaultValue=true)]
        public string CourtRecordAddress { get; set; }

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
        /// Gets or Sets NatureOfDebt
        /// </summary>
        [DataMember(Name="natureOfDebt", EmitDefaultValue=true)]
        public string NatureOfDebt { get; set; }

        /// <summary>
        /// Gets or Sets DefendantDistrict
        /// </summary>
        [DataMember(Name="defendantDistrict", EmitDefaultValue=true)]
        public string DefendantDistrict { get; set; }

        /// <summary>
        /// Gets or Sets CaseNumber
        /// </summary>
        [DataMember(Name="caseNumber", EmitDefaultValue=true)]
        public string CaseNumber { get; set; }

        /// <summary>
        /// Gets or Sets CourtDistrict
        /// </summary>
        [DataMember(Name="courtDistrict", EmitDefaultValue=true)]
        public string CourtDistrict { get; set; }

        /// <summary>
        /// Gets or Sets CourtType
        /// </summary>
        [DataMember(Name="courtType", EmitDefaultValue=true)]
        public string CourtType { get; set; }

        /// <summary>
        /// Gets or Sets PlaintiffName
        /// </summary>
        [DataMember(Name="plaintiffName", EmitDefaultValue=true)]
        public string PlaintiffName { get; set; }

        /// <summary>
        /// Gets or Sets Attorney
        /// </summary>
        [DataMember(Name="attorney", EmitDefaultValue=true)]
        public string Attorney { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets AbandonDate
        /// </summary>
        [DataMember(Name="abandonDate", EmitDefaultValue=true)]
        public string AbandonDate { get; set; }

        /// <summary>
        /// Gets or Sets ReturnDate
        /// </summary>
        [DataMember(Name="returnDate", EmitDefaultValue=true)]
        public string ReturnDate { get; set; }

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
        /// Gets or Sets PaidInFullIndicator
        /// </summary>
        [DataMember(Name="paidInFullIndicator", EmitDefaultValue=true)]
        public string PaidInFullIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PaidInFullDate
        /// </summary>
        [DataMember(Name="paidInFullDate", EmitDefaultValue=true)]
        public string PaidInFullDate { get; set; }

        /// <summary>
        /// Gets or Sets ItNumber
        /// </summary>
        [DataMember(Name="itNumber", EmitDefaultValue=true)]
        public string ItNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialCourtRecord {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  NumberFound: ").Append(NumberFound).Append("\n");
            sb.Append("  ActionDate: ").Append(ActionDate).Append("\n");
            sb.Append("  TypeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  ClaimAmount: ").Append(ClaimAmount).Append("\n");
            sb.Append("  TypeDesc: ").Append(TypeDesc).Append("\n");
            sb.Append("  DefendantName: ").Append(DefendantName).Append("\n");
            sb.Append("  DefendantTradeStyle: ").Append(DefendantTradeStyle).Append("\n");
            sb.Append("  CourtRecordAddress: ").Append(CourtRecordAddress).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  NatureOfDebt: ").Append(NatureOfDebt).Append("\n");
            sb.Append("  DefendantDistrict: ").Append(DefendantDistrict).Append("\n");
            sb.Append("  CaseNumber: ").Append(CaseNumber).Append("\n");
            sb.Append("  CourtDistrict: ").Append(CourtDistrict).Append("\n");
            sb.Append("  CourtType: ").Append(CourtType).Append("\n");
            sb.Append("  PlaintiffName: ").Append(PlaintiffName).Append("\n");
            sb.Append("  Attorney: ").Append(Attorney).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  AbandonDate: ").Append(AbandonDate).Append("\n");
            sb.Append("  ReturnDate: ").Append(ReturnDate).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  PaidInFullIndicator: ").Append(PaidInFullIndicator).Append("\n");
            sb.Append("  PaidInFullDate: ").Append(PaidInFullDate).Append("\n");
            sb.Append("  ItNumber: ").Append(ItNumber).Append("\n");
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
            return this.Equals(input as TransunionCommercialCourtRecord);
        }

        /// <summary>
        /// Returns true if TransunionCommercialCourtRecord instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialCourtRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialCourtRecord input)
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
                    this.ActionDate == input.ActionDate ||
                    (this.ActionDate != null &&
                    this.ActionDate.Equals(input.ActionDate))
                ) && 
                (
                    this.TypeCode == input.TypeCode ||
                    (this.TypeCode != null &&
                    this.TypeCode.Equals(input.TypeCode))
                ) && 
                (
                    this.ClaimAmount == input.ClaimAmount ||
                    (this.ClaimAmount != null &&
                    this.ClaimAmount.Equals(input.ClaimAmount))
                ) && 
                (
                    this.TypeDesc == input.TypeDesc ||
                    (this.TypeDesc != null &&
                    this.TypeDesc.Equals(input.TypeDesc))
                ) && 
                (
                    this.DefendantName == input.DefendantName ||
                    (this.DefendantName != null &&
                    this.DefendantName.Equals(input.DefendantName))
                ) && 
                (
                    this.DefendantTradeStyle == input.DefendantTradeStyle ||
                    (this.DefendantTradeStyle != null &&
                    this.DefendantTradeStyle.Equals(input.DefendantTradeStyle))
                ) && 
                (
                    this.CourtRecordAddress == input.CourtRecordAddress ||
                    (this.CourtRecordAddress != null &&
                    this.CourtRecordAddress.Equals(input.CourtRecordAddress))
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
                    this.NatureOfDebt == input.NatureOfDebt ||
                    (this.NatureOfDebt != null &&
                    this.NatureOfDebt.Equals(input.NatureOfDebt))
                ) && 
                (
                    this.DefendantDistrict == input.DefendantDistrict ||
                    (this.DefendantDistrict != null &&
                    this.DefendantDistrict.Equals(input.DefendantDistrict))
                ) && 
                (
                    this.CaseNumber == input.CaseNumber ||
                    (this.CaseNumber != null &&
                    this.CaseNumber.Equals(input.CaseNumber))
                ) && 
                (
                    this.CourtDistrict == input.CourtDistrict ||
                    (this.CourtDistrict != null &&
                    this.CourtDistrict.Equals(input.CourtDistrict))
                ) && 
                (
                    this.CourtType == input.CourtType ||
                    (this.CourtType != null &&
                    this.CourtType.Equals(input.CourtType))
                ) && 
                (
                    this.PlaintiffName == input.PlaintiffName ||
                    (this.PlaintiffName != null &&
                    this.PlaintiffName.Equals(input.PlaintiffName))
                ) && 
                (
                    this.Attorney == input.Attorney ||
                    (this.Attorney != null &&
                    this.Attorney.Equals(input.Attorney))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.AbandonDate == input.AbandonDate ||
                    (this.AbandonDate != null &&
                    this.AbandonDate.Equals(input.AbandonDate))
                ) && 
                (
                    this.ReturnDate == input.ReturnDate ||
                    (this.ReturnDate != null &&
                    this.ReturnDate.Equals(input.ReturnDate))
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
                    this.PaidInFullIndicator == input.PaidInFullIndicator ||
                    (this.PaidInFullIndicator != null &&
                    this.PaidInFullIndicator.Equals(input.PaidInFullIndicator))
                ) && 
                (
                    this.PaidInFullDate == input.PaidInFullDate ||
                    (this.PaidInFullDate != null &&
                    this.PaidInFullDate.Equals(input.PaidInFullDate))
                ) && 
                (
                    this.ItNumber == input.ItNumber ||
                    (this.ItNumber != null &&
                    this.ItNumber.Equals(input.ItNumber))
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
                if (this.ActionDate != null)
                    hashCode = hashCode * 59 + this.ActionDate.GetHashCode();
                if (this.TypeCode != null)
                    hashCode = hashCode * 59 + this.TypeCode.GetHashCode();
                if (this.ClaimAmount != null)
                    hashCode = hashCode * 59 + this.ClaimAmount.GetHashCode();
                if (this.TypeDesc != null)
                    hashCode = hashCode * 59 + this.TypeDesc.GetHashCode();
                if (this.DefendantName != null)
                    hashCode = hashCode * 59 + this.DefendantName.GetHashCode();
                if (this.DefendantTradeStyle != null)
                    hashCode = hashCode * 59 + this.DefendantTradeStyle.GetHashCode();
                if (this.CourtRecordAddress != null)
                    hashCode = hashCode * 59 + this.CourtRecordAddress.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.NatureOfDebt != null)
                    hashCode = hashCode * 59 + this.NatureOfDebt.GetHashCode();
                if (this.DefendantDistrict != null)
                    hashCode = hashCode * 59 + this.DefendantDistrict.GetHashCode();
                if (this.CaseNumber != null)
                    hashCode = hashCode * 59 + this.CaseNumber.GetHashCode();
                if (this.CourtDistrict != null)
                    hashCode = hashCode * 59 + this.CourtDistrict.GetHashCode();
                if (this.CourtType != null)
                    hashCode = hashCode * 59 + this.CourtType.GetHashCode();
                if (this.PlaintiffName != null)
                    hashCode = hashCode * 59 + this.PlaintiffName.GetHashCode();
                if (this.Attorney != null)
                    hashCode = hashCode * 59 + this.Attorney.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.AbandonDate != null)
                    hashCode = hashCode * 59 + this.AbandonDate.GetHashCode();
                if (this.ReturnDate != null)
                    hashCode = hashCode * 59 + this.ReturnDate.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.PaidInFullIndicator != null)
                    hashCode = hashCode * 59 + this.PaidInFullIndicator.GetHashCode();
                if (this.PaidInFullDate != null)
                    hashCode = hashCode * 59 + this.PaidInFullDate.GetHashCode();
                if (this.ItNumber != null)
                    hashCode = hashCode * 59 + this.ItNumber.GetHashCode();
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
