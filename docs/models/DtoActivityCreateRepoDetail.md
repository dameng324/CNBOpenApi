# CNBOpenApi.Model.DtoActivityCreateRepoDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreateAt** | **string** |  | [optional] 
**Detail** | [**DtoRepos4UserBase**](DtoRepos4UserBase.md) | 公仓转私仓或仓库被删除后为 null | [optional] 
**ExposedRepoPath** | **string** | activity 发生时仓库的 path，这时的 path 是可以公开的 | [optional] 
**Freeze** | **bool** | 仓库是否封禁 | [optional] 
**RepoUnaccessible** | **bool** | 仓库是否不可访问（公仓转私仓或仓库被删除后不可访问） | [optional] 
**VisibilityLevel** | **ConstantVisibility** | 仓库可见性 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

