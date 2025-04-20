# CNBOpenApi.Api.RepositoriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAFork**](RepositoriesApi.md#createafork) | **POST** /{repo}/-/forks | fork 仓库 |
| [**CreateRepo**](RepositoriesApi.md#createrepo) | **POST** /{group}/-/repos | 创建仓库 |
| [**DeleteRepo**](RepositoriesApi.md#deleterepo) | **DELETE** /{repo} | 删除指定仓库 |
| [**GetGroupSubRepos**](RepositoriesApi.md#getgroupsubrepos) | **GET** /{group}/-/repos | 查询组织下访问用户有权限查看到仓库 |
| [**GetPinnedRepoByGroup**](RepositoriesApi.md#getpinnedrepobygroup) | **GET** /{group}/-/pinned-repos | 获取指定组织的仓库墙列表 |
| [**GetPinnedRepoByID**](RepositoriesApi.md#getpinnedrepobyid) | **GET** /users/{username}/pinned-repos | 获取指定用户的用户仓库墙 |
| [**GetRepo**](RepositoriesApi.md#getrepo) | **GET** /{repo} | 获取指定仓库信息 |
| [**GetRepos**](RepositoriesApi.md#getrepos) | **GET** /user/repos | 获取当前用户拥有指定权限及其以上权限的仓库 |
| [**GetReposByUserName**](RepositoriesApi.md#getreposbyusername) | **GET** /users/{username}/repos | 获取指定用户有指定以上权限并且客人态可见的仓库 |
| [**GetUserAllStaredRepos**](RepositoriesApi.md#getuserallstaredrepos) | **GET** /user/stared-repos | 获取当前用户 star 的仓库列表 |
| [**ListForksRepos**](RepositoriesApi.md#listforksrepos) | **GET** /{repo}/-/forks | 获取指定仓库的 fork 列表 |
| [**SetPinnedRepoByGroup**](RepositoriesApi.md#setpinnedrepobygroup) | **PUT** /{group}/-/pinned-repos | 更新指定组织仓库墙 |
| [**UpdateRepo**](RepositoriesApi.md#updaterepo) | **PATCH** /{repo} | 更新仓库信息, 可更新的内容为: 仓库简介, 仓库站点, 仓库主题, 开源许可证 |

<a id="createafork"></a>
# **CreateAFork**
> void CreateAFork (string repo, DtoForkReq request)

fork 仓库

访问令牌调用此接口需包含以下权限  group-resource:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class CreateAForkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var repo = "repo_example";  // string | slug
            var request = new DtoForkReq(); // DtoForkReq | target

            try
            {
                // fork 仓库
                apiInstance.CreateAFork(repo, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.CreateAFork: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAForkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // fork 仓库
    apiInstance.CreateAForkWithHttpInfo(repo, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.CreateAForkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **request** | [**DtoForkReq**](DtoForkReq.md) | target |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createrepo"></a>
# **CreateRepo**
> void CreateRepo (DtoCreateRepoReq request, string group)

创建仓库

访问令牌调用此接口需包含以下权限  group-resource:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class CreateRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var request = new DtoCreateRepoReq(); // DtoCreateRepoReq | repo information
            var group = "\"hello\"";  // string | Group slug (default to "hello")

            try
            {
                // 创建仓库
                apiInstance.CreateRepo(request, group);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.CreateRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建仓库
    apiInstance.CreateRepoWithHttpInfo(request, group);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.CreateRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**DtoCreateRepoReq**](DtoCreateRepoReq.md) | repo information |  |
| **group** | **string** | Group slug | [default to &quot;hello&quot;] |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleterepo"></a>
# **DeleteRepo**
> void DeleteRepo (string repo, string xCnbIdentityTicket = null)

删除指定仓库

访问令牌调用此接口需包含以下权限  repo-delete:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var repo = "repo_example";  // string | repo path
            var xCnbIdentityTicket = "xCnbIdentityTicket_example";  // string | 微信用户需要确认身份，第一次调用不传接口会调用失败并返回一个x-cnb-identity-ticket，第二次调用再传返回的值 (optional) 

            try
            {
                // 删除指定仓库
                apiInstance.DeleteRepo(repo, xCnbIdentityTicket);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.DeleteRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定仓库
    apiInstance.DeleteRepoWithHttpInfo(repo, xCnbIdentityTicket);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.DeleteRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo path |  |
| **xCnbIdentityTicket** | **string** | 微信用户需要确认身份，第一次调用不传接口会调用失败并返回一个x-cnb-identity-ticket，第二次调用再传返回的值 | [optional]  |

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

<a id="getgroupsubrepos"></a>
# **GetGroupSubRepos**
> List&lt;DtoRepos4UserBase&gt; GetGroupSubRepos (string group, int page = null, int pageSize = null, string filterType = null, string orderBy = null, bool desc = null, string descendant = null, string search = null)

查询组织下访问用户有权限查看到仓库

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
    public class GetGroupSubReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var group = "group_example";  // string | 组织 slug
            var page = 1;  // int | 页码 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页数量 (optional)  (default to 10)
            var filterType = "private";  // string | 仓库类型 (optional) 
            var orderBy = "created_at";  // string | 排序类型，默认last_updated_at (optional) 
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)
            var descendant = "all";  // string | 查全部/查询直接属于当前组织的仓库/查询子组织的仓库 (optional) 
            var search = "search_example";  // string | 搜索关键字 (optional) 

            try
            {
                // 查询组织下访问用户有权限查看到仓库
                List<DtoRepos4UserBase> result = apiInstance.GetGroupSubRepos(group, page, pageSize, filterType, orderBy, desc, descendant, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetGroupSubRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupSubReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询组织下访问用户有权限查看到仓库
    ApiResponse<List<DtoRepos4UserBase>> response = apiInstance.GetGroupSubReposWithHttpInfo(group, page, pageSize, filterType, orderBy, desc, descendant, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetGroupSubReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | 组织 slug |  |
| **page** | **int** | 页码 | [optional] [default to 1] |
| **pageSize** | **int** | 每页数量 | [optional] [default to 10] |
| **filterType** | **string** | 仓库类型 | [optional]  |
| **orderBy** | **string** | 排序类型，默认last_updated_at | [optional]  |
| **desc** | **bool** | 排序顺序 | [optional] [default to false] |
| **descendant** | **string** | 查全部/查询直接属于当前组织的仓库/查询子组织的仓库 | [optional]  |
| **search** | **string** | 搜索关键字 | [optional]  |

### Return type

[**List&lt;DtoRepos4UserBase&gt;**](DtoRepos4UserBase.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpinnedrepobygroup"></a>
# **GetPinnedRepoByGroup**
> List&lt;DtoRepos4UserBase&gt; GetPinnedRepoByGroup (string group)

获取指定组织的仓库墙列表

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
    public class GetPinnedRepoByGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var group = "group_example";  // string | slug

            try
            {
                // 获取指定组织的仓库墙列表
                List<DtoRepos4UserBase> result = apiInstance.GetPinnedRepoByGroup(group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetPinnedRepoByGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPinnedRepoByGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织的仓库墙列表
    ApiResponse<List<DtoRepos4UserBase>> response = apiInstance.GetPinnedRepoByGroupWithHttpInfo(group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetPinnedRepoByGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |

### Return type

[**List&lt;DtoRepos4UserBase&gt;**](DtoRepos4UserBase.md)

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

<a id="getpinnedrepobyid"></a>
# **GetPinnedRepoByID**
> List&lt;DtoRepos4User&gt; GetPinnedRepoByID (string username)

获取指定用户的用户仓库墙

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
    public class GetPinnedRepoByIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var username = "\"someone\"";  // string | User Name (default to "someone")

            try
            {
                // 获取指定用户的用户仓库墙
                List<DtoRepos4User> result = apiInstance.GetPinnedRepoByID(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetPinnedRepoByID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPinnedRepoByIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户的用户仓库墙
    ApiResponse<List<DtoRepos4User>> response = apiInstance.GetPinnedRepoByIDWithHttpInfo(username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetPinnedRepoByIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | User Name | [default to &quot;someone&quot;] |

### Return type

[**List&lt;DtoRepos4User&gt;**](DtoRepos4User.md)

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

<a id="getrepo"></a>
# **GetRepo**
> DtoRepos4User GetRepo (string repo)

获取指定仓库信息

访问令牌调用此接口需包含以下权限  repo-basic-info:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var repo = "repo_example";  // string | repo path

            try
            {
                // 获取指定仓库信息
                DtoRepos4User result = apiInstance.GetRepo(repo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定仓库信息
    ApiResponse<DtoRepos4User> response = apiInstance.GetRepoWithHttpInfo(repo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo path |  |

### Return type

[**DtoRepos4User**](DtoRepos4User.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | repo |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrepos"></a>
# **GetRepos**
> List&lt;DtoRepos4User&gt; GetRepos (int page = null, int pageSize = null, string search = null, string filterType = null, string role = null, string orderBy = null, bool desc = null)

获取当前用户拥有指定权限及其以上权限的仓库

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
    public class GetReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var search = "search_example";  // string | 过滤仓库 (optional) 
            var filterType = "private";  // string | 仓库类型 (optional) 
            var role = "Reporter";  // string | 最小仓库权限，默认owner (optional) 
            var orderBy = "created_at";  // string | 排序类型，默认last_updated_at (optional) 
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)

            try
            {
                // 获取当前用户拥有指定权限及其以上权限的仓库
                List<DtoRepos4User> result = apiInstance.GetRepos(page, pageSize, search, filterType, role, orderBy, desc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取当前用户拥有指定权限及其以上权限的仓库
    ApiResponse<List<DtoRepos4User>> response = apiInstance.GetReposWithHttpInfo(page, pageSize, search, filterType, role, orderBy, desc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **search** | **string** | 过滤仓库 | [optional]  |
| **filterType** | **string** | 仓库类型 | [optional]  |
| **role** | **string** | 最小仓库权限，默认owner | [optional]  |
| **orderBy** | **string** | 排序类型，默认last_updated_at | [optional]  |
| **desc** | **bool** | 排序顺序 | [optional] [default to false] |

### Return type

[**List&lt;DtoRepos4User&gt;**](DtoRepos4User.md)

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

<a id="getreposbyusername"></a>
# **GetReposByUserName**
> List&lt;DtoRepos4User&gt; GetReposByUserName (string username, string search = null, string role = null, int page = null, int pageSize = null, bool desc = null, string orderBy = null)

获取指定用户有指定以上权限并且客人态可见的仓库

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
    public class GetReposByUserNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var username = "\"someone\"";  // string | UserName (default to "someone")
            var search = "search_example";  // string | 过滤仓库 (optional) 
            var role = "Reporter";  // string | 最小仓库权限，默认owner (optional) 
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)
            var orderBy = "created_at";  // string | 排序类型，默认last_updated_at (optional) 

            try
            {
                // 获取指定用户有指定以上权限并且客人态可见的仓库
                List<DtoRepos4User> result = apiInstance.GetReposByUserName(username, search, role, page, pageSize, desc, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetReposByUserName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetReposByUserNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户有指定以上权限并且客人态可见的仓库
    ApiResponse<List<DtoRepos4User>> response = apiInstance.GetReposByUserNameWithHttpInfo(username, search, role, page, pageSize, desc, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetReposByUserNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | UserName | [default to &quot;someone&quot;] |
| **search** | **string** | 过滤仓库 | [optional]  |
| **role** | **string** | 最小仓库权限，默认owner | [optional]  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **desc** | **bool** | 排序顺序 | [optional] [default to false] |
| **orderBy** | **string** | 排序类型，默认last_updated_at | [optional]  |

### Return type

[**List&lt;DtoRepos4User&gt;**](DtoRepos4User.md)

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

<a id="getuserallstaredrepos"></a>
# **GetUserAllStaredRepos**
> List&lt;DtoRepos4UserBase&gt; GetUserAllStaredRepos (int page = null, int pageSize = null, string search = null, bool desc = null, string orderBy = null)

获取当前用户 star 的仓库列表

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
    public class GetUserAllStaredReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var search = "search_example";  // string | 过滤仓库 (optional) 
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)
            var orderBy = "created_at";  // string | 排序类型，默认last_updated_at (optional) 

            try
            {
                // 获取当前用户 star 的仓库列表
                List<DtoRepos4UserBase> result = apiInstance.GetUserAllStaredRepos(page, pageSize, search, desc, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.GetUserAllStaredRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserAllStaredReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取当前用户 star 的仓库列表
    ApiResponse<List<DtoRepos4UserBase>> response = apiInstance.GetUserAllStaredReposWithHttpInfo(page, pageSize, search, desc, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.GetUserAllStaredReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **search** | **string** | 过滤仓库 | [optional]  |
| **desc** | **bool** | 排序顺序 | [optional] [default to false] |
| **orderBy** | **string** | 排序类型，默认last_updated_at | [optional]  |

### Return type

[**List&lt;DtoRepos4UserBase&gt;**](DtoRepos4UserBase.md)

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

<a id="listforksrepos"></a>
# **ListForksRepos**
> List&lt;DtoForks&gt; ListForksRepos (string repo, int page, int pageSize)

获取指定仓库的 fork 列表

访问令牌调用此接口需包含以下权限  repo-base-info:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListForksReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var repo = "repo_example";  // string | slug
            var page = 1;  // int | page (default to 1)
            var pageSize = 10;  // int | page (default to 10)

            try
            {
                // 获取指定仓库的 fork 列表
                List<DtoForks> result = apiInstance.ListForksRepos(repo, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.ListForksRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListForksReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定仓库的 fork 列表
    ApiResponse<List<DtoForks>> response = apiInstance.ListForksReposWithHttpInfo(repo, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.ListForksReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **page** | **int** | page | [default to 1] |
| **pageSize** | **int** | page | [default to 10] |

### Return type

[**List&lt;DtoForks&gt;**](DtoForks.md)

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

<a id="setpinnedrepobygroup"></a>
# **SetPinnedRepoByGroup**
> List&lt;DtoRepos4UserBase&gt; SetPinnedRepoByGroup (string group, List<string> request)

更新指定组织仓库墙

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
    public class SetPinnedRepoByGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var group = "group_example";  // string | slug
            var request = new List<string>(); // List<string> | repo path

            try
            {
                // 更新指定组织仓库墙
                List<DtoRepos4UserBase> result = apiInstance.SetPinnedRepoByGroup(group, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.SetPinnedRepoByGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetPinnedRepoByGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新指定组织仓库墙
    ApiResponse<List<DtoRepos4UserBase>> response = apiInstance.SetPinnedRepoByGroupWithHttpInfo(group, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.SetPinnedRepoByGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **request** | [**List&lt;string&gt;**](string.md) | repo path |  |

### Return type

[**List&lt;DtoRepos4UserBase&gt;**](DtoRepos4UserBase.md)

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

<a id="updaterepo"></a>
# **UpdateRepo**
> void UpdateRepo (string repo, DtoRepoPatch request)

更新仓库信息, 可更新的内容为: 仓库简介, 仓库站点, 仓库主题, 开源许可证

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
    public class UpdateRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepositoriesApi(config);
            var repo = "repo_example";  // string | 仓库路径
            var request = new DtoRepoPatch(); // DtoRepoPatch | 仓库信息

            try
            {
                // 更新仓库信息, 可更新的内容为: 仓库简介, 仓库站点, 仓库主题, 开源许可证
                apiInstance.UpdateRepo(repo, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepositoriesApi.UpdateRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新仓库信息, 可更新的内容为: 仓库简介, 仓库站点, 仓库主题, 开源许可证
    apiInstance.UpdateRepoWithHttpInfo(repo, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepositoriesApi.UpdateRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | 仓库路径 |  |
| **request** | [**DtoRepoPatch**](DtoRepoPatch.md) | 仓库信息 |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

