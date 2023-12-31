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
    /// XdsDirectorContactHistory
    /// </summary>
    [DataContract]
    public partial class XdsDirectorContactHistory :  IEquatable<XdsDirectorContactHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsDirectorContactHistory" /> class.
        /// </summary>
        /// <param name="displayText">displayText.</param>
        /// <param name="directorID">directorID.</param>
        /// <param name="bureauUpdate">bureauUpdate.</param>
        /// <param name="captureddate">captureddate.</param>
        /// <param name="contactType">contactType.</param>
        /// <param name="detail">detail.</param>
        public XdsDirectorContactHistory(string displayText = default(string), string directorID = default(string), string bureauUpdate = default(string), string captureddate = default(string), string contactType = default(string), string detail = default(string))
        {
            this.DisplayText = displayText;
            this.DirectorID = directorID;
            this.BureauUpdate = bureauUpdate;
            this.Captureddate = captureddate;
            this.ContactType = contactType;
            this.Detail = detail;
            this.DisplayText = displayText;
            this.DirectorID = directorID;
            this.BureauUpdate = bureauUpdate;
            this.Captureddate = captureddate;
            this.ContactType = contactType;
            this.Detail = detail;
        }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets DirectorID
        /// </summary>
        [DataMember(Name="directorID", EmitDefaultValue=true)]
        public string DirectorID { get; set; }

        /// <summary>
        /// Gets or Sets BureauUpdate
        /// </summary>
        [DataMember(Name="bureauUpdate", EmitDefaultValue=true)]
        public string BureauUpdate { get; set; }

        /// <summary>
        /// Gets or Sets Captureddate
        /// </summary>
        [DataMember(Name="captureddate", EmitDefaultValue=true)]
        public string Captureddate { get; set; }

        /// <summary>
        /// Gets or Sets ContactType
        /// </summary>
        [DataMember(Name="contactType", EmitDefaultValue=true)]
        public string ContactType { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name="detail", EmitDefaultValue=true)]
        public string Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsDirectorContactHistory {\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  DirectorID: ").Append(DirectorID).Append("\n");
            sb.Append("  BureauUpdate: ").Append(BureauUpdate).Append("\n");
            sb.Append("  Captureddate: ").Append(Captureddate).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as XdsDirectorContactHistory);
        }

        /// <summary>
        /// Returns true if XdsDirectorContactHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsDirectorContactHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsDirectorContactHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.DirectorID == input.DirectorID ||
                    (this.DirectorID != null &&
                    this.DirectorID.Equals(input.DirectorID))
                ) && 
                (
                    this.BureauUpdate == input.BureauUpdate ||
                    (this.BureauUpdate != null &&
                    this.BureauUpdate.Equals(input.BureauUpdate))
                ) && 
                (
                    this.Captureddate == input.Captureddate ||
                    (this.Captureddate != null &&
                    this.Captureddate.Equals(input.Captureddate))
                ) && 
                (
                    this.ContactType == input.ContactType ||
                    (this.ContactType != null &&
                    this.ContactType.Equals(input.ContactType))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.DirectorID != null)
                    hashCode = hashCode * 59 + this.DirectorID.GetHashCode();
                if (this.BureauUpdate != null)
                    hashCode = hashCode * 59 + this.BureauUpdate.GetHashCode();
                if (this.Captureddate != null)
                    hashCode = hashCode * 59 + this.Captureddate.GetHashCode();
                if (this.ContactType != null)
                    hashCode = hashCode * 59 + this.ContactType.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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
