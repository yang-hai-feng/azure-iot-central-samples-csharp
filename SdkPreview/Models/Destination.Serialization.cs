// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class Destination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static Destination DeserializeDestination(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ExportDestination": return ExportDestination.DeserializeExportDestination(element);
                    case "blobstorage@v1": return BlobStorageV1Destination.DeserializeBlobStorageV1Destination(element);
                    case "dataexplorer@v1": return DataExplorerV1Destination.DeserializeDataExplorerV1Destination(element);
                    case "eventhubs@v1": return EventHubsV1Destination.DeserializeEventHubsV1Destination(element);
                    case "servicebusqueue@v1": return ServiceBusQueueV1Destination.DeserializeServiceBusQueueV1Destination(element);
                    case "servicebustopic@v1": return ServiceBusTopicV1Destination.DeserializeServiceBusTopicV1Destination(element);
                    case "webhook@v1": return WebhookV1Destination.DeserializeWebhookV1Destination(element);
                }
            }
            Optional<string> id = default;
            string displayName = default;
            string type = default;
            Optional<string> status = default;
            Optional<IReadOnlyList<DataExportError>> errors = default;
            Optional<DateTimeOffset> lastExportTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataExportError> array = new List<DataExportError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataExportError.DeserializeDataExportError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("lastExportTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastExportTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new Destination(status.Value, Optional.ToList(errors), Optional.ToNullable(lastExportTime), id.Value, displayName, type);
        }
    }
}
