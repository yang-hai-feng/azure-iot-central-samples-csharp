// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class GroupSymmetricKeyAttestation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SymmetricKey))
            {
                writer.WritePropertyName("symmetricKey");
                writer.WriteObjectValue(SymmetricKey);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static GroupSymmetricKeyAttestation DeserializeGroupSymmetricKeyAttestation(JsonElement element)
        {
            Optional<SymmetricKey> symmetricKey = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("symmetricKey"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    symmetricKey = SymmetricKey.DeserializeSymmetricKey(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new GroupSymmetricKeyAttestation(type, symmetricKey.Value);
        }
    }
}
