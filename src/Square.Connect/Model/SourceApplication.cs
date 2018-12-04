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
    /// Provides information about the application used to generate an inventory change.
    /// </summary>
    [DataContract]
    public partial class SourceApplication :  IEquatable<SourceApplication>, IValidatableObject
    {
        /// <summary>
        /// Read-only [Product](#type-product) type for the application.
        /// </summary>
        /// <value>Read-only [Product](#type-product) type for the application.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductEnum
        {
            
            /// <summary>
            /// Enum SQUAREPOS for "SQUARE_POS"
            /// </summary>
            [EnumMember(Value = "SQUARE_POS")]
            SQUAREPOS,
            
            /// <summary>
            /// Enum EXTERNALAPI for "EXTERNAL_API"
            /// </summary>
            [EnumMember(Value = "EXTERNAL_API")]
            EXTERNALAPI,
            
            /// <summary>
            /// Enum BILLING for "BILLING"
            /// </summary>
            [EnumMember(Value = "BILLING")]
            BILLING,
            
            /// <summary>
            /// Enum APPOINTMENTS for "APPOINTMENTS"
            /// </summary>
            [EnumMember(Value = "APPOINTMENTS")]
            APPOINTMENTS,
            
            /// <summary>
            /// Enum INVOICES for "INVOICES"
            /// </summary>
            [EnumMember(Value = "INVOICES")]
            INVOICES,
            
            /// <summary>
            /// Enum ONLINESTORE for "ONLINE_STORE"
            /// </summary>
            [EnumMember(Value = "ONLINE_STORE")]
            ONLINESTORE,
            
            /// <summary>
            /// Enum PAYROLL for "PAYROLL"
            /// </summary>
            [EnumMember(Value = "PAYROLL")]
            PAYROLL,
            
            /// <summary>
            /// Enum DASHBOARD for "DASHBOARD"
            /// </summary>
            [EnumMember(Value = "DASHBOARD")]
            DASHBOARD,
            
            /// <summary>
            /// Enum ITEMLIBRARYIMPORT for "ITEM_LIBRARY_IMPORT"
            /// </summary>
            [EnumMember(Value = "ITEM_LIBRARY_IMPORT")]
            ITEMLIBRARYIMPORT,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// Read-only [Product](#type-product) type for the application.
        /// </summary>
        /// <value>Read-only [Product](#type-product) type for the application.</value>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public ProductEnum? Product { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceApplication" /> class.
        /// </summary>
        /// <param name="Product">Read-only [Product](#type-product) type for the application..</param>
        /// <param name="ApplicationId">Read-only Square ID assigned to the application. Only used for [Product](#type-product) type &#x60;EXTERNAL_API&#x60;..</param>
        /// <param name="Name">Read-only display name assigned to the application (e.g. &#x60;\&quot;Custom Application\&quot;&#x60;, &#x60;\&quot;Square POS 4.74 for Android\&quot;&#x60;)..</param>
        public SourceApplication(ProductEnum? Product = default(ProductEnum?), string ApplicationId = default(string), string Name = default(string))
        {
            this.Product = Product;
            this.ApplicationId = ApplicationId;
            this.Name = Name;
        }
        
        /// <summary>
        /// Read-only Square ID assigned to the application. Only used for [Product](#type-product) type &#x60;EXTERNAL_API&#x60;.
        /// </summary>
        /// <value>Read-only Square ID assigned to the application. Only used for [Product](#type-product) type &#x60;EXTERNAL_API&#x60;.</value>
        [DataMember(Name="application_id", EmitDefaultValue=false)]
        public string ApplicationId { get; set; }
        /// <summary>
        /// Read-only display name assigned to the application (e.g. &#x60;\&quot;Custom Application\&quot;&#x60;, &#x60;\&quot;Square POS 4.74 for Android\&quot;&#x60;).
        /// </summary>
        /// <value>Read-only display name assigned to the application (e.g. &#x60;\&quot;Custom Application\&quot;&#x60;, &#x60;\&quot;Square POS 4.74 for Android\&quot;&#x60;).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceApplication {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as SourceApplication);
        }

        /// <summary>
        /// Returns true if SourceApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of SourceApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SourceApplication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Product == other.Product ||
                    this.Product != null &&
                    this.Product.Equals(other.Product)
                ) && 
                (
                    this.ApplicationId == other.ApplicationId ||
                    this.ApplicationId != null &&
                    this.ApplicationId.Equals(other.ApplicationId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Product != null)
                    hash = hash * 59 + this.Product.GetHashCode();
                if (this.ApplicationId != null)
                    hash = hash * 59 + this.ApplicationId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}