# CNBOpenApi.Api.GitSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteBranchProtection**](GitSettingsApi.md#deletebranchprotection) | **DELETE** /{repo}/-/settings/branch-protections/{id} | 删除仓库保护分支规则(openapi) |
| [**GetBranchProtection**](GitSettingsApi.md#getbranchprotection) | **GET** /{repo}/-/settings/branch-protections/{id} | 查询仓库保护分支规则(openapi) |
| [**GetPipelineSettings**](GitSettingsApi.md#getpipelinesettings) | **GET** /{repo}/-/settings/cloud-native-build | 查询仓库云原生构建设置(openapi) |
| [**GetPullRequestSettings**](GitSettingsApi.md#getpullrequestsettings) | **GET** /{repo}/-/settings/pull-request | 查询仓库合并请求设置(openapi) |
| [**GetPushLimitSettings**](GitSettingsApi.md#getpushlimitsettings) | **GET** /{repo}/-/settings/push-limit | 查询仓库推送设置(openapi) |
| [**ListBranchProtections**](GitSettingsApi.md#listbranchprotections) | **GET** /{repo}/-/settings/branch-protections | 查询仓库保护分支规则列表(openapi) |
| [**PatchBranchProtection**](GitSettingsApi.md#patchbranchprotection) | **PATCH** /{repo}/-/settings/branch-protections/{id} | 更新仓库保护分支规则(openapi) |
| [**PostBranchProtection**](GitSettingsApi.md#postbranchprotection) | **POST** /{repo}/-/settings/branch-protections | 新增仓库保护分支规则(openapi) |
| [**PutPipelineSettings**](GitSettingsApi.md#putpipelinesettings) | **PUT** /{repo}/-/settings/cloud-native-build | 更新仓库云原生构建设置(openapi) |
| [**PutPullRequestSettings**](GitSettingsApi.md#putpullrequestsettings) | **PUT** /{repo}/-/settings/pull-request | 设置仓库推送设置(openapi) |
| [**PutPushLimitSettings**](GitSettingsApi.md#putpushlimitsettings) | **PUT** /{repo}/-/settings/push-limit | 设置仓库推送设置(openapi) |

<a id="deletebranchprotection"></a>
# **DeleteBranchProtection**
> void DeleteBranchProtection (string repo, string id)

删除仓库保护分支规则(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteBranchProtectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var id = "id_example";  // string | Branch Protection id

            try
            {
                // 删除仓库保护分支规则(openapi)
                apiInstance.DeleteBranchProtection(repo, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.DeleteBranchProtection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteBranchProtectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除仓库保护分支规则(openapi)
    apiInstance.DeleteBranchProtectionWithHttpInfo(repo, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.DeleteBranchProtectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **id** | **string** | Branch Protection id |  |

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

<a id="getbranchprotection"></a>
# **GetBranchProtection**
> ApiBranchProtection GetBranchProtection (string repo, string id)

查询仓库保护分支规则(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetBranchProtectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var id = "id_example";  // string | branch protection id

            try
            {
                // 查询仓库保护分支规则(openapi)
                ApiBranchProtection result = apiInstance.GetBranchProtection(repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.GetBranchProtection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBranchProtectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库保护分支规则(openapi)
    ApiResponse<ApiBranchProtection> response = apiInstance.GetBranchProtectionWithHttpInfo(repo, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.GetBranchProtectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **id** | **string** | branch protection id |  |

### Return type

[**ApiBranchProtection**](ApiBranchProtection.md)

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

<a id="getpipelinesettings"></a>
# **GetPipelineSettings**
> ApiPipelineSettings GetPipelineSettings (string repo)

查询仓库云原生构建设置(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetPipelineSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo

            try
            {
                // 查询仓库云原生构建设置(openapi)
                ApiPipelineSettings result = apiInstance.GetPipelineSettings(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.GetPipelineSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPipelineSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库云原生构建设置(openapi)
    ApiResponse<ApiPipelineSettings> response = apiInstance.GetPipelineSettingsWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.GetPipelineSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |

### Return type

[**ApiPipelineSettings**](ApiPipelineSettings.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpullrequestsettings"></a>
# **GetPullRequestSettings**
> ApiPullRequestSettings GetPullRequestSettings (string repo)

查询仓库合并请求设置(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetPullRequestSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo

            try
            {
                // 查询仓库合并请求设置(openapi)
                ApiPullRequestSettings result = apiInstance.GetPullRequestSettings(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.GetPullRequestSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPullRequestSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库合并请求设置(openapi)
    ApiResponse<ApiPullRequestSettings> response = apiInstance.GetPullRequestSettingsWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.GetPullRequestSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |

### Return type

[**ApiPullRequestSettings**](ApiPullRequestSettings.md)

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

<a id="getpushlimitsettings"></a>
# **GetPushLimitSettings**
> ApiPushLimitSettings GetPushLimitSettings (string repo)

查询仓库推送设置(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetPushLimitSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo

            try
            {
                // 查询仓库推送设置(openapi)
                ApiPushLimitSettings result = apiInstance.GetPushLimitSettings(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.GetPushLimitSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPushLimitSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库推送设置(openapi)
    ApiResponse<ApiPushLimitSettings> response = apiInstance.GetPushLimitSettingsWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.GetPushLimitSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |

### Return type

[**ApiPushLimitSettings**](ApiPushLimitSettings.md)

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

<a id="listbranchprotections"></a>
# **ListBranchProtections**
> List&lt;ApiBranchProtection&gt; ListBranchProtections (string repo)

查询仓库保护分支规则列表(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListBranchProtectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo

            try
            {
                // 查询仓库保护分支规则列表(openapi)
                List<ApiBranchProtection> result = apiInstance.ListBranchProtections(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.ListBranchProtections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListBranchProtectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库保护分支规则列表(openapi)
    ApiResponse<List<ApiBranchProtection>> response = apiInstance.ListBranchProtectionsWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.ListBranchProtectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |

### Return type

[**List&lt;ApiBranchProtection&gt;**](ApiBranchProtection.md)

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

<a id="patchbranchprotection"></a>
# **PatchBranchProtection**
> void PatchBranchProtection (string repo, string id, ApiBranchProtection branchProtectionForm)

更新仓库保护分支规则(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PatchBranchProtectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var id = "id_example";  // string | Branch Protection id
            var branchProtectionForm = new ApiBranchProtection(); // ApiBranchProtection | Branch Protection Form

            try
            {
                // 更新仓库保护分支规则(openapi)
                apiInstance.PatchBranchProtection(repo, id, branchProtectionForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.PatchBranchProtection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchBranchProtectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新仓库保护分支规则(openapi)
    apiInstance.PatchBranchProtectionWithHttpInfo(repo, id, branchProtectionForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.PatchBranchProtectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **id** | **string** | Branch Protection id |  |
| **branchProtectionForm** | [**ApiBranchProtection**](ApiBranchProtection.md) | Branch Protection Form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postbranchprotection"></a>
# **PostBranchProtection**
> void PostBranchProtection (string repo, ApiBranchProtection branchProtectionForm)

新增仓库保护分支规则(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostBranchProtectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var branchProtectionForm = new ApiBranchProtection(); // ApiBranchProtection | Branch Protection Form

            try
            {
                // 新增仓库保护分支规则(openapi)
                apiInstance.PostBranchProtection(repo, branchProtectionForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.PostBranchProtection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostBranchProtectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新增仓库保护分支规则(openapi)
    apiInstance.PostBranchProtectionWithHttpInfo(repo, branchProtectionForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.PostBranchProtectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **branchProtectionForm** | [**ApiBranchProtection**](ApiBranchProtection.md) | Branch Protection Form |  |

### Return type

void (empty response body)

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

<a id="putpipelinesettings"></a>
# **PutPipelineSettings**
> void PutPipelineSettings (string repo, WebPipelineSettings pipelineForm)

更新仓库云原生构建设置(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutPipelineSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var pipelineForm = new WebPipelineSettings(); // WebPipelineSettings | Cloud Native Build Form

            try
            {
                // 更新仓库云原生构建设置(openapi)
                apiInstance.PutPipelineSettings(repo, pipelineForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.PutPipelineSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutPipelineSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新仓库云原生构建设置(openapi)
    apiInstance.PutPipelineSettingsWithHttpInfo(repo, pipelineForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.PutPipelineSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **pipelineForm** | [**WebPipelineSettings**](WebPipelineSettings.md) | Cloud Native Build Form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putpullrequestsettings"></a>
# **PutPullRequestSettings**
> void PutPullRequestSettings (string repo, ApiPullRequestSettings pullRequestForm)

设置仓库推送设置(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutPullRequestSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var pullRequestForm = new ApiPullRequestSettings(); // ApiPullRequestSettings | Pull Request Form

            try
            {
                // 设置仓库推送设置(openapi)
                apiInstance.PutPullRequestSettings(repo, pullRequestForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.PutPullRequestSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutPullRequestSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 设置仓库推送设置(openapi)
    apiInstance.PutPullRequestSettingsWithHttpInfo(repo, pullRequestForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.PutPullRequestSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **pullRequestForm** | [**ApiPullRequestSettings**](ApiPullRequestSettings.md) | Pull Request Form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putpushlimitsettings"></a>
# **PutPushLimitSettings**
> void PutPushLimitSettings (string repo, ApiPushLimitSettings pushLimitForm)

设置仓库推送设置(openapi)

访问令牌调用此接口需包含以下权限  repo-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutPushLimitSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new GitSettingsApi(config);
            var repo = "repo_example";  // string | repo
            var pushLimitForm = new ApiPushLimitSettings(); // ApiPushLimitSettings | Push Limit Form

            try
            {
                // 设置仓库推送设置(openapi)
                apiInstance.PutPushLimitSettings(repo, pushLimitForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GitSettingsApi.PutPushLimitSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutPushLimitSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 设置仓库推送设置(openapi)
    apiInstance.PutPushLimitSettingsWithHttpInfo(repo, pushLimitForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GitSettingsApi.PutPushLimitSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **pushLimitForm** | [**ApiPushLimitSettings**](ApiPushLimitSettings.md) | Push Limit Form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

