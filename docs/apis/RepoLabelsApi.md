# CNBOpenApi.Api.RepoLabelsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteLabel**](RepoLabelsApi.md#deletelabel) | **DELETE** /{repo}/-/labels/{name} | 删除指定的仓库标签 label |
| [**ListLabels**](RepoLabelsApi.md#listlabels) | **GET** /{repo}/-/labels | 查询仓库的标签(label) 列表 |
| [**PatchLabel**](RepoLabelsApi.md#patchlabel) | **PATCH** /{repo}/-/labels/{name} | 更新标签信息 |
| [**PostLabel**](RepoLabelsApi.md#postlabel) | **POST** /{repo}/-/labels | 创建一个 标签 |

<a id="deletelabel"></a>
# **DeleteLabel**
> void DeleteLabel (string repo, string name)

删除指定的仓库标签 label

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepoLabelsApi(config);
            var repo = "repo_example";  // string | repo
            var name = "name_example";  // string | label name

            try
            {
                // 删除指定的仓库标签 label
                apiInstance.DeleteLabel(repo, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepoLabelsApi.DeleteLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定的仓库标签 label
    apiInstance.DeleteLabelWithHttpInfo(repo, name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepoLabelsApi.DeleteLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **name** | **string** | label name |  |

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

<a id="listlabels"></a>
# **ListLabels**
> List&lt;ApiLabel&gt; ListLabels (string repo, int page = null, int pageSize = null, string keyword = null)

查询仓库的标签(label) 列表

访问令牌调用此接口需包含以下权限  repo-notes:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepoLabelsApi(config);
            var repo = "repo_example";  // string | repo
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)
            var keyword = "keyword_example";  // string | label search key (optional) 

            try
            {
                // 查询仓库的标签(label) 列表
                List<ApiLabel> result = apiInstance.ListLabels(repo, page, pageSize, keyword);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepoLabelsApi.ListLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库的标签(label) 列表
    ApiResponse<List<ApiLabel>> response = apiInstance.ListLabelsWithHttpInfo(repo, page, pageSize, keyword);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepoLabelsApi.ListLabelsWithHttpInfo: " + e.Message);
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
| **keyword** | **string** | label search key | [optional]  |

### Return type

[**List&lt;ApiLabel&gt;**](ApiLabel.md)

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

<a id="patchlabel"></a>
# **PatchLabel**
> ApiLabel PatchLabel (string repo, string name, ApiPatchLabelForm patchLabelForm)

更新标签信息

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PatchLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepoLabelsApi(config);
            var repo = "repo_example";  // string | repo
            var name = "name_example";  // string | label name
            var patchLabelForm = new ApiPatchLabelForm(); // ApiPatchLabelForm | Patch Label Form

            try
            {
                // 更新标签信息
                ApiLabel result = apiInstance.PatchLabel(repo, name, patchLabelForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepoLabelsApi.PatchLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新标签信息
    ApiResponse<ApiLabel> response = apiInstance.PatchLabelWithHttpInfo(repo, name, patchLabelForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepoLabelsApi.PatchLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **name** | **string** | label name |  |
| **patchLabelForm** | [**ApiPatchLabelForm**](ApiPatchLabelForm.md) | Patch Label Form |  |

### Return type

[**ApiLabel**](ApiLabel.md)

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

<a id="postlabel"></a>
# **PostLabel**
> ApiLabel PostLabel (string repo, ApiPostLabelForm postLabelForm)

创建一个 标签

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepoLabelsApi(config);
            var repo = "repo_example";  // string | repo
            var postLabelForm = new ApiPostLabelForm(); // ApiPostLabelForm | Post Label Form

            try
            {
                // 创建一个 标签
                ApiLabel result = apiInstance.PostLabel(repo, postLabelForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepoLabelsApi.PostLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建一个 标签
    ApiResponse<ApiLabel> response = apiInstance.PostLabelWithHttpInfo(repo, postLabelForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepoLabelsApi.PostLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **postLabelForm** | [**ApiPostLabelForm**](ApiPostLabelForm.md) | Post Label Form |  |

### Return type

[**ApiLabel**](ApiLabel.md)

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

