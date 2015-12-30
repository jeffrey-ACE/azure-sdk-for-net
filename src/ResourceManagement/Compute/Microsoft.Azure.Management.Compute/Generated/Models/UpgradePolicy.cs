// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes an upgrade policy - automatic or manual.
    /// </summary>
    public partial class UpgradePolicy
    {
        /// <summary>
        /// Initializes a new instance of the UpgradePolicy class.
        /// </summary>
        public UpgradePolicy() { }

        /// <summary>
        /// Initializes a new instance of the UpgradePolicy class.
        /// </summary>
        public UpgradePolicy(string mode = default(string))
        {
            Mode = mode;
        }

        /// <summary>
        /// Gets or sets the upgrade mode. Possible values for this property
        /// include: 'Automatic', 'Manual'.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

    }
}
