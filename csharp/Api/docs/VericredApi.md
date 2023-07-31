# MarisIT.Api.Api.VericredApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VericredContactInformation**](VericredApi.md#vericredcontactinformation) | **POST** /api/v6/vericredcontactinformation | Returns contact information for a supplied ID number.
[**VericredGetEstimateIncome**](VericredApi.md#vericredgetestimateincome) | **POST** /api/v6/vericredgetestimateincome | Returns the income estimate for a supplied ID number.
[**VericredPersonalVerification**](VericredApi.md#vericredpersonalverification) | **POST** /api/v6/vericredpersonalverification | Returns personal information for a supplied ID number.



## VericredContactInformation

> ApiReturnOfVericredContactInformation VericredContactInformation (VericredVericredRequest vericredVericredRequest = null)

Returns contact information for a supplied ID number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class VericredContactInformationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VericredApi(Configuration.Default);
            var vericredVericredRequest = new VericredVericredRequest(); // VericredVericredRequest |  (optional) 

            try
            {
                // Returns contact information for a supplied ID number.
                ApiReturnOfVericredContactInformation result = apiInstance.VericredContactInformation(vericredVericredRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VericredApi.VericredContactInformation: " + e.Message );
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
 **vericredVericredRequest** | [**VericredVericredRequest**](VericredVericredRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVericredContactInformation**](ApiReturnOfVericredContactInformation.md)

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


## VericredGetEstimateIncome

> ApiReturnOfVericredIncomeEstimate VericredGetEstimateIncome (VericredVericredRequest vericredVericredRequest = null)

Returns the income estimate for a supplied ID number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class VericredGetEstimateIncomeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VericredApi(Configuration.Default);
            var vericredVericredRequest = new VericredVericredRequest(); // VericredVericredRequest |  (optional) 

            try
            {
                // Returns the income estimate for a supplied ID number.
                ApiReturnOfVericredIncomeEstimate result = apiInstance.VericredGetEstimateIncome(vericredVericredRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VericredApi.VericredGetEstimateIncome: " + e.Message );
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
 **vericredVericredRequest** | [**VericredVericredRequest**](VericredVericredRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVericredIncomeEstimate**](ApiReturnOfVericredIncomeEstimate.md)

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


## VericredPersonalVerification

> ApiReturnOfVericredPersonalVerification VericredPersonalVerification (VericredVericredRequest vericredVericredRequest = null)

Returns personal information for a supplied ID number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class VericredPersonalVerificationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VericredApi(Configuration.Default);
            var vericredVericredRequest = new VericredVericredRequest(); // VericredVericredRequest |  (optional) 

            try
            {
                // Returns personal information for a supplied ID number.
                ApiReturnOfVericredPersonalVerification result = apiInstance.VericredPersonalVerification(vericredVericredRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VericredApi.VericredPersonalVerification: " + e.Message );
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
 **vericredVericredRequest** | [**VericredVericredRequest**](VericredVericredRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVericredPersonalVerification**](ApiReturnOfVericredPersonalVerification.md)

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

