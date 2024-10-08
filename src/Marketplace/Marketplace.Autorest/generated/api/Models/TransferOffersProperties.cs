// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>Transfer offers properties</summary>
    public partial class TransferOffersProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersPropertiesInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetails Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersPropertiesInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.TransferOffersDetails()); set { {_property = value;} } }

        /// <summary>Offers ids list to transfer from source collection to target collection(s)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> OfferIdsList { get => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetailsInternal)Property).OfferIdsList; set => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetailsInternal)Property).OfferIdsList = value ?? null /* arrayOf */; }

        /// <summary>Operation to perform (For example: Copy or Move)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Inlined)]
        public string Operation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetailsInternal)Property).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetailsInternal)Property).Operation = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetails _property;

        /// <summary>transfer offers properties details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetails Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.TransferOffersDetails()); set => this._property = value; }

        /// <summary>Target collections ids</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> TargetCollection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetailsInternal)Property).TargetCollection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetailsInternal)Property).TargetCollection = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="TransferOffersProperties" /> instance.</summary>
        public TransferOffersProperties()
        {

        }
    }
    /// Transfer offers properties
    public partial interface ITransferOffersProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Offers ids list to transfer from source collection to target collection(s)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Offers ids list to transfer from source collection to target collection(s)",
        SerializedName = @"offerIdsList",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> OfferIdsList { get; set; }
        /// <summary>Operation to perform (For example: Copy or Move)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operation to perform (For example: Copy or Move)",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string Operation { get; set; }
        /// <summary>Target collections ids</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target collections ids",
        SerializedName = @"targetCollections",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> TargetCollection { get; set; }

    }
    /// Transfer offers properties
    internal partial interface ITransferOffersPropertiesInternal

    {
        /// <summary>Offers ids list to transfer from source collection to target collection(s)</summary>
        System.Collections.Generic.List<string> OfferIdsList { get; set; }
        /// <summary>Operation to perform (For example: Copy or Move)</summary>
        string Operation { get; set; }
        /// <summary>transfer offers properties details</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ITransferOffersDetails Property { get; set; }
        /// <summary>Target collections ids</summary>
        System.Collections.Generic.List<string> TargetCollection { get; set; }

    }
}