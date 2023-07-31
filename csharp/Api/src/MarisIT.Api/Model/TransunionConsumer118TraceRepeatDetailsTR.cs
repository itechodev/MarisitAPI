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
    /// TransunionConsumer118TraceRepeatDetailsTR
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TraceRepeatDetailsTR :  IEquatable<TransunionConsumer118TraceRepeatDetailsTR>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TraceRepeatDetailsTR" /> class.
        /// </summary>
        /// <param name="iLinkSurnameO">iLinkSurnameO.</param>
        /// <param name="iLinkForenameO">iLinkForenameO.</param>
        /// <param name="iLinkCellphoneNumber">iLinkCellphoneNumber.</param>
        /// <param name="iLinkHomeTelephoneNumber">iLinkHomeTelephoneNumber.</param>
        /// <param name="iLinkWorkTelephoneNumber">iLinkWorkTelephoneNumber.</param>
        /// <param name="iLinkAddress">iLinkAddress.</param>
        /// <param name="iAddressLine1">iAddressLine1.</param>
        /// <param name="iAddressLine2">iAddressLine2.</param>
        /// <param name="iAddressSuburb">iAddressSuburb.</param>
        /// <param name="iAddressTown">iAddressTown.</param>
        /// <param name="iAddressCode">iAddressCode.</param>
        /// <param name="iLinkConsumerArrays">iLinkConsumerArrays.</param>
        /// <param name="iLinkSurname">iLinkSurname.</param>
        /// <param name="iLinkForename">iLinkForename.</param>
        /// <param name="iLinkCellCommon">iLinkCellCommon.</param>
        /// <param name="iLinkHomeTelephoneCommon">iLinkHomeTelephoneCommon.</param>
        /// <param name="iLinkWorkTelephoneCommon">iLinkWorkTelephoneCommon.</param>
        /// <param name="iLinkAddressCommon">iLinkAddressCommon.</param>
        public TransunionConsumer118TraceRepeatDetailsTR(string iLinkSurnameO = default(string), string iLinkForenameO = default(string), string iLinkCellphoneNumber = default(string), string iLinkHomeTelephoneNumber = default(string), string iLinkWorkTelephoneNumber = default(string), string iLinkAddress = default(string), string iAddressLine1 = default(string), string iAddressLine2 = default(string), string iAddressSuburb = default(string), string iAddressTown = default(string), string iAddressCode = default(string), List<TransunionConsumer118ILinkConsumerArray> iLinkConsumerArrays = default(List<TransunionConsumer118ILinkConsumerArray>), string iLinkSurname = default(string), string iLinkForename = default(string), string iLinkCellCommon = default(string), string iLinkHomeTelephoneCommon = default(string), string iLinkWorkTelephoneCommon = default(string), string iLinkAddressCommon = default(string))
        {
            this.ILinkSurnameO = iLinkSurnameO;
            this.ILinkForenameO = iLinkForenameO;
            this.ILinkCellphoneNumber = iLinkCellphoneNumber;
            this.ILinkHomeTelephoneNumber = iLinkHomeTelephoneNumber;
            this.ILinkWorkTelephoneNumber = iLinkWorkTelephoneNumber;
            this.ILinkAddress = iLinkAddress;
            this.IAddressLine1 = iAddressLine1;
            this.IAddressLine2 = iAddressLine2;
            this.IAddressSuburb = iAddressSuburb;
            this.IAddressTown = iAddressTown;
            this.IAddressCode = iAddressCode;
            this.ILinkConsumerArrays = iLinkConsumerArrays;
            this.ILinkSurname = iLinkSurname;
            this.ILinkForename = iLinkForename;
            this.ILinkCellCommon = iLinkCellCommon;
            this.ILinkHomeTelephoneCommon = iLinkHomeTelephoneCommon;
            this.ILinkWorkTelephoneCommon = iLinkWorkTelephoneCommon;
            this.ILinkAddressCommon = iLinkAddressCommon;
            this.ILinkSurnameO = iLinkSurnameO;
            this.ILinkForenameO = iLinkForenameO;
            this.ILinkCellphoneNumber = iLinkCellphoneNumber;
            this.ILinkHomeTelephoneNumber = iLinkHomeTelephoneNumber;
            this.ILinkWorkTelephoneNumber = iLinkWorkTelephoneNumber;
            this.ILinkAddress = iLinkAddress;
            this.IAddressLine1 = iAddressLine1;
            this.IAddressLine2 = iAddressLine2;
            this.IAddressSuburb = iAddressSuburb;
            this.IAddressTown = iAddressTown;
            this.IAddressCode = iAddressCode;
            this.ILinkConsumerArrays = iLinkConsumerArrays;
            this.ILinkSurname = iLinkSurname;
            this.ILinkForename = iLinkForename;
            this.ILinkCellCommon = iLinkCellCommon;
            this.ILinkHomeTelephoneCommon = iLinkHomeTelephoneCommon;
            this.ILinkWorkTelephoneCommon = iLinkWorkTelephoneCommon;
            this.ILinkAddressCommon = iLinkAddressCommon;
        }

        /// <summary>
        /// Gets or Sets ILinkSurnameO
        /// </summary>
        [DataMember(Name="iLinkSurnameO", EmitDefaultValue=true)]
        public string ILinkSurnameO { get; set; }

        /// <summary>
        /// Gets or Sets ILinkForenameO
        /// </summary>
        [DataMember(Name="iLinkForenameO", EmitDefaultValue=true)]
        public string ILinkForenameO { get; set; }

        /// <summary>
        /// Gets or Sets ILinkCellphoneNumber
        /// </summary>
        [DataMember(Name="iLinkCellphoneNumber", EmitDefaultValue=true)]
        public string ILinkCellphoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ILinkHomeTelephoneNumber
        /// </summary>
        [DataMember(Name="iLinkHomeTelephoneNumber", EmitDefaultValue=true)]
        public string ILinkHomeTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ILinkWorkTelephoneNumber
        /// </summary>
        [DataMember(Name="iLinkWorkTelephoneNumber", EmitDefaultValue=true)]
        public string ILinkWorkTelephoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets ILinkAddress
        /// </summary>
        [DataMember(Name="iLinkAddress", EmitDefaultValue=true)]
        public string ILinkAddress { get; set; }

        /// <summary>
        /// Gets or Sets IAddressLine1
        /// </summary>
        [DataMember(Name="iAddressLine1", EmitDefaultValue=true)]
        public string IAddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets IAddressLine2
        /// </summary>
        [DataMember(Name="iAddressLine2", EmitDefaultValue=true)]
        public string IAddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets IAddressSuburb
        /// </summary>
        [DataMember(Name="iAddressSuburb", EmitDefaultValue=true)]
        public string IAddressSuburb { get; set; }

        /// <summary>
        /// Gets or Sets IAddressTown
        /// </summary>
        [DataMember(Name="iAddressTown", EmitDefaultValue=true)]
        public string IAddressTown { get; set; }

        /// <summary>
        /// Gets or Sets IAddressCode
        /// </summary>
        [DataMember(Name="iAddressCode", EmitDefaultValue=true)]
        public string IAddressCode { get; set; }

        /// <summary>
        /// Gets or Sets ILinkConsumerArrays
        /// </summary>
        [DataMember(Name="iLinkConsumerArrays", EmitDefaultValue=true)]
        public List<TransunionConsumer118ILinkConsumerArray> ILinkConsumerArrays { get; set; }

        /// <summary>
        /// Gets or Sets ILinkSurname
        /// </summary>
        [DataMember(Name="iLinkSurname", EmitDefaultValue=true)]
        public string ILinkSurname { get; set; }

        /// <summary>
        /// Gets or Sets ILinkForename
        /// </summary>
        [DataMember(Name="iLinkForename", EmitDefaultValue=true)]
        public string ILinkForename { get; set; }

        /// <summary>
        /// Gets or Sets ILinkCellCommon
        /// </summary>
        [DataMember(Name="iLinkCellCommon", EmitDefaultValue=true)]
        public string ILinkCellCommon { get; set; }

        /// <summary>
        /// Gets or Sets ILinkHomeTelephoneCommon
        /// </summary>
        [DataMember(Name="iLinkHomeTelephoneCommon", EmitDefaultValue=true)]
        public string ILinkHomeTelephoneCommon { get; set; }

        /// <summary>
        /// Gets or Sets ILinkWorkTelephoneCommon
        /// </summary>
        [DataMember(Name="iLinkWorkTelephoneCommon", EmitDefaultValue=true)]
        public string ILinkWorkTelephoneCommon { get; set; }

        /// <summary>
        /// Gets or Sets ILinkAddressCommon
        /// </summary>
        [DataMember(Name="iLinkAddressCommon", EmitDefaultValue=true)]
        public string ILinkAddressCommon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TraceRepeatDetailsTR {\n");
            sb.Append("  ILinkSurnameO: ").Append(ILinkSurnameO).Append("\n");
            sb.Append("  ILinkForenameO: ").Append(ILinkForenameO).Append("\n");
            sb.Append("  ILinkCellphoneNumber: ").Append(ILinkCellphoneNumber).Append("\n");
            sb.Append("  ILinkHomeTelephoneNumber: ").Append(ILinkHomeTelephoneNumber).Append("\n");
            sb.Append("  ILinkWorkTelephoneNumber: ").Append(ILinkWorkTelephoneNumber).Append("\n");
            sb.Append("  ILinkAddress: ").Append(ILinkAddress).Append("\n");
            sb.Append("  IAddressLine1: ").Append(IAddressLine1).Append("\n");
            sb.Append("  IAddressLine2: ").Append(IAddressLine2).Append("\n");
            sb.Append("  IAddressSuburb: ").Append(IAddressSuburb).Append("\n");
            sb.Append("  IAddressTown: ").Append(IAddressTown).Append("\n");
            sb.Append("  IAddressCode: ").Append(IAddressCode).Append("\n");
            sb.Append("  ILinkConsumerArrays: ").Append(ILinkConsumerArrays).Append("\n");
            sb.Append("  ILinkSurname: ").Append(ILinkSurname).Append("\n");
            sb.Append("  ILinkForename: ").Append(ILinkForename).Append("\n");
            sb.Append("  ILinkCellCommon: ").Append(ILinkCellCommon).Append("\n");
            sb.Append("  ILinkHomeTelephoneCommon: ").Append(ILinkHomeTelephoneCommon).Append("\n");
            sb.Append("  ILinkWorkTelephoneCommon: ").Append(ILinkWorkTelephoneCommon).Append("\n");
            sb.Append("  ILinkAddressCommon: ").Append(ILinkAddressCommon).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TraceRepeatDetailsTR);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TraceRepeatDetailsTR instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TraceRepeatDetailsTR to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TraceRepeatDetailsTR input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ILinkSurnameO == input.ILinkSurnameO ||
                    (this.ILinkSurnameO != null &&
                    this.ILinkSurnameO.Equals(input.ILinkSurnameO))
                ) && 
                (
                    this.ILinkForenameO == input.ILinkForenameO ||
                    (this.ILinkForenameO != null &&
                    this.ILinkForenameO.Equals(input.ILinkForenameO))
                ) && 
                (
                    this.ILinkCellphoneNumber == input.ILinkCellphoneNumber ||
                    (this.ILinkCellphoneNumber != null &&
                    this.ILinkCellphoneNumber.Equals(input.ILinkCellphoneNumber))
                ) && 
                (
                    this.ILinkHomeTelephoneNumber == input.ILinkHomeTelephoneNumber ||
                    (this.ILinkHomeTelephoneNumber != null &&
                    this.ILinkHomeTelephoneNumber.Equals(input.ILinkHomeTelephoneNumber))
                ) && 
                (
                    this.ILinkWorkTelephoneNumber == input.ILinkWorkTelephoneNumber ||
                    (this.ILinkWorkTelephoneNumber != null &&
                    this.ILinkWorkTelephoneNumber.Equals(input.ILinkWorkTelephoneNumber))
                ) && 
                (
                    this.ILinkAddress == input.ILinkAddress ||
                    (this.ILinkAddress != null &&
                    this.ILinkAddress.Equals(input.ILinkAddress))
                ) && 
                (
                    this.IAddressLine1 == input.IAddressLine1 ||
                    (this.IAddressLine1 != null &&
                    this.IAddressLine1.Equals(input.IAddressLine1))
                ) && 
                (
                    this.IAddressLine2 == input.IAddressLine2 ||
                    (this.IAddressLine2 != null &&
                    this.IAddressLine2.Equals(input.IAddressLine2))
                ) && 
                (
                    this.IAddressSuburb == input.IAddressSuburb ||
                    (this.IAddressSuburb != null &&
                    this.IAddressSuburb.Equals(input.IAddressSuburb))
                ) && 
                (
                    this.IAddressTown == input.IAddressTown ||
                    (this.IAddressTown != null &&
                    this.IAddressTown.Equals(input.IAddressTown))
                ) && 
                (
                    this.IAddressCode == input.IAddressCode ||
                    (this.IAddressCode != null &&
                    this.IAddressCode.Equals(input.IAddressCode))
                ) && 
                (
                    this.ILinkConsumerArrays == input.ILinkConsumerArrays ||
                    this.ILinkConsumerArrays != null &&
                    input.ILinkConsumerArrays != null &&
                    this.ILinkConsumerArrays.SequenceEqual(input.ILinkConsumerArrays)
                ) && 
                (
                    this.ILinkSurname == input.ILinkSurname ||
                    (this.ILinkSurname != null &&
                    this.ILinkSurname.Equals(input.ILinkSurname))
                ) && 
                (
                    this.ILinkForename == input.ILinkForename ||
                    (this.ILinkForename != null &&
                    this.ILinkForename.Equals(input.ILinkForename))
                ) && 
                (
                    this.ILinkCellCommon == input.ILinkCellCommon ||
                    (this.ILinkCellCommon != null &&
                    this.ILinkCellCommon.Equals(input.ILinkCellCommon))
                ) && 
                (
                    this.ILinkHomeTelephoneCommon == input.ILinkHomeTelephoneCommon ||
                    (this.ILinkHomeTelephoneCommon != null &&
                    this.ILinkHomeTelephoneCommon.Equals(input.ILinkHomeTelephoneCommon))
                ) && 
                (
                    this.ILinkWorkTelephoneCommon == input.ILinkWorkTelephoneCommon ||
                    (this.ILinkWorkTelephoneCommon != null &&
                    this.ILinkWorkTelephoneCommon.Equals(input.ILinkWorkTelephoneCommon))
                ) && 
                (
                    this.ILinkAddressCommon == input.ILinkAddressCommon ||
                    (this.ILinkAddressCommon != null &&
                    this.ILinkAddressCommon.Equals(input.ILinkAddressCommon))
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
                if (this.ILinkSurnameO != null)
                    hashCode = hashCode * 59 + this.ILinkSurnameO.GetHashCode();
                if (this.ILinkForenameO != null)
                    hashCode = hashCode * 59 + this.ILinkForenameO.GetHashCode();
                if (this.ILinkCellphoneNumber != null)
                    hashCode = hashCode * 59 + this.ILinkCellphoneNumber.GetHashCode();
                if (this.ILinkHomeTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.ILinkHomeTelephoneNumber.GetHashCode();
                if (this.ILinkWorkTelephoneNumber != null)
                    hashCode = hashCode * 59 + this.ILinkWorkTelephoneNumber.GetHashCode();
                if (this.ILinkAddress != null)
                    hashCode = hashCode * 59 + this.ILinkAddress.GetHashCode();
                if (this.IAddressLine1 != null)
                    hashCode = hashCode * 59 + this.IAddressLine1.GetHashCode();
                if (this.IAddressLine2 != null)
                    hashCode = hashCode * 59 + this.IAddressLine2.GetHashCode();
                if (this.IAddressSuburb != null)
                    hashCode = hashCode * 59 + this.IAddressSuburb.GetHashCode();
                if (this.IAddressTown != null)
                    hashCode = hashCode * 59 + this.IAddressTown.GetHashCode();
                if (this.IAddressCode != null)
                    hashCode = hashCode * 59 + this.IAddressCode.GetHashCode();
                if (this.ILinkConsumerArrays != null)
                    hashCode = hashCode * 59 + this.ILinkConsumerArrays.GetHashCode();
                if (this.ILinkSurname != null)
                    hashCode = hashCode * 59 + this.ILinkSurname.GetHashCode();
                if (this.ILinkForename != null)
                    hashCode = hashCode * 59 + this.ILinkForename.GetHashCode();
                if (this.ILinkCellCommon != null)
                    hashCode = hashCode * 59 + this.ILinkCellCommon.GetHashCode();
                if (this.ILinkHomeTelephoneCommon != null)
                    hashCode = hashCode * 59 + this.ILinkHomeTelephoneCommon.GetHashCode();
                if (this.ILinkWorkTelephoneCommon != null)
                    hashCode = hashCode * 59 + this.ILinkWorkTelephoneCommon.GetHashCode();
                if (this.ILinkAddressCommon != null)
                    hashCode = hashCode * 59 + this.ILinkAddressCommon.GetHashCode();
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