# CNBOpenApi.Api.PullsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePullLabel**](PullsApi.md#deletepulllabel) | **DELETE** /{repo}/-/pulls/{number}/labels/{name} | 删除 Pull 标签 |
| [**DeletePullLabels**](PullsApi.md#deletepulllabels) | **DELETE** /{repo}/-/pulls/{number}/labels | 清空 Pull 标签 |
| [**GetPull**](PullsApi.md#getpull) | **GET** /{repo}/-/pulls/{number} | [openapi] 查询指定 Pull |
| [**ListPullComments**](PullsApi.md#listpullcomments) | **GET** /{repo}/-/pulls/{number}/comments | [openapi] 查询 Pull Comments 列表 |
| [**ListPullLabels**](PullsApi.md#listpulllabels) | **GET** /{repo}/-/pulls/{number}/labels | 查询 Pull 的标签(label) 列表 |
| [**ListPulls**](PullsApi.md#listpulls) | **GET** /{repo}/-/pulls | [openapi] 查询 Pull 列表 |
| [**ListPullsByNumbers**](PullsApi.md#listpullsbynumbers) | **GET** /{repo}/-/pull-in-batch | [openapi] 根据numbers查询 Pull 列表 |
| [**MergePull**](PullsApi.md#mergepull) | **PUT** /{repo}/-/pulls/{number}/merge | [openapi] 合并一个 Pull Request |
| [**PatchPull**](PullsApi.md#patchpull) | **PATCH** /{repo}/-/pulls/{number} | [openapi] 更新一个 Pull Request |
| [**PostPull**](PullsApi.md#postpull) | **POST** /{repo}/-/pulls | [openapi] 新增一个 Pull |
| [**PostPullComment**](PullsApi.md#postpullcomment) | **POST** /{repo}/-/pulls/{number}/comments | [openapi] 新增一个 Pull Comment |
| [**PostPullLabels**](PullsApi.md#postpulllabels) | **POST** /{repo}/-/pulls/{number}/labels | 新增 Pull 标签 |
| [**PostPullReview**](PullsApi.md#postpullreview) | **POST** /{repo}/-/pulls/{number}/reviews | 新增一次 pull request 评审 |
| [**PutPullLabels**](PullsApi.md#putpulllabels) | **PUT** /{repo}/-/pulls/{number}/labels | 设置 Pull 标签 |

<a id="deletepulllabel"></a>
# **DeletePullLabel**
> ApiLabel DeletePullLabel (string repo, int number, string name)

删除 Pull 标签

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeletePullLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var name = "name_example";  // string | label name

            try
            {
                // 删除 Pull 标签
                ApiLabel result = apiInstance.DeletePullLabel(repo, number, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.DeletePullLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePullLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除 Pull 标签
    ApiResponse<ApiLabel> response = apiInstance.DeletePullLabelWithHttpInfo(repo, number, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.DeletePullLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **name** | **string** | label name |  |

### Return type

[**ApiLabel**](ApiLabel.md)

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

<a id="deletepulllabels"></a>
# **DeletePullLabels**
> void DeletePullLabels (string repo, int number)

清空 Pull 标签

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeletePullLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number

            try
            {
                // 清空 Pull 标签
                apiInstance.DeletePullLabels(repo, number);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.DeletePullLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePullLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 清空 Pull 标签
    apiInstance.DeletePullLabelsWithHttpInfo(repo, number);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.DeletePullLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpull"></a>
# **GetPull**
> ApiPull GetPull (string repo, int number)

[openapi] 查询指定 Pull

访问令牌调用此接口需包含以下权限  repo-pr:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetPullExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | pull request number

            try
            {
                // [openapi] 查询指定 Pull
                ApiPull result = apiInstance.GetPull(repo, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.GetPull: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPullWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 查询指定 Pull
    ApiResponse<ApiPull> response = apiInstance.GetPullWithHttpInfo(repo, number);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.GetPullWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | pull request number |  |

### Return type

[**ApiPull**](ApiPull.md)

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

<a id="listpullcomments"></a>
# **ListPullComments**
> List&lt;ApiPullRequestComment&gt; ListPullComments (string repo, string number, int page = null, int pageSize = null)

[openapi] 查询 Pull Comments 列表

访问令牌调用此接口需包含以下权限  repo-notes:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListPullCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = "number_example";  // string | number
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // [openapi] 查询 Pull Comments 列表
                List<ApiPullRequestComment> result = apiInstance.ListPullComments(repo, number, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.ListPullComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPullCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 查询 Pull Comments 列表
    ApiResponse<List<ApiPullRequestComment>> response = apiInstance.ListPullCommentsWithHttpInfo(repo, number, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.ListPullCommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **string** | number |  |
| **page** | **int** | pagination page number | [optional] [default to 1] |
| **pageSize** | **int** | pagination page size | [optional] [default to 30] |

### Return type

[**List&lt;ApiPullRequestComment&gt;**](ApiPullRequestComment.md)

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

<a id="listpulllabels"></a>
# **ListPullLabels**
> List&lt;ApiLabel&gt; ListPullLabels (string repo, int number, int page = null, int pageSize = null)

查询 Pull 的标签(label) 列表

访问令牌调用此接口需包含以下权限  repo-notes:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListPullLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // 查询 Pull 的标签(label) 列表
                List<ApiLabel> result = apiInstance.ListPullLabels(repo, number, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.ListPullLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPullLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询 Pull 的标签(label) 列表
    ApiResponse<List<ApiLabel>> response = apiInstance.ListPullLabelsWithHttpInfo(repo, number, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.ListPullLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **page** | **int** | pagination page number | [optional] [default to 1] |
| **pageSize** | **int** | pagination page size | [optional] [default to 30] |

### Return type

[**List&lt;ApiLabel&gt;**](ApiLabel.md)

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

<a id="listpulls"></a>
# **ListPulls**
> List&lt;ApiPullRequest&gt; ListPulls (string repo, int page = null, int pageSize = null, string state = null, string authors = null, string reviewers = null, string assignees = null, string baseRef = null)

[openapi] 查询 Pull 列表

访问令牌调用此接口需包含以下权限  repo-pr:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListPullsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)
            var state = "\"open\"";  // string | pull state `open`，`closed`, `all` (optional)  (default to "open")
            var authors = "authors_example";  // string | pull authors name, example: 张三,李四 (optional) 
            var reviewers = "reviewers_example";  // string | pull reviewers name, example: 张三,李四; - means nobody to review (optional) 
            var assignees = "assignees_example";  // string | pull assignees name, example: 张三,李四,-; - means assign to nobody (optional) 
            var baseRef = "baseRef_example";  // string | pull base ref,  example: refs/heads/master (optional) 

            try
            {
                // [openapi] 查询 Pull 列表
                List<ApiPullRequest> result = apiInstance.ListPulls(repo, page, pageSize, state, authors, reviewers, assignees, baseRef);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.ListPulls: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPullsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 查询 Pull 列表
    ApiResponse<List<ApiPullRequest>> response = apiInstance.ListPullsWithHttpInfo(repo, page, pageSize, state, authors, reviewers, assignees, baseRef);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.ListPullsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **page** | **int** | pagination page number | [optional] [default to 1] |
| **pageSize** | **int** | pagination page size | [optional] [default to 30] |
| **state** | **string** | pull state &#x60;open&#x60;，&#x60;closed&#x60;, &#x60;all&#x60; | [optional] [default to &quot;open&quot;] |
| **authors** | **string** | pull authors name, example: 张三,李四 | [optional]  |
| **reviewers** | **string** | pull reviewers name, example: 张三,李四; - means nobody to review | [optional]  |
| **assignees** | **string** | pull assignees name, example: 张三,李四,-; - means assign to nobody | [optional]  |
| **baseRef** | **string** | pull base ref,  example: refs/heads/master | [optional]  |

### Return type

[**List&lt;ApiPullRequest&gt;**](ApiPullRequest.md)

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

<a id="listpullsbynumbers"></a>
# **ListPullsByNumbers**
> List&lt;ApiPullRequestInfo&gt; ListPullsByNumbers (string repo, List<string> n)

[openapi] 根据numbers查询 Pull 列表

访问令牌调用此接口需包含以下权限  repo-pr:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListPullsByNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var n = new List<string>(); // List<string> | pull request numbers

            try
            {
                // [openapi] 根据numbers查询 Pull 列表
                List<ApiPullRequestInfo> result = apiInstance.ListPullsByNumbers(repo, n);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.ListPullsByNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPullsByNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 根据numbers查询 Pull 列表
    ApiResponse<List<ApiPullRequestInfo>> response = apiInstance.ListPullsByNumbersWithHttpInfo(repo, n);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.ListPullsByNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **n** | [**List&lt;string&gt;**](string.md) | pull request numbers |  |

### Return type

[**List&lt;ApiPullRequestInfo&gt;**](ApiPullRequestInfo.md)

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

<a id="mergepull"></a>
# **MergePull**
> ApiMergePullResponse MergePull (string repo, int number, ApiMergePullRequest mergePullRequestForm)

[openapi] 合并一个 Pull Request

访问令牌调用此接口需包含以下权限  repo-pr:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class MergePullExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | Pull Request Number
            var mergePullRequestForm = new ApiMergePullRequest(); // ApiMergePullRequest | Merge Pull Request Form

            try
            {
                // [openapi] 合并一个 Pull Request
                ApiMergePullResponse result = apiInstance.MergePull(repo, number, mergePullRequestForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.MergePull: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MergePullWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 合并一个 Pull Request
    ApiResponse<ApiMergePullResponse> response = apiInstance.MergePullWithHttpInfo(repo, number, mergePullRequestForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.MergePullWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | Pull Request Number |  |
| **mergePullRequestForm** | [**ApiMergePullRequest**](ApiMergePullRequest.md) | Merge Pull Request Form |  |

### Return type

[**ApiMergePullResponse**](ApiMergePullResponse.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="patchpull"></a>
# **PatchPull**
> ApiPull PatchPull (string repo, int number, ApiPatchPullRequest updatePullRequestForm)

[openapi] 更新一个 Pull Request

访问令牌调用此接口需包含以下权限  repo-pr:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PatchPullExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | Pull Request Number
            var updatePullRequestForm = new ApiPatchPullRequest(); // ApiPatchPullRequest | Update Pull Request Form

            try
            {
                // [openapi] 更新一个 Pull Request
                ApiPull result = apiInstance.PatchPull(repo, number, updatePullRequestForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.PatchPull: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchPullWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 更新一个 Pull Request
    ApiResponse<ApiPull> response = apiInstance.PatchPullWithHttpInfo(repo, number, updatePullRequestForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.PatchPullWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | Pull Request Number |  |
| **updatePullRequestForm** | [**ApiPatchPullRequest**](ApiPatchPullRequest.md) | Update Pull Request Form |  |

### Return type

[**ApiPull**](ApiPull.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postpull"></a>
# **PostPull**
> ApiPull PostPull (string repo, ApiPullCreationForm postPullForm)

[openapi] 新增一个 Pull

访问令牌调用此接口需包含以下权限  repo-pr:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostPullExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var postPullForm = new ApiPullCreationForm(); // ApiPullCreationForm | Post Pull Request Form

            try
            {
                // [openapi] 新增一个 Pull
                ApiPull result = apiInstance.PostPull(repo, postPullForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.PostPull: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPullWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 新增一个 Pull
    ApiResponse<ApiPull> response = apiInstance.PostPullWithHttpInfo(repo, postPullForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.PostPullWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **postPullForm** | [**ApiPullCreationForm**](ApiPullCreationForm.md) | Post Pull Request Form |  |

### Return type

[**ApiPull**](ApiPull.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postpullcomment"></a>
# **PostPullComment**
> void PostPullComment (string repo, int number, ApiPullCommentCreationForm postPullCommentForm)

[openapi] 新增一个 Pull Comment

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostPullCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var postPullCommentForm = new ApiPullCommentCreationForm(); // ApiPullCommentCreationForm | Post Pull Request Comment Form

            try
            {
                // [openapi] 新增一个 Pull Comment
                apiInstance.PostPullComment(repo, number, postPullCommentForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.PostPullComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPullCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [openapi] 新增一个 Pull Comment
    apiInstance.PostPullCommentWithHttpInfo(repo, number, postPullCommentForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.PostPullCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **postPullCommentForm** | [**ApiPullCommentCreationForm**](ApiPullCommentCreationForm.md) | Post Pull Request Comment Form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postpulllabels"></a>
# **PostPullLabels**
> ApiLabel PostPullLabels (string repo, int number, ApiPostPullLabelsForm postPullLabelsForm)

新增 Pull 标签

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostPullLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var postPullLabelsForm = new ApiPostPullLabelsForm(); // ApiPostPullLabelsForm | Post Pull Labels Form

            try
            {
                // 新增 Pull 标签
                ApiLabel result = apiInstance.PostPullLabels(repo, number, postPullLabelsForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.PostPullLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPullLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新增 Pull 标签
    ApiResponse<ApiLabel> response = apiInstance.PostPullLabelsWithHttpInfo(repo, number, postPullLabelsForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.PostPullLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **postPullLabelsForm** | [**ApiPostPullLabelsForm**](ApiPostPullLabelsForm.md) | Post Pull Labels Form |  |

### Return type

[**ApiLabel**](ApiLabel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postpullreview"></a>
# **PostPullReview**
> void PostPullReview (string repo, int number, ApiPullReviewCreationForm postPullReviewForm)

新增一次 pull request 评审

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PostPullReviewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var postPullReviewForm = new ApiPullReviewCreationForm(); // ApiPullReviewCreationForm | Post Pull Review Form

            try
            {
                // 新增一次 pull request 评审
                apiInstance.PostPullReview(repo, number, postPullReviewForm);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.PostPullReview: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostPullReviewWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新增一次 pull request 评审
    apiInstance.PostPullReviewWithHttpInfo(repo, number, postPullReviewForm);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.PostPullReviewWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **postPullReviewForm** | [**ApiPullReviewCreationForm**](ApiPullReviewCreationForm.md) | Post Pull Review Form |  |

### Return type

void (empty response body)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="putpulllabels"></a>
# **PutPullLabels**
> ApiLabel PutPullLabels (string repo, int number, ApiPutPullLabelsForm putPullLabelsForm)

设置 Pull 标签

访问令牌调用此接口需包含以下权限  repo-notes:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class PutPullLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PullsApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var putPullLabelsForm = new ApiPutPullLabelsForm(); // ApiPutPullLabelsForm | Put Pull Labels Form

            try
            {
                // 设置 Pull 标签
                ApiLabel result = apiInstance.PutPullLabels(repo, number, putPullLabelsForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PullsApi.PutPullLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutPullLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 设置 Pull 标签
    ApiResponse<ApiLabel> response = apiInstance.PutPullLabelsWithHttpInfo(repo, number, putPullLabelsForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PullsApi.PutPullLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **putPullLabelsForm** | [**ApiPutPullLabelsForm**](ApiPutPullLabelsForm.md) | Put Pull Labels Form |  |

### Return type

[**ApiLabel**](ApiLabel.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

