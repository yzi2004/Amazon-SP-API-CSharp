/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// The dimension values and unit of measurement.
    /// </summary>
    [DataContract]
    public partial class Dimensions : IEquatable<Dimensions>, IValidatableObject
    {
        /// <summary>
        /// The unit of measurement for the dimensions.
        /// </summary>
        /// <value>The unit of measurement for the dimensions.</value>
        [DataMember(Name = "Unit", EmitDefaultValue = false)]
        public UnitOfMeasurement Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Dimensions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        /// <param name="Length">The length dimension. (required).</param>
        /// <param name="Width">The width dimension. (required).</param>
        /// <param name="Height">The height dimension. (required).</param>
        /// <param name="Unit">The unit of measurement for the dimensions. (required).</param>
        public Dimensions(BigDecimalType Length = default(BigDecimalType), BigDecimalType Width = default(BigDecimalType), BigDecimalType Height = default(BigDecimalType), UnitOfMeasurement Unit = default(UnitOfMeasurement))
        {
            // to ensure "Length" is required (not null)
            if (Length == null)
            {
                throw new InvalidDataException("Length is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Length = Length;
            }
            // to ensure "Width" is required (not null)
            if (Width == null)
            {
                throw new InvalidDataException("Width is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Width = Width;
            }
            // to ensure "Height" is required (not null)
            if (Height == null)
            {
                throw new InvalidDataException("Height is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Height = Height;
            }
            // to ensure "Unit" is required (not null)
            if (Unit == null)
            {
                throw new InvalidDataException("Unit is a required property for Dimensions and cannot be null");
            }
            else
            {
                this.Unit = Unit;
            }
        }

        /// <summary>
        /// The length dimension.
        /// </summary>
        /// <value>The length dimension.</value>
        [DataMember(Name = "Length", EmitDefaultValue = false)]
        public BigDecimalType Length { get; set; }

        /// <summary>
        /// The width dimension.
        /// </summary>
        /// <value>The width dimension.</value>
        [DataMember(Name = "Width", EmitDefaultValue = false)]
        public BigDecimalType Width { get; set; }

        /// <summary>
        /// The height dimension.
        /// </summary>
        /// <value>The height dimension.</value>
        [DataMember(Name = "Height", EmitDefaultValue = false)]
        public BigDecimalType Height { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dimensions {\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Dimensions);
        }

        /// <summary>
        /// Returns true if Dimensions instances are equal
        /// </summary>
        /// <param name="input">Instance of Dimensions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dimensions input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) &&
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) &&
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) &&
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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