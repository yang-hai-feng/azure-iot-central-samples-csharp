// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    public partial class JobProgress
    {
        internal static JobProgress DeserializeJobProgress(JsonElement element)
        {
            Optional<int> total = default;
            Optional<int> pending = default;
            Optional<int> completed = default;
            Optional<int> failed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("total"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pending"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    pending = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("completed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    completed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("failed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    failed = property.Value.GetInt32();
                    continue;
                }
            }
            return new JobProgress(Optional.ToNullable(total), Optional.ToNullable(pending), Optional.ToNullable(completed), Optional.ToNullable(failed));
        }
    }
}