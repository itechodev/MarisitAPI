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
    /// CompuscanCOMPFINANCIALS
    /// </summary>
    [DataContract]
    public partial class CompuscanCOMPFINANCIALS :  IEquatable<CompuscanCOMPFINANCIALS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompuscanCOMPFINANCIALS" /> class.
        /// </summary>
        /// <param name="bonds">bonds.</param>
        /// <param name="bondsval">bondsval.</param>
        /// <param name="comments">comments.</param>
        /// <param name="createddttm">createddttm.</param>
        /// <param name="debtceded">debtceded.</param>
        /// <param name="debtcededvalue">debtcededvalue.</param>
        /// <param name="debtfact">debtfact.</param>
        /// <param name="debtfactval">debtfactval.</param>
        /// <param name="finhistoricyearend">finhistoricyearend.</param>
        /// <param name="finyearend">finyearend.</param>
        /// <param name="sureties">sureties.</param>
        /// <param name="suretiesvalue">suretiesvalue.</param>
        /// <param name="totoverdraftex">totoverdraftex.</param>
        public CompuscanCOMPFINANCIALS(string bonds = default(string), string bondsval = default(string), string comments = default(string), string createddttm = default(string), string debtceded = default(string), string debtcededvalue = default(string), string debtfact = default(string), string debtfactval = default(string), string finhistoricyearend = default(string), string finyearend = default(string), string sureties = default(string), string suretiesvalue = default(string), string totoverdraftex = default(string))
        {
            this.Bonds = bonds;
            this.Bondsval = bondsval;
            this.Comments = comments;
            this.Createddttm = createddttm;
            this.Debtceded = debtceded;
            this.Debtcededvalue = debtcededvalue;
            this.Debtfact = debtfact;
            this.Debtfactval = debtfactval;
            this.Finhistoricyearend = finhistoricyearend;
            this.Finyearend = finyearend;
            this.Sureties = sureties;
            this.Suretiesvalue = suretiesvalue;
            this.Totoverdraftex = totoverdraftex;
            this.Bonds = bonds;
            this.Bondsval = bondsval;
            this.Comments = comments;
            this.Createddttm = createddttm;
            this.Debtceded = debtceded;
            this.Debtcededvalue = debtcededvalue;
            this.Debtfact = debtfact;
            this.Debtfactval = debtfactval;
            this.Finhistoricyearend = finhistoricyearend;
            this.Finyearend = finyearend;
            this.Sureties = sureties;
            this.Suretiesvalue = suretiesvalue;
            this.Totoverdraftex = totoverdraftex;
        }

        /// <summary>
        /// Gets or Sets Bonds
        /// </summary>
        [DataMember(Name="bonds", EmitDefaultValue=true)]
        public string Bonds { get; set; }

        /// <summary>
        /// Gets or Sets Bondsval
        /// </summary>
        [DataMember(Name="bondsval", EmitDefaultValue=true)]
        public string Bondsval { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=true)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Createddttm
        /// </summary>
        [DataMember(Name="createddttm", EmitDefaultValue=true)]
        public string Createddttm { get; set; }

        /// <summary>
        /// Gets or Sets Debtceded
        /// </summary>
        [DataMember(Name="debtceded", EmitDefaultValue=true)]
        public string Debtceded { get; set; }

        /// <summary>
        /// Gets or Sets Debtcededvalue
        /// </summary>
        [DataMember(Name="debtcededvalue", EmitDefaultValue=true)]
        public string Debtcededvalue { get; set; }

        /// <summary>
        /// Gets or Sets Debtfact
        /// </summary>
        [DataMember(Name="debtfact", EmitDefaultValue=true)]
        public string Debtfact { get; set; }

        /// <summary>
        /// Gets or Sets Debtfactval
        /// </summary>
        [DataMember(Name="debtfactval", EmitDefaultValue=true)]
        public string Debtfactval { get; set; }

        /// <summary>
        /// Gets or Sets Finhistoricyearend
        /// </summary>
        [DataMember(Name="finhistoricyearend", EmitDefaultValue=true)]
        public string Finhistoricyearend { get; set; }

        /// <summary>
        /// Gets or Sets Finyearend
        /// </summary>
        [DataMember(Name="finyearend", EmitDefaultValue=true)]
        public string Finyearend { get; set; }

        /// <summary>
        /// Gets or Sets Sureties
        /// </summary>
        [DataMember(Name="sureties", EmitDefaultValue=true)]
        public string Sureties { get; set; }

        /// <summary>
        /// Gets or Sets Suretiesvalue
        /// </summary>
        [DataMember(Name="suretiesvalue", EmitDefaultValue=true)]
        public string Suretiesvalue { get; set; }

        /// <summary>
        /// Gets or Sets Totoverdraftex
        /// </summary>
        [DataMember(Name="totoverdraftex", EmitDefaultValue=true)]
        public string Totoverdraftex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompuscanCOMPFINANCIALS {\n");
            sb.Append("  Bonds: ").Append(Bonds).Append("\n");
            sb.Append("  Bondsval: ").Append(Bondsval).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Createddttm: ").Append(Createddttm).Append("\n");
            sb.Append("  Debtceded: ").Append(Debtceded).Append("\n");
            sb.Append("  Debtcededvalue: ").Append(Debtcededvalue).Append("\n");
            sb.Append("  Debtfact: ").Append(Debtfact).Append("\n");
            sb.Append("  Debtfactval: ").Append(Debtfactval).Append("\n");
            sb.Append("  Finhistoricyearend: ").Append(Finhistoricyearend).Append("\n");
            sb.Append("  Finyearend: ").Append(Finyearend).Append("\n");
            sb.Append("  Sureties: ").Append(Sureties).Append("\n");
            sb.Append("  Suretiesvalue: ").Append(Suretiesvalue).Append("\n");
            sb.Append("  Totoverdraftex: ").Append(Totoverdraftex).Append("\n");
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
            return this.Equals(input as CompuscanCOMPFINANCIALS);
        }

        /// <summary>
        /// Returns true if CompuscanCOMPFINANCIALS instances are equal
        /// </summary>
        /// <param name="input">Instance of CompuscanCOMPFINANCIALS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompuscanCOMPFINANCIALS input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bonds == input.Bonds ||
                    (this.Bonds != null &&
                    this.Bonds.Equals(input.Bonds))
                ) && 
                (
                    this.Bondsval == input.Bondsval ||
                    (this.Bondsval != null &&
                    this.Bondsval.Equals(input.Bondsval))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Createddttm == input.Createddttm ||
                    (this.Createddttm != null &&
                    this.Createddttm.Equals(input.Createddttm))
                ) && 
                (
                    this.Debtceded == input.Debtceded ||
                    (this.Debtceded != null &&
                    this.Debtceded.Equals(input.Debtceded))
                ) && 
                (
                    this.Debtcededvalue == input.Debtcededvalue ||
                    (this.Debtcededvalue != null &&
                    this.Debtcededvalue.Equals(input.Debtcededvalue))
                ) && 
                (
                    this.Debtfact == input.Debtfact ||
                    (this.Debtfact != null &&
                    this.Debtfact.Equals(input.Debtfact))
                ) && 
                (
                    this.Debtfactval == input.Debtfactval ||
                    (this.Debtfactval != null &&
                    this.Debtfactval.Equals(input.Debtfactval))
                ) && 
                (
                    this.Finhistoricyearend == input.Finhistoricyearend ||
                    (this.Finhistoricyearend != null &&
                    this.Finhistoricyearend.Equals(input.Finhistoricyearend))
                ) && 
                (
                    this.Finyearend == input.Finyearend ||
                    (this.Finyearend != null &&
                    this.Finyearend.Equals(input.Finyearend))
                ) && 
                (
                    this.Sureties == input.Sureties ||
                    (this.Sureties != null &&
                    this.Sureties.Equals(input.Sureties))
                ) && 
                (
                    this.Suretiesvalue == input.Suretiesvalue ||
                    (this.Suretiesvalue != null &&
                    this.Suretiesvalue.Equals(input.Suretiesvalue))
                ) && 
                (
                    this.Totoverdraftex == input.Totoverdraftex ||
                    (this.Totoverdraftex != null &&
                    this.Totoverdraftex.Equals(input.Totoverdraftex))
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
                if (this.Bonds != null)
                    hashCode = hashCode * 59 + this.Bonds.GetHashCode();
                if (this.Bondsval != null)
                    hashCode = hashCode * 59 + this.Bondsval.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Createddttm != null)
                    hashCode = hashCode * 59 + this.Createddttm.GetHashCode();
                if (this.Debtceded != null)
                    hashCode = hashCode * 59 + this.Debtceded.GetHashCode();
                if (this.Debtcededvalue != null)
                    hashCode = hashCode * 59 + this.Debtcededvalue.GetHashCode();
                if (this.Debtfact != null)
                    hashCode = hashCode * 59 + this.Debtfact.GetHashCode();
                if (this.Debtfactval != null)
                    hashCode = hashCode * 59 + this.Debtfactval.GetHashCode();
                if (this.Finhistoricyearend != null)
                    hashCode = hashCode * 59 + this.Finhistoricyearend.GetHashCode();
                if (this.Finyearend != null)
                    hashCode = hashCode * 59 + this.Finyearend.GetHashCode();
                if (this.Sureties != null)
                    hashCode = hashCode * 59 + this.Sureties.GetHashCode();
                if (this.Suretiesvalue != null)
                    hashCode = hashCode * 59 + this.Suretiesvalue.GetHashCode();
                if (this.Totoverdraftex != null)
                    hashCode = hashCode * 59 + this.Totoverdraftex.GetHashCode();
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
