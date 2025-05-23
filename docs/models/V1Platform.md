# CNBOpenApi.Model.V1Platform

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Architecture** | **string** | Architecture field specifies the CPU architecture, for example &#x60;amd64&#x60; or &#x60;ppc64le&#x60;. | [optional] 
**Os** | **string** | OS specifies the operating system, for example &#x60;linux&#x60; or &#x60;windows&#x60;. | [optional] 
**OsFeatures** | **List&lt;string&gt;** | OSFeatures is an optional field specifying an array of strings, each listing a required OS feature (for example on Windows &#x60;win32k&#x60;). | [optional] 
**OsVersion** | **string** | OSVersion is an optional field specifying the operating system version, for example on Windows &#x60;10.0.14393.1066&#x60;. | [optional] 
**Variant** | **string** | Variant is an optional field specifying a variant of the CPU, for example &#x60;v7&#x60; to specify ARMv7 when architecture is &#x60;arm&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

