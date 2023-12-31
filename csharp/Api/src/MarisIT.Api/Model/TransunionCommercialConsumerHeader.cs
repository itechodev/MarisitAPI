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
    /// TransunionCommercialConsumerHeader
    /// </summary>
    [DataContract]
    public partial class TransunionCommercialConsumerHeader :  IEquatable<TransunionCommercialConsumerHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionCommercialConsumerHeader" /> class.
        /// </summary>
        /// <param name="majorProduct">majorProduct.</param>
        /// <param name="consumerNumber">consumerNumber.</param>
        /// <param name="surname">surname.</param>
        /// <param name="forename1">forename1.</param>
        /// <param name="forename2">forename2.</param>
        /// <param name="forename3">forename3.</param>
        /// <param name="akaName1">akaName1.</param>
        /// <param name="akaDate1">akaDate1.</param>
        /// <param name="akaName2">akaName2.</param>
        /// <param name="akaDate2">akaDate2.</param>
        /// <param name="akaName3">akaName3.</param>
        /// <param name="akaDate3">akaDate3.</param>
        /// <param name="spouseForename">spouseForename.</param>
        /// <param name="addressDate1">addressDate1.</param>
        /// <param name="address1">address1.</param>
        /// <param name="addressDate2">addressDate2.</param>
        /// <param name="address2">address2.</param>
        /// <param name="addressDate3">addressDate3.</param>
        /// <param name="address3">address3.</param>
        /// <param name="addressDate4">addressDate4.</param>
        /// <param name="address4">address4.</param>
        /// <param name="employmentDate1">employmentDate1.</param>
        /// <param name="occupation1">occupation1.</param>
        /// <param name="employer1">employer1.</param>
        /// <param name="employmentDate2">employmentDate2.</param>
        /// <param name="occupation2">occupation2.</param>
        /// <param name="employer2">employer2.</param>
        /// <param name="employmentDate3">employmentDate3.</param>
        /// <param name="occupation3">occupation3.</param>
        /// <param name="employer3">employer3.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="idNo1">idNo1.</param>
        /// <param name="idNo2">idNo2.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="workPhoneCode">workPhoneCode.</param>
        /// <param name="workPhoneNumber">workPhoneNumber.</param>
        /// <param name="homePhoneCode">homePhoneCode.</param>
        /// <param name="homePhoneNumber">homePhoneNumber.</param>
        /// <param name="ticketNumber">ticketNumber.</param>
        /// <param name="message">message.</param>
        /// <param name="match">match.</param>
        /// <param name="disputeDate">disputeDate.</param>
        /// <param name="debtCouncilDate">debtCouncilDate.</param>
        public TransunionCommercialConsumerHeader(string majorProduct = default(string), string consumerNumber = default(string), string surname = default(string), string forename1 = default(string), string forename2 = default(string), string forename3 = default(string), string akaName1 = default(string), string akaDate1 = default(string), string akaName2 = default(string), string akaDate2 = default(string), string akaName3 = default(string), string akaDate3 = default(string), string spouseForename = default(string), string addressDate1 = default(string), string address1 = default(string), string addressDate2 = default(string), string address2 = default(string), string addressDate3 = default(string), string address3 = default(string), string addressDate4 = default(string), string address4 = default(string), string employmentDate1 = default(string), string occupation1 = default(string), string employer1 = default(string), string employmentDate2 = default(string), string occupation2 = default(string), string employer2 = default(string), string employmentDate3 = default(string), string occupation3 = default(string), string employer3 = default(string), string remarks = default(string), string idNo1 = default(string), string idNo2 = default(string), string dateOfBirth = default(string), string workPhoneCode = default(string), string workPhoneNumber = default(string), string homePhoneCode = default(string), string homePhoneNumber = default(string), string ticketNumber = default(string), string message = default(string), string match = default(string), string disputeDate = default(string), string debtCouncilDate = default(string))
        {
            this.MajorProduct = majorProduct;
            this.ConsumerNumber = consumerNumber;
            this.Surname = surname;
            this.Forename1 = forename1;
            this.Forename2 = forename2;
            this.Forename3 = forename3;
            this.AkaName1 = akaName1;
            this.AkaDate1 = akaDate1;
            this.AkaName2 = akaName2;
            this.AkaDate2 = akaDate2;
            this.AkaName3 = akaName3;
            this.AkaDate3 = akaDate3;
            this.SpouseForename = spouseForename;
            this.AddressDate1 = addressDate1;
            this.Address1 = address1;
            this.AddressDate2 = addressDate2;
            this.Address2 = address2;
            this.AddressDate3 = addressDate3;
            this.Address3 = address3;
            this.AddressDate4 = addressDate4;
            this.Address4 = address4;
            this.EmploymentDate1 = employmentDate1;
            this.Occupation1 = occupation1;
            this.Employer1 = employer1;
            this.EmploymentDate2 = employmentDate2;
            this.Occupation2 = occupation2;
            this.Employer2 = employer2;
            this.EmploymentDate3 = employmentDate3;
            this.Occupation3 = occupation3;
            this.Employer3 = employer3;
            this.Remarks = remarks;
            this.IdNo1 = idNo1;
            this.IdNo2 = idNo2;
            this.DateOfBirth = dateOfBirth;
            this.WorkPhoneCode = workPhoneCode;
            this.WorkPhoneNumber = workPhoneNumber;
            this.HomePhoneCode = homePhoneCode;
            this.HomePhoneNumber = homePhoneNumber;
            this.TicketNumber = ticketNumber;
            this.Message = message;
            this.Match = match;
            this.DisputeDate = disputeDate;
            this.DebtCouncilDate = debtCouncilDate;
            this.MajorProduct = majorProduct;
            this.ConsumerNumber = consumerNumber;
            this.Surname = surname;
            this.Forename1 = forename1;
            this.Forename2 = forename2;
            this.Forename3 = forename3;
            this.AkaName1 = akaName1;
            this.AkaDate1 = akaDate1;
            this.AkaName2 = akaName2;
            this.AkaDate2 = akaDate2;
            this.AkaName3 = akaName3;
            this.AkaDate3 = akaDate3;
            this.SpouseForename = spouseForename;
            this.AddressDate1 = addressDate1;
            this.Address1 = address1;
            this.AddressDate2 = addressDate2;
            this.Address2 = address2;
            this.AddressDate3 = addressDate3;
            this.Address3 = address3;
            this.AddressDate4 = addressDate4;
            this.Address4 = address4;
            this.EmploymentDate1 = employmentDate1;
            this.Occupation1 = occupation1;
            this.Employer1 = employer1;
            this.EmploymentDate2 = employmentDate2;
            this.Occupation2 = occupation2;
            this.Employer2 = employer2;
            this.EmploymentDate3 = employmentDate3;
            this.Occupation3 = occupation3;
            this.Employer3 = employer3;
            this.Remarks = remarks;
            this.IdNo1 = idNo1;
            this.IdNo2 = idNo2;
            this.DateOfBirth = dateOfBirth;
            this.WorkPhoneCode = workPhoneCode;
            this.WorkPhoneNumber = workPhoneNumber;
            this.HomePhoneCode = homePhoneCode;
            this.HomePhoneNumber = homePhoneNumber;
            this.TicketNumber = ticketNumber;
            this.Message = message;
            this.Match = match;
            this.DisputeDate = disputeDate;
            this.DebtCouncilDate = debtCouncilDate;
        }

        /// <summary>
        /// Gets or Sets MajorProduct
        /// </summary>
        [DataMember(Name="majorProduct", EmitDefaultValue=true)]
        public string MajorProduct { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerNumber
        /// </summary>
        [DataMember(Name="consumerNumber", EmitDefaultValue=true)]
        public string ConsumerNumber { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets Forename1
        /// </summary>
        [DataMember(Name="forename1", EmitDefaultValue=true)]
        public string Forename1 { get; set; }

        /// <summary>
        /// Gets or Sets Forename2
        /// </summary>
        [DataMember(Name="forename2", EmitDefaultValue=true)]
        public string Forename2 { get; set; }

        /// <summary>
        /// Gets or Sets Forename3
        /// </summary>
        [DataMember(Name="forename3", EmitDefaultValue=true)]
        public string Forename3 { get; set; }

        /// <summary>
        /// Gets or Sets AkaName1
        /// </summary>
        [DataMember(Name="akaName1", EmitDefaultValue=true)]
        public string AkaName1 { get; set; }

        /// <summary>
        /// Gets or Sets AkaDate1
        /// </summary>
        [DataMember(Name="akaDate1", EmitDefaultValue=true)]
        public string AkaDate1 { get; set; }

        /// <summary>
        /// Gets or Sets AkaName2
        /// </summary>
        [DataMember(Name="akaName2", EmitDefaultValue=true)]
        public string AkaName2 { get; set; }

        /// <summary>
        /// Gets or Sets AkaDate2
        /// </summary>
        [DataMember(Name="akaDate2", EmitDefaultValue=true)]
        public string AkaDate2 { get; set; }

        /// <summary>
        /// Gets or Sets AkaName3
        /// </summary>
        [DataMember(Name="akaName3", EmitDefaultValue=true)]
        public string AkaName3 { get; set; }

        /// <summary>
        /// Gets or Sets AkaDate3
        /// </summary>
        [DataMember(Name="akaDate3", EmitDefaultValue=true)]
        public string AkaDate3 { get; set; }

        /// <summary>
        /// Gets or Sets SpouseForename
        /// </summary>
        [DataMember(Name="spouseForename", EmitDefaultValue=true)]
        public string SpouseForename { get; set; }

        /// <summary>
        /// Gets or Sets AddressDate1
        /// </summary>
        [DataMember(Name="addressDate1", EmitDefaultValue=true)]
        public string AddressDate1 { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=true)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressDate2
        /// </summary>
        [DataMember(Name="addressDate2", EmitDefaultValue=true)]
        public string AddressDate2 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=true)]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressDate3
        /// </summary>
        [DataMember(Name="addressDate3", EmitDefaultValue=true)]
        public string AddressDate3 { get; set; }

        /// <summary>
        /// Gets or Sets Address3
        /// </summary>
        [DataMember(Name="address3", EmitDefaultValue=true)]
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or Sets AddressDate4
        /// </summary>
        [DataMember(Name="addressDate4", EmitDefaultValue=true)]
        public string AddressDate4 { get; set; }

        /// <summary>
        /// Gets or Sets Address4
        /// </summary>
        [DataMember(Name="address4", EmitDefaultValue=true)]
        public string Address4 { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDate1
        /// </summary>
        [DataMember(Name="employmentDate1", EmitDefaultValue=true)]
        public string EmploymentDate1 { get; set; }

        /// <summary>
        /// Gets or Sets Occupation1
        /// </summary>
        [DataMember(Name="occupation1", EmitDefaultValue=true)]
        public string Occupation1 { get; set; }

        /// <summary>
        /// Gets or Sets Employer1
        /// </summary>
        [DataMember(Name="employer1", EmitDefaultValue=true)]
        public string Employer1 { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDate2
        /// </summary>
        [DataMember(Name="employmentDate2", EmitDefaultValue=true)]
        public string EmploymentDate2 { get; set; }

        /// <summary>
        /// Gets or Sets Occupation2
        /// </summary>
        [DataMember(Name="occupation2", EmitDefaultValue=true)]
        public string Occupation2 { get; set; }

        /// <summary>
        /// Gets or Sets Employer2
        /// </summary>
        [DataMember(Name="employer2", EmitDefaultValue=true)]
        public string Employer2 { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDate3
        /// </summary>
        [DataMember(Name="employmentDate3", EmitDefaultValue=true)]
        public string EmploymentDate3 { get; set; }

        /// <summary>
        /// Gets or Sets Occupation3
        /// </summary>
        [DataMember(Name="occupation3", EmitDefaultValue=true)]
        public string Occupation3 { get; set; }

        /// <summary>
        /// Gets or Sets Employer3
        /// </summary>
        [DataMember(Name="employer3", EmitDefaultValue=true)]
        public string Employer3 { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="remarks", EmitDefaultValue=true)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets IdNo1
        /// </summary>
        [DataMember(Name="idNo1", EmitDefaultValue=true)]
        public string IdNo1 { get; set; }

        /// <summary>
        /// Gets or Sets IdNo2
        /// </summary>
        [DataMember(Name="idNo2", EmitDefaultValue=true)]
        public string IdNo2 { get; set; }

        /// <summary>
        /// Gets or Sets DateOfBirth
        /// </summary>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=true)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets WorkPhoneCode
        /// </summary>
        [DataMember(Name="workPhoneCode", EmitDefaultValue=true)]
        public string WorkPhoneCode { get; set; }

        /// <summary>
        /// Gets or Sets WorkPhoneNumber
        /// </summary>
        [DataMember(Name="workPhoneNumber", EmitDefaultValue=true)]
        public string WorkPhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets HomePhoneCode
        /// </summary>
        [DataMember(Name="homePhoneCode", EmitDefaultValue=true)]
        public string HomePhoneCode { get; set; }

        /// <summary>
        /// Gets or Sets HomePhoneNumber
        /// </summary>
        [DataMember(Name="homePhoneNumber", EmitDefaultValue=true)]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets TicketNumber
        /// </summary>
        [DataMember(Name="ticketNumber", EmitDefaultValue=true)]
        public string TicketNumber { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name="match", EmitDefaultValue=true)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets DisputeDate
        /// </summary>
        [DataMember(Name="disputeDate", EmitDefaultValue=true)]
        public string DisputeDate { get; set; }

        /// <summary>
        /// Gets or Sets DebtCouncilDate
        /// </summary>
        [DataMember(Name="debtCouncilDate", EmitDefaultValue=true)]
        public string DebtCouncilDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionCommercialConsumerHeader {\n");
            sb.Append("  MajorProduct: ").Append(MajorProduct).Append("\n");
            sb.Append("  ConsumerNumber: ").Append(ConsumerNumber).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  Forename1: ").Append(Forename1).Append("\n");
            sb.Append("  Forename2: ").Append(Forename2).Append("\n");
            sb.Append("  Forename3: ").Append(Forename3).Append("\n");
            sb.Append("  AkaName1: ").Append(AkaName1).Append("\n");
            sb.Append("  AkaDate1: ").Append(AkaDate1).Append("\n");
            sb.Append("  AkaName2: ").Append(AkaName2).Append("\n");
            sb.Append("  AkaDate2: ").Append(AkaDate2).Append("\n");
            sb.Append("  AkaName3: ").Append(AkaName3).Append("\n");
            sb.Append("  AkaDate3: ").Append(AkaDate3).Append("\n");
            sb.Append("  SpouseForename: ").Append(SpouseForename).Append("\n");
            sb.Append("  AddressDate1: ").Append(AddressDate1).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  AddressDate2: ").Append(AddressDate2).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  AddressDate3: ").Append(AddressDate3).Append("\n");
            sb.Append("  Address3: ").Append(Address3).Append("\n");
            sb.Append("  AddressDate4: ").Append(AddressDate4).Append("\n");
            sb.Append("  Address4: ").Append(Address4).Append("\n");
            sb.Append("  EmploymentDate1: ").Append(EmploymentDate1).Append("\n");
            sb.Append("  Occupation1: ").Append(Occupation1).Append("\n");
            sb.Append("  Employer1: ").Append(Employer1).Append("\n");
            sb.Append("  EmploymentDate2: ").Append(EmploymentDate2).Append("\n");
            sb.Append("  Occupation2: ").Append(Occupation2).Append("\n");
            sb.Append("  Employer2: ").Append(Employer2).Append("\n");
            sb.Append("  EmploymentDate3: ").Append(EmploymentDate3).Append("\n");
            sb.Append("  Occupation3: ").Append(Occupation3).Append("\n");
            sb.Append("  Employer3: ").Append(Employer3).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  IdNo1: ").Append(IdNo1).Append("\n");
            sb.Append("  IdNo2: ").Append(IdNo2).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  WorkPhoneCode: ").Append(WorkPhoneCode).Append("\n");
            sb.Append("  WorkPhoneNumber: ").Append(WorkPhoneNumber).Append("\n");
            sb.Append("  HomePhoneCode: ").Append(HomePhoneCode).Append("\n");
            sb.Append("  HomePhoneNumber: ").Append(HomePhoneNumber).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  DisputeDate: ").Append(DisputeDate).Append("\n");
            sb.Append("  DebtCouncilDate: ").Append(DebtCouncilDate).Append("\n");
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
            return this.Equals(input as TransunionCommercialConsumerHeader);
        }

        /// <summary>
        /// Returns true if TransunionCommercialConsumerHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionCommercialConsumerHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionCommercialConsumerHeader input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MajorProduct == input.MajorProduct ||
                    (this.MajorProduct != null &&
                    this.MajorProduct.Equals(input.MajorProduct))
                ) && 
                (
                    this.ConsumerNumber == input.ConsumerNumber ||
                    (this.ConsumerNumber != null &&
                    this.ConsumerNumber.Equals(input.ConsumerNumber))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.Forename1 == input.Forename1 ||
                    (this.Forename1 != null &&
                    this.Forename1.Equals(input.Forename1))
                ) && 
                (
                    this.Forename2 == input.Forename2 ||
                    (this.Forename2 != null &&
                    this.Forename2.Equals(input.Forename2))
                ) && 
                (
                    this.Forename3 == input.Forename3 ||
                    (this.Forename3 != null &&
                    this.Forename3.Equals(input.Forename3))
                ) && 
                (
                    this.AkaName1 == input.AkaName1 ||
                    (this.AkaName1 != null &&
                    this.AkaName1.Equals(input.AkaName1))
                ) && 
                (
                    this.AkaDate1 == input.AkaDate1 ||
                    (this.AkaDate1 != null &&
                    this.AkaDate1.Equals(input.AkaDate1))
                ) && 
                (
                    this.AkaName2 == input.AkaName2 ||
                    (this.AkaName2 != null &&
                    this.AkaName2.Equals(input.AkaName2))
                ) && 
                (
                    this.AkaDate2 == input.AkaDate2 ||
                    (this.AkaDate2 != null &&
                    this.AkaDate2.Equals(input.AkaDate2))
                ) && 
                (
                    this.AkaName3 == input.AkaName3 ||
                    (this.AkaName3 != null &&
                    this.AkaName3.Equals(input.AkaName3))
                ) && 
                (
                    this.AkaDate3 == input.AkaDate3 ||
                    (this.AkaDate3 != null &&
                    this.AkaDate3.Equals(input.AkaDate3))
                ) && 
                (
                    this.SpouseForename == input.SpouseForename ||
                    (this.SpouseForename != null &&
                    this.SpouseForename.Equals(input.SpouseForename))
                ) && 
                (
                    this.AddressDate1 == input.AddressDate1 ||
                    (this.AddressDate1 != null &&
                    this.AddressDate1.Equals(input.AddressDate1))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.AddressDate2 == input.AddressDate2 ||
                    (this.AddressDate2 != null &&
                    this.AddressDate2.Equals(input.AddressDate2))
                ) && 
                (
                    this.Address2 == input.Address2 ||
                    (this.Address2 != null &&
                    this.Address2.Equals(input.Address2))
                ) && 
                (
                    this.AddressDate3 == input.AddressDate3 ||
                    (this.AddressDate3 != null &&
                    this.AddressDate3.Equals(input.AddressDate3))
                ) && 
                (
                    this.Address3 == input.Address3 ||
                    (this.Address3 != null &&
                    this.Address3.Equals(input.Address3))
                ) && 
                (
                    this.AddressDate4 == input.AddressDate4 ||
                    (this.AddressDate4 != null &&
                    this.AddressDate4.Equals(input.AddressDate4))
                ) && 
                (
                    this.Address4 == input.Address4 ||
                    (this.Address4 != null &&
                    this.Address4.Equals(input.Address4))
                ) && 
                (
                    this.EmploymentDate1 == input.EmploymentDate1 ||
                    (this.EmploymentDate1 != null &&
                    this.EmploymentDate1.Equals(input.EmploymentDate1))
                ) && 
                (
                    this.Occupation1 == input.Occupation1 ||
                    (this.Occupation1 != null &&
                    this.Occupation1.Equals(input.Occupation1))
                ) && 
                (
                    this.Employer1 == input.Employer1 ||
                    (this.Employer1 != null &&
                    this.Employer1.Equals(input.Employer1))
                ) && 
                (
                    this.EmploymentDate2 == input.EmploymentDate2 ||
                    (this.EmploymentDate2 != null &&
                    this.EmploymentDate2.Equals(input.EmploymentDate2))
                ) && 
                (
                    this.Occupation2 == input.Occupation2 ||
                    (this.Occupation2 != null &&
                    this.Occupation2.Equals(input.Occupation2))
                ) && 
                (
                    this.Employer2 == input.Employer2 ||
                    (this.Employer2 != null &&
                    this.Employer2.Equals(input.Employer2))
                ) && 
                (
                    this.EmploymentDate3 == input.EmploymentDate3 ||
                    (this.EmploymentDate3 != null &&
                    this.EmploymentDate3.Equals(input.EmploymentDate3))
                ) && 
                (
                    this.Occupation3 == input.Occupation3 ||
                    (this.Occupation3 != null &&
                    this.Occupation3.Equals(input.Occupation3))
                ) && 
                (
                    this.Employer3 == input.Employer3 ||
                    (this.Employer3 != null &&
                    this.Employer3.Equals(input.Employer3))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.IdNo1 == input.IdNo1 ||
                    (this.IdNo1 != null &&
                    this.IdNo1.Equals(input.IdNo1))
                ) && 
                (
                    this.IdNo2 == input.IdNo2 ||
                    (this.IdNo2 != null &&
                    this.IdNo2.Equals(input.IdNo2))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.WorkPhoneCode == input.WorkPhoneCode ||
                    (this.WorkPhoneCode != null &&
                    this.WorkPhoneCode.Equals(input.WorkPhoneCode))
                ) && 
                (
                    this.WorkPhoneNumber == input.WorkPhoneNumber ||
                    (this.WorkPhoneNumber != null &&
                    this.WorkPhoneNumber.Equals(input.WorkPhoneNumber))
                ) && 
                (
                    this.HomePhoneCode == input.HomePhoneCode ||
                    (this.HomePhoneCode != null &&
                    this.HomePhoneCode.Equals(input.HomePhoneCode))
                ) && 
                (
                    this.HomePhoneNumber == input.HomePhoneNumber ||
                    (this.HomePhoneNumber != null &&
                    this.HomePhoneNumber.Equals(input.HomePhoneNumber))
                ) && 
                (
                    this.TicketNumber == input.TicketNumber ||
                    (this.TicketNumber != null &&
                    this.TicketNumber.Equals(input.TicketNumber))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Match == input.Match ||
                    (this.Match != null &&
                    this.Match.Equals(input.Match))
                ) && 
                (
                    this.DisputeDate == input.DisputeDate ||
                    (this.DisputeDate != null &&
                    this.DisputeDate.Equals(input.DisputeDate))
                ) && 
                (
                    this.DebtCouncilDate == input.DebtCouncilDate ||
                    (this.DebtCouncilDate != null &&
                    this.DebtCouncilDate.Equals(input.DebtCouncilDate))
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
                if (this.MajorProduct != null)
                    hashCode = hashCode * 59 + this.MajorProduct.GetHashCode();
                if (this.ConsumerNumber != null)
                    hashCode = hashCode * 59 + this.ConsumerNumber.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.Forename1 != null)
                    hashCode = hashCode * 59 + this.Forename1.GetHashCode();
                if (this.Forename2 != null)
                    hashCode = hashCode * 59 + this.Forename2.GetHashCode();
                if (this.Forename3 != null)
                    hashCode = hashCode * 59 + this.Forename3.GetHashCode();
                if (this.AkaName1 != null)
                    hashCode = hashCode * 59 + this.AkaName1.GetHashCode();
                if (this.AkaDate1 != null)
                    hashCode = hashCode * 59 + this.AkaDate1.GetHashCode();
                if (this.AkaName2 != null)
                    hashCode = hashCode * 59 + this.AkaName2.GetHashCode();
                if (this.AkaDate2 != null)
                    hashCode = hashCode * 59 + this.AkaDate2.GetHashCode();
                if (this.AkaName3 != null)
                    hashCode = hashCode * 59 + this.AkaName3.GetHashCode();
                if (this.AkaDate3 != null)
                    hashCode = hashCode * 59 + this.AkaDate3.GetHashCode();
                if (this.SpouseForename != null)
                    hashCode = hashCode * 59 + this.SpouseForename.GetHashCode();
                if (this.AddressDate1 != null)
                    hashCode = hashCode * 59 + this.AddressDate1.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.AddressDate2 != null)
                    hashCode = hashCode * 59 + this.AddressDate2.GetHashCode();
                if (this.Address2 != null)
                    hashCode = hashCode * 59 + this.Address2.GetHashCode();
                if (this.AddressDate3 != null)
                    hashCode = hashCode * 59 + this.AddressDate3.GetHashCode();
                if (this.Address3 != null)
                    hashCode = hashCode * 59 + this.Address3.GetHashCode();
                if (this.AddressDate4 != null)
                    hashCode = hashCode * 59 + this.AddressDate4.GetHashCode();
                if (this.Address4 != null)
                    hashCode = hashCode * 59 + this.Address4.GetHashCode();
                if (this.EmploymentDate1 != null)
                    hashCode = hashCode * 59 + this.EmploymentDate1.GetHashCode();
                if (this.Occupation1 != null)
                    hashCode = hashCode * 59 + this.Occupation1.GetHashCode();
                if (this.Employer1 != null)
                    hashCode = hashCode * 59 + this.Employer1.GetHashCode();
                if (this.EmploymentDate2 != null)
                    hashCode = hashCode * 59 + this.EmploymentDate2.GetHashCode();
                if (this.Occupation2 != null)
                    hashCode = hashCode * 59 + this.Occupation2.GetHashCode();
                if (this.Employer2 != null)
                    hashCode = hashCode * 59 + this.Employer2.GetHashCode();
                if (this.EmploymentDate3 != null)
                    hashCode = hashCode * 59 + this.EmploymentDate3.GetHashCode();
                if (this.Occupation3 != null)
                    hashCode = hashCode * 59 + this.Occupation3.GetHashCode();
                if (this.Employer3 != null)
                    hashCode = hashCode * 59 + this.Employer3.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.IdNo1 != null)
                    hashCode = hashCode * 59 + this.IdNo1.GetHashCode();
                if (this.IdNo2 != null)
                    hashCode = hashCode * 59 + this.IdNo2.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.WorkPhoneCode != null)
                    hashCode = hashCode * 59 + this.WorkPhoneCode.GetHashCode();
                if (this.WorkPhoneNumber != null)
                    hashCode = hashCode * 59 + this.WorkPhoneNumber.GetHashCode();
                if (this.HomePhoneCode != null)
                    hashCode = hashCode * 59 + this.HomePhoneCode.GetHashCode();
                if (this.HomePhoneNumber != null)
                    hashCode = hashCode * 59 + this.HomePhoneNumber.GetHashCode();
                if (this.TicketNumber != null)
                    hashCode = hashCode * 59 + this.TicketNumber.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Match != null)
                    hashCode = hashCode * 59 + this.Match.GetHashCode();
                if (this.DisputeDate != null)
                    hashCode = hashCode * 59 + this.DisputeDate.GetHashCode();
                if (this.DebtCouncilDate != null)
                    hashCode = hashCode * 59 + this.DebtCouncilDate.GetHashCode();
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
