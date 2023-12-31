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
    /// WindeedOfficeSummaryProperty
    /// </summary>
    [DataContract]
    public partial class WindeedOfficeSummaryProperty :  IEquatable<WindeedOfficeSummaryProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindeedOfficeSummaryProperty" /> class.
        /// </summary>
        /// <param name="dbKey">dbKey.</param>
        /// <param name="titleDeed">titleDeed.</param>
        /// <param name="lpiCode">lpiCode.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="longitute">longitute.</param>
        /// <param name="latitude">latitude.</param>
        public WindeedOfficeSummaryProperty(string dbKey = default(string), WindeedOfficeSummaryTitleDeed titleDeed = default(WindeedOfficeSummaryTitleDeed), string lpiCode = default(string), string suburb = default(string), double? longitute = default(double?), double? latitude = default(double?))
        {
            this.DbKey = dbKey;
            this.LpiCode = lpiCode;
            this.Suburb = suburb;
            this.Longitute = longitute;
            this.Latitude = latitude;
            this.DbKey = dbKey;
            this.TitleDeed = titleDeed;
            this.LpiCode = lpiCode;
            this.Suburb = suburb;
            this.Longitute = longitute;
            this.Latitude = latitude;
        }

        /// <summary>
        /// Gets or Sets DbKey
        /// </summary>
        [DataMember(Name="dbKey", EmitDefaultValue=true)]
        public string DbKey { get; set; }

        /// <summary>
        /// Gets or Sets TitleDeed
        /// </summary>
        [DataMember(Name="titleDeed", EmitDefaultValue=false)]
        public WindeedOfficeSummaryTitleDeed TitleDeed { get; set; }

        /// <summary>
        /// Gets or Sets LpiCode
        /// </summary>
        [DataMember(Name="lpiCode", EmitDefaultValue=true)]
        public string LpiCode { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets Longitute
        /// </summary>
        [DataMember(Name="longitute", EmitDefaultValue=true)]
        public double? Longitute { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WindeedOfficeSummaryProperty {\n");
            sb.Append("  DbKey: ").Append(DbKey).Append("\n");
            sb.Append("  TitleDeed: ").Append(TitleDeed).Append("\n");
            sb.Append("  LpiCode: ").Append(LpiCode).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Longitute: ").Append(Longitute).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
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
            return this.Equals(input as WindeedOfficeSummaryProperty);
        }

        /// <summary>
        /// Returns true if WindeedOfficeSummaryProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of WindeedOfficeSummaryProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindeedOfficeSummaryProperty input)
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
                    this.TitleDeed == input.TitleDeed ||
                    (this.TitleDeed != null &&
                    this.TitleDeed.Equals(input.TitleDeed))
                ) && 
                (
                    this.LpiCode == input.LpiCode ||
                    (this.LpiCode != null &&
                    this.LpiCode.Equals(input.LpiCode))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Longitute == input.Longitute ||
                    (this.Longitute != null &&
                    this.Longitute.Equals(input.Longitute))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
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
                if (this.TitleDeed != null)
                    hashCode = hashCode * 59 + this.TitleDeed.GetHashCode();
                if (this.LpiCode != null)
                    hashCode = hashCode * 59 + this.LpiCode.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Longitute != null)
                    hashCode = hashCode * 59 + this.Longitute.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
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
