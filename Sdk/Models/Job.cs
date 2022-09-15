// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.IoTCentral.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The job definition.
    /// </summary>
    public partial class Job
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="group">The ID of the device group on which to execute
        /// the job.</param>
        /// <param name="data">The capabilities being updated by the job and
        /// the values with which they are being updated.</param>
        /// <param name="id">Unique ID of the job.</param>
        /// <param name="scheduledJobId">Id of the scheduled job definition
        /// that created this job.</param>
        /// <param name="displayName">Display name of the job.</param>
        /// <param name="description">Detailed description of the job.</param>
        /// <param name="batch">The batching configuration for the job.</param>
        /// <param name="cancellationThreshold">The cancellation threshold for
        /// the job.</param>
        /// <param name="start">The start time of the job</param>
        /// <param name="end">The end time of the job</param>
        /// <param name="progress">The progress statistics of the job.</param>
        /// <param name="status">Indicates whether the job is starting,
        /// running, etc.</param>
        /// <param name="organizations">List of organizations of the job, only
        /// one organization is supported today, multiple organizations will be
        /// supported soon.</param>
        public Job(string group, IList<JobData> data, string id = default(string), string scheduledJobId = default(string), string displayName = default(string), string description = default(string), JobBatch batch = default(JobBatch), JobCancellationThreshold cancellationThreshold = default(JobCancellationThreshold), System.DateTime? start = default(System.DateTime?), System.DateTime? end = default(System.DateTime?), JobProgress progress = default(JobProgress), string status = default(string), IList<string> organizations = default(IList<string>))
        {
            Id = id;
            ScheduledJobId = scheduledJobId;
            DisplayName = displayName;
            Description = description;
            Group = group;
            Batch = batch;
            CancellationThreshold = cancellationThreshold;
            Data = data;
            Start = start;
            End = end;
            Progress = progress;
            Status = status;
            Organizations = organizations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets unique ID of the job.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets id of the scheduled job definition that created this
        /// job.
        /// </summary>
        [JsonProperty(PropertyName = "scheduledJobId")]
        public string ScheduledJobId { get; set; }

        /// <summary>
        /// Gets or sets display name of the job.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets detailed description of the job.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ID of the device group on which to execute the
        /// job.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the batching configuration for the job.
        /// </summary>
        [JsonProperty(PropertyName = "batch")]
        public JobBatch Batch { get; set; }

        /// <summary>
        /// Gets or sets the cancellation threshold for the job.
        /// </summary>
        [JsonProperty(PropertyName = "cancellationThreshold")]
        public JobCancellationThreshold CancellationThreshold { get; set; }

        /// <summary>
        /// Gets or sets the capabilities being updated by the job and the
        /// values with which they are being updated.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<JobData> Data { get; set; }

        /// <summary>
        /// Gets the start time of the job
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public System.DateTime? Start { get; private set; }

        /// <summary>
        /// Gets the end time of the job
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public System.DateTime? End { get; private set; }

        /// <summary>
        /// Gets the progress statistics of the job.
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public JobProgress Progress { get; private set; }

        /// <summary>
        /// Gets indicates whether the job is starting, running, etc.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets list of organizations of the job, only one
        /// organization is supported today, multiple organizations will be
        /// supported soon.
        /// </summary>
        [JsonProperty(PropertyName = "organizations")]
        public IList<string> Organizations { get; set; }

    }
}