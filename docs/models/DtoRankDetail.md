# CNBOpenApi.Model.DtoRankDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**DisplayModule** | **ConstantRepoDisplayModule** |  | [optional] 
**ForkCount** | **int** |  | [optional] 
**ForkedFromRepo** | [**DtoSlugs**](DtoSlugs.md) | 预留 | [optional] 
**Freeze** | **bool** |  | [optional] [readonly] 
**Id** | **int** |  | [optional] 
**Language** | **string** | 仓库程序语言，预留 | [optional] 
**Languages** | [**List&lt;DtoRepoLanguage&gt;**](DtoRepoLanguage.md) | 仓库语言 | [optional] 
**LastUpdateNickname** | **string** | 最新代码更新人姓名 | [optional] 
**LastUpdateUsername** | **string** | 最新代码更新人账户名 | [optional] 
**LastUpdatedAt** | [**ConvertNullTime**](ConvertNullTime.md) | 最新代码更新时间 | [optional] 
**License** | **string** |  | [optional] 
**MarkCount** | **int** |  | [optional] 
**Name** | **string** |  | [optional] 
**OpenIssueCount** | **int** | 开启的issue数 | [optional] 
**OpenPullRequestCount** | **int** | 开启的pull request数 | [optional] 
**Path** | **string** | 完整仓库路径 | [optional] 
**RankValue** | **int** |  | [optional] 
**Site** | **string** |  | [optional] 
**StarCount** | **int** |  | [optional] 
**Status** | **ConstantRepoStatus** |  | [optional] 
**Tags** | [**List&lt;DtoRankDetailTagsInner&gt;**](DtoRankDetailTagsInner.md) |  | [optional] 
**Topics** | **string** |  | [optional] 
**UpdatedAt** | **string** |  | [optional] 
**VisibilityLevel** | **ConstantVisibility** |  | [optional] 
**WebUrl** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

