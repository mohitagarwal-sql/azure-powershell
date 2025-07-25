// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for Node type action. If nodes are not specified on the
    /// parameters, the operation will be performed in all nodes of the node type
    /// one upgrade domain at a time.
    /// </summary>
    public partial class NodeTypeActionParameters
    {
        /// <summary>
        /// Initializes a new instance of the NodeTypeActionParameters class.
        /// </summary>
        public NodeTypeActionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NodeTypeActionParameters class.
        /// </summary>

        /// <param name="nodes">List of node names from the node type.
        /// </param>

        /// <param name="force">Force the action to go through.
        /// </param>

        /// <param name="updateType">Specifies the way the operation will be performed.
        /// Possible values include: &#39;Default&#39;, &#39;ByUpgradeDomain&#39;</param>
        public NodeTypeActionParameters(System.Collections.Generic.IList<string> nodes = default(System.Collections.Generic.IList<string>), bool? force = default(bool?), string updateType = default(string))

        {
            this.Nodes = nodes;
            this.Force = force;
            this.UpdateType = updateType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets list of node names from the node type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodes")]
        public System.Collections.Generic.IList<string> Nodes {get; set; }

        /// <summary>
        /// Gets or sets force the action to go through.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "force")]
        public bool? Force {get; set; }

        /// <summary>
        /// Gets or sets specifies the way the operation will be performed. Possible values include: &#39;Default&#39;, &#39;ByUpgradeDomain&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "updateType")]
        public string UpdateType {get; set; }
    }
}