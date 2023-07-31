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
    /// XdsAccountTraceRequest
    /// </summary>
    [DataContract]
    public partial class XdsAccountTraceRequest :  IEquatable<XdsAccountTraceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsAccountTraceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected XdsAccountTraceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsAccountTraceRequest" /> class.
        /// </summary>
        /// <param name="surname">surname.</param>
        /// <param name="accountNo">accountNo (required).</param>
        /// <param name="reference">reference.</param>
        public XdsAccountTraceRequest(string surname = default(string), string accountNo = default(string), string reference = default(string))
        {
            this.Surname = surname;
            // to ensure "accountNo" is required (not null)
            if (accountNo == null)
            {
                throw new InvalidDataException("accountNo is a required property for XdsAccountTraceRequest and cannot be null");
            }
            else
            {
                this.AccountNo = accountNo;
            }

            this.Reference = reference;
            this.Surname = surname;
            this.Reference = reference;
        }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets AccountNo
        /// </summary>
        [DataMember(Name="accountNo", EmitDefaultValue=true)]
        public string AccountNo { get; set; }

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
            sb.Append("class XdsAccountTraceRequest {\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
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
            return this.Equals(input as XdsAccountTraceRequest);
        }

        /// <summary>
        /// Returns true if XdsAccountTraceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsAccountTraceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsAccountTraceRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.AccountNo == input.AccountNo ||
                    (this.AccountNo != null &&
                    this.AccountNo.Equals(input.AccountNo))
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
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.AccountNo != null)
                    hashCode = hashCode * 59 + this.AccountNo.GetHashCode();
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
