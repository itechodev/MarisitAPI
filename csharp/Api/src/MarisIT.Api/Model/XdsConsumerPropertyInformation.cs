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
    /// XdsConsumerPropertyInformation
    /// </summary>
    [DataContract]
    public partial class XdsConsumerPropertyInformation :  IEquatable<XdsConsumerPropertyInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumerPropertyInformation" /> class.
        /// </summary>
        /// <param name="attorneyFileNo">attorneyFileNo.</param>
        /// <param name="attorneyFirmNo">attorneyFirmNo.</param>
        /// <param name="authorityName">authorityName.</param>
        /// <param name="bondAccountNo">bondAccountNo.</param>
        /// <param name="bondAmt">bondAmt.</param>
        /// <param name="bondHolderName">bondHolderName.</param>
        /// <param name="buyerIDNo">buyerIDNo.</param>
        /// <param name="buyerMaritalStatusCode">buyerMaritalStatusCode.</param>
        /// <param name="buyerName">buyerName.</param>
        /// <param name="buyerSharePerc">buyerSharePerc.</param>
        /// <param name="buyerTypeCode">buyerTypeCode.</param>
        /// <param name="cityName">cityName.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="erfNo">erfNo.</param>
        /// <param name="erfSize">erfSize.</param>
        /// <param name="oldTitleDeedNo">oldTitleDeedNo.</param>
        /// <param name="physicalAddress">physicalAddress.</param>
        /// <param name="portionNo">portionNo.</param>
        /// <param name="propertyTypeCode">propertyTypeCode.</param>
        /// <param name="propertyTypeDesc">propertyTypeDesc.</param>
        /// <param name="purchaseDate">purchaseDate.</param>
        /// <param name="purchasePriceAmt">purchasePriceAmt.</param>
        /// <param name="registrarName">registrarName.</param>
        /// <param name="sellerIDNo">sellerIDNo.</param>
        /// <param name="sellerMaritalStatusCode">sellerMaritalStatusCode.</param>
        /// <param name="sellerName">sellerName.</param>
        /// <param name="sellerTypeCode">sellerTypeCode.</param>
        /// <param name="standNo">standNo.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="streetNo">streetNo.</param>
        /// <param name="suburbName">suburbName.</param>
        /// <param name="titleDeedFeeAmt">titleDeedFeeAmt.</param>
        /// <param name="titleDeedNo">titleDeedNo.</param>
        /// <param name="townshipName">townshipName.</param>
        /// <param name="transferDate">transferDate.</param>
        /// <param name="transferID">transferID.</param>
        /// <param name="farmName">farmName.</param>
        /// <param name="schemeName">schemeName.</param>
        public XdsConsumerPropertyInformation(string attorneyFileNo = default(string), string attorneyFirmNo = default(string), string authorityName = default(string), string bondAccountNo = default(string), string bondAmt = default(string), string bondHolderName = default(string), string buyerIDNo = default(string), string buyerMaritalStatusCode = default(string), string buyerName = default(string), string buyerSharePerc = default(string), string buyerTypeCode = default(string), string cityName = default(string), string deedsOffice = default(string), string displayText = default(string), string erfNo = default(string), string erfSize = default(string), string oldTitleDeedNo = default(string), string physicalAddress = default(string), string portionNo = default(string), string propertyTypeCode = default(string), string propertyTypeDesc = default(string), string purchaseDate = default(string), string purchasePriceAmt = default(string), string registrarName = default(string), string sellerIDNo = default(string), string sellerMaritalStatusCode = default(string), string sellerName = default(string), string sellerTypeCode = default(string), string standNo = default(string), string streetName = default(string), string streetNo = default(string), string suburbName = default(string), string titleDeedFeeAmt = default(string), string titleDeedNo = default(string), string townshipName = default(string), string transferDate = default(string), string transferID = default(string), string farmName = default(string), string schemeName = default(string))
        {
            this.AttorneyFileNo = attorneyFileNo;
            this.AttorneyFirmNo = attorneyFirmNo;
            this.AuthorityName = authorityName;
            this.BondAccountNo = bondAccountNo;
            this.BondAmt = bondAmt;
            this.BondHolderName = bondHolderName;
            this.BuyerIDNo = buyerIDNo;
            this.BuyerMaritalStatusCode = buyerMaritalStatusCode;
            this.BuyerName = buyerName;
            this.BuyerSharePerc = buyerSharePerc;
            this.BuyerTypeCode = buyerTypeCode;
            this.CityName = cityName;
            this.DeedsOffice = deedsOffice;
            this.DisplayText = displayText;
            this.ErfNo = erfNo;
            this.ErfSize = erfSize;
            this.OldTitleDeedNo = oldTitleDeedNo;
            this.PhysicalAddress = physicalAddress;
            this.PortionNo = portionNo;
            this.PropertyTypeCode = propertyTypeCode;
            this.PropertyTypeDesc = propertyTypeDesc;
            this.PurchaseDate = purchaseDate;
            this.PurchasePriceAmt = purchasePriceAmt;
            this.RegistrarName = registrarName;
            this.SellerIDNo = sellerIDNo;
            this.SellerMaritalStatusCode = sellerMaritalStatusCode;
            this.SellerName = sellerName;
            this.SellerTypeCode = sellerTypeCode;
            this.StandNo = standNo;
            this.StreetName = streetName;
            this.StreetNo = streetNo;
            this.SuburbName = suburbName;
            this.TitleDeedFeeAmt = titleDeedFeeAmt;
            this.TitleDeedNo = titleDeedNo;
            this.TownshipName = townshipName;
            this.TransferDate = transferDate;
            this.TransferID = transferID;
            this.FarmName = farmName;
            this.SchemeName = schemeName;
            this.AttorneyFileNo = attorneyFileNo;
            this.AttorneyFirmNo = attorneyFirmNo;
            this.AuthorityName = authorityName;
            this.BondAccountNo = bondAccountNo;
            this.BondAmt = bondAmt;
            this.BondHolderName = bondHolderName;
            this.BuyerIDNo = buyerIDNo;
            this.BuyerMaritalStatusCode = buyerMaritalStatusCode;
            this.BuyerName = buyerName;
            this.BuyerSharePerc = buyerSharePerc;
            this.BuyerTypeCode = buyerTypeCode;
            this.CityName = cityName;
            this.DeedsOffice = deedsOffice;
            this.DisplayText = displayText;
            this.ErfNo = erfNo;
            this.ErfSize = erfSize;
            this.OldTitleDeedNo = oldTitleDeedNo;
            this.PhysicalAddress = physicalAddress;
            this.PortionNo = portionNo;
            this.PropertyTypeCode = propertyTypeCode;
            this.PropertyTypeDesc = propertyTypeDesc;
            this.PurchaseDate = purchaseDate;
            this.PurchasePriceAmt = purchasePriceAmt;
            this.RegistrarName = registrarName;
            this.SellerIDNo = sellerIDNo;
            this.SellerMaritalStatusCode = sellerMaritalStatusCode;
            this.SellerName = sellerName;
            this.SellerTypeCode = sellerTypeCode;
            this.StandNo = standNo;
            this.StreetName = streetName;
            this.StreetNo = streetNo;
            this.SuburbName = suburbName;
            this.TitleDeedFeeAmt = titleDeedFeeAmt;
            this.TitleDeedNo = titleDeedNo;
            this.TownshipName = townshipName;
            this.TransferDate = transferDate;
            this.TransferID = transferID;
            this.FarmName = farmName;
            this.SchemeName = schemeName;
        }

        /// <summary>
        /// Gets or Sets AttorneyFileNo
        /// </summary>
        [DataMember(Name="attorneyFileNo", EmitDefaultValue=true)]
        public string AttorneyFileNo { get; set; }

        /// <summary>
        /// Gets or Sets AttorneyFirmNo
        /// </summary>
        [DataMember(Name="attorneyFirmNo", EmitDefaultValue=true)]
        public string AttorneyFirmNo { get; set; }

        /// <summary>
        /// Gets or Sets AuthorityName
        /// </summary>
        [DataMember(Name="authorityName", EmitDefaultValue=true)]
        public string AuthorityName { get; set; }

        /// <summary>
        /// Gets or Sets BondAccountNo
        /// </summary>
        [DataMember(Name="bondAccountNo", EmitDefaultValue=true)]
        public string BondAccountNo { get; set; }

        /// <summary>
        /// Gets or Sets BondAmt
        /// </summary>
        [DataMember(Name="bondAmt", EmitDefaultValue=true)]
        public string BondAmt { get; set; }

        /// <summary>
        /// Gets or Sets BondHolderName
        /// </summary>
        [DataMember(Name="bondHolderName", EmitDefaultValue=true)]
        public string BondHolderName { get; set; }

        /// <summary>
        /// Gets or Sets BuyerIDNo
        /// </summary>
        [DataMember(Name="buyerIDNo", EmitDefaultValue=true)]
        public string BuyerIDNo { get; set; }

        /// <summary>
        /// Gets or Sets BuyerMaritalStatusCode
        /// </summary>
        [DataMember(Name="buyerMaritalStatusCode", EmitDefaultValue=true)]
        public string BuyerMaritalStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets BuyerName
        /// </summary>
        [DataMember(Name="buyerName", EmitDefaultValue=true)]
        public string BuyerName { get; set; }

        /// <summary>
        /// Gets or Sets BuyerSharePerc
        /// </summary>
        [DataMember(Name="buyerSharePerc", EmitDefaultValue=true)]
        public string BuyerSharePerc { get; set; }

        /// <summary>
        /// Gets or Sets BuyerTypeCode
        /// </summary>
        [DataMember(Name="buyerTypeCode", EmitDefaultValue=true)]
        public string BuyerTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets CityName
        /// </summary>
        [DataMember(Name="cityName", EmitDefaultValue=true)]
        public string CityName { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=true)]
        public string DeedsOffice { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets ErfNo
        /// </summary>
        [DataMember(Name="erfNo", EmitDefaultValue=true)]
        public string ErfNo { get; set; }

        /// <summary>
        /// Gets or Sets ErfSize
        /// </summary>
        [DataMember(Name="erfSize", EmitDefaultValue=true)]
        public string ErfSize { get; set; }

        /// <summary>
        /// Gets or Sets OldTitleDeedNo
        /// </summary>
        [DataMember(Name="oldTitleDeedNo", EmitDefaultValue=true)]
        public string OldTitleDeedNo { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalAddress
        /// </summary>
        [DataMember(Name="physicalAddress", EmitDefaultValue=true)]
        public string PhysicalAddress { get; set; }

        /// <summary>
        /// Gets or Sets PortionNo
        /// </summary>
        [DataMember(Name="portionNo", EmitDefaultValue=true)]
        public string PortionNo { get; set; }

        /// <summary>
        /// Gets or Sets PropertyTypeCode
        /// </summary>
        [DataMember(Name="propertyTypeCode", EmitDefaultValue=true)]
        public string PropertyTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets PropertyTypeDesc
        /// </summary>
        [DataMember(Name="propertyTypeDesc", EmitDefaultValue=true)]
        public string PropertyTypeDesc { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDate
        /// </summary>
        [DataMember(Name="purchaseDate", EmitDefaultValue=true)]
        public string PurchaseDate { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePriceAmt
        /// </summary>
        [DataMember(Name="purchasePriceAmt", EmitDefaultValue=true)]
        public string PurchasePriceAmt { get; set; }

        /// <summary>
        /// Gets or Sets RegistrarName
        /// </summary>
        [DataMember(Name="registrarName", EmitDefaultValue=true)]
        public string RegistrarName { get; set; }

        /// <summary>
        /// Gets or Sets SellerIDNo
        /// </summary>
        [DataMember(Name="sellerIDNo", EmitDefaultValue=true)]
        public string SellerIDNo { get; set; }

        /// <summary>
        /// Gets or Sets SellerMaritalStatusCode
        /// </summary>
        [DataMember(Name="sellerMaritalStatusCode", EmitDefaultValue=true)]
        public string SellerMaritalStatusCode { get; set; }

        /// <summary>
        /// Gets or Sets SellerName
        /// </summary>
        [DataMember(Name="sellerName", EmitDefaultValue=true)]
        public string SellerName { get; set; }

        /// <summary>
        /// Gets or Sets SellerTypeCode
        /// </summary>
        [DataMember(Name="sellerTypeCode", EmitDefaultValue=true)]
        public string SellerTypeCode { get; set; }

        /// <summary>
        /// Gets or Sets StandNo
        /// </summary>
        [DataMember(Name="standNo", EmitDefaultValue=true)]
        public string StandNo { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=true)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets StreetNo
        /// </summary>
        [DataMember(Name="streetNo", EmitDefaultValue=true)]
        public string StreetNo { get; set; }

        /// <summary>
        /// Gets or Sets SuburbName
        /// </summary>
        [DataMember(Name="suburbName", EmitDefaultValue=true)]
        public string SuburbName { get; set; }

        /// <summary>
        /// Gets or Sets TitleDeedFeeAmt
        /// </summary>
        [DataMember(Name="titleDeedFeeAmt", EmitDefaultValue=true)]
        public string TitleDeedFeeAmt { get; set; }

        /// <summary>
        /// Gets or Sets TitleDeedNo
        /// </summary>
        [DataMember(Name="titleDeedNo", EmitDefaultValue=true)]
        public string TitleDeedNo { get; set; }

        /// <summary>
        /// Gets or Sets TownshipName
        /// </summary>
        [DataMember(Name="townshipName", EmitDefaultValue=true)]
        public string TownshipName { get; set; }

        /// <summary>
        /// Gets or Sets TransferDate
        /// </summary>
        [DataMember(Name="transferDate", EmitDefaultValue=true)]
        public string TransferDate { get; set; }

        /// <summary>
        /// Gets or Sets TransferID
        /// </summary>
        [DataMember(Name="transferID", EmitDefaultValue=true)]
        public string TransferID { get; set; }

        /// <summary>
        /// Gets or Sets FarmName
        /// </summary>
        [DataMember(Name="farmName", EmitDefaultValue=true)]
        public string FarmName { get; set; }

        /// <summary>
        /// Gets or Sets SchemeName
        /// </summary>
        [DataMember(Name="schemeName", EmitDefaultValue=true)]
        public string SchemeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumerPropertyInformation {\n");
            sb.Append("  AttorneyFileNo: ").Append(AttorneyFileNo).Append("\n");
            sb.Append("  AttorneyFirmNo: ").Append(AttorneyFirmNo).Append("\n");
            sb.Append("  AuthorityName: ").Append(AuthorityName).Append("\n");
            sb.Append("  BondAccountNo: ").Append(BondAccountNo).Append("\n");
            sb.Append("  BondAmt: ").Append(BondAmt).Append("\n");
            sb.Append("  BondHolderName: ").Append(BondHolderName).Append("\n");
            sb.Append("  BuyerIDNo: ").Append(BuyerIDNo).Append("\n");
            sb.Append("  BuyerMaritalStatusCode: ").Append(BuyerMaritalStatusCode).Append("\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  BuyerSharePerc: ").Append(BuyerSharePerc).Append("\n");
            sb.Append("  BuyerTypeCode: ").Append(BuyerTypeCode).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  ErfNo: ").Append(ErfNo).Append("\n");
            sb.Append("  ErfSize: ").Append(ErfSize).Append("\n");
            sb.Append("  OldTitleDeedNo: ").Append(OldTitleDeedNo).Append("\n");
            sb.Append("  PhysicalAddress: ").Append(PhysicalAddress).Append("\n");
            sb.Append("  PortionNo: ").Append(PortionNo).Append("\n");
            sb.Append("  PropertyTypeCode: ").Append(PropertyTypeCode).Append("\n");
            sb.Append("  PropertyTypeDesc: ").Append(PropertyTypeDesc).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  PurchasePriceAmt: ").Append(PurchasePriceAmt).Append("\n");
            sb.Append("  RegistrarName: ").Append(RegistrarName).Append("\n");
            sb.Append("  SellerIDNo: ").Append(SellerIDNo).Append("\n");
            sb.Append("  SellerMaritalStatusCode: ").Append(SellerMaritalStatusCode).Append("\n");
            sb.Append("  SellerName: ").Append(SellerName).Append("\n");
            sb.Append("  SellerTypeCode: ").Append(SellerTypeCode).Append("\n");
            sb.Append("  StandNo: ").Append(StandNo).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetNo: ").Append(StreetNo).Append("\n");
            sb.Append("  SuburbName: ").Append(SuburbName).Append("\n");
            sb.Append("  TitleDeedFeeAmt: ").Append(TitleDeedFeeAmt).Append("\n");
            sb.Append("  TitleDeedNo: ").Append(TitleDeedNo).Append("\n");
            sb.Append("  TownshipName: ").Append(TownshipName).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  TransferID: ").Append(TransferID).Append("\n");
            sb.Append("  FarmName: ").Append(FarmName).Append("\n");
            sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
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
            return this.Equals(input as XdsConsumerPropertyInformation);
        }

        /// <summary>
        /// Returns true if XdsConsumerPropertyInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumerPropertyInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumerPropertyInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttorneyFileNo == input.AttorneyFileNo ||
                    (this.AttorneyFileNo != null &&
                    this.AttorneyFileNo.Equals(input.AttorneyFileNo))
                ) && 
                (
                    this.AttorneyFirmNo == input.AttorneyFirmNo ||
                    (this.AttorneyFirmNo != null &&
                    this.AttorneyFirmNo.Equals(input.AttorneyFirmNo))
                ) && 
                (
                    this.AuthorityName == input.AuthorityName ||
                    (this.AuthorityName != null &&
                    this.AuthorityName.Equals(input.AuthorityName))
                ) && 
                (
                    this.BondAccountNo == input.BondAccountNo ||
                    (this.BondAccountNo != null &&
                    this.BondAccountNo.Equals(input.BondAccountNo))
                ) && 
                (
                    this.BondAmt == input.BondAmt ||
                    (this.BondAmt != null &&
                    this.BondAmt.Equals(input.BondAmt))
                ) && 
                (
                    this.BondHolderName == input.BondHolderName ||
                    (this.BondHolderName != null &&
                    this.BondHolderName.Equals(input.BondHolderName))
                ) && 
                (
                    this.BuyerIDNo == input.BuyerIDNo ||
                    (this.BuyerIDNo != null &&
                    this.BuyerIDNo.Equals(input.BuyerIDNo))
                ) && 
                (
                    this.BuyerMaritalStatusCode == input.BuyerMaritalStatusCode ||
                    (this.BuyerMaritalStatusCode != null &&
                    this.BuyerMaritalStatusCode.Equals(input.BuyerMaritalStatusCode))
                ) && 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) && 
                (
                    this.BuyerSharePerc == input.BuyerSharePerc ||
                    (this.BuyerSharePerc != null &&
                    this.BuyerSharePerc.Equals(input.BuyerSharePerc))
                ) && 
                (
                    this.BuyerTypeCode == input.BuyerTypeCode ||
                    (this.BuyerTypeCode != null &&
                    this.BuyerTypeCode.Equals(input.BuyerTypeCode))
                ) && 
                (
                    this.CityName == input.CityName ||
                    (this.CityName != null &&
                    this.CityName.Equals(input.CityName))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.ErfNo == input.ErfNo ||
                    (this.ErfNo != null &&
                    this.ErfNo.Equals(input.ErfNo))
                ) && 
                (
                    this.ErfSize == input.ErfSize ||
                    (this.ErfSize != null &&
                    this.ErfSize.Equals(input.ErfSize))
                ) && 
                (
                    this.OldTitleDeedNo == input.OldTitleDeedNo ||
                    (this.OldTitleDeedNo != null &&
                    this.OldTitleDeedNo.Equals(input.OldTitleDeedNo))
                ) && 
                (
                    this.PhysicalAddress == input.PhysicalAddress ||
                    (this.PhysicalAddress != null &&
                    this.PhysicalAddress.Equals(input.PhysicalAddress))
                ) && 
                (
                    this.PortionNo == input.PortionNo ||
                    (this.PortionNo != null &&
                    this.PortionNo.Equals(input.PortionNo))
                ) && 
                (
                    this.PropertyTypeCode == input.PropertyTypeCode ||
                    (this.PropertyTypeCode != null &&
                    this.PropertyTypeCode.Equals(input.PropertyTypeCode))
                ) && 
                (
                    this.PropertyTypeDesc == input.PropertyTypeDesc ||
                    (this.PropertyTypeDesc != null &&
                    this.PropertyTypeDesc.Equals(input.PropertyTypeDesc))
                ) && 
                (
                    this.PurchaseDate == input.PurchaseDate ||
                    (this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(input.PurchaseDate))
                ) && 
                (
                    this.PurchasePriceAmt == input.PurchasePriceAmt ||
                    (this.PurchasePriceAmt != null &&
                    this.PurchasePriceAmt.Equals(input.PurchasePriceAmt))
                ) && 
                (
                    this.RegistrarName == input.RegistrarName ||
                    (this.RegistrarName != null &&
                    this.RegistrarName.Equals(input.RegistrarName))
                ) && 
                (
                    this.SellerIDNo == input.SellerIDNo ||
                    (this.SellerIDNo != null &&
                    this.SellerIDNo.Equals(input.SellerIDNo))
                ) && 
                (
                    this.SellerMaritalStatusCode == input.SellerMaritalStatusCode ||
                    (this.SellerMaritalStatusCode != null &&
                    this.SellerMaritalStatusCode.Equals(input.SellerMaritalStatusCode))
                ) && 
                (
                    this.SellerName == input.SellerName ||
                    (this.SellerName != null &&
                    this.SellerName.Equals(input.SellerName))
                ) && 
                (
                    this.SellerTypeCode == input.SellerTypeCode ||
                    (this.SellerTypeCode != null &&
                    this.SellerTypeCode.Equals(input.SellerTypeCode))
                ) && 
                (
                    this.StandNo == input.StandNo ||
                    (this.StandNo != null &&
                    this.StandNo.Equals(input.StandNo))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.StreetNo == input.StreetNo ||
                    (this.StreetNo != null &&
                    this.StreetNo.Equals(input.StreetNo))
                ) && 
                (
                    this.SuburbName == input.SuburbName ||
                    (this.SuburbName != null &&
                    this.SuburbName.Equals(input.SuburbName))
                ) && 
                (
                    this.TitleDeedFeeAmt == input.TitleDeedFeeAmt ||
                    (this.TitleDeedFeeAmt != null &&
                    this.TitleDeedFeeAmt.Equals(input.TitleDeedFeeAmt))
                ) && 
                (
                    this.TitleDeedNo == input.TitleDeedNo ||
                    (this.TitleDeedNo != null &&
                    this.TitleDeedNo.Equals(input.TitleDeedNo))
                ) && 
                (
                    this.TownshipName == input.TownshipName ||
                    (this.TownshipName != null &&
                    this.TownshipName.Equals(input.TownshipName))
                ) && 
                (
                    this.TransferDate == input.TransferDate ||
                    (this.TransferDate != null &&
                    this.TransferDate.Equals(input.TransferDate))
                ) && 
                (
                    this.TransferID == input.TransferID ||
                    (this.TransferID != null &&
                    this.TransferID.Equals(input.TransferID))
                ) && 
                (
                    this.FarmName == input.FarmName ||
                    (this.FarmName != null &&
                    this.FarmName.Equals(input.FarmName))
                ) && 
                (
                    this.SchemeName == input.SchemeName ||
                    (this.SchemeName != null &&
                    this.SchemeName.Equals(input.SchemeName))
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
                if (this.AttorneyFileNo != null)
                    hashCode = hashCode * 59 + this.AttorneyFileNo.GetHashCode();
                if (this.AttorneyFirmNo != null)
                    hashCode = hashCode * 59 + this.AttorneyFirmNo.GetHashCode();
                if (this.AuthorityName != null)
                    hashCode = hashCode * 59 + this.AuthorityName.GetHashCode();
                if (this.BondAccountNo != null)
                    hashCode = hashCode * 59 + this.BondAccountNo.GetHashCode();
                if (this.BondAmt != null)
                    hashCode = hashCode * 59 + this.BondAmt.GetHashCode();
                if (this.BondHolderName != null)
                    hashCode = hashCode * 59 + this.BondHolderName.GetHashCode();
                if (this.BuyerIDNo != null)
                    hashCode = hashCode * 59 + this.BuyerIDNo.GetHashCode();
                if (this.BuyerMaritalStatusCode != null)
                    hashCode = hashCode * 59 + this.BuyerMaritalStatusCode.GetHashCode();
                if (this.BuyerName != null)
                    hashCode = hashCode * 59 + this.BuyerName.GetHashCode();
                if (this.BuyerSharePerc != null)
                    hashCode = hashCode * 59 + this.BuyerSharePerc.GetHashCode();
                if (this.BuyerTypeCode != null)
                    hashCode = hashCode * 59 + this.BuyerTypeCode.GetHashCode();
                if (this.CityName != null)
                    hashCode = hashCode * 59 + this.CityName.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.ErfNo != null)
                    hashCode = hashCode * 59 + this.ErfNo.GetHashCode();
                if (this.ErfSize != null)
                    hashCode = hashCode * 59 + this.ErfSize.GetHashCode();
                if (this.OldTitleDeedNo != null)
                    hashCode = hashCode * 59 + this.OldTitleDeedNo.GetHashCode();
                if (this.PhysicalAddress != null)
                    hashCode = hashCode * 59 + this.PhysicalAddress.GetHashCode();
                if (this.PortionNo != null)
                    hashCode = hashCode * 59 + this.PortionNo.GetHashCode();
                if (this.PropertyTypeCode != null)
                    hashCode = hashCode * 59 + this.PropertyTypeCode.GetHashCode();
                if (this.PropertyTypeDesc != null)
                    hashCode = hashCode * 59 + this.PropertyTypeDesc.GetHashCode();
                if (this.PurchaseDate != null)
                    hashCode = hashCode * 59 + this.PurchaseDate.GetHashCode();
                if (this.PurchasePriceAmt != null)
                    hashCode = hashCode * 59 + this.PurchasePriceAmt.GetHashCode();
                if (this.RegistrarName != null)
                    hashCode = hashCode * 59 + this.RegistrarName.GetHashCode();
                if (this.SellerIDNo != null)
                    hashCode = hashCode * 59 + this.SellerIDNo.GetHashCode();
                if (this.SellerMaritalStatusCode != null)
                    hashCode = hashCode * 59 + this.SellerMaritalStatusCode.GetHashCode();
                if (this.SellerName != null)
                    hashCode = hashCode * 59 + this.SellerName.GetHashCode();
                if (this.SellerTypeCode != null)
                    hashCode = hashCode * 59 + this.SellerTypeCode.GetHashCode();
                if (this.StandNo != null)
                    hashCode = hashCode * 59 + this.StandNo.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.StreetNo != null)
                    hashCode = hashCode * 59 + this.StreetNo.GetHashCode();
                if (this.SuburbName != null)
                    hashCode = hashCode * 59 + this.SuburbName.GetHashCode();
                if (this.TitleDeedFeeAmt != null)
                    hashCode = hashCode * 59 + this.TitleDeedFeeAmt.GetHashCode();
                if (this.TitleDeedNo != null)
                    hashCode = hashCode * 59 + this.TitleDeedNo.GetHashCode();
                if (this.TownshipName != null)
                    hashCode = hashCode * 59 + this.TownshipName.GetHashCode();
                if (this.TransferDate != null)
                    hashCode = hashCode * 59 + this.TransferDate.GetHashCode();
                if (this.TransferID != null)
                    hashCode = hashCode * 59 + this.TransferID.GetHashCode();
                if (this.FarmName != null)
                    hashCode = hashCode * 59 + this.FarmName.GetHashCode();
                if (this.SchemeName != null)
                    hashCode = hashCode * 59 + this.SchemeName.GetHashCode();
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
