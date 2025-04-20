# CNBOpenApi.Api.StarringApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetUserStaredRepos**](StarringApi.md#getuserstaredrepos) | **GET** /users/{username}/stared-repos | 获取指定用户的 star 仓库列表 |
| [**ListStarUsers**](StarringApi.md#liststarusers) | **GET** /{repo}/-/stars | 获取指定仓库的star用户列表 |

<a id="getuserstaredrepos"></a>
# **GetUserStaredRepos**
> List&lt;DtoRepos4User&gt; GetUserStaredRepos (string username, string search = null, int page = null, int pageSize = null, bool desc = null, string orderBy = null)

获取指定用户的 star 仓库列表

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
    public class GetUserStaredReposExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StarringApi(config);
            var username = "\"someone\"";  // string | UserName (default to "someone")
            var search = "search_example";  // string | 过滤仓库 (optional) 
            var page = 1;  // int | 第几页，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var desc = false;  // bool | 排序顺序 (optional)  (default to false)
            var orderBy = "created_at";  // string | 排序类型，默认last_updated_at (optional) 

            try
            {
                // 获取指定用户的 star 仓库列表
                List<DtoRepos4User> result = apiInstance.GetUserStaredRepos(username, search, page, pageSize, desc, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StarringApi.GetUserStaredRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserStaredReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定用户的 star 仓库列表
    ApiResponse<List<DtoRepos4User>> response = apiInstance.GetUserStaredReposWithHttpInfo(username, search, page, pageSize, desc, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StarringApi.GetUserStaredReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | UserName | [default to &quot;someone&quot;] |
| **search** | **string** | 过滤仓库 | [optional]  |
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

<a id="liststarusers"></a>
# **ListStarUsers**
> DtoRepoStarUsers ListStarUsers (string repo, string filterType, int page, int pageSize)

获取指定仓库的star用户列表

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
    public class ListStarUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StarringApi(config);
            var repo = "repo_example";  // string | slug
            var filterType = "all";  // string | 我关注的
            var page = 1;  // int | page (default to 1)
            var pageSize = 10;  // int | page (default to 10)

            try
            {
                // 获取指定仓库的star用户列表
                DtoRepoStarUsers result = apiInstance.ListStarUsers(repo, filterType, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StarringApi.ListStarUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListStarUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取指定仓库的star用户列表
    ApiResponse<DtoRepoStarUsers> response = apiInstance.ListStarUsersWithHttpInfo(repo, filterType, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StarringApi.ListStarUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **filterType** | **string** | 我关注的 |  |
| **page** | **int** | page | [default to 1] |
| **pageSize** | **int** | page | [default to 10] |

### Return type

[**DtoRepoStarUsers**](DtoRepoStarUsers.md)

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

