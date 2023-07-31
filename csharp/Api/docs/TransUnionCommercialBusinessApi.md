# MarisIT.Api.Api.TransUnionCommercialBusinessApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TUBusinessResult**](TransUnionCommercialBusinessApi.md#tubusinessresult) | **POST** /api/v6/tubusinessresult | Returns the business report.
[**TUBusinessSearch**](TransUnionCommercialBusinessApi.md#tubusinesssearch) | **POST** /api/v6/tubusinesssearch | Returns a list of business matches searched by name. Pass one of the references to BusinessResult.
[**TUBusinessSearchDunsRequest**](TransUnionCommercialBusinessApi.md#tubusinesssearchdunsrequest) | **POST** /api/v6/tubusinesssearchdunsrequest | Returns a list of business matches searched by duns number. Pass one of the references to BusinessResult.
[**TUBusinessSearchRegistrationRequest**](TransUnionCommercialBusinessApi.md#tubusinesssearchregistrationrequest) | **POST** /api/v6/tubusinesssearchregistrationrequest | Returns a list of business matches searched by registration number. Pass one of the references to BusinessResult.



## TUBusinessResult

> ApiReturnOfTransunionCommercialCommercialResponse TUBusinessResult (ReferenceRequest referenceRequest = null)

Returns the business report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUBusinessResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionCommercialBusinessApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns the business report.
                ApiReturnOfTransunionCommercialCommercialResponse result = apiInstance.TUBusinessResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionCommercialBusinessApi.TUBusinessResult: " + e.Message );
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

[**ApiReturnOfTransunionCommercialCommercialResponse**](ApiReturnOfTransunionCommercialCommercialResponse.md)

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


## TUBusinessSearch

> ApiReturnOfCompanySearchArray TUBusinessSearch (TransunionBusinessSearchRequest transunionBusinessSearchRequest = null)

Returns a list of business matches searched by name. Pass one of the references to BusinessResult.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUBusinessSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionCommercialBusinessApi(Configuration.Default);
            var transunionBusinessSearchRequest = new TransunionBusinessSearchRequest(); // TransunionBusinessSearchRequest |  (optional) 

            try
            {
                // Returns a list of business matches searched by name. Pass one of the references to BusinessResult.
                ApiReturnOfCompanySearchArray result = apiInstance.TUBusinessSearch(transunionBusinessSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionCommercialBusinessApi.TUBusinessSearch: " + e.Message );
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
 **transunionBusinessSearchRequest** | [**TransunionBusinessSearchRequest**](TransunionBusinessSearchRequest.md)|  | [optional] 

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


## TUBusinessSearchDunsRequest

> ApiReturnOfCompanySearchArray TUBusinessSearchDunsRequest (TransunionBusinessSearchDunsRequest transunionBusinessSearchDunsRequest = null)

Returns a list of business matches searched by duns number. Pass one of the references to BusinessResult.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUBusinessSearchDunsRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionCommercialBusinessApi(Configuration.Default);
            var transunionBusinessSearchDunsRequest = new TransunionBusinessSearchDunsRequest(); // TransunionBusinessSearchDunsRequest |  (optional) 

            try
            {
                // Returns a list of business matches searched by duns number. Pass one of the references to BusinessResult.
                ApiReturnOfCompanySearchArray result = apiInstance.TUBusinessSearchDunsRequest(transunionBusinessSearchDunsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionCommercialBusinessApi.TUBusinessSearchDunsRequest: " + e.Message );
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
 **transunionBusinessSearchDunsRequest** | [**TransunionBusinessSearchDunsRequest**](TransunionBusinessSearchDunsRequest.md)|  | [optional] 

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


## TUBusinessSearchRegistrationRequest

> ApiReturnOfCompanySearchArray TUBusinessSearchRegistrationRequest (TransunionBusinessSearchRegistrationRequest transunionBusinessSearchRegistrationRequest = null)

Returns a list of business matches searched by registration number. Pass one of the references to BusinessResult.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUBusinessSearchRegistrationRequestExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionCommercialBusinessApi(Configuration.Default);
            var transunionBusinessSearchRegistrationRequest = new TransunionBusinessSearchRegistrationRequest(); // TransunionBusinessSearchRegistrationRequest |  (optional) 

            try
            {
                // Returns a list of business matches searched by registration number. Pass one of the references to BusinessResult.
                ApiReturnOfCompanySearchArray result = apiInstance.TUBusinessSearchRegistrationRequest(transunionBusinessSearchRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionCommercialBusinessApi.TUBusinessSearchRegistrationRequest: " + e.Message );
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
 **transunionBusinessSearchRegistrationRequest** | [**TransunionBusinessSearchRegistrationRequest**](TransunionBusinessSearchRegistrationRequest.md)|  | [optional] 

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

