// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The paged results of dashboards. </summary>
    internal partial class DashboardCollection
    {
        /// <summary> Initializes a new instance of DashboardCollection. </summary>
        /// <param name="value"> The collection of dashboards. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DashboardCollection(IEnumerable<Dashboard> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DashboardCollection. </summary>
        /// <param name="value"> The collection of dashboards. </param>
        /// <param name="nextLink"> URL to get the next page of dashboards. </param>
        internal DashboardCollection(IReadOnlyList<Dashboard> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The collection of dashboards. </summary>
        public IReadOnlyList<Dashboard> Value { get; }
        /// <summary> URL to get the next page of dashboards. </summary>
        public string NextLink { get; }
    }
}