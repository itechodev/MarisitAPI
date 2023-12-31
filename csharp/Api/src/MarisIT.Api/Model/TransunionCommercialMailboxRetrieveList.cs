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
    /// TransunionCommercialMailboxRetrieveList
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialMailboxRetrieveList :  IEquatable<TransunionCommercialMailboxRetrieveList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialMailboxRetrieveList" /> class.
        /// </summary>
        /// <param name="tickets">tickets.</param>
        public TransunionCommercialMailboxRetrieveList(List<string> tickets = default(List<string>))
        {
            this.Tickets = tickets;
            this.Tickets = tickets;
        }

        /// <summary>
        /// Gets or Sets Tickets
        /// </summary>
        [DataMember(Name="tickets", EmitDefaultValue=true)]
        public List<string> Tickets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialMailboxRetrieveList {\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
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
            return this.Equals(input as TransunionCommercialMailboxRetrieveList);
        }

        /// <summary>
        /// Returns true if TransunionCommercialMailboxRetrieveList instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialMailboxRetrieveList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialMailboxRetrieveList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tickets == input.Tickets ||
                    this.Tickets != null &&
                    input.Tickets != null &&
                    this.Tickets.SequenceEqual(input.Tickets)
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
                if (this.Tickets != null)
                    hashCode = hashCode * 59 + this.Tickets.GetHashCode();
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
