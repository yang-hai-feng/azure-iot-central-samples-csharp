// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying formatting options for a chart tile. </summary>
    public partial class ChartFormatConfiguration
    {
        /// <summary> Initializes a new instance of ChartFormatConfiguration. </summary>
        public ChartFormatConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ChartFormatConfiguration. </summary>
        /// <param name="xAxisEnabled"> Whether to display the x-axis. </param>
        /// <param name="yAxisEnabled"> Whether to display the y-axis. </param>
        /// <param name="legendEnabled"> Whether to display the legend. </param>
        internal ChartFormatConfiguration(bool? xAxisEnabled, bool? yAxisEnabled, bool? legendEnabled)
        {
            XAxisEnabled = xAxisEnabled;
            YAxisEnabled = yAxisEnabled;
            LegendEnabled = legendEnabled;
        }

        /// <summary> Whether to display the x-axis. </summary>
        public bool? XAxisEnabled { get; set; }
        /// <summary> Whether to display the y-axis. </summary>
        public bool? YAxisEnabled { get; set; }
        /// <summary> Whether to display the legend. </summary>
        public bool? LegendEnabled { get; set; }
    }
}
