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
    /// TransunionConsumer118AllRiskTypesAR
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118AllRiskTypesAR :  IEquatable<TransunionConsumer118AllRiskTypesAR>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118AllRiskTypesAR" /> class.
        /// </summary>
        /// <param name="claimItem1">claimItem1.</param>
        /// <param name="claimItem2">claimItem2.</param>
        /// <param name="claimItem3">claimItem3.</param>
        /// <param name="claimItem4">claimItem4.</param>
        /// <param name="claimItem5">claimItem5.</param>
        /// <param name="claimItem6">claimItem6.</param>
        /// <param name="claimItem7">claimItem7.</param>
        /// <param name="claimItem8">claimItem8.</param>
        /// <param name="claimItem9">claimItem9.</param>
        /// <param name="claimItem10">claimItem10.</param>
        /// <param name="claimItem11">claimItem11.</param>
        /// <param name="claimItem12">claimItem12.</param>
        /// <param name="claimItem13">claimItem13.</param>
        /// <param name="claimItem14">claimItem14.</param>
        /// <param name="claimItem15">claimItem15.</param>
        /// <param name="claimItem16">claimItem16.</param>
        /// <param name="claimItem17">claimItem17.</param>
        /// <param name="claimItem18">claimItem18.</param>
        /// <param name="claimItem19">claimItem19.</param>
        /// <param name="claimItem20">claimItem20.</param>
        public TransunionConsumer118AllRiskTypesAR(string claimItem1 = default(string), string claimItem2 = default(string), string claimItem3 = default(string), string claimItem4 = default(string), string claimItem5 = default(string), string claimItem6 = default(string), string claimItem7 = default(string), string claimItem8 = default(string), string claimItem9 = default(string), string claimItem10 = default(string), string claimItem11 = default(string), string claimItem12 = default(string), string claimItem13 = default(string), string claimItem14 = default(string), string claimItem15 = default(string), string claimItem16 = default(string), string claimItem17 = default(string), string claimItem18 = default(string), string claimItem19 = default(string), string claimItem20 = default(string))
        {
            this.ClaimItem1 = claimItem1;
            this.ClaimItem2 = claimItem2;
            this.ClaimItem3 = claimItem3;
            this.ClaimItem4 = claimItem4;
            this.ClaimItem5 = claimItem5;
            this.ClaimItem6 = claimItem6;
            this.ClaimItem7 = claimItem7;
            this.ClaimItem8 = claimItem8;
            this.ClaimItem9 = claimItem9;
            this.ClaimItem10 = claimItem10;
            this.ClaimItem11 = claimItem11;
            this.ClaimItem12 = claimItem12;
            this.ClaimItem13 = claimItem13;
            this.ClaimItem14 = claimItem14;
            this.ClaimItem15 = claimItem15;
            this.ClaimItem16 = claimItem16;
            this.ClaimItem17 = claimItem17;
            this.ClaimItem18 = claimItem18;
            this.ClaimItem19 = claimItem19;
            this.ClaimItem20 = claimItem20;
            this.ClaimItem1 = claimItem1;
            this.ClaimItem2 = claimItem2;
            this.ClaimItem3 = claimItem3;
            this.ClaimItem4 = claimItem4;
            this.ClaimItem5 = claimItem5;
            this.ClaimItem6 = claimItem6;
            this.ClaimItem7 = claimItem7;
            this.ClaimItem8 = claimItem8;
            this.ClaimItem9 = claimItem9;
            this.ClaimItem10 = claimItem10;
            this.ClaimItem11 = claimItem11;
            this.ClaimItem12 = claimItem12;
            this.ClaimItem13 = claimItem13;
            this.ClaimItem14 = claimItem14;
            this.ClaimItem15 = claimItem15;
            this.ClaimItem16 = claimItem16;
            this.ClaimItem17 = claimItem17;
            this.ClaimItem18 = claimItem18;
            this.ClaimItem19 = claimItem19;
            this.ClaimItem20 = claimItem20;
        }

        /// <summary>
        /// Gets or Sets ClaimItem1
        /// </summary>
        [DataMember(Name="claimItem1", EmitDefaultValue=true)]
        public string ClaimItem1 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem2
        /// </summary>
        [DataMember(Name="claimItem2", EmitDefaultValue=true)]
        public string ClaimItem2 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem3
        /// </summary>
        [DataMember(Name="claimItem3", EmitDefaultValue=true)]
        public string ClaimItem3 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem4
        /// </summary>
        [DataMember(Name="claimItem4", EmitDefaultValue=true)]
        public string ClaimItem4 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem5
        /// </summary>
        [DataMember(Name="claimItem5", EmitDefaultValue=true)]
        public string ClaimItem5 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem6
        /// </summary>
        [DataMember(Name="claimItem6", EmitDefaultValue=true)]
        public string ClaimItem6 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem7
        /// </summary>
        [DataMember(Name="claimItem7", EmitDefaultValue=true)]
        public string ClaimItem7 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem8
        /// </summary>
        [DataMember(Name="claimItem8", EmitDefaultValue=true)]
        public string ClaimItem8 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem9
        /// </summary>
        [DataMember(Name="claimItem9", EmitDefaultValue=true)]
        public string ClaimItem9 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem10
        /// </summary>
        [DataMember(Name="claimItem10", EmitDefaultValue=true)]
        public string ClaimItem10 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem11
        /// </summary>
        [DataMember(Name="claimItem11", EmitDefaultValue=true)]
        public string ClaimItem11 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem12
        /// </summary>
        [DataMember(Name="claimItem12", EmitDefaultValue=true)]
        public string ClaimItem12 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem13
        /// </summary>
        [DataMember(Name="claimItem13", EmitDefaultValue=true)]
        public string ClaimItem13 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem14
        /// </summary>
        [DataMember(Name="claimItem14", EmitDefaultValue=true)]
        public string ClaimItem14 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem15
        /// </summary>
        [DataMember(Name="claimItem15", EmitDefaultValue=true)]
        public string ClaimItem15 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem16
        /// </summary>
        [DataMember(Name="claimItem16", EmitDefaultValue=true)]
        public string ClaimItem16 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem17
        /// </summary>
        [DataMember(Name="claimItem17", EmitDefaultValue=true)]
        public string ClaimItem17 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem18
        /// </summary>
        [DataMember(Name="claimItem18", EmitDefaultValue=true)]
        public string ClaimItem18 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem19
        /// </summary>
        [DataMember(Name="claimItem19", EmitDefaultValue=true)]
        public string ClaimItem19 { get; set; }

        /// <summary>
        /// Gets or Sets ClaimItem20
        /// </summary>
        [DataMember(Name="claimItem20", EmitDefaultValue=true)]
        public string ClaimItem20 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118AllRiskTypesAR {\n");
            sb.Append("  ClaimItem1: ").Append(ClaimItem1).Append("\n");
            sb.Append("  ClaimItem2: ").Append(ClaimItem2).Append("\n");
            sb.Append("  ClaimItem3: ").Append(ClaimItem3).Append("\n");
            sb.Append("  ClaimItem4: ").Append(ClaimItem4).Append("\n");
            sb.Append("  ClaimItem5: ").Append(ClaimItem5).Append("\n");
            sb.Append("  ClaimItem6: ").Append(ClaimItem6).Append("\n");
            sb.Append("  ClaimItem7: ").Append(ClaimItem7).Append("\n");
            sb.Append("  ClaimItem8: ").Append(ClaimItem8).Append("\n");
            sb.Append("  ClaimItem9: ").Append(ClaimItem9).Append("\n");
            sb.Append("  ClaimItem10: ").Append(ClaimItem10).Append("\n");
            sb.Append("  ClaimItem11: ").Append(ClaimItem11).Append("\n");
            sb.Append("  ClaimItem12: ").Append(ClaimItem12).Append("\n");
            sb.Append("  ClaimItem13: ").Append(ClaimItem13).Append("\n");
            sb.Append("  ClaimItem14: ").Append(ClaimItem14).Append("\n");
            sb.Append("  ClaimItem15: ").Append(ClaimItem15).Append("\n");
            sb.Append("  ClaimItem16: ").Append(ClaimItem16).Append("\n");
            sb.Append("  ClaimItem17: ").Append(ClaimItem17).Append("\n");
            sb.Append("  ClaimItem18: ").Append(ClaimItem18).Append("\n");
            sb.Append("  ClaimItem19: ").Append(ClaimItem19).Append("\n");
            sb.Append("  ClaimItem20: ").Append(ClaimItem20).Append("\n");
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
            return this.Equals(input as TransunionConsumer118AllRiskTypesAR);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118AllRiskTypesAR instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118AllRiskTypesAR to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118AllRiskTypesAR input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClaimItem1 == input.ClaimItem1 ||
                    (this.ClaimItem1 != null &&
                    this.ClaimItem1.Equals(input.ClaimItem1))
                ) && 
                (
                    this.ClaimItem2 == input.ClaimItem2 ||
                    (this.ClaimItem2 != null &&
                    this.ClaimItem2.Equals(input.ClaimItem2))
                ) && 
                (
                    this.ClaimItem3 == input.ClaimItem3 ||
                    (this.ClaimItem3 != null &&
                    this.ClaimItem3.Equals(input.ClaimItem3))
                ) && 
                (
                    this.ClaimItem4 == input.ClaimItem4 ||
                    (this.ClaimItem4 != null &&
                    this.ClaimItem4.Equals(input.ClaimItem4))
                ) && 
                (
                    this.ClaimItem5 == input.ClaimItem5 ||
                    (this.ClaimItem5 != null &&
                    this.ClaimItem5.Equals(input.ClaimItem5))
                ) && 
                (
                    this.ClaimItem6 == input.ClaimItem6 ||
                    (this.ClaimItem6 != null &&
                    this.ClaimItem6.Equals(input.ClaimItem6))
                ) && 
                (
                    this.ClaimItem7 == input.ClaimItem7 ||
                    (this.ClaimItem7 != null &&
                    this.ClaimItem7.Equals(input.ClaimItem7))
                ) && 
                (
                    this.ClaimItem8 == input.ClaimItem8 ||
                    (this.ClaimItem8 != null &&
                    this.ClaimItem8.Equals(input.ClaimItem8))
                ) && 
                (
                    this.ClaimItem9 == input.ClaimItem9 ||
                    (this.ClaimItem9 != null &&
                    this.ClaimItem9.Equals(input.ClaimItem9))
                ) && 
                (
                    this.ClaimItem10 == input.ClaimItem10 ||
                    (this.ClaimItem10 != null &&
                    this.ClaimItem10.Equals(input.ClaimItem10))
                ) && 
                (
                    this.ClaimItem11 == input.ClaimItem11 ||
                    (this.ClaimItem11 != null &&
                    this.ClaimItem11.Equals(input.ClaimItem11))
                ) && 
                (
                    this.ClaimItem12 == input.ClaimItem12 ||
                    (this.ClaimItem12 != null &&
                    this.ClaimItem12.Equals(input.ClaimItem12))
                ) && 
                (
                    this.ClaimItem13 == input.ClaimItem13 ||
                    (this.ClaimItem13 != null &&
                    this.ClaimItem13.Equals(input.ClaimItem13))
                ) && 
                (
                    this.ClaimItem14 == input.ClaimItem14 ||
                    (this.ClaimItem14 != null &&
                    this.ClaimItem14.Equals(input.ClaimItem14))
                ) && 
                (
                    this.ClaimItem15 == input.ClaimItem15 ||
                    (this.ClaimItem15 != null &&
                    this.ClaimItem15.Equals(input.ClaimItem15))
                ) && 
                (
                    this.ClaimItem16 == input.ClaimItem16 ||
                    (this.ClaimItem16 != null &&
                    this.ClaimItem16.Equals(input.ClaimItem16))
                ) && 
                (
                    this.ClaimItem17 == input.ClaimItem17 ||
                    (this.ClaimItem17 != null &&
                    this.ClaimItem17.Equals(input.ClaimItem17))
                ) && 
                (
                    this.ClaimItem18 == input.ClaimItem18 ||
                    (this.ClaimItem18 != null &&
                    this.ClaimItem18.Equals(input.ClaimItem18))
                ) && 
                (
                    this.ClaimItem19 == input.ClaimItem19 ||
                    (this.ClaimItem19 != null &&
                    this.ClaimItem19.Equals(input.ClaimItem19))
                ) && 
                (
                    this.ClaimItem20 == input.ClaimItem20 ||
                    (this.ClaimItem20 != null &&
                    this.ClaimItem20.Equals(input.ClaimItem20))
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
                if (this.ClaimItem1 != null)
                    hashCode = hashCode * 59 + this.ClaimItem1.GetHashCode();
                if (this.ClaimItem2 != null)
                    hashCode = hashCode * 59 + this.ClaimItem2.GetHashCode();
                if (this.ClaimItem3 != null)
                    hashCode = hashCode * 59 + this.ClaimItem3.GetHashCode();
                if (this.ClaimItem4 != null)
                    hashCode = hashCode * 59 + this.ClaimItem4.GetHashCode();
                if (this.ClaimItem5 != null)
                    hashCode = hashCode * 59 + this.ClaimItem5.GetHashCode();
                if (this.ClaimItem6 != null)
                    hashCode = hashCode * 59 + this.ClaimItem6.GetHashCode();
                if (this.ClaimItem7 != null)
                    hashCode = hashCode * 59 + this.ClaimItem7.GetHashCode();
                if (this.ClaimItem8 != null)
                    hashCode = hashCode * 59 + this.ClaimItem8.GetHashCode();
                if (this.ClaimItem9 != null)
                    hashCode = hashCode * 59 + this.ClaimItem9.GetHashCode();
                if (this.ClaimItem10 != null)
                    hashCode = hashCode * 59 + this.ClaimItem10.GetHashCode();
                if (this.ClaimItem11 != null)
                    hashCode = hashCode * 59 + this.ClaimItem11.GetHashCode();
                if (this.ClaimItem12 != null)
                    hashCode = hashCode * 59 + this.ClaimItem12.GetHashCode();
                if (this.ClaimItem13 != null)
                    hashCode = hashCode * 59 + this.ClaimItem13.GetHashCode();
                if (this.ClaimItem14 != null)
                    hashCode = hashCode * 59 + this.ClaimItem14.GetHashCode();
                if (this.ClaimItem15 != null)
                    hashCode = hashCode * 59 + this.ClaimItem15.GetHashCode();
                if (this.ClaimItem16 != null)
                    hashCode = hashCode * 59 + this.ClaimItem16.GetHashCode();
                if (this.ClaimItem17 != null)
                    hashCode = hashCode * 59 + this.ClaimItem17.GetHashCode();
                if (this.ClaimItem18 != null)
                    hashCode = hashCode * 59 + this.ClaimItem18.GetHashCode();
                if (this.ClaimItem19 != null)
                    hashCode = hashCode * 59 + this.ClaimItem19.GetHashCode();
                if (this.ClaimItem20 != null)
                    hashCode = hashCode * 59 + this.ClaimItem20.GetHashCode();
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
