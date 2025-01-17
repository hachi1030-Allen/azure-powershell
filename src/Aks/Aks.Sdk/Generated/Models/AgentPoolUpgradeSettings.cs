// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Settings for upgrading an agentpool
    /// </summary>
    public partial class AgentPoolUpgradeSettings
    {
        /// <summary>
        /// Initializes a new instance of the AgentPoolUpgradeSettings class.
        /// </summary>
        public AgentPoolUpgradeSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentPoolUpgradeSettings class.
        /// </summary>
        /// <param name="maxSurge">The maximum number or percentage of nodes
        /// that are surged during upgrade.</param>
        public AgentPoolUpgradeSettings(string maxSurge = default(string))
        {
            MaxSurge = maxSurge;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the maximum number or percentage of nodes that are
        /// surged during upgrade.
        /// </summary>
        /// <remarks>
        /// This can either be set to an integer (e.g. '5') or a percentage
        /// (e.g. '50%'). If a percentage is specified, it is the percentage of
        /// the total agent pool size at the time of the upgrade. For
        /// percentages, fractional nodes are rounded up. If not specified, the
        /// default is 1. For more information, including best practices, see:
        /// https://learn.microsoft.com/azure/aks/upgrade-cluster#customize-node-surge-upgrade
        /// </remarks>
        [JsonProperty(PropertyName = "maxSurge")]
        public string MaxSurge { get; set; }

    }
}
