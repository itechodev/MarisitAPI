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
    /// TransunionConsumer118StandardBatchCharsSB30
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118StandardBatchCharsSB30 :  IEquatable<TransunionConsumer118StandardBatchCharsSB30>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118StandardBatchCharsSB30" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="aT001">aT001.</param>
        /// <param name="aT006">aT006.</param>
        /// <param name="aT022">aT022.</param>
        /// <param name="aT025">aT025.</param>
        /// <param name="aT041">aT041.</param>
        /// <param name="aT043">aT043.</param>
        /// <param name="aT092">aT092.</param>
        /// <param name="aT093">aT093.</param>
        /// <param name="aT103">aT103.</param>
        /// <param name="aT107">aT107.</param>
        /// <param name="aT121">aT121.</param>
        /// <param name="aT140">aT140.</param>
        /// <param name="aT141">aT141.</param>
        /// <param name="aT152">aT152.</param>
        /// <param name="aT156">aT156.</param>
        /// <param name="aT164">aT164.</param>
        /// <param name="aT167">aT167.</param>
        /// <param name="g002">g002.</param>
        /// <param name="g011">g011.</param>
        /// <param name="g031">g031.</param>
        /// <param name="g057">g057.</param>
        /// <param name="iN001">iN001.</param>
        /// <param name="iN180">iN180.</param>
        /// <param name="iN181">iN181.</param>
        /// <param name="mL001">mL001.</param>
        /// <param name="mL006">mL006.</param>
        /// <param name="mL042">mL042.</param>
        /// <param name="mL093">mL093.</param>
        /// <param name="mL094">mL094.</param>
        /// <param name="mL104">mL104.</param>
        /// <param name="mL140">mL140.</param>
        /// <param name="mL160">mL160.</param>
        /// <param name="mL181">mL181.</param>
        /// <param name="oT001">oT001.</param>
        /// <param name="rE001">rE001.</param>
        /// <param name="rE003">rE003.</param>
        /// <param name="rE022">rE022.</param>
        /// <param name="rE107">rE107.</param>
        /// <param name="rE121">rE121.</param>
        /// <param name="rE156">rE156.</param>
        /// <param name="rE180">rE180.</param>
        public TransunionConsumer118StandardBatchCharsSB30(string consumerNo = default(string), string aT001 = default(string), string aT006 = default(string), string aT022 = default(string), string aT025 = default(string), string aT041 = default(string), string aT043 = default(string), string aT092 = default(string), string aT093 = default(string), string aT103 = default(string), string aT107 = default(string), string aT121 = default(string), string aT140 = default(string), string aT141 = default(string), string aT152 = default(string), string aT156 = default(string), string aT164 = default(string), string aT167 = default(string), string g002 = default(string), string g011 = default(string), string g031 = default(string), string g057 = default(string), string iN001 = default(string), string iN180 = default(string), string iN181 = default(string), string mL001 = default(string), string mL006 = default(string), string mL042 = default(string), string mL093 = default(string), string mL094 = default(string), string mL104 = default(string), string mL140 = default(string), string mL160 = default(string), string mL181 = default(string), string oT001 = default(string), string rE001 = default(string), string rE003 = default(string), string rE022 = default(string), string rE107 = default(string), string rE121 = default(string), string rE156 = default(string), string rE180 = default(string))
        {
            this.ConsumerNo = consumerNo;
            this.AT001 = aT001;
            this.AT006 = aT006;
            this.AT022 = aT022;
            this.AT025 = aT025;
            this.AT041 = aT041;
            this.AT043 = aT043;
            this.AT092 = aT092;
            this.AT093 = aT093;
            this.AT103 = aT103;
            this.AT107 = aT107;
            this.AT121 = aT121;
            this.AT140 = aT140;
            this.AT141 = aT141;
            this.AT152 = aT152;
            this.AT156 = aT156;
            this.AT164 = aT164;
            this.AT167 = aT167;
            this.G002 = g002;
            this.G011 = g011;
            this.G031 = g031;
            this.G057 = g057;
            this.IN001 = iN001;
            this.IN180 = iN180;
            this.IN181 = iN181;
            this.ML001 = mL001;
            this.ML006 = mL006;
            this.ML042 = mL042;
            this.ML093 = mL093;
            this.ML094 = mL094;
            this.ML104 = mL104;
            this.ML140 = mL140;
            this.ML160 = mL160;
            this.ML181 = mL181;
            this.OT001 = oT001;
            this.RE001 = rE001;
            this.RE003 = rE003;
            this.RE022 = rE022;
            this.RE107 = rE107;
            this.RE121 = rE121;
            this.RE156 = rE156;
            this.RE180 = rE180;
            this.ConsumerNo = consumerNo;
            this.AT001 = aT001;
            this.AT006 = aT006;
            this.AT022 = aT022;
            this.AT025 = aT025;
            this.AT041 = aT041;
            this.AT043 = aT043;
            this.AT092 = aT092;
            this.AT093 = aT093;
            this.AT103 = aT103;
            this.AT107 = aT107;
            this.AT121 = aT121;
            this.AT140 = aT140;
            this.AT141 = aT141;
            this.AT152 = aT152;
            this.AT156 = aT156;
            this.AT164 = aT164;
            this.AT167 = aT167;
            this.G002 = g002;
            this.G011 = g011;
            this.G031 = g031;
            this.G057 = g057;
            this.IN001 = iN001;
            this.IN180 = iN180;
            this.IN181 = iN181;
            this.ML001 = mL001;
            this.ML006 = mL006;
            this.ML042 = mL042;
            this.ML093 = mL093;
            this.ML094 = mL094;
            this.ML104 = mL104;
            this.ML140 = mL140;
            this.ML160 = mL160;
            this.ML181 = mL181;
            this.OT001 = oT001;
            this.RE001 = rE001;
            this.RE003 = rE003;
            this.RE022 = rE022;
            this.RE107 = rE107;
            this.RE121 = rE121;
            this.RE156 = rE156;
            this.RE180 = rE180;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets AT001
        /// </summary>
        [DataMember(Name="aT001", EmitDefaultValue=true)]
        public string AT001 { get; set; }

        /// <summary>
        /// Gets or Sets AT006
        /// </summary>
        [DataMember(Name="aT006", EmitDefaultValue=true)]
        public string AT006 { get; set; }

        /// <summary>
        /// Gets or Sets AT022
        /// </summary>
        [DataMember(Name="aT022", EmitDefaultValue=true)]
        public string AT022 { get; set; }

        /// <summary>
        /// Gets or Sets AT025
        /// </summary>
        [DataMember(Name="aT025", EmitDefaultValue=true)]
        public string AT025 { get; set; }

        /// <summary>
        /// Gets or Sets AT041
        /// </summary>
        [DataMember(Name="aT041", EmitDefaultValue=true)]
        public string AT041 { get; set; }

        /// <summary>
        /// Gets or Sets AT043
        /// </summary>
        [DataMember(Name="aT043", EmitDefaultValue=true)]
        public string AT043 { get; set; }

        /// <summary>
        /// Gets or Sets AT092
        /// </summary>
        [DataMember(Name="aT092", EmitDefaultValue=true)]
        public string AT092 { get; set; }

        /// <summary>
        /// Gets or Sets AT093
        /// </summary>
        [DataMember(Name="aT093", EmitDefaultValue=true)]
        public string AT093 { get; set; }

        /// <summary>
        /// Gets or Sets AT103
        /// </summary>
        [DataMember(Name="aT103", EmitDefaultValue=true)]
        public string AT103 { get; set; }

        /// <summary>
        /// Gets or Sets AT107
        /// </summary>
        [DataMember(Name="aT107", EmitDefaultValue=true)]
        public string AT107 { get; set; }

        /// <summary>
        /// Gets or Sets AT121
        /// </summary>
        [DataMember(Name="aT121", EmitDefaultValue=true)]
        public string AT121 { get; set; }

        /// <summary>
        /// Gets or Sets AT140
        /// </summary>
        [DataMember(Name="aT140", EmitDefaultValue=true)]
        public string AT140 { get; set; }

        /// <summary>
        /// Gets or Sets AT141
        /// </summary>
        [DataMember(Name="aT141", EmitDefaultValue=true)]
        public string AT141 { get; set; }

        /// <summary>
        /// Gets or Sets AT152
        /// </summary>
        [DataMember(Name="aT152", EmitDefaultValue=true)]
        public string AT152 { get; set; }

        /// <summary>
        /// Gets or Sets AT156
        /// </summary>
        [DataMember(Name="aT156", EmitDefaultValue=true)]
        public string AT156 { get; set; }

        /// <summary>
        /// Gets or Sets AT164
        /// </summary>
        [DataMember(Name="aT164", EmitDefaultValue=true)]
        public string AT164 { get; set; }

        /// <summary>
        /// Gets or Sets AT167
        /// </summary>
        [DataMember(Name="aT167", EmitDefaultValue=true)]
        public string AT167 { get; set; }

        /// <summary>
        /// Gets or Sets G002
        /// </summary>
        [DataMember(Name="g002", EmitDefaultValue=true)]
        public string G002 { get; set; }

        /// <summary>
        /// Gets or Sets G011
        /// </summary>
        [DataMember(Name="g011", EmitDefaultValue=true)]
        public string G011 { get; set; }

        /// <summary>
        /// Gets or Sets G031
        /// </summary>
        [DataMember(Name="g031", EmitDefaultValue=true)]
        public string G031 { get; set; }

        /// <summary>
        /// Gets or Sets G057
        /// </summary>
        [DataMember(Name="g057", EmitDefaultValue=true)]
        public string G057 { get; set; }

        /// <summary>
        /// Gets or Sets IN001
        /// </summary>
        [DataMember(Name="iN001", EmitDefaultValue=true)]
        public string IN001 { get; set; }

        /// <summary>
        /// Gets or Sets IN180
        /// </summary>
        [DataMember(Name="iN180", EmitDefaultValue=true)]
        public string IN180 { get; set; }

        /// <summary>
        /// Gets or Sets IN181
        /// </summary>
        [DataMember(Name="iN181", EmitDefaultValue=true)]
        public string IN181 { get; set; }

        /// <summary>
        /// Gets or Sets ML001
        /// </summary>
        [DataMember(Name="mL001", EmitDefaultValue=true)]
        public string ML001 { get; set; }

        /// <summary>
        /// Gets or Sets ML006
        /// </summary>
        [DataMember(Name="mL006", EmitDefaultValue=true)]
        public string ML006 { get; set; }

        /// <summary>
        /// Gets or Sets ML042
        /// </summary>
        [DataMember(Name="mL042", EmitDefaultValue=true)]
        public string ML042 { get; set; }

        /// <summary>
        /// Gets or Sets ML093
        /// </summary>
        [DataMember(Name="mL093", EmitDefaultValue=true)]
        public string ML093 { get; set; }

        /// <summary>
        /// Gets or Sets ML094
        /// </summary>
        [DataMember(Name="mL094", EmitDefaultValue=true)]
        public string ML094 { get; set; }

        /// <summary>
        /// Gets or Sets ML104
        /// </summary>
        [DataMember(Name="mL104", EmitDefaultValue=true)]
        public string ML104 { get; set; }

        /// <summary>
        /// Gets or Sets ML140
        /// </summary>
        [DataMember(Name="mL140", EmitDefaultValue=true)]
        public string ML140 { get; set; }

        /// <summary>
        /// Gets or Sets ML160
        /// </summary>
        [DataMember(Name="mL160", EmitDefaultValue=true)]
        public string ML160 { get; set; }

        /// <summary>
        /// Gets or Sets ML181
        /// </summary>
        [DataMember(Name="mL181", EmitDefaultValue=true)]
        public string ML181 { get; set; }

        /// <summary>
        /// Gets or Sets OT001
        /// </summary>
        [DataMember(Name="oT001", EmitDefaultValue=true)]
        public string OT001 { get; set; }

        /// <summary>
        /// Gets or Sets RE001
        /// </summary>
        [DataMember(Name="rE001", EmitDefaultValue=true)]
        public string RE001 { get; set; }

        /// <summary>
        /// Gets or Sets RE003
        /// </summary>
        [DataMember(Name="rE003", EmitDefaultValue=true)]
        public string RE003 { get; set; }

        /// <summary>
        /// Gets or Sets RE022
        /// </summary>
        [DataMember(Name="rE022", EmitDefaultValue=true)]
        public string RE022 { get; set; }

        /// <summary>
        /// Gets or Sets RE107
        /// </summary>
        [DataMember(Name="rE107", EmitDefaultValue=true)]
        public string RE107 { get; set; }

        /// <summary>
        /// Gets or Sets RE121
        /// </summary>
        [DataMember(Name="rE121", EmitDefaultValue=true)]
        public string RE121 { get; set; }

        /// <summary>
        /// Gets or Sets RE156
        /// </summary>
        [DataMember(Name="rE156", EmitDefaultValue=true)]
        public string RE156 { get; set; }

        /// <summary>
        /// Gets or Sets RE180
        /// </summary>
        [DataMember(Name="rE180", EmitDefaultValue=true)]
        public string RE180 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118StandardBatchCharsSB30 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  AT001: ").Append(AT001).Append("\n");
            sb.Append("  AT006: ").Append(AT006).Append("\n");
            sb.Append("  AT022: ").Append(AT022).Append("\n");
            sb.Append("  AT025: ").Append(AT025).Append("\n");
            sb.Append("  AT041: ").Append(AT041).Append("\n");
            sb.Append("  AT043: ").Append(AT043).Append("\n");
            sb.Append("  AT092: ").Append(AT092).Append("\n");
            sb.Append("  AT093: ").Append(AT093).Append("\n");
            sb.Append("  AT103: ").Append(AT103).Append("\n");
            sb.Append("  AT107: ").Append(AT107).Append("\n");
            sb.Append("  AT121: ").Append(AT121).Append("\n");
            sb.Append("  AT140: ").Append(AT140).Append("\n");
            sb.Append("  AT141: ").Append(AT141).Append("\n");
            sb.Append("  AT152: ").Append(AT152).Append("\n");
            sb.Append("  AT156: ").Append(AT156).Append("\n");
            sb.Append("  AT164: ").Append(AT164).Append("\n");
            sb.Append("  AT167: ").Append(AT167).Append("\n");
            sb.Append("  G002: ").Append(G002).Append("\n");
            sb.Append("  G011: ").Append(G011).Append("\n");
            sb.Append("  G031: ").Append(G031).Append("\n");
            sb.Append("  G057: ").Append(G057).Append("\n");
            sb.Append("  IN001: ").Append(IN001).Append("\n");
            sb.Append("  IN180: ").Append(IN180).Append("\n");
            sb.Append("  IN181: ").Append(IN181).Append("\n");
            sb.Append("  ML001: ").Append(ML001).Append("\n");
            sb.Append("  ML006: ").Append(ML006).Append("\n");
            sb.Append("  ML042: ").Append(ML042).Append("\n");
            sb.Append("  ML093: ").Append(ML093).Append("\n");
            sb.Append("  ML094: ").Append(ML094).Append("\n");
            sb.Append("  ML104: ").Append(ML104).Append("\n");
            sb.Append("  ML140: ").Append(ML140).Append("\n");
            sb.Append("  ML160: ").Append(ML160).Append("\n");
            sb.Append("  ML181: ").Append(ML181).Append("\n");
            sb.Append("  OT001: ").Append(OT001).Append("\n");
            sb.Append("  RE001: ").Append(RE001).Append("\n");
            sb.Append("  RE003: ").Append(RE003).Append("\n");
            sb.Append("  RE022: ").Append(RE022).Append("\n");
            sb.Append("  RE107: ").Append(RE107).Append("\n");
            sb.Append("  RE121: ").Append(RE121).Append("\n");
            sb.Append("  RE156: ").Append(RE156).Append("\n");
            sb.Append("  RE180: ").Append(RE180).Append("\n");
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
            return this.Equals(input as TransunionConsumer118StandardBatchCharsSB30);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118StandardBatchCharsSB30 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118StandardBatchCharsSB30 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118StandardBatchCharsSB30 input)
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
                    this.AT001 == input.AT001 ||
                    (this.AT001 != null &&
                    this.AT001.Equals(input.AT001))
                ) && 
                (
                    this.AT006 == input.AT006 ||
                    (this.AT006 != null &&
                    this.AT006.Equals(input.AT006))
                ) && 
                (
                    this.AT022 == input.AT022 ||
                    (this.AT022 != null &&
                    this.AT022.Equals(input.AT022))
                ) && 
                (
                    this.AT025 == input.AT025 ||
                    (this.AT025 != null &&
                    this.AT025.Equals(input.AT025))
                ) && 
                (
                    this.AT041 == input.AT041 ||
                    (this.AT041 != null &&
                    this.AT041.Equals(input.AT041))
                ) && 
                (
                    this.AT043 == input.AT043 ||
                    (this.AT043 != null &&
                    this.AT043.Equals(input.AT043))
                ) && 
                (
                    this.AT092 == input.AT092 ||
                    (this.AT092 != null &&
                    this.AT092.Equals(input.AT092))
                ) && 
                (
                    this.AT093 == input.AT093 ||
                    (this.AT093 != null &&
                    this.AT093.Equals(input.AT093))
                ) && 
                (
                    this.AT103 == input.AT103 ||
                    (this.AT103 != null &&
                    this.AT103.Equals(input.AT103))
                ) && 
                (
                    this.AT107 == input.AT107 ||
                    (this.AT107 != null &&
                    this.AT107.Equals(input.AT107))
                ) && 
                (
                    this.AT121 == input.AT121 ||
                    (this.AT121 != null &&
                    this.AT121.Equals(input.AT121))
                ) && 
                (
                    this.AT140 == input.AT140 ||
                    (this.AT140 != null &&
                    this.AT140.Equals(input.AT140))
                ) && 
                (
                    this.AT141 == input.AT141 ||
                    (this.AT141 != null &&
                    this.AT141.Equals(input.AT141))
                ) && 
                (
                    this.AT152 == input.AT152 ||
                    (this.AT152 != null &&
                    this.AT152.Equals(input.AT152))
                ) && 
                (
                    this.AT156 == input.AT156 ||
                    (this.AT156 != null &&
                    this.AT156.Equals(input.AT156))
                ) && 
                (
                    this.AT164 == input.AT164 ||
                    (this.AT164 != null &&
                    this.AT164.Equals(input.AT164))
                ) && 
                (
                    this.AT167 == input.AT167 ||
                    (this.AT167 != null &&
                    this.AT167.Equals(input.AT167))
                ) && 
                (
                    this.G002 == input.G002 ||
                    (this.G002 != null &&
                    this.G002.Equals(input.G002))
                ) && 
                (
                    this.G011 == input.G011 ||
                    (this.G011 != null &&
                    this.G011.Equals(input.G011))
                ) && 
                (
                    this.G031 == input.G031 ||
                    (this.G031 != null &&
                    this.G031.Equals(input.G031))
                ) && 
                (
                    this.G057 == input.G057 ||
                    (this.G057 != null &&
                    this.G057.Equals(input.G057))
                ) && 
                (
                    this.IN001 == input.IN001 ||
                    (this.IN001 != null &&
                    this.IN001.Equals(input.IN001))
                ) && 
                (
                    this.IN180 == input.IN180 ||
                    (this.IN180 != null &&
                    this.IN180.Equals(input.IN180))
                ) && 
                (
                    this.IN181 == input.IN181 ||
                    (this.IN181 != null &&
                    this.IN181.Equals(input.IN181))
                ) && 
                (
                    this.ML001 == input.ML001 ||
                    (this.ML001 != null &&
                    this.ML001.Equals(input.ML001))
                ) && 
                (
                    this.ML006 == input.ML006 ||
                    (this.ML006 != null &&
                    this.ML006.Equals(input.ML006))
                ) && 
                (
                    this.ML042 == input.ML042 ||
                    (this.ML042 != null &&
                    this.ML042.Equals(input.ML042))
                ) && 
                (
                    this.ML093 == input.ML093 ||
                    (this.ML093 != null &&
                    this.ML093.Equals(input.ML093))
                ) && 
                (
                    this.ML094 == input.ML094 ||
                    (this.ML094 != null &&
                    this.ML094.Equals(input.ML094))
                ) && 
                (
                    this.ML104 == input.ML104 ||
                    (this.ML104 != null &&
                    this.ML104.Equals(input.ML104))
                ) && 
                (
                    this.ML140 == input.ML140 ||
                    (this.ML140 != null &&
                    this.ML140.Equals(input.ML140))
                ) && 
                (
                    this.ML160 == input.ML160 ||
                    (this.ML160 != null &&
                    this.ML160.Equals(input.ML160))
                ) && 
                (
                    this.ML181 == input.ML181 ||
                    (this.ML181 != null &&
                    this.ML181.Equals(input.ML181))
                ) && 
                (
                    this.OT001 == input.OT001 ||
                    (this.OT001 != null &&
                    this.OT001.Equals(input.OT001))
                ) && 
                (
                    this.RE001 == input.RE001 ||
                    (this.RE001 != null &&
                    this.RE001.Equals(input.RE001))
                ) && 
                (
                    this.RE003 == input.RE003 ||
                    (this.RE003 != null &&
                    this.RE003.Equals(input.RE003))
                ) && 
                (
                    this.RE022 == input.RE022 ||
                    (this.RE022 != null &&
                    this.RE022.Equals(input.RE022))
                ) && 
                (
                    this.RE107 == input.RE107 ||
                    (this.RE107 != null &&
                    this.RE107.Equals(input.RE107))
                ) && 
                (
                    this.RE121 == input.RE121 ||
                    (this.RE121 != null &&
                    this.RE121.Equals(input.RE121))
                ) && 
                (
                    this.RE156 == input.RE156 ||
                    (this.RE156 != null &&
                    this.RE156.Equals(input.RE156))
                ) && 
                (
                    this.RE180 == input.RE180 ||
                    (this.RE180 != null &&
                    this.RE180.Equals(input.RE180))
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
                if (this.AT001 != null)
                    hashCode = hashCode * 59 + this.AT001.GetHashCode();
                if (this.AT006 != null)
                    hashCode = hashCode * 59 + this.AT006.GetHashCode();
                if (this.AT022 != null)
                    hashCode = hashCode * 59 + this.AT022.GetHashCode();
                if (this.AT025 != null)
                    hashCode = hashCode * 59 + this.AT025.GetHashCode();
                if (this.AT041 != null)
                    hashCode = hashCode * 59 + this.AT041.GetHashCode();
                if (this.AT043 != null)
                    hashCode = hashCode * 59 + this.AT043.GetHashCode();
                if (this.AT092 != null)
                    hashCode = hashCode * 59 + this.AT092.GetHashCode();
                if (this.AT093 != null)
                    hashCode = hashCode * 59 + this.AT093.GetHashCode();
                if (this.AT103 != null)
                    hashCode = hashCode * 59 + this.AT103.GetHashCode();
                if (this.AT107 != null)
                    hashCode = hashCode * 59 + this.AT107.GetHashCode();
                if (this.AT121 != null)
                    hashCode = hashCode * 59 + this.AT121.GetHashCode();
                if (this.AT140 != null)
                    hashCode = hashCode * 59 + this.AT140.GetHashCode();
                if (this.AT141 != null)
                    hashCode = hashCode * 59 + this.AT141.GetHashCode();
                if (this.AT152 != null)
                    hashCode = hashCode * 59 + this.AT152.GetHashCode();
                if (this.AT156 != null)
                    hashCode = hashCode * 59 + this.AT156.GetHashCode();
                if (this.AT164 != null)
                    hashCode = hashCode * 59 + this.AT164.GetHashCode();
                if (this.AT167 != null)
                    hashCode = hashCode * 59 + this.AT167.GetHashCode();
                if (this.G002 != null)
                    hashCode = hashCode * 59 + this.G002.GetHashCode();
                if (this.G011 != null)
                    hashCode = hashCode * 59 + this.G011.GetHashCode();
                if (this.G031 != null)
                    hashCode = hashCode * 59 + this.G031.GetHashCode();
                if (this.G057 != null)
                    hashCode = hashCode * 59 + this.G057.GetHashCode();
                if (this.IN001 != null)
                    hashCode = hashCode * 59 + this.IN001.GetHashCode();
                if (this.IN180 != null)
                    hashCode = hashCode * 59 + this.IN180.GetHashCode();
                if (this.IN181 != null)
                    hashCode = hashCode * 59 + this.IN181.GetHashCode();
                if (this.ML001 != null)
                    hashCode = hashCode * 59 + this.ML001.GetHashCode();
                if (this.ML006 != null)
                    hashCode = hashCode * 59 + this.ML006.GetHashCode();
                if (this.ML042 != null)
                    hashCode = hashCode * 59 + this.ML042.GetHashCode();
                if (this.ML093 != null)
                    hashCode = hashCode * 59 + this.ML093.GetHashCode();
                if (this.ML094 != null)
                    hashCode = hashCode * 59 + this.ML094.GetHashCode();
                if (this.ML104 != null)
                    hashCode = hashCode * 59 + this.ML104.GetHashCode();
                if (this.ML140 != null)
                    hashCode = hashCode * 59 + this.ML140.GetHashCode();
                if (this.ML160 != null)
                    hashCode = hashCode * 59 + this.ML160.GetHashCode();
                if (this.ML181 != null)
                    hashCode = hashCode * 59 + this.ML181.GetHashCode();
                if (this.OT001 != null)
                    hashCode = hashCode * 59 + this.OT001.GetHashCode();
                if (this.RE001 != null)
                    hashCode = hashCode * 59 + this.RE001.GetHashCode();
                if (this.RE003 != null)
                    hashCode = hashCode * 59 + this.RE003.GetHashCode();
                if (this.RE022 != null)
                    hashCode = hashCode * 59 + this.RE022.GetHashCode();
                if (this.RE107 != null)
                    hashCode = hashCode * 59 + this.RE107.GetHashCode();
                if (this.RE121 != null)
                    hashCode = hashCode * 59 + this.RE121.GetHashCode();
                if (this.RE156 != null)
                    hashCode = hashCode * 59 + this.RE156.GetHashCode();
                if (this.RE180 != null)
                    hashCode = hashCode * 59 + this.RE180.GetHashCode();
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