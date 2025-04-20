# CNBOpenApi.Api.RepoContributorApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetRepoContributorTrend**](RepoContributorApi.md#getrepocontributortrend) | **GET** /{repo}/-/contributor/trend | 查询仓库贡献者前 100 名的详细趋势数据 |

<a id="getrepocontributortrend"></a>
# **GetRepoContributorTrend**
> WebRepoContribTrend GetRepoContributorTrend (string repo, int limit = null, bool excludeExternalUsers = null)

查询仓库贡献者前 100 名的详细趋势数据

访问令牌调用此接口需包含以下权限  repo-code:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetRepoContributorTrendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RepoContributorApi(config);
            var repo = "repo_example";  // string | slug
            var limit = 14;  // int | limit, 0~100 (optional)  (default to 14)
            var excludeExternalUsers = false;  // bool | exclude_external_users, true|false (optional)  (default to false)

            try
            {
                // 查询仓库贡献者前 100 名的详细趋势数据
                WebRepoContribTrend result = apiInstance.GetRepoContributorTrend(repo, limit, excludeExternalUsers);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RepoContributorApi.GetRepoContributorTrend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRepoContributorTrendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库贡献者前 100 名的详细趋势数据
    ApiResponse<WebRepoContribTrend> response = apiInstance.GetRepoContributorTrendWithHttpInfo(repo, limit, excludeExternalUsers);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RepoContributorApi.GetRepoContributorTrendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | slug |  |
| **limit** | **int** | limit, 0~100 | [optional] [default to 14] |
| **excludeExternalUsers** | **bool** | exclude_external_users, true|false | [optional] [default to false] |

### Return type

[**WebRepoContribTrend**](WebRepoContribTrend.md)

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

