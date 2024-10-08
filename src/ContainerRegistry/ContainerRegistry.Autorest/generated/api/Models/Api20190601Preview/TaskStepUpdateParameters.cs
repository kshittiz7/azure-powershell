// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Extensions;

    /// <summary>Base properties for updating any task step.</summary>
    public partial class TaskStepUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ITaskStepUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="ContextAccessToken" /> property.</summary>
        private string _contextAccessToken;

        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string ContextAccessToken { get => this._contextAccessToken; set => this._contextAccessToken = value; }

        /// <summary>Backing field for <see cref="ContextPath" /> property.</summary>
        private string _contextPath;

        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public string ContextPath { get => this._contextPath; set => this._contextPath = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType _type;

        /// <summary>The type of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="TaskStepUpdateParameters" /> instance.</summary>
        public TaskStepUpdateParameters()
        {

        }
    }
    /// Base properties for updating any task step.
    public partial interface ITaskStepUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The token (git PAT or SAS token of storage account blob) associated with the context for a step.",
        SerializedName = @"contextAccessToken",
        PossibleTypes = new [] { typeof(string) })]
        string ContextAccessToken { get; set; }
        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL(absolute or relative) of the source context for the task step.",
        SerializedName = @"contextPath",
        PossibleTypes = new [] { typeof(string) })]
        string ContextPath { get; set; }
        /// <summary>The type of the step.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of the step.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType Type { get; set; }

    }
    /// Base properties for updating any task step.
    internal partial interface ITaskStepUpdateParametersInternal

    {
        /// <summary>
        /// The token (git PAT or SAS token of storage account blob) associated with the context for a step.
        /// </summary>
        string ContextAccessToken { get; set; }
        /// <summary>The URL(absolute or relative) of the source context for the task step.</summary>
        string ContextPath { get; set; }
        /// <summary>The type of the step.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.StepType Type { get; set; }

    }
}