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
    /// TransunionConsumer118TUVehicleEnquiryHistoryVE
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118TUVehicleEnquiryHistoryVE :  IEquatable<TransunionConsumer118TUVehicleEnquiryHistoryVE>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118TUVehicleEnquiryHistoryVE" /> class.
        /// </summary>
        /// <param name="customerType">customerType.</param>
        /// <param name="enquiryDate">enquiryDate.</param>
        public TransunionConsumer118TUVehicleEnquiryHistoryVE(string customerType = default(string), string enquiryDate = default(string))
        {
            this.CustomerType = customerType;
            this.EnquiryDate = enquiryDate;
            this.CustomerType = customerType;
            this.EnquiryDate = enquiryDate;
        }

        /// <summary>
        /// Gets or Sets CustomerType
        /// </summary>
        [DataMember(Name="customerType", EmitDefaultValue=true)]
        public string CustomerType { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryDate
        /// </summary>
        [DataMember(Name="enquiryDate", EmitDefaultValue=true)]
        public string EnquiryDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118TUVehicleEnquiryHistoryVE {\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
            sb.Append("  EnquiryDate: ").Append(EnquiryDate).Append("\n");
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
            return this.Equals(input as TransunionConsumer118TUVehicleEnquiryHistoryVE);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118TUVehicleEnquiryHistoryVE instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118TUVehicleEnquiryHistoryVE to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118TUVehicleEnquiryHistoryVE input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerType == input.CustomerType ||
                    (this.CustomerType != null &&
                    this.CustomerType.Equals(input.CustomerType))
                ) && 
                (
                    this.EnquiryDate == input.EnquiryDate ||
                    (this.EnquiryDate != null &&
                    this.EnquiryDate.Equals(input.EnquiryDate))
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
                if (this.CustomerType != null)
                    hashCode = hashCode * 59 + this.CustomerType.GetHashCode();
                if (this.EnquiryDate != null)
                    hashCode = hashCode * 59 + this.EnquiryDate.GetHashCode();
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
