# CNBOpenApi.Model.ChartDependency

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alias** | **string** | Alias usable alias to be used for the chart | [optional] 
**Condition** | **string** | A yaml path that resolves to a boolean, used for enabling/disabling charts (e.g. subchart1.enabled ) | [optional] 
**Enabled** | **bool** | Enabled bool determines if chart should be loaded | [optional] 
**ImportValues** | **List&lt;Object&gt;** | ImportValues holds the mapping of source values to parent key to be imported. Each item can be a string or pair of child/parent sublist items. | [optional] 
**Name** | **string** | Name is the name of the dependency.  This must mach the name in the dependency&#39;s Chart.yaml. | [optional] 
**Repository** | **string** | The URL to the repository.  Appending &#x60;index.yaml&#x60; to this string should result in a URL that can be used to fetch the repository index. | [optional] 
**Tags** | **List&lt;string&gt;** | Tags can be used to group charts for enabling/disabling together | [optional] 
**VarVersion** | **string** | Version is the version (range) of this chart.  A lock file will always produce a single version, while a dependency may contain a semantic version range. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

