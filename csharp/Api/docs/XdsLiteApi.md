# MarisIT.Api.Api.XdsLiteApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**XdsIdTraceLite**](XdsLiteApi.md#xdsidtracelite) | **POST** /api/v6/xdsidtracelite | Returns a list of possible consumer matches using ID number. Pass one of the references to the TraceResultLite call to retrieve the report.
[**XdsTraceResultLite**](XdsLiteApi.md#xdstraceresultlite) | **POST** /api/v6/xdstraceresultlite | The consumer data using a reference number obtained from one of the trace lite search calls.



## XdsIdTraceLite

> ApiReturnOfConsumerSearchArray XdsIdTraceLite (XdsTraceIdRequest xdsTraceIdRequest = null)

Returns a list of possible consumer matches using ID number. Pass one of the references to the TraceResultLite call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsIdTraceLiteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsLiteApi(Configuration.Default);
            var xdsTraceIdRequest = new XdsTraceIdRequest(); // XdsTraceIdRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using ID number. Pass one of the references to the TraceResultLite call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsIdTraceLite(xdsTraceIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsLiteApi.XdsIdTraceLite: " + e.Message );
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
 **xdsTraceIdRequest** | [**XdsTraceIdRequest**](XdsTraceIdRequest.md)|  | [optional] 

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


## XdsTraceResultLite

> ApiReturnOfXdsConsumerLite XdsTraceResultLite (ReferenceRequest referenceRequest = null)

The consumer data using a reference number obtained from one of the trace lite search calls.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsTraceResultLiteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsLiteApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // The consumer data using a reference number obtained from one of the trace lite search calls.
                ApiReturnOfXdsConsumerLite result = apiInstance.XdsTraceResultLite(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsLiteApi.XdsTraceResultLite: " + e.Message );
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

[**ApiReturnOfXdsConsumerLite**](ApiReturnOfXdsConsumerLite.md)

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

