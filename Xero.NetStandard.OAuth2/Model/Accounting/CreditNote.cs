/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.12
 * Contact: api@xero.com
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// CreditNote
    /// </summary>
    [DataContract]
    public partial class CreditNote :  IEquatable<CreditNote>, IValidatableObject
    {
        /// <summary>
        /// See Credit Note Types
        /// </summary>
        /// <value>See Credit Note Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ACCPAYCREDIT for value: ACCPAYCREDIT
            /// </summary>
            [EnumMember(Value = "ACCPAYCREDIT")]
            ACCPAYCREDIT = 1,

            /// <summary>
            /// Enum ACCRECCREDIT for value: ACCRECCREDIT
            /// </summary>
            [EnumMember(Value = "ACCRECCREDIT")]
            ACCRECCREDIT = 2

        }

        /// <summary>
        /// See Credit Note Types
        /// </summary>
        /// <value>See Credit Note Types</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// See Credit Note Status Codes
        /// </summary>
        /// <value>See Credit Note Status Codes</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,

            /// <summary>
            /// Enum SUBMITTED for value: SUBMITTED
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            SUBMITTED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3,

            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 4,

            /// <summary>
            /// Enum PAID for value: PAID
            /// </summary>
            [EnumMember(Value = "PAID")]
            PAID = 5,

            /// <summary>
            /// Enum VOIDED for value: VOIDED
            /// </summary>
            [EnumMember(Value = "VOIDED")]
            VOIDED = 6

        }

        /// <summary>
        /// See Credit Note Status Codes
        /// </summary>
        /// <value>See Credit Note Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public LineAmountTypes LineAmountTypes { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The date the credit note is issued YYYY-MM-DD. If the Date element is not specified then it will default to the current date based on the timezone setting of the organisation
        /// </summary>
        /// <value>The date the credit note is issued YYYY-MM-DD. If the Date element is not specified then it will default to the current date based on the timezone setting of the organisation</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// See Invoice Line Items
        /// </summary>
        /// <value>See Invoice Line Items</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The subtotal of the credit note excluding taxes
        /// </summary>
        /// <value>The subtotal of the credit note excluding taxes</value>
        [DataMember(Name="SubTotal", EmitDefaultValue=false)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// The total tax on the credit note
        /// </summary>
        /// <value>The total tax on the credit note</value>
        [DataMember(Name="TotalTax", EmitDefaultValue=false)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// The total of the Credit Note(subtotal + total tax)
        /// </summary>
        /// <value>The total of the Credit Note(subtotal + total tax)</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// UTC timestamp of last update to the credit note
        /// </summary>
        /// <value>UTC timestamp of last update to the credit note</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Date when credit note was fully paid(UTC format)
        /// </summary>
        /// <value>Date when credit note was fully paid(UTC format)</value>
        [DataMember(Name="FullyPaidOnDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? FullyPaidOnDate { get; set; }

        /// <summary>
        /// Xero generated unique identifier
        /// </summary>
        /// <value>Xero generated unique identifier</value>
        [DataMember(Name="CreditNoteID", EmitDefaultValue=false)]
        public Guid? CreditNoteID { get; set; }

        /// <summary>
        /// ACCRECCREDIT – Unique alpha numeric code identifying credit note (when missing will auto-generate from your Organisation Invoice Settings)
        /// </summary>
        /// <value>ACCRECCREDIT – Unique alpha numeric code identifying credit note (when missing will auto-generate from your Organisation Invoice Settings)</value>
        [DataMember(Name="CreditNoteNumber", EmitDefaultValue=false)]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// ACCRECCREDIT only – additional reference number
        /// </summary>
        /// <value>ACCRECCREDIT only – additional reference number</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// boolean to indicate if a credit note has been sent to a contact via  the Xero app (currently read only)
        /// </summary>
        /// <value>boolean to indicate if a credit note has been sent to a contact via  the Xero app (currently read only)</value>
        [DataMember(Name="SentToContact", EmitDefaultValue=false)]
        public bool? SentToContact { get; private set; }

        /// <summary>
        /// The currency rate for a multicurrency invoice. If no rate is specified, the XE.com day rate is used
        /// </summary>
        /// <value>The currency rate for a multicurrency invoice. If no rate is specified, the XE.com day rate is used</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// The remaining credit balance on the Credit Note
        /// </summary>
        /// <value>The remaining credit balance on the Credit Note</value>
        [DataMember(Name="RemainingCredit", EmitDefaultValue=false)]
        public decimal? RemainingCredit { get; set; }

        /// <summary>
        /// See Allocations
        /// </summary>
        /// <value>See Allocations</value>
        [DataMember(Name="Allocations", EmitDefaultValue=false)]
        public List<Allocation> Allocations { get; set; }

        /// <summary>
        /// The amount of applied to an invoice
        /// </summary>
        /// <value>The amount of applied to an invoice</value>
        [DataMember(Name="AppliedAmount", EmitDefaultValue=false)]
        public double? AppliedAmount { get; set; }

        /// <summary>
        /// See Payments
        /// </summary>
        /// <value>See Payments</value>
        [DataMember(Name="Payments", EmitDefaultValue=false)]
        public List<Payment> Payments { get; set; }

        /// <summary>
        /// See BrandingThemes
        /// </summary>
        /// <value>See BrandingThemes</value>
        [DataMember(Name="BrandingThemeID", EmitDefaultValue=false)]
        public Guid? BrandingThemeID { get; set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// boolean to indicate if a credit note has an attachment
        /// </summary>
        /// <value>boolean to indicate if a credit note has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// A boolean to indicate if a credit note has an validation errors
        /// </summary>
        /// <value>A boolean to indicate if a credit note has an validation errors</value>
        [DataMember(Name="HasErrors", EmitDefaultValue=false)]
        public bool? HasErrors { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNote {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FullyPaidOnDate: ").Append(FullyPaidOnDate).Append("\n");
            sb.Append("  CreditNoteID: ").Append(CreditNoteID).Append("\n");
            sb.Append("  CreditNoteNumber: ").Append(CreditNoteNumber).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SentToContact: ").Append(SentToContact).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  RemainingCredit: ").Append(RemainingCredit).Append("\n");
            sb.Append("  Allocations: ").Append(Allocations).Append("\n");
            sb.Append("  AppliedAmount: ").Append(AppliedAmount).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  BrandingThemeID: ").Append(BrandingThemeID).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  HasErrors: ").Append(HasErrors).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreditNote);
        }

        /// <summary>
        /// Returns true if CreditNote instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    this.TotalTax.Equals(input.TotalTax)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.FullyPaidOnDate == input.FullyPaidOnDate ||
                    (this.FullyPaidOnDate != null &&
                    this.FullyPaidOnDate.Equals(input.FullyPaidOnDate))
                ) && 
                (
                    this.CreditNoteID == input.CreditNoteID ||
                    (this.CreditNoteID != null &&
                    this.CreditNoteID.Equals(input.CreditNoteID))
                ) && 
                (
                    this.CreditNoteNumber == input.CreditNoteNumber ||
                    (this.CreditNoteNumber != null &&
                    this.CreditNoteNumber.Equals(input.CreditNoteNumber))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SentToContact == input.SentToContact ||
                    this.SentToContact.Equals(input.SentToContact)
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    this.CurrencyRate.Equals(input.CurrencyRate)
                ) && 
                (
                    this.RemainingCredit == input.RemainingCredit ||
                    this.RemainingCredit.Equals(input.RemainingCredit)
                ) && 
                (
                    this.Allocations == input.Allocations ||
                    this.Allocations != null &&
                    input.Allocations != null &&
                    this.Allocations.SequenceEqual(input.Allocations)
                ) && 
                (
                    this.AppliedAmount == input.AppliedAmount ||
                    this.AppliedAmount.Equals(input.AppliedAmount)
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.BrandingThemeID == input.BrandingThemeID ||
                    (this.BrandingThemeID != null &&
                    this.BrandingThemeID.Equals(input.BrandingThemeID))
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    this.HasAttachments.Equals(input.HasAttachments)
                ) && 
                (
                    this.HasErrors == input.HasErrors ||
                    this.HasErrors.Equals(input.HasErrors)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.FullyPaidOnDate != null)
                    hashCode = hashCode * 59 + this.FullyPaidOnDate.GetHashCode();
                if (this.CreditNoteID != null)
                    hashCode = hashCode * 59 + this.CreditNoteID.GetHashCode();
                if (this.CreditNoteNumber != null)
                    hashCode = hashCode * 59 + this.CreditNoteNumber.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                hashCode = hashCode * 59 + this.SentToContact.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                hashCode = hashCode * 59 + this.RemainingCredit.GetHashCode();
                if (this.Allocations != null)
                    hashCode = hashCode * 59 + this.Allocations.GetHashCode();
                hashCode = hashCode * 59 + this.AppliedAmount.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.BrandingThemeID != null)
                    hashCode = hashCode * 59 + this.BrandingThemeID.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
                hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                hashCode = hashCode * 59 + this.HasErrors.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
