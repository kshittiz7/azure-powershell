// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Extensions;

    public partial class PrivateLinkScopedResource :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResourceInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure
        /// Monitor Private Link Scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="ScopeId" /> property.</summary>
        private string _scopeId;

        /// <summary>
        /// The immutableId of the Azure Monitor Private Link Scope Resource to which the association is.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.PropertyOrigin.Owned)]
        public string ScopeId { get => this._scopeId; set => this._scopeId = value; }

        /// <summary>Creates an new <see cref="PrivateLinkScopedResource" /> instance.</summary>
        public PrivateLinkScopedResource()
        {

        }
    }
    public partial interface IPrivateLinkScopedResource :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure
        /// Monitor Private Link Scope.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure Monitor Private Link Scope.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }
        /// <summary>
        /// The immutableId of the Azure Monitor Private Link Scope Resource to which the association is.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The immutableId of the Azure Monitor Private Link Scope Resource to which the association is.",
        SerializedName = @"scopeId",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeId { get; set; }

    }
    internal partial interface IPrivateLinkScopedResourceInternal

    {
        /// <summary>
        /// The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure
        /// Monitor Private Link Scope.
        /// </summary>
        string ResourceId { get; set; }
        /// <summary>
        /// The immutableId of the Azure Monitor Private Link Scope Resource to which the association is.
        /// </summary>
        string ScopeId { get; set; }

    }
}