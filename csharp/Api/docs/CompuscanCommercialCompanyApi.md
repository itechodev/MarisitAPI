# MarisIT.Api.Api.CompuscanCommercialCompanyApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompuscanCompanyResult**](CompuscanCommercialCompanyApi.md#compuscancompanyresult) | **POST** /api/v6/compuscancompanyresult | Returns an embedded PDF company report.
[**CompuscanCompanySearchByName**](CompuscanCommercialCompanyApi.md#compuscancompanysearchbyname) | **POST** /api/v6/compuscancompanysearchbyname | Returns a list of possible company matches using the company name. Pass one of the references to the CompanyResult call to retrieve the full report.
[**CompuscanCompanySearchByRegistration**](CompuscanCommercialCompanyApi.md#compuscancompanysearchbyregistration) | **POST** /api/v6/compuscancompanysearchbyregistration | Returns a list of possible company matches using the company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.



## CompuscanCompanyResult

> ApiReturnOfCompuscanCompuscanCompany CompuscanCompanyResult (ReferenceRequest referenceRequest = null)

Returns an embedded PDF company report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CompuscanCompanyResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompuscanCommercialCompanyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns an embedded PDF company report.
                ApiReturnOfCompuscanCompuscanCompany result = apiInstance.CompuscanCompanyResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CompuscanCommercialCompanyApi.CompuscanCompanyResult: " + e.Message );
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

[**ApiReturnOfCompuscanCompuscanCompany**](ApiReturnOfCompuscanCompuscanCompany.md)

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


## CompuscanCompanySearchByName

> ApiReturnOfCompanySearchArray CompuscanCompanySearchByName (CompuscanCompanyNameRequest compuscanCompanyNameRequest = null)

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
    public class CompuscanCompanySearchByNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompuscanCommercialCompanyApi(Configuration.Default);
            var compuscanCompanyNameRequest = new CompuscanCompanyNameRequest(); // CompuscanCompanyNameRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using the company name. Pass one of the references to the CompanyResult call to retrieve the full report.
                ApiReturnOfCompanySearchArray result = apiInstance.CompuscanCompanySearchByName(compuscanCompanyNameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CompuscanCommercialCompanyApi.CompuscanCompanySearchByName: " + e.Message );
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
 **compuscanCompanyNameRequest** | [**CompuscanCompanyNameRequest**](CompuscanCompanyNameRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfCompanySearchArray**](ApiReturnOfCompanySearchArray.md)

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


## CompuscanCompanySearchByRegistration

> ApiReturnOfCompanySearchArray CompuscanCompanySearchByRegistration (CompuscanCompanyRegistrationRequest compuscanCompanyRegistrationRequest = null)

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
    public class CompuscanCompanySearchByRegistrationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CompuscanCommercialCompanyApi(Configuration.Default);
            var compuscanCompanyRegistrationRequest = new CompuscanCompanyRegistrationRequest(); // CompuscanCompanyRegistrationRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using the company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.
                ApiReturnOfCompanySearchArray result = apiInstance.CompuscanCompanySearchByRegistration(compuscanCompanyRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling CompuscanCommercialCompanyApi.CompuscanCompanySearchByRegistration: " + e.Message );
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
 **compuscanCompanyRegistrationRequest** | [**CompuscanCompanyRegistrationRequest**](CompuscanCompanyRegistrationRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfCompanySearchArray**](ApiReturnOfCompanySearchArray.md)

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

