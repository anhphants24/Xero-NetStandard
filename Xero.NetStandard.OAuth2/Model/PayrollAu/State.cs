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
    /// State abbreviation for employee home address
    /// </summary>
    /// <value>State abbreviation for employee home address</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum State
    {
        /// <summary>
        /// Enum ACT for value: ACT
        /// </summary>
        [EnumMember(Value = "ACT")]
        ACT = 1,

        /// <summary>
        /// Enum NSW for value: NSW
        /// </summary>
        [EnumMember(Value = "NSW")]
        NSW = 2,

        /// <summary>
        /// Enum NT for value: NT
        /// </summary>
        [EnumMember(Value = "NT")]
        NT = 3,

        /// <summary>
        /// Enum QLD for value: QLD
        /// </summary>
        [EnumMember(Value = "QLD")]
        QLD = 4,

        /// <summary>
        /// Enum SA for value: SA
        /// </summary>
        [EnumMember(Value = "SA")]
        SA = 5,

        /// <summary>
        /// Enum TAS for value: TAS
        /// </summary>
        [EnumMember(Value = "TAS")]
        TAS = 6,

        /// <summary>
        /// Enum VIC for value: VIC
        /// </summary>
        [EnumMember(Value = "VIC")]
        VIC = 7,

        /// <summary>
        /// Enum WA for value: WA
        /// </summary>
        [EnumMember(Value = "WA")]
        WA = 8

    }

}
