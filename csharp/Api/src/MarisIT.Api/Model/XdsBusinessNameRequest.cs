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
    /// XdsBusinessNameRequest
    /// </summary>
    [DataContract]
    public partial class XdsBusinessNameRequest :  IEquatable<XdsBusinessNameRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsBusinessNameRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XdsBusinessNameRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsBusinessNameRequest" /> class.
        /// </summary>
        /// <param name="businessName">businessName (required).</param>
        /// <param name="reference">reference.</param>
        public XdsBusinessNameRequest(string businessName = default(string), string reference = default(string))
        {
            // to ensure "businessName" is required (not null)
            if (businessName == null)
            {
                throw new InvalidDataException("businessName is a required property for XdsBusinessNameRequest and cannot be null");
            }
            else
            {
                this.BusinessName = businessName;
            }

            this.Reference = reference;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="businessName", EmitDefaultValue=true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsBusinessNameRequest {\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as XdsBusinessNameRequest);
        }

        /// <summary>
        /// Returns true if XdsBusinessNameRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsBusinessNameRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsBusinessNameRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
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
