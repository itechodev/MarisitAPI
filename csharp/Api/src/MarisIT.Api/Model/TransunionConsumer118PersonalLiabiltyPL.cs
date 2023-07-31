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
    /// TransunionConsumer118PersonalLiabiltyPL
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118PersonalLiabiltyPL :  IEquatable<TransunionConsumer118PersonalLiabiltyPL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118PersonalLiabiltyPL" /> class.
        /// </summary>
        /// <param name="person1Surname">person1Surname.</param>
        /// <param name="person1Initial1">person1Initial1.</param>
        /// <param name="person1Initial2">person1Initial2.</param>
        /// <param name="person1Initial3">person1Initial3.</param>
        /// <param name="person1RSAIDNumber">person1RSAIDNumber.</param>
        /// <param name="person1OtherIDNumber">person1OtherIDNumber.</param>
        /// <param name="person1DateOfBirth">person1DateOfBirth.</param>
        /// <param name="person1AddressLine1">person1AddressLine1.</param>
        /// <param name="person1AddressLine2">person1AddressLine2.</param>
        /// <param name="person1AddressLine3">person1AddressLine3.</param>
        /// <param name="person1AddressLine4">person1AddressLine4.</param>
        /// <param name="person1AddressPostalCode">person1AddressPostalCode.</param>
        /// <param name="person2Surname">person2Surname.</param>
        /// <param name="person2Initial1">person2Initial1.</param>
        /// <param name="person2Initial2">person2Initial2.</param>
        /// <param name="person2Initial3">person2Initial3.</param>
        /// <param name="person2RSAIDNumber">person2RSAIDNumber.</param>
        /// <param name="person2OtherIDNumber">person2OtherIDNumber.</param>
        /// <param name="person2DateOfBirth">person2DateOfBirth.</param>
        /// <param name="person2AddressLine1">person2AddressLine1.</param>
        /// <param name="person2AddressLine2">person2AddressLine2.</param>
        /// <param name="person2AddressLine3">person2AddressLine3.</param>
        /// <param name="person2AddressLine4">person2AddressLine4.</param>
        /// <param name="person2AddressPostalCode">person2AddressPostalCode.</param>
        /// <param name="person3Surname">person3Surname.</param>
        /// <param name="person3Initial1">person3Initial1.</param>
        /// <param name="person3Initial2">person3Initial2.</param>
        /// <param name="person3Initial3">person3Initial3.</param>
        /// <param name="person3RSAIDNumber">person3RSAIDNumber.</param>
        /// <param name="person3OtherIDNumber">person3OtherIDNumber.</param>
        /// <param name="person3DateOfBirth">person3DateOfBirth.</param>
        /// <param name="person3AddressLine1">person3AddressLine1.</param>
        /// <param name="person3AddressLine2">person3AddressLine2.</param>
        /// <param name="person3AddressLine3">person3AddressLine3.</param>
        /// <param name="person3AddressLine4">person3AddressLine4.</param>
        /// <param name="person3AddressPostalCode">person3AddressPostalCode.</param>
        public TransunionConsumer118PersonalLiabiltyPL(string person1Surname = default(string), string person1Initial1 = default(string), string person1Initial2 = default(string), string person1Initial3 = default(string), string person1RSAIDNumber = default(string), string person1OtherIDNumber = default(string), string person1DateOfBirth = default(string), string person1AddressLine1 = default(string), string person1AddressLine2 = default(string), string person1AddressLine3 = default(string), string person1AddressLine4 = default(string), string person1AddressPostalCode = default(string), string person2Surname = default(string), string person2Initial1 = default(string), string person2Initial2 = default(string), string person2Initial3 = default(string), string person2RSAIDNumber = default(string), string person2OtherIDNumber = default(string), string person2DateOfBirth = default(string), string person2AddressLine1 = default(string), string person2AddressLine2 = default(string), string person2AddressLine3 = default(string), string person2AddressLine4 = default(string), string person2AddressPostalCode = default(string), string person3Surname = default(string), string person3Initial1 = default(string), string person3Initial2 = default(string), string person3Initial3 = default(string), string person3RSAIDNumber = default(string), string person3OtherIDNumber = default(string), string person3DateOfBirth = default(string), string person3AddressLine1 = default(string), string person3AddressLine2 = default(string), string person3AddressLine3 = default(string), string person3AddressLine4 = default(string), string person3AddressPostalCode = default(string))
        {
            this.Person1Surname = person1Surname;
            this.Person1Initial1 = person1Initial1;
            this.Person1Initial2 = person1Initial2;
            this.Person1Initial3 = person1Initial3;
            this.Person1RSAIDNumber = person1RSAIDNumber;
            this.Person1OtherIDNumber = person1OtherIDNumber;
            this.Person1DateOfBirth = person1DateOfBirth;
            this.Person1AddressLine1 = person1AddressLine1;
            this.Person1AddressLine2 = person1AddressLine2;
            this.Person1AddressLine3 = person1AddressLine3;
            this.Person1AddressLine4 = person1AddressLine4;
            this.Person1AddressPostalCode = person1AddressPostalCode;
            this.Person2Surname = person2Surname;
            this.Person2Initial1 = person2Initial1;
            this.Person2Initial2 = person2Initial2;
            this.Person2Initial3 = person2Initial3;
            this.Person2RSAIDNumber = person2RSAIDNumber;
            this.Person2OtherIDNumber = person2OtherIDNumber;
            this.Person2DateOfBirth = person2DateOfBirth;
            this.Person2AddressLine1 = person2AddressLine1;
            this.Person2AddressLine2 = person2AddressLine2;
            this.Person2AddressLine3 = person2AddressLine3;
            this.Person2AddressLine4 = person2AddressLine4;
            this.Person2AddressPostalCode = person2AddressPostalCode;
            this.Person3Surname = person3Surname;
            this.Person3Initial1 = person3Initial1;
            this.Person3Initial2 = person3Initial2;
            this.Person3Initial3 = person3Initial3;
            this.Person3RSAIDNumber = person3RSAIDNumber;
            this.Person3OtherIDNumber = person3OtherIDNumber;
            this.Person3DateOfBirth = person3DateOfBirth;
            this.Person3AddressLine1 = person3AddressLine1;
            this.Person3AddressLine2 = person3AddressLine2;
            this.Person3AddressLine3 = person3AddressLine3;
            this.Person3AddressLine4 = person3AddressLine4;
            this.Person3AddressPostalCode = person3AddressPostalCode;
            this.Person1Surname = person1Surname;
            this.Person1Initial1 = person1Initial1;
            this.Person1Initial2 = person1Initial2;
            this.Person1Initial3 = person1Initial3;
            this.Person1RSAIDNumber = person1RSAIDNumber;
            this.Person1OtherIDNumber = person1OtherIDNumber;
            this.Person1DateOfBirth = person1DateOfBirth;
            this.Person1AddressLine1 = person1AddressLine1;
            this.Person1AddressLine2 = person1AddressLine2;
            this.Person1AddressLine3 = person1AddressLine3;
            this.Person1AddressLine4 = person1AddressLine4;
            this.Person1AddressPostalCode = person1AddressPostalCode;
            this.Person2Surname = person2Surname;
            this.Person2Initial1 = person2Initial1;
            this.Person2Initial2 = person2Initial2;
            this.Person2Initial3 = person2Initial3;
            this.Person2RSAIDNumber = person2RSAIDNumber;
            this.Person2OtherIDNumber = person2OtherIDNumber;
            this.Person2DateOfBirth = person2DateOfBirth;
            this.Person2AddressLine1 = person2AddressLine1;
            this.Person2AddressLine2 = person2AddressLine2;
            this.Person2AddressLine3 = person2AddressLine3;
            this.Person2AddressLine4 = person2AddressLine4;
            this.Person2AddressPostalCode = person2AddressPostalCode;
            this.Person3Surname = person3Surname;
            this.Person3Initial1 = person3Initial1;
            this.Person3Initial2 = person3Initial2;
            this.Person3Initial3 = person3Initial3;
            this.Person3RSAIDNumber = person3RSAIDNumber;
            this.Person3OtherIDNumber = person3OtherIDNumber;
            this.Person3DateOfBirth = person3DateOfBirth;
            this.Person3AddressLine1 = person3AddressLine1;
            this.Person3AddressLine2 = person3AddressLine2;
            this.Person3AddressLine3 = person3AddressLine3;
            this.Person3AddressLine4 = person3AddressLine4;
            this.Person3AddressPostalCode = person3AddressPostalCode;
        }

        /// <summary>
        /// Gets or Sets Person1Surname
        /// </summary>
        [DataMember(Name="person1Surname", EmitDefaultValue=true)]
        public string Person1Surname { get; set; }

        /// <summary>
        /// Gets or Sets Person1Initial1
        /// </summary>
        [DataMember(Name="person1Initial1", EmitDefaultValue=true)]
        public string Person1Initial1 { get; set; }

        /// <summary>
        /// Gets or Sets Person1Initial2
        /// </summary>
        [DataMember(Name="person1Initial2", EmitDefaultValue=true)]
        public string Person1Initial2 { get; set; }

        /// <summary>
        /// Gets or Sets Person1Initial3
        /// </summary>
        [DataMember(Name="person1Initial3", EmitDefaultValue=true)]
        public string Person1Initial3 { get; set; }

        /// <summary>
        /// Gets or Sets Person1RSAIDNumber
        /// </summary>
        [DataMember(Name="person1RSAIDNumber", EmitDefaultValue=true)]
        public string Person1RSAIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Person1OtherIDNumber
        /// </summary>
        [DataMember(Name="person1OtherIDNumber", EmitDefaultValue=true)]
        public string Person1OtherIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Person1DateOfBirth
        /// </summary>
        [DataMember(Name="person1DateOfBirth", EmitDefaultValue=true)]
        public string Person1DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Person1AddressLine1
        /// </summary>
        [DataMember(Name="person1AddressLine1", EmitDefaultValue=true)]
        public string Person1AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets Person1AddressLine2
        /// </summary>
        [DataMember(Name="person1AddressLine2", EmitDefaultValue=true)]
        public string Person1AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets Person1AddressLine3
        /// </summary>
        [DataMember(Name="person1AddressLine3", EmitDefaultValue=true)]
        public string Person1AddressLine3 { get; set; }

        /// <summary>
        /// Gets or Sets Person1AddressLine4
        /// </summary>
        [DataMember(Name="person1AddressLine4", EmitDefaultValue=true)]
        public string Person1AddressLine4 { get; set; }

        /// <summary>
        /// Gets or Sets Person1AddressPostalCode
        /// </summary>
        [DataMember(Name="person1AddressPostalCode", EmitDefaultValue=true)]
        public string Person1AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Person2Surname
        /// </summary>
        [DataMember(Name="person2Surname", EmitDefaultValue=true)]
        public string Person2Surname { get; set; }

        /// <summary>
        /// Gets or Sets Person2Initial1
        /// </summary>
        [DataMember(Name="person2Initial1", EmitDefaultValue=true)]
        public string Person2Initial1 { get; set; }

        /// <summary>
        /// Gets or Sets Person2Initial2
        /// </summary>
        [DataMember(Name="person2Initial2", EmitDefaultValue=true)]
        public string Person2Initial2 { get; set; }

        /// <summary>
        /// Gets or Sets Person2Initial3
        /// </summary>
        [DataMember(Name="person2Initial3", EmitDefaultValue=true)]
        public string Person2Initial3 { get; set; }

        /// <summary>
        /// Gets or Sets Person2RSAIDNumber
        /// </summary>
        [DataMember(Name="person2RSAIDNumber", EmitDefaultValue=true)]
        public string Person2RSAIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Person2OtherIDNumber
        /// </summary>
        [DataMember(Name="person2OtherIDNumber", EmitDefaultValue=true)]
        public string Person2OtherIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Person2DateOfBirth
        /// </summary>
        [DataMember(Name="person2DateOfBirth", EmitDefaultValue=true)]
        public string Person2DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Person2AddressLine1
        /// </summary>
        [DataMember(Name="person2AddressLine1", EmitDefaultValue=true)]
        public string Person2AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets Person2AddressLine2
        /// </summary>
        [DataMember(Name="person2AddressLine2", EmitDefaultValue=true)]
        public string Person2AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets Person2AddressLine3
        /// </summary>
        [DataMember(Name="person2AddressLine3", EmitDefaultValue=true)]
        public string Person2AddressLine3 { get; set; }

        /// <summary>
        /// Gets or Sets Person2AddressLine4
        /// </summary>
        [DataMember(Name="person2AddressLine4", EmitDefaultValue=true)]
        public string Person2AddressLine4 { get; set; }

        /// <summary>
        /// Gets or Sets Person2AddressPostalCode
        /// </summary>
        [DataMember(Name="person2AddressPostalCode", EmitDefaultValue=true)]
        public string Person2AddressPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Person3Surname
        /// </summary>
        [DataMember(Name="person3Surname", EmitDefaultValue=true)]
        public string Person3Surname { get; set; }

        /// <summary>
        /// Gets or Sets Person3Initial1
        /// </summary>
        [DataMember(Name="person3Initial1", EmitDefaultValue=true)]
        public string Person3Initial1 { get; set; }

        /// <summary>
        /// Gets or Sets Person3Initial2
        /// </summary>
        [DataMember(Name="person3Initial2", EmitDefaultValue=true)]
        public string Person3Initial2 { get; set; }

        /// <summary>
        /// Gets or Sets Person3Initial3
        /// </summary>
        [DataMember(Name="person3Initial3", EmitDefaultValue=true)]
        public string Person3Initial3 { get; set; }

        /// <summary>
        /// Gets or Sets Person3RSAIDNumber
        /// </summary>
        [DataMember(Name="person3RSAIDNumber", EmitDefaultValue=true)]
        public string Person3RSAIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Person3OtherIDNumber
        /// </summary>
        [DataMember(Name="person3OtherIDNumber", EmitDefaultValue=true)]
        public string Person3OtherIDNumber { get; set; }

        /// <summary>
        /// Gets or Sets Person3DateOfBirth
        /// </summary>
        [DataMember(Name="person3DateOfBirth", EmitDefaultValue=true)]
        public string Person3DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Person3AddressLine1
        /// </summary>
        [DataMember(Name="person3AddressLine1", EmitDefaultValue=true)]
        public string Person3AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets Person3AddressLine2
        /// </summary>
        [DataMember(Name="person3AddressLine2", EmitDefaultValue=true)]
        public string Person3AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets Person3AddressLine3
        /// </summary>
        [DataMember(Name="person3AddressLine3", EmitDefaultValue=true)]
        public string Person3AddressLine3 { get; set; }

        /// <summary>
        /// Gets or Sets Person3AddressLine4
        /// </summary>
        [DataMember(Name="person3AddressLine4", EmitDefaultValue=true)]
        public string Person3AddressLine4 { get; set; }

        /// <summary>
        /// Gets or Sets Person3AddressPostalCode
        /// </summary>
        [DataMember(Name="person3AddressPostalCode", EmitDefaultValue=true)]
        public string Person3AddressPostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118PersonalLiabiltyPL {\n");
            sb.Append("  Person1Surname: ").Append(Person1Surname).Append("\n");
            sb.Append("  Person1Initial1: ").Append(Person1Initial1).Append("\n");
            sb.Append("  Person1Initial2: ").Append(Person1Initial2).Append("\n");
            sb.Append("  Person1Initial3: ").Append(Person1Initial3).Append("\n");
            sb.Append("  Person1RSAIDNumber: ").Append(Person1RSAIDNumber).Append("\n");
            sb.Append("  Person1OtherIDNumber: ").Append(Person1OtherIDNumber).Append("\n");
            sb.Append("  Person1DateOfBirth: ").Append(Person1DateOfBirth).Append("\n");
            sb.Append("  Person1AddressLine1: ").Append(Person1AddressLine1).Append("\n");
            sb.Append("  Person1AddressLine2: ").Append(Person1AddressLine2).Append("\n");
            sb.Append("  Person1AddressLine3: ").Append(Person1AddressLine3).Append("\n");
            sb.Append("  Person1AddressLine4: ").Append(Person1AddressLine4).Append("\n");
            sb.Append("  Person1AddressPostalCode: ").Append(Person1AddressPostalCode).Append("\n");
            sb.Append("  Person2Surname: ").Append(Person2Surname).Append("\n");
            sb.Append("  Person2Initial1: ").Append(Person2Initial1).Append("\n");
            sb.Append("  Person2Initial2: ").Append(Person2Initial2).Append("\n");
            sb.Append("  Person2Initial3: ").Append(Person2Initial3).Append("\n");
            sb.Append("  Person2RSAIDNumber: ").Append(Person2RSAIDNumber).Append("\n");
            sb.Append("  Person2OtherIDNumber: ").Append(Person2OtherIDNumber).Append("\n");
            sb.Append("  Person2DateOfBirth: ").Append(Person2DateOfBirth).Append("\n");
            sb.Append("  Person2AddressLine1: ").Append(Person2AddressLine1).Append("\n");
            sb.Append("  Person2AddressLine2: ").Append(Person2AddressLine2).Append("\n");
            sb.Append("  Person2AddressLine3: ").Append(Person2AddressLine3).Append("\n");
            sb.Append("  Person2AddressLine4: ").Append(Person2AddressLine4).Append("\n");
            sb.Append("  Person2AddressPostalCode: ").Append(Person2AddressPostalCode).Append("\n");
            sb.Append("  Person3Surname: ").Append(Person3Surname).Append("\n");
            sb.Append("  Person3Initial1: ").Append(Person3Initial1).Append("\n");
            sb.Append("  Person3Initial2: ").Append(Person3Initial2).Append("\n");
            sb.Append("  Person3Initial3: ").Append(Person3Initial3).Append("\n");
            sb.Append("  Person3RSAIDNumber: ").Append(Person3RSAIDNumber).Append("\n");
            sb.Append("  Person3OtherIDNumber: ").Append(Person3OtherIDNumber).Append("\n");
            sb.Append("  Person3DateOfBirth: ").Append(Person3DateOfBirth).Append("\n");
            sb.Append("  Person3AddressLine1: ").Append(Person3AddressLine1).Append("\n");
            sb.Append("  Person3AddressLine2: ").Append(Person3AddressLine2).Append("\n");
            sb.Append("  Person3AddressLine3: ").Append(Person3AddressLine3).Append("\n");
            sb.Append("  Person3AddressLine4: ").Append(Person3AddressLine4).Append("\n");
            sb.Append("  Person3AddressPostalCode: ").Append(Person3AddressPostalCode).Append("\n");
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
            return this.Equals(input as TransunionConsumer118PersonalLiabiltyPL);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118PersonalLiabiltyPL instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118PersonalLiabiltyPL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118PersonalLiabiltyPL input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Person1Surname == input.Person1Surname ||
                    (this.Person1Surname != null &&
                    this.Person1Surname.Equals(input.Person1Surname))
                ) && 
                (
                    this.Person1Initial1 == input.Person1Initial1 ||
                    (this.Person1Initial1 != null &&
                    this.Person1Initial1.Equals(input.Person1Initial1))
                ) && 
                (
                    this.Person1Initial2 == input.Person1Initial2 ||
                    (this.Person1Initial2 != null &&
                    this.Person1Initial2.Equals(input.Person1Initial2))
                ) && 
                (
                    this.Person1Initial3 == input.Person1Initial3 ||
                    (this.Person1Initial3 != null &&
                    this.Person1Initial3.Equals(input.Person1Initial3))
                ) && 
                (
                    this.Person1RSAIDNumber == input.Person1RSAIDNumber ||
                    (this.Person1RSAIDNumber != null &&
                    this.Person1RSAIDNumber.Equals(input.Person1RSAIDNumber))
                ) && 
                (
                    this.Person1OtherIDNumber == input.Person1OtherIDNumber ||
                    (this.Person1OtherIDNumber != null &&
                    this.Person1OtherIDNumber.Equals(input.Person1OtherIDNumber))
                ) && 
                (
                    this.Person1DateOfBirth == input.Person1DateOfBirth ||
                    (this.Person1DateOfBirth != null &&
                    this.Person1DateOfBirth.Equals(input.Person1DateOfBirth))
                ) && 
                (
                    this.Person1AddressLine1 == input.Person1AddressLine1 ||
                    (this.Person1AddressLine1 != null &&
                    this.Person1AddressLine1.Equals(input.Person1AddressLine1))
                ) && 
                (
                    this.Person1AddressLine2 == input.Person1AddressLine2 ||
                    (this.Person1AddressLine2 != null &&
                    this.Person1AddressLine2.Equals(input.Person1AddressLine2))
                ) && 
                (
                    this.Person1AddressLine3 == input.Person1AddressLine3 ||
                    (this.Person1AddressLine3 != null &&
                    this.Person1AddressLine3.Equals(input.Person1AddressLine3))
                ) && 
                (
                    this.Person1AddressLine4 == input.Person1AddressLine4 ||
                    (this.Person1AddressLine4 != null &&
                    this.Person1AddressLine4.Equals(input.Person1AddressLine4))
                ) && 
                (
                    this.Person1AddressPostalCode == input.Person1AddressPostalCode ||
                    (this.Person1AddressPostalCode != null &&
                    this.Person1AddressPostalCode.Equals(input.Person1AddressPostalCode))
                ) && 
                (
                    this.Person2Surname == input.Person2Surname ||
                    (this.Person2Surname != null &&
                    this.Person2Surname.Equals(input.Person2Surname))
                ) && 
                (
                    this.Person2Initial1 == input.Person2Initial1 ||
                    (this.Person2Initial1 != null &&
                    this.Person2Initial1.Equals(input.Person2Initial1))
                ) && 
                (
                    this.Person2Initial2 == input.Person2Initial2 ||
                    (this.Person2Initial2 != null &&
                    this.Person2Initial2.Equals(input.Person2Initial2))
                ) && 
                (
                    this.Person2Initial3 == input.Person2Initial3 ||
                    (this.Person2Initial3 != null &&
                    this.Person2Initial3.Equals(input.Person2Initial3))
                ) && 
                (
                    this.Person2RSAIDNumber == input.Person2RSAIDNumber ||
                    (this.Person2RSAIDNumber != null &&
                    this.Person2RSAIDNumber.Equals(input.Person2RSAIDNumber))
                ) && 
                (
                    this.Person2OtherIDNumber == input.Person2OtherIDNumber ||
                    (this.Person2OtherIDNumber != null &&
                    this.Person2OtherIDNumber.Equals(input.Person2OtherIDNumber))
                ) && 
                (
                    this.Person2DateOfBirth == input.Person2DateOfBirth ||
                    (this.Person2DateOfBirth != null &&
                    this.Person2DateOfBirth.Equals(input.Person2DateOfBirth))
                ) && 
                (
                    this.Person2AddressLine1 == input.Person2AddressLine1 ||
                    (this.Person2AddressLine1 != null &&
                    this.Person2AddressLine1.Equals(input.Person2AddressLine1))
                ) && 
                (
                    this.Person2AddressLine2 == input.Person2AddressLine2 ||
                    (this.Person2AddressLine2 != null &&
                    this.Person2AddressLine2.Equals(input.Person2AddressLine2))
                ) && 
                (
                    this.Person2AddressLine3 == input.Person2AddressLine3 ||
                    (this.Person2AddressLine3 != null &&
                    this.Person2AddressLine3.Equals(input.Person2AddressLine3))
                ) && 
                (
                    this.Person2AddressLine4 == input.Person2AddressLine4 ||
                    (this.Person2AddressLine4 != null &&
                    this.Person2AddressLine4.Equals(input.Person2AddressLine4))
                ) && 
                (
                    this.Person2AddressPostalCode == input.Person2AddressPostalCode ||
                    (this.Person2AddressPostalCode != null &&
                    this.Person2AddressPostalCode.Equals(input.Person2AddressPostalCode))
                ) && 
                (
                    this.Person3Surname == input.Person3Surname ||
                    (this.Person3Surname != null &&
                    this.Person3Surname.Equals(input.Person3Surname))
                ) && 
                (
                    this.Person3Initial1 == input.Person3Initial1 ||
                    (this.Person3Initial1 != null &&
                    this.Person3Initial1.Equals(input.Person3Initial1))
                ) && 
                (
                    this.Person3Initial2 == input.Person3Initial2 ||
                    (this.Person3Initial2 != null &&
                    this.Person3Initial2.Equals(input.Person3Initial2))
                ) && 
                (
                    this.Person3Initial3 == input.Person3Initial3 ||
                    (this.Person3Initial3 != null &&
                    this.Person3Initial3.Equals(input.Person3Initial3))
                ) && 
                (
                    this.Person3RSAIDNumber == input.Person3RSAIDNumber ||
                    (this.Person3RSAIDNumber != null &&
                    this.Person3RSAIDNumber.Equals(input.Person3RSAIDNumber))
                ) && 
                (
                    this.Person3OtherIDNumber == input.Person3OtherIDNumber ||
                    (this.Person3OtherIDNumber != null &&
                    this.Person3OtherIDNumber.Equals(input.Person3OtherIDNumber))
                ) && 
                (
                    this.Person3DateOfBirth == input.Person3DateOfBirth ||
                    (this.Person3DateOfBirth != null &&
                    this.Person3DateOfBirth.Equals(input.Person3DateOfBirth))
                ) && 
                (
                    this.Person3AddressLine1 == input.Person3AddressLine1 ||
                    (this.Person3AddressLine1 != null &&
                    this.Person3AddressLine1.Equals(input.Person3AddressLine1))
                ) && 
                (
                    this.Person3AddressLine2 == input.Person3AddressLine2 ||
                    (this.Person3AddressLine2 != null &&
                    this.Person3AddressLine2.Equals(input.Person3AddressLine2))
                ) && 
                (
                    this.Person3AddressLine3 == input.Person3AddressLine3 ||
                    (this.Person3AddressLine3 != null &&
                    this.Person3AddressLine3.Equals(input.Person3AddressLine3))
                ) && 
                (
                    this.Person3AddressLine4 == input.Person3AddressLine4 ||
                    (this.Person3AddressLine4 != null &&
                    this.Person3AddressLine4.Equals(input.Person3AddressLine4))
                ) && 
                (
                    this.Person3AddressPostalCode == input.Person3AddressPostalCode ||
                    (this.Person3AddressPostalCode != null &&
                    this.Person3AddressPostalCode.Equals(input.Person3AddressPostalCode))
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
                if (this.Person1Surname != null)
                    hashCode = hashCode * 59 + this.Person1Surname.GetHashCode();
                if (this.Person1Initial1 != null)
                    hashCode = hashCode * 59 + this.Person1Initial1.GetHashCode();
                if (this.Person1Initial2 != null)
                    hashCode = hashCode * 59 + this.Person1Initial2.GetHashCode();
                if (this.Person1Initial3 != null)
                    hashCode = hashCode * 59 + this.Person1Initial3.GetHashCode();
                if (this.Person1RSAIDNumber != null)
                    hashCode = hashCode * 59 + this.Person1RSAIDNumber.GetHashCode();
                if (this.Person1OtherIDNumber != null)
                    hashCode = hashCode * 59 + this.Person1OtherIDNumber.GetHashCode();
                if (this.Person1DateOfBirth != null)
                    hashCode = hashCode * 59 + this.Person1DateOfBirth.GetHashCode();
                if (this.Person1AddressLine1 != null)
                    hashCode = hashCode * 59 + this.Person1AddressLine1.GetHashCode();
                if (this.Person1AddressLine2 != null)
                    hashCode = hashCode * 59 + this.Person1AddressLine2.GetHashCode();
                if (this.Person1AddressLine3 != null)
                    hashCode = hashCode * 59 + this.Person1AddressLine3.GetHashCode();
                if (this.Person1AddressLine4 != null)
                    hashCode = hashCode * 59 + this.Person1AddressLine4.GetHashCode();
                if (this.Person1AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.Person1AddressPostalCode.GetHashCode();
                if (this.Person2Surname != null)
                    hashCode = hashCode * 59 + this.Person2Surname.GetHashCode();
                if (this.Person2Initial1 != null)
                    hashCode = hashCode * 59 + this.Person2Initial1.GetHashCode();
                if (this.Person2Initial2 != null)
                    hashCode = hashCode * 59 + this.Person2Initial2.GetHashCode();
                if (this.Person2Initial3 != null)
                    hashCode = hashCode * 59 + this.Person2Initial3.GetHashCode();
                if (this.Person2RSAIDNumber != null)
                    hashCode = hashCode * 59 + this.Person2RSAIDNumber.GetHashCode();
                if (this.Person2OtherIDNumber != null)
                    hashCode = hashCode * 59 + this.Person2OtherIDNumber.GetHashCode();
                if (this.Person2DateOfBirth != null)
                    hashCode = hashCode * 59 + this.Person2DateOfBirth.GetHashCode();
                if (this.Person2AddressLine1 != null)
                    hashCode = hashCode * 59 + this.Person2AddressLine1.GetHashCode();
                if (this.Person2AddressLine2 != null)
                    hashCode = hashCode * 59 + this.Person2AddressLine2.GetHashCode();
                if (this.Person2AddressLine3 != null)
                    hashCode = hashCode * 59 + this.Person2AddressLine3.GetHashCode();
                if (this.Person2AddressLine4 != null)
                    hashCode = hashCode * 59 + this.Person2AddressLine4.GetHashCode();
                if (this.Person2AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.Person2AddressPostalCode.GetHashCode();
                if (this.Person3Surname != null)
                    hashCode = hashCode * 59 + this.Person3Surname.GetHashCode();
                if (this.Person3Initial1 != null)
                    hashCode = hashCode * 59 + this.Person3Initial1.GetHashCode();
                if (this.Person3Initial2 != null)
                    hashCode = hashCode * 59 + this.Person3Initial2.GetHashCode();
                if (this.Person3Initial3 != null)
                    hashCode = hashCode * 59 + this.Person3Initial3.GetHashCode();
                if (this.Person3RSAIDNumber != null)
                    hashCode = hashCode * 59 + this.Person3RSAIDNumber.GetHashCode();
                if (this.Person3OtherIDNumber != null)
                    hashCode = hashCode * 59 + this.Person3OtherIDNumber.GetHashCode();
                if (this.Person3DateOfBirth != null)
                    hashCode = hashCode * 59 + this.Person3DateOfBirth.GetHashCode();
                if (this.Person3AddressLine1 != null)
                    hashCode = hashCode * 59 + this.Person3AddressLine1.GetHashCode();
                if (this.Person3AddressLine2 != null)
                    hashCode = hashCode * 59 + this.Person3AddressLine2.GetHashCode();
                if (this.Person3AddressLine3 != null)
                    hashCode = hashCode * 59 + this.Person3AddressLine3.GetHashCode();
                if (this.Person3AddressLine4 != null)
                    hashCode = hashCode * 59 + this.Person3AddressLine4.GetHashCode();
                if (this.Person3AddressPostalCode != null)
                    hashCode = hashCode * 59 + this.Person3AddressPostalCode.GetHashCode();
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
