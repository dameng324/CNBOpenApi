# CNBOpenApi.Api.BuildApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBuildLogs**](BuildApi.md#getbuildlogs) | **GET** /{repo}/-/build/logs | 查询流水线构建列表 |
| [**GetBuildStatus**](BuildApi.md#getbuildstatus) | **GET** /{repo}/-/build/status/{sn} | 查询流水线构建状态 |
| [**StartBuild**](BuildApi.md#startbuild) | **POST** /{repo}/-/build/start | 开始一个构建 |
| [**StopBuild**](BuildApi.md#stopbuild) | **POST** /{repo}/-/build/stop/{sn} | 停止一个构建 |

<a id="getbuildlogs"></a>
# **GetBuildLogs**
> DtoBuildLogsResult GetBuildLogs (string repo, string createTime = null, string endTime = null, string varEvent = null, int page = null, int pagesize = null, string sha = null, string sn = null, string sourceRef = null, string status = null, string targetRef = null, string userId = null, string userName = null)

查询流水线构建列表

访问令牌调用此接口需包含以下权限  repo-cnb-trigger:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetBuildLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildApi(config);
            var repo = "repo_example";  // string | 仓库路径
            var createTime = "createTime_example";  // string | 开始时间，格式：YYYY-MM-DD，例如：2024-12-01 (optional) 
            var endTime = "endTime_example";  // string | 结束时间，格式：YYYY-MM-DD，例如：2024-12-01 (optional) 
            var varEvent = "varEvent_example";  // string | 事件名，例如：push (optional) 
            var page = 56;  // int | 页数，从 1 开始 (optional) 
            var pagesize = 56;  // int | 每页数量，最大 100 条，默认 20 条 (optional) 
            var sha = "sha_example";  // string | commit id，例如：2221d4535ec0c921bcd0858627c5025a871dd2b5 (optional) 
            var sn = "sn_example";  // string | 构建号，例如：cnb-1qa-1i3f5ecau (optional) 
            var sourceRef = "sourceRef_example";  // string | 源分支名，例如：dev (optional) 
            var status = "status_example";  // string | 构建状态，pending: 构建中、success：成功、error: 失败、cancel: 取消 (optional) 
            var targetRef = "targetRef_example";  // string | 目标分支名，例如：main (optional) 
            var userId = "userId_example";  // string | 用户 id (optional) 
            var userName = "userName_example";  // string | 用户名 (optional) 

            try
            {
                // 查询流水线构建列表
                DtoBuildLogsResult result = apiInstance.GetBuildLogs(repo, createTime, endTime, varEvent, page, pagesize, sha, sn, sourceRef, status, targetRef, userId, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBuildLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询流水线构建列表
    ApiResponse<DtoBuildLogsResult> response = apiInstance.GetBuildLogsWithHttpInfo(repo, createTime, endTime, varEvent, page, pagesize, sha, sn, sourceRef, status, targetRef, userId, userName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildApi.GetBuildLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | 仓库路径 |  |
| **createTime** | **string** | 开始时间，格式：YYYY-MM-DD，例如：2024-12-01 | [optional]  |
| **endTime** | **string** | 结束时间，格式：YYYY-MM-DD，例如：2024-12-01 | [optional]  |
| **varEvent** | **string** | 事件名，例如：push | [optional]  |
| **page** | **int** | 页数，从 1 开始 | [optional]  |
| **pagesize** | **int** | 每页数量，最大 100 条，默认 20 条 | [optional]  |
| **sha** | **string** | commit id，例如：2221d4535ec0c921bcd0858627c5025a871dd2b5 | [optional]  |
| **sn** | **string** | 构建号，例如：cnb-1qa-1i3f5ecau | [optional]  |
| **sourceRef** | **string** | 源分支名，例如：dev | [optional]  |
| **status** | **string** | 构建状态，pending: 构建中、success：成功、error: 失败、cancel: 取消 | [optional]  |
| **targetRef** | **string** | 目标分支名，例如：main | [optional]  |
| **userId** | **string** | 用户 id | [optional]  |
| **userName** | **string** | 用户名 | [optional]  |

### Return type

[**DtoBuildLogsResult**](DtoBuildLogsResult.md)

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

<a id="getbuildstatus"></a>
# **GetBuildStatus**
> DtoBuildStatusResult GetBuildStatus (string repo, string sn)

查询流水线构建状态

访问令牌调用此接口需包含以下权限  repo-cnb-trigger:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetBuildStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildApi(config);
            var repo = "repo_example";  // string | 仓库路径
            var sn = "sn_example";  // string | 构建号

            try
            {
                // 查询流水线构建状态
                DtoBuildStatusResult result = apiInstance.GetBuildStatus(repo, sn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildApi.GetBuildStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBuildStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询流水线构建状态
    ApiResponse<DtoBuildStatusResult> response = apiInstance.GetBuildStatusWithHttpInfo(repo, sn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildApi.GetBuildStatusWithHttpInfo: " + e.Message);
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

[**DtoBuildStatusResult**](DtoBuildStatusResult.md)

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

<a id="startbuild"></a>
# **StartBuild**
> List&lt;DtoBuildResult&gt; StartBuild (string repo, DtoStartBuildReq request)

开始一个构建

访问令牌调用此接口需包含以下权限  repo-cnb-trigger:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class StartBuildExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildApi(config);
            var repo = "repo_example";  // string | repo
            var request = new DtoStartBuildReq(); // DtoStartBuildReq | 构建参数

            try
            {
                // 开始一个构建
                List<DtoBuildResult> result = apiInstance.StartBuild(repo, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildApi.StartBuild: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartBuildWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 开始一个构建
    ApiResponse<List<DtoBuildResult>> response = apiInstance.StartBuildWithHttpInfo(repo, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildApi.StartBuildWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **request** | [**DtoStartBuildReq**](DtoStartBuildReq.md) | 构建参数 |  |

### Return type

[**List&lt;DtoBuildResult&gt;**](DtoBuildResult.md)

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

<a id="stopbuild"></a>
# **StopBuild**
> List&lt;DtoBuildResult&gt; StopBuild (string repo, string sn)

停止一个构建

访问令牌调用此接口需包含以下权限  repo-cnb-trigger:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class StopBuildExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BuildApi(config);
            var repo = "repo_example";  // string | repo
            var sn = "sn_example";  // string | 构建号

            try
            {
                // 停止一个构建
                List<DtoBuildResult> result = apiInstance.StopBuild(repo, sn);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BuildApi.StopBuild: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StopBuildWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 停止一个构建
    ApiResponse<List<DtoBuildResult>> response = apiInstance.StopBuildWithHttpInfo(repo, sn);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BuildApi.StopBuildWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **sn** | **string** | 构建号 |  |

### Return type

[**List&lt;DtoBuildResult&gt;**](DtoBuildResult.md)

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

