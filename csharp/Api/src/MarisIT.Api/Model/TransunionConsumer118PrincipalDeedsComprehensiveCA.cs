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
    /// TransunionConsumer118PrincipalDeedsComprehensiveCA
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118PrincipalDeedsComprehensiveCA :  IEquatable<TransunionConsumer118PrincipalDeedsComprehensiveCA>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118PrincipalDeedsComprehensiveCA" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="date">date.</param>
        /// <param name="comment">comment.</param>
        /// <param name="purchasePrice">purchasePrice.</param>
        /// <param name="purchaseDate">purchaseDate.</param>
        /// <param name="propertySize">propertySize.</param>
        /// <param name="bondNumber">bondNumber.</param>
        /// <param name="bondHolder">bondHolder.</param>
        /// <param name="bondAmount">bondAmount.</param>
        /// <param name="bondDate">bondDate.</param>
        /// <param name="multipleOwners">multipleOwners.</param>
        /// <param name="share">share.</param>
        /// <param name="dateOfBirthOrIDNumber">dateOfBirthOrIDNumber.</param>
        /// <param name="erf">erf.</param>
        /// <param name="propertyType">propertyType.</param>
        /// <param name="farm">farm.</param>
        /// <param name="propertyName">propertyName.</param>
        /// <param name="schemeName">schemeName.</param>
        /// <param name="schemeNumber">schemeNumber.</param>
        /// <param name="portion">portion.</param>
        /// <param name="title">title.</param>
        /// <param name="township">township.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="rowID">rowID.</param>
        /// <param name="street">street.</param>
        /// <param name="province">province.</param>
        /// <param name="streetNumber">streetNumber.</param>
        public TransunionConsumer118PrincipalDeedsComprehensiveCA(string majorProduct = default(string), string date = default(string), string comment = default(string), string purchasePrice = default(string), string purchaseDate = default(string), string propertySize = default(string), string bondNumber = default(string), string bondHolder = default(string), string bondAmount = default(string), string bondDate = default(string), string multipleOwners = default(string), string share = default(string), string dateOfBirthOrIDNumber = default(string), string erf = default(string), string propertyType = default(string), string farm = default(string), string propertyName = default(string), string schemeName = default(string), string schemeNumber = default(string), string portion = default(string), string title = default(string), string township = default(string), string deedsOffice = default(string), string rowID = default(string), string street = default(string), string province = default(string), string streetNumber = default(string))
        {
            this.MajorProduct = majorProduct;
            this.Date = date;
            this.Comment = comment;
            this.PurchasePrice = purchasePrice;
            this.PurchaseDate = purchaseDate;
            this.PropertySize = propertySize;
            this.BondNumber = bondNumber;
            this.BondHolder = bondHolder;
            this.BondAmount = bondAmount;
            this.BondDate = bondDate;
            this.MultipleOwners = multipleOwners;
            this.Share = share;
            this.DateOfBirthOrIDNumber = dateOfBirthOrIDNumber;
            this.Erf = erf;
            this.PropertyType = propertyType;
            this.Farm = farm;
            this.PropertyName = propertyName;
            this.SchemeName = schemeName;
            this.SchemeNumber = schemeNumber;
            this.Portion = portion;
            this.Title = title;
            this.Township = township;
            this.DeedsOffice = deedsOffice;
            this.RowID = rowID;
            this.Street = street;
            this.Province = province;
            this.StreetNumber = streetNumber;
            this.MajorProduct = majorProduct;
            this.Date = date;
            this.Comment = comment;
            this.PurchasePrice = purchasePrice;
            this.PurchaseDate = purchaseDate;
            this.PropertySize = propertySize;
            this.BondNumber = bondNumber;
            this.BondHolder = bondHolder;
            this.BondAmount = bondAmount;
            this.BondDate = bondDate;
            this.MultipleOwners = multipleOwners;
            this.Share = share;
            this.DateOfBirthOrIDNumber = dateOfBirthOrIDNumber;
            this.Erf = erf;
            this.PropertyType = propertyType;
            this.Farm = farm;
            this.PropertyName = propertyName;
            this.SchemeName = schemeName;
            this.SchemeNumber = schemeNumber;
            this.Portion = portion;
            this.Title = title;
            this.Township = township;
            this.DeedsOffice = deedsOffice;
            this.RowID = rowID;
            this.Street = street;
            this.Province = province;
            this.StreetNumber = streetNumber;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=true)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=true)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name="purchasePrice", EmitDefaultValue=true)]
        public string PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDate
        /// </summary>
        [DataMember(Name="purchaseDate", EmitDefaultValue=true)]
        public string PurchaseDate { get; set; }

        /// <summary>
        /// Gets or Sets PropertySize
        /// </summary>
        [DataMember(Name="propertySize", EmitDefaultValue=true)]
        public string PropertySize { get; set; }

        /// <summary>
        /// Gets or Sets BondNumber
        /// </summary>
        [DataMember(Name="bondNumber", EmitDefaultValue=true)]
        public string BondNumber { get; set; }

        /// <summary>
        /// Gets or Sets BondHolder
        /// </summary>
        [DataMember(Name="bondHolder", EmitDefaultValue=true)]
        public string BondHolder { get; set; }

        /// <summary>
        /// Gets or Sets BondAmount
        /// </summary>
        [DataMember(Name="bondAmount", EmitDefaultValue=true)]
        public string BondAmount { get; set; }

        /// <summary>
        /// Gets or Sets BondDate
        /// </summary>
        [DataMember(Name="bondDate", EmitDefaultValue=true)]
        public string BondDate { get; set; }

        /// <summary>
        /// Gets or Sets MultipleOwners
        /// </summary>
        [DataMember(Name="multipleOwners", EmitDefaultValue=true)]
        public string MultipleOwners { get; set; }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=true)]
        public string Share { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirthOrIDNumber
        /// </summary>
        [DataMember(Name="dateOfBirthOrIDNumber", EmitDefaultValue=true)]
        public string DateOfBirthOrIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Erf
        /// </summary>
        [DataMember(Name="erf", EmitDefaultValue=true)]
        public string Erf { get; set; }

        /// <summary>
        /// Gets or Sets PropertyType
        /// </summary>
        [DataMember(Name="propertyType", EmitDefaultValue=true)]
        public string PropertyType { get; set; }

        /// <summary>
        /// Gets or Sets Farm
        /// </summary>
        [DataMember(Name="farm", EmitDefaultValue=true)]
        public string Farm { get; set; }

        /// <summary>
        /// Gets or Sets PropertyName
        /// </summary>
        [DataMember(Name="propertyName", EmitDefaultValue=true)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or Sets SchemeName
        /// </summary>
        [DataMember(Name="schemeName", EmitDefaultValue=true)]
        public string SchemeName { get; set; }

        /// <summary>
        /// Gets or Sets SchemeNumber
        /// </summary>
        [DataMember(Name="schemeNumber", EmitDefaultValue=true)]
        public string SchemeNumber { get; set; }

        /// <summary>
        /// Gets or Sets Portion
        /// </summary>
        [DataMember(Name="portion", EmitDefaultValue=true)]
        public string Portion { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Township
        /// </summary>
        [DataMember(Name="township", EmitDefaultValue=true)]
        public string Township { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public string DeedsOffice { get; set; }

        /// <summary>
        /// Gets or Sets RowID
        /// </summary>
        [DataMember(Name="rowID", EmitDefaultValue=true)]
        public string RowID { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=true)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets StreetNumber
        /// </summary>
        [DataMember(Name="streetNumber", EmitDefaultValue=true)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118PrincipalDeedsComprehensiveCA {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  PropertySize: ").Append(PropertySize).Append("\n");
            sb.Append("  BondNumber: ").Append(BondNumber).Append("\n");
            sb.Append("  BondHolder: ").Append(BondHolder).Append("\n");
            sb.Append("  BondAmount: ").Append(BondAmount).Append("\n");
            sb.Append("  BondDate: ").Append(BondDate).Append("\n");
            sb.Append("  MultipleOwners: ").Append(MultipleOwners).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  DateOfBirthOrIDNumber: ").Append(DateOfBirthOrIDNumber).Append("\n");
            sb.Append("  Erf: ").Append(Erf).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  Farm: ").Append(Farm).Append("\n");
            sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
            sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
            sb.Append("  SchemeNumber: ").Append(SchemeNumber).Append("\n");
            sb.Append("  Portion: ").Append(Portion).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Township: ").Append(Township).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  RowID: ").Append(RowID).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
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
            return this.Equals(input as TransunionConsumer118PrincipalDeedsComprehensiveCA);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118PrincipalDeedsComprehensiveCA instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118PrincipalDeedsComprehensiveCA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118PrincipalDeedsComprehensiveCA input)
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.PurchaseDate == input.PurchaseDate ||
                    (this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(input.PurchaseDate))
                ) && 
                (
                    this.PropertySize == input.PropertySize ||
                    (this.PropertySize != null &&
                    this.PropertySize.Equals(input.PropertySize))
                ) && 
                (
                    this.BondNumber == input.BondNumber ||
                    (this.BondNumber != null &&
                    this.BondNumber.Equals(input.BondNumber))
                ) && 
                (
                    this.BondHolder == input.BondHolder ||
                    (this.BondHolder != null &&
                    this.BondHolder.Equals(input.BondHolder))
                ) && 
                (
                    this.BondAmount == input.BondAmount ||
                    (this.BondAmount != null &&
                    this.BondAmount.Equals(input.BondAmount))
                ) && 
                (
                    this.BondDate == input.BondDate ||
                    (this.BondDate != null &&
                    this.BondDate.Equals(input.BondDate))
                ) && 
                (
                    this.MultipleOwners == input.MultipleOwners ||
                    (this.MultipleOwners != null &&
                    this.MultipleOwners.Equals(input.MultipleOwners))
                ) && 
                (
                    this.Share == input.Share ||
                    (this.Share != null &&
                    this.Share.Equals(input.Share))
                ) && 
                (
                    this.DateOfBirthOrIDNumber == input.DateOfBirthOrIDNumber ||
                    (this.DateOfBirthOrIDNumber != null &&
                    this.DateOfBirthOrIDNumber.Equals(input.DateOfBirthOrIDNumber))
                ) && 
                (
                    this.Erf == input.Erf ||
                    (this.Erf != null &&
                    this.Erf.Equals(input.Erf))
                ) && 
                (
                    this.PropertyType == input.PropertyType ||
                    (this.PropertyType != null &&
                    this.PropertyType.Equals(input.PropertyType))
                ) && 
                (
                    this.Farm == input.Farm ||
                    (this.Farm != null &&
                    this.Farm.Equals(input.Farm))
                ) && 
                (
                    this.PropertyName == input.PropertyName ||
                    (this.PropertyName != null &&
                    this.PropertyName.Equals(input.PropertyName))
                ) && 
                (
                    this.SchemeName == input.SchemeName ||
                    (this.SchemeName != null &&
                    this.SchemeName.Equals(input.SchemeName))
                ) && 
                (
                    this.SchemeNumber == input.SchemeNumber ||
                    (this.SchemeNumber != null &&
                    this.SchemeNumber.Equals(input.SchemeNumber))
                ) && 
                (
                    this.Portion == input.Portion ||
                    (this.Portion != null &&
                    this.Portion.Equals(input.Portion))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Township == input.Township ||
                    (this.Township != null &&
                    this.Township.Equals(input.Township))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.RowID == input.RowID ||
                    (this.RowID != null &&
                    this.RowID.Equals(input.RowID))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.PurchaseDate != null)
                    hashCode = hashCode * 59 + this.PurchaseDate.GetHashCode();
                if (this.PropertySize != null)
                    hashCode = hashCode * 59 + this.PropertySize.GetHashCode();
                if (this.BondNumber != null)
                    hashCode = hashCode * 59 + this.BondNumber.GetHashCode();
                if (this.BondHolder != null)
                    hashCode = hashCode * 59 + this.BondHolder.GetHashCode();
                if (this.BondAmount != null)
                    hashCode = hashCode * 59 + this.BondAmount.GetHashCode();
                if (this.BondDate != null)
                    hashCode = hashCode * 59 + this.BondDate.GetHashCode();
                if (this.MultipleOwners != null)
                    hashCode = hashCode * 59 + this.MultipleOwners.GetHashCode();
                if (this.Share != null)
                    hashCode = hashCode * 59 + this.Share.GetHashCode();
                if (this.DateOfBirthOrIDNumber != null)
                    hashCode = hashCode * 59 + this.DateOfBirthOrIDNumber.GetHashCode();
                if (this.Erf != null)
                    hashCode = hashCode * 59 + this.Erf.GetHashCode();
                if (this.PropertyType != null)
                    hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                if (this.Farm != null)
                    hashCode = hashCode * 59 + this.Farm.GetHashCode();
                if (this.PropertyName != null)
                    hashCode = hashCode * 59 + this.PropertyName.GetHashCode();
                if (this.SchemeName != null)
                    hashCode = hashCode * 59 + this.SchemeName.GetHashCode();
                if (this.SchemeNumber != null)
                    hashCode = hashCode * 59 + this.SchemeNumber.GetHashCode();
                if (this.Portion != null)
                    hashCode = hashCode * 59 + this.Portion.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Township != null)
                    hashCode = hashCode * 59 + this.Township.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.RowID != null)
                    hashCode = hashCode * 59 + this.RowID.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
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