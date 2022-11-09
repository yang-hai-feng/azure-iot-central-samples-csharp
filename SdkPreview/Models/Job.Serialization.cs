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
    public partial class Job : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduledJobId))
            {
                writer.WritePropertyName("scheduledJobId");
                writer.WriteStringValue(ScheduledJobId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("group");
            writer.WriteStringValue(Group);
            if (Optional.IsDefined(Batch))
            {
                writer.WritePropertyName("batch");
                writer.WriteObjectValue(Batch);
            }
            if (Optional.IsDefined(CancellationThreshold))
            {
                writer.WritePropertyName("cancellationThreshold");
                writer.WriteObjectValue(CancellationThreshold);
            }
            writer.WritePropertyName("data");
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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
            writer.WriteEndObject();
        }

        internal static Job DeserializeJob(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> scheduledJobId = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            string group = default;
            Optional<JobBatch> batch = default;
            Optional<JobCancellationThreshold> cancellationThreshold = default;
            IList<JobData> data = default;
            Optional<DateTimeOffset> start = default;
            Optional<DateTimeOffset> end = default;
            Optional<JobProgress> progress = default;
            Optional<string> status = default;
            Optional<IList<string>> organizations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scheduledJobId"))
                {
                    scheduledJobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("group"))
                {
                    group = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("batch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    batch = JobBatch.DeserializeJobBatch(property.Value);
                    continue;
                }
                if (property.NameEquals("cancellationThreshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cancellationThreshold = JobCancellationThreshold.DeserializeJobCancellationThreshold(property.Value);
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    List<JobData> array = new List<JobData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobData.DeserializeJobData(item));
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("start"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    start = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("end"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    end = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("progress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    progress = JobProgress.DeserializeJobProgress(property.Value);
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
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
            }
            return new Job(id.Value, scheduledJobId.Value, displayName.Value, description.Value, group, batch.Value, cancellationThreshold.Value, data, Optional.ToNullable(start), Optional.ToNullable(end), progress.Value, status.Value, Optional.ToList(organizations));
        }
    }
}
