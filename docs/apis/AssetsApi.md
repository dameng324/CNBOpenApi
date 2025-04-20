# CNBOpenApi.Api.AssetsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCommitAssets**](AssetsApi.md#getcommitassets) | **GET** /{repo}/-/commit-assets/download/{fileName} | 发起一个获取 commits 附件的请求，返回内容或者 302 到某个地址 |
| [**GetFiles**](AssetsApi.md#getfiles) | **GET** /{repo}/-/files/{userIdKey}/{randomUUID}/{fileName} | 发起一个获取 files 的请求，返回内容或者 302 到某个地址 |
| [**GetImgs**](AssetsApi.md#getimgs) | **GET** /{repo}/-/imgs/{userIdKey}/{fileName} | 发起一个获取 imgs 的请求，返回内容或者 302 到某个地址 |
| [**GetLatestReleasesAsset**](AssetsApi.md#getlatestreleasesasset) | **GET** /{repo}/-/releases/latest/download/{fileName} | 发起一个获取 latest release 附件的请求，返回内容或者 302 到某个地址 |
| [**GetLogos**](AssetsApi.md#getlogos) | **GET** /{group}/-/logos/{size} | 发起一个获取 logo 的请求，返回内容或者 302 到某个地址 |
| [**GetReleasesAsset**](AssetsApi.md#getreleasesasset) | **GET** /{repo}/-/releases/download/{fileName} | 发起一个获取 release 附件的请求，返回内容或者 302 到某个地址 |
| [**GetUserAvatar**](AssetsApi.md#getuseravatar) | **GET** /users/{username}/avatar/{size} | 获取指定用户的用户头像 |
| [**PutFiles**](AssetsApi.md#putfiles) | **PUT** /{repo}/-/files/{userIdKey}/{randomUUID}/{fileName} | 发起一个确认 files 的请求，上传的图片要调用此接口才能生效 |
| [**PutImgs**](AssetsApi.md#putimgs) | **PUT** /{repo}/-/imgs/{userIdKey}/{fileName} | 发起一个确认 imgs 的请求，上传的图片要调用此接口才能生效 |
| [**PutLogos**](AssetsApi.md#putlogos) | **PUT** /{group}/-/logos | 确认上传的logo |
| [**UploadFiles**](AssetsApi.md#uploadfiles) | **POST** /{repo}/-/upload/files | 发起一个上传 files（issue，pr 及其评论中文档，压缩包等）的请求，返回上传 cos 的 url 和 form 内容 |
| [**UploadImgs**](AssetsApi.md#uploadimgs) | **POST** /{repo}/-/upload/imgs | 发起一个上传 imgs 的请求，返回上传 cos 的 url 和 form 内容 |
| [**UploadLogos**](AssetsApi.md#uploadlogos) | **POST** /{group}/-/upload/logos | 发起一个上传 logo 的请求，返回上传 cos 的 url 和 form 内容 |
| [**UploadReleases**](AssetsApi.md#uploadreleases) | **POST** /{repo}/-/upload/releases/{tagName} | 发起一个上传 release 附件的请求，返回上传 cos 的 url 和 form 内容 |

<a id="getcommitassets"></a>
# **GetCommitAssets**
> void GetCommitAssets (string fileName, string repo)

发起一个获取 commits 附件的请求，返回内容或者 302 到某个地址

访问令牌调用此接口需包含以下权限  repo-contents:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetCommitAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var fileName = "fileName_example";  // string | 包含commitSha和文件名，例如 3bba1ce6a8c35ee1264c7449f4f0b512bd751eac/test.png
            var repo = "\"test-group/test-repo\"";  // string | Repo (default to "test-group/test-repo")

            try
            {
                // 发起一个获取 commits 附件的请求，返回内容或者 302 到某个地址
                apiInstance.GetCommitAssets(fileName, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetCommitAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommitAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个获取 commits 附件的请求，返回内容或者 302 到某个地址
    apiInstance.GetCommitAssetsWithHttpInfo(fileName, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetCommitAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileName** | **string** | 包含commitSha和文件名，例如 3bba1ce6a8c35ee1264c7449f4f0b512bd751eac/test.png |  |
| **repo** | **string** | Repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getfiles"></a>
# **GetFiles**
> void GetFiles (string userIdKey, string randomUUID, string fileName, string repo)

发起一个获取 files 的请求，返回内容或者 302 到某个地址

访问令牌调用此接口需包含以下权限  repo-contents:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var userIdKey = "userIdKey_example";  // string | user_id_key
            var randomUUID = "randomUUID_example";  // string | random_uuid
            var fileName = "fileName_example";  // string | file_name
            var repo = "\"test-group/test-repo\"";  // string | repo (default to "test-group/test-repo")

            try
            {
                // 发起一个获取 files 的请求，返回内容或者 302 到某个地址
                apiInstance.GetFiles(userIdKey, randomUUID, fileName, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个获取 files 的请求，返回内容或者 302 到某个地址
    apiInstance.GetFilesWithHttpInfo(userIdKey, randomUUID, fileName, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdKey** | **string** | user_id_key |  |
| **randomUUID** | **string** | random_uuid |  |
| **fileName** | **string** | file_name |  |
| **repo** | **string** | repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getimgs"></a>
# **GetImgs**
> void GetImgs (string userIdKey, string fileName, string repo)

发起一个获取 imgs 的请求，返回内容或者 302 到某个地址

访问令牌调用此接口需包含以下权限  repo-contents:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetImgsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var userIdKey = "userIdKey_example";  // string | user_id_key
            var fileName = "fileName_example";  // string | file_name
            var repo = "\"test-group/test-repo\"";  // string | repo (default to "test-group/test-repo")

            try
            {
                // 发起一个获取 imgs 的请求，返回内容或者 302 到某个地址
                apiInstance.GetImgs(userIdKey, fileName, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetImgs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImgsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个获取 imgs 的请求，返回内容或者 302 到某个地址
    apiInstance.GetImgsWithHttpInfo(userIdKey, fileName, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetImgsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdKey** | **string** | user_id_key |  |
| **fileName** | **string** | file_name |  |
| **repo** | **string** | repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getlatestreleasesasset"></a>
# **GetLatestReleasesAsset**
> void GetLatestReleasesAsset (string fileName, string repo)

发起一个获取 latest release 附件的请求，返回内容或者 302 到某个地址

访问令牌调用此接口需包含以下权限  repo-contents:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetLatestReleasesAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var fileName = "fileName_example";  // string | 文件名，例如 test.png
            var repo = "\"test-group/test-repo\"";  // string | Repo (default to "test-group/test-repo")

            try
            {
                // 发起一个获取 latest release 附件的请求，返回内容或者 302 到某个地址
                apiInstance.GetLatestReleasesAsset(fileName, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetLatestReleasesAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLatestReleasesAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个获取 latest release 附件的请求，返回内容或者 302 到某个地址
    apiInstance.GetLatestReleasesAssetWithHttpInfo(fileName, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetLatestReleasesAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileName** | **string** | 文件名，例如 test.png |  |
| **repo** | **string** | Repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getlogos"></a>
# **GetLogos**
> void GetLogos (string size, string group)

发起一个获取 logo 的请求，返回内容或者 302 到某个地址

访问令牌调用此接口需包含以下权限  group-resource:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetLogosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var size = "size_example";  // string | size
            var group = "\"test-group\"";  // string | group (default to "test-group")

            try
            {
                // 发起一个获取 logo 的请求，返回内容或者 302 到某个地址
                apiInstance.GetLogos(size, group);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetLogos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLogosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个获取 logo 的请求，返回内容或者 302 到某个地址
    apiInstance.GetLogosWithHttpInfo(size, group);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetLogosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **string** | size |  |
| **group** | **string** | group | [default to &quot;test-group&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getreleasesasset"></a>
# **GetReleasesAsset**
> void GetReleasesAsset (string fileName, string repo)

发起一个获取 release 附件的请求，返回内容或者 302 到某个地址

访问令牌调用此接口需包含以下权限  repo-contents:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetReleasesAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var fileName = "fileName_example";  // string | 包含tag名称和文件名，例如 v1.0/test.png
            var repo = "\"test-group/test-repo\"";  // string | Repo (default to "test-group/test-repo")

            try
            {
                // 发起一个获取 release 附件的请求，返回内容或者 302 到某个地址
                apiInstance.GetReleasesAsset(fileName, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetReleasesAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReleasesAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个获取 release 附件的请求，返回内容或者 302 到某个地址
    apiInstance.GetReleasesAssetWithHttpInfo(fileName, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetReleasesAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fileName** | **string** | 包含tag名称和文件名，例如 v1.0/test.png |  |
| **repo** | **string** | Repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getuseravatar"></a>
# **GetUserAvatar**
> void GetUserAvatar (string size, string username)

获取指定用户的用户头像

访问令牌调用此接口需包含以下权限  account-profile:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetUserAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AssetsApi(config);
            var size = "size_example";  // string | 头像大小，取 s 或者 l
            var username = "\"someone\"";  // string | User Name (default to "someone")

            try
            {
                // 获取指定用户的用户头像
                apiInstance.GetUserAvatar(size, username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.GetUserAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户的用户头像
    apiInstance.GetUserAvatarWithHttpInfo(size, username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.GetUserAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **size** | **string** | 头像大小，取 s 或者 l |  |
| **username** | **string** | User Name | [default to &quot;someone&quot;] |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putfiles"></a>
# **PutFiles**
> void PutFiles (string userIdKey, string randomUUID, string fileName, string token, string repo)

发起一个确认 files 的请求，上传的图片要调用此接口才能生效

访问令牌调用此接口需包含以下权限  repo-contents:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var userIdKey = "userIdKey_example";  // string | user_id_key
            var randomUUID = "randomUUID_example";  // string | random_uuid
            var fileName = "fileName_example";  // string | file_name
            var token = "token_example";  // string | 获取 uploadurl 时返回的token
            var repo = "\"test-group/test-repo\"";  // string | Repo (default to "test-group/test-repo")

            try
            {
                // 发起一个确认 files 的请求，上传的图片要调用此接口才能生效
                apiInstance.PutFiles(userIdKey, randomUUID, fileName, token, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.PutFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个确认 files 的请求，上传的图片要调用此接口才能生效
    apiInstance.PutFilesWithHttpInfo(userIdKey, randomUUID, fileName, token, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.PutFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdKey** | **string** | user_id_key |  |
| **randomUUID** | **string** | random_uuid |  |
| **fileName** | **string** | file_name |  |
| **token** | **string** | 获取 uploadurl 时返回的token |  |
| **repo** | **string** | Repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putimgs"></a>
# **PutImgs**
> void PutImgs (string userIdKey, string fileName, string token, string repo)

发起一个确认 imgs 的请求，上传的图片要调用此接口才能生效

访问令牌调用此接口需包含以下权限  repo-contents:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutImgsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var userIdKey = "userIdKey_example";  // string | user_id_key
            var fileName = "fileName_example";  // string | file_name
            var token = "token_example";  // string | 获取 uploadurl 时返回的token
            var repo = "\"test-group/test-repo\"";  // string | Repo (default to "test-group/test-repo")

            try
            {
                // 发起一个确认 imgs 的请求，上传的图片要调用此接口才能生效
                apiInstance.PutImgs(userIdKey, fileName, token, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.PutImgs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutImgsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个确认 imgs 的请求，上传的图片要调用此接口才能生效
    apiInstance.PutImgsWithHttpInfo(userIdKey, fileName, token, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.PutImgsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userIdKey** | **string** | user_id_key |  |
| **fileName** | **string** | file_name |  |
| **token** | **string** | 获取 uploadurl 时返回的token |  |
| **repo** | **string** | Repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putlogos"></a>
# **PutLogos**
> void PutLogos (string token, string group)

确认上传的logo

访问令牌调用此接口需包含以下权限  group-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutLogosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var token = "token_example";  // string | 获取 uploadurl 时返回的token
            var group = "\"test-group/test-repo\"";  // string | group (default to "test-group/test-repo")

            try
            {
                // 确认上传的logo
                apiInstance.PutLogos(token, group);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.PutLogos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutLogosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 确认上传的logo
    apiInstance.PutLogosWithHttpInfo(token, group);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.PutLogosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | **string** | 获取 uploadurl 时返回的token |  |
| **group** | **string** | group | [default to &quot;test-group/test-repo&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadfiles"></a>
# **UploadFiles**
> DtoUploadAssetsResponse UploadFiles (DtoUploadRequestParams request, string repo)

发起一个上传 files（issue，pr 及其评论中文档，压缩包等）的请求，返回上传 cos 的 url 和 form 内容

访问令牌调用此接口需包含以下权限  repo-contents:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class UploadFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var request = new DtoUploadRequestParams(); // DtoUploadRequestParams | UploadRequestParams
            var repo = "\"test-group/test-repo\"";  // string | repo (default to "test-group/test-repo")

            try
            {
                // 发起一个上传 files（issue，pr 及其评论中文档，压缩包等）的请求，返回上传 cos 的 url 和 form 内容
                DtoUploadAssetsResponse result = apiInstance.UploadFiles(request, repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UploadFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个上传 files（issue，pr 及其评论中文档，压缩包等）的请求，返回上传 cos 的 url 和 form 内容
    ApiResponse<DtoUploadAssetsResponse> response = apiInstance.UploadFilesWithHttpInfo(request, repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.UploadFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**DtoUploadRequestParams**](DtoUploadRequestParams.md) | UploadRequestParams |  |
| **repo** | **string** | repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

[**DtoUploadAssetsResponse**](DtoUploadAssetsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadimgs"></a>
# **UploadImgs**
> DtoUploadAssetsResponse UploadImgs (DtoUploadRequestParams request, string repo)

发起一个上传 imgs 的请求，返回上传 cos 的 url 和 form 内容

访问令牌调用此接口需包含以下权限  repo-contents:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class UploadImgsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var request = new DtoUploadRequestParams(); // DtoUploadRequestParams | UploadRequestParams
            var repo = "\"test-group/test-repo\"";  // string | repo (default to "test-group/test-repo")

            try
            {
                // 发起一个上传 imgs 的请求，返回上传 cos 的 url 和 form 内容
                DtoUploadAssetsResponse result = apiInstance.UploadImgs(request, repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UploadImgs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadImgsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个上传 imgs 的请求，返回上传 cos 的 url 和 form 内容
    ApiResponse<DtoUploadAssetsResponse> response = apiInstance.UploadImgsWithHttpInfo(request, repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.UploadImgsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**DtoUploadRequestParams**](DtoUploadRequestParams.md) | UploadRequestParams |  |
| **repo** | **string** | repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

[**DtoUploadAssetsResponse**](DtoUploadAssetsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadlogos"></a>
# **UploadLogos**
> DtoUploadAssetsResponse UploadLogos (DtoUploadRequestParams request, string group)

发起一个上传 logo 的请求，返回上传 cos 的 url 和 form 内容

访问令牌调用此接口需包含以下权限  group-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class UploadLogosExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var request = new DtoUploadRequestParams(); // DtoUploadRequestParams | UploadRequestParams
            var group = "\"test-group\"";  // string | group (default to "test-group")

            try
            {
                // 发起一个上传 logo 的请求，返回上传 cos 的 url 和 form 内容
                DtoUploadAssetsResponse result = apiInstance.UploadLogos(request, group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UploadLogos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadLogosWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个上传 logo 的请求，返回上传 cos 的 url 和 form 内容
    ApiResponse<DtoUploadAssetsResponse> response = apiInstance.UploadLogosWithHttpInfo(request, group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.UploadLogosWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**DtoUploadRequestParams**](DtoUploadRequestParams.md) | UploadRequestParams |  |
| **group** | **string** | group | [default to &quot;test-group&quot;] |

### Return type

[**DtoUploadAssetsResponse**](DtoUploadAssetsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="uploadreleases"></a>
# **UploadReleases**
> DtoUploadAssetsResponse UploadReleases (string tagName, DtoUploadRequestParams request, string repo)

发起一个上传 release 附件的请求，返回上传 cos 的 url 和 form 内容

访问令牌调用此接口需包含以下权限  repo-contents:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class UploadReleasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AssetsApi(config);
            var tagName = "tagName_example";  // string | tag_name
            var request = new DtoUploadRequestParams(); // DtoUploadRequestParams | UploadRequestParams
            var repo = "\"test-group/test-repo\"";  // string | repo (default to "test-group/test-repo")

            try
            {
                // 发起一个上传 release 附件的请求，返回上传 cos 的 url 和 form 内容
                DtoUploadAssetsResponse result = apiInstance.UploadReleases(tagName, request, repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetsApi.UploadReleases: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadReleasesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起一个上传 release 附件的请求，返回上传 cos 的 url 和 form 内容
    ApiResponse<DtoUploadAssetsResponse> response = apiInstance.UploadReleasesWithHttpInfo(tagName, request, repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetsApi.UploadReleasesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagName** | **string** | tag_name |  |
| **request** | [**DtoUploadRequestParams**](DtoUploadRequestParams.md) | UploadRequestParams |  |
| **repo** | **string** | repo | [default to &quot;test-group/test-repo&quot;] |

### Return type

[**DtoUploadAssetsResponse**](DtoUploadAssetsResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

