/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace Square.Connect.Model
{
    /// <summary>
    /// V1Tender
    /// </summary>
    [DataContract]
    public partial class V1Tender :  IEquatable<V1Tender>, IValidatableObject
    {
        /// <summary>
        /// The type of tender.
        /// </summary>
        /// <value>The type of tender.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum CREDITCARD for "CREDIT_CARD"
            /// </summary>
            [EnumMember(Value = "CREDIT_CARD")]
            CREDITCARD,
            
            /// <summary>
            /// Enum CASH for "CASH"
            /// </summary>
            [EnumMember(Value = "CASH")]
            CASH,
            
            /// <summary>
            /// Enum THIRDPARTYCARD for "THIRD_PARTY_CARD"
            /// </summary>
            [EnumMember(Value = "THIRD_PARTY_CARD")]
            THIRDPARTYCARD,
            
            /// <summary>
            /// Enum NOSALE for "NO_SALE"
            /// </summary>
            [EnumMember(Value = "NO_SALE")]
            NOSALE,
            
            /// <summary>
            /// Enum SQUAREWALLET for "SQUARE_WALLET"
            /// </summary>
            [EnumMember(Value = "SQUARE_WALLET")]
            SQUAREWALLET,
            
            /// <summary>
            /// Enum SQUAREGIFTCARD for "SQUARE_GIFT_CARD"
            /// </summary>
            [EnumMember(Value = "SQUARE_GIFT_CARD")]
            SQUAREGIFTCARD,
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// The brand of credit card provided.
        /// </summary>
        /// <value>The brand of credit card provided.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardBrandEnum
        {
            
            /// <summary>
            /// Enum OTHERBRAND for "OTHER_BRAND"
            /// </summary>
            [EnumMember(Value = "OTHER_BRAND")]
            OTHERBRAND,
            
            /// <summary>
            /// Enum VISA for "VISA"
            /// </summary>
            [EnumMember(Value = "VISA")]
            VISA,
            
            /// <summary>
            /// Enum MASTERCARD for "MASTER_CARD"
            /// </summary>
            [EnumMember(Value = "MASTER_CARD")]
            MASTERCARD,
            
            /// <summary>
            /// Enum AMERICANEXPRESS for "AMERICAN_EXPRESS"
            /// </summary>
            [EnumMember(Value = "AMERICAN_EXPRESS")]
            AMERICANEXPRESS,
            
            /// <summary>
            /// Enum DISCOVER for "DISCOVER"
            /// </summary>
            [EnumMember(Value = "DISCOVER")]
            DISCOVER,
            
            /// <summary>
            /// Enum DISCOVERDINERS for "DISCOVER_DINERS"
            /// </summary>
            [EnumMember(Value = "DISCOVER_DINERS")]
            DISCOVERDINERS,
            
            /// <summary>
            /// Enum JCB for "JCB"
            /// </summary>
            [EnumMember(Value = "JCB")]
            JCB,
            
            /// <summary>
            /// Enum CHINAUNIONPAY for "CHINA_UNIONPAY"
            /// </summary>
            [EnumMember(Value = "CHINA_UNIONPAY")]
            CHINAUNIONPAY,
            
            /// <summary>
            /// Enum SQUAREGIFTCARD for "SQUARE_GIFT_CARD"
            /// </summary>
            [EnumMember(Value = "SQUARE_GIFT_CARD")]
            SQUAREGIFTCARD
        }

        /// <summary>
        /// The tender's unique ID.
        /// </summary>
        /// <value>The tender's unique ID.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntryMethodEnum
        {
            
            /// <summary>
            /// Enum MANUAL for "MANUAL"
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL,
            
            /// <summary>
            /// Enum SCANNED for "SCANNED"
            /// </summary>
            [EnumMember(Value = "SCANNED")]
            SCANNED,
            
            /// <summary>
            /// Enum SQUARECASH for "SQUARE_CASH"
            /// </summary>
            [EnumMember(Value = "SQUARE_CASH")]
            SQUARECASH,
            
            /// <summary>
            /// Enum SQUAREWALLET for "SQUARE_WALLET"
            /// </summary>
            [EnumMember(Value = "SQUARE_WALLET")]
            SQUAREWALLET,
            
            /// <summary>
            /// Enum SWIPED for "SWIPED"
            /// </summary>
            [EnumMember(Value = "SWIPED")]
            SWIPED,
            
            /// <summary>
            /// Enum WEBFORM for "WEB_FORM"
            /// </summary>
            [EnumMember(Value = "WEB_FORM")]
            WEBFORM,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// The type of tender.
        /// </summary>
        /// <value>The type of tender.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The brand of credit card provided.
        /// </summary>
        /// <value>The brand of credit card provided.</value>
        [DataMember(Name="card_brand", EmitDefaultValue=false)]
        public CardBrandEnum? CardBrand { get; set; }
        /// <summary>
        /// The tender's unique ID.
        /// </summary>
        /// <value>The tender's unique ID.</value>
        [DataMember(Name="entry_method", EmitDefaultValue=false)]
        public EntryMethodEnum? EntryMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Tender" /> class.
        /// </summary>
        /// <param name="Id">The tender&#39;s unique ID..</param>
        /// <param name="Type">The type of tender..</param>
        /// <param name="Name">A human-readable description of the tender..</param>
        /// <param name="EmployeeId">The ID of the employee that processed the tender..</param>
        /// <param name="ReceiptUrl">The URL of the receipt for the tender..</param>
        /// <param name="CardBrand">The brand of credit card provided..</param>
        /// <param name="PanSuffix">The last four digits of the provided credit card&#39;s account number..</param>
        /// <param name="EntryMethod">The tender&#39;s unique ID..</param>
        /// <param name="PaymentNote">Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type: OTHER..</param>
        /// <param name="TotalMoney">The total amount of money provided in this form of tender..</param>
        /// <param name="TenderedMoney">The amount of total_money applied to the payment..</param>
        /// <param name="TenderedAt">The time when the tender was created, in ISO 8601 format..</param>
        /// <param name="SettledAt">The time when the tender was settled, in ISO 8601 format..</param>
        /// <param name="ChangeBackMoney">The amount of total_money returned to the buyer as change..</param>
        /// <param name="RefundedMoney">The total of all refunds applied to this tender. This amount is always negative or zero..</param>
        /// <param name="IsExchange">Indicates whether or not the tender is associated with an exchange. If is_exchange is true, the tender represents the value of goods returned in an exchange not the actual money paid. The exchange value reduces the tender amounts needed to pay for items purchased in the exchange..</param>
        public V1Tender(string Id = default(string), TypeEnum? Type = default(TypeEnum?), string Name = default(string), string EmployeeId = default(string), string ReceiptUrl = default(string), CardBrandEnum? CardBrand = default(CardBrandEnum?), string PanSuffix = default(string), EntryMethodEnum? EntryMethod = default(EntryMethodEnum?), string PaymentNote = default(string), V1Money TotalMoney = default(V1Money), V1Money TenderedMoney = default(V1Money), string TenderedAt = default(string), string SettledAt = default(string), V1Money ChangeBackMoney = default(V1Money), V1Money RefundedMoney = default(V1Money), bool? IsExchange = default(bool?))
        {
            this.Id = Id;
            this.Type = Type;
            this.Name = Name;
            this.EmployeeId = EmployeeId;
            this.ReceiptUrl = ReceiptUrl;
            this.CardBrand = CardBrand;
            this.PanSuffix = PanSuffix;
            this.EntryMethod = EntryMethod;
            this.PaymentNote = PaymentNote;
            this.TotalMoney = TotalMoney;
            this.TenderedMoney = TenderedMoney;
            this.TenderedAt = TenderedAt;
            this.SettledAt = SettledAt;
            this.ChangeBackMoney = ChangeBackMoney;
            this.RefundedMoney = RefundedMoney;
            this.IsExchange = IsExchange;
        }
        
        /// <summary>
        /// The tender&#39;s unique ID.
        /// </summary>
        /// <value>The tender&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// A human-readable description of the tender.
        /// </summary>
        /// <value>A human-readable description of the tender.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The ID of the employee that processed the tender.
        /// </summary>
        /// <value>The ID of the employee that processed the tender.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// The URL of the receipt for the tender.
        /// </summary>
        /// <value>The URL of the receipt for the tender.</value>
        [DataMember(Name="receipt_url", EmitDefaultValue=false)]
        public string ReceiptUrl { get; set; }
        /// <summary>
        /// The last four digits of the provided credit card&#39;s account number.
        /// </summary>
        /// <value>The last four digits of the provided credit card&#39;s account number.</value>
        [DataMember(Name="pan_suffix", EmitDefaultValue=false)]
        public string PanSuffix { get; set; }
        /// <summary>
        /// Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type: OTHER.
        /// </summary>
        /// <value>Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type: OTHER.</value>
        [DataMember(Name="payment_note", EmitDefaultValue=false)]
        public string PaymentNote { get; set; }
        /// <summary>
        /// The total amount of money provided in this form of tender.
        /// </summary>
        /// <value>The total amount of money provided in this form of tender.</value>
        [DataMember(Name="total_money", EmitDefaultValue=false)]
        public V1Money TotalMoney { get; set; }
        /// <summary>
        /// The amount of total_money applied to the payment.
        /// </summary>
        /// <value>The amount of total_money applied to the payment.</value>
        [DataMember(Name="tendered_money", EmitDefaultValue=false)]
        public V1Money TenderedMoney { get; set; }
        /// <summary>
        /// The time when the tender was created, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the tender was created, in ISO 8601 format.</value>
        [DataMember(Name="tendered_at", EmitDefaultValue=false)]
        public string TenderedAt { get; set; }
        /// <summary>
        /// The time when the tender was settled, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the tender was settled, in ISO 8601 format.</value>
        [DataMember(Name="settled_at", EmitDefaultValue=false)]
        public string SettledAt { get; set; }
        /// <summary>
        /// The amount of total_money returned to the buyer as change.
        /// </summary>
        /// <value>The amount of total_money returned to the buyer as change.</value>
        [DataMember(Name="change_back_money", EmitDefaultValue=false)]
        public V1Money ChangeBackMoney { get; set; }
        /// <summary>
        /// The total of all refunds applied to this tender. This amount is always negative or zero.
        /// </summary>
        /// <value>The total of all refunds applied to this tender. This amount is always negative or zero.</value>
        [DataMember(Name="refunded_money", EmitDefaultValue=false)]
        public V1Money RefundedMoney { get; set; }
        /// <summary>
        /// Indicates whether or not the tender is associated with an exchange. If is_exchange is true, the tender represents the value of goods returned in an exchange not the actual money paid. The exchange value reduces the tender amounts needed to pay for items purchased in the exchange.
        /// </summary>
        /// <value>Indicates whether or not the tender is associated with an exchange. If is_exchange is true, the tender represents the value of goods returned in an exchange not the actual money paid. The exchange value reduces the tender amounts needed to pay for items purchased in the exchange.</value>
        [DataMember(Name="is_exchange", EmitDefaultValue=false)]
        public bool? IsExchange { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Tender {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  ReceiptUrl: ").Append(ReceiptUrl).Append("\n");
            sb.Append("  CardBrand: ").Append(CardBrand).Append("\n");
            sb.Append("  PanSuffix: ").Append(PanSuffix).Append("\n");
            sb.Append("  EntryMethod: ").Append(EntryMethod).Append("\n");
            sb.Append("  PaymentNote: ").Append(PaymentNote).Append("\n");
            sb.Append("  TotalMoney: ").Append(TotalMoney).Append("\n");
            sb.Append("  TenderedMoney: ").Append(TenderedMoney).Append("\n");
            sb.Append("  TenderedAt: ").Append(TenderedAt).Append("\n");
            sb.Append("  SettledAt: ").Append(SettledAt).Append("\n");
            sb.Append("  ChangeBackMoney: ").Append(ChangeBackMoney).Append("\n");
            sb.Append("  RefundedMoney: ").Append(RefundedMoney).Append("\n");
            sb.Append("  IsExchange: ").Append(IsExchange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1Tender);
        }

        /// <summary>
        /// Returns true if V1Tender instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Tender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Tender other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.ReceiptUrl == other.ReceiptUrl ||
                    this.ReceiptUrl != null &&
                    this.ReceiptUrl.Equals(other.ReceiptUrl)
                ) && 
                (
                    this.CardBrand == other.CardBrand ||
                    this.CardBrand != null &&
                    this.CardBrand.Equals(other.CardBrand)
                ) && 
                (
                    this.PanSuffix == other.PanSuffix ||
                    this.PanSuffix != null &&
                    this.PanSuffix.Equals(other.PanSuffix)
                ) && 
                (
                    this.EntryMethod == other.EntryMethod ||
                    this.EntryMethod != null &&
                    this.EntryMethod.Equals(other.EntryMethod)
                ) && 
                (
                    this.PaymentNote == other.PaymentNote ||
                    this.PaymentNote != null &&
                    this.PaymentNote.Equals(other.PaymentNote)
                ) && 
                (
                    this.TotalMoney == other.TotalMoney ||
                    this.TotalMoney != null &&
                    this.TotalMoney.Equals(other.TotalMoney)
                ) && 
                (
                    this.TenderedMoney == other.TenderedMoney ||
                    this.TenderedMoney != null &&
                    this.TenderedMoney.Equals(other.TenderedMoney)
                ) && 
                (
                    this.TenderedAt == other.TenderedAt ||
                    this.TenderedAt != null &&
                    this.TenderedAt.Equals(other.TenderedAt)
                ) && 
                (
                    this.SettledAt == other.SettledAt ||
                    this.SettledAt != null &&
                    this.SettledAt.Equals(other.SettledAt)
                ) && 
                (
                    this.ChangeBackMoney == other.ChangeBackMoney ||
                    this.ChangeBackMoney != null &&
                    this.ChangeBackMoney.Equals(other.ChangeBackMoney)
                ) && 
                (
                    this.RefundedMoney == other.RefundedMoney ||
                    this.RefundedMoney != null &&
                    this.RefundedMoney.Equals(other.RefundedMoney)
                ) && 
                (
                    this.IsExchange == other.IsExchange ||
                    this.IsExchange != null &&
                    this.IsExchange.Equals(other.IsExchange)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.ReceiptUrl != null)
                    hash = hash * 59 + this.ReceiptUrl.GetHashCode();
                if (this.CardBrand != null)
                    hash = hash * 59 + this.CardBrand.GetHashCode();
                if (this.PanSuffix != null)
                    hash = hash * 59 + this.PanSuffix.GetHashCode();
                if (this.EntryMethod != null)
                    hash = hash * 59 + this.EntryMethod.GetHashCode();
                if (this.PaymentNote != null)
                    hash = hash * 59 + this.PaymentNote.GetHashCode();
                if (this.TotalMoney != null)
                    hash = hash * 59 + this.TotalMoney.GetHashCode();
                if (this.TenderedMoney != null)
                    hash = hash * 59 + this.TenderedMoney.GetHashCode();
                if (this.TenderedAt != null)
                    hash = hash * 59 + this.TenderedAt.GetHashCode();
                if (this.SettledAt != null)
                    hash = hash * 59 + this.SettledAt.GetHashCode();
                if (this.ChangeBackMoney != null)
                    hash = hash * 59 + this.ChangeBackMoney.GetHashCode();
                if (this.RefundedMoney != null)
                    hash = hash * 59 + this.RefundedMoney.GetHashCode();
                if (this.IsExchange != null)
                    hash = hash * 59 + this.IsExchange.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
