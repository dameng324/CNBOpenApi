# CNBOpenApi.Api.CollaboratorsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddMembersOfGroup**](CollaboratorsApi.md#addmembersofgroup) | **POST** /{group}/-/members/{username} | 添加成员 |
| [**AddMembersOfMission**](CollaboratorsApi.md#addmembersofmission) | **POST** /{mission}/-/members/{username} | 添加成员 |
| [**AddMembersOfRegistry**](CollaboratorsApi.md#addmembersofregistry) | **POST** /{registry}/-/members/{username} | 添加成员 |
| [**AddMembersOfRepo**](CollaboratorsApi.md#addmembersofrepo) | **POST** /{repo}/-/members/{username} | 添加成员 |
| [**DeleteMembersOfGroup**](CollaboratorsApi.md#deletemembersofgroup) | **DELETE** /{group}/-/members/{username} | 删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员 |
| [**DeleteMembersOfRepo**](CollaboratorsApi.md#deletemembersofrepo) | **DELETE** /{repo}/-/members/{username} | 删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员 |
| [**DeleteOutsideCollaborators**](CollaboratorsApi.md#deleteoutsidecollaborators) | **DELETE** /{repo}/-/outside-collaborators/{username} | 删除指定仓库的外部贡献者, 包含两种场景: 1. 作为外部贡献者的用户自己退出仓库 2. 由仓库管理者移除指定的外部贡献者 |
| [**ListAllMembers**](CollaboratorsApi.md#listallmembers) | **GET** /{repo}/-/list-members | 获取指定仓库内的有效成员列表，包含继承成员 |
| [**ListInheritMembersOfGroup**](CollaboratorsApi.md#listinheritmembersofgroup) | **GET** /{group}/-/inherit-members | 获取指定组织或仓库内的继承成员 |
| [**ListInheritMembersOfRepo**](CollaboratorsApi.md#listinheritmembersofrepo) | **GET** /{repo}/-/inherit-members | 获取指定组织或仓库内的继承成员 |
| [**ListMembersOfGroup**](CollaboratorsApi.md#listmembersofgroup) | **GET** /{group}/-/members | 获取指定组织或仓库内的所有直接成员 |
| [**ListMembersOfRepo**](CollaboratorsApi.md#listmembersofrepo) | **GET** /{repo}/-/members | 获取指定组织或仓库内的所有直接成员 |
| [**ListOutsideCollaborators**](CollaboratorsApi.md#listoutsidecollaborators) | **GET** /{repo}/-/outside-collaborators | 获取指定仓库内的外部贡献者 |
| [**TopContributors**](CollaboratorsApi.md#topcontributors) | **GET** /{repo}/-/top-activity-users | 获取 top 贡献用户 |
| [**UpdateMembersOfGroup**](CollaboratorsApi.md#updatemembersofgroup) | **PUT** /{group}/-/members/{username} | 更新指定组织或仓库内的直接成员权限信息 |
| [**UpdateMembersOfRepo**](CollaboratorsApi.md#updatemembersofrepo) | **PUT** /{repo}/-/members/{username} | 更新指定组织或仓库内的直接成员权限信息 |
| [**UpdateOutsideCollaborators**](CollaboratorsApi.md#updateoutsidecollaborators) | **PUT** /{repo}/-/outside-collaborators/{username} | 更新指定仓库的外部贡献者权限信息 |

<a id="addmembersofgroup"></a>
# **AddMembersOfGroup**
> void AddMembersOfGroup (string group, string username, DtoUpdateMembersRequest request)

添加成员

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
    public class AddMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var group = "group_example";  // string | slug
            var username = "username_example";  // string | username
            var request = new DtoUpdateMembersRequest(); // DtoUpdateMembersRequest | member information

            try
            {
                // 添加成员
                apiInstance.AddMembersOfGroup(group, username, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加成员
    apiInstance.AddMembersOfGroupWithHttpInfo(group, username, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **username** | **string** | username |  |
| **request** | [**DtoUpdateMembersRequest**](DtoUpdateMembersRequest.md) | member information |  |

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

<a id="addmembersofmission"></a>
# **AddMembersOfMission**
> void AddMembersOfMission (string mission, string username, DtoUpdateMembersRequest request)

添加成员

访问令牌调用此接口需包含以下权限  mission-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class AddMembersOfMissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var mission = "mission_example";  // string | slug
            var username = "username_example";  // string | username
            var request = new DtoUpdateMembersRequest(); // DtoUpdateMembersRequest | member information

            try
            {
                // 添加成员
                apiInstance.AddMembersOfMission(mission, username, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfMission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMembersOfMissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加成员
    apiInstance.AddMembersOfMissionWithHttpInfo(mission, username, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfMissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mission** | **string** | slug |  |
| **username** | **string** | username |  |
| **request** | [**DtoUpdateMembersRequest**](DtoUpdateMembersRequest.md) | member information |  |

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

<a id="addmembersofregistry"></a>
# **AddMembersOfRegistry**
> void AddMembersOfRegistry (string registry, string username, DtoUpdateMembersRequest request)

添加成员

访问令牌调用此接口需包含以下权限  registry-manage:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class AddMembersOfRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var registry = "registry_example";  // string | slug
            var username = "username_example";  // string | username
            var request = new DtoUpdateMembersRequest(); // DtoUpdateMembersRequest | member information

            try
            {
                // 添加成员
                apiInstance.AddMembersOfRegistry(registry, username, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMembersOfRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加成员
    apiInstance.AddMembersOfRegistryWithHttpInfo(registry, username, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registry** | **string** | slug |  |
| **username** | **string** | username |  |
| **request** | [**DtoUpdateMembersRequest**](DtoUpdateMembersRequest.md) | member information |  |

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

<a id="addmembersofrepo"></a>
# **AddMembersOfRepo**
> void AddMembersOfRepo (string repo, string username, DtoUpdateMembersRequest request)

添加成员

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
    public class AddMembersOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var username = "username_example";  // string | username
            var request = new DtoUpdateMembersRequest(); // DtoUpdateMembersRequest | member information

            try
            {
                // 添加成员
                apiInstance.AddMembersOfRepo(repo, username, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddMembersOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加成员
    apiInstance.AddMembersOfRepoWithHttpInfo(repo, username, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.AddMembersOfRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **username** | **string** | username |  |
| **request** | [**DtoUpdateMembersRequest**](DtoUpdateMembersRequest.md) | member information |  |

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

<a id="deletemembersofgroup"></a>
# **DeleteMembersOfGroup**
> void DeleteMembersOfGroup (string group, string username)

删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员

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
    public class DeleteMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var group = "group_example";  // string | slug
            var username = "username_example";  // string | username

            try
            {
                // 删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员
                apiInstance.DeleteMembersOfGroup(group, username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.DeleteMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员
    apiInstance.DeleteMembersOfGroupWithHttpInfo(group, username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.DeleteMembersOfGroupWithHttpInfo: " + e.Message);
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

<a id="deletemembersofrepo"></a>
# **DeleteMembersOfRepo**
> void DeleteMembersOfRepo (string repo, string username)

删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员

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
    public class DeleteMembersOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var username = "username_example";  // string | username

            try
            {
                // 删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员
                apiInstance.DeleteMembersOfRepo(repo, username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.DeleteMembersOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMembersOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定组织或仓库的直接成员, 包含两种场景: 1. 作为直接成员的用户自己退出 2. 由管理者移除指定的直接成员
    apiInstance.DeleteMembersOfRepoWithHttpInfo(repo, username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.DeleteMembersOfRepoWithHttpInfo: " + e.Message);
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

<a id="deleteoutsidecollaborators"></a>
# **DeleteOutsideCollaborators**
> void DeleteOutsideCollaborators (string repo, string username)

删除指定仓库的外部贡献者, 包含两种场景: 1. 作为外部贡献者的用户自己退出仓库 2. 由仓库管理者移除指定的外部贡献者

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
    public class DeleteOutsideCollaboratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var username = "username_example";  // string | username

            try
            {
                // 删除指定仓库的外部贡献者, 包含两种场景: 1. 作为外部贡献者的用户自己退出仓库 2. 由仓库管理者移除指定的外部贡献者
                apiInstance.DeleteOutsideCollaborators(repo, username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.DeleteOutsideCollaborators: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOutsideCollaboratorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定仓库的外部贡献者, 包含两种场景: 1. 作为外部贡献者的用户自己退出仓库 2. 由仓库管理者移除指定的外部贡献者
    apiInstance.DeleteOutsideCollaboratorsWithHttpInfo(repo, username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.DeleteOutsideCollaboratorsWithHttpInfo: " + e.Message);
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

<a id="listallmembers"></a>
# **ListAllMembers**
> List&lt;DtoUsersWithAccessLevelInSlug&gt; ListAllMembers (string repo, int page = null, int pageSize = null, string role = null, string search = null, string names = null, string orderBy = null, bool desc = null)

获取指定仓库内的有效成员列表，包含继承成员

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
    public class ListAllMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var role = "Guest";  // string | 筛选角色 (optional) 
            var search = "search_example";  // string | 过滤成员 (optional) 
            var names = "names_example";  // string | 精准匹配用户名,多个用户名用逗号间隔 (optional) 
            var orderBy = "created_at";  // string | 排序类型，默认created_at (optional) 
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)

            try
            {
                // 获取指定仓库内的有效成员列表，包含继承成员
                List<DtoUsersWithAccessLevelInSlug> result = apiInstance.ListAllMembers(repo, page, pageSize, role, search, names, orderBy, desc);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.ListAllMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定仓库内的有效成员列表，包含继承成员
    ApiResponse<List<DtoUsersWithAccessLevelInSlug>> response = apiInstance.ListAllMembersWithHttpInfo(repo, page, pageSize, role, search, names, orderBy, desc);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.ListAllMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **role** | **string** | 筛选角色 | [optional]  |
| **search** | **string** | 过滤成员 | [optional]  |
| **names** | **string** | 精准匹配用户名,多个用户名用逗号间隔 | [optional]  |
| **orderBy** | **string** | 排序类型，默认created_at | [optional]  |
| **desc** | **bool** | 排序顺序 | [optional] [default to false] |

### Return type

[**List&lt;DtoUsersWithAccessLevelInSlug&gt;**](DtoUsersWithAccessLevelInSlug.md)

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

<a id="listinheritmembersofgroup"></a>
# **ListInheritMembersOfGroup**
> List&lt;DtoListInheritMembers&gt; ListInheritMembersOfGroup (string group, string search = null, string role = null, int page = null, int pageSize = null)

获取指定组织或仓库内的继承成员

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
    public class ListInheritMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var group = "group_example";  // string | slug
            var search = "search_example";  // string | 过滤成员 (optional) 
            var role = "Guest";  // string | 筛选角色 (optional) 
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)

            try
            {
                // 获取指定组织或仓库内的继承成员
                List<DtoListInheritMembers> result = apiInstance.ListInheritMembersOfGroup(group, search, role, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.ListInheritMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInheritMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内的继承成员
    ApiResponse<List<DtoListInheritMembers>> response = apiInstance.ListInheritMembersOfGroupWithHttpInfo(group, search, role, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.ListInheritMembersOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **search** | **string** | 过滤成员 | [optional]  |
| **role** | **string** | 筛选角色 | [optional]  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |

### Return type

[**List&lt;DtoListInheritMembers&gt;**](DtoListInheritMembers.md)

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

<a id="listinheritmembersofrepo"></a>
# **ListInheritMembersOfRepo**
> List&lt;DtoListInheritMembers&gt; ListInheritMembersOfRepo (string repo, string search = null, string role = null, int page = null, int pageSize = null)

获取指定组织或仓库内的继承成员

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
    public class ListInheritMembersOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var search = "search_example";  // string | 过滤成员 (optional) 
            var role = "Guest";  // string | 筛选角色 (optional) 
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)

            try
            {
                // 获取指定组织或仓库内的继承成员
                List<DtoListInheritMembers> result = apiInstance.ListInheritMembersOfRepo(repo, search, role, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.ListInheritMembersOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListInheritMembersOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内的继承成员
    ApiResponse<List<DtoListInheritMembers>> response = apiInstance.ListInheritMembersOfRepoWithHttpInfo(repo, search, role, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.ListInheritMembersOfRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **search** | **string** | 过滤成员 | [optional]  |
| **role** | **string** | 筛选角色 | [optional]  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |

### Return type

[**List&lt;DtoListInheritMembers&gt;**](DtoListInheritMembers.md)

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

<a id="listmembersofgroup"></a>
# **ListMembersOfGroup**
> List&lt;DtoUsersWithAccessLevelInSlug&gt; ListMembersOfGroup (string group, int page = null, int pageSize = null, string role = null, string search = null)

获取指定组织或仓库内的所有直接成员

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
    public class ListMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var group = "group_example";  // string | slug
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var role = "Guest";  // string | 筛选角色 (optional) 
            var search = "search_example";  // string | 过滤成员 (optional) 

            try
            {
                // 获取指定组织或仓库内的所有直接成员
                List<DtoUsersWithAccessLevelInSlug> result = apiInstance.ListMembersOfGroup(group, page, pageSize, role, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.ListMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内的所有直接成员
    ApiResponse<List<DtoUsersWithAccessLevelInSlug>> response = apiInstance.ListMembersOfGroupWithHttpInfo(group, page, pageSize, role, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.ListMembersOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **role** | **string** | 筛选角色 | [optional]  |
| **search** | **string** | 过滤成员 | [optional]  |

### Return type

[**List&lt;DtoUsersWithAccessLevelInSlug&gt;**](DtoUsersWithAccessLevelInSlug.md)

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

<a id="listmembersofrepo"></a>
# **ListMembersOfRepo**
> List&lt;DtoUsersWithAccessLevelInSlug&gt; ListMembersOfRepo (string repo, int page = null, int pageSize = null, string role = null, string search = null)

获取指定组织或仓库内的所有直接成员

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
    public class ListMembersOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var role = "Guest";  // string | 筛选角色 (optional) 
            var search = "search_example";  // string | 过滤成员 (optional) 

            try
            {
                // 获取指定组织或仓库内的所有直接成员
                List<DtoUsersWithAccessLevelInSlug> result = apiInstance.ListMembersOfRepo(repo, page, pageSize, role, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.ListMembersOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMembersOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织或仓库内的所有直接成员
    ApiResponse<List<DtoUsersWithAccessLevelInSlug>> response = apiInstance.ListMembersOfRepoWithHttpInfo(repo, page, pageSize, role, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.ListMembersOfRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **role** | **string** | 筛选角色 | [optional]  |
| **search** | **string** | 过滤成员 | [optional]  |

### Return type

[**List&lt;DtoUsersWithAccessLevelInSlug&gt;**](DtoUsersWithAccessLevelInSlug.md)

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

<a id="listoutsidecollaborators"></a>
# **ListOutsideCollaborators**
> List&lt;DtoOutsideCollaboratorInRepo&gt; ListOutsideCollaborators (string repo, int page = null, int pageSize = null, string role = null, string search = null)

获取指定仓库内的外部贡献者

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
    public class ListOutsideCollaboratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var role = "Guest";  // string | 筛选角色 (optional) 
            var search = "search_example";  // string | 过滤成员 (optional) 

            try
            {
                // 获取指定仓库内的外部贡献者
                List<DtoOutsideCollaboratorInRepo> result = apiInstance.ListOutsideCollaborators(repo, page, pageSize, role, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.ListOutsideCollaborators: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListOutsideCollaboratorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定仓库内的外部贡献者
    ApiResponse<List<DtoOutsideCollaboratorInRepo>> response = apiInstance.ListOutsideCollaboratorsWithHttpInfo(repo, page, pageSize, role, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.ListOutsideCollaboratorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **role** | **string** | 筛选角色 | [optional]  |
| **search** | **string** | 过滤成员 | [optional]  |

### Return type

[**List&lt;DtoOutsideCollaboratorInRepo&gt;**](DtoOutsideCollaboratorInRepo.md)

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

<a id="topcontributors"></a>
# **TopContributors**
> List&lt;DtoUsersResult&gt; TopContributors (string repo, int top = null)

获取 top 贡献用户

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
    public class TopContributorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var top = 5;  // int | top几，不要超过10 (optional)  (default to 5)

            try
            {
                // 获取 top 贡献用户
                List<DtoUsersResult> result = apiInstance.TopContributors(repo, top);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.TopContributors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TopContributorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取 top 贡献用户
    ApiResponse<List<DtoUsersResult>> response = apiInstance.TopContributorsWithHttpInfo(repo, top);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.TopContributorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **top** | **int** | top几，不要超过10 | [optional] [default to 5] |

### Return type

[**List&lt;DtoUsersResult&gt;**](DtoUsersResult.md)

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

<a id="updatemembersofgroup"></a>
# **UpdateMembersOfGroup**
> void UpdateMembersOfGroup (string group, string username, DtoUpdateMembersRequest request)

更新指定组织或仓库内的直接成员权限信息

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
    public class UpdateMembersOfGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var group = "group_example";  // string | slug
            var username = "username_example";  // string | username
            var request = new DtoUpdateMembersRequest(); // DtoUpdateMembersRequest | member information

            try
            {
                // 更新指定组织或仓库内的直接成员权限信息
                apiInstance.UpdateMembersOfGroup(group, username, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.UpdateMembersOfGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMembersOfGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新指定组织或仓库内的直接成员权限信息
    apiInstance.UpdateMembersOfGroupWithHttpInfo(group, username, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.UpdateMembersOfGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **username** | **string** | username |  |
| **request** | [**DtoUpdateMembersRequest**](DtoUpdateMembersRequest.md) | member information |  |

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

<a id="updatemembersofrepo"></a>
# **UpdateMembersOfRepo**
> void UpdateMembersOfRepo (string repo, string username, DtoUpdateMembersRequest request)

更新指定组织或仓库内的直接成员权限信息

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
    public class UpdateMembersOfRepoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var username = "username_example";  // string | username
            var request = new DtoUpdateMembersRequest(); // DtoUpdateMembersRequest | member information

            try
            {
                // 更新指定组织或仓库内的直接成员权限信息
                apiInstance.UpdateMembersOfRepo(repo, username, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.UpdateMembersOfRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMembersOfRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新指定组织或仓库内的直接成员权限信息
    apiInstance.UpdateMembersOfRepoWithHttpInfo(repo, username, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.UpdateMembersOfRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **username** | **string** | username |  |
| **request** | [**DtoUpdateMembersRequest**](DtoUpdateMembersRequest.md) | member information |  |

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

<a id="updateoutsidecollaborators"></a>
# **UpdateOutsideCollaborators**
> void UpdateOutsideCollaborators (string repo, string username, string role)

更新指定仓库的外部贡献者权限信息

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
    public class UpdateOutsideCollaboratorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CollaboratorsApi(config);
            var repo = "repo_example";  // string | slug
            var username = "username_example";  // string | username
            var role = "Guest";  // string | 用户权限

            try
            {
                // 更新指定仓库的外部贡献者权限信息
                apiInstance.UpdateOutsideCollaborators(repo, username, role);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollaboratorsApi.UpdateOutsideCollaborators: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOutsideCollaboratorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新指定仓库的外部贡献者权限信息
    apiInstance.UpdateOutsideCollaboratorsWithHttpInfo(repo, username, role);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollaboratorsApi.UpdateOutsideCollaboratorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **username** | **string** | username |  |
| **role** | **string** | 用户权限 |  |

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

