// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>The Private Endpoint resource.</summary>
    public partial class PrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IPrivateEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IPrivateEndpointInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ARM identifier for Private Endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IPrivateEndpointInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Creates an new <see cref="PrivateEndpoint" /> instance.</summary>
        public PrivateEndpoint()
        {

        }
    }
    /// The Private Endpoint resource.
    public partial interface IPrivateEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable
    {
        /// <summary>The ARM identifier for Private Endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ARM identifier for Private Endpoint",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }

    }
    /// The Private Endpoint resource.
    internal partial interface IPrivateEndpointInternal

    {
        /// <summary>The ARM identifier for Private Endpoint</summary>
        string Id { get; set; }

    }
}