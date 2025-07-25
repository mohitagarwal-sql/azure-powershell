#
# Module manifest for module 'Az.EventHub'
#
# Generated by: Microsoft Corporation
#
# Generated on: 5/14/2025
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '5.3.0'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'd1fc588c-f6f1-4c18-968b-94c7c1ee695d'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Event Hubs service cmdlets for Azure Resource Manager in Windows PowerShell and PowerShell Core.

For more information on Event Hubs, please visit the following: https://learn.microsoft.com/azure/event-hubs/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# ClrVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '5.0.0'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'EventHub.Autorest/bin/Az.EventHub.private.dll', 
               'Microsoft.Azure.PowerShell.EventHub.Management.Sdk.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'EventHub.Autorest/Az.EventHub.format.ps1xml', 
               'EventHub.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('EventHub.Autorest/Az.EventHub.psm1', 
               'Microsoft.Azure.PowerShell.Cmdlets.EventHub.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'Approve-AzEventHubPrivateEndpointConnection', 
               'Deny-AzEventHubPrivateEndpointConnection', 'Get-AzEventHub', 
               'Get-AzEventHubApplicationGroup', 'Get-AzEventHubAuthorizationRule', 
               'Get-AzEventHubCluster', 'Get-AzEventHubClusterNamespace', 
               'Get-AzEventHubClustersAvailableRegion', 
               'Get-AzEventHubConsumerGroup', 'Get-AzEventHubGeoDRConfiguration', 
               'Get-AzEventHubKey', 'Get-AzEventHubNamespace', 
               'Get-AzEventHubNetworkRuleSet', 
               'Get-AzEventHubPrivateEndpointConnection', 
               'Get-AzEventHubPrivateLink', 'Get-AzEventHubSchemaGroup', 
               'Get-AzEventHubNetworkSecurityPerimeterConfiguration',
               'Get-AzEventHubNetworkSecurityPerimeterConfigurationsForAssociation',
               'New-AzEventHub', 'New-AzEventHubApplicationGroup', 
               'New-AzEventHubAuthorizationRule', 'New-AzEventHubCluster', 
               'New-AzEventHubConsumerGroup', 'New-AzEventHubGeoDRConfiguration', 
               'New-AzEventHubIPRuleConfig', 'New-AzEventHubKey', 
               'New-AzEventHubKeyVaultPropertiesObject', 
               'New-AzEventHubLocationsNameObject', 'New-AzEventHubNamespace', 
               'New-AzEventHubSchemaGroup', 'New-AzEventHubThrottlingPolicyConfig', 
               'New-AzEventHubVirtualNetworkRuleConfig', 'Remove-AzEventHub', 
               'Remove-AzEventHubApplicationGroup', 
               'Remove-AzEventHubAuthorizationRule', 'Remove-AzEventHubCluster', 
               'Remove-AzEventHubConsumerGroup', 
               'Remove-AzEventHubGeoDRConfiguration', 'Remove-AzEventHubNamespace', 
               'Remove-AzEventHubPrivateEndpointConnection', 
               'Remove-AzEventHubSchemaGroup', 'Set-AzEventHub', 
               'Set-AzEventHubApplicationGroup', 'Set-AzEventHubAuthorizationRule', 
               'Set-AzEventHubCluster', 'Set-AzEventHubConsumerGroup', 
               'Set-AzEventHubGeoDRConfigurationBreakPair', 
               'Set-AzEventHubGeoDRConfigurationFailOver', 
               'Set-AzEventHubNamespace', 'Set-AzEventHubNetworkRuleSet', 
               'Start-AzEventHubNamespaceFailOver', 'Test-AzEventHubName'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'New-AzEventHubAuthorizationRuleSASToken'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Get-AzEventHubNamespaceV2', 'New-AzEventHubNamespaceV2', 
               'Remove-AzEventHubNamespaceV2', 'Set-AzEventHubNamespaceV2'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        Tags = 'Azure','ResourceManager','ARM','EventHub'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Added parameters ''MaxReplicationLagDurationInSeconds'' and ''Replicalocation'' in cmdlets ''New-AzEventHubNamespace'' & ''Set-AzEventHubNamespace''
* Added new cmdlets for doing namespace failover - ''Start-AzEventHubNamespaceFailOver''
* Added new cmdlets for generating replication object for Replication parameter - ''New-AzEventHubLocationsNameObject'''

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

