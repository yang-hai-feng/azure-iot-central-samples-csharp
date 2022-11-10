// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The symmetric key attestation definition. </summary>
    public partial class GroupSymmetricKeyAttestation : GroupAttestation
    {
        /// <summary> Initializes a new instance of GroupSymmetricKeyAttestation. </summary>
        public GroupSymmetricKeyAttestation()
        {
            Type = "symmetricKey";
        }

        /// <summary> Initializes a new instance of GroupSymmetricKeyAttestation. </summary>
        /// <param name="type"> Type of the attestation. </param>
        /// <param name="symmetricKey"> The symmetric key credentials for this attestation. </param>
        internal GroupSymmetricKeyAttestation(string type, SymmetricKey symmetricKey) : base(type)
        {
            SymmetricKey = symmetricKey;
            Type = type ?? "symmetricKey";
        }

        /// <summary> The symmetric key credentials for this attestation. </summary>
        public SymmetricKey SymmetricKey { get; set; }
    }
}