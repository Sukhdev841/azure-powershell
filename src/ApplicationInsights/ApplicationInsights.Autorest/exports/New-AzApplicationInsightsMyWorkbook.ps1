
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create a new private workbook.
.Description
Create a new private workbook.
.Example
# The value of the parameter name is the Guid type.
$name = (New-Guid).ToString()
New-AzApplicationInsightsMyWorkbook -ResourceGroupName appinsights-hkrs2v-test -Name $name -Location westus2  -DisplayName "$name-display" -SourceId "/subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourcegroups/appinsights-hkrs2v-test/providers/microsoft.insights/components/appinsights-48mah3-pwsh" -Category 'workbook' -SerializedData $null

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IMyWorkbook
.Link
https://learn.microsoft.com/powershell/module/az.applicationinsights/new-azapplicationinsightsmyworkbook
#>
function New-AzApplicationInsightsMyWorkbook {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IMyWorkbook])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [System.String]
    # The name of the Application Insights component resource.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Query')]
    [System.String]
    # Azure Resource Id that will fetch all linked workbooks.
    ${LinkedSourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Workbook category, as defined by the user at creation time.
    ${Category},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # The user-defined name of the private workbook.
    ${DisplayName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IMyWorkbookResourceEtag]))]
    [System.Collections.Hashtable]
    # Resource etag
    ${Etag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Azure resource Id
    ${Id},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # The identity type.
    ${IdentityType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Configuration of this particular private workbook.
    # Configuration data is a string containing valid JSON
    ${SerializedData},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Optional resourceId for a source resource.
    ${SourceId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String[]]
    # A list of 0 or more tags that are associated with this private workbook definition
    ${SourceTag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # BYOS Storage Account URI
    ${StorageUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20210308.IMyWorkbookResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # Azure resource type
    ${Type},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Body')]
    [System.String]
    # This instance's version of the data model.
    # This can change as new features are added that can be marked private workbook.
    ${Version},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.ApplicationInsights.private\New-AzApplicationInsightsMyWorkbook_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.PipelineMock' -eq $_.Target.GetType().FullName) }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Kind')) {
            $PSBoundParameters['Kind'] = "user"
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
