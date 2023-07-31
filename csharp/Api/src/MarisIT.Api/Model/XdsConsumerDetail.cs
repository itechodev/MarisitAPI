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
    /// XdsConsumerDetail
    /// </summary>
    [DataContract]
    public partial class XdsConsumerDetail :  IEquatable<XdsConsumerDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XdsConsumerDetail" /> class.
        /// </summary>
        /// <param name="consumerID">consumerID.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="secondName">secondName.</param>
        /// <param name="thirdName">thirdName.</param>
        /// <param name="surname">surname.</param>
        /// <param name="idNo">idNo.</param>
        /// <param name="passportNo">passportNo.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="genderInd">genderInd.</param>
        /// <param name="bonusXML">bonusXML.</param>
        /// <param name="tempReference">tempReference.</param>
        /// <param name="enquiryID">enquiryID.</param>
        /// <param name="enquiryResultID">enquiryResultID.</param>
        /// <param name="reference">reference.</param>
        /// <param name="age">age.</param>
        /// <param name="bureauAddress">bureauAddress.</param>
        /// <param name="cellularNo">cellularNo.</param>
        /// <param name="displayText">displayText.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="employerDetail">employerDetail.</param>
        /// <param name="externalReference">externalReference.</param>
        /// <param name="gender">gender.</param>
        /// <param name="homeTelephoneNo">homeTelephoneNo.</param>
        /// <param name="initials">initials.</param>
        /// <param name="inputAddress">inputAddress.</param>
        /// <param name="maidenName">maidenName.</param>
        /// <param name="maritalStatusDesc">maritalStatusDesc.</param>
        /// <param name="nationality">nationality.</param>
        /// <param name="noOfEnquiries">noOfEnquiries.</param>
        /// <param name="postalAddress">postalAddress.</param>
        /// <param name="privacyStatus">privacyStatus.</param>
        /// <param name="referenceNo">referenceNo.</param>
        /// <param name="residentialAddress">residentialAddress.</param>
        /// <param name="titleDesc">titleDesc.</param>
        /// <param name="workTelephoneNo">workTelephoneNo.</param>
        /// <param name="xdsDeceasedDate">xdsDeceasedDate.</param>
        /// <param name="xdsDeceasedStatus">xdsDeceasedStatus.</param>
        public XdsConsumerDetail(int consumerID = default(int), string firstName = default(string), string secondName = default(string), string thirdName = default(string), string surname = default(string), string idNo = default(string), string passportNo = default(string), string birthDate = default(string), string genderInd = default(string), string bonusXML = default(string), string tempReference = default(string), long enquiryID = default(long), long enquiryResultID = default(long), string reference = default(string), string age = default(string), string bureauAddress = default(string), string cellularNo = default(string), string displayText = default(string), string emailAddress = default(string), string employerDetail = default(string), string externalReference = default(string), string gender = default(string), string homeTelephoneNo = default(string), string initials = default(string), string inputAddress = default(string), string maidenName = default(string), string maritalStatusDesc = default(string), string nationality = default(string), int noOfEnquiries = default(int), string postalAddress = default(string), string privacyStatus = default(string), string referenceNo = default(string), string residentialAddress = default(string), string titleDesc = default(string), string workTelephoneNo = default(string), string xdsDeceasedDate = default(string), string xdsDeceasedStatus = default(string))
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.Surname = surname;
            this.IdNo = idNo;
            this.PassportNo = passportNo;
            this.BirthDate = birthDate;
            this.GenderInd = genderInd;
            this.BonusXML = bonusXML;
            this.TempReference = tempReference;
            this.Reference = reference;
            this.Age = age;
            this.BureauAddress = bureauAddress;
            this.CellularNo = cellularNo;
            this.DisplayText = displayText;
            this.EmailAddress = emailAddress;
            this.EmployerDetail = employerDetail;
            this.ExternalReference = externalReference;
            this.Gender = gender;
            this.HomeTelephoneNo = homeTelephoneNo;
            this.Initials = initials;
            this.InputAddress = inputAddress;
            this.MaidenName = maidenName;
            this.MaritalStatusDesc = maritalStatusDesc;
            this.Nationality = nationality;
            this.PostalAddress = postalAddress;
            this.PrivacyStatus = privacyStatus;
            this.ReferenceNo = referenceNo;
            this.ResidentialAddress = residentialAddress;
            this.TitleDesc = titleDesc;
            this.WorkTelephoneNo = workTelephoneNo;
            this.XdsDeceasedDate = xdsDeceasedDate;
            this.XdsDeceasedStatus = xdsDeceasedStatus;
            this.ConsumerID = consumerID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.Surname = surname;
            this.IdNo = idNo;
            this.PassportNo = passportNo;
            this.BirthDate = birthDate;
            this.GenderInd = genderInd;
            this.BonusXML = bonusXML;
            this.TempReference = tempReference;
            this.EnquiryID = enquiryID;
            this.EnquiryResultID = enquiryResultID;
            this.Reference = reference;
            this.Age = age;
            this.BureauAddress = bureauAddress;
            this.CellularNo = cellularNo;
            this.DisplayText = displayText;
            this.EmailAddress = emailAddress;
            this.EmployerDetail = employerDetail;
            this.ExternalReference = externalReference;
            this.Gender = gender;
            this.HomeTelephoneNo = homeTelephoneNo;
            this.Initials = initials;
            this.InputAddress = inputAddress;
            this.MaidenName = maidenName;
            this.MaritalStatusDesc = maritalStatusDesc;
            this.Nationality = nationality;
            this.NoOfEnquiries = noOfEnquiries;
            this.PostalAddress = postalAddress;
            this.PrivacyStatus = privacyStatus;
            this.ReferenceNo = referenceNo;
            this.ResidentialAddress = residentialAddress;
            this.TitleDesc = titleDesc;
            this.WorkTelephoneNo = workTelephoneNo;
            this.XdsDeceasedDate = xdsDeceasedDate;
            this.XdsDeceasedStatus = xdsDeceasedStatus;
        }

        /// <summary>
        /// Gets or Sets ConsumerID
        /// </summary>
        [DataMember(Name="consumerID", EmitDefaultValue=false)]
        public int ConsumerID { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets SecondName
        /// </summary>
        [DataMember(Name="secondName", EmitDefaultValue=true)]
        public string SecondName { get; set; }

        /// <summary>
        /// Gets or Sets ThirdName
        /// </summary>
        [DataMember(Name="thirdName", EmitDefaultValue=true)]
        public string ThirdName { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name="surname", EmitDefaultValue=true)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets IdNo
        /// </summary>
        [DataMember(Name="idNo", EmitDefaultValue=true)]
        public string IdNo { get; set; }

        /// <summary>
        /// Gets or Sets PassportNo
        /// </summary>
        [DataMember(Name="passportNo", EmitDefaultValue=true)]
        public string PassportNo { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name="birthDate", EmitDefaultValue=true)]
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets GenderInd
        /// </summary>
        [DataMember(Name="genderInd", EmitDefaultValue=true)]
        public string GenderInd { get; set; }

        /// <summary>
        /// Gets or Sets BonusXML
        /// </summary>
        [DataMember(Name="bonusXML", EmitDefaultValue=true)]
        public string BonusXML { get; set; }

        /// <summary>
        /// Gets or Sets TempReference
        /// </summary>
        [DataMember(Name="tempReference", EmitDefaultValue=true)]
        public string TempReference { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryID
        /// </summary>
        [DataMember(Name="enquiryID", EmitDefaultValue=false)]
        public long EnquiryID { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryResultID
        /// </summary>
        [DataMember(Name="enquiryResultID", EmitDefaultValue=false)]
        public long EnquiryResultID { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=true)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name="age", EmitDefaultValue=true)]
        public string Age { get; set; }

        /// <summary>
        /// Gets or Sets BureauAddress
        /// </summary>
        [DataMember(Name="bureauAddress", EmitDefaultValue=true)]
        public string BureauAddress { get; set; }

        /// <summary>
        /// Gets or Sets CellularNo
        /// </summary>
        [DataMember(Name="cellularNo", EmitDefaultValue=true)]
        public string CellularNo { get; set; }

        /// <summary>
        /// Gets or Sets DisplayText
        /// </summary>
        [DataMember(Name="displayText", EmitDefaultValue=true)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets EmployerDetail
        /// </summary>
        [DataMember(Name="employerDetail", EmitDefaultValue=true)]
        public string EmployerDetail { get; set; }

        /// <summary>
        /// Gets or Sets ExternalReference
        /// </summary>
        [DataMember(Name="externalReference", EmitDefaultValue=true)]
        public string ExternalReference { get; set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=true)]
        public string Gender { get; set; }

        /// <summary>
        /// Gets or Sets HomeTelephoneNo
        /// </summary>
        [DataMember(Name="homeTelephoneNo", EmitDefaultValue=true)]
        public string HomeTelephoneNo { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=true)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets InputAddress
        /// </summary>
        [DataMember(Name="inputAddress", EmitDefaultValue=true)]
        public string InputAddress { get; set; }

        /// <summary>
        /// Gets or Sets MaidenName
        /// </summary>
        [DataMember(Name="maidenName", EmitDefaultValue=true)]
        public string MaidenName { get; set; }

        /// <summary>
        /// Gets or Sets MaritalStatusDesc
        /// </summary>
        [DataMember(Name="maritalStatusDesc", EmitDefaultValue=true)]
        public string MaritalStatusDesc { get; set; }

        /// <summary>
        /// Gets or Sets Nationality
        /// </summary>
        [DataMember(Name="nationality", EmitDefaultValue=true)]
        public string Nationality { get; set; }

        /// <summary>
        /// Gets or Sets NoOfEnquiries
        /// </summary>
        [DataMember(Name="noOfEnquiries", EmitDefaultValue=false)]
        public int NoOfEnquiries { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="postalAddress", EmitDefaultValue=true)]
        public string PostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyStatus
        /// </summary>
        [DataMember(Name="privacyStatus", EmitDefaultValue=true)]
        public string PrivacyStatus { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceNo
        /// </summary>
        [DataMember(Name="referenceNo", EmitDefaultValue=true)]
        public string ReferenceNo { get; set; }

        /// <summary>
        /// Gets or Sets ResidentialAddress
        /// </summary>
        [DataMember(Name="residentialAddress", EmitDefaultValue=true)]
        public string ResidentialAddress { get; set; }

        /// <summary>
        /// Gets or Sets TitleDesc
        /// </summary>
        [DataMember(Name="titleDesc", EmitDefaultValue=true)]
        public string TitleDesc { get; set; }

        /// <summary>
        /// Gets or Sets WorkTelephoneNo
        /// </summary>
        [DataMember(Name="workTelephoneNo", EmitDefaultValue=true)]
        public string WorkTelephoneNo { get; set; }

        /// <summary>
        /// Gets or Sets XdsDeceasedDate
        /// </summary>
        [DataMember(Name="xdsDeceasedDate", EmitDefaultValue=true)]
        public string XdsDeceasedDate { get; set; }

        /// <summary>
        /// Gets or Sets XdsDeceasedStatus
        /// </summary>
        [DataMember(Name="xdsDeceasedStatus", EmitDefaultValue=true)]
        public string XdsDeceasedStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XdsConsumerDetail {\n");
            sb.Append("  ConsumerID: ").Append(ConsumerID).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  SecondName: ").Append(SecondName).Append("\n");
            sb.Append("  ThirdName: ").Append(ThirdName).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  IdNo: ").Append(IdNo).Append("\n");
            sb.Append("  PassportNo: ").Append(PassportNo).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  GenderInd: ").Append(GenderInd).Append("\n");
            sb.Append("  BonusXML: ").Append(BonusXML).Append("\n");
            sb.Append("  TempReference: ").Append(TempReference).Append("\n");
            sb.Append("  EnquiryID: ").Append(EnquiryID).Append("\n");
            sb.Append("  EnquiryResultID: ").Append(EnquiryResultID).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  BureauAddress: ").Append(BureauAddress).Append("\n");
            sb.Append("  CellularNo: ").Append(CellularNo).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  EmployerDetail: ").Append(EmployerDetail).Append("\n");
            sb.Append("  ExternalReference: ").Append(ExternalReference).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  HomeTelephoneNo: ").Append(HomeTelephoneNo).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  InputAddress: ").Append(InputAddress).Append("\n");
            sb.Append("  MaidenName: ").Append(MaidenName).Append("\n");
            sb.Append("  MaritalStatusDesc: ").Append(MaritalStatusDesc).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  NoOfEnquiries: ").Append(NoOfEnquiries).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  PrivacyStatus: ").Append(PrivacyStatus).Append("\n");
            sb.Append("  ReferenceNo: ").Append(ReferenceNo).Append("\n");
            sb.Append("  ResidentialAddress: ").Append(ResidentialAddress).Append("\n");
            sb.Append("  TitleDesc: ").Append(TitleDesc).Append("\n");
            sb.Append("  WorkTelephoneNo: ").Append(WorkTelephoneNo).Append("\n");
            sb.Append("  XdsDeceasedDate: ").Append(XdsDeceasedDate).Append("\n");
            sb.Append("  XdsDeceasedStatus: ").Append(XdsDeceasedStatus).Append("\n");
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
            return this.Equals(input as XdsConsumerDetail);
        }

        /// <summary>
        /// Returns true if XdsConsumerDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of XdsConsumerDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XdsConsumerDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerID == input.ConsumerID ||
                    (this.ConsumerID != null &&
                    this.ConsumerID.Equals(input.ConsumerID))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.SecondName == input.SecondName ||
                    (this.SecondName != null &&
                    this.SecondName.Equals(input.SecondName))
                ) && 
                (
                    this.ThirdName == input.ThirdName ||
                    (this.ThirdName != null &&
                    this.ThirdName.Equals(input.ThirdName))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.IdNo == input.IdNo ||
                    (this.IdNo != null &&
                    this.IdNo.Equals(input.IdNo))
                ) && 
                (
                    this.PassportNo == input.PassportNo ||
                    (this.PassportNo != null &&
                    this.PassportNo.Equals(input.PassportNo))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
                ) && 
                (
                    this.GenderInd == input.GenderInd ||
                    (this.GenderInd != null &&
                    this.GenderInd.Equals(input.GenderInd))
                ) && 
                (
                    this.BonusXML == input.BonusXML ||
                    (this.BonusXML != null &&
                    this.BonusXML.Equals(input.BonusXML))
                ) && 
                (
                    this.TempReference == input.TempReference ||
                    (this.TempReference != null &&
                    this.TempReference.Equals(input.TempReference))
                ) && 
                (
                    this.EnquiryID == input.EnquiryID ||
                    (this.EnquiryID != null &&
                    this.EnquiryID.Equals(input.EnquiryID))
                ) && 
                (
                    this.EnquiryResultID == input.EnquiryResultID ||
                    (this.EnquiryResultID != null &&
                    this.EnquiryResultID.Equals(input.EnquiryResultID))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.BureauAddress == input.BureauAddress ||
                    (this.BureauAddress != null &&
                    this.BureauAddress.Equals(input.BureauAddress))
                ) && 
                (
                    this.CellularNo == input.CellularNo ||
                    (this.CellularNo != null &&
                    this.CellularNo.Equals(input.CellularNo))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.EmployerDetail == input.EmployerDetail ||
                    (this.EmployerDetail != null &&
                    this.EmployerDetail.Equals(input.EmployerDetail))
                ) && 
                (
                    this.ExternalReference == input.ExternalReference ||
                    (this.ExternalReference != null &&
                    this.ExternalReference.Equals(input.ExternalReference))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.HomeTelephoneNo == input.HomeTelephoneNo ||
                    (this.HomeTelephoneNo != null &&
                    this.HomeTelephoneNo.Equals(input.HomeTelephoneNo))
                ) && 
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                    this.Initials.Equals(input.Initials))
                ) && 
                (
                    this.InputAddress == input.InputAddress ||
                    (this.InputAddress != null &&
                    this.InputAddress.Equals(input.InputAddress))
                ) && 
                (
                    this.MaidenName == input.MaidenName ||
                    (this.MaidenName != null &&
                    this.MaidenName.Equals(input.MaidenName))
                ) && 
                (
                    this.MaritalStatusDesc == input.MaritalStatusDesc ||
                    (this.MaritalStatusDesc != null &&
                    this.MaritalStatusDesc.Equals(input.MaritalStatusDesc))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.NoOfEnquiries == input.NoOfEnquiries ||
                    (this.NoOfEnquiries != null &&
                    this.NoOfEnquiries.Equals(input.NoOfEnquiries))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
                ) && 
                (
                    this.PrivacyStatus == input.PrivacyStatus ||
                    (this.PrivacyStatus != null &&
                    this.PrivacyStatus.Equals(input.PrivacyStatus))
                ) && 
                (
                    this.ReferenceNo == input.ReferenceNo ||
                    (this.ReferenceNo != null &&
                    this.ReferenceNo.Equals(input.ReferenceNo))
                ) && 
                (
                    this.ResidentialAddress == input.ResidentialAddress ||
                    (this.ResidentialAddress != null &&
                    this.ResidentialAddress.Equals(input.ResidentialAddress))
                ) && 
                (
                    this.TitleDesc == input.TitleDesc ||
                    (this.TitleDesc != null &&
                    this.TitleDesc.Equals(input.TitleDesc))
                ) && 
                (
                    this.WorkTelephoneNo == input.WorkTelephoneNo ||
                    (this.WorkTelephoneNo != null &&
                    this.WorkTelephoneNo.Equals(input.WorkTelephoneNo))
                ) && 
                (
                    this.XdsDeceasedDate == input.XdsDeceasedDate ||
                    (this.XdsDeceasedDate != null &&
                    this.XdsDeceasedDate.Equals(input.XdsDeceasedDate))
                ) && 
                (
                    this.XdsDeceasedStatus == input.XdsDeceasedStatus ||
                    (this.XdsDeceasedStatus != null &&
                    this.XdsDeceasedStatus.Equals(input.XdsDeceasedStatus))
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
                if (this.ConsumerID != null)
                    hashCode = hashCode * 59 + this.ConsumerID.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.SecondName != null)
                    hashCode = hashCode * 59 + this.SecondName.GetHashCode();
                if (this.ThirdName != null)
                    hashCode = hashCode * 59 + this.ThirdName.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.IdNo != null)
                    hashCode = hashCode * 59 + this.IdNo.GetHashCode();
                if (this.PassportNo != null)
                    hashCode = hashCode * 59 + this.PassportNo.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.GenderInd != null)
                    hashCode = hashCode * 59 + this.GenderInd.GetHashCode();
                if (this.BonusXML != null)
                    hashCode = hashCode * 59 + this.BonusXML.GetHashCode();
                if (this.TempReference != null)
                    hashCode = hashCode * 59 + this.TempReference.GetHashCode();
                if (this.EnquiryID != null)
                    hashCode = hashCode * 59 + this.EnquiryID.GetHashCode();
                if (this.EnquiryResultID != null)
                    hashCode = hashCode * 59 + this.EnquiryResultID.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Age != null)
                    hashCode = hashCode * 59 + this.Age.GetHashCode();
                if (this.BureauAddress != null)
                    hashCode = hashCode * 59 + this.BureauAddress.GetHashCode();
                if (this.CellularNo != null)
                    hashCode = hashCode * 59 + this.CellularNo.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.EmployerDetail != null)
                    hashCode = hashCode * 59 + this.EmployerDetail.GetHashCode();
                if (this.ExternalReference != null)
                    hashCode = hashCode * 59 + this.ExternalReference.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.HomeTelephoneNo != null)
                    hashCode = hashCode * 59 + this.HomeTelephoneNo.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.InputAddress != null)
                    hashCode = hashCode * 59 + this.InputAddress.GetHashCode();
                if (this.MaidenName != null)
                    hashCode = hashCode * 59 + this.MaidenName.GetHashCode();
                if (this.MaritalStatusDesc != null)
                    hashCode = hashCode * 59 + this.MaritalStatusDesc.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.NoOfEnquiries != null)
                    hashCode = hashCode * 59 + this.NoOfEnquiries.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
                if (this.PrivacyStatus != null)
                    hashCode = hashCode * 59 + this.PrivacyStatus.GetHashCode();
                if (this.ReferenceNo != null)
                    hashCode = hashCode * 59 + this.ReferenceNo.GetHashCode();
                if (this.ResidentialAddress != null)
                    hashCode = hashCode * 59 + this.ResidentialAddress.GetHashCode();
                if (this.TitleDesc != null)
                    hashCode = hashCode * 59 + this.TitleDesc.GetHashCode();
                if (this.WorkTelephoneNo != null)
                    hashCode = hashCode * 59 + this.WorkTelephoneNo.GetHashCode();
                if (this.XdsDeceasedDate != null)
                    hashCode = hashCode * 59 + this.XdsDeceasedDate.GetHashCode();
                if (this.XdsDeceasedStatus != null)
                    hashCode = hashCode * 59 + this.XdsDeceasedStatus.GetHashCode();
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