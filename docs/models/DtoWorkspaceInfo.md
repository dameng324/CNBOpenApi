# CNBOpenApi.Model.DtoWorkspaceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Branch** | **string** | 分支名，例如：main | [optional] 
**CommitCount** | **int** | 备份的 commit 数 | [optional] 
**CreateTime** | **string** | 开发环境创建时间，例如：2024-12-02T03:20:22.000Z | [optional] 
**Duration** | **int** | 开发环境持续时间，单位：ms（非实时更新） | [optional] 
**FileCount** | **int** | 备份的文件数 | [optional] 
**FileList** | **string** | 备份的文件列表，仅前五个备份文件相对路径 | [optional] 
**LatestSha** | **string** | 环境销毁时远程最新的 commit short hash | [optional] 
**PipelineId** | **string** | 创建环境的子流水线 id | [optional] 
**RemoteStashCount** | **int** | 备份的 stash 数 | [optional] 
**RepoUrl** | **string** | 仓库地址 | [optional] 
**RestoreId** | **string** | 恢复备份代码的流水线 id，如果有值表示备份代码已被恢复（重建环境时会恢复备份代码） | [optional] 
**Slug** | **string** | 仓库路径，例如：groupname/reponame | [optional] 
**Sn** | **string** | 创建开发环境的流水线 sn | [optional] 
**Ssh** | **bool** | 开发环境是否支持 ssh 链接 | [optional] 
**Status** | **string** | 工作区状态，running: 开发环境已启动，closed：开发环境已关闭 | [optional] 
**Workspace** | **string** | 开发环境默认工作区路径 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

