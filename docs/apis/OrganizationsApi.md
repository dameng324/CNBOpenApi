# CNBOpenApi.Api.OrganizationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrganization**](OrganizationsApi.md#createorganization) | **POST** /groups | 创建新组织 |
| [**DeleteOrganization**](OrganizationsApi.md#deleteorganization) | **DELETE** /{group} | 删除指定组织 |
| [**GetGroup**](OrganizationsApi.md#getgroup) | **GET** /{group} | 获取指定组织信息 |
| [**GetGroupSetting**](OrganizationsApi.md#getgroupsetting) | **GET** /{group}/-/settings | 获取指定组织的配置详情 |
| [**GetGroupsByUserID**](OrganizationsApi.md#getgroupsbyuserid) | **GET** /users/{username}/groups | 获取指定用户拥有权限的顶层组织列表 |
| [**ListGroups**](OrganizationsApi.md#listgroups) | **GET** /user/groups/{group} | 查询当前用户在指定组织下拥有指定权限的子组织列表 |
| [**ListSubgroups**](OrganizationsApi.md#listsubgroups) | **GET** /{group}/-/sub-groups | 获取指定组织下的子组织列表 |
| [**ListTopGroups**](OrganizationsApi.md#listtopgroups) | **GET** /user/groups | 获取当前用户拥有权限的顶层组织列表 |
| [**UpdateGroupAvatar**](OrganizationsApi.md#updategroupavatar) | **PUT** /{group}/-/avatar | 更新组织头像 URL 地址 |
| [**UpdateGroupSetting**](OrganizationsApi.md#updategroupsetting) | **PUT** /{group}/-/settings | 更新指定组织的配置, 可更新内容为: 是否对外隐藏组织成员 |
| [**UpdateOrganization**](OrganizationsApi.md#updateorganization) | **PUT** /{group} | 更新组织信息, 可更新的内容为: 组织描述, 组织展示名称, 组织网站, 组织联系邮箱 |

<a id="createorganization"></a>
# **CreateOrganization**
> void CreateOrganization (DtoCreateGroupReq request)

创建新组织

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
    public class CreateOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var request = new DtoCreateGroupReq(); // DtoCreateGroupReq | group information

            try
            {
                // 创建新组织
                apiInstance.CreateOrganization(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.CreateOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建新组织
    apiInstance.CreateOrganizationWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.CreateOrganizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**DtoCreateGroupReq**](DtoCreateGroupReq.md) | group information |  |

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

<a id="deleteorganization"></a>
# **DeleteOrganization**
> void DeleteOrganization (string group, string xCnbIdentityTicket = null)

删除指定组织

访问令牌调用此接口需包含以下权限  group-delete:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | group path
            var xCnbIdentityTicket = "xCnbIdentityTicket_example";  // string | 微信用户需要确认身份，第一次调用不传接口会调用失败并返回一个x-cnb-identity-ticket，第二次调用再传返回的值 (optional) 

            try
            {
                // 删除指定组织
                apiInstance.DeleteOrganization(group, xCnbIdentityTicket);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.DeleteOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定组织
    apiInstance.DeleteOrganizationWithHttpInfo(group, xCnbIdentityTicket);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.DeleteOrganizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | group path |  |
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

<a id="getgroup"></a>
# **GetGroup**
> DtoOrganizationAccess GetGroup (string group)

获取指定组织信息

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
    public class GetGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | group path

            try
            {
                // 获取指定组织信息
                DtoOrganizationAccess result = apiInstance.GetGroup(group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织信息
    ApiResponse<DtoOrganizationAccess> response = apiInstance.GetGroupWithHttpInfo(group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.GetGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | group path |  |

### Return type

[**DtoOrganizationAccess**](DtoOrganizationAccess.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | group |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getgroupsetting"></a>
# **GetGroupSetting**
> DtoOrganizationSettingWithParent GetGroupSetting (string group)

获取指定组织的配置详情

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
    public class GetGroupSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | group path

            try
            {
                // 获取指定组织的配置详情
                DtoOrganizationSettingWithParent result = apiInstance.GetGroupSetting(group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetGroupSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织的配置详情
    ApiResponse<DtoOrganizationSettingWithParent> response = apiInstance.GetGroupSettingWithHttpInfo(group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.GetGroupSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | group path |  |

### Return type

[**DtoOrganizationSettingWithParent**](DtoOrganizationSettingWithParent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getgroupsbyuserid"></a>
# **GetGroupsByUserID**
> DtoOrganizationUnion GetGroupsByUserID (string username, string search = null, int page = null, int pageSize = null, bool desc = null, string orderBy = null)

获取指定用户拥有权限的顶层组织列表

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
    public class GetGroupsByUserIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var username = "\"someone\"";  // string | UserName (default to "someone")
            var search = "search_example";  // string | 过滤组织 (optional) 
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)
            var orderBy = "join_time";  // string | 排序类型，默认为created_at (optional) 

            try
            {
                // 获取指定用户拥有权限的顶层组织列表
                DtoOrganizationUnion result = apiInstance.GetGroupsByUserID(username, search, page, pageSize, desc, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.GetGroupsByUserID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsByUserIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户拥有权限的顶层组织列表
    ApiResponse<DtoOrganizationUnion> response = apiInstance.GetGroupsByUserIDWithHttpInfo(username, search, page, pageSize, desc, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.GetGroupsByUserIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | UserName | [default to &quot;someone&quot;] |
| **search** | **string** | 过滤组织 | [optional]  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **desc** | **bool** | 排序顺序 | [optional] [default to false] |
| **orderBy** | **string** | 排序类型，默认为created_at | [optional]  |

### Return type

[**DtoOrganizationUnion**](DtoOrganizationUnion.md)

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

<a id="listgroups"></a>
# **ListGroups**
> List&lt;DtoOrganizationAccess&gt; ListGroups (string group, int page = null, int pageSize = null, int access = null)

查询当前用户在指定组织下拥有指定权限的子组织列表

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
    public class ListGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "\"hello\"";  // string | Group slug (default to "hello")
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var access = 56;  // int | access level (optional) 

            try
            {
                // 查询当前用户在指定组织下拥有指定权限的子组织列表
                List<DtoOrganizationAccess> result = apiInstance.ListGroups(group, page, pageSize, access);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ListGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询当前用户在指定组织下拥有指定权限的子组织列表
    ApiResponse<List<DtoOrganizationAccess>> response = apiInstance.ListGroupsWithHttpInfo(group, page, pageSize, access);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ListGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | Group slug | [default to &quot;hello&quot;] |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **access** | **int** | access level | [optional]  |

### Return type

[**List&lt;DtoOrganizationAccess&gt;**](DtoOrganizationAccess.md)

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

<a id="listsubgroups"></a>
# **ListSubgroups**
> List&lt;DtoOrganizationUnion&gt; ListSubgroups (string group, int page, int pageSize, string search = null)

获取指定组织下的子组织列表

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
    public class ListSubgroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | Slug
            var page = 1;  // int | page (default to 1)
            var pageSize = 10;  // int | page (default to 10)
            var search = "search_example";  // string | 过滤组织 (optional) 

            try
            {
                // 获取指定组织下的子组织列表
                List<DtoOrganizationUnion> result = apiInstance.ListSubgroups(group, page, pageSize, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ListSubgroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSubgroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定组织下的子组织列表
    ApiResponse<List<DtoOrganizationUnion>> response = apiInstance.ListSubgroupsWithHttpInfo(group, page, pageSize, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ListSubgroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | Slug |  |
| **page** | **int** | page | [default to 1] |
| **pageSize** | **int** | page | [default to 10] |
| **search** | **string** | 过滤组织 | [optional]  |

### Return type

[**List&lt;DtoOrganizationUnion&gt;**](DtoOrganizationUnion.md)

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

<a id="listtopgroups"></a>
# **ListTopGroups**
> List&lt;DtoOrganizationAccess&gt; ListTopGroups (int page = null, int pageSize = null, string search = null, string role = null)

获取当前用户拥有权限的顶层组织列表

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
    public class ListTopGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var search = "search_example";  // string | 过滤组织 (optional) 
            var role = "Guest";  // string | 筛选角色 (optional) 

            try
            {
                // 获取当前用户拥有权限的顶层组织列表
                List<DtoOrganizationAccess> result = apiInstance.ListTopGroups(page, pageSize, search, role);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.ListTopGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTopGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取当前用户拥有权限的顶层组织列表
    ApiResponse<List<DtoOrganizationAccess>> response = apiInstance.ListTopGroupsWithHttpInfo(page, pageSize, search, role);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.ListTopGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **search** | **string** | 过滤组织 | [optional]  |
| **role** | **string** | 筛选角色 | [optional]  |

### Return type

[**List&lt;DtoOrganizationAccess&gt;**](DtoOrganizationAccess.md)

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

<a id="updategroupavatar"></a>
# **UpdateGroupAvatar**
> void UpdateGroupAvatar (string group, DtoUpdateGroupAvatarReq request)

更新组织头像 URL 地址

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
    public class UpdateGroupAvatarExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | slug
            var request = new DtoUpdateGroupAvatarReq(); // DtoUpdateGroupAvatarReq | group avatar url to update

            try
            {
                // 更新组织头像 URL 地址
                apiInstance.UpdateGroupAvatar(group, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateGroupAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新组织头像 URL 地址
    apiInstance.UpdateGroupAvatarWithHttpInfo(group, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.UpdateGroupAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **request** | [**DtoUpdateGroupAvatarReq**](DtoUpdateGroupAvatarReq.md) | group avatar url to update |  |

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

<a id="updategroupsetting"></a>
# **UpdateGroupSetting**
> void UpdateGroupSetting (string group, DtoGroupSettingReq request)

更新指定组织的配置, 可更新内容为: 是否对外隐藏组织成员

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
    public class UpdateGroupSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | slug
            var request = new DtoGroupSettingReq(); // DtoGroupSettingReq | group information to update

            try
            {
                // 更新指定组织的配置, 可更新内容为: 是否对外隐藏组织成员
                apiInstance.UpdateGroupSetting(group, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateGroupSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新指定组织的配置, 可更新内容为: 是否对外隐藏组织成员
    apiInstance.UpdateGroupSettingWithHttpInfo(group, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.UpdateGroupSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **request** | [**DtoGroupSettingReq**](DtoGroupSettingReq.md) | group information to update |  |

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

<a id="updateorganization"></a>
# **UpdateOrganization**
> void UpdateOrganization (string group, DtoUpdateGroupReq request)

更新组织信息, 可更新的内容为: 组织描述, 组织展示名称, 组织网站, 组织联系邮箱

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
    public class UpdateOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationsApi(config);
            var group = "group_example";  // string | slug
            var request = new DtoUpdateGroupReq(); // DtoUpdateGroupReq | group information to update

            try
            {
                // 更新组织信息, 可更新的内容为: 组织描述, 组织展示名称, 组织网站, 组织联系邮箱
                apiInstance.UpdateOrganization(group, request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationsApi.UpdateOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新组织信息, 可更新的内容为: 组织描述, 组织展示名称, 组织网站, 组织联系邮箱
    apiInstance.UpdateOrganizationWithHttpInfo(group, request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationsApi.UpdateOrganizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **group** | **string** | slug |  |
| **request** | [**DtoUpdateGroupReq**](DtoUpdateGroupReq.md) | group information to update |  |

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

