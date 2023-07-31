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
    /// WindeedSpiderErf
    /// </summary>
    [DataContract]
    public partial class WindeedSpiderErf :  IEquatable<WindeedSpiderErf>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=false)]
        public WindeedSpiderRegistrar? DeedsOffice { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedSpiderErf" /> class.
        /// </summary>
        /// <param name="korbitecPropId">korbitecPropId.</param>
        /// <param name="localAuthority">localAuthority.</param>
        /// <param name="extent">extent.</param>
        /// <param name="extentUnit">extentUnit.</param>
        /// <param name="extentText">extentText.</param>
        /// <param name="previousDescription">previousDescription.</param>
        /// <param name="province">province.</param>
        /// <param name="diagramDeedNumber">diagramDeedNumber.</param>
        /// <param name="registrationDivision">registrationDivision.</param>
        /// <param name="lpiCode">lpiCode.</param>
        /// <param name="sellingDate">sellingDate.</param>
        /// <param name="sellingPrice">sellingPrice.</param>
        /// <param name="sellingPriceDescription">sellingPriceDescription.</param>
        /// <param name="relatedDocuments">relatedDocuments.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="propertyDescription">propertyDescription.</param>
        /// <param name="erfNumber">erfNumber.</param>
        /// <param name="portionNumber">portionNumber.</param>
        /// <param name="township">township.</param>
        /// <param name="streetAddress">streetAddress.</param>
        public WindeedSpiderErf(int korbitecPropId = default(int), string localAuthority = default(string), double extent = default(double), string extentUnit = default(string), string extentText = default(string), string previousDescription = default(string), string province = default(string), string diagramDeedNumber = default(string), string registrationDivision = default(string), string lpiCode = default(string), DateTime? sellingDate = default(DateTime?), double? sellingPrice = default(double?), string sellingPriceDescription = default(string), WindeedSpiderDSCollectionOfDocument relatedDocuments = default(WindeedSpiderDSCollectionOfDocument), WindeedSpiderRegistrar? deedsOffice = default(WindeedSpiderRegistrar?), string propertyDescription = default(string), int? erfNumber = default(int?), string portionNumber = default(string), string township = default(string), string streetAddress = default(string))
        {
            this.LocalAuthority = localAuthority;
            this.ExtentUnit = extentUnit;
            this.ExtentText = extentText;
            this.PreviousDescription = previousDescription;
            this.Province = province;
            this.DiagramDeedNumber = diagramDeedNumber;
            this.RegistrationDivision = registrationDivision;
            this.LpiCode = lpiCode;
            this.SellingDate = sellingDate;
            this.SellingPrice = sellingPrice;
            this.SellingPriceDescription = sellingPriceDescription;
            this.PropertyDescription = propertyDescription;
            this.ErfNumber = erfNumber;
            this.PortionNumber = portionNumber;
            this.Township = township;
            this.StreetAddress = streetAddress;
            this.KorbitecPropId = korbitecPropId;
            this.LocalAuthority = localAuthority;
            this.Extent = extent;
            this.ExtentUnit = extentUnit;
            this.ExtentText = extentText;
            this.PreviousDescription = previousDescription;
            this.Province = province;
            this.DiagramDeedNumber = diagramDeedNumber;
            this.RegistrationDivision = registrationDivision;
            this.LpiCode = lpiCode;
            this.SellingDate = sellingDate;
            this.SellingPrice = sellingPrice;
            this.SellingPriceDescription = sellingPriceDescription;
            this.RelatedDocuments = relatedDocuments;
            this.DeedsOffice = deedsOffice;
            this.PropertyDescription = propertyDescription;
            this.ErfNumber = erfNumber;
            this.PortionNumber = portionNumber;
            this.Township = township;
            this.StreetAddress = streetAddress;
        }

        /// <summary>
        /// Gets or Sets KorbitecPropId
        /// </summary>
        [DataMember(Name="korbitecPropId", EmitDefaultValue=false)]
        public int KorbitecPropId { get; set; }

        /// <summary>
        /// Gets or Sets LocalAuthority
        /// </summary>
        [DataMember(Name="localAuthority", EmitDefaultValue=true)]
        public string LocalAuthority { get; set; }

        /// <summary>
        /// Gets or Sets Extent
        /// </summary>
        [DataMember(Name="extent", EmitDefaultValue=false)]
        public double Extent { get; set; }

        /// <summary>
        /// Gets or Sets ExtentUnit
        /// </summary>
        [DataMember(Name="extentUnit", EmitDefaultValue=true)]
        public string ExtentUnit { get; set; }

        /// <summary>
        /// Gets or Sets ExtentText
        /// </summary>
        [DataMember(Name="extentText", EmitDefaultValue=true)]
        public string ExtentText { get; set; }

        /// <summary>
        /// Gets or Sets PreviousDescription
        /// </summary>
        [DataMember(Name="previousDescription", EmitDefaultValue=true)]
        public string PreviousDescription { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets DiagramDeedNumber
        /// </summary>
        [DataMember(Name="diagramDeedNumber", EmitDefaultValue=true)]
        public string DiagramDeedNumber { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDivision
        /// </summary>
        [DataMember(Name="registrationDivision", EmitDefaultValue=true)]
        public string RegistrationDivision { get; set; }

        /// <summary>
        /// Gets or Sets LpiCode
        /// </summary>
        [DataMember(Name="lpiCode", EmitDefaultValue=true)]
        public string LpiCode { get; set; }

        /// <summary>
        /// Gets or Sets SellingDate
        /// </summary>
        [DataMember(Name="sellingDate", EmitDefaultValue=true)]
        public DateTime? SellingDate { get; set; }

        /// <summary>
        /// Gets or Sets SellingPrice
        /// </summary>
        [DataMember(Name="sellingPrice", EmitDefaultValue=true)]
        public double? SellingPrice { get; set; }

        /// <summary>
        /// Gets or Sets SellingPriceDescription
        /// </summary>
        [DataMember(Name="sellingPriceDescription", EmitDefaultValue=true)]
        public string SellingPriceDescription { get; set; }

        /// <summary>
        /// Gets or Sets RelatedDocuments
        /// </summary>
        [DataMember(Name="relatedDocuments", EmitDefaultValue=false)]
        public WindeedSpiderDSCollectionOfDocument RelatedDocuments { get; set; }


        /// <summary>
        /// Gets or Sets PropertyDescription
        /// </summary>
        [DataMember(Name="propertyDescription", EmitDefaultValue=true)]
        public string PropertyDescription { get; set; }

        /// <summary>
        /// Gets or Sets ErfNumber
        /// </summary>
        [DataMember(Name="erfNumber", EmitDefaultValue=true)]
        public int? ErfNumber { get; set; }

        /// <summary>
        /// Gets or Sets PortionNumber
        /// </summary>
        [DataMember(Name="portionNumber", EmitDefaultValue=true)]
        public string PortionNumber { get; set; }

        /// <summary>
        /// Gets or Sets Township
        /// </summary>
        [DataMember(Name="township", EmitDefaultValue=true)]
        public string Township { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name="streetAddress", EmitDefaultValue=true)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedSpiderErf {\n");
            sb.Append("  KorbitecPropId: ").Append(KorbitecPropId).Append("\n");
            sb.Append("  LocalAuthority: ").Append(LocalAuthority).Append("\n");
            sb.Append("  Extent: ").Append(Extent).Append("\n");
            sb.Append("  ExtentUnit: ").Append(ExtentUnit).Append("\n");
            sb.Append("  ExtentText: ").Append(ExtentText).Append("\n");
            sb.Append("  PreviousDescription: ").Append(PreviousDescription).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  DiagramDeedNumber: ").Append(DiagramDeedNumber).Append("\n");
            sb.Append("  RegistrationDivision: ").Append(RegistrationDivision).Append("\n");
            sb.Append("  LpiCode: ").Append(LpiCode).Append("\n");
            sb.Append("  SellingDate: ").Append(SellingDate).Append("\n");
            sb.Append("  SellingPrice: ").Append(SellingPrice).Append("\n");
            sb.Append("  SellingPriceDescription: ").Append(SellingPriceDescription).Append("\n");
            sb.Append("  RelatedDocuments: ").Append(RelatedDocuments).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
            sb.Append("  ErfNumber: ").Append(ErfNumber).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
            sb.Append("  Township: ").Append(Township).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
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
            return this.Equals(input as WindeedSpiderErf);
        }

        /// <summary>
        /// Returns true if WindeedSpiderErf instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedSpiderErf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedSpiderErf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KorbitecPropId == input.KorbitecPropId ||
                    (this.KorbitecPropId != null &&
                    this.KorbitecPropId.Equals(input.KorbitecPropId))
                ) && 
                (
                    this.LocalAuthority == input.LocalAuthority ||
                    (this.LocalAuthority != null &&
                    this.LocalAuthority.Equals(input.LocalAuthority))
                ) && 
                (
                    this.Extent == input.Extent ||
                    (this.Extent != null &&
                    this.Extent.Equals(input.Extent))
                ) && 
                (
                    this.ExtentUnit == input.ExtentUnit ||
                    (this.ExtentUnit != null &&
                    this.ExtentUnit.Equals(input.ExtentUnit))
                ) && 
                (
                    this.ExtentText == input.ExtentText ||
                    (this.ExtentText != null &&
                    this.ExtentText.Equals(input.ExtentText))
                ) && 
                (
                    this.PreviousDescription == input.PreviousDescription ||
                    (this.PreviousDescription != null &&
                    this.PreviousDescription.Equals(input.PreviousDescription))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.DiagramDeedNumber == input.DiagramDeedNumber ||
                    (this.DiagramDeedNumber != null &&
                    this.DiagramDeedNumber.Equals(input.DiagramDeedNumber))
                ) && 
                (
                    this.RegistrationDivision == input.RegistrationDivision ||
                    (this.RegistrationDivision != null &&
                    this.RegistrationDivision.Equals(input.RegistrationDivision))
                ) && 
                (
                    this.LpiCode == input.LpiCode ||
                    (this.LpiCode != null &&
                    this.LpiCode.Equals(input.LpiCode))
                ) && 
                (
                    this.SellingDate == input.SellingDate ||
                    (this.SellingDate != null &&
                    this.SellingDate.Equals(input.SellingDate))
                ) && 
                (
                    this.SellingPrice == input.SellingPrice ||
                    (this.SellingPrice != null &&
                    this.SellingPrice.Equals(input.SellingPrice))
                ) && 
                (
                    this.SellingPriceDescription == input.SellingPriceDescription ||
                    (this.SellingPriceDescription != null &&
                    this.SellingPriceDescription.Equals(input.SellingPriceDescription))
                ) && 
                (
                    this.RelatedDocuments == input.RelatedDocuments ||
                    (this.RelatedDocuments != null &&
                    this.RelatedDocuments.Equals(input.RelatedDocuments))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.PropertyDescription == input.PropertyDescription ||
                    (this.PropertyDescription != null &&
                    this.PropertyDescription.Equals(input.PropertyDescription))
                ) && 
                (
                    this.ErfNumber == input.ErfNumber ||
                    (this.ErfNumber != null &&
                    this.ErfNumber.Equals(input.ErfNumber))
                ) && 
                (
                    this.PortionNumber == input.PortionNumber ||
                    (this.PortionNumber != null &&
                    this.PortionNumber.Equals(input.PortionNumber))
                ) && 
                (
                    this.Township == input.Township ||
                    (this.Township != null &&
                    this.Township.Equals(input.Township))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
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
                if (this.KorbitecPropId != null)
                    hashCode = hashCode * 59 + this.KorbitecPropId.GetHashCode();
                if (this.LocalAuthority != null)
                    hashCode = hashCode * 59 + this.LocalAuthority.GetHashCode();
                if (this.Extent != null)
                    hashCode = hashCode * 59 + this.Extent.GetHashCode();
                if (this.ExtentUnit != null)
                    hashCode = hashCode * 59 + this.ExtentUnit.GetHashCode();
                if (this.ExtentText != null)
                    hashCode = hashCode * 59 + this.ExtentText.GetHashCode();
                if (this.PreviousDescription != null)
                    hashCode = hashCode * 59 + this.PreviousDescription.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.DiagramDeedNumber != null)
                    hashCode = hashCode * 59 + this.DiagramDeedNumber.GetHashCode();
                if (this.RegistrationDivision != null)
                    hashCode = hashCode * 59 + this.RegistrationDivision.GetHashCode();
                if (this.LpiCode != null)
                    hashCode = hashCode * 59 + this.LpiCode.GetHashCode();
                if (this.SellingDate != null)
                    hashCode = hashCode * 59 + this.SellingDate.GetHashCode();
                if (this.SellingPrice != null)
                    hashCode = hashCode * 59 + this.SellingPrice.GetHashCode();
                if (this.SellingPriceDescription != null)
                    hashCode = hashCode * 59 + this.SellingPriceDescription.GetHashCode();
                if (this.RelatedDocuments != null)
                    hashCode = hashCode * 59 + this.RelatedDocuments.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.PropertyDescription != null)
                    hashCode = hashCode * 59 + this.PropertyDescription.GetHashCode();
                if (this.ErfNumber != null)
                    hashCode = hashCode * 59 + this.ErfNumber.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
                if (this.Township != null)
                    hashCode = hashCode * 59 + this.Township.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
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
