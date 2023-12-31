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
    /// TransunionConsumer118EvolutionCC01
    /// </summary>
    [DataContract]
    public partial class TransunionConsumer118EvolutionCC01 :  IEquatable<TransunionConsumer118EvolutionCC01>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransunionConsumer118EvolutionCC01" /> class.
        /// </summary>
        /// <param name="consumerNo">consumerNo.</param>
        /// <param name="currOwnEnq">currOwnEnq.</param>
        /// <param name="prevOwnEnq">prevOwnEnq.</param>
        /// <param name="currOtherEnq">currOtherEnq.</param>
        /// <param name="prevOtherEnq">prevOtherEnq.</param>
        /// <param name="currJdgmnt">currJdgmnt.</param>
        /// <param name="prevJdgmnt">prevJdgmnt.</param>
        /// <param name="otherJdgmnt">otherJdgmnt.</param>
        /// <param name="currNotices">currNotices.</param>
        /// <param name="prevNotices">prevNotices.</param>
        /// <param name="otherNotices">otherNotices.</param>
        /// <param name="currDefault">currDefault.</param>
        /// <param name="prevDefault">prevDefault.</param>
        /// <param name="currTraceAlerts">currTraceAlerts.</param>
        /// <param name="prevTraceAlerts">prevTraceAlerts.</param>
        /// <param name="activeAccounts">activeAccounts.</param>
        /// <param name="currPositiveLoans">currPositiveLoans.</param>
        /// <param name="currHigestMia">currHigestMia.</param>
        /// <param name="prevPositiveAccounts">prevPositiveAccounts.</param>
        /// <param name="prevHigestMia">prevHigestMia.</param>
        /// <param name="closedAccounts">closedAccounts.</param>
        /// <param name="adverseAccounts">adverseAccounts.</param>
        /// <param name="mnthsInArrears">mnthsInArrears.</param>
        /// <param name="currBalance">currBalance.</param>
        /// <param name="currMonthlyInstallment">currMonthlyInstallment.</param>
        /// <param name="cummulativeArrearsAmount">cummulativeArrearsAmount.</param>
        /// <param name="filler">filler.</param>
        /// <param name="evolutionPaymentHistory">evolutionPaymentHistory.</param>
        public TransunionConsumer118EvolutionCC01(string consumerNo = default(string), string currOwnEnq = default(string), string prevOwnEnq = default(string), string currOtherEnq = default(string), string prevOtherEnq = default(string), string currJdgmnt = default(string), string prevJdgmnt = default(string), string otherJdgmnt = default(string), string currNotices = default(string), string prevNotices = default(string), string otherNotices = default(string), string currDefault = default(string), string prevDefault = default(string), string currTraceAlerts = default(string), string prevTraceAlerts = default(string), string activeAccounts = default(string), string currPositiveLoans = default(string), string currHigestMia = default(string), string prevPositiveAccounts = default(string), string prevHigestMia = default(string), string closedAccounts = default(string), string adverseAccounts = default(string), string mnthsInArrears = default(string), string currBalance = default(string), string currMonthlyInstallment = default(string), string cummulativeArrearsAmount = default(string), string filler = default(string), List<TransunionConsumer118EvolutionPaymentHistory> evolutionPaymentHistory = default(List<TransunionConsumer118EvolutionPaymentHistory>))
        {
            this.ConsumerNo = consumerNo;
            this.CurrOwnEnq = currOwnEnq;
            this.PrevOwnEnq = prevOwnEnq;
            this.CurrOtherEnq = currOtherEnq;
            this.PrevOtherEnq = prevOtherEnq;
            this.CurrJdgmnt = currJdgmnt;
            this.PrevJdgmnt = prevJdgmnt;
            this.OtherJdgmnt = otherJdgmnt;
            this.CurrNotices = currNotices;
            this.PrevNotices = prevNotices;
            this.OtherNotices = otherNotices;
            this.CurrDefault = currDefault;
            this.PrevDefault = prevDefault;
            this.CurrTraceAlerts = currTraceAlerts;
            this.PrevTraceAlerts = prevTraceAlerts;
            this.ActiveAccounts = activeAccounts;
            this.CurrPositiveLoans = currPositiveLoans;
            this.CurrHigestMia = currHigestMia;
            this.PrevPositiveAccounts = prevPositiveAccounts;
            this.PrevHigestMia = prevHigestMia;
            this.ClosedAccounts = closedAccounts;
            this.AdverseAccounts = adverseAccounts;
            this.MnthsInArrears = mnthsInArrears;
            this.CurrBalance = currBalance;
            this.CurrMonthlyInstallment = currMonthlyInstallment;
            this.CummulativeArrearsAmount = cummulativeArrearsAmount;
            this.Filler = filler;
            this.EvolutionPaymentHistory = evolutionPaymentHistory;
            this.ConsumerNo = consumerNo;
            this.CurrOwnEnq = currOwnEnq;
            this.PrevOwnEnq = prevOwnEnq;
            this.CurrOtherEnq = currOtherEnq;
            this.PrevOtherEnq = prevOtherEnq;
            this.CurrJdgmnt = currJdgmnt;
            this.PrevJdgmnt = prevJdgmnt;
            this.OtherJdgmnt = otherJdgmnt;
            this.CurrNotices = currNotices;
            this.PrevNotices = prevNotices;
            this.OtherNotices = otherNotices;
            this.CurrDefault = currDefault;
            this.PrevDefault = prevDefault;
            this.CurrTraceAlerts = currTraceAlerts;
            this.PrevTraceAlerts = prevTraceAlerts;
            this.ActiveAccounts = activeAccounts;
            this.CurrPositiveLoans = currPositiveLoans;
            this.CurrHigestMia = currHigestMia;
            this.PrevPositiveAccounts = prevPositiveAccounts;
            this.PrevHigestMia = prevHigestMia;
            this.ClosedAccounts = closedAccounts;
            this.AdverseAccounts = adverseAccounts;
            this.MnthsInArrears = mnthsInArrears;
            this.CurrBalance = currBalance;
            this.CurrMonthlyInstallment = currMonthlyInstallment;
            this.CummulativeArrearsAmount = cummulativeArrearsAmount;
            this.Filler = filler;
            this.EvolutionPaymentHistory = evolutionPaymentHistory;
        }

        /// <summary>
        /// Gets or Sets ConsumerNo
        /// </summary>
        [DataMember(Name="consumerNo", EmitDefaultValue=true)]
        public string ConsumerNo { get; set; }

        /// <summary>
        /// Gets or Sets CurrOwnEnq
        /// </summary>
        [DataMember(Name="curr_own_enq", EmitDefaultValue=true)]
        public string CurrOwnEnq { get; set; }

        /// <summary>
        /// Gets or Sets PrevOwnEnq
        /// </summary>
        [DataMember(Name="prev_own_enq", EmitDefaultValue=true)]
        public string PrevOwnEnq { get; set; }

        /// <summary>
        /// Gets or Sets CurrOtherEnq
        /// </summary>
        [DataMember(Name="curr_other_enq", EmitDefaultValue=true)]
        public string CurrOtherEnq { get; set; }

        /// <summary>
        /// Gets or Sets PrevOtherEnq
        /// </summary>
        [DataMember(Name="prev_other_enq", EmitDefaultValue=true)]
        public string PrevOtherEnq { get; set; }

        /// <summary>
        /// Gets or Sets CurrJdgmnt
        /// </summary>
        [DataMember(Name="curr_jdgmnt", EmitDefaultValue=true)]
        public string CurrJdgmnt { get; set; }

        /// <summary>
        /// Gets or Sets PrevJdgmnt
        /// </summary>
        [DataMember(Name="prev_jdgmnt", EmitDefaultValue=true)]
        public string PrevJdgmnt { get; set; }

        /// <summary>
        /// Gets or Sets OtherJdgmnt
        /// </summary>
        [DataMember(Name="other_jdgmnt", EmitDefaultValue=true)]
        public string OtherJdgmnt { get; set; }

        /// <summary>
        /// Gets or Sets CurrNotices
        /// </summary>
        [DataMember(Name="curr_notices", EmitDefaultValue=true)]
        public string CurrNotices { get; set; }

        /// <summary>
        /// Gets or Sets PrevNotices
        /// </summary>
        [DataMember(Name="prev_notices", EmitDefaultValue=true)]
        public string PrevNotices { get; set; }

        /// <summary>
        /// Gets or Sets OtherNotices
        /// </summary>
        [DataMember(Name="other_notices", EmitDefaultValue=true)]
        public string OtherNotices { get; set; }

        /// <summary>
        /// Gets or Sets CurrDefault
        /// </summary>
        [DataMember(Name="curr_default", EmitDefaultValue=true)]
        public string CurrDefault { get; set; }

        /// <summary>
        /// Gets or Sets PrevDefault
        /// </summary>
        [DataMember(Name="prev_default", EmitDefaultValue=true)]
        public string PrevDefault { get; set; }

        /// <summary>
        /// Gets or Sets CurrTraceAlerts
        /// </summary>
        [DataMember(Name="curr_trace_alerts", EmitDefaultValue=true)]
        public string CurrTraceAlerts { get; set; }

        /// <summary>
        /// Gets or Sets PrevTraceAlerts
        /// </summary>
        [DataMember(Name="prev_trace_alerts", EmitDefaultValue=true)]
        public string PrevTraceAlerts { get; set; }

        /// <summary>
        /// Gets or Sets ActiveAccounts
        /// </summary>
        [DataMember(Name="active_accounts", EmitDefaultValue=true)]
        public string ActiveAccounts { get; set; }

        /// <summary>
        /// Gets or Sets CurrPositiveLoans
        /// </summary>
        [DataMember(Name="curr_positive_loans", EmitDefaultValue=true)]
        public string CurrPositiveLoans { get; set; }

        /// <summary>
        /// Gets or Sets CurrHigestMia
        /// </summary>
        [DataMember(Name="curr_higest_mia", EmitDefaultValue=true)]
        public string CurrHigestMia { get; set; }

        /// <summary>
        /// Gets or Sets PrevPositiveAccounts
        /// </summary>
        [DataMember(Name="prev_positive_accounts", EmitDefaultValue=true)]
        public string PrevPositiveAccounts { get; set; }

        /// <summary>
        /// Gets or Sets PrevHigestMia
        /// </summary>
        [DataMember(Name="prev_higest_mia", EmitDefaultValue=true)]
        public string PrevHigestMia { get; set; }

        /// <summary>
        /// Gets or Sets ClosedAccounts
        /// </summary>
        [DataMember(Name="closed_accounts", EmitDefaultValue=true)]
        public string ClosedAccounts { get; set; }

        /// <summary>
        /// Gets or Sets AdverseAccounts
        /// </summary>
        [DataMember(Name="adverse_accounts", EmitDefaultValue=true)]
        public string AdverseAccounts { get; set; }

        /// <summary>
        /// Gets or Sets MnthsInArrears
        /// </summary>
        [DataMember(Name="mnths_in_arrears", EmitDefaultValue=true)]
        public string MnthsInArrears { get; set; }

        /// <summary>
        /// Gets or Sets CurrBalance
        /// </summary>
        [DataMember(Name="curr_balance", EmitDefaultValue=true)]
        public string CurrBalance { get; set; }

        /// <summary>
        /// Gets or Sets CurrMonthlyInstallment
        /// </summary>
        [DataMember(Name="curr_monthly_installment", EmitDefaultValue=true)]
        public string CurrMonthlyInstallment { get; set; }

        /// <summary>
        /// Gets or Sets CummulativeArrearsAmount
        /// </summary>
        [DataMember(Name="cummulative_arrears_amount", EmitDefaultValue=true)]
        public string CummulativeArrearsAmount { get; set; }

        /// <summary>
        /// Gets or Sets Filler
        /// </summary>
        [DataMember(Name="filler", EmitDefaultValue=true)]
        public string Filler { get; set; }

        /// <summary>
        /// Gets or Sets EvolutionPaymentHistory
        /// </summary>
        [DataMember(Name="evolutionPaymentHistory", EmitDefaultValue=true)]
        public List<TransunionConsumer118EvolutionPaymentHistory> EvolutionPaymentHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransunionConsumer118EvolutionCC01 {\n");
            sb.Append("  ConsumerNo: ").Append(ConsumerNo).Append("\n");
            sb.Append("  CurrOwnEnq: ").Append(CurrOwnEnq).Append("\n");
            sb.Append("  PrevOwnEnq: ").Append(PrevOwnEnq).Append("\n");
            sb.Append("  CurrOtherEnq: ").Append(CurrOtherEnq).Append("\n");
            sb.Append("  PrevOtherEnq: ").Append(PrevOtherEnq).Append("\n");
            sb.Append("  CurrJdgmnt: ").Append(CurrJdgmnt).Append("\n");
            sb.Append("  PrevJdgmnt: ").Append(PrevJdgmnt).Append("\n");
            sb.Append("  OtherJdgmnt: ").Append(OtherJdgmnt).Append("\n");
            sb.Append("  CurrNotices: ").Append(CurrNotices).Append("\n");
            sb.Append("  PrevNotices: ").Append(PrevNotices).Append("\n");
            sb.Append("  OtherNotices: ").Append(OtherNotices).Append("\n");
            sb.Append("  CurrDefault: ").Append(CurrDefault).Append("\n");
            sb.Append("  PrevDefault: ").Append(PrevDefault).Append("\n");
            sb.Append("  CurrTraceAlerts: ").Append(CurrTraceAlerts).Append("\n");
            sb.Append("  PrevTraceAlerts: ").Append(PrevTraceAlerts).Append("\n");
            sb.Append("  ActiveAccounts: ").Append(ActiveAccounts).Append("\n");
            sb.Append("  CurrPositiveLoans: ").Append(CurrPositiveLoans).Append("\n");
            sb.Append("  CurrHigestMia: ").Append(CurrHigestMia).Append("\n");
            sb.Append("  PrevPositiveAccounts: ").Append(PrevPositiveAccounts).Append("\n");
            sb.Append("  PrevHigestMia: ").Append(PrevHigestMia).Append("\n");
            sb.Append("  ClosedAccounts: ").Append(ClosedAccounts).Append("\n");
            sb.Append("  AdverseAccounts: ").Append(AdverseAccounts).Append("\n");
            sb.Append("  MnthsInArrears: ").Append(MnthsInArrears).Append("\n");
            sb.Append("  CurrBalance: ").Append(CurrBalance).Append("\n");
            sb.Append("  CurrMonthlyInstallment: ").Append(CurrMonthlyInstallment).Append("\n");
            sb.Append("  CummulativeArrearsAmount: ").Append(CummulativeArrearsAmount).Append("\n");
            sb.Append("  Filler: ").Append(Filler).Append("\n");
            sb.Append("  EvolutionPaymentHistory: ").Append(EvolutionPaymentHistory).Append("\n");
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
            return this.Equals(input as TransunionConsumer118EvolutionCC01);
        }

        /// <summary>
        /// Returns true if TransunionConsumer118EvolutionCC01 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransunionConsumer118EvolutionCC01 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransunionConsumer118EvolutionCC01 input)
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
                    this.CurrOwnEnq == input.CurrOwnEnq ||
                    (this.CurrOwnEnq != null &&
                    this.CurrOwnEnq.Equals(input.CurrOwnEnq))
                ) && 
                (
                    this.PrevOwnEnq == input.PrevOwnEnq ||
                    (this.PrevOwnEnq != null &&
                    this.PrevOwnEnq.Equals(input.PrevOwnEnq))
                ) && 
                (
                    this.CurrOtherEnq == input.CurrOtherEnq ||
                    (this.CurrOtherEnq != null &&
                    this.CurrOtherEnq.Equals(input.CurrOtherEnq))
                ) && 
                (
                    this.PrevOtherEnq == input.PrevOtherEnq ||
                    (this.PrevOtherEnq != null &&
                    this.PrevOtherEnq.Equals(input.PrevOtherEnq))
                ) && 
                (
                    this.CurrJdgmnt == input.CurrJdgmnt ||
                    (this.CurrJdgmnt != null &&
                    this.CurrJdgmnt.Equals(input.CurrJdgmnt))
                ) && 
                (
                    this.PrevJdgmnt == input.PrevJdgmnt ||
                    (this.PrevJdgmnt != null &&
                    this.PrevJdgmnt.Equals(input.PrevJdgmnt))
                ) && 
                (
                    this.OtherJdgmnt == input.OtherJdgmnt ||
                    (this.OtherJdgmnt != null &&
                    this.OtherJdgmnt.Equals(input.OtherJdgmnt))
                ) && 
                (
                    this.CurrNotices == input.CurrNotices ||
                    (this.CurrNotices != null &&
                    this.CurrNotices.Equals(input.CurrNotices))
                ) && 
                (
                    this.PrevNotices == input.PrevNotices ||
                    (this.PrevNotices != null &&
                    this.PrevNotices.Equals(input.PrevNotices))
                ) && 
                (
                    this.OtherNotices == input.OtherNotices ||
                    (this.OtherNotices != null &&
                    this.OtherNotices.Equals(input.OtherNotices))
                ) && 
                (
                    this.CurrDefault == input.CurrDefault ||
                    (this.CurrDefault != null &&
                    this.CurrDefault.Equals(input.CurrDefault))
                ) && 
                (
                    this.PrevDefault == input.PrevDefault ||
                    (this.PrevDefault != null &&
                    this.PrevDefault.Equals(input.PrevDefault))
                ) && 
                (
                    this.CurrTraceAlerts == input.CurrTraceAlerts ||
                    (this.CurrTraceAlerts != null &&
                    this.CurrTraceAlerts.Equals(input.CurrTraceAlerts))
                ) && 
                (
                    this.PrevTraceAlerts == input.PrevTraceAlerts ||
                    (this.PrevTraceAlerts != null &&
                    this.PrevTraceAlerts.Equals(input.PrevTraceAlerts))
                ) && 
                (
                    this.ActiveAccounts == input.ActiveAccounts ||
                    (this.ActiveAccounts != null &&
                    this.ActiveAccounts.Equals(input.ActiveAccounts))
                ) && 
                (
                    this.CurrPositiveLoans == input.CurrPositiveLoans ||
                    (this.CurrPositiveLoans != null &&
                    this.CurrPositiveLoans.Equals(input.CurrPositiveLoans))
                ) && 
                (
                    this.CurrHigestMia == input.CurrHigestMia ||
                    (this.CurrHigestMia != null &&
                    this.CurrHigestMia.Equals(input.CurrHigestMia))
                ) && 
                (
                    this.PrevPositiveAccounts == input.PrevPositiveAccounts ||
                    (this.PrevPositiveAccounts != null &&
                    this.PrevPositiveAccounts.Equals(input.PrevPositiveAccounts))
                ) && 
                (
                    this.PrevHigestMia == input.PrevHigestMia ||
                    (this.PrevHigestMia != null &&
                    this.PrevHigestMia.Equals(input.PrevHigestMia))
                ) && 
                (
                    this.ClosedAccounts == input.ClosedAccounts ||
                    (this.ClosedAccounts != null &&
                    this.ClosedAccounts.Equals(input.ClosedAccounts))
                ) && 
                (
                    this.AdverseAccounts == input.AdverseAccounts ||
                    (this.AdverseAccounts != null &&
                    this.AdverseAccounts.Equals(input.AdverseAccounts))
                ) && 
                (
                    this.MnthsInArrears == input.MnthsInArrears ||
                    (this.MnthsInArrears != null &&
                    this.MnthsInArrears.Equals(input.MnthsInArrears))
                ) && 
                (
                    this.CurrBalance == input.CurrBalance ||
                    (this.CurrBalance != null &&
                    this.CurrBalance.Equals(input.CurrBalance))
                ) && 
                (
                    this.CurrMonthlyInstallment == input.CurrMonthlyInstallment ||
                    (this.CurrMonthlyInstallment != null &&
                    this.CurrMonthlyInstallment.Equals(input.CurrMonthlyInstallment))
                ) && 
                (
                    this.CummulativeArrearsAmount == input.CummulativeArrearsAmount ||
                    (this.CummulativeArrearsAmount != null &&
                    this.CummulativeArrearsAmount.Equals(input.CummulativeArrearsAmount))
                ) && 
                (
                    this.Filler == input.Filler ||
                    (this.Filler != null &&
                    this.Filler.Equals(input.Filler))
                ) && 
                (
                    this.EvolutionPaymentHistory == input.EvolutionPaymentHistory ||
                    this.EvolutionPaymentHistory != null &&
                    input.EvolutionPaymentHistory != null &&
                    this.EvolutionPaymentHistory.SequenceEqual(input.EvolutionPaymentHistory)
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
                if (this.CurrOwnEnq != null)
                    hashCode = hashCode * 59 + this.CurrOwnEnq.GetHashCode();
                if (this.PrevOwnEnq != null)
                    hashCode = hashCode * 59 + this.PrevOwnEnq.GetHashCode();
                if (this.CurrOtherEnq != null)
                    hashCode = hashCode * 59 + this.CurrOtherEnq.GetHashCode();
                if (this.PrevOtherEnq != null)
                    hashCode = hashCode * 59 + this.PrevOtherEnq.GetHashCode();
                if (this.CurrJdgmnt != null)
                    hashCode = hashCode * 59 + this.CurrJdgmnt.GetHashCode();
                if (this.PrevJdgmnt != null)
                    hashCode = hashCode * 59 + this.PrevJdgmnt.GetHashCode();
                if (this.OtherJdgmnt != null)
                    hashCode = hashCode * 59 + this.OtherJdgmnt.GetHashCode();
                if (this.CurrNotices != null)
                    hashCode = hashCode * 59 + this.CurrNotices.GetHashCode();
                if (this.PrevNotices != null)
                    hashCode = hashCode * 59 + this.PrevNotices.GetHashCode();
                if (this.OtherNotices != null)
                    hashCode = hashCode * 59 + this.OtherNotices.GetHashCode();
                if (this.CurrDefault != null)
                    hashCode = hashCode * 59 + this.CurrDefault.GetHashCode();
                if (this.PrevDefault != null)
                    hashCode = hashCode * 59 + this.PrevDefault.GetHashCode();
                if (this.CurrTraceAlerts != null)
                    hashCode = hashCode * 59 + this.CurrTraceAlerts.GetHashCode();
                if (this.PrevTraceAlerts != null)
                    hashCode = hashCode * 59 + this.PrevTraceAlerts.GetHashCode();
                if (this.ActiveAccounts != null)
                    hashCode = hashCode * 59 + this.ActiveAccounts.GetHashCode();
                if (this.CurrPositiveLoans != null)
                    hashCode = hashCode * 59 + this.CurrPositiveLoans.GetHashCode();
                if (this.CurrHigestMia != null)
                    hashCode = hashCode * 59 + this.CurrHigestMia.GetHashCode();
                if (this.PrevPositiveAccounts != null)
                    hashCode = hashCode * 59 + this.PrevPositiveAccounts.GetHashCode();
                if (this.PrevHigestMia != null)
                    hashCode = hashCode * 59 + this.PrevHigestMia.GetHashCode();
                if (this.ClosedAccounts != null)
                    hashCode = hashCode * 59 + this.ClosedAccounts.GetHashCode();
                if (this.AdverseAccounts != null)
                    hashCode = hashCode * 59 + this.AdverseAccounts.GetHashCode();
                if (this.MnthsInArrears != null)
                    hashCode = hashCode * 59 + this.MnthsInArrears.GetHashCode();
                if (this.CurrBalance != null)
                    hashCode = hashCode * 59 + this.CurrBalance.GetHashCode();
                if (this.CurrMonthlyInstallment != null)
                    hashCode = hashCode * 59 + this.CurrMonthlyInstallment.GetHashCode();
                if (this.CummulativeArrearsAmount != null)
                    hashCode = hashCode * 59 + this.CummulativeArrearsAmount.GetHashCode();
                if (this.Filler != null)
                    hashCode = hashCode * 59 + this.Filler.GetHashCode();
                if (this.EvolutionPaymentHistory != null)
                    hashCode = hashCode * 59 + this.EvolutionPaymentHistory.GetHashCode();
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
