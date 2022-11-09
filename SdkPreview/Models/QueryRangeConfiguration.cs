// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying how much data to return for a tile. </summary>
    public partial class QueryRangeConfiguration
    {
        /// <summary> Initializes a new instance of QueryRangeConfiguration. </summary>
        public QueryRangeConfiguration()
        {
        }

        /// <summary> Initializes a new instance of QueryRangeConfiguration. </summary>
        /// <param name="type"> The type of time range - &apos;count&apos; or &apos;time&apos;. </param>
        internal QueryRangeConfiguration(string type)
        {
            Type = type;
        }

        /// <summary> The type of time range - &apos;count&apos; or &apos;time&apos;. </summary>
        internal string Type { get; set; }
    }
}
