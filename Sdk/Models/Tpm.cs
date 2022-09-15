// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoTCentral.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The trusted platform module definition.
    /// </summary>
    public partial class Tpm
    {
        /// <summary>
        /// Initializes a new instance of the Tpm class.
        /// </summary>
        public Tpm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Tpm class.
        /// </summary>
        /// <param name="endorsementKey">The TPM endorsement key for this
        /// credential.</param>
        public Tpm(string endorsementKey)
        {
            EndorsementKey = endorsementKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the TPM endorsement key for this credential.
        /// </summary>
        [JsonProperty(PropertyName = "endorsementKey")]
        public string EndorsementKey { get; set; }

    }
}