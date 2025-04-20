# CNBOpenApi.Model.WebGPGPublicKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **string** |  | [optional] 
**Emails** | [**List&lt;WebGPGEmail&gt;**](WebGPGEmail.md) |  | [optional] 
**ExpiredAt** | **string** | 过期时间 | [optional] 
**Fingerprint** | **string** | 公钥指纹 | [optional] 
**Id** | **string** |  | [optional] 
**KeyCreationTime** | **string** | 密钥创建时间 | [optional] 
**KeyId** | **string** | 公钥 ID | [optional] 
**Name** | **string** | 标题 | [optional] 
**PublicKey** | **string** |  | [optional] 
**Subkeys** | [**List&lt;WebGPGSubkey&gt;**](WebGPGSubkey.md) | 子密钥指纹，当为 primary key 时与 primary_fingerprint 相同 | [optional] 
**UserId** | **string** |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

