# CNBOpenApi.Api.ArtifactoryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePackageTag**](ArtifactoryApi.md#deletepackagetag) | **DELETE** /{slug}/-/packages/{type}/{name}/-/tag/{tag} | Delete the specific tag under specific package |
| [**DeleteRegistry**](ArtifactoryApi.md#deleteregistry) | **DELETE** /{registry} | 删除制品仓库 |
| [**DownloadQuotasByProjectName**](ArtifactoryApi.md#downloadquotasbyprojectname) | **GET** /{slug}/-/packages/{type}/-/quotas/download | Download registry quota details |
| [**GetPackage**](ArtifactoryApi.md#getpackage) | **GET** /{slug}/-/packages/{type}/{name} | Get the specific package |
| [**GetPackageTagDetail**](ArtifactoryApi.md#getpackagetagdetail) | **GET** /{slug}/-/packages/{type}/{name}/-/tag/{tag} | Get the specific tag under specific package |
| [**GetQuotaByProjectName**](ArtifactoryApi.md#getquotabyprojectname) | **GET** /{slug}/-/packages/{type}/-/quota | Get quota of specific registry |
| [**GetQuotasByProjectName**](ArtifactoryApi.md#getquotasbyprojectname) | **GET** /{slug}/-/packages/{type}/-/quotas | Get quotas of packages under one registry |
| [**HeadPackages**](ArtifactoryApi.md#headpackages) | **HEAD** /{slug}/-/packages | Head all packages |
| [**ListPackageTags**](ArtifactoryApi.md#listpackagetags) | **GET** /{slug}/-/packages/{type}/{pkgname}/-/tags | List all tags under specific package |
| [**ListPackages**](ArtifactoryApi.md#listpackages) | **GET** /{slug}/-/packages | List all packages |

<a id="deletepackagetag"></a>
# **DeletePackageTag**
> void DeletePackageTag (string slug, string type, string name, string tag)

Delete the specific tag under specific package

访问令牌调用此接口需包含以下权限  registry-package-delete:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeletePackageTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型
            var name = "name_example";  // string | 制品名称
            var tag = "tag_example";  // string | 制品标签

            try
            {
                // Delete the specific tag under specific package
                apiInstance.DeletePackageTag(slug, type, name, tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.DeletePackageTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePackageTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete the specific tag under specific package
    apiInstance.DeletePackageTagWithHttpInfo(slug, type, name, tag);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.DeletePackageTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **name** | **string** | 制品名称 |  |
| **tag** | **string** | 制品标签 |  |

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

<a id="deleteregistry"></a>
# **DeleteRegistry**
> void DeleteRegistry (string registry, string xCnbIdentityTicket = null)

删除制品仓库

访问令牌调用此接口需包含以下权限  registry-delete:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var registry = "registry_example";  // string | registry path
            var xCnbIdentityTicket = "xCnbIdentityTicket_example";  // string | 微信用户需要确认身份，第一次调用不传接口会调用失败并返回一个x-cnb-identity-ticket，第二次调用再传返回的值 (optional) 

            try
            {
                // 删除制品仓库
                apiInstance.DeleteRegistry(registry, xCnbIdentityTicket);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.DeleteRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除制品仓库
    apiInstance.DeleteRegistryWithHttpInfo(registry, xCnbIdentityTicket);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.DeleteRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registry** | **string** | registry path |  |
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

<a id="downloadquotasbyprojectname"></a>
# **DownloadQuotasByProjectName**
> List&lt;DtoQuotaRsp&gt; DownloadQuotasByProjectName (string slug, string type, int page = null, int pageSize = null, string ordering = null)

Download registry quota details

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DownloadQuotasByProjectNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型
            var page = 1;  // int | 页码，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页数量 (optional)  (default to 10)
            var ordering = "used_ascend";  // string | 排序类型 (optional) 

            try
            {
                // Download registry quota details
                List<DtoQuotaRsp> result = apiInstance.DownloadQuotasByProjectName(slug, type, page, pageSize, ordering);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.DownloadQuotasByProjectName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadQuotasByProjectNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download registry quota details
    ApiResponse<List<DtoQuotaRsp>> response = apiInstance.DownloadQuotasByProjectNameWithHttpInfo(slug, type, page, pageSize, ordering);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.DownloadQuotasByProjectNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **page** | **int** | 页码，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页数量 | [optional] [default to 10] |
| **ordering** | **string** | 排序类型 | [optional]  |

### Return type

[**List&lt;DtoQuotaRsp&gt;**](DtoQuotaRsp.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json, application/vnd.cnb.web+json, application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpackage"></a>
# **GetPackage**
> DtoPackageDetail GetPackage (string slug, string type, string name)

Get the specific package

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetPackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型
            var name = "name_example";  // string | 制品名称

            try
            {
                // Get the specific package
                DtoPackageDetail result = apiInstance.GetPackage(slug, type, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.GetPackage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPackageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the specific package
    ApiResponse<DtoPackageDetail> response = apiInstance.GetPackageWithHttpInfo(slug, type, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.GetPackageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **name** | **string** | 制品名称 |  |

### Return type

[**DtoPackageDetail**](DtoPackageDetail.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.web+json, application/vnd.cnb.api+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpackagetagdetail"></a>
# **GetPackageTagDetail**
> DtoTagDetail GetPackageTagDetail (string slug, string type, string name, string tag, string sha256 = null)

Get the specific tag under specific package

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetPackageTagDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型
            var name = "name_example";  // string | 制品名称
            var tag = "tag_example";  // string | 制品标签
            var sha256 = "sha256_example";  // string | 摘要，容器制品时必须 (optional) 

            try
            {
                // Get the specific tag under specific package
                DtoTagDetail result = apiInstance.GetPackageTagDetail(slug, type, name, tag, sha256);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.GetPackageTagDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPackageTagDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the specific tag under specific package
    ApiResponse<DtoTagDetail> response = apiInstance.GetPackageTagDetailWithHttpInfo(slug, type, name, tag, sha256);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.GetPackageTagDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **name** | **string** | 制品名称 |  |
| **tag** | **string** | 制品标签 |  |
| **sha256** | **string** | 摘要，容器制品时必须 | [optional]  |

### Return type

[**DtoTagDetail**](DtoTagDetail.md)

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

<a id="getquotabyprojectname"></a>
# **GetQuotaByProjectName**
> DtoQuotaRsp GetQuotaByProjectName (string slug, string type)

Get quota of specific registry

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetQuotaByProjectNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型

            try
            {
                // Get quota of specific registry
                DtoQuotaRsp result = apiInstance.GetQuotaByProjectName(slug, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.GetQuotaByProjectName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuotaByProjectNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get quota of specific registry
    ApiResponse<DtoQuotaRsp> response = apiInstance.GetQuotaByProjectNameWithHttpInfo(slug, type);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.GetQuotaByProjectNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |

### Return type

[**DtoQuotaRsp**](DtoQuotaRsp.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getquotasbyprojectname"></a>
# **GetQuotasByProjectName**
> List&lt;DtoQuotaRsp&gt; GetQuotasByProjectName (string slug, string type, int page = null, int pageSize = null, string ordering = null)

Get quotas of packages under one registry

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class GetQuotasByProjectNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型
            var page = 1;  // int | 页码，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页数量 (optional)  (default to 10)
            var ordering = "used_ascend";  // string | 排序类型 (optional) 

            try
            {
                // Get quotas of packages under one registry
                List<DtoQuotaRsp> result = apiInstance.GetQuotasByProjectName(slug, type, page, pageSize, ordering);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.GetQuotasByProjectName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetQuotasByProjectNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get quotas of packages under one registry
    ApiResponse<List<DtoQuotaRsp>> response = apiInstance.GetQuotasByProjectNameWithHttpInfo(slug, type, page, pageSize, ordering);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.GetQuotasByProjectNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **page** | **int** | 页码，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页数量 | [optional] [default to 10] |
| **ordering** | **string** | 排序类型 | [optional]  |

### Return type

[**List&lt;DtoQuotaRsp&gt;**](DtoQuotaRsp.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="headpackages"></a>
# **HeadPackages**
> void HeadPackages (string slug, string type, int page = null, int pageSize = null, string ordering = null, string name = null)

Head all packages

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class HeadPackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "all";  // string | 制品类型
            var page = 1;  // int | 页码，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页数量 (optional)  (default to 10)
            var ordering = "pull_count";  // string | 排序类型 (optional) 
            var name = "name_example";  // string | 制品名搜索关键词 (optional) 

            try
            {
                // Head all packages
                apiInstance.HeadPackages(slug, type, page, pageSize, ordering, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.HeadPackages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HeadPackagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Head all packages
    apiInstance.HeadPackagesWithHttpInfo(slug, type, page, pageSize, ordering, name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.HeadPackagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **page** | **int** | 页码，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页数量 | [optional] [default to 10] |
| **ordering** | **string** | 排序类型 | [optional]  |
| **name** | **string** | 制品名搜索关键词 | [optional]  |

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
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="listpackagetags"></a>
# **ListPackageTags**
> DtoTag ListPackageTags (string slug, string type, string pkgname, int page = null, int pageSize = null, string ordering = null, string name = null)

List all tags under specific package

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListPackageTagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "docker";  // string | 制品类型
            var pkgname = "pkgname_example";  // string | 制品名称
            var page = 1;  // int | 页码，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页多少条数据 (optional)  (default to 10)
            var ordering = "pull_count";  // string | 排序类型 (optional) 
            var name = "name_example";  // string | 搜索关键字 (optional) 

            try
            {
                // List all tags under specific package
                DtoTag result = apiInstance.ListPackageTags(slug, type, pkgname, page, pageSize, ordering, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.ListPackageTags: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPackageTagsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all tags under specific package
    ApiResponse<DtoTag> response = apiInstance.ListPackageTagsWithHttpInfo(slug, type, pkgname, page, pageSize, ordering, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.ListPackageTagsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **pkgname** | **string** | 制品名称 |  |
| **page** | **int** | 页码，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页多少条数据 | [optional] [default to 10] |
| **ordering** | **string** | 排序类型 | [optional]  |
| **name** | **string** | 搜索关键字 | [optional]  |

### Return type

[**DtoTag**](DtoTag.md)

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

<a id="listpackages"></a>
# **ListPackages**
> List&lt;DtoPackage&gt; ListPackages (string slug, string type, int page = null, int pageSize = null, string ordering = null, string name = null)

List all packages

访问令牌调用此接口需包含以下权限  registry-package:r

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class ListPackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ArtifactoryApi(config);
            var slug = "slug_example";  // string | 仓库 slug
            var type = "all";  // string | 制品类型
            var page = 1;  // int | 页码，从1开始 (optional)  (default to 1)
            var pageSize = 10;  // int | 每页数量 (optional)  (default to 10)
            var ordering = "pull_count";  // string | 排序类型 (optional) 
            var name = "name_example";  // string | 制品名搜索关键词 (optional) 

            try
            {
                // List all packages
                List<DtoPackage> result = apiInstance.ListPackages(slug, type, page, pageSize, ordering, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ArtifactoryApi.ListPackages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPackagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all packages
    ApiResponse<List<DtoPackage>> response = apiInstance.ListPackagesWithHttpInfo(slug, type, page, pageSize, ordering, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ArtifactoryApi.ListPackagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **slug** | **string** | 仓库 slug |  |
| **type** | **string** | 制品类型 |  |
| **page** | **int** | 页码，从1开始 | [optional] [default to 1] |
| **pageSize** | **int** | 每页数量 | [optional] [default to 10] |
| **ordering** | **string** | 排序类型 | [optional]  |
| **name** | **string** | 制品名搜索关键词 | [optional]  |

### Return type

[**List&lt;DtoPackage&gt;**](DtoPackage.md)

### Authorization

[BearerAuth](../README.md#BearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.cnb.api+json, application/vnd.cnb.web+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

