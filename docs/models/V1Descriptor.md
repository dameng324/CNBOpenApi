# CNBOpenApi.Model.V1Descriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Annotations** | **Dictionary&lt;string, string&gt;** | Annotations contains arbitrary metadata relating to the targeted content. | [optional] 
**ArtifactType** | **string** | ArtifactType is the IANA media type of this artifact. | [optional] 
**Data** | **List&lt;int&gt;** | Data is an embedding of the targeted content. This is encoded as a base64 string when marshalled to JSON (automatically, by encoding/json). If present, Data can be used directly to avoid fetching the targeted content. | [optional] 
**Digest** | **string** | Digest is the digest of the targeted content. | [optional] 
**MediaType** | **string** | MediaType is the media type of the object this schema refers to. | [optional] 
**Platform** | [**V1Platform**](V1Platform.md) | Platform describes the platform which the image in the manifest runs on.  This should only be used when referring to a manifest. | [optional] 
**Size** | **int** | Size specifies the size in bytes of the blob. | [optional] 
**Urls** | **List&lt;string&gt;** | URLs specifies a list of URLs from which this object MAY be downloaded | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

