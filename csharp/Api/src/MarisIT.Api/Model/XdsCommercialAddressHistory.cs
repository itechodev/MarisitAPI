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
    /// XdsCommercialAddressHistory
    /// </summary>
    [DataContract]
    public partial class XdsCommercialAddressHistory :  IEquatable<XdsCommercialAddressHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsCommercialAddressHistory" /> class.
        /// </summary>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="address3">address3.</param>
        /// <param name="address4">address4.</param>
        /// <param name="addressType">addressType.</param>
        /// <param name="commercialName">commercialName.</param>
        /// <param name="contactLocationID">contactLocationID.</param>
        /// <param name="createdOnDate">createdOnDate.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="occupiedDate">occupiedDate.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="registrationNo">registrationNo.</param>
        /// <param name="source">source.</param>
        public XdsCommercialAddressHistory(string address1 = default(string), string address2 = default(string), string address3 = default(string), string address4 = default(string), string addressType = default(string), string commercialName = default(string), string contactLocationID = default(string), string createdOnDate = default(string), string displayText = default(string), string occupiedDate = default(string), string postalCode = default(string), string registrationNo = default(string), string source = default(string))
        {
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.Address4 = address4;
            this.AddressType = addressType;
            this.CommercialName = commercialName;
            this.ContactLocationID = contactLocationID;
            this.CreatedOnDate = createdOnDate;
            this.DisplayText = displayText;
            this.OccupiedDate = occupiedDate;
            this.PostalCode = postalCode;
            this.RegistrationNo = registrationNo;
            this.Source = source;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.Address4 = address4;
            this.AddressType = addressType;
            this.CommercialName = commercialName;
            this.ContactLocationID = contactLocationID;
            this.CreatedOnDate = createdOnDate;
            this.DisplayText = displayText;
            this.OccupiedDate = occupiedDate;
            this.PostalCode = postalCode;
            this.RegistrationNo = registrationNo;
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=true)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=true)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets Address3
        /// </summary>
        [DataMember(Name="address3", EmitDefaultValue=true)]
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or Sets Address4
        /// </summary>
        [DataMember(Name="address4", EmitDefaultValue=true)]
        public string Address4 { get; set; }

        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="addressType", EmitDefaultValue=true)]
        public string AddressType { get; set; }

        /// <summary>
        /// Gets or Sets CommercialName
        /// </summary>
        [DataMember(Name="commercialName", EmitDefaultValue=true)]
        public string CommercialName { get; set; }

        /// <summary>
        /// Gets or Sets ContactLocationID
        /// </summary>
        [DataMember(Name="contactLocationID", EmitDefaultValue=true)]
        public string ContactLocationID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOnDate
        /// </summary>
        [DataMember(Name="createdOnDate", EmitDefaultValue=true)]
        public string CreatedOnDate { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets OccupiedDate
        /// </summary>
        [DataMember(Name="occupiedDate", EmitDefaultValue=true)]
        public string OccupiedDate { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNo
        /// </summary>
        [DataMember(Name="registrationNo", EmitDefaultValue=true)]
        public string RegistrationNo { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsCommercialAddressHistory {\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  Address4: ").Append(Address4).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
            sb.Append("  ContactLocationID: ").Append(ContactLocationID).Append("\n");
            sb.Append("  CreatedOnDate: ").Append(CreatedOnDate).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  OccupiedDate: ").Append(OccupiedDate).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  RegistrationNo: ").Append(RegistrationNo).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as XdsCommercialAddressHistory);
        }

        /// <summary>
        /// Returns true if XdsCommercialAddressHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsCommercialAddressHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsCommercialAddressHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.Address3 == input.Address3 ||
                    (this.Address3 != null &&
                    this.Address3.Equals(input.Address3))
                ) && 
                (
                    this.Address4 == input.Address4 ||
                    (this.Address4 != null &&
                    this.Address4.Equals(input.Address4))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.CommercialName == input.CommercialName ||
                    (this.CommercialName != null &&
                    this.CommercialName.Equals(input.CommercialName))
                ) && 
                (
                    this.ContactLocationID == input.ContactLocationID ||
                    (this.ContactLocationID != null &&
                    this.ContactLocationID.Equals(input.ContactLocationID))
                ) && 
                (
                    this.CreatedOnDate == input.CreatedOnDate ||
                    (this.CreatedOnDate != null &&
                    this.CreatedOnDate.Equals(input.CreatedOnDate))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.OccupiedDate == input.OccupiedDate ||
                    (this.OccupiedDate != null &&
                    this.OccupiedDate.Equals(input.OccupiedDate))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.RegistrationNo == input.RegistrationNo ||
                    (this.RegistrationNo != null &&
                    this.RegistrationNo.Equals(input.RegistrationNo))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.Address3 != null)
                    hashCode = hashCode * 59 + this.Address3.GetHashCode();
                if (this.Address4 != null)
                    hashCode = hashCode * 59 + this.Address4.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.CommercialName != null)
                    hashCode = hashCode * 59 + this.CommercialName.GetHashCode();
                if (this.ContactLocationID != null)
                    hashCode = hashCode * 59 + this.ContactLocationID.GetHashCode();
                if (this.CreatedOnDate != null)
                    hashCode = hashCode * 59 + this.CreatedOnDate.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.OccupiedDate != null)
                    hashCode = hashCode * 59 + this.OccupiedDate.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.RegistrationNo != null)
                    hashCode = hashCode * 59 + this.RegistrationNo.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
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