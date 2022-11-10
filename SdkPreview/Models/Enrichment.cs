// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The enrichment definition for data export. </summary>
    public partial class Enrichment
    {
        /// <summary> Initializes a new instance of Enrichment. </summary>
        public Enrichment()
        {
        }

        /// <summary> Initializes a new instance of Enrichment. </summary>
        /// <param name="target"> The device template or interface which defines the target capability for the enrichment. </param>
        /// <param name="path"> The path to the target capability within the device template or the system property to use. </param>
        /// <param name="value"> The raw value used for the enrichment. </param>
        internal Enrichment(string target, string path, object value)
        {
            Target = target;
            Path = path;
            Value = value;
        }

        /// <summary> The device template or interface which defines the target capability for the enrichment. </summary>
        public string Target { get; set; }
        /// <summary> The path to the target capability within the device template or the system property to use. </summary>
        public string Path { get; set; }
        /// <summary> The raw value used for the enrichment. </summary>
        public object Value { get; set; }
    }
}