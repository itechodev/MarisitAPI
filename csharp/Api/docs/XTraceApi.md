# MarisIT.Api.Api.XTraceApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**XTraceResult**](XTraceApi.md#xtraceresult) | **POST** /api/v6/xtraceresult | Returns a list of possible company matches using the company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.
[**XTraceSearch**](XTraceApi.md#xtracesearch) | **POST** /api/v6/xtracesearch | Returns a list of possible company matches using the company name. Pass one of the references to the CompanyResult call to retrieve the full report.



## XTraceResult

> ApiReturnOfDatacisionServicePerson XTraceResult (ReferenceRequest referenceRequest = null)

Returns a list of possible company matches using the company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XTraceResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XTraceApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using the company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.
                ApiReturnOfDatacisionServicePerson result = apiInstance.XTraceResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XTraceApi.XTraceResult: " + e.Message );
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

[**ApiReturnOfDatacisionServicePerson**](ApiReturnOfDatacisionServicePerson.md)

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


## XTraceSearch

> ApiReturnOfConsumerSearchArray XTraceSearch (XTraceSearchRequest xTraceSearchRequest = null)

Returns a list of possible company matches using the company name. Pass one of the references to the CompanyResult call to retrieve the full report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XTraceSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XTraceApi(Configuration.Default);
            var xTraceSearchRequest = new XTraceSearchRequest(); // XTraceSearchRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using the company name. Pass one of the references to the CompanyResult call to retrieve the full report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XTraceSearch(xTraceSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XTraceApi.XTraceSearch: " + e.Message );
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
 **xTraceSearchRequest** | [**XTraceSearchRequest**](XTraceSearchRequest.md)|  | [optional] 

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

