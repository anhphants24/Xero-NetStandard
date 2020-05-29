/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.1.4
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// LeaveBalance
    /// </summary>
    [DataContract]
    public partial class LeaveBalance :  IEquatable<LeaveBalance>, IValidatableObject
    {
        
        /// <summary>
        /// The name of the leave type
        /// </summary>
        /// <value>The name of the leave type</value>
        [DataMember(Name="LeaveName", EmitDefaultValue=false)]
        public string LeaveName { get; set; }

        /// <summary>
        /// Identifier of the leave type (see PayItems)
        /// </summary>
        /// <value>Identifier of the leave type (see PayItems)</value>
        [DataMember(Name="LeaveTypeID", EmitDefaultValue=false)]
        public string LeaveTypeID { get; set; }

        /// <summary>
        /// The balance of the leave available
        /// </summary>
        /// <value>The balance of the leave available</value>
        [DataMember(Name="NumberOfUnits", EmitDefaultValue=false)]
        public float? NumberOfUnits { get; set; }

        /// <summary>
        /// The type of units as specified by the LeaveType (see PayItems)
        /// </summary>
        /// <value>The type of units as specified by the LeaveType (see PayItems)</value>
        [DataMember(Name="TypeOfUnits", EmitDefaultValue=false)]
        public string TypeOfUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveBalance {\n");
            sb.Append("  LeaveName: ").Append(LeaveName).Append("\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  TypeOfUnits: ").Append(TypeOfUnits).Append("\n");
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
            return this.Equals(input as LeaveBalance);
        }

        /// <summary>
        /// Returns true if LeaveBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaveName == input.LeaveName ||
                    (this.LeaveName != null &&
                    this.LeaveName.Equals(input.LeaveName))
                ) && 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    this.NumberOfUnits.Equals(input.NumberOfUnits)
                ) && 
                (
                    this.TypeOfUnits == input.TypeOfUnits ||
                    (this.TypeOfUnits != null &&
                    this.TypeOfUnits.Equals(input.TypeOfUnits))
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
                if (this.LeaveName != null)
                    hashCode = hashCode * 59 + this.LeaveName.GetHashCode();
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                if (this.TypeOfUnits != null)
                    hashCode = hashCode * 59 + this.TypeOfUnits.GetHashCode();
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
