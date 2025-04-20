# CNBOpenApi.Model.WebCodeSensitiveDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **string** | 问题创建时间 | [optional] 
**FileName** | **string** | 包含问题的文件名 | [optional] 
**FilePath** | **string** | 包含问题的文件路径 | [optional] 
**Handler** | [**GitWoaComCnbMonorepoGitInternalDtoWebUserInfo**](GitWoaComCnbMonorepoGitInternalDtoWebUserInfo.md) | 忽略人(平台信息) | [optional] 
**Id** | **string** | 问题id | [optional] 
**IgnoreReason** | **string** | 忽略原因 | [optional] 
**IgnoredAt** | **string** | 忽略时间 | [optional] 
**IssueDetail** | [**List&lt;WebCSDetail&gt;**](WebCSDetail.md) | 问题详情 | [optional] 
**IssueSubType** | **string** | 问题子类型 | [optional] 
**IssueType** | **string** | 问题类型 | [optional] 
**LineNo** | **List&lt;int&gt;** | 问题行号 | [optional] 
**OccurVersion** | **string** | 问题发生版本 | [optional] 
**Owner** | [**GitWoaComCnbMonorepoGitInternalDtoWebUserInfo**](GitWoaComCnbMonorepoGitInternalDtoWebUserInfo.md) | 问题责任人(平台信息) | [optional] 
**RawAuthor** | [**WebRawAuthor**](WebRawAuthor.md) | 问题责任人原生git信息 | [optional] 
**ReopenAt** | **string** | 重新开启时间 | [optional] 
**ReopenHandler** | [**GitWoaComCnbMonorepoGitInternalDtoWebUserInfo**](GitWoaComCnbMonorepoGitInternalDtoWebUserInfo.md) | 重新开启人 | [optional] 
**Revision** | **string** | 问题所在版本 | [optional] 
**RiskLevel** | **string** | 问题等级 | [optional] 
**State** | **string** | 问题状态 开启/忽略 | [optional] 
**Tool** | **string** | 扫描工具 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

