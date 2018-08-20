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
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineScaleSetForceRecoveryServiceFabricPlatformUpdateDomainWalkDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pResourceGroupName = new RuntimeDefinedParameter();
            pResourceGroupName.Name = "ResourceGroupName";
            pResourceGroupName.ParameterType = typeof(string);
            pResourceGroupName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pResourceGroupName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ResourceGroupName", pResourceGroupName);

            var pVMScaleSetName = new RuntimeDefinedParameter();
            pVMScaleSetName.Name = "VMScaleSetName";
            pVMScaleSetName.ParameterType = typeof(string);
            pVMScaleSetName.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 2,
                Mandatory = true
            });
            pVMScaleSetName.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VMScaleSetName", pVMScaleSetName);

            var pPlatformUpdateDomain = new RuntimeDefinedParameter();
            pPlatformUpdateDomain.Name = "PlatformUpdateDomain";
            pPlatformUpdateDomain.ParameterType = typeof(int);
            pPlatformUpdateDomain.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 3,
                Mandatory = true
            });
            pPlatformUpdateDomain.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("PlatformUpdateDomain", pPlatformUpdateDomain);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 4,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineScaleSetForceRecoveryServiceFabricPlatformUpdateDomainWalkMethod(object[] invokeMethodInputParameters)
        {
            string resourceGroupName = (string)ParseParameter(invokeMethodInputParameters[0]);
            string vmScaleSetName = (string)ParseParameter(invokeMethodInputParameters[1]);
            int platformUpdateDomain = (int)ParseParameter(invokeMethodInputParameters[2]);

            var result = VirtualMachineScaleSetsClient.ForceRecoveryServiceFabricPlatformUpdateDomainWalk(resourceGroupName, vmScaleSetName, platformUpdateDomain);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected PSArgument[] CreateVirtualMachineScaleSetForceRecoveryServiceFabricPlatformUpdateDomainWalkParameters()
        {
            string resourceGroupName = string.Empty;
            string vmScaleSetName = string.Empty;
            int platformUpdateDomain = new int();

            return ConvertFromObjectsToArguments(
                 new string[] { "ResourceGroupName", "VMScaleSetName", "PlatformUpdateDomain" },
                 new object[] { resourceGroupName, vmScaleSetName, platformUpdateDomain });
        }
    }

    [Cmdlet("Repair", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VmssServiceFabricUpdateDomain", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [Alias("Repair-AzureRmVmssServiceFabricUD")]
    [OutputType(typeof(PSRecoveryWalkResponse))]
    public partial class RepairAzureRmVmssServiceFabricUpdateDomain : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.VMScaleSetName, "Repair"))
                {
                    string resourceGroupName;
                    string vmScaleSetName;
                    switch(this.ParameterSetName)
                    {
                        case "ResourceIdParameter":
                            resourceGroupName = GetResourceGroupName(this.ResourceId);
                            vmScaleSetName = GetResourceName(this.ResourceId, "Microsoft.Compute/VirtualMachineScaleSets");
                            break;
                        case "ObjectParameter":
                            resourceGroupName = GetResourceGroupName(this.VirtualMachineScaleSet.Id);
                            vmScaleSetName = GetResourceName(this.VirtualMachineScaleSet.Id, "Microsoft.Compute/VirtualMachineScaleSets");
                            break;
                        default:
                            resourceGroupName = this.ResourceGroupName;
                            vmScaleSetName = this.VMScaleSetName;
                            break;
                    }
                    int platformUpdateDomain = this.PlatformUpdateDomain;

                    var result = VirtualMachineScaleSetsClient.ForceRecoveryServiceFabricPlatformUpdateDomainWalk(resourceGroupName, vmScaleSetName, platformUpdateDomain);
                    var psObject = new PSRecoveryWalkResponse();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<RecoveryWalkResponse, PSRecoveryWalkResponse>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceManager.Common.ArgumentCompleters.ResourceGroupCompleter()]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("Name")]
        public string VMScaleSetName { get; set; }

        [Parameter(
            Position = 3,
            Mandatory = true)]
        public int PlatformUpdateDomain { get; set; }

        [Parameter(
           ParameterSetName = "ResourceIdParameter",
           Mandatory = true,
           ValueFromPipelineByPropertyName = true)]
        public string ResourceId { get; set; }

        [Parameter(
            ParameterSetName = "ObjectParameter",
            Mandatory = true,
            ValueFromPipeline = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}