// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> The authentication definition with connection string for blob storage destination. </summary>
    public partial class BlobStorageV1DestinationConnectionStringAuth : BlobStorageV1DestinationAuth
    {
        /// <summary> Initializes a new instance of BlobStorageV1DestinationConnectionStringAuth. </summary>
        /// <param name="connectionString"> The connection string for accessing the blob storage account. </param>
        /// <param name="containerName"> Name of the container where data should be written in the storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> or <paramref name="containerName"/> is null. </exception>
        public BlobStorageV1DestinationConnectionStringAuth(string connectionString, string containerName)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));
            Argument.AssertNotNull(containerName, nameof(containerName));

            ConnectionString = connectionString;
            ContainerName = containerName;
            Type = "connectionString";
        }

        /// <summary> Initializes a new instance of BlobStorageV1DestinationConnectionStringAuth. </summary>
        /// <param name="type"> The kind of authentication to use. </param>
        /// <param name="connectionString"> The connection string for accessing the blob storage account. </param>
        /// <param name="containerName"> Name of the container where data should be written in the storage account. </param>
        internal BlobStorageV1DestinationConnectionStringAuth(string type, string connectionString, string containerName) : base(type)
        {
            ConnectionString = connectionString;
            ContainerName = containerName;
            Type = type ?? "connectionString";
        }

        /// <summary> The connection string for accessing the blob storage account. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Name of the container where data should be written in the storage account. </summary>
        public string ContainerName { get; set; }
    }
}
