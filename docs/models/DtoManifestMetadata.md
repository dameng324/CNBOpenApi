# CNBOpenApi.Model.DtoManifestMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Annotations** | **Dictionary&lt;string, string&gt;** | Annotations contains arbitrary metadata for the image manifest. | [optional] 
**ArtifactType** | **string** | ArtifactType specifies the IANA media type of artifact when the manifest is used for an artifact. | [optional] 
**Config** | [**V1Descriptor**](V1Descriptor.md) | Config references a configuration object for a container, by digest. The referenced configuration object is a JSON blob that the runtime uses to set up the container. | [optional] 
**Layers** | [**List&lt;V1Descriptor&gt;**](V1Descriptor.md) | Layers is an indexed list of layers referenced by the manifest. | [optional] 
**Manifests** | [**List&lt;V1Descriptor&gt;**](V1Descriptor.md) | Manifests references platform specific manifests. | [optional] 
**MediaType** | **string** | MediaType specifies the type of this document data structure e.g. &#x60;application/vnd.oci.image.manifest.v1+json&#x60; | [optional] 
**SchemaVersion** | **int** | SchemaVersion is the image manifest schema that this image follows | [optional] 
**Subject** | [**V1Descriptor**](V1Descriptor.md) | Subject is an optional link from the image manifest to another manifest forming an association between the image manifest and the other manifest. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

