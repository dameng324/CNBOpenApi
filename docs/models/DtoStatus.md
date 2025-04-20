# CNBOpenApi.Model.DtoStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BudgetStatus** | **ConstantBudgetSts** | 预算单状态，0-没有预算单，1-正常，2-欠费被隔离，3-被销毁 | [optional] 
**Overruns** | **Dictionary&lt;string, bool&gt;** | 对应资源类型是否超限 | [optional] 
**UsedPercent** | **Dictionary&lt;string, int&gt;** | 对应资源类型目前的使用率，比如50就是50% | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

