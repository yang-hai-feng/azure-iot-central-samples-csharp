// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The authentication definition with connection string for service bus queue definition. </summary>
    public partial class ServiceBusQueueV1DestinationConnectionStringAuth : ServiceBusQueueV1DestinationAuth
    {
        /// <summary> Initializes a new instance of ServiceBusQueueV1DestinationConnectionStringAuth. </summary>
        /// <param name="connectionString"> The connection string for accessing the Service Bus namespace, including the `EntityPath` of the queue. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public ServiceBusQueueV1DestinationConnectionStringAuth(string connectionString)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            ConnectionString = connectionString;
            Type = "connectionString";
        }

        /// <summary> Initializes a new instance of ServiceBusQueueV1DestinationConnectionStringAuth. </summary>
        /// <param name="type"> The kind of authentication to use. </param>
        /// <param name="connectionString"> The connection string for accessing the Service Bus namespace, including the `EntityPath` of the queue. </param>
        internal ServiceBusQueueV1DestinationConnectionStringAuth(string type, string connectionString) : base(type)
        {
            ConnectionString = connectionString;
            Type = type ?? "connectionString";
        }

        /// <summary> The connection string for accessing the Service Bus namespace, including the `EntityPath` of the queue. </summary>
        public string ConnectionString { get; set; }
    }
}
