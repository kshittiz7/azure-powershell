// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(JobPatchProperties1TypeConverter))]
    public partial class JobPatchProperties1
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
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobPatchProperties1"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1 DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new JobPatchProperties1(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobPatchProperties1"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1 DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new JobPatchProperties1(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="JobPatchProperties1" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="JobPatchProperties1" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1 FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobPatchProperties1"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal JobPatchProperties1(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Configuration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfiguration) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Configuration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Template"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Template = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobTemplate) content.GetValueForProperty("Template",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Template, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobTemplateTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnvironmentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EnvironmentId = (string) content.GetValueForProperty("EnvironmentId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EnvironmentId, global::System.Convert.ToString);
            }
            if (content.Contains("OutboundIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).OutboundIPAddress = (System.Collections.Generic.List<string>) content.GetValueForProperty("OutboundIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).OutboundIPAddress, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EventStreamEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventStreamEndpoint = (string) content.GetValueForProperty("EventStreamEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventStreamEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationTriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationTriggerType = (string) content.GetValueForProperty("ConfigurationTriggerType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationTriggerType, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationManualTriggerConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationManualTriggerConfig = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfigurationManualTriggerConfig) content.GetValueForProperty("ConfigurationManualTriggerConfig",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationManualTriggerConfig, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationManualTriggerConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationScheduleTriggerConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationScheduleTriggerConfig = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfigurationScheduleTriggerConfig) content.GetValueForProperty("ConfigurationScheduleTriggerConfig",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationScheduleTriggerConfig, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationScheduleTriggerConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationEventTriggerConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationEventTriggerConfig = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfigurationEventTriggerConfig) content.GetValueForProperty("ConfigurationEventTriggerConfig",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationEventTriggerConfig, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationEventTriggerConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationSecret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ISecret>) content.GetValueForProperty("ConfigurationSecret",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationSecret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ISecret>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.SecretTypeConverter.ConvertFrom));
            }
            if (content.Contains("ConfigurationReplicaTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaTimeout = (int) content.GetValueForProperty("ConfigurationReplicaTimeout",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaTimeout, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ConfigurationReplicaRetryLimit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaRetryLimit = (int?) content.GetValueForProperty("ConfigurationReplicaRetryLimit",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaRetryLimit, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ConfigurationRegistry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationRegistry = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IRegistryCredentials>) content.GetValueForProperty("ConfigurationRegistry",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationRegistry, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IRegistryCredentials>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.RegistryCredentialsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManualTriggerConfigParallelism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigParallelism = (int?) content.GetValueForProperty("ManualTriggerConfigParallelism",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigParallelism, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScheduleTriggerConfigParallelism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigParallelism = (int?) content.GetValueForProperty("ScheduleTriggerConfigParallelism",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigParallelism, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EventTriggerConfigParallelism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigParallelism = (int?) content.GetValueForProperty("EventTriggerConfigParallelism",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigParallelism, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TemplateInitContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateInitContainer = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IInitContainer>) content.GetValueForProperty("TemplateInitContainer",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateInitContainer, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IInitContainer>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.InitContainerTypeConverter.ConvertFrom));
            }
            if (content.Contains("TemplateContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateContainer = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainer>) content.GetValueForProperty("TemplateContainer",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateContainer, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainer>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerTypeConverter.ConvertFrom));
            }
            if (content.Contains("TemplateVolume"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateVolume = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IVolume>) content.GetValueForProperty("TemplateVolume",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateVolume, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IVolume>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.VolumeTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManualTriggerConfigReplicaCompletionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigReplicaCompletionCount = (int?) content.GetValueForProperty("ManualTriggerConfigReplicaCompletionCount",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigReplicaCompletionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScheduleTriggerConfigReplicaCompletionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigReplicaCompletionCount = (int?) content.GetValueForProperty("ScheduleTriggerConfigReplicaCompletionCount",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigReplicaCompletionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScheduleTriggerConfigCronExpression"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigCronExpression = (string) content.GetValueForProperty("ScheduleTriggerConfigCronExpression",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigCronExpression, global::System.Convert.ToString);
            }
            if (content.Contains("EventTriggerConfigScale"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigScale = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScale) content.GetValueForProperty("EventTriggerConfigScale",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigScale, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobScaleTypeConverter.ConvertFrom);
            }
            if (content.Contains("EventTriggerConfigReplicaCompletionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigReplicaCompletionCount = (int?) content.GetValueForProperty("EventTriggerConfigReplicaCompletionCount",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigReplicaCompletionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScalePollingInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScalePollingInterval = (int?) content.GetValueForProperty("ScalePollingInterval",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScalePollingInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScaleMinExecution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMinExecution = (int?) content.GetValueForProperty("ScaleMinExecution",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMinExecution, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScaleMaxExecution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMaxExecution = (int?) content.GetValueForProperty("ScaleMaxExecution",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMaxExecution, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScaleRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScaleRule>) content.GetValueForProperty("ScaleRule",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScaleRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobScaleRuleTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobPatchProperties1"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal JobPatchProperties1(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Configuration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Configuration = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfiguration) content.GetValueForProperty("Configuration",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Configuration, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Template"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Template = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobTemplate) content.GetValueForProperty("Template",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).Template, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobTemplateTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnvironmentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EnvironmentId = (string) content.GetValueForProperty("EnvironmentId",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EnvironmentId, global::System.Convert.ToString);
            }
            if (content.Contains("OutboundIPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).OutboundIPAddress = (System.Collections.Generic.List<string>) content.GetValueForProperty("OutboundIPAddress",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).OutboundIPAddress, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("EventStreamEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventStreamEndpoint = (string) content.GetValueForProperty("EventStreamEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventStreamEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationTriggerType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationTriggerType = (string) content.GetValueForProperty("ConfigurationTriggerType",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationTriggerType, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationManualTriggerConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationManualTriggerConfig = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfigurationManualTriggerConfig) content.GetValueForProperty("ConfigurationManualTriggerConfig",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationManualTriggerConfig, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationManualTriggerConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationScheduleTriggerConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationScheduleTriggerConfig = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfigurationScheduleTriggerConfig) content.GetValueForProperty("ConfigurationScheduleTriggerConfig",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationScheduleTriggerConfig, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationScheduleTriggerConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationEventTriggerConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationEventTriggerConfig = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobConfigurationEventTriggerConfig) content.GetValueForProperty("ConfigurationEventTriggerConfig",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationEventTriggerConfig, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobConfigurationEventTriggerConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("ConfigurationSecret"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationSecret = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ISecret>) content.GetValueForProperty("ConfigurationSecret",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationSecret, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.ISecret>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.SecretTypeConverter.ConvertFrom));
            }
            if (content.Contains("ConfigurationReplicaTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaTimeout = (int) content.GetValueForProperty("ConfigurationReplicaTimeout",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaTimeout, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ConfigurationReplicaRetryLimit"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaRetryLimit = (int?) content.GetValueForProperty("ConfigurationReplicaRetryLimit",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationReplicaRetryLimit, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ConfigurationRegistry"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationRegistry = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IRegistryCredentials>) content.GetValueForProperty("ConfigurationRegistry",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ConfigurationRegistry, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IRegistryCredentials>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.RegistryCredentialsTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManualTriggerConfigParallelism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigParallelism = (int?) content.GetValueForProperty("ManualTriggerConfigParallelism",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigParallelism, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScheduleTriggerConfigParallelism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigParallelism = (int?) content.GetValueForProperty("ScheduleTriggerConfigParallelism",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigParallelism, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("EventTriggerConfigParallelism"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigParallelism = (int?) content.GetValueForProperty("EventTriggerConfigParallelism",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigParallelism, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("TemplateInitContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateInitContainer = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IInitContainer>) content.GetValueForProperty("TemplateInitContainer",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateInitContainer, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IInitContainer>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.InitContainerTypeConverter.ConvertFrom));
            }
            if (content.Contains("TemplateContainer"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateContainer = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainer>) content.GetValueForProperty("TemplateContainer",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateContainer, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IContainer>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.ContainerTypeConverter.ConvertFrom));
            }
            if (content.Contains("TemplateVolume"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateVolume = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IVolume>) content.GetValueForProperty("TemplateVolume",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).TemplateVolume, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IVolume>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.VolumeTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManualTriggerConfigReplicaCompletionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigReplicaCompletionCount = (int?) content.GetValueForProperty("ManualTriggerConfigReplicaCompletionCount",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ManualTriggerConfigReplicaCompletionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScheduleTriggerConfigReplicaCompletionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigReplicaCompletionCount = (int?) content.GetValueForProperty("ScheduleTriggerConfigReplicaCompletionCount",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigReplicaCompletionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScheduleTriggerConfigCronExpression"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigCronExpression = (string) content.GetValueForProperty("ScheduleTriggerConfigCronExpression",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScheduleTriggerConfigCronExpression, global::System.Convert.ToString);
            }
            if (content.Contains("EventTriggerConfigScale"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigScale = (Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScale) content.GetValueForProperty("EventTriggerConfigScale",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigScale, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobScaleTypeConverter.ConvertFrom);
            }
            if (content.Contains("EventTriggerConfigReplicaCompletionCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigReplicaCompletionCount = (int?) content.GetValueForProperty("EventTriggerConfigReplicaCompletionCount",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).EventTriggerConfigReplicaCompletionCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScalePollingInterval"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScalePollingInterval = (int?) content.GetValueForProperty("ScalePollingInterval",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScalePollingInterval, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScaleMinExecution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMinExecution = (int?) content.GetValueForProperty("ScaleMinExecution",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMinExecution, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScaleMaxExecution"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMaxExecution = (int?) content.GetValueForProperty("ScaleMaxExecution",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleMaxExecution, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ScaleRule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleRule = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScaleRule>) content.GetValueForProperty("ScaleRule",((Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobPatchProperties1Internal)this).ScaleRule, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.App.Models.IJobScaleRule>(__y, Microsoft.Azure.PowerShell.Cmdlets.App.Models.JobScaleRuleTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(JobPatchProperties1TypeConverter))]
    public partial interface IJobPatchProperties1

    {

    }
}