# CNBOpenApi.Api.IssuesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateIssue**](IssuesApi.md#createissue) | **POST** /{repo}/-/issues | 创建一个 Issue |
| [**DeleteIssueLabel**](IssuesApi.md#deleteissuelabel) | **DELETE** /{repo}/-/issues/{number}/labels/{name} | 删除 Issue 标签 |
| [**DeleteIssueLabels**](IssuesApi.md#deleteissuelabels) | **DELETE** /{repo}/-/issues/{number}/labels | 清空 Issue 标签 |
| [**GetIssue**](IssuesApi.md#getissue) | **GET** /{repo}/-/issues/{number} | 查询指定的 Issues |
| [**GetIssueComment**](IssuesApi.md#getissuecomment) | **GET** /{repo}/-/issues/{number}/comments/{comment_id} | 获取一个 Issue Comment |
| [**ListIssueComments**](IssuesApi.md#listissuecomments) | **GET** /{repo}/-/issues/{number}/comments | 查询仓库的 Issue 评论列表 |
| [**ListIssueLabels**](IssuesApi.md#listissuelabels) | **GET** /{repo}/-/issues/{number}/labels | 查询 Issue 的标签(label) 列表 |
| [**ListIssues**](IssuesApi.md#listissues) | **GET** /{repo}/-/issues | 查询仓库的 Issues |
| [**PatchIssueComment**](IssuesApi.md#patchissuecomment) | **PATCH** /{repo}/-/issues/{number}/comments/{comment_id} | 修改一个 Issue Comment |
| [**PostIssueComment**](IssuesApi.md#postissuecomment) | **POST** /{repo}/-/issues/{number}/comments | 创建一个 Issue Comment |
| [**PostIssueLabels**](IssuesApi.md#postissuelabels) | **POST** /{repo}/-/issues/{number}/labels | 新增 Issue 标签 |
| [**PutIssueLabels**](IssuesApi.md#putissuelabels) | **PUT** /{repo}/-/issues/{number}/labels | 设置 Issue 标签 |
| [**UpdateIssue**](IssuesApi.md#updateissue) | **PATCH** /{repo}/-/issues/{number} | 更新一个 Issue |

<a id="createissue"></a>
# **CreateIssue**
> ApiIssueDetail CreateIssue (string repo, ApiPostIssueForm postIssueForm)

创建一个 Issue

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
    public class CreateIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var postIssueForm = new ApiPostIssueForm(); // ApiPostIssueForm | Post Issue Form

            try
            {
                // 创建一个 Issue
                ApiIssueDetail result = apiInstance.CreateIssue(repo, postIssueForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.CreateIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建一个 Issue
    ApiResponse<ApiIssueDetail> response = apiInstance.CreateIssueWithHttpInfo(repo, postIssueForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.CreateIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **postIssueForm** | [**ApiPostIssueForm**](ApiPostIssueForm.md) | Post Issue Form |  |

### Return type

[**ApiIssueDetail**](ApiIssueDetail.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deleteissuelabel"></a>
# **DeleteIssueLabel**
> ApiLabel DeleteIssueLabel (string repo, int number, string name)

删除 Issue 标签

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
    public class DeleteIssueLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var name = "name_example";  // string | label name

            try
            {
                // 删除 Issue 标签
                ApiLabel result = apiInstance.DeleteIssueLabel(repo, number, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.DeleteIssueLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIssueLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除 Issue 标签
    ApiResponse<ApiLabel> response = apiInstance.DeleteIssueLabelWithHttpInfo(repo, number, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.DeleteIssueLabelWithHttpInfo: " + e.Message);
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

<a id="deleteissuelabels"></a>
# **DeleteIssueLabels**
> void DeleteIssueLabels (string repo, int number)

清空 Issue 标签

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
    public class DeleteIssueLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number

            try
            {
                // 清空 Issue 标签
                apiInstance.DeleteIssueLabels(repo, number);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.DeleteIssueLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIssueLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 清空 Issue 标签
    apiInstance.DeleteIssueLabelsWithHttpInfo(repo, number);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.DeleteIssueLabelsWithHttpInfo: " + e.Message);
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

<a id="getissue"></a>
# **GetIssue**
> ApiIssueDetail GetIssue (string repo, int number)

查询指定的 Issues

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
    public class GetIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | issue number

            try
            {
                // 查询指定的 Issues
                ApiIssueDetail result = apiInstance.GetIssue(repo, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.GetIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询指定的 Issues
    ApiResponse<ApiIssueDetail> response = apiInstance.GetIssueWithHttpInfo(repo, number);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.GetIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | issue number |  |

### Return type

[**ApiIssueDetail**](ApiIssueDetail.md)

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

<a id="getissuecomment"></a>
# **GetIssueComment**
> ApiIssueComment GetIssueComment (string repo, int number, int commentId)

获取一个 Issue Comment

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
    public class GetIssueCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var commentId = 56;  // int | comment_id

            try
            {
                // 获取一个 Issue Comment
                ApiIssueComment result = apiInstance.GetIssueComment(repo, number, commentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.GetIssueComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIssueCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取一个 Issue Comment
    ApiResponse<ApiIssueComment> response = apiInstance.GetIssueCommentWithHttpInfo(repo, number, commentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.GetIssueCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **commentId** | **int** | comment_id |  |

### Return type

[**ApiIssueComment**](ApiIssueComment.md)

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

<a id="listissuecomments"></a>
# **ListIssueComments**
> List&lt;ApiIssueComment&gt; ListIssueComments (string repo, int number, int page = null, int pageSize = null)

查询仓库的 Issue 评论列表

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
    public class ListIssueCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | issue number
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // 查询仓库的 Issue 评论列表
                List<ApiIssueComment> result = apiInstance.ListIssueComments(repo, number, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.ListIssueComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIssueCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库的 Issue 评论列表
    ApiResponse<List<ApiIssueComment>> response = apiInstance.ListIssueCommentsWithHttpInfo(repo, number, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.ListIssueCommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | issue number |  |
| **page** | **int** | pagination page number | [optional] [default to 1] |
| **pageSize** | **int** | pagination page size | [optional] [default to 30] |

### Return type

[**List&lt;ApiIssueComment&gt;**](ApiIssueComment.md)

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

<a id="listissuelabels"></a>
# **ListIssueLabels**
> List&lt;ApiLabel&gt; ListIssueLabels (string repo, int number, int page = null, int pageSize = null)

查询 Issue 的标签(label) 列表

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
    public class ListIssueLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)

            try
            {
                // 查询 Issue 的标签(label) 列表
                List<ApiLabel> result = apiInstance.ListIssueLabels(repo, number, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.ListIssueLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIssueLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询 Issue 的标签(label) 列表
    ApiResponse<List<ApiLabel>> response = apiInstance.ListIssueLabelsWithHttpInfo(repo, number, page, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.ListIssueLabelsWithHttpInfo: " + e.Message);
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

<a id="listissues"></a>
# **ListIssues**
> List&lt;ApiIssue&gt; ListIssues (string repo, int page = null, int pageSize = null, string state = null, string keyword = null, string priority = null, string labels = null, string authors = null, string assignees = null, string updatedTimeBegin = null, string updatedTimeEnd = null, string orderBy = null)

查询仓库的 Issues

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
    public class ListIssuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var page = 1;  // int | pagination page number (optional)  (default to 1)
            var pageSize = 30;  // int | pagination page size (optional)  (default to 30)
            var state = "state_example";  // string | issue state open or closed (optional) 
            var keyword = "keyword_example";  // string | issue search key (optional) 
            var priority = "priority_example";  // string | issue priority example: p0,p1,p2,p3 (optional) 
            var labels = "labels_example";  // string | issue labels example: git,bug,feature (optional) 
            var authors = "authors_example";  // string | issue authors name, example: 张三,李四 (optional) 
            var assignees = "assignees_example";  // string | issue assignees name, example: 张三,李四,-; - means assign to nobody (optional) 
            var updatedTimeBegin = "updatedTimeBegin_example";  // string | issue filter update time begin  example: 2022-01-31 (optional) 
            var updatedTimeEnd = "updatedTimeEnd_example";  // string | issue filter update time end,  example: 2022-01-31 (optional) 
            var orderBy = "orderBy_example";  // string | issue order, example: created_at, -updated_at, reference_count。‘-’ prefix means descending order (optional) 

            try
            {
                // 查询仓库的 Issues
                List<ApiIssue> result = apiInstance.ListIssues(repo, page, pageSize, state, keyword, priority, labels, authors, assignees, updatedTimeBegin, updatedTimeEnd, orderBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.ListIssues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIssuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询仓库的 Issues
    ApiResponse<List<ApiIssue>> response = apiInstance.ListIssuesWithHttpInfo(repo, page, pageSize, state, keyword, priority, labels, authors, assignees, updatedTimeBegin, updatedTimeEnd, orderBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.ListIssuesWithHttpInfo: " + e.Message);
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
| **state** | **string** | issue state open or closed | [optional]  |
| **keyword** | **string** | issue search key | [optional]  |
| **priority** | **string** | issue priority example: p0,p1,p2,p3 | [optional]  |
| **labels** | **string** | issue labels example: git,bug,feature | [optional]  |
| **authors** | **string** | issue authors name, example: 张三,李四 | [optional]  |
| **assignees** | **string** | issue assignees name, example: 张三,李四,-; - means assign to nobody | [optional]  |
| **updatedTimeBegin** | **string** | issue filter update time begin  example: 2022-01-31 | [optional]  |
| **updatedTimeEnd** | **string** | issue filter update time end,  example: 2022-01-31 | [optional]  |
| **orderBy** | **string** | issue order, example: created_at, -updated_at, reference_count。‘-’ prefix means descending order | [optional]  |

### Return type

[**List&lt;ApiIssue&gt;**](ApiIssue.md)

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

<a id="patchissuecomment"></a>
# **PatchIssueComment**
> ApiIssueComment PatchIssueComment (string repo, int number, int commentId, ApiPatchIssueCommentForm patchIssueCommentForm)

修改一个 Issue Comment

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
    public class PatchIssueCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var commentId = 56;  // int | comment_id
            var patchIssueCommentForm = new ApiPatchIssueCommentForm(); // ApiPatchIssueCommentForm | Patch Issue Comment Form

            try
            {
                // 修改一个 Issue Comment
                ApiIssueComment result = apiInstance.PatchIssueComment(repo, number, commentId, patchIssueCommentForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.PatchIssueComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PatchIssueCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 修改一个 Issue Comment
    ApiResponse<ApiIssueComment> response = apiInstance.PatchIssueCommentWithHttpInfo(repo, number, commentId, patchIssueCommentForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.PatchIssueCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **commentId** | **int** | comment_id |  |
| **patchIssueCommentForm** | [**ApiPatchIssueCommentForm**](ApiPatchIssueCommentForm.md) | Patch Issue Comment Form |  |

### Return type

[**ApiIssueComment**](ApiIssueComment.md)

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

<a id="postissuecomment"></a>
# **PostIssueComment**
> ApiIssueComment PostIssueComment (string repo, int number, ApiPostIssueCommentForm postIssueCommentForm)

创建一个 Issue Comment

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
    public class PostIssueCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var postIssueCommentForm = new ApiPostIssueCommentForm(); // ApiPostIssueCommentForm | Post Issue Comment Form

            try
            {
                // 创建一个 Issue Comment
                ApiIssueComment result = apiInstance.PostIssueComment(repo, number, postIssueCommentForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.PostIssueComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostIssueCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建一个 Issue Comment
    ApiResponse<ApiIssueComment> response = apiInstance.PostIssueCommentWithHttpInfo(repo, number, postIssueCommentForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.PostIssueCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **postIssueCommentForm** | [**ApiPostIssueCommentForm**](ApiPostIssueCommentForm.md) | Post Issue Comment Form |  |

### Return type

[**ApiIssueComment**](ApiIssueComment.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postissuelabels"></a>
# **PostIssueLabels**
> ApiLabel PostIssueLabels (string repo, int number, ApiPostIssueLabelsForm postIssueLabelsForm)

新增 Issue 标签

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
    public class PostIssueLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var postIssueLabelsForm = new ApiPostIssueLabelsForm(); // ApiPostIssueLabelsForm | Post Issue Labels Form

            try
            {
                // 新增 Issue 标签
                ApiLabel result = apiInstance.PostIssueLabels(repo, number, postIssueLabelsForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.PostIssueLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostIssueLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 新增 Issue 标签
    ApiResponse<ApiLabel> response = apiInstance.PostIssueLabelsWithHttpInfo(repo, number, postIssueLabelsForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.PostIssueLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **postIssueLabelsForm** | [**ApiPostIssueLabelsForm**](ApiPostIssueLabelsForm.md) | Post Issue Labels Form |  |

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

<a id="putissuelabels"></a>
# **PutIssueLabels**
> ApiLabel PutIssueLabels (string repo, int number, ApiPutIssueLabelsForm putIssueLabelsForm)

设置 Issue 标签

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
    public class PutIssueLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | number
            var putIssueLabelsForm = new ApiPutIssueLabelsForm(); // ApiPutIssueLabelsForm | Put Issue Labels Form

            try
            {
                // 设置 Issue 标签
                ApiLabel result = apiInstance.PutIssueLabels(repo, number, putIssueLabelsForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.PutIssueLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutIssueLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 设置 Issue 标签
    ApiResponse<ApiLabel> response = apiInstance.PutIssueLabelsWithHttpInfo(repo, number, putIssueLabelsForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.PutIssueLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | number |  |
| **putIssueLabelsForm** | [**ApiPutIssueLabelsForm**](ApiPutIssueLabelsForm.md) | Put Issue Labels Form |  |

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

<a id="updateissue"></a>
# **UpdateIssue**
> ApiIssueDetail UpdateIssue (string repo, int number, ApiPatchIssueForm patchIssueForm)

更新一个 Issue

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
    public class UpdateIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var repo = "repo_example";  // string | repo
            var number = 56;  // int | issue number
            var patchIssueForm = new ApiPatchIssueForm(); // ApiPatchIssueForm | Patch Issue Form

            try
            {
                // 更新一个 Issue
                ApiIssueDetail result = apiInstance.UpdateIssue(repo, number, patchIssueForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.UpdateIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新一个 Issue
    ApiResponse<ApiIssueDetail> response = apiInstance.UpdateIssueWithHttpInfo(repo, number, patchIssueForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssuesApi.UpdateIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **repo** | **string** | repo |  |
| **number** | **int** | issue number |  |
| **patchIssueForm** | [**ApiPatchIssueForm**](ApiPatchIssueForm.md) | Patch Issue Form |  |

### Return type

[**ApiIssueDetail**](ApiIssueDetail.md)

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

