# MarisIT.Api.Api.CompuscanConsumerIndividualApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompuscanConsumerTrace**](CompuscanConsumerIndividualApi.md#compuscanconsumertrace) | **POST** /api/v6/compuscanconsumertrace | Returns the trace data of a consumer (individual).
[**CompuscanGetScore**](CompuscanConsumerIndividualApi.md#compuscangetscore) | **POST** /api/v6/compuscangetscore | Returns the credit scores of a consumer (individual).
[**CompuscanIncomeEstimate**](CompuscanConsumerIndividualApi.md#compuscanincomeestimate) | **POST** /api/v6/compuscanincomeestimate | Returns the income estimate of a consumer (individual).



## CompuscanConsumerTrace

> ApiReturnOfCompuscanContactInfoResponse CompuscanConsumerTrace (ConsumerTraceRequest consumerTraceRequest = null)

Returns the trace data of a consumer (individual).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CompuscanConsumerTraceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompuscanConsumerIndividualApi(Configuration.Default);
            var consumerTraceRequest = new ConsumerTraceRequest(); // ConsumerTraceRequest |  (optional) 

            try
            {
                // Returns the trace data of a consumer (individual).
                ApiReturnOfCompuscanContactInfoResponse result = apiInstance.CompuscanConsumerTrace(consumerTraceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CompuscanConsumerIndividualApi.CompuscanConsumerTrace: " + e.Message );
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
 **consumerTraceRequest** | [**ConsumerTraceRequest**](ConsumerTraceRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfCompuscanContactInfoResponse**](ApiReturnOfCompuscanContactInfoResponse.md)

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


## CompuscanGetScore

> ApiReturnOfCompuscanGetScoreResult CompuscanGetScore (CompuscanIdRequest compuscanIdRequest = null)

Returns the credit scores of a consumer (individual).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CompuscanGetScoreExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompuscanConsumerIndividualApi(Configuration.Default);
            var compuscanIdRequest = new CompuscanIdRequest(); // CompuscanIdRequest |  (optional) 

            try
            {
                // Returns the credit scores of a consumer (individual).
                ApiReturnOfCompuscanGetScoreResult result = apiInstance.CompuscanGetScore(compuscanIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CompuscanConsumerIndividualApi.CompuscanGetScore: " + e.Message );
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
 **compuscanIdRequest** | [**CompuscanIdRequest**](CompuscanIdRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfCompuscanGetScoreResult**](ApiReturnOfCompuscanGetScoreResult.md)

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


## CompuscanIncomeEstimate

> ApiReturnOfCompuscanIncomePredictorResponse CompuscanIncomeEstimate (CompuscanIdRequest compuscanIdRequest = null)

Returns the income estimate of a consumer (individual).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CompuscanIncomeEstimateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompuscanConsumerIndividualApi(Configuration.Default);
            var compuscanIdRequest = new CompuscanIdRequest(); // CompuscanIdRequest |  (optional) 

            try
            {
                // Returns the income estimate of a consumer (individual).
                ApiReturnOfCompuscanIncomePredictorResponse result = apiInstance.CompuscanIncomeEstimate(compuscanIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CompuscanConsumerIndividualApi.CompuscanIncomeEstimate: " + e.Message );
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
 **compuscanIdRequest** | [**CompuscanIdRequest**](CompuscanIdRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfCompuscanIncomePredictorResponse**](ApiReturnOfCompuscanIncomePredictorResponse.md)

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

