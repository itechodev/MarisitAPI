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
    /// WindeedSpiderPersonAssociation
    /// </summary>
    [DataContract]
    public partial class WindeedSpiderPersonAssociation :  IEquatable<WindeedSpiderPersonAssociation>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SubjectType
        /// </summary>
        [DataMember(Name="subjectType", EmitDefaultValue=false)]
        public WindeedSpiderPersonType? SubjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedSpiderPersonAssociation" /> class.
        /// </summary>
        /// <param name="dbKey">dbKey.</param>
        /// <param name="deedsOfficeName">deedsOfficeName.</param>
        /// <param name="deedsOfficeNumber">deedsOfficeNumber.</param>
        /// <param name="currentPropertyCount">currentPropertyCount.</param>
        /// <param name="historicPropertyCount">historicPropertyCount.</param>
        /// <param name="subjectType">subjectType.</param>
        public WindeedSpiderPersonAssociation(int dbKey = default(int), string deedsOfficeName = default(string), string deedsOfficeNumber = default(string), int currentPropertyCount = default(int), int historicPropertyCount = default(int), WindeedSpiderPersonType? subjectType = default(WindeedSpiderPersonType?))
        {
            this.DeedsOfficeName = deedsOfficeName;
            this.DeedsOfficeNumber = deedsOfficeNumber;
            this.DbKey = dbKey;
            this.DeedsOfficeName = deedsOfficeName;
            this.DeedsOfficeNumber = deedsOfficeNumber;
            this.CurrentPropertyCount = currentPropertyCount;
            this.HistoricPropertyCount = historicPropertyCount;
            this.SubjectType = subjectType;
        }

        /// <summary>
        /// Gets or Sets DbKey
        /// </summary>
        [DataMember(Name="dbKey", EmitDefaultValue=false)]
        public int DbKey { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOfficeName
        /// </summary>
        [DataMember(Name="deedsOfficeName", EmitDefaultValue=true)]
        public string DeedsOfficeName { get; set; }

        /// <summary>
        /// Gets or Sets DeedsOfficeNumber
        /// </summary>
        [DataMember(Name="deedsOfficeNumber", EmitDefaultValue=true)]
        public string DeedsOfficeNumber { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPropertyCount
        /// </summary>
        [DataMember(Name="currentPropertyCount", EmitDefaultValue=false)]
        public int CurrentPropertyCount { get; set; }

        /// <summary>
        /// Gets or Sets HistoricPropertyCount
        /// </summary>
        [DataMember(Name="historicPropertyCount", EmitDefaultValue=false)]
        public int HistoricPropertyCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedSpiderPersonAssociation {\n");
            sb.Append("  DbKey: ").Append(DbKey).Append("\n");
            sb.Append("  DeedsOfficeName: ").Append(DeedsOfficeName).Append("\n");
            sb.Append("  DeedsOfficeNumber: ").Append(DeedsOfficeNumber).Append("\n");
            sb.Append("  CurrentPropertyCount: ").Append(CurrentPropertyCount).Append("\n");
            sb.Append("  HistoricPropertyCount: ").Append(HistoricPropertyCount).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
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
            return this.Equals(input as WindeedSpiderPersonAssociation);
        }

        /// <summary>
        /// Returns true if WindeedSpiderPersonAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedSpiderPersonAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedSpiderPersonAssociation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DbKey == input.DbKey ||
                    (this.DbKey != null &&
                    this.DbKey.Equals(input.DbKey))
                ) && 
                (
                    this.DeedsOfficeName == input.DeedsOfficeName ||
                    (this.DeedsOfficeName != null &&
                    this.DeedsOfficeName.Equals(input.DeedsOfficeName))
                ) && 
                (
                    this.DeedsOfficeNumber == input.DeedsOfficeNumber ||
                    (this.DeedsOfficeNumber != null &&
                    this.DeedsOfficeNumber.Equals(input.DeedsOfficeNumber))
                ) && 
                (
                    this.CurrentPropertyCount == input.CurrentPropertyCount ||
                    (this.CurrentPropertyCount != null &&
                    this.CurrentPropertyCount.Equals(input.CurrentPropertyCount))
                ) && 
                (
                    this.HistoricPropertyCount == input.HistoricPropertyCount ||
                    (this.HistoricPropertyCount != null &&
                    this.HistoricPropertyCount.Equals(input.HistoricPropertyCount))
                ) && 
                (
                    this.SubjectType == input.SubjectType ||
                    (this.SubjectType != null &&
                    this.SubjectType.Equals(input.SubjectType))
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
                if (this.DbKey != null)
                    hashCode = hashCode * 59 + this.DbKey.GetHashCode();
                if (this.DeedsOfficeName != null)
                    hashCode = hashCode * 59 + this.DeedsOfficeName.GetHashCode();
                if (this.DeedsOfficeNumber != null)
                    hashCode = hashCode * 59 + this.DeedsOfficeNumber.GetHashCode();
                if (this.CurrentPropertyCount != null)
                    hashCode = hashCode * 59 + this.CurrentPropertyCount.GetHashCode();
                if (this.HistoricPropertyCount != null)
                    hashCode = hashCode * 59 + this.HistoricPropertyCount.GetHashCode();
                if (this.SubjectType != null)
                    hashCode = hashCode * 59 + this.SubjectType.GetHashCode();
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
