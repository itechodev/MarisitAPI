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
    /// WindeedKnowledgeFactoryErfToStreetResponse
    /// </summary>
    [DataContract]
    public partial class WindeedKnowledgeFactoryErfToStreetResponse :  IEquatable<WindeedKnowledgeFactoryErfToStreetResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets StreetType
        /// </summary>
        [DataMember(Name="streetType", EmitDefaultValue=false)]
        public WindeedKnowledgeFactoryStreetType? StreetType { get; set; }
        /// <summary>
        /// Gets or Sets DeedsOffice
        /// </summary>
        [DataMember(Name="deedsOffice", EmitDefaultValue=false)]
        public WindeedKnowledgeFactoryRegistrar? DeedsOffice { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedKnowledgeFactoryErfToStreetResponse" /> class.
        /// </summary>
        /// <param name="responseDateTime">responseDateTime.</param>
        /// <param name="isSearchBatched">isSearchBatched.</param>
        /// <param name="warnings">warnings.</param>
        /// <param name="dbKey">dbKey.</param>
        /// <param name="erfNumber">erfNumber.</param>
        /// <param name="portionNumber">portionNumber.</param>
        /// <param name="streetNumber">streetNumber.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="streetType">streetType.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="town">town.</param>
        /// <param name="deedsOffice">deedsOffice.</param>
        /// <param name="township">township.</param>
        public WindeedKnowledgeFactoryErfToStreetResponse(DateTime responseDateTime = default(DateTime), bool isSearchBatched = default(bool), List<string> warnings = default(List<string>), string dbKey = default(string), string erfNumber = default(string), string portionNumber = default(string), string streetNumber = default(string), string streetName = default(string), WindeedKnowledgeFactoryStreetType? streetType = default(WindeedKnowledgeFactoryStreetType?), string suburb = default(string), string town = default(string), WindeedKnowledgeFactoryRegistrar? deedsOffice = default(WindeedKnowledgeFactoryRegistrar?), string township = default(string))
        {
            this.Warnings = warnings;
            this.DbKey = dbKey;
            this.ErfNumber = erfNumber;
            this.PortionNumber = portionNumber;
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.Suburb = suburb;
            this.Town = town;
            this.Township = township;
            this.ResponseDateTime = responseDateTime;
            this.IsSearchBatched = isSearchBatched;
            this.Warnings = warnings;
            this.DbKey = dbKey;
            this.ErfNumber = erfNumber;
            this.PortionNumber = portionNumber;
            this.StreetNumber = streetNumber;
            this.StreetName = streetName;
            this.StreetType = streetType;
            this.Suburb = suburb;
            this.Town = town;
            this.DeedsOffice = deedsOffice;
            this.Township = township;
        }

        /// <summary>
        /// Gets or Sets ResponseDateTime
        /// </summary>
        [DataMember(Name="responseDateTime", EmitDefaultValue=false)]
        public DateTime ResponseDateTime { get; set; }

        /// <summary>
        /// Gets or Sets IsSearchBatched
        /// </summary>
        [DataMember(Name="isSearchBatched", EmitDefaultValue=false)]
        public bool IsSearchBatched { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name="warnings", EmitDefaultValue=true)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets DbKey
        /// </summary>
        [DataMember(Name="dbKey", EmitDefaultValue=true)]
        public string DbKey { get; set; }

        /// <summary>
        /// Gets or Sets ErfNumber
        /// </summary>
        [DataMember(Name="erfNumber", EmitDefaultValue=true)]
        public string ErfNumber { get; set; }

        /// <summary>
        /// Gets or Sets PortionNumber
        /// </summary>
        [DataMember(Name="portionNumber", EmitDefaultValue=true)]
        public string PortionNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetNumber
        /// </summary>
        [DataMember(Name="streetNumber", EmitDefaultValue=true)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=true)]
        public string StreetName { get; set; }


        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Town
        /// </summary>
        [DataMember(Name="town", EmitDefaultValue=true)]
        public string Town { get; set; }


        /// <summary>
        /// Gets or Sets Township
        /// </summary>
        [DataMember(Name="township", EmitDefaultValue=true)]
        public string Township { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedKnowledgeFactoryErfToStreetResponse {\n");
            sb.Append("  ResponseDateTime: ").Append(ResponseDateTime).Append("\n");
            sb.Append("  IsSearchBatched: ").Append(IsSearchBatched).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  DbKey: ").Append(DbKey).Append("\n");
            sb.Append("  ErfNumber: ").Append(ErfNumber).Append("\n");
            sb.Append("  PortionNumber: ").Append(PortionNumber).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetType: ").Append(StreetType).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Town: ").Append(Town).Append("\n");
            sb.Append("  DeedsOffice: ").Append(DeedsOffice).Append("\n");
            sb.Append("  Township: ").Append(Township).Append("\n");
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
            return this.Equals(input as WindeedKnowledgeFactoryErfToStreetResponse);
        }

        /// <summary>
        /// Returns true if WindeedKnowledgeFactoryErfToStreetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedKnowledgeFactoryErfToStreetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedKnowledgeFactoryErfToStreetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseDateTime == input.ResponseDateTime ||
                    (this.ResponseDateTime != null &&
                    this.ResponseDateTime.Equals(input.ResponseDateTime))
                ) && 
                (
                    this.IsSearchBatched == input.IsSearchBatched ||
                    (this.IsSearchBatched != null &&
                    this.IsSearchBatched.Equals(input.IsSearchBatched))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.DbKey == input.DbKey ||
                    (this.DbKey != null &&
                    this.DbKey.Equals(input.DbKey))
                ) && 
                (
                    this.ErfNumber == input.ErfNumber ||
                    (this.ErfNumber != null &&
                    this.ErfNumber.Equals(input.ErfNumber))
                ) && 
                (
                    this.PortionNumber == input.PortionNumber ||
                    (this.PortionNumber != null &&
                    this.PortionNumber.Equals(input.PortionNumber))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.StreetType == input.StreetType ||
                    (this.StreetType != null &&
                    this.StreetType.Equals(input.StreetType))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Town == input.Town ||
                    (this.Town != null &&
                    this.Town.Equals(input.Town))
                ) && 
                (
                    this.DeedsOffice == input.DeedsOffice ||
                    (this.DeedsOffice != null &&
                    this.DeedsOffice.Equals(input.DeedsOffice))
                ) && 
                (
                    this.Township == input.Township ||
                    (this.Township != null &&
                    this.Township.Equals(input.Township))
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
                if (this.ResponseDateTime != null)
                    hashCode = hashCode * 59 + this.ResponseDateTime.GetHashCode();
                if (this.IsSearchBatched != null)
                    hashCode = hashCode * 59 + this.IsSearchBatched.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.DbKey != null)
                    hashCode = hashCode * 59 + this.DbKey.GetHashCode();
                if (this.ErfNumber != null)
                    hashCode = hashCode * 59 + this.ErfNumber.GetHashCode();
                if (this.PortionNumber != null)
                    hashCode = hashCode * 59 + this.PortionNumber.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.StreetType != null)
                    hashCode = hashCode * 59 + this.StreetType.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Town != null)
                    hashCode = hashCode * 59 + this.Town.GetHashCode();
                if (this.DeedsOffice != null)
                    hashCode = hashCode * 59 + this.DeedsOffice.GetHashCode();
                if (this.Township != null)
                    hashCode = hashCode * 59 + this.Township.GetHashCode();
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
