// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class DataExplorerV1DestinationAuth : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static DataExplorerV1DestinationAuth DeserializeDataExplorerV1DestinationAuth(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "servicePrincipal": return DataExplorerV1DestinationServicePrincipalAuth.DeserializeDataExplorerV1DestinationServicePrincipalAuth(element);
                    case "systemAssignedManagedIdentity": return DataExplorerV1DestinationSystemAssignedManagedIdentityAuth.DeserializeDataExplorerV1DestinationSystemAssignedManagedIdentityAuth(element);
                }
            }
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new DataExplorerV1DestinationAuth(type);
        }
    }
}
