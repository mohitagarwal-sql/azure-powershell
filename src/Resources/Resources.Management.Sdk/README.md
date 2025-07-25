# Overall
This directory contains management plane service clients of Az.Resources module.

## Run Generation
In this directory, run AutoRest:
```
rm -r Generated/*
autorest --reset
autorest --use:@autorest/powershell@4.x --tag=package-privatelinks-2020-05
autorest --use:@autorest/powershell@4.x --tag=package-subscriptions-2021-01
autorest --use:@autorest/powershell@4.x --tag=package-features-2021-07
autorest --use:@autorest/powershell@4.x --tag=package-deploymentscripts-2020-10
autorest --use:@autorest/powershell@4.x --tag=package-resources-2024-11
autorest --use:@autorest/powershell@4.x --tag=package-deploymentstacks-2024-03
autorest --use:@autorest/powershell@4.x --tag=package-templatespecs-2021-05
```

### AutoRest Configuration
> see https://aka.ms/autorest
``` yaml
output-folder: Generated
namespace: Microsoft.Azure.Management.Resources
isSdkGenerator: true
powershell: true
clear-output-folder: false
reflect-api-versions: true
azure-arm: true
license-header: MICROSOFT_MIT_NO_VERSION
```

## Configuration

```yaml
commit: 5e5d8196f6ba69545a9c4882ab4769d108b513c9
```

### Tag: package-deploymentscripts-2023-08

These settings apply only when `--tag=package-deploymentscripts-2020-10` is specified on the command line.

```yaml $(tag) == 'package-deploymentscripts-2020-10'
input-file:
- https://github.com/Azure/azure-rest-api-specs/blob/$(commit)/specification/resources/resource-manager/Microsoft.Resources/stable/2020-10-01/deploymentScripts.json

suppressions:
  - code: OperationsAPIImplementation
    reason: OperationsAPI will come from Resources
```

### Tag: package-resources-2024-11

These settings apply only when `--tag=package-resources-2024-11` is specified on the command line.

``` yaml $(tag) == 'package-resources-2024-11'
input-file:
  - https://github.com/Azure/azure-rest-api-specs/tree/$(commit)/specification/resources/resource-manager/Microsoft.Resources/stable/2024-11-01/resources.json

directive:
  - from: resources.json
    where: $.definitions
    transform: >
      $.ResourceGroupFilterWithExpand = {
        "allOf": [
          { "$ref": "#/definitions/ResourceGroupFilter" }
        ],
        "properties": {
          "$expand": {
            "type": "string",
            "description": "Comma-separated list of additional properties to be included in the response. Valid values include createdTime, changedTime."
          }
        }
      };

  - from: resources.json
    where: $.paths["/subscriptions/{subscriptionId}/resourcegroups"].get
    transform: >
      $["x-ms-odata"] = "#/definitions/ResourceGroupFilterWithExpand";

  - from: resources.json
    where: $.paths["/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}"].get.parameters
    transform: >
      $.push({
        "name": "$expand",
        "in": "query",
        "required": false,
        "type": "string",
        "description": "Comma-separated list of additional properties to be included in the response. Valid values include createdTime, changedTime."
      });

  - from: resources.json
    where: $.definitions.ResourceGroup.properties
    transform: >
      $.createdTime = {
        "readOnly": true,
        "type": "string",
        "format": "date-time",
        "description": "The created time of the resource group. This is only present if requested via the $expand query parameter."
      };

  - from: resources.json
    where: $.definitions.ResourceGroup.properties
    transform: >
      $.changedTime = {
        "readOnly": true,
        "type": "string", 
        "format": "date-time",
        "description": "The changed time of the resource group. This is only present if requested via the $expand query parameter."
      };
```

### Tag: package-privatelinks-2020-05

These settings apply only when `--tag=package-privatelinks-2020-05` is specified on the command line.

``` yaml $(tag) == 'package-privatelinks-2020-05'
input-file:
- https://github.com/Azure/azure-rest-api-specs/tree/$(commit)/specification/resources/resource-manager/Microsoft.Authorization/stable/2020-05-01/privateLinks.json
```

### Tag: package-subscriptions-2021-01

These settings apply only when `--tag=package-subscriptions-2021-01` is specified on the command line.

``` yaml $(tag) == 'package-subscriptions-2021-01'
input-file:
- https://github.com/Azure/azure-rest-api-specs/blob/$(commit)/specification/resources/resource-manager/Microsoft.Resources/stable/2021-01-01/subscriptions.json
```

### Tag: package-features-2021-07

These settings apply only when `--tag=package-features-2021-07` is specified on the command line.

``` yaml $(tag) == 'package-features-2021-07'
input-file:
- https://github.com/Azure/azure-rest-api-specs/tree/$(commit)/specification/resources/resource-manager/Microsoft.Features/stable/2021-07-01/features.json
- https://github.com/Azure/azure-rest-api-specs/tree/$(commit)/specification/resources/resource-manager/Microsoft.Features/stable/2021-07-01/SubscriptionFeatureRegistration.json

# Needed when there is more than one input file
override-info:
  title: FeatureClient
```

### Tag: package-templatespecs-2021-05

These settings apply only when `--tag=package-templatespecs-2021-05` is specified on the command line.

``` yaml $(tag) == 'package-templatespecs-2021-05'
input-file:
- https://github.com/Azure/azure-rest-api-specs/tree/$(commit)/specification/resources/resource-manager/Microsoft.Resources/stable/2021-05-01/templateSpecs.json
```

### Tag: package-deploymentstacks-2024-03

These settings apply only when `--tag=package-deploymentstacks-2024-03` is specified on the command line.

``` yaml $(tag) == 'package-deploymentstacks-2024-03'
input-file:
- https://github.com/Azure/azure-rest-api-specs/tree/$(commit)/specification/resources/resource-manager/Microsoft.Resources/stable/2024-03-01/deploymentStacks.json

# Temporary override to make subscription id GUID a string.
directive:
  - from: deploymentStacks.json
    where: $
    transform: $ = $.replace(/common-types\/resource-management\/v5\/types.json#\/parameters\/SubscriptionIdParameter/g, 'common-types/resource-management/v3/types.json#/parameters/SubscriptionIdParameter');
```