# MarisIT.Api.Api.ITCApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ItcResult**](ITCApi.md#itcresult) | **POST** /api/v6/itcresult | Returns consumer details for on of the searches
[**ItcSearch**](ITCApi.md#itcsearch) | **POST** /api/v6/itcsearch | Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.



## ItcResult

> ApiReturnOfItcItcConsumer ItcResult (ReferenceRequest referenceRequest = null)

Returns consumer details for on of the searches

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ItcResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ITCApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns consumer details for on of the searches
                ApiReturnOfItcItcConsumer result = apiInstance.ItcResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ITCApi.ItcResult: " + e.Message );
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
 **referenceRequest** | [**ReferenceRequest**](ReferenceRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfItcItcConsumer**](ApiReturnOfItcItcConsumer.md)

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


## ItcSearch

> ApiReturnOfConsumerSearchArray ItcSearch (ItcSearchRequest itcSearchRequest = null)

Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ItcSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ITCApi(Configuration.Default);
            var itcSearchRequest = new ItcSearchRequest(); // ItcSearchRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.
                ApiReturnOfConsumerSearchArray result = apiInstance.ItcSearch(itcSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ITCApi.ItcSearch: " + e.Message );
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
 **itcSearchRequest** | [**ItcSearchRequest**](ItcSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfConsumerSearchArray**](ApiReturnOfConsumerSearchArray.md)

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

