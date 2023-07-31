# MarisIT.Api.Api.SAFPSApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SAFPSFraudSearch**](SAFPSApi.md#safpsfraudsearch) | **POST** /api/v6/safpsfraudsearch | Returns fraud data for a single supplied ID or telephone or passport number.



## SAFPSFraudSearch

> ApiReturnOfSafpsDetailedSearchResponseArray SAFPSFraudSearch (SAFPSFraudSearchRequest sAFPSFraudSearchRequest = null)

Returns fraud data for a single supplied ID or telephone or passport number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SAFPSFraudSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SAFPSApi(Configuration.Default);
            var sAFPSFraudSearchRequest = new SAFPSFraudSearchRequest(); // SAFPSFraudSearchRequest |  (optional) 

            try
            {
                // Returns fraud data for a single supplied ID or telephone or passport number.
                ApiReturnOfSafpsDetailedSearchResponseArray result = apiInstance.SAFPSFraudSearch(sAFPSFraudSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SAFPSApi.SAFPSFraudSearch: " + e.Message );
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
 **sAFPSFraudSearchRequest** | [**SAFPSFraudSearchRequest**](SAFPSFraudSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfSafpsDetailedSearchResponseArray**](ApiReturnOfSafpsDetailedSearchResponseArray.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
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

