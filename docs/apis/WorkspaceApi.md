# CNBOpenApi.Api.WorkspaceApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteWorkspace**](WorkspaceApi.md#deleteworkspace) | **POST** /workspace/delete | 删除我的云原生开发环境 |
| [**GetWorkspaceDetail**](WorkspaceApi.md#getworkspacedetail) | **GET** /{repo}/-/workspace/detail/{sn} | 根据流水线sn查询云原生开发访问地址 |
| [**ListWorkspaces**](WorkspaceApi.md#listworkspaces) | **GET** /workspace/list | 获取我的云原生开发环境列表 |

<a id="deleteworkspace"></a>
# **DeleteWorkspace**
> DtoWorkspaceDeleteResult DeleteWorkspace (DtoWorkspaceDeleteReq request)

删除我的云原生开发环境

访问令牌调用此接口需包含以下权限  account-engage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(config);
            var request = new DtoWorkspaceDeleteReq(); // DtoWorkspaceDeleteReq | 参数

            try
            {
                // 删除我的云原生开发环境
                DtoWorkspaceDeleteResult result = apiInstance.DeleteWorkspace(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除我的云原生开发环境
    ApiResponse<DtoWorkspaceDeleteResult> response = apiInstance.DeleteWorkspaceWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.DeleteWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**DtoWorkspaceDeleteReq**](DtoWorkspaceDeleteReq.md) | 参数 |  |

### Return type

[**DtoWorkspaceDeleteResult**](DtoWorkspaceDeleteResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getworkspacedetail"></a>
# **GetWorkspaceDetail**
> DtoWorkspaceDetailResult GetWorkspaceDetail (string repo, string sn)

根据流水线sn查询云原生开发访问地址

访问令牌调用此接口需包含以下权限  repo-cnb-detail:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetWorkspaceDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(config);
            var repo = "repo_example";  // string | 仓库路径
            var sn = "sn_example";  // string | 构建号

            try
            {
                // 根据流水线sn查询云原生开发访问地址
                DtoWorkspaceDetailResult result = apiInstance.GetWorkspaceDetail(repo, sn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWorkspaceDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 根据流水线sn查询云原生开发访问地址
    ApiResponse<DtoWorkspaceDetailResult> response = apiInstance.GetWorkspaceDetailWithHttpInfo(repo, sn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.GetWorkspaceDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | 仓库路径 |  |
| **sn** | **string** | 构建号 |  |

### Return type

[**DtoWorkspaceDetailResult**](DtoWorkspaceDetailResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listworkspaces"></a>
# **ListWorkspaces**
> DtoWorkspaceListResult ListWorkspaces (string branch = null, string end = null, int page = null, int pageSize = null, string slug = null, string start = null, string status = null)

获取我的云原生开发环境列表

访问令牌调用此接口需包含以下权限  account-engage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListWorkspacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WorkspaceApi(config);
            var branch = "branch_example";  // string | 分支名，例如：main (optional) 
            var end = "end_example";  // string | 查询结束时间，格式：YYYY-MM-DD HH:mm:ssZZ，例如：2024-12-01 00:00:00+0800 (optional) 
            var page = 56;  // int | 分页页码，从 1 开始，默认为 1 (optional) 
            var pageSize = 56;  // int | 每页条数，默认为 20，最高 100 (optional) 
            var slug = "slug_example";  // string | 仓库路径，例如：groupname/reponame (optional) 
            var start = "start_example";  // string | 查询开始时间，格式：YYYY-MM-DD HH:mm:ssZZ，例如：2024-12-01 00:00:00+0800 (optional) 
            var status = "status_example";  // string | 开发环境状态，running: 开发环境已启动，closed：开发环境已关闭 (optional) 

            try
            {
                // 获取我的云原生开发环境列表
                DtoWorkspaceListResult result = apiInstance.ListWorkspaces(branch, end, page, pageSize, slug, start, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkspaceApi.ListWorkspaces: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWorkspacesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取我的云原生开发环境列表
    ApiResponse<DtoWorkspaceListResult> response = apiInstance.ListWorkspacesWithHttpInfo(branch, end, page, pageSize, slug, start, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WorkspaceApi.ListWorkspacesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **branch** | **string** | 分支名，例如：main | [optional]  |
| **end** | **string** | 查询结束时间，格式：YYYY-MM-DD HH:mm:ssZZ，例如：2024-12-01 00:00:00+0800 | [optional]  |
| **page** | **int** | 分页页码，从 1 开始，默认为 1 | [optional]  |
| **pageSize** | **int** | 每页条数，默认为 20，最高 100 | [optional]  |
| **slug** | **string** | 仓库路径，例如：groupname/reponame | [optional]  |
| **start** | **string** | 查询开始时间，格式：YYYY-MM-DD HH:mm:ssZZ，例如：2024-12-01 00:00:00+0800 | [optional]  |
| **status** | **string** | 开发环境状态，running: 开发环境已启动，closed：开发环境已关闭 | [optional]  |

### Return type

[**DtoWorkspaceListResult**](DtoWorkspaceListResult.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

