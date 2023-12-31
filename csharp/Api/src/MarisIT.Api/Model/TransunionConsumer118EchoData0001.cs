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
    /// TransunionConsumer118EchoData0001
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EchoData0001 :  IEquatable<TransunionConsumer118EchoData0001>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EchoData0001" /> class.
        /// </summary>
        /// <param name="subscriberCode">subscriberCode.</param>
        /// <param name="clientReference">clientReference.</param>
        /// <param name="branchNumber">branchNumber.</param>
        /// <param name="batchNumber">batchNumber.</param>
        public TransunionConsumer118EchoData0001(string subscriberCode = default(string), string clientReference = default(string), string branchNumber = default(string), string batchNumber = default(string))
        {
            this.SubscriberCode = subscriberCode;
            this.ClientReference = clientReference;
            this.BranchNumber = branchNumber;
            this.BatchNumber = batchNumber;
            this.SubscriberCode = subscriberCode;
            this.ClientReference = clientReference;
            this.BranchNumber = branchNumber;
            this.BatchNumber = batchNumber;
        }

        /// <summary>
        /// Gets or Sets SubscriberCode
        /// </summary>
        [DataMember(Name="subscriberCode", EmitDefaultValue=true)]
        public string SubscriberCode { get; set; }

        /// <summary>
        /// Gets or Sets ClientReference
        /// </summary>
        [DataMember(Name="clientReference", EmitDefaultValue=true)]
        public string ClientReference { get; set; }

        /// <summary>
        /// Gets or Sets BranchNumber
        /// </summary>
        [DataMember(Name="branchNumber", EmitDefaultValue=true)]
        public string BranchNumber { get; set; }

        /// <summary>
        /// Gets or Sets BatchNumber
        /// </summary>
        [DataMember(Name="batchNumber", EmitDefaultValue=true)]
        public string BatchNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EchoData0001 {\n");
            sb.Append("  SubscriberCode: ").Append(SubscriberCode).Append("\n");
            sb.Append("  ClientReference: ").Append(ClientReference).Append("\n");
            sb.Append("  BranchNumber: ").Append(BranchNumber).Append("\n");
            sb.Append("  BatchNumber: ").Append(BatchNumber).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EchoData0001);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EchoData0001 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EchoData0001 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EchoData0001 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriberCode == input.SubscriberCode ||
                    (this.SubscriberCode != null &&
                    this.SubscriberCode.Equals(input.SubscriberCode))
                ) && 
                (
                    this.ClientReference == input.ClientReference ||
                    (this.ClientReference != null &&
                    this.ClientReference.Equals(input.ClientReference))
                ) && 
                (
                    this.BranchNumber == input.BranchNumber ||
                    (this.BranchNumber != null &&
                    this.BranchNumber.Equals(input.BranchNumber))
                ) && 
                (
                    this.BatchNumber == input.BatchNumber ||
                    (this.BatchNumber != null &&
                    this.BatchNumber.Equals(input.BatchNumber))
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
                if (this.SubscriberCode != null)
                    hashCode = hashCode * 59 + this.SubscriberCode.GetHashCode();
                if (this.ClientReference != null)
                    hashCode = hashCode * 59 + this.ClientReference.GetHashCode();
                if (this.BranchNumber != null)
                    hashCode = hashCode * 59 + this.BranchNumber.GetHashCode();
                if (this.BatchNumber != null)
                    hashCode = hashCode * 59 + this.BatchNumber.GetHashCode();
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
