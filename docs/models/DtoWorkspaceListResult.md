# CNBOpenApi.Model.DtoWorkspaceListResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasMore** | **bool** | 开发环境状态，running: 开发环境已启动，closed：开发环境已关闭 | [optional] 
**List** | [**List&lt;DtoWorkspaceInfo&gt;**](DtoWorkspaceInfo.md) | 查询开始时间，格式：YYYY-MM-DD HH:mm:ssZZ，例如：2024-12-01 00:00:00+0800 | [optional] 
**PageInfo** | [**DtoWorkspacePageInfo**](DtoWorkspacePageInfo.md) | 查询结束时间，格式：YYYY-MM-DD HH:mm:ssZZ，例如：2024-12-01 00:00:00+0800 | [optional] 
**Total** | **int** | 分支名，例如：main | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

