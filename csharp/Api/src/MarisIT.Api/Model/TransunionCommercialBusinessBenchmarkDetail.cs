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
    /// TransunionCommercialBusinessBenchmarkDetail
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialBusinessBenchmarkDetail :  IEquatable<TransunionCommercialBusinessBenchmarkDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialBusinessBenchmarkDetail" /> class.
        /// </summary>
        /// <param name="bcACategory">bcACategory.</param>
        /// <param name="bcAVarId">bcAVarId.</param>
        /// <param name="bcASubjVal">bcASubjVal.</param>
        /// <param name="bcALtdVal">bcALtdVal.</param>
        /// <param name="bcAPtyLtdVal">bcAPtyLtdVal.</param>
        /// <param name="bcACCVal">bcACCVal.</param>
        /// <param name="bcAOtherVal">bcAOtherVal.</param>
        public TransunionCommercialBusinessBenchmarkDetail(string bcACategory = default(string), string bcAVarId = default(string), string bcASubjVal = default(string), string bcALtdVal = default(string), string bcAPtyLtdVal = default(string), string bcACCVal = default(string), string bcAOtherVal = default(string))
        {
            this.BcACategory = bcACategory;
            this.BcAVarId = bcAVarId;
            this.BcASubjVal = bcASubjVal;
            this.BcALtdVal = bcALtdVal;
            this.BcAPtyLtdVal = bcAPtyLtdVal;
            this.BcACCVal = bcACCVal;
            this.BcAOtherVal = bcAOtherVal;
            this.BcACategory = bcACategory;
            this.BcAVarId = bcAVarId;
            this.BcASubjVal = bcASubjVal;
            this.BcALtdVal = bcALtdVal;
            this.BcAPtyLtdVal = bcAPtyLtdVal;
            this.BcACCVal = bcACCVal;
            this.BcAOtherVal = bcAOtherVal;
        }

        /// <summary>
        /// Gets or Sets BcACategory
        /// </summary>
        [DataMember(Name="bcA_Category", EmitDefaultValue=true)]
        public string BcACategory { get; set; }

        /// <summary>
        /// Gets or Sets BcAVarId
        /// </summary>
        [DataMember(Name="bcA_Var_Id", EmitDefaultValue=true)]
        public string BcAVarId { get; set; }

        /// <summary>
        /// Gets or Sets BcASubjVal
        /// </summary>
        [DataMember(Name="bcA_Subj_val", EmitDefaultValue=true)]
        public string BcASubjVal { get; set; }

        /// <summary>
        /// Gets or Sets BcALtdVal
        /// </summary>
        [DataMember(Name="bcA_Ltd_Val", EmitDefaultValue=true)]
        public string BcALtdVal { get; set; }

        /// <summary>
        /// Gets or Sets BcAPtyLtdVal
        /// </summary>
        [DataMember(Name="bcA_PtyLtd_Val", EmitDefaultValue=true)]
        public string BcAPtyLtdVal { get; set; }

        /// <summary>
        /// Gets or Sets BcACCVal
        /// </summary>
        [DataMember(Name="bcA_CC_Val", EmitDefaultValue=true)]
        public string BcACCVal { get; set; }

        /// <summary>
        /// Gets or Sets BcAOtherVal
        /// </summary>
        [DataMember(Name="bcA_Other_val", EmitDefaultValue=true)]
        public string BcAOtherVal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialBusinessBenchmarkDetail {\n");
            sb.Append("  BcACategory: ").Append(BcACategory).Append("\n");
            sb.Append("  BcAVarId: ").Append(BcAVarId).Append("\n");
            sb.Append("  BcASubjVal: ").Append(BcASubjVal).Append("\n");
            sb.Append("  BcALtdVal: ").Append(BcALtdVal).Append("\n");
            sb.Append("  BcAPtyLtdVal: ").Append(BcAPtyLtdVal).Append("\n");
            sb.Append("  BcACCVal: ").Append(BcACCVal).Append("\n");
            sb.Append("  BcAOtherVal: ").Append(BcAOtherVal).Append("\n");
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
            return this.Equals(input as TransunionCommercialBusinessBenchmarkDetail);
        }

        /// <summary>
        /// Returns true if TransunionCommercialBusinessBenchmarkDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialBusinessBenchmarkDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialBusinessBenchmarkDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BcACategory == input.BcACategory ||
                    (this.BcACategory != null &&
                    this.BcACategory.Equals(input.BcACategory))
                ) && 
                (
                    this.BcAVarId == input.BcAVarId ||
                    (this.BcAVarId != null &&
                    this.BcAVarId.Equals(input.BcAVarId))
                ) && 
                (
                    this.BcASubjVal == input.BcASubjVal ||
                    (this.BcASubjVal != null &&
                    this.BcASubjVal.Equals(input.BcASubjVal))
                ) && 
                (
                    this.BcALtdVal == input.BcALtdVal ||
                    (this.BcALtdVal != null &&
                    this.BcALtdVal.Equals(input.BcALtdVal))
                ) && 
                (
                    this.BcAPtyLtdVal == input.BcAPtyLtdVal ||
                    (this.BcAPtyLtdVal != null &&
                    this.BcAPtyLtdVal.Equals(input.BcAPtyLtdVal))
                ) && 
                (
                    this.BcACCVal == input.BcACCVal ||
                    (this.BcACCVal != null &&
                    this.BcACCVal.Equals(input.BcACCVal))
                ) && 
                (
                    this.BcAOtherVal == input.BcAOtherVal ||
                    (this.BcAOtherVal != null &&
                    this.BcAOtherVal.Equals(input.BcAOtherVal))
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
                if (this.BcACategory != null)
                    hashCode = hashCode * 59 + this.BcACategory.GetHashCode();
                if (this.BcAVarId != null)
                    hashCode = hashCode * 59 + this.BcAVarId.GetHashCode();
                if (this.BcASubjVal != null)
                    hashCode = hashCode * 59 + this.BcASubjVal.GetHashCode();
                if (this.BcALtdVal != null)
                    hashCode = hashCode * 59 + this.BcALtdVal.GetHashCode();
                if (this.BcAPtyLtdVal != null)
                    hashCode = hashCode * 59 + this.BcAPtyLtdVal.GetHashCode();
                if (this.BcACCVal != null)
                    hashCode = hashCode * 59 + this.BcACCVal.GetHashCode();
                if (this.BcAOtherVal != null)
                    hashCode = hashCode * 59 + this.BcAOtherVal.GetHashCode();
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
