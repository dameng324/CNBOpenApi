# CNBOpenApi.Model.DtoOrganizationSettingWithParent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanShowMembers** | **bool** | 上级group设置了hide_members为1，则下级都不能显示 | [optional] 
**CanShowSubGroups** | **bool** | 上级group设置了hide_sub_groups为1，则下级都不能显示 | [optional] 
**CanShowWatermark** | **bool** |  | [optional] 
**EmailVerification** | **string** |  | [optional] 
**GroupProtection** | **int** |  | [optional] 
**HideMembers** | **int** | 是否对外隐藏组织成员，0 - 否, 1 - 是 | [optional] 
**HideSubGroups** | **int** | 是否对外隐藏子组织，0 - 否, 1 - 是 | [optional] 
**RootEmailVerification** | **string** |  | [optional] 
**RootGroupProtection** | **bool** |  | [optional] 
**RootValues** | **OrganizationSettingValue** |  | [optional] 
**ShowPrivateRepoWatermark** | **int** |  | [optional] 
**Values** | **OrganizationSettingValue** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

