// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Address Properties</summary>
    [System.ComponentModel.TypeConverter(typeof(AddressPropertiesTypeConverter))]
    public partial class AddressProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AddressProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).AddressValidationStatus = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus?) content.GetValueForProperty("AddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).AddressValidationStatus, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AddressProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ShippingAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ShippingAddress = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IShippingAddress) content.GetValueForProperty("ShippingAddress",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ShippingAddress, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ShippingAddressTypeConverter.ConvertFrom);
            }
            if (content.Contains("ContactDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ContactDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IContactDetails) content.GetValueForProperty("ContactDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).ContactDetail, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ContactDetailsTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddressValidationStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).AddressValidationStatus = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus?) content.GetValueForProperty("AddressValidationStatus",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressPropertiesInternal)this).AddressValidationStatus, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AddressValidationStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AddressProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AddressProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AddressProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AddressProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AddressProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAddressProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Address Properties
    [System.ComponentModel.TypeConverter(typeof(AddressPropertiesTypeConverter))]
    public partial interface IAddressProperties

    {

    }
}