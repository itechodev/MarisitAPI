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
    /// TransunionConsumer118AddressNA08
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118AddressNA08 :  IEquatable<TransunionConsumer118AddressNA08>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118AddressNA08" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="informationDate">informationDate.</param>
        /// <param name="line1">line1.</param>
        /// <param name="line2">line2.</param>
        /// <param name="suburb">suburb.</param>
        /// <param name="city">city.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="provinceCode">provinceCode.</param>
        /// <param name="province">province.</param>
        /// <param name="addressPeriod">addressPeriod.</param>
        /// <param name="ownerTenant">ownerTenant.</param>
        /// <param name="addressChanged">addressChanged.</param>
        public TransunionConsumer118AddressNA08(string consumerNo = default(string), string informationDate = default(string), string line1 = default(string), string line2 = default(string), string suburb = default(string), string city = default(string), string postalCode = default(string), string provinceCode = default(string), string province = default(string), string addressPeriod = default(string), string ownerTenant = default(string), string addressChanged = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.InformationDate = informationDate;
            this.Line1 = line1;
            this.Line2 = line2;
            this.Suburb = suburb;
            this.City = city;
            this.PostalCode = postalCode;
            this.ProvinceCode = provinceCode;
            this.Province = province;
            this.AddressPeriod = addressPeriod;
            this.OwnerTenant = ownerTenant;
            this.AddressChanged = addressChanged;
            this.ConsumerNo = consumerNo;
            this.InformationDate = informationDate;
            this.Line1 = line1;
            this.Line2 = line2;
            this.Suburb = suburb;
            this.City = city;
            this.PostalCode = postalCode;
            this.ProvinceCode = provinceCode;
            this.Province = province;
            this.AddressPeriod = addressPeriod;
            this.OwnerTenant = ownerTenant;
            this.AddressChanged = addressChanged;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets InformationDate
        /// </summary>
        [DataMember(Name="informationDate", EmitDefaultValue=true)]
        public string InformationDate { get; set; }

        /// <summary>
        /// Gets or Sets Line1
        /// </summary>
        [DataMember(Name="line1", EmitDefaultValue=true)]
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or Sets Line2
        /// </summary>
        [DataMember(Name="line2", EmitDefaultValue=true)]
        public string Line2 { get; set; }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name="suburb", EmitDefaultValue=true)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets ProvinceCode
        /// </summary>
        [DataMember(Name="provinceCode", EmitDefaultValue=true)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// Gets or Sets Province
        /// </summary>
        [DataMember(Name="province", EmitDefaultValue=true)]
        public string Province { get; set; }

        /// <summary>
        /// Gets or Sets AddressPeriod
        /// </summary>
        [DataMember(Name="addressPeriod", EmitDefaultValue=true)]
        public string AddressPeriod { get; set; }

        /// <summary>
        /// Gets or Sets OwnerTenant
        /// </summary>
        [DataMember(Name="ownerTenant", EmitDefaultValue=true)]
        public string OwnerTenant { get; set; }

        /// <summary>
        /// Gets or Sets AddressChanged
        /// </summary>
        [DataMember(Name="addressChanged", EmitDefaultValue=true)]
        public string AddressChanged { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118AddressNA08 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  InformationDate: ").Append(InformationDate).Append("\n");
            sb.Append("  Line1: ").Append(Line1).Append("\n");
            sb.Append("  Line2: ").Append(Line2).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
            sb.Append("  Province: ").Append(Province).Append("\n");
            sb.Append("  AddressPeriod: ").Append(AddressPeriod).Append("\n");
            sb.Append("  OwnerTenant: ").Append(OwnerTenant).Append("\n");
            sb.Append("  AddressChanged: ").Append(AddressChanged).Append("\n");
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
            return this.Equals(input as TransunionConsumer118AddressNA08);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118AddressNA08 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118AddressNA08 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118AddressNA08 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsumerNo == input.ConsumerNo ||
                    (this.ConsumerNo != null &&
                    this.ConsumerNo.Equals(input.ConsumerNo))
                ) && 
                (
                    this.InformationDate == input.InformationDate ||
                    (this.InformationDate != null &&
                    this.InformationDate.Equals(input.InformationDate))
                ) && 
                (
                    this.Line1 == input.Line1 ||
                    (this.Line1 != null &&
                    this.Line1.Equals(input.Line1))
                ) && 
                (
                    this.Line2 == input.Line2 ||
                    (this.Line2 != null &&
                    this.Line2.Equals(input.Line2))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
                ) && 
                (
                    this.Province == input.Province ||
                    (this.Province != null &&
                    this.Province.Equals(input.Province))
                ) && 
                (
                    this.AddressPeriod == input.AddressPeriod ||
                    (this.AddressPeriod != null &&
                    this.AddressPeriod.Equals(input.AddressPeriod))
                ) && 
                (
                    this.OwnerTenant == input.OwnerTenant ||
                    (this.OwnerTenant != null &&
                    this.OwnerTenant.Equals(input.OwnerTenant))
                ) && 
                (
                    this.AddressChanged == input.AddressChanged ||
                    (this.AddressChanged != null &&
                    this.AddressChanged.Equals(input.AddressChanged))
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
                if (this.ConsumerNo != null)
                    hashCode = hashCode * 59 + this.ConsumerNo.GetHashCode();
                if (this.InformationDate != null)
                    hashCode = hashCode * 59 + this.InformationDate.GetHashCode();
                if (this.Line1 != null)
                    hashCode = hashCode * 59 + this.Line1.GetHashCode();
                if (this.Line2 != null)
                    hashCode = hashCode * 59 + this.Line2.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.ProvinceCode != null)
                    hashCode = hashCode * 59 + this.ProvinceCode.GetHashCode();
                if (this.Province != null)
                    hashCode = hashCode * 59 + this.Province.GetHashCode();
                if (this.AddressPeriod != null)
                    hashCode = hashCode * 59 + this.AddressPeriod.GetHashCode();
                if (this.OwnerTenant != null)
                    hashCode = hashCode * 59 + this.OwnerTenant.GetHashCode();
                if (this.AddressChanged != null)
                    hashCode = hashCode * 59 + this.AddressChanged.GetHashCode();
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
