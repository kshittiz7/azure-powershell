// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Support
{

    /// <summary>The method that should be used to authenticate the user.</summary>
    public partial struct ClientCredentialMethod :
        System.IEquatable<ClientCredentialMethod>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod ClientSecretPost = @"ClientSecretPost";

        /// <summary>the value for an instance of the <see cref="ClientCredentialMethod" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ClientCredentialMethod"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ClientCredentialMethod(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ClientCredentialMethod</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClientCredentialMethod" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ClientCredentialMethod(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ClientCredentialMethod</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ClientCredentialMethod (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ClientCredentialMethod && Equals((ClientCredentialMethod)obj);
        }

        /// <summary>Returns hashCode for enum ClientCredentialMethod</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ClientCredentialMethod</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ClientCredentialMethod</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ClientCredentialMethod" />.</param>

        public static implicit operator ClientCredentialMethod(string value)
        {
            return new ClientCredentialMethod(value);
        }

        /// <summary>Implicit operator to convert ClientCredentialMethod to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ClientCredentialMethod" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ClientCredentialMethod</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ClientCredentialMethod</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod e1, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.ClientCredentialMethod e2)
        {
            return e2.Equals(e1);
        }
    }
}