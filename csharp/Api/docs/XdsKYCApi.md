# MarisIT.Api.Api.XdsKYCApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**KnowYourClientIdNumber**](XdsKYCApi.md#knowyourclientidnumber) | **POST** /api/v6/knowyourclientidnumber | Return list of KYC match on ID Number
[**KnowYourClientPassport**](XdsKYCApi.md#knowyourclientpassport) | **POST** /api/v6/knowyourclientpassport | Return list of KYC match on passport number
[**KnowYourClientResult**](XdsKYCApi.md#knowyourclientresult) | **POST** /api/v6/knowyourclientresult | KYC result on previous matched enty



## KnowYourClientIdNumber

> ApiReturnOfConsumerSearchArray KnowYourClientIdNumber (ServicesXdsKnowYourClientIdNumberRequest servicesXdsKnowYourClientIdNumberRequest = null)

Return list of KYC match on ID Number

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class KnowYourClientIdNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsKYCApi(Configuration.Default);
            var servicesXdsKnowYourClientIdNumberRequest = new ServicesXdsKnowYourClientIdNumberRequest(); // ServicesXdsKnowYourClientIdNumberRequest |  (optional) 

            try
            {
                // Return list of KYC match on ID Number
                ApiReturnOfConsumerSearchArray result = apiInstance.KnowYourClientIdNumber(servicesXdsKnowYourClientIdNumberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsKYCApi.KnowYourClientIdNumber: " + e.Message );
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
 **servicesXdsKnowYourClientIdNumberRequest** | [**ServicesXdsKnowYourClientIdNumberRequest**](ServicesXdsKnowYourClientIdNumberRequest.md)|  | [optional] 

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


## KnowYourClientPassport

> ApiReturnOfConsumerSearchArray KnowYourClientPassport (ServicesXdsKnowYourClientPassportRequest servicesXdsKnowYourClientPassportRequest = null)

Return list of KYC match on passport number

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class KnowYourClientPassportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsKYCApi(Configuration.Default);
            var servicesXdsKnowYourClientPassportRequest = new ServicesXdsKnowYourClientPassportRequest(); // ServicesXdsKnowYourClientPassportRequest |  (optional) 

            try
            {
                // Return list of KYC match on passport number
                ApiReturnOfConsumerSearchArray result = apiInstance.KnowYourClientPassport(servicesXdsKnowYourClientPassportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsKYCApi.KnowYourClientPassport: " + e.Message );
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
 **servicesXdsKnowYourClientPassportRequest** | [**ServicesXdsKnowYourClientPassportRequest**](ServicesXdsKnowYourClientPassportRequest.md)|  | [optional] 

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


## KnowYourClientResult

> ApiReturnOfXdsKYCOnline KnowYourClientResult (ReferenceRequest referenceRequest = null)

KYC result on previous matched enty

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class KnowYourClientResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsKYCApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // KYC result on previous matched enty
                ApiReturnOfXdsKYCOnline result = apiInstance.KnowYourClientResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsKYCApi.KnowYourClientResult: " + e.Message );
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

[**ApiReturnOfXdsKYCOnline**](ApiReturnOfXdsKYCOnline.md)

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

