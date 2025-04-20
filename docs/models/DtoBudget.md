# CNBOpenApi.Model.DtoBudget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChargeTypeCi** | **int** | 单位：核时 | [optional] 
**ChargeTypeCiPolicy** | **decimal** |  | [optional] 
**ChargeTypeCiPrice** | **decimal** | ci价格，单位：分 | [optional] 
**ChargeTypeDev** | **int** |  | [optional] 
**ChargeTypeDevPolicy** | **decimal** |  | [optional] 
**ChargeTypeDevPrice** | **decimal** | 开发价格，单位：分 | [optional] 
**ChargeTypeGit** | **int** | 单位：Gib | [optional] 
**ChargeTypeGitPolicy** | **decimal** | 折扣，没折扣是100 | [optional] 
**ChargeTypeGitPrice** | **decimal** | git存储价格，单位：分 | [optional] 
**ChargeTypeObject** | **int** |  | [optional] 
**ChargeTypeObjectPolicy** | **decimal** |  | [optional] 
**ChargeTypeObjectPrice** | **decimal** | 对象存储价格，单位：分 | [optional] 
**Name** | **string** | 预算单名称 | [optional] 
**Status** | **ConstantBudgetSts** | 预算单状态，1-正常，2-隔离，3-销毁 | [optional] 
**Uin** | **string** | 云账号id | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

