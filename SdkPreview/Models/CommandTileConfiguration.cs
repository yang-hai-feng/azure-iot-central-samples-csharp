// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Microsoft.Azure.IoTCentral.Preview.Models
{
    /// <summary> Configuration specifying options for a command tile. </summary>
    public partial class CommandTileConfiguration : TileConfiguration
    {
        /// <summary> Initializes a new instance of CommandTileConfiguration. </summary>
        /// <param name="group"> The ID of the device group to display. </param>
        /// <param name="command"> The command to reference in the tile. </param>
        /// <param name="device"> The device to reference in the tile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="group"/>, <paramref name="command"/> or <paramref name="device"/> is null. </exception>
        public CommandTileConfiguration(string group, string command, object device)
        {
            Argument.AssertNotNull(group, nameof(group));
            Argument.AssertNotNull(command, nameof(command));
            Argument.AssertNotNull(device, nameof(device));

            Group = group;
            Command = command;
            Device = device;
            Type = "command";
        }

        /// <summary> Initializes a new instance of CommandTileConfiguration. </summary>
        /// <param name="type"> The type of widget the tile renders. </param>
        /// <param name="group"> The ID of the device group to display. </param>
        /// <param name="command"> The command to reference in the tile. </param>
        /// <param name="device"> The device to reference in the tile. </param>
        internal CommandTileConfiguration(string type, string group, string command, object device) : base(type)
        {
            Group = group;
            Command = command;
            Device = device;
            Type = type ?? "command";
        }

        /// <summary> The ID of the device group to display. </summary>
        public string Group { get; set; }
        /// <summary> The command to reference in the tile. </summary>
        public string Command { get; set; }
        /// <summary> The device to reference in the tile. </summary>
        public object Device { get; set; }
    }
}