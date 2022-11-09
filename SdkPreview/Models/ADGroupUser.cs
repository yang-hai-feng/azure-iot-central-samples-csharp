// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The active directory group user definition. </summary>
    public partial class ADGroupUser : User
    {
        /// <summary> Initializes a new instance of ADGroupUser. </summary>
        /// <param name="roles"> List of role assignments that specify the permissions to access the application. </param>
        /// <param name="tenantId"> The AAD tenant ID of the AD Group. </param>
        /// <param name="objectId"> The AAD object ID of the AD Group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roles"/>, <paramref name="tenantId"/> or <paramref name="objectId"/> is null. </exception>
        public ADGroupUser(IEnumerable<RoleAssignment> roles, string tenantId, string objectId) : base(roles)
        {
            Argument.AssertNotNull(roles, nameof(roles));
            Argument.AssertNotNull(tenantId, nameof(tenantId));
            Argument.AssertNotNull(objectId, nameof(objectId));

            TenantId = tenantId;
            ObjectId = objectId;
            Type = "adGroup";
        }

        /// <summary> Initializes a new instance of ADGroupUser. </summary>
        /// <param name="roles"> List of role assignments that specify the permissions to access the application. </param>
        /// <param name="id"> Unique ID of the user. </param>
        /// <param name="type"> Type of the user. </param>
        /// <param name="tenantId"> The AAD tenant ID of the AD Group. </param>
        /// <param name="objectId"> The AAD object ID of the AD Group. </param>
        internal ADGroupUser(IList<RoleAssignment> roles, string id, string type, string tenantId, string objectId) : base(roles, id, type)
        {
            TenantId = tenantId;
            ObjectId = objectId;
            Type = type ?? "adGroup";
        }

        /// <summary> The AAD tenant ID of the AD Group. </summary>
        public string TenantId { get; set; }
        /// <summary> The AAD object ID of the AD Group. </summary>
        public string ObjectId { get; set; }
    }
}
