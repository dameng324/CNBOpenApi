# CNBOpenApi.Api.MissionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteMission**](MissionsApi.md#deletemission) | **DELETE** /{mission} | 删除指定任务集 |

<a id="deletemission"></a>
# **DeleteMission**
> void DeleteMission (string mission, string xCnbIdentityTicket = null)

删除指定任务集

访问令牌调用此接口需包含以下权限  mission-delete:rw

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using CNBOpenApi.Api;
using CNBOpenApi.Client;
using CNBOpenApi.Model;

namespace Example
{
    public class DeleteMissionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure API key authorization: BearerAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MissionsApi(config);
            var mission = "mission_example";  // string | mission path
            var xCnbIdentityTicket = "xCnbIdentityTicket_example";  // string | 微信用户需要确认身份，第一次调用不传接口会调用失败并返回一个x-cnb-identity-ticket，第二次调用再传返回的值 (optional) 

            try
            {
                // 删除指定任务集
                apiInstance.DeleteMission(mission, xCnbIdentityTicket);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissionsApi.DeleteMission: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteMissionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除指定任务集
    apiInstance.DeleteMissionWithHttpInfo(mission, xCnbIdentityTicket);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissionsApi.DeleteMissionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mission** | **string** | mission path |  |
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

