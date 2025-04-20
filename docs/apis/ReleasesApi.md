# CNBOpenApi.Api.ReleasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteRelease**](ReleasesApi.md#deleterelease) | **DELETE** /{repo}/-/releases/{release_id} | [openapi] 删除指定的 release |
| [**DeleteReleaseAsset**](ReleasesApi.md#deletereleaseasset) | **DELETE** /{repo}/-/releases/{release_id}/assets/{asset_id} | [openapi] 删除指定的 release asset |
| [**GetLatestRelease**](ReleasesApi.md#getlatestrelease) | **GET** /{repo}/-/releases/latest | 查询 latest release |
| [**GetReleaseAsset**](ReleasesApi.md#getreleaseasset) | **GET** /{repo}/-/releases/{release_id}/assets/{asset_id} | [openapi] 查询指定的 release asset |
| [**GetReleaseByID**](ReleasesApi.md#getreleasebyid) | **GET** /{repo}/-/releases/{release_id} | [openapi] 根据 id 查询指定 release |
| [**GetReleaseByTag**](ReleasesApi.md#getreleasebytag) | **GET** /{repo}/-/releases/tags/{tag} | [openapi] 通过 tag 查询指定 release |
| [**ListReleases**](ReleasesApi.md#listreleases) | **GET** /{repo}/-/releases | [openapi] 查询 release 列表 |
| [**PatchRelease**](ReleasesApi.md#patchrelease) | **PATCH** /{repo}/-/releases/{release_id} | [openapi] 更新 release |
| [**PostRelease**](ReleasesApi.md#postrelease) | **POST** /{repo}/-/releases | [openapi] 新增一个 Release |
| [**PostReleaseAssetUploadConfirmation**](ReleasesApi.md#postreleaseassetuploadconfirmation) | **POST** /{repo}/-/releases/{release_id}/asset-upload-confirmation/{token}/{asset_path} | [openapi] 确认 Release asset 上传完成 |
| [**PostReleaseAssetUploadURL**](ReleasesApi.md#postreleaseassetuploadurl) | **POST** /{repo}/-/releases/{release_id}/asset-upload-url | [openapi] 新增一个 Release asset |

<a id="deleterelease"></a>
# **DeleteRelease**
> void DeleteRelease (string repo, int releaseId)

[openapi] 删除指定的 release

访问令牌调用此接口需包含以下权限  repo-code:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id

            try
            {
                // [openapi] 删除指定的 release
                apiInstance.DeleteRelease(repo, releaseId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.DeleteRelease: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReleaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 删除指定的 release
    apiInstance.DeleteReleaseWithHttpInfo(repo, releaseId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.DeleteReleaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletereleaseasset"></a>
# **DeleteReleaseAsset**
> void DeleteReleaseAsset (string repo, int releaseId, int assetId)

[openapi] 删除指定的 release asset

访问令牌调用此接口需包含以下权限  repo-code:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteReleaseAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id
            var assetId = 56;  // int | asset id

            try
            {
                // [openapi] 删除指定的 release asset
                apiInstance.DeleteReleaseAsset(repo, releaseId, assetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.DeleteReleaseAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteReleaseAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 删除指定的 release asset
    apiInstance.DeleteReleaseAssetWithHttpInfo(repo, releaseId, assetId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.DeleteReleaseAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |
| **assetId** | **int** | asset id |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getlatestrelease"></a>
# **GetLatestRelease**
> ApiRelease GetLatestRelease (string repo)

查询 latest release

访问令牌调用此接口需包含以下权限  repo-code:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetLatestReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo

            try
            {
                // 查询 latest release
                ApiRelease result = apiInstance.GetLatestRelease(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.GetLatestRelease: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLatestReleaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询 latest release
    ApiResponse<ApiRelease> response = apiInstance.GetLatestReleaseWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.GetLatestReleaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |

### Return type

[**ApiRelease**](ApiRelease.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreleaseasset"></a>
# **GetReleaseAsset**
> ApiReleaseAsset GetReleaseAsset (string repo, int releaseId, int assetId)

[openapi] 查询指定的 release asset

访问令牌调用此接口需包含以下权限  repo-code:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetReleaseAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id
            var assetId = 56;  // int | asset id

            try
            {
                // [openapi] 查询指定的 release asset
                ApiReleaseAsset result = apiInstance.GetReleaseAsset(repo, releaseId, assetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.GetReleaseAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReleaseAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 查询指定的 release asset
    ApiResponse<ApiReleaseAsset> response = apiInstance.GetReleaseAssetWithHttpInfo(repo, releaseId, assetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.GetReleaseAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |
| **assetId** | **int** | asset id |  |

### Return type

[**ApiReleaseAsset**](ApiReleaseAsset.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreleasebyid"></a>
# **GetReleaseByID**
> ApiRelease GetReleaseByID (string repo, int releaseId)

[openapi] 根据 id 查询指定 release

访问令牌调用此接口需包含以下权限  repo-code:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetReleaseByIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id

            try
            {
                // [openapi] 根据 id 查询指定 release
                ApiRelease result = apiInstance.GetReleaseByID(repo, releaseId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.GetReleaseByID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReleaseByIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 根据 id 查询指定 release
    ApiResponse<ApiRelease> response = apiInstance.GetReleaseByIDWithHttpInfo(repo, releaseId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.GetReleaseByIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |

### Return type

[**ApiRelease**](ApiRelease.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreleasebytag"></a>
# **GetReleaseByTag**
> ApiRelease GetReleaseByTag (string repo, string tag)

[openapi] 通过 tag 查询指定 release

访问令牌调用此接口需包含以下权限  repo-code:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetReleaseByTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var tag = "tag_example";  // string | tag name

            try
            {
                // [openapi] 通过 tag 查询指定 release
                ApiRelease result = apiInstance.GetReleaseByTag(repo, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.GetReleaseByTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReleaseByTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 通过 tag 查询指定 release
    ApiResponse<ApiRelease> response = apiInstance.GetReleaseByTagWithHttpInfo(repo, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.GetReleaseByTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **tag** | **string** | tag name |  |

### Return type

[**ApiRelease**](ApiRelease.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listreleases"></a>
# **ListReleases**
> List&lt;ApiRelease&gt; ListReleases (string repo, int page = null, int pageSize = null)

[openapi] 查询 release 列表

访问令牌调用此接口需包含以下权限  repo-code:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListReleasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // [openapi] 查询 release 列表
                List<ApiRelease> result = apiInstance.ListReleases(repo, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.ListReleases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListReleasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 查询 release 列表
    ApiResponse<List<ApiRelease>> response = apiInstance.ListReleasesWithHttpInfo(repo, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.ListReleasesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **page** | **int** | pagination page number | [optional] [default to 1] |
| **pageSize** | **int** | pagination page size | [optional] [default to 30] |

### Return type

[**List&lt;ApiRelease&gt;**](ApiRelease.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="patchrelease"></a>
# **PatchRelease**
> void PatchRelease (string repo, int releaseId, OpenapiPatchReleaseForm patchReleaseForm)

[openapi] 更新 release

访问令牌调用此接口需包含以下权限  repo-code:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PatchReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id
            var patchReleaseForm = new OpenapiPatchReleaseForm(); // OpenapiPatchReleaseForm | patch release form

            try
            {
                // [openapi] 更新 release
                apiInstance.PatchRelease(repo, releaseId, patchReleaseForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.PatchRelease: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchReleaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 更新 release
    apiInstance.PatchReleaseWithHttpInfo(repo, releaseId, patchReleaseForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.PatchReleaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |
| **patchReleaseForm** | [**OpenapiPatchReleaseForm**](OpenapiPatchReleaseForm.md) | patch release form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postrelease"></a>
# **PostRelease**
> ApiRelease PostRelease (string repo, OpenapiPostReleaseForm createReleaseForm)

[openapi] 新增一个 Release

访问令牌调用此接口需包含以下权限  repo-code:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostReleaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var createReleaseForm = new OpenapiPostReleaseForm(); // OpenapiPostReleaseForm | Post Release Form, attachment is optional

            try
            {
                // [openapi] 新增一个 Release
                ApiRelease result = apiInstance.PostRelease(repo, createReleaseForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.PostRelease: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostReleaseWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 新增一个 Release
    ApiResponse<ApiRelease> response = apiInstance.PostReleaseWithHttpInfo(repo, createReleaseForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.PostReleaseWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **createReleaseForm** | [**OpenapiPostReleaseForm**](OpenapiPostReleaseForm.md) | Post Release Form, attachment is optional |  |

### Return type

[**ApiRelease**](ApiRelease.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postreleaseassetuploadconfirmation"></a>
# **PostReleaseAssetUploadConfirmation**
> void PostReleaseAssetUploadConfirmation (string repo, int releaseId, string token, string assetPath)

[openapi] 确认 Release asset 上传完成

访问令牌调用此接口需包含以下权限  repo-code:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostReleaseAssetUploadConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id
            var token = "token_example";  // string | upload token
            var assetPath = "assetPath_example";  // string | release asset path

            try
            {
                // [openapi] 确认 Release asset 上传完成
                apiInstance.PostReleaseAssetUploadConfirmation(repo, releaseId, token, assetPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.PostReleaseAssetUploadConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostReleaseAssetUploadConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 确认 Release asset 上传完成
    apiInstance.PostReleaseAssetUploadConfirmationWithHttpInfo(repo, releaseId, token, assetPath);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.PostReleaseAssetUploadConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |
| **token** | **string** | upload token |  |
| **assetPath** | **string** | release asset path |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postreleaseassetuploadurl"></a>
# **PostReleaseAssetUploadURL**
> OpenapiReleaseAssetUploadURL PostReleaseAssetUploadURL (string repo, int releaseId, OpenapiPostReleaseAssetUploadURLForm createReleaseAssetUploadUrlForm)

[openapi] 新增一个 Release asset

访问令牌调用此接口需包含以下权限  repo-code:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostReleaseAssetUploadURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ReleasesApi(config);
            var repo = "repo_example";  // string | repo
            var releaseId = 56;  // int | release id
            var createReleaseAssetUploadUrlForm = new OpenapiPostReleaseAssetUploadURLForm(); // OpenapiPostReleaseAssetUploadURLForm | Post Release Asset Upload URL Form

            try
            {
                // [openapi] 新增一个 Release asset
                OpenapiReleaseAssetUploadURL result = apiInstance.PostReleaseAssetUploadURL(repo, releaseId, createReleaseAssetUploadUrlForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReleasesApi.PostReleaseAssetUploadURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostReleaseAssetUploadURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 新增一个 Release asset
    ApiResponse<OpenapiReleaseAssetUploadURL> response = apiInstance.PostReleaseAssetUploadURLWithHttpInfo(repo, releaseId, createReleaseAssetUploadUrlForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReleasesApi.PostReleaseAssetUploadURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **releaseId** | **int** | release id |  |
| **createReleaseAssetUploadUrlForm** | [**OpenapiPostReleaseAssetUploadURLForm**](OpenapiPostReleaseAssetUploadURLForm.md) | Post Release Asset Upload URL Form |  |

### Return type

[**OpenapiReleaseAssetUploadURL**](OpenapiReleaseAssetUploadURL.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

