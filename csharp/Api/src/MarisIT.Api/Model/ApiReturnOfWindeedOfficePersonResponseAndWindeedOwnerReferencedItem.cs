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
    /// ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem
    /// </summary>
    [DataContract]
    public partial class ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem :  IEquatable<ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem" /> class.
        /// </summary>
        /// <param name="reportData">reportData.</param>
        public ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem(WindeedOfficePersonResponse reportData = default(WindeedOfficePersonResponse))
        {
            this.ReportData = reportData;
        }

        /// <summary>
        /// Gets or Sets ReportData
        /// </summary>
        [DataMember(Name="reportData", EmitDefaultValue=false)]
        public WindeedOfficePersonResponse ReportData { get; set; }

        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name="list", EmitDefaultValue=true)]
        public List<WindeedOwnerReferencedItem> List { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem {\n");
            sb.Append("  ReportData: ").Append(ReportData).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
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
            return this.Equals(input as ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem);
        }

        /// <summary>
        /// Returns true if ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportData == input.ReportData ||
                    (this.ReportData != null &&
                    this.ReportData.Equals(input.ReportData))
                ) && 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
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
                if (this.ReportData != null)
                    hashCode = hashCode * 59 + this.ReportData.GetHashCode();
                if (this.List != null)
                    hashCode = hashCode * 59 + this.List.GetHashCode();
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
