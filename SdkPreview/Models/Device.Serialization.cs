// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class Device : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Etag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template");
                writer.WriteStringValue(Template);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Simulated))
            {
                writer.WritePropertyName("simulated");
                writer.WriteBooleanValue(Simulated.Value);
            }
            if (Optional.IsCollectionDefined(Organizations))
            {
                writer.WritePropertyName("organizations");
                writer.WriteStartArray();
                foreach (var item in Organizations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStartArray();
                foreach (var item in Type)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DeploymentManifest))
            {
                writer.WritePropertyName("deploymentManifest");
                writer.WriteObjectValue(DeploymentManifest);
            }
            writer.WriteEndObject();
        }

        internal static Device DeserializeDevice(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> etag = default;
            Optional<string> displayName = default;
            Optional<string> template = default;
            Optional<bool> enabled = default;
            Optional<bool> provisioned = default;
            Optional<bool> simulated = default;
            Optional<IList<string>> organizations = default;
            Optional<IList<DeviceType>> type = default;
            Optional<DeploymentManifest> deploymentManifest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("template"))
                {
                    template = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("provisioned"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioned = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("simulated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    simulated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("organizations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    organizations = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DeviceType> array = new List<DeviceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DeviceType(item.GetString()));
                    }
                    type = array;
                    continue;
                }
                if (property.NameEquals("deploymentManifest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deploymentManifest = DeploymentManifest.DeserializeDeploymentManifest(property.Value);
                    continue;
                }
            }
            return new Device(id.Value, etag.Value, displayName.Value, template.Value, Optional.ToNullable(enabled), Optional.ToNullable(provisioned), Optional.ToNullable(simulated), Optional.ToList(organizations), Optional.ToList(type), deploymentManifest.Value);
        }
    }
}
