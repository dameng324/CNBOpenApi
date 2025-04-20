# CNBOpenApi.Model.ChartMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Annotations** | **Dictionary&lt;string, string&gt;** | Annotations are additional mappings uninterpreted by Helm, made available for inspection by other applications. | [optional] 
**ApiVersion** | **string** | The API Version of this chart. Required. | [optional] 
**AppVersion** | **string** | The version of the application enclosed inside of this chart. | [optional] 
**Condition** | **string** | The condition to check to enable chart | [optional] 
**Dependencies** | [**List&lt;ChartDependency&gt;**](ChartDependency.md) | Dependencies are a list of dependencies for a chart. | [optional] 
**Deprecated** | **bool** | Whether or not this chart is deprecated | [optional] 
**Description** | **string** | A one-sentence description of the chart | [optional] 
**Home** | **string** | The URL to a relevant project page, git repo, or contact person | [optional] 
**Icon** | **string** | The URL to an icon file. | [optional] 
**Keywords** | **List&lt;string&gt;** | A list of string keywords | [optional] 
**KubeVersion** | **string** | KubeVersion is a SemVer constraint specifying the version of Kubernetes required. | [optional] 
**Maintainers** | [**List&lt;ChartMaintainer&gt;**](ChartMaintainer.md) | A list of name and URL/email address combinations for the maintainer(s) | [optional] 
**Name** | **string** | The name of the chart. Required. | [optional] 
**Sources** | **List&lt;string&gt;** | Source is the URL to the source code of this chart | [optional] 
**Tags** | **string** | The tags to check to enable chart | [optional] 
**Type** | **string** | Specifies the chart type: application or library | [optional] 
**VarVersion** | **string** | A SemVer 2 conformant version string of the chart. Required. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

