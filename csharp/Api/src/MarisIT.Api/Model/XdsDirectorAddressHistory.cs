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
    /// XdsDirectorAddressHistory
    /// </summary>
    [DataContract]
    public partial class XdsDirectorAddressHistory :  IEquatable<XdsDirectorAddressHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsDirectorAddressHistory" /> class.
        /// </summary>
        /// <param name="displayText">displayText.</param>
        /// <param name="directorID">directorID.</param>
        /// <param name="addressTypeInd">addressTypeInd.</param>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="address3">address3.</param>
        /// <param name="address4">address4.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="createdOnDate">createdOnDate.</param>
        public XdsDirectorAddressHistory(string displayText = default(string), string directorID = default(string), string addressTypeInd = default(string), string address1 = default(string), string address2 = default(string), string address3 = default(string), string address4 = default(string), string postalCode = default(string), string createdOnDate = default(string))
        {
            this.DisplayText = displayText;
            this.DirectorID = directorID;
            this.AddressTypeInd = addressTypeInd;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.Address4 = address4;
            this.PostalCode = postalCode;
            this.CreatedOnDate = createdOnDate;
            this.DisplayText = displayText;
            this.DirectorID = directorID;
            this.AddressTypeInd = addressTypeInd;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Address3 = address3;
            this.Address4 = address4;
            this.PostalCode = postalCode;
            this.CreatedOnDate = createdOnDate;
        }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets DirectorID
        /// </summary>
        [DataMember(Name="directorID", EmitDefaultValue=true)]
        public string DirectorID { get; set; }

        /// <summary>
        /// Gets or Sets AddressTypeInd
        /// </summary>
        [DataMember(Name="addressTypeInd", EmitDefaultValue=true)]
        public string AddressTypeInd { get; set; }

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
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOnDate
        /// </summary>
        [DataMember(Name="createdOnDate", EmitDefaultValue=true)]
        public string CreatedOnDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsDirectorAddressHistory {\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  DirectorID: ").Append(DirectorID).Append("\n");
            sb.Append("  AddressTypeInd: ").Append(AddressTypeInd).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  Address4: ").Append(Address4).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CreatedOnDate: ").Append(CreatedOnDate).Append("\n");
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
            return this.Equals(input as XdsDirectorAddressHistory);
        }

        /// <summary>
        /// Returns true if XdsDirectorAddressHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsDirectorAddressHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsDirectorAddressHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.DirectorID == input.DirectorID ||
                    (this.DirectorID != null &&
                    this.DirectorID.Equals(input.DirectorID))
                ) && 
                (
                    this.AddressTypeInd == input.AddressTypeInd ||
                    (this.AddressTypeInd != null &&
                    this.AddressTypeInd.Equals(input.AddressTypeInd))
                ) && 
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
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CreatedOnDate == input.CreatedOnDate ||
                    (this.CreatedOnDate != null &&
                    this.CreatedOnDate.Equals(input.CreatedOnDate))
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
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.DirectorID != null)
                    hashCode = hashCode * 59 + this.DirectorID.GetHashCode();
                if (this.AddressTypeInd != null)
                    hashCode = hashCode * 59 + this.AddressTypeInd.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.Address3 != null)
                    hashCode = hashCode * 59 + this.Address3.GetHashCode();
                if (this.Address4 != null)
                    hashCode = hashCode * 59 + this.Address4.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CreatedOnDate != null)
                    hashCode = hashCode * 59 + this.CreatedOnDate.GetHashCode();
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
