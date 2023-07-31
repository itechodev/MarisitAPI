# MarisIT.Api.Api.WindeedLightstoneApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ErfValuation**](WindeedLightstoneApi.md#erfvaluation) | **POST** /api/v6/erfvaluation | 
[**FarmValuation**](WindeedLightstoneApi.md#farmvaluation) | **POST** /api/v6/farmvaluation | 
[**SchemeValuation**](WindeedLightstoneApi.md#schemevaluation) | **POST** /api/v6/schemevaluation | 



## ErfValuation

> ApiReturnOfWindeedValuationResponse ErfValuation (WindeedErfValuationRequest windeedErfValuationRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ErfValuationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedLightstoneApi(Configuration.Default);
            var windeedErfValuationRequest = new WindeedErfValuationRequest(); // WindeedErfValuationRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedValuationResponse result = apiInstance.ErfValuation(windeedErfValuationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedLightstoneApi.ErfValuation: " + e.Message );
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
 **windeedErfValuationRequest** | [**WindeedErfValuationRequest**](WindeedErfValuationRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfWindeedValuationResponse**](ApiReturnOfWindeedValuationResponse.md)

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


## FarmValuation

> ApiReturnOfWindeedValuationResponse FarmValuation (WindeedFarmValuationRequest windeedFarmValuationRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class FarmValuationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedLightstoneApi(Configuration.Default);
            var windeedFarmValuationRequest = new WindeedFarmValuationRequest(); // WindeedFarmValuationRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedValuationResponse result = apiInstance.FarmValuation(windeedFarmValuationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedLightstoneApi.FarmValuation: " + e.Message );
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
 **windeedFarmValuationRequest** | [**WindeedFarmValuationRequest**](WindeedFarmValuationRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfWindeedValuationResponse**](ApiReturnOfWindeedValuationResponse.md)

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


## SchemeValuation

> ApiReturnOfWindeedValuationResponse SchemeValuation (WindeedSchemaValuationRequest windeedSchemaValuationRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SchemeValuationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedLightstoneApi(Configuration.Default);
            var windeedSchemaValuationRequest = new WindeedSchemaValuationRequest(); // WindeedSchemaValuationRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedValuationResponse result = apiInstance.SchemeValuation(windeedSchemaValuationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedLightstoneApi.SchemeValuation: " + e.Message );
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
 **windeedSchemaValuationRequest** | [**WindeedSchemaValuationRequest**](WindeedSchemaValuationRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfWindeedValuationResponse**](ApiReturnOfWindeedValuationResponse.md)

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

