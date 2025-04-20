# CNBOpenApi.Model.DtoStartBuildReq

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Branch** | **string** | 触发分支，默认为主分支 | [optional] 
**Config** | **string** | 指定配置文件内容，yaml 格式 | [optional] 
**Env** | **Dictionary&lt;string, string&gt;** | 环境变量，对象格式 | [optional] 
**Event** | **string** | 事件名，必须是 api_trigger 或以 api_trigger_ 开头，默认为 &#x60;api_trigger&#x60; | [optional] 
**Sha** | **string** | commit id ，优先级比 tag 高，默认为分支最新提交记录 | [optional] 
**Sync** | **string** | 是否等待构建正式触发，为false时会立刻返回 sn 和 buildLogUrl | [optional] 
**Tag** | **string** | 触发 tag，优先级比 branch 高 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

