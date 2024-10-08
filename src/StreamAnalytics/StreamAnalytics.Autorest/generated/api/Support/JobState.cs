// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support
{

    /// <summary>The current execution state of the streaming job.</summary>
    public partial struct JobState :
        System.IEquatable<JobState>
    {
        /// <summary>The job is currently in the Created state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Created = @"Created";

        /// <summary>The job is currently in the Degraded state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Degraded = @"Degraded";

        /// <summary>The job is currently in the Deleting state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Deleting = @"Deleting";

        /// <summary>The job is currently in the Failed state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Failed = @"Failed";

        /// <summary>The job is currently in the Restarting state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Restarting = @"Restarting";

        /// <summary>The job is currently in the Running state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Running = @"Running";

        /// <summary>The job is currently in the Scaling state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Scaling = @"Scaling";

        /// <summary>The job is currently in the Starting state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Starting = @"Starting";

        /// <summary>The job is currently in the Stopped state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Stopped = @"Stopped";

        /// <summary>The job is currently in the Stopping state.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState Stopping = @"Stopping";

        /// <summary>the value for an instance of the <see cref="JobState" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to JobState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="JobState" />.</param>
        internal static object CreateFrom(object value)
        {
            return new JobState(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type JobState</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type JobState (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is JobState && Equals((JobState)obj);
        }

        /// <summary>Returns hashCode for enum JobState</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="JobState"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private JobState(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for JobState</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to JobState</summary>
        /// <param name="value">the value to convert to an instance of <see cref="JobState" />.</param>

        public static implicit operator JobState(string value)
        {
            return new JobState(value);
        }

        /// <summary>Implicit operator to convert JobState to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="JobState" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum JobState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum JobState</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState e1, Microsoft.Azure.PowerShell.Cmdlets.StreamAnalytics.Support.JobState e2)
        {
            return e2.Equals(e1);
        }
    }
}