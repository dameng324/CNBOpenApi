# CNBOpenApi.Api.UsersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AutoCompleteSource**](UsersApi.md#autocompletesource) | **GET** /user/autocomplete_source | 查询当前用户用户拥有指定权限的所有资源列表 |
| [**GetUserInfo**](UsersApi.md#getuserinfo) | **GET** /user | 获取指定用户的详情信息 |
| [**GetUserInfoByName**](UsersApi.md#getuserinfobyname) | **GET** /users/{username} | 获取指定用户的详情信息 |
| [**UpdateUserInfo**](UsersApi.md#updateuserinfo) | **POST** /user | 更新指定用户的详情信息, 可更新内容为: 昵称, 个人签名, 微信公众号名称, 微信公众号二维码链接, 个人网站, 个人地址, 公司名称 |

<a id="autocompletesource"></a>
# **AutoCompleteSource**
> List&lt;string&gt; AutoCompleteSource (string sourceType = null, int page = null, int pageSize = null, string search = null, string access = null)

查询当前用户用户拥有指定权限的所有资源列表

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
    public class AutoCompleteSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(config);
            var sourceType = "Group";  // string | 资源类型, 默认group (optional) 
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var search = "search_example";  // string | 过滤组织 (optional) 
            var access = "Reporter";  // string | 最小仓库权限，默认owner (optional) 

            try
            {
                // 查询当前用户用户拥有指定权限的所有资源列表
                List<string> result = apiInstance.AutoCompleteSource(sourceType, page, pageSize, search, access);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.AutoCompleteSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AutoCompleteSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询当前用户用户拥有指定权限的所有资源列表
    ApiResponse<List<string>> response = apiInstance.AutoCompleteSourceWithHttpInfo(sourceType, page, pageSize, search, access);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.AutoCompleteSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceType** | **string** | 资源类型, 默认group | [optional]  |
| **page** | **int** | 第几页，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **search** | **string** | 过滤组织 | [optional]  |
| **access** | **string** | 最小仓库权限，默认owner | [optional]  |

### Return type

**List<string>**

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

<a id="getuserinfo"></a>
# **GetUserInfo**
> DtoUsersResultForSelf GetUserInfo ()

获取指定用户的详情信息

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
    public class GetUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(config);

            try
            {
                // 获取指定用户的详情信息
                DtoUsersResultForSelf result = apiInstance.GetUserInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户的详情信息
    ApiResponse<DtoUsersResultForSelf> response = apiInstance.GetUserInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DtoUsersResultForSelf**](DtoUsersResultForSelf.md)

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

<a id="getuserinfobyname"></a>
# **GetUserInfoByName**
> DtoUsersResult GetUserInfoByName (string username)

获取指定用户的详情信息

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
    public class GetUserInfoByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(config);
            var username = "\"someone\"";  // string | User Name (default to "someone")

            try
            {
                // 获取指定用户的详情信息
                DtoUsersResult result = apiInstance.GetUserInfoByName(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserInfoByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserInfoByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户的详情信息
    ApiResponse<DtoUsersResult> response = apiInstance.GetUserInfoByNameWithHttpInfo(username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserInfoByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | User Name | [default to &quot;someone&quot;] |

### Return type

[**DtoUsersResult**](DtoUsersResult.md)

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

<a id="updateuserinfo"></a>
# **UpdateUserInfo**
> void UpdateUserInfo (HttpUpdateUserInfoPayload request)

更新指定用户的详情信息, 可更新内容为: 昵称, 个人签名, 微信公众号名称, 微信公众号二维码链接, 个人网站, 个人地址, 公司名称

访问令牌调用此接口需包含以下权限  account-profile:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class UpdateUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UsersApi(config);
            var request = new HttpUpdateUserInfoPayload(); // HttpUpdateUserInfoPayload | user info

            try
            {
                // 更新指定用户的详情信息, 可更新内容为: 昵称, 个人签名, 微信公众号名称, 微信公众号二维码链接, 个人网站, 个人地址, 公司名称
                apiInstance.UpdateUserInfo(request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新指定用户的详情信息, 可更新内容为: 昵称, 个人签名, 微信公众号名称, 微信公众号二维码链接, 个人网站, 个人地址, 公司名称
    apiInstance.UpdateUserInfoWithHttpInfo(request);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateUserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**HttpUpdateUserInfoPayload**](HttpUpdateUserInfoPayload.md) | user info |  |

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

