# MarisIT.Api.Api.LifeStyleAuditApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LifeStyleAudit**](LifeStyleAuditApi.md#lifestyleaudit) | **POST** /api/v6/lifestyleaudit | 



## LifeStyleAudit

> ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse LifeStyleAudit (string idNumber = null, string reference = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class LifeStyleAuditExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LifeStyleAuditApi(Configuration.Default);
            var idNumber = "idNumber_example";  // string |  (optional) 
            var reference = "reference_example";  // string |  (optional) 

            try
            {
                ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse result = apiInstance.LifeStyleAudit(idNumber, reference);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LifeStyleAuditApi.LifeStyleAudit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **idNumber** | **string**|  | [optional] 
 **reference** | **string**|  | [optional] 

### Return type

[**ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse**](ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorised |  -  |
| **403** | Forbidden |  -  |
| **400** | Validation failed |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

