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
    /// V1Payment
    /// </summary>
    [DataContract]
    public partial class V1Payment :  IEquatable<V1Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Payment" /> class.
        /// </summary>
        /// <param name="Id">The payment&#39;s unique identifier..</param>
        /// <param name="MerchantId">The unique identifier of the merchant that took the payment..</param>
        /// <param name="CreatedAt">The time when the payment was created, in ISO 8601 format. Reflects the time of the first payment if the object represents an incomplete partial payment, and the time of the last or complete payment otherwise..</param>
        /// <param name="CreatorId">The unique identifier of the Square account that took the payment..</param>
        /// <param name="Device">The device that took the payment..</param>
        /// <param name="PaymentUrl">The URL of the payment&#39;s detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page..</param>
        /// <param name="ReceiptUrl">The URL of the receipt for the payment. Note that for split tender payments, this URL corresponds to the receipt for the first tender listed in the payment&#39;s tender field. Each Tender object has its own receipt_url field you can use to get the other receipts associated with a split tender payment..</param>
        /// <param name="InclusiveTaxMoney">The sum of all inclusive taxes associated with the payment..</param>
        /// <param name="AdditiveTaxMoney">The sum of all additive taxes associated with the payment..</param>
        /// <param name="TaxMoney">The total of all taxes applied to the payment. This is always the sum of inclusive_tax_money and additive_tax_money..</param>
        /// <param name="TipMoney">The total of all tips applied to the payment..</param>
        /// <param name="DiscountMoney">The total of all discounts applied to the payment..</param>
        /// <param name="TotalCollectedMoney">The total of all discounts applied to the payment..</param>
        /// <param name="ProcessingFeeMoney">The total of all processing fees collected by Square for the payment..</param>
        /// <param name="NetTotalMoney">The amount to be deposited into the merchant&#39;s bank account for the payment..</param>
        /// <param name="RefundedMoney">The total of all refunds applied to the payment..</param>
        /// <param name="SwedishRoundingMoney">The total of all sales, including any applicable taxes, rounded to the smallest legal unit of currency (e.g., the nearest penny in USD, the nearest nickel in CAD).</param>
        /// <param name="GrossSalesMoney">The total of all sales, including any applicable taxes..</param>
        /// <param name="NetSalesMoney">The total of all sales, minus any applicable taxes..</param>
        /// <param name="InclusiveTax">All of the inclusive taxes associated with the payment..</param>
        /// <param name="AdditiveTax">All of the additive taxes associated with the payment..</param>
        /// <param name="Tender">All of the additive taxes associated with the payment..</param>
        /// <param name="Refunds">All of the refunds applied to the payment. Note that the value of all refunds on a payment can exceed the value of all tenders if a merchant chooses to refund money to a tender after previously accepting returned goods as part of an exchange..</param>
        /// <param name="Itemizations">The items purchased in the payment..</param>
        /// <param name="SurchargeMoney">The total of all surcharges applied to the payment..</param>
        /// <param name="Surcharges">A list of all surcharges associated with the payment..</param>
        /// <param name="IsPartial">Indicates whether or not the payment is only partially paid for. If true, this payment will have the tenders collected so far, but the itemizations will be empty until the payment is completed..</param>
        public V1Payment(string Id = default(string), string MerchantId = default(string), string CreatedAt = default(string), string CreatorId = default(string), Device Device = default(Device), string PaymentUrl = default(string), string ReceiptUrl = default(string), V1Money InclusiveTaxMoney = default(V1Money), V1Money AdditiveTaxMoney = default(V1Money), V1Money TaxMoney = default(V1Money), V1Money TipMoney = default(V1Money), V1Money DiscountMoney = default(V1Money), V1Money TotalCollectedMoney = default(V1Money), V1Money ProcessingFeeMoney = default(V1Money), V1Money NetTotalMoney = default(V1Money), V1Money RefundedMoney = default(V1Money), V1Money SwedishRoundingMoney = default(V1Money), V1Money GrossSalesMoney = default(V1Money), V1Money NetSalesMoney = default(V1Money), List<V1PaymentTax> InclusiveTax = default(List<V1PaymentTax>), List<V1PaymentTax> AdditiveTax = default(List<V1PaymentTax>), List<V1Tender> Tender = default(List<V1Tender>), List<V1Refund> Refunds = default(List<V1Refund>), List<V1PaymentItemization> Itemizations = default(List<V1PaymentItemization>), V1Money SurchargeMoney = default(V1Money), List<V1PaymentSurcharge> Surcharges = default(List<V1PaymentSurcharge>), bool? IsPartial = default(bool?))
        {
            this.Id = Id;
            this.MerchantId = MerchantId;
            this.CreatedAt = CreatedAt;
            this.CreatorId = CreatorId;
            this.Device = Device;
            this.PaymentUrl = PaymentUrl;
            this.ReceiptUrl = ReceiptUrl;
            this.InclusiveTaxMoney = InclusiveTaxMoney;
            this.AdditiveTaxMoney = AdditiveTaxMoney;
            this.TaxMoney = TaxMoney;
            this.TipMoney = TipMoney;
            this.DiscountMoney = DiscountMoney;
            this.TotalCollectedMoney = TotalCollectedMoney;
            this.ProcessingFeeMoney = ProcessingFeeMoney;
            this.NetTotalMoney = NetTotalMoney;
            this.RefundedMoney = RefundedMoney;
            this.SwedishRoundingMoney = SwedishRoundingMoney;
            this.GrossSalesMoney = GrossSalesMoney;
            this.NetSalesMoney = NetSalesMoney;
            this.InclusiveTax = InclusiveTax;
            this.AdditiveTax = AdditiveTax;
            this.Tender = Tender;
            this.Refunds = Refunds;
            this.Itemizations = Itemizations;
            this.SurchargeMoney = SurchargeMoney;
            this.Surcharges = Surcharges;
            this.IsPartial = IsPartial;
        }
        
        /// <summary>
        /// The payment&#39;s unique identifier.
        /// </summary>
        /// <value>The payment&#39;s unique identifier.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The unique identifier of the merchant that took the payment.
        /// </summary>
        /// <value>The unique identifier of the merchant that took the payment.</value>
        [DataMember(Name="merchant_id", EmitDefaultValue=false)]
        public string MerchantId { get; set; }
        /// <summary>
        /// The time when the payment was created, in ISO 8601 format. Reflects the time of the first payment if the object represents an incomplete partial payment, and the time of the last or complete payment otherwise.
        /// </summary>
        /// <value>The time when the payment was created, in ISO 8601 format. Reflects the time of the first payment if the object represents an incomplete partial payment, and the time of the last or complete payment otherwise.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// The unique identifier of the Square account that took the payment.
        /// </summary>
        /// <value>The unique identifier of the Square account that took the payment.</value>
        [DataMember(Name="creator_id", EmitDefaultValue=false)]
        public string CreatorId { get; set; }
        /// <summary>
        /// The device that took the payment.
        /// </summary>
        /// <value>The device that took the payment.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public Device Device { get; set; }
        /// <summary>
        /// The URL of the payment&#39;s detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page.
        /// </summary>
        /// <value>The URL of the payment&#39;s detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page.</value>
        [DataMember(Name="payment_url", EmitDefaultValue=false)]
        public string PaymentUrl { get; set; }
        /// <summary>
        /// The URL of the receipt for the payment. Note that for split tender payments, this URL corresponds to the receipt for the first tender listed in the payment&#39;s tender field. Each Tender object has its own receipt_url field you can use to get the other receipts associated with a split tender payment.
        /// </summary>
        /// <value>The URL of the receipt for the payment. Note that for split tender payments, this URL corresponds to the receipt for the first tender listed in the payment&#39;s tender field. Each Tender object has its own receipt_url field you can use to get the other receipts associated with a split tender payment.</value>
        [DataMember(Name="receipt_url", EmitDefaultValue=false)]
        public string ReceiptUrl { get; set; }
        /// <summary>
        /// The sum of all inclusive taxes associated with the payment.
        /// </summary>
        /// <value>The sum of all inclusive taxes associated with the payment.</value>
        [DataMember(Name="inclusive_tax_money", EmitDefaultValue=false)]
        public V1Money InclusiveTaxMoney { get; set; }
        /// <summary>
        /// The sum of all additive taxes associated with the payment.
        /// </summary>
        /// <value>The sum of all additive taxes associated with the payment.</value>
        [DataMember(Name="additive_tax_money", EmitDefaultValue=false)]
        public V1Money AdditiveTaxMoney { get; set; }
        /// <summary>
        /// The total of all taxes applied to the payment. This is always the sum of inclusive_tax_money and additive_tax_money.
        /// </summary>
        /// <value>The total of all taxes applied to the payment. This is always the sum of inclusive_tax_money and additive_tax_money.</value>
        [DataMember(Name="tax_money", EmitDefaultValue=false)]
        public V1Money TaxMoney { get; set; }
        /// <summary>
        /// The total of all tips applied to the payment.
        /// </summary>
        /// <value>The total of all tips applied to the payment.</value>
        [DataMember(Name="tip_money", EmitDefaultValue=false)]
        public V1Money TipMoney { get; set; }
        /// <summary>
        /// The total of all discounts applied to the payment.
        /// </summary>
        /// <value>The total of all discounts applied to the payment.</value>
        [DataMember(Name="discount_money", EmitDefaultValue=false)]
        public V1Money DiscountMoney { get; set; }
        /// <summary>
        /// The total of all discounts applied to the payment.
        /// </summary>
        /// <value>The total of all discounts applied to the payment.</value>
        [DataMember(Name="total_collected_money", EmitDefaultValue=false)]
        public V1Money TotalCollectedMoney { get; set; }
        /// <summary>
        /// The total of all processing fees collected by Square for the payment.
        /// </summary>
        /// <value>The total of all processing fees collected by Square for the payment.</value>
        [DataMember(Name="processing_fee_money", EmitDefaultValue=false)]
        public V1Money ProcessingFeeMoney { get; set; }
        /// <summary>
        /// The amount to be deposited into the merchant&#39;s bank account for the payment.
        /// </summary>
        /// <value>The amount to be deposited into the merchant&#39;s bank account for the payment.</value>
        [DataMember(Name="net_total_money", EmitDefaultValue=false)]
        public V1Money NetTotalMoney { get; set; }
        /// <summary>
        /// The total of all refunds applied to the payment.
        /// </summary>
        /// <value>The total of all refunds applied to the payment.</value>
        [DataMember(Name="refunded_money", EmitDefaultValue=false)]
        public V1Money RefundedMoney { get; set; }
        /// <summary>
        /// The total of all sales, including any applicable taxes, rounded to the smallest legal unit of currency (e.g., the nearest penny in USD, the nearest nickel in CAD)
        /// </summary>
        /// <value>The total of all sales, including any applicable taxes, rounded to the smallest legal unit of currency (e.g., the nearest penny in USD, the nearest nickel in CAD)</value>
        [DataMember(Name="swedish_rounding_money", EmitDefaultValue=false)]
        public V1Money SwedishRoundingMoney { get; set; }
        /// <summary>
        /// The total of all sales, including any applicable taxes.
        /// </summary>
        /// <value>The total of all sales, including any applicable taxes.</value>
        [DataMember(Name="gross_sales_money", EmitDefaultValue=false)]
        public V1Money GrossSalesMoney { get; set; }
        /// <summary>
        /// The total of all sales, minus any applicable taxes.
        /// </summary>
        /// <value>The total of all sales, minus any applicable taxes.</value>
        [DataMember(Name="net_sales_money", EmitDefaultValue=false)]
        public V1Money NetSalesMoney { get; set; }
        /// <summary>
        /// All of the inclusive taxes associated with the payment.
        /// </summary>
        /// <value>All of the inclusive taxes associated with the payment.</value>
        [DataMember(Name="inclusive_tax", EmitDefaultValue=false)]
        public List<V1PaymentTax> InclusiveTax { get; set; }
        /// <summary>
        /// All of the additive taxes associated with the payment.
        /// </summary>
        /// <value>All of the additive taxes associated with the payment.</value>
        [DataMember(Name="additive_tax", EmitDefaultValue=false)]
        public List<V1PaymentTax> AdditiveTax { get; set; }
        /// <summary>
        /// All of the additive taxes associated with the payment.
        /// </summary>
        /// <value>All of the additive taxes associated with the payment.</value>
        [DataMember(Name="tender", EmitDefaultValue=false)]
        public List<V1Tender> Tender { get; set; }
        /// <summary>
        /// All of the refunds applied to the payment. Note that the value of all refunds on a payment can exceed the value of all tenders if a merchant chooses to refund money to a tender after previously accepting returned goods as part of an exchange.
        /// </summary>
        /// <value>All of the refunds applied to the payment. Note that the value of all refunds on a payment can exceed the value of all tenders if a merchant chooses to refund money to a tender after previously accepting returned goods as part of an exchange.</value>
        [DataMember(Name="refunds", EmitDefaultValue=false)]
        public List<V1Refund> Refunds { get; set; }
        /// <summary>
        /// The items purchased in the payment.
        /// </summary>
        /// <value>The items purchased in the payment.</value>
        [DataMember(Name="itemizations", EmitDefaultValue=false)]
        public List<V1PaymentItemization> Itemizations { get; set; }
        /// <summary>
        /// The total of all surcharges applied to the payment.
        /// </summary>
        /// <value>The total of all surcharges applied to the payment.</value>
        [DataMember(Name="surcharge_money", EmitDefaultValue=false)]
        public V1Money SurchargeMoney { get; set; }
        /// <summary>
        /// A list of all surcharges associated with the payment.
        /// </summary>
        /// <value>A list of all surcharges associated with the payment.</value>
        [DataMember(Name="surcharges", EmitDefaultValue=false)]
        public List<V1PaymentSurcharge> Surcharges { get; set; }
        /// <summary>
        /// Indicates whether or not the payment is only partially paid for. If true, this payment will have the tenders collected so far, but the itemizations will be empty until the payment is completed.
        /// </summary>
        /// <value>Indicates whether or not the payment is only partially paid for. If true, this payment will have the tenders collected so far, but the itemizations will be empty until the payment is completed.</value>
        [DataMember(Name="is_partial", EmitDefaultValue=false)]
        public bool? IsPartial { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Payment {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
            sb.Append("  ReceiptUrl: ").Append(ReceiptUrl).Append("\n");
            sb.Append("  InclusiveTaxMoney: ").Append(InclusiveTaxMoney).Append("\n");
            sb.Append("  AdditiveTaxMoney: ").Append(AdditiveTaxMoney).Append("\n");
            sb.Append("  TaxMoney: ").Append(TaxMoney).Append("\n");
            sb.Append("  TipMoney: ").Append(TipMoney).Append("\n");
            sb.Append("  DiscountMoney: ").Append(DiscountMoney).Append("\n");
            sb.Append("  TotalCollectedMoney: ").Append(TotalCollectedMoney).Append("\n");
            sb.Append("  ProcessingFeeMoney: ").Append(ProcessingFeeMoney).Append("\n");
            sb.Append("  NetTotalMoney: ").Append(NetTotalMoney).Append("\n");
            sb.Append("  RefundedMoney: ").Append(RefundedMoney).Append("\n");
            sb.Append("  SwedishRoundingMoney: ").Append(SwedishRoundingMoney).Append("\n");
            sb.Append("  GrossSalesMoney: ").Append(GrossSalesMoney).Append("\n");
            sb.Append("  NetSalesMoney: ").Append(NetSalesMoney).Append("\n");
            sb.Append("  InclusiveTax: ").Append(InclusiveTax).Append("\n");
            sb.Append("  AdditiveTax: ").Append(AdditiveTax).Append("\n");
            sb.Append("  Tender: ").Append(Tender).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Itemizations: ").Append(Itemizations).Append("\n");
            sb.Append("  SurchargeMoney: ").Append(SurchargeMoney).Append("\n");
            sb.Append("  Surcharges: ").Append(Surcharges).Append("\n");
            sb.Append("  IsPartial: ").Append(IsPartial).Append("\n");
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
            return this.Equals(obj as V1Payment);
        }

        /// <summary>
        /// Returns true if V1Payment instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Payment other)
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
                    this.MerchantId == other.MerchantId ||
                    this.MerchantId != null &&
                    this.MerchantId.Equals(other.MerchantId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.CreatorId == other.CreatorId ||
                    this.CreatorId != null &&
                    this.CreatorId.Equals(other.CreatorId)
                ) && 
                (
                    this.Device == other.Device ||
                    this.Device != null &&
                    this.Device.Equals(other.Device)
                ) && 
                (
                    this.PaymentUrl == other.PaymentUrl ||
                    this.PaymentUrl != null &&
                    this.PaymentUrl.Equals(other.PaymentUrl)
                ) && 
                (
                    this.ReceiptUrl == other.ReceiptUrl ||
                    this.ReceiptUrl != null &&
                    this.ReceiptUrl.Equals(other.ReceiptUrl)
                ) && 
                (
                    this.InclusiveTaxMoney == other.InclusiveTaxMoney ||
                    this.InclusiveTaxMoney != null &&
                    this.InclusiveTaxMoney.Equals(other.InclusiveTaxMoney)
                ) && 
                (
                    this.AdditiveTaxMoney == other.AdditiveTaxMoney ||
                    this.AdditiveTaxMoney != null &&
                    this.AdditiveTaxMoney.Equals(other.AdditiveTaxMoney)
                ) && 
                (
                    this.TaxMoney == other.TaxMoney ||
                    this.TaxMoney != null &&
                    this.TaxMoney.Equals(other.TaxMoney)
                ) && 
                (
                    this.TipMoney == other.TipMoney ||
                    this.TipMoney != null &&
                    this.TipMoney.Equals(other.TipMoney)
                ) && 
                (
                    this.DiscountMoney == other.DiscountMoney ||
                    this.DiscountMoney != null &&
                    this.DiscountMoney.Equals(other.DiscountMoney)
                ) && 
                (
                    this.TotalCollectedMoney == other.TotalCollectedMoney ||
                    this.TotalCollectedMoney != null &&
                    this.TotalCollectedMoney.Equals(other.TotalCollectedMoney)
                ) && 
                (
                    this.ProcessingFeeMoney == other.ProcessingFeeMoney ||
                    this.ProcessingFeeMoney != null &&
                    this.ProcessingFeeMoney.Equals(other.ProcessingFeeMoney)
                ) && 
                (
                    this.NetTotalMoney == other.NetTotalMoney ||
                    this.NetTotalMoney != null &&
                    this.NetTotalMoney.Equals(other.NetTotalMoney)
                ) && 
                (
                    this.RefundedMoney == other.RefundedMoney ||
                    this.RefundedMoney != null &&
                    this.RefundedMoney.Equals(other.RefundedMoney)
                ) && 
                (
                    this.SwedishRoundingMoney == other.SwedishRoundingMoney ||
                    this.SwedishRoundingMoney != null &&
                    this.SwedishRoundingMoney.Equals(other.SwedishRoundingMoney)
                ) && 
                (
                    this.GrossSalesMoney == other.GrossSalesMoney ||
                    this.GrossSalesMoney != null &&
                    this.GrossSalesMoney.Equals(other.GrossSalesMoney)
                ) && 
                (
                    this.NetSalesMoney == other.NetSalesMoney ||
                    this.NetSalesMoney != null &&
                    this.NetSalesMoney.Equals(other.NetSalesMoney)
                ) && 
                (
                    this.InclusiveTax == other.InclusiveTax ||
                    this.InclusiveTax != null &&
                    this.InclusiveTax.SequenceEqual(other.InclusiveTax)
                ) && 
                (
                    this.AdditiveTax == other.AdditiveTax ||
                    this.AdditiveTax != null &&
                    this.AdditiveTax.SequenceEqual(other.AdditiveTax)
                ) && 
                (
                    this.Tender == other.Tender ||
                    this.Tender != null &&
                    this.Tender.SequenceEqual(other.Tender)
                ) && 
                (
                    this.Refunds == other.Refunds ||
                    this.Refunds != null &&
                    this.Refunds.SequenceEqual(other.Refunds)
                ) && 
                (
                    this.Itemizations == other.Itemizations ||
                    this.Itemizations != null &&
                    this.Itemizations.SequenceEqual(other.Itemizations)
                ) && 
                (
                    this.SurchargeMoney == other.SurchargeMoney ||
                    this.SurchargeMoney != null &&
                    this.SurchargeMoney.Equals(other.SurchargeMoney)
                ) && 
                (
                    this.Surcharges == other.Surcharges ||
                    this.Surcharges != null &&
                    this.Surcharges.SequenceEqual(other.Surcharges)
                ) && 
                (
                    this.IsPartial == other.IsPartial ||
                    this.IsPartial != null &&
                    this.IsPartial.Equals(other.IsPartial)
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
                if (this.MerchantId != null)
                    hash = hash * 59 + this.MerchantId.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatorId != null)
                    hash = hash * 59 + this.CreatorId.GetHashCode();
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                if (this.PaymentUrl != null)
                    hash = hash * 59 + this.PaymentUrl.GetHashCode();
                if (this.ReceiptUrl != null)
                    hash = hash * 59 + this.ReceiptUrl.GetHashCode();
                if (this.InclusiveTaxMoney != null)
                    hash = hash * 59 + this.InclusiveTaxMoney.GetHashCode();
                if (this.AdditiveTaxMoney != null)
                    hash = hash * 59 + this.AdditiveTaxMoney.GetHashCode();
                if (this.TaxMoney != null)
                    hash = hash * 59 + this.TaxMoney.GetHashCode();
                if (this.TipMoney != null)
                    hash = hash * 59 + this.TipMoney.GetHashCode();
                if (this.DiscountMoney != null)
                    hash = hash * 59 + this.DiscountMoney.GetHashCode();
                if (this.TotalCollectedMoney != null)
                    hash = hash * 59 + this.TotalCollectedMoney.GetHashCode();
                if (this.ProcessingFeeMoney != null)
                    hash = hash * 59 + this.ProcessingFeeMoney.GetHashCode();
                if (this.NetTotalMoney != null)
                    hash = hash * 59 + this.NetTotalMoney.GetHashCode();
                if (this.RefundedMoney != null)
                    hash = hash * 59 + this.RefundedMoney.GetHashCode();
                if (this.SwedishRoundingMoney != null)
                    hash = hash * 59 + this.SwedishRoundingMoney.GetHashCode();
                if (this.GrossSalesMoney != null)
                    hash = hash * 59 + this.GrossSalesMoney.GetHashCode();
                if (this.NetSalesMoney != null)
                    hash = hash * 59 + this.NetSalesMoney.GetHashCode();
                if (this.InclusiveTax != null)
                    hash = hash * 59 + this.InclusiveTax.GetHashCode();
                if (this.AdditiveTax != null)
                    hash = hash * 59 + this.AdditiveTax.GetHashCode();
                if (this.Tender != null)
                    hash = hash * 59 + this.Tender.GetHashCode();
                if (this.Refunds != null)
                    hash = hash * 59 + this.Refunds.GetHashCode();
                if (this.Itemizations != null)
                    hash = hash * 59 + this.Itemizations.GetHashCode();
                if (this.SurchargeMoney != null)
                    hash = hash * 59 + this.SurchargeMoney.GetHashCode();
                if (this.Surcharges != null)
                    hash = hash * 59 + this.Surcharges.GetHashCode();
                if (this.IsPartial != null)
                    hash = hash * 59 + this.IsPartial.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
