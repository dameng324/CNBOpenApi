# CNBOpenApi.Model.DtoGroupSettingReq

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmailVerification** | **string** | 组织限制指定邮箱认证才能加入 | [optional] 
**GroupProtection** | **int** | 组织保护开关，0 - 关闭，1 - 打开 | [optional] 
**HideMembers** | **int** | 是否对外隐藏组织成员，0 - 否, 1 - 是 | [optional] 
**HideSubGroups** | **int** | 是否对外隐藏子组织，0 - 否, 1 - 是 | [optional] 
**ShowPrivateRepoWatermark** | **int** | 是否对外显示私有仓库水印，0 - 否, 1 - 是 | [optional] 
**Values** | **string** | SettingValue 组织设置值，多个选项，用逗号拼接。可选值来自 SettingNamesArray 的值，e.g. disable_organization_readme,cloud_native_dev_only | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

