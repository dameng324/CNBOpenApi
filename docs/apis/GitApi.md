# CNBOpenApi.Api.GitApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateBlob**](GitApi.md#createblob) | **POST** /{repo}/-/git/blobs | 创建一个 blob |
| [**CreateBranch**](GitApi.md#createbranch) | **POST** /{repo}/-/git/branches | 创建新分支 |
| [**CreateTag**](GitApi.md#createtag) | **POST** /{repo}/-/git/tags | 创建一个 tag |
| [**DeleteBranch**](GitApi.md#deletebranch) | **DELETE** /{repo}/-/git/branches/{branch} | 删除指定分支 |
| [**DeleteCommitAnnotation**](GitApi.md#deletecommitannotation) | **DELETE** /{repo}/-/git/commit-annotations/{sha}/{key} | 删除指定 commit 的元数据 |
| [**DeleteCommitAsset**](GitApi.md#deletecommitasset) | **DELETE** /{repo}/-/git/commit-assets/{sha1}/{asset_id} | 删除指定 commit 的附件 |
| [**DeleteTag**](GitApi.md#deletetag) | **DELETE** /{repo}/-/git/tags/{tag} | 删除指定标签 |
| [**DeleteTagAnnotation**](GitApi.md#deletetagannotation) | **DELETE** /{repo}/-/git/tag-annotations/{tag_with_key} | 删除指定 tag 的元数据 |
| [**GetArchiveCommitChangedFiles**](GitApi.md#getarchivecommitchangedfiles) | **GET** /{repo}/-/git/archive-commit-changed-files/{sha1} | 打包下载 commit 变更文件 |
| [**GetArchiveCompareChangedFiles**](GitApi.md#getarchivecomparechangedfiles) | **GET** /{repo}/-/git/archive-compare-changed-files/{base_head} | 打包下载两次 ref 之间的变更文件 |
| [**GetBranch**](GitApi.md#getbranch) | **GET** /{repo}/-/git/branches/{branch} | 查询指定分支 |
| [**GetCommit**](GitApi.md#getcommit) | **GET** /{repo}/-/git/commits/{ref} | 查询指定 commit |
| [**GetCommitAnnotations**](GitApi.md#getcommitannotations) | **GET** /{repo}/-/git/commit-annotations/{sha} | 查询指定 commit 的元数据 |
| [**GetCommitAnnotationsInBatch**](GitApi.md#getcommitannotationsinbatch) | **POST** /{repo}/-/git/commit-annotations-in-batch | 查询指定 commit 的元数据 |
| [**GetCommitAssetsBySha**](GitApi.md#getcommitassetsbysha) | **GET** /{repo}/-/git/commit-assets/{sha1} | 查询指定 commit 的附件 |
| [**GetCommitStatuses**](GitApi.md#getcommitstatuses) | **GET** /{repo}/-/git/commit-statuses/{commitish} | 查询指定 commit 的 check statuses |
| [**GetCompareCommits**](GitApi.md#getcomparecommits) | **GET** /{repo}/-/git/compare/{base_head} | 对比 base...head |
| [**GetContent**](GitApi.md#getcontent) | **GET** /{repo}/-/git/contents/{file_path} | 查询仓库文件列表或文件 |
| [**GetHead**](GitApi.md#gethead) | **GET** /{repo}/-/git/head | 获取仓库默认分支 |
| [**GetTag**](GitApi.md#gettag) | **GET** /{repo}/-/git/tags/{tag} | 查询指定 Tag |
| [**GetTagAnnotations**](GitApi.md#gettagannotations) | **GET** /{repo}/-/git/tag-annotations/{tag} | 查询指定 tag 的元数据 |
| [**ListBranches**](GitApi.md#listbranches) | **GET** /{repo}/-/git/branches | 查询分支列表 |
| [**ListCommits**](GitApi.md#listcommits) | **GET** /{repo}/-/git/commits | 查询 commit 列表 |
| [**ListTags**](GitApi.md#listtags) | **GET** /{repo}/-/git/tags | 查询标签列表 |
| [**PostCommitAssetUploadConfirmation**](GitApi.md#postcommitassetuploadconfirmation) | **POST** /{repo}/-/git/commit-assets/{sha1}/asset-upload-confirmation/{token}/{asset_path} | 确认 Commit asset 上传完成 |
| [**PostCommitAssetUploadURL**](GitApi.md#postcommitassetuploadurl) | **POST** /{repo}/-/git/commit-assets/{sha1}/asset-upload-url | 新增一个 Commit asset |
| [**PutCommitAnnotations**](GitApi.md#putcommitannotations) | **PUT** /{repo}/-/git/commit-annotations/{sha} | 设定指定 commit 的元数据 |
| [**PutTagAnnotations**](GitApi.md#puttagannotations) | **PUT** /{repo}/-/git/tag-annotations/{tag} | 设定指定 tag 的元数据 |

<a id="createblob"></a>
# **CreateBlob**
> ApiBlob CreateBlob (string repo, ApiPostBlobForm postBlobForm)

创建一个 blob

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
    public class CreateBlobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var postBlobForm = new ApiPostBlobForm(); // ApiPostBlobForm | PostBlobForm

            try
            {
                // 创建一个 blob
                ApiBlob result = apiInstance.CreateBlob(repo, postBlobForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.CreateBlob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBlobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建一个 blob
    ApiResponse<ApiBlob> response = apiInstance.CreateBlobWithHttpInfo(repo, postBlobForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.CreateBlobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **postBlobForm** | [**ApiPostBlobForm**](ApiPostBlobForm.md) | PostBlobForm |  |

### Return type

[**ApiBlob**](ApiBlob.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createbranch"></a>
# **CreateBranch**
> void CreateBranch (string repo, OpenapiCreateBranchForm createBranchForm)

创建新分支

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
    public class CreateBranchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var createBranchForm = new OpenapiCreateBranchForm(); // OpenapiCreateBranchForm | Create BranchDetail Form

            try
            {
                // 创建新分支
                apiInstance.CreateBranch(repo, createBranchForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.CreateBranch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBranchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建新分支
    apiInstance.CreateBranchWithHttpInfo(repo, createBranchForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.CreateBranchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **createBranchForm** | [**OpenapiCreateBranchForm**](OpenapiCreateBranchForm.md) | Create BranchDetail Form |  |

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
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createtag"></a>
# **CreateTag**
> ApiTag CreateTag (string repo, ApiPostTagFrom postTagForm)

创建一个 tag

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
    public class CreateTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var postTagForm = new ApiPostTagFrom(); // ApiPostTagFrom | PostTagFrom

            try
            {
                // 创建一个 tag
                ApiTag result = apiInstance.CreateTag(repo, postTagForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.CreateTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建一个 tag
    ApiResponse<ApiTag> response = apiInstance.CreateTagWithHttpInfo(repo, postTagForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.CreateTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **postTagForm** | [**ApiPostTagFrom**](ApiPostTagFrom.md) | PostTagFrom |  |

### Return type

[**ApiTag**](ApiTag.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletebranch"></a>
# **DeleteBranch**
> void DeleteBranch (string repo, string branch)

删除指定分支

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
    public class DeleteBranchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var branch = "branch_example";  // string | branch name

            try
            {
                // 删除指定分支
                apiInstance.DeleteBranch(repo, branch);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.DeleteBranch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBranchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定分支
    apiInstance.DeleteBranchWithHttpInfo(repo, branch);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.DeleteBranchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **branch** | **string** | branch name |  |

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

<a id="deletecommitannotation"></a>
# **DeleteCommitAnnotation**
> void DeleteCommitAnnotation (string repo, string sha, string key)

删除指定 commit 的元数据

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
    public class DeleteCommitAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha = "sha_example";  // string | commit hash
            var key = "key_example";  // string | commit annotation key

            try
            {
                // 删除指定 commit 的元数据
                apiInstance.DeleteCommitAnnotation(repo, sha, key);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.DeleteCommitAnnotation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCommitAnnotationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定 commit 的元数据
    apiInstance.DeleteCommitAnnotationWithHttpInfo(repo, sha, key);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.DeleteCommitAnnotationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha** | **string** | commit hash |  |
| **key** | **string** | commit annotation key |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletecommitasset"></a>
# **DeleteCommitAsset**
> void DeleteCommitAsset (string repo, string sha1, int assetId)

删除指定 commit 的附件

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
    public class DeleteCommitAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha1 = "sha1_example";  // string | sha
            var assetId = 56;  // int | asset id

            try
            {
                // 删除指定 commit 的附件
                apiInstance.DeleteCommitAsset(repo, sha1, assetId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.DeleteCommitAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCommitAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定 commit 的附件
    apiInstance.DeleteCommitAssetWithHttpInfo(repo, sha1, assetId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.DeleteCommitAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha1** | **string** | sha |  |
| **assetId** | **int** | asset id |  |

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
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetag"></a>
# **DeleteTag**
> void DeleteTag (string repo, string tag)

删除指定标签

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
    public class DeleteTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var tag = "tag_example";  // string | tag name

            try
            {
                // 删除指定标签
                apiInstance.DeleteTag(repo, tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.DeleteTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定标签
    apiInstance.DeleteTagWithHttpInfo(repo, tag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.DeleteTagWithHttpInfo: " + e.Message);
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

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletetagannotation"></a>
# **DeleteTagAnnotation**
> void DeleteTagAnnotation (string repo, string tagWithKey)

删除指定 tag 的元数据

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
    public class DeleteTagAnnotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var tagWithKey = "tagWithKey_example";  // string | tag with key

            try
            {
                // 删除指定 tag 的元数据
                apiInstance.DeleteTagAnnotation(repo, tagWithKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.DeleteTagAnnotation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTagAnnotationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定 tag 的元数据
    apiInstance.DeleteTagAnnotationWithHttpInfo(repo, tagWithKey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.DeleteTagAnnotationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **tagWithKey** | **string** | tag with key |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getarchivecommitchangedfiles"></a>
# **GetArchiveCommitChangedFiles**
> void GetArchiveCommitChangedFiles (string repo, string sha1)

打包下载 commit 变更文件

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
    public class GetArchiveCommitChangedFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha1 = "sha1_example";  // string | commit sha

            try
            {
                // 打包下载 commit 变更文件
                apiInstance.GetArchiveCommitChangedFiles(repo, sha1);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetArchiveCommitChangedFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetArchiveCommitChangedFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 打包下载 commit 变更文件
    apiInstance.GetArchiveCommitChangedFilesWithHttpInfo(repo, sha1);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetArchiveCommitChangedFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha1** | **string** | commit sha |  |

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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getarchivecomparechangedfiles"></a>
# **GetArchiveCompareChangedFiles**
> void GetArchiveCompareChangedFiles (string repo, string baseHead)

打包下载两次 ref 之间的变更文件

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
    public class GetArchiveCompareChangedFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var baseHead = "baseHead_example";  // string | base...head

            try
            {
                // 打包下载两次 ref 之间的变更文件
                apiInstance.GetArchiveCompareChangedFiles(repo, baseHead);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetArchiveCompareChangedFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetArchiveCompareChangedFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 打包下载两次 ref 之间的变更文件
    apiInstance.GetArchiveCompareChangedFilesWithHttpInfo(repo, baseHead);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetArchiveCompareChangedFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **baseHead** | **string** | base...head |  |

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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getbranch"></a>
# **GetBranch**
> ApiBranchDetail GetBranch (string repo, string branch)

查询指定分支

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
    public class GetBranchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var branch = "branch_example";  // string | branch name

            try
            {
                // 查询指定分支
                ApiBranchDetail result = apiInstance.GetBranch(repo, branch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetBranch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBranchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定分支
    ApiResponse<ApiBranchDetail> response = apiInstance.GetBranchWithHttpInfo(repo, branch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetBranchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **branch** | **string** | branch name |  |

### Return type

[**ApiBranchDetail**](ApiBranchDetail.md)

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

<a id="getcommit"></a>
# **GetCommit**
> ApiCommit GetCommit (string repo, string varRef)

查询指定 commit

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
    public class GetCommitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var varRef = "varRef_example";  // string | ref

            try
            {
                // 查询指定 commit
                ApiCommit result = apiInstance.GetCommit(repo, varRef);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetCommit: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommitWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 commit
    ApiResponse<ApiCommit> response = apiInstance.GetCommitWithHttpInfo(repo, varRef);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetCommitWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **varRef** | **string** | ref |  |

### Return type

[**ApiCommit**](ApiCommit.md)

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

<a id="getcommitannotations"></a>
# **GetCommitAnnotations**
> List&lt;WebCommitAnnotation&gt; GetCommitAnnotations (string repo, string sha)

查询指定 commit 的元数据

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
    public class GetCommitAnnotationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha = "sha_example";  // string | commit hash

            try
            {
                // 查询指定 commit 的元数据
                List<WebCommitAnnotation> result = apiInstance.GetCommitAnnotations(repo, sha);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetCommitAnnotations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommitAnnotationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 commit 的元数据
    ApiResponse<List<WebCommitAnnotation>> response = apiInstance.GetCommitAnnotationsWithHttpInfo(repo, sha);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetCommitAnnotationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha** | **string** | commit hash |  |

### Return type

[**List&lt;WebCommitAnnotation&gt;**](WebCommitAnnotation.md)

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

<a id="getcommitannotationsinbatch"></a>
# **GetCommitAnnotationsInBatch**
> List&lt;WebCommitAnnotationInBatch&gt; GetCommitAnnotationsInBatch (string repo, WebGetCommitAnnotationsInBatchForm getCommitAnnotationsForm)

查询指定 commit 的元数据

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
    public class GetCommitAnnotationsInBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var getCommitAnnotationsForm = new WebGetCommitAnnotationsInBatchForm(); // WebGetCommitAnnotationsInBatchForm | Get Commit Annotations In Batch Form

            try
            {
                // 查询指定 commit 的元数据
                List<WebCommitAnnotationInBatch> result = apiInstance.GetCommitAnnotationsInBatch(repo, getCommitAnnotationsForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetCommitAnnotationsInBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommitAnnotationsInBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 commit 的元数据
    ApiResponse<List<WebCommitAnnotationInBatch>> response = apiInstance.GetCommitAnnotationsInBatchWithHttpInfo(repo, getCommitAnnotationsForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetCommitAnnotationsInBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **getCommitAnnotationsForm** | [**WebGetCommitAnnotationsInBatchForm**](WebGetCommitAnnotationsInBatchForm.md) | Get Commit Annotations In Batch Form |  |

### Return type

[**List&lt;WebCommitAnnotationInBatch&gt;**](WebCommitAnnotationInBatch.md)

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

<a id="getcommitassetsbysha"></a>
# **GetCommitAssetsBySha**
> List&lt;ApiCommitAsset&gt; GetCommitAssetsBySha (string repo, string sha1)

查询指定 commit 的附件

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
    public class GetCommitAssetsByShaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha1 = "sha1_example";  // string | sha

            try
            {
                // 查询指定 commit 的附件
                List<ApiCommitAsset> result = apiInstance.GetCommitAssetsBySha(repo, sha1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetCommitAssetsBySha: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommitAssetsByShaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 commit 的附件
    ApiResponse<List<ApiCommitAsset>> response = apiInstance.GetCommitAssetsByShaWithHttpInfo(repo, sha1);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetCommitAssetsByShaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha1** | **string** | sha |  |

### Return type

[**List&lt;ApiCommitAsset&gt;**](ApiCommitAsset.md)

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

<a id="getcommitstatuses"></a>
# **GetCommitStatuses**
> List&lt;ApiCommitStatus&gt; GetCommitStatuses (string repo, string commitish)

查询指定 commit 的 check statuses

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
    public class GetCommitStatusesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var commitish = "commitish_example";  // string | commitish

            try
            {
                // 查询指定 commit 的 check statuses
                List<ApiCommitStatus> result = apiInstance.GetCommitStatuses(repo, commitish);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetCommitStatuses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCommitStatusesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 commit 的 check statuses
    ApiResponse<List<ApiCommitStatus>> response = apiInstance.GetCommitStatusesWithHttpInfo(repo, commitish);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetCommitStatusesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **commitish** | **string** | commitish |  |

### Return type

[**List&lt;ApiCommitStatus&gt;**](ApiCommitStatus.md)

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

<a id="getcomparecommits"></a>
# **GetCompareCommits**
> ApiCompareResponse GetCompareCommits (string repo, string baseHead)

对比 base...head

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
    public class GetCompareCommitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var baseHead = "baseHead_example";  // string | base...head

            try
            {
                // 对比 base...head
                ApiCompareResponse result = apiInstance.GetCompareCommits(repo, baseHead);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetCompareCommits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompareCommitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 对比 base...head
    ApiResponse<ApiCompareResponse> response = apiInstance.GetCompareCommitsWithHttpInfo(repo, baseHead);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetCompareCommitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **baseHead** | **string** | base...head |  |

### Return type

[**ApiCompareResponse**](ApiCompareResponse.md)

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

<a id="getcontent"></a>
# **GetContent**
> ApiContent GetContent (string repo, string filePath, string varRef = null)

查询仓库文件列表或文件

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
    public class GetContentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var filePath = "filePath_example";  // string | path
            var varRef = "varRef_example";  // string | ref (optional) 

            try
            {
                // 查询仓库文件列表或文件
                ApiContent result = apiInstance.GetContent(repo, filePath, varRef);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetContent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库文件列表或文件
    ApiResponse<ApiContent> response = apiInstance.GetContentWithHttpInfo(repo, filePath, varRef);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetContentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **filePath** | **string** | path |  |
| **varRef** | **string** | ref | [optional]  |

### Return type

[**ApiContent**](ApiContent.md)

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

<a id="gethead"></a>
# **GetHead**
> OpenapiHeadRef GetHead (string repo)

获取仓库默认分支

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
    public class GetHeadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo

            try
            {
                // 获取仓库默认分支
                OpenapiHeadRef result = apiInstance.GetHead(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetHead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHeadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取仓库默认分支
    ApiResponse<OpenapiHeadRef> response = apiInstance.GetHeadWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetHeadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |

### Return type

[**OpenapiHeadRef**](OpenapiHeadRef.md)

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

<a id="gettag"></a>
# **GetTag**
> ApiTag GetTag (string repo, string tag)

查询指定 Tag

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
    public class GetTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var tag = "tag_example";  // string | tag name

            try
            {
                // 查询指定 Tag
                ApiTag result = apiInstance.GetTag(repo, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 Tag
    ApiResponse<ApiTag> response = apiInstance.GetTagWithHttpInfo(repo, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetTagWithHttpInfo: " + e.Message);
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

[**ApiTag**](ApiTag.md)

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

<a id="gettagannotations"></a>
# **GetTagAnnotations**
> List&lt;WebTagAnnotation&gt; GetTagAnnotations (string repo, string tag)

查询指定 tag 的元数据

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
    public class GetTagAnnotationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var tag = "tag_example";  // string | tag

            try
            {
                // 查询指定 tag 的元数据
                List<WebTagAnnotation> result = apiInstance.GetTagAnnotations(repo, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.GetTagAnnotations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTagAnnotationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定 tag 的元数据
    ApiResponse<List<WebTagAnnotation>> response = apiInstance.GetTagAnnotationsWithHttpInfo(repo, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.GetTagAnnotationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **tag** | **string** | tag |  |

### Return type

[**List&lt;WebTagAnnotation&gt;**](WebTagAnnotation.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listbranches"></a>
# **ListBranches**
> List&lt;ApiBranch&gt; ListBranches (string repo, int page = null, int pageSize = null)

查询分支列表

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
    public class ListBranchesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // 查询分支列表
                List<ApiBranch> result = apiInstance.ListBranches(repo, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.ListBranches: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBranchesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询分支列表
    ApiResponse<List<ApiBranch>> response = apiInstance.ListBranchesWithHttpInfo(repo, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.ListBranchesWithHttpInfo: " + e.Message);
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

[**List&lt;ApiBranch&gt;**](ApiBranch.md)

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

<a id="listcommits"></a>
# **ListCommits**
> List&lt;ApiCommit&gt; ListCommits (string repo, string sha = null, string author = null, string committer = null, string since = null, string until = null, int page = null, int pageSize = null)

查询 commit 列表

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
    public class ListCommitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha = "sha_example";  // string | sha or branch (optional) 
            var author = "author_example";  // string | commit author pattern (optional) 
            var committer = "committer_example";  // string | commit committer pattern (optional) 
            var since = "since_example";  // string | commit since (optional) 
            var until = "until_example";  // string | commit until (optional) 
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // 查询 commit 列表
                List<ApiCommit> result = apiInstance.ListCommits(repo, sha, author, committer, since, until, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.ListCommits: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCommitsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询 commit 列表
    ApiResponse<List<ApiCommit>> response = apiInstance.ListCommitsWithHttpInfo(repo, sha, author, committer, since, until, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.ListCommitsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha** | **string** | sha or branch | [optional]  |
| **author** | **string** | commit author pattern | [optional]  |
| **committer** | **string** | commit committer pattern | [optional]  |
| **since** | **string** | commit since | [optional]  |
| **until** | **string** | commit until | [optional]  |
| **page** | **int** | pagination page number | [optional] [default to 1] |
| **pageSize** | **int** | pagination page size | [optional] [default to 30] |

### Return type

[**List&lt;ApiCommit&gt;**](ApiCommit.md)

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

<a id="listtags"></a>
# **ListTags**
> List&lt;ApiTag&gt; ListTags (string repo, int page = null, int pageSize = null)

查询标签列表

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
    public class ListTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // 查询标签列表
                List<ApiTag> result = apiInstance.ListTags(repo, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.ListTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询标签列表
    ApiResponse<List<ApiTag>> response = apiInstance.ListTagsWithHttpInfo(repo, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.ListTagsWithHttpInfo: " + e.Message);
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

[**List&lt;ApiTag&gt;**](ApiTag.md)

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

<a id="postcommitassetuploadconfirmation"></a>
# **PostCommitAssetUploadConfirmation**
> void PostCommitAssetUploadConfirmation (string repo, int sha1, string token, string assetPath)

确认 Commit asset 上传完成

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
    public class PostCommitAssetUploadConfirmationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha1 = 56;  // int | sha
            var token = "token_example";  // string | upload token
            var assetPath = "assetPath_example";  // string | release asset path

            try
            {
                // 确认 Commit asset 上传完成
                apiInstance.PostCommitAssetUploadConfirmation(repo, sha1, token, assetPath);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.PostCommitAssetUploadConfirmation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCommitAssetUploadConfirmationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 确认 Commit asset 上传完成
    apiInstance.PostCommitAssetUploadConfirmationWithHttpInfo(repo, sha1, token, assetPath);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.PostCommitAssetUploadConfirmationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha1** | **int** | sha |  |
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

<a id="postcommitassetuploadurl"></a>
# **PostCommitAssetUploadURL**
> OpenapiCommitAssetUploadURL PostCommitAssetUploadURL (string repo, int sha1, OpenapiPostCommitAssetUploadURLForm createCommitAssetUploadUrlForm)

新增一个 Commit asset

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
    public class PostCommitAssetUploadURLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha1 = 56;  // int | sha
            var createCommitAssetUploadUrlForm = new OpenapiPostCommitAssetUploadURLForm(); // OpenapiPostCommitAssetUploadURLForm | Post Commit Asset Upload URL Form

            try
            {
                // 新增一个 Commit asset
                OpenapiCommitAssetUploadURL result = apiInstance.PostCommitAssetUploadURL(repo, sha1, createCommitAssetUploadUrlForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.PostCommitAssetUploadURL: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostCommitAssetUploadURLWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新增一个 Commit asset
    ApiResponse<OpenapiCommitAssetUploadURL> response = apiInstance.PostCommitAssetUploadURLWithHttpInfo(repo, sha1, createCommitAssetUploadUrlForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.PostCommitAssetUploadURLWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha1** | **int** | sha |  |
| **createCommitAssetUploadUrlForm** | [**OpenapiPostCommitAssetUploadURLForm**](OpenapiPostCommitAssetUploadURLForm.md) | Post Commit Asset Upload URL Form |  |

### Return type

[**OpenapiCommitAssetUploadURL**](OpenapiCommitAssetUploadURL.md)

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

<a id="putcommitannotations"></a>
# **PutCommitAnnotations**
> void PutCommitAnnotations (string repo, string sha, OpenapiPutCommitAnnotationsForm putCommitAnnotationsForm)

设定指定 commit 的元数据

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
    public class PutCommitAnnotationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var sha = "sha_example";  // string | commit hash
            var putCommitAnnotationsForm = new OpenapiPutCommitAnnotationsForm(); // OpenapiPutCommitAnnotationsForm | Put Commit Annotations Form

            try
            {
                // 设定指定 commit 的元数据
                apiInstance.PutCommitAnnotations(repo, sha, putCommitAnnotationsForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.PutCommitAnnotations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutCommitAnnotationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 设定指定 commit 的元数据
    apiInstance.PutCommitAnnotationsWithHttpInfo(repo, sha, putCommitAnnotationsForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.PutCommitAnnotationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sha** | **string** | commit hash |  |
| **putCommitAnnotationsForm** | [**OpenapiPutCommitAnnotationsForm**](OpenapiPutCommitAnnotationsForm.md) | Put Commit Annotations Form |  |

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

<a id="puttagannotations"></a>
# **PutTagAnnotations**
> void PutTagAnnotations (string repo, string tag, OpenapiPutTagAnnotationsForm putTagAnnotationsForm)

设定指定 tag 的元数据

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
    public class PutTagAnnotationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitApi(config);
            var repo = "repo_example";  // string | repo
            var tag = "tag_example";  // string | tag
            var putTagAnnotationsForm = new OpenapiPutTagAnnotationsForm(); // OpenapiPutTagAnnotationsForm | Put Tag Annotations Form

            try
            {
                // 设定指定 tag 的元数据
                apiInstance.PutTagAnnotations(repo, tag, putTagAnnotationsForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitApi.PutTagAnnotations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutTagAnnotationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 设定指定 tag 的元数据
    apiInstance.PutTagAnnotationsWithHttpInfo(repo, tag, putTagAnnotationsForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitApi.PutTagAnnotationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **tag** | **string** | tag |  |
| **putTagAnnotationsForm** | [**OpenapiPutTagAnnotationsForm**](OpenapiPutTagAnnotationsForm.md) | Put Tag Annotations Form |  |

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

