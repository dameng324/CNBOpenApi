# CNBOpenApi.Api.ContributorsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMemberAccessLevelOfGroup**](ContributorsApi.md#getmemberaccesslevelofgroup) | **GET** /{group}/-/members/access-level | 获取指定组织或仓库内, 访问成员在当前层级内的权限信息 |
| [**GetMemberAccessLevelOfRepo**](ContributorsApi.md#getmemberaccesslevelofrepo) | **GET** /{repo}/-/members/access-level | 获取指定组织或仓库内, 访问成员在当前层级内的权限信息 |
| [**ListMemberAccessLevelOfGroup**](ContributorsApi.md#listmemberaccesslevelofgroup) | **GET** /{group}/-/members/{username}/access-level | 获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息 |
| [**ListMemberAccessLevelOfRepo**](ContributorsApi.md#listmemberaccesslevelofrepo) | **GET** /{repo}/-/members/{username}/access-level | 获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息 |

<a id="getmemberaccesslevelofgroup"></a>
# **GetMemberAccessLevelOfGroup**
> DtoMemberAccessLevelInSlugUnion GetMemberAccessLevelOfGroup (string group, bool includeInherit = null)

获取指定组织或仓库内, 访问成员在当前层级内的权限信息

访问令牌调用此接口需包含以下权限  group-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetMemberAccessLevelOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContributorsApi(config);
            var group = "group_example";  // string | slug
            var includeInherit = true;  // bool | 是否包含继承的权限 (optional)  (default to true)

            try
            {
                // 获取指定组织或仓库内, 访问成员在当前层级内的权限信息
                DtoMemberAccessLevelInSlugUnion result = apiInstance.GetMemberAccessLevelOfGroup(group, includeInherit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContributorsApi.GetMemberAccessLevelOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberAccessLevelOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内, 访问成员在当前层级内的权限信息
    ApiResponse<DtoMemberAccessLevelInSlugUnion> response = apiInstance.GetMemberAccessLevelOfGroupWithHttpInfo(group, includeInherit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContributorsApi.GetMemberAccessLevelOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **includeInherit** | **bool** | 是否包含继承的权限 | [optional] [default to true] |

### Return type

[**DtoMemberAccessLevelInSlugUnion**](DtoMemberAccessLevelInSlugUnion.md)

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

<a id="getmemberaccesslevelofrepo"></a>
# **GetMemberAccessLevelOfRepo**
> DtoMemberAccessLevelInSlugUnion GetMemberAccessLevelOfRepo (string repo, bool includeInherit = null)

获取指定组织或仓库内, 访问成员在当前层级内的权限信息

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
    public class GetMemberAccessLevelOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContributorsApi(config);
            var repo = "repo_example";  // string | slug
            var includeInherit = true;  // bool | 是否包含继承的权限 (optional)  (default to true)

            try
            {
                // 获取指定组织或仓库内, 访问成员在当前层级内的权限信息
                DtoMemberAccessLevelInSlugUnion result = apiInstance.GetMemberAccessLevelOfRepo(repo, includeInherit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContributorsApi.GetMemberAccessLevelOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMemberAccessLevelOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内, 访问成员在当前层级内的权限信息
    ApiResponse<DtoMemberAccessLevelInSlugUnion> response = apiInstance.GetMemberAccessLevelOfRepoWithHttpInfo(repo, includeInherit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContributorsApi.GetMemberAccessLevelOfRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **includeInherit** | **bool** | 是否包含继承的权限 | [optional] [default to true] |

### Return type

[**DtoMemberAccessLevelInSlugUnion**](DtoMemberAccessLevelInSlugUnion.md)

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

<a id="listmemberaccesslevelofgroup"></a>
# **ListMemberAccessLevelOfGroup**
> List&lt;DtoMemberAccessLevel&gt; ListMemberAccessLevelOfGroup (string group, string username)

获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息

访问令牌调用此接口需包含以下权限  group-manage:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListMemberAccessLevelOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContributorsApi(config);
            var group = "group_example";  // string | slug
            var username = "username_example";  // string | username

            try
            {
                // 获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息
                List<DtoMemberAccessLevel> result = apiInstance.ListMemberAccessLevelOfGroup(group, username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContributorsApi.ListMemberAccessLevelOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberAccessLevelOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息
    ApiResponse<List<DtoMemberAccessLevel>> response = apiInstance.ListMemberAccessLevelOfGroupWithHttpInfo(group, username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContributorsApi.ListMemberAccessLevelOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **username** | **string** | username |  |

### Return type

[**List&lt;DtoMemberAccessLevel&gt;**](DtoMemberAccessLevel.md)

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

<a id="listmemberaccesslevelofrepo"></a>
# **ListMemberAccessLevelOfRepo**
> List&lt;DtoMemberAccessLevel&gt; ListMemberAccessLevelOfRepo (string repo, string username)

获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息

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
    public class ListMemberAccessLevelOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ContributorsApi(config);
            var repo = "repo_example";  // string | slug
            var username = "username_example";  // string | username

            try
            {
                // 获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息
                List<DtoMemberAccessLevel> result = apiInstance.ListMemberAccessLevelOfRepo(repo, username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContributorsApi.ListMemberAccessLevelOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMemberAccessLevelOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内指定成员的权限信息, 结果按组织层级来展示, 包含上层组织的权限继承信息
    ApiResponse<List<DtoMemberAccessLevel>> response = apiInstance.ListMemberAccessLevelOfRepoWithHttpInfo(repo, username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContributorsApi.ListMemberAccessLevelOfRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **username** | **string** | username |  |

### Return type

[**List&lt;DtoMemberAccessLevel&gt;**](DtoMemberAccessLevel.md)

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

