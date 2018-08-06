﻿//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssOsProfile", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class SetAzureRmVmssOsProfileCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string ComputerNamePrefix { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string AdminUsername { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 3,
            ValueFromPipelineByPropertyName = true)]
        public string AdminPassword { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 4,
            ValueFromPipelineByPropertyName = true)]
        public string CustomData { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 5,
            ValueFromPipelineByPropertyName = true)]
        public bool? WindowsConfigurationProvisionVMAgent { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 6,
            ValueFromPipelineByPropertyName = true)]
        public bool? WindowsConfigurationEnableAutomaticUpdate { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 7,
            ValueFromPipelineByPropertyName = true)]
        public string TimeZone { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 8,
            ValueFromPipelineByPropertyName = true)]
        public AdditionalUnattendContent[] AdditionalUnattendContent { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 9,
            ValueFromPipelineByPropertyName = true)]
        public WinRMListener[] Listener { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 10,
            ValueFromPipelineByPropertyName = true)]
        public bool? LinuxConfigurationDisablePasswordAuthentication { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 11,
            ValueFromPipelineByPropertyName = true)]
        public SshPublicKey[] PublicKey { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 12,
            ValueFromPipelineByPropertyName = true)]
        public VaultSecretGroup[] Secret { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Set"))
            {
                Run();
            }
        }

        private void Run()
        {
            if (this.MyInvocation.BoundParameters.ContainsKey("ComputerNamePrefix"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.ComputerNamePrefix = this.ComputerNamePrefix;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("AdminUsername"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.AdminUsername = this.AdminUsername;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("AdminPassword"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.AdminPassword = this.AdminPassword;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("CustomData"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.CustomData = this.CustomData;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("WindowsConfigurationProvisionVMAgent"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // WindowsConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration = new Microsoft.Azure.Management.Compute.Models.WindowsConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.ProvisionVMAgent = this.WindowsConfigurationProvisionVMAgent;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("WindowsConfigurationEnableAutomaticUpdate"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // WindowsConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration = new Microsoft.Azure.Management.Compute.Models.WindowsConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.EnableAutomaticUpdates = this.WindowsConfigurationEnableAutomaticUpdate;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("TimeZone"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // WindowsConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration = new Microsoft.Azure.Management.Compute.Models.WindowsConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.TimeZone = this.TimeZone;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("AdditionalUnattendContent"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // WindowsConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration = new Microsoft.Azure.Management.Compute.Models.WindowsConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.AdditionalUnattendContent = this.AdditionalUnattendContent;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("Listener"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // WindowsConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration = new Microsoft.Azure.Management.Compute.Models.WindowsConfiguration();
                }
                // WinRM
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.WinRM == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.WinRM = new Microsoft.Azure.Management.Compute.Models.WinRMConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.WindowsConfiguration.WinRM.Listeners = this.Listener;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("LinuxConfigurationDisablePasswordAuthentication"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // LinuxConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration = new Microsoft.Azure.Management.Compute.Models.LinuxConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.DisablePasswordAuthentication = this.LinuxConfigurationDisablePasswordAuthentication;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("PublicKey"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                // LinuxConfiguration
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration = new Microsoft.Azure.Management.Compute.Models.LinuxConfiguration();
                }
                // Ssh
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh = new Microsoft.Azure.Management.Compute.Models.SshConfiguration();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh.PublicKeys = this.PublicKey;
            }

            if (this.MyInvocation.BoundParameters.ContainsKey("Secret"))
            {
                // VirtualMachineProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
                }
                // OsProfile
                if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
                {
                    this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
                }
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.Secrets = this.Secret;
            }

            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}
