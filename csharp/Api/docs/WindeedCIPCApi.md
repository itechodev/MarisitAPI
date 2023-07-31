# MarisIT.Api.Api.WindeedCIPCApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CipcCompanyResult**](WindeedCIPCApi.md#cipccompanyresult) | **POST** /api/v6/cipccompanyresult | Returns company report for one of the references.
[**CipcCompanySearch**](WindeedCIPCApi.md#cipccompanysearch) | **POST** /api/v6/cipccompanysearch | Returns a list of possible company matches by company name. Pass one of the references to the CompanyResult call to retrieve the full report.
[**CipcCompanySearchReg**](WindeedCIPCApi.md#cipccompanysearchreg) | **POST** /api/v6/cipccompanysearchreg | Returns a list of possible company matches by company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.
[**CipcDirectorResult**](WindeedCIPCApi.md#cipcdirectorresult) | **POST** /api/v6/cipcdirectorresult | Returns director report for one of the references.
[**CipcDirectorSearch**](WindeedCIPCApi.md#cipcdirectorsearch) | **POST** /api/v6/cipcdirectorsearch | Returns a list of possible director matches using personal details. Pass one of the references to the DirectorResult call to retrieve the full report.



## CipcCompanyResult

> ApiReturnOfWindeedCipcProxiesCompanyReportFlatten CipcCompanyResult (ReferenceRequest referenceRequest = null)

Returns company report for one of the references.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CipcCompanyResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedCIPCApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns company report for one of the references.
                ApiReturnOfWindeedCipcProxiesCompanyReportFlatten result = apiInstance.CipcCompanyResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedCIPCApi.CipcCompanyResult: " + e.Message );
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

[**ApiReturnOfWindeedCipcProxiesCompanyReportFlatten**](ApiReturnOfWindeedCipcProxiesCompanyReportFlatten.md)

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


## CipcCompanySearch

> ApiReturnOfCompanySearchArray CipcCompanySearch (WindeedCompanySearchByNameRequest windeedCompanySearchByNameRequest = null)

Returns a list of possible company matches by company name. Pass one of the references to the CompanyResult call to retrieve the full report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CipcCompanySearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedCIPCApi(Configuration.Default);
            var windeedCompanySearchByNameRequest = new WindeedCompanySearchByNameRequest(); // WindeedCompanySearchByNameRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches by company name. Pass one of the references to the CompanyResult call to retrieve the full report.
                ApiReturnOfCompanySearchArray result = apiInstance.CipcCompanySearch(windeedCompanySearchByNameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedCIPCApi.CipcCompanySearch: " + e.Message );
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
 **windeedCompanySearchByNameRequest** | [**WindeedCompanySearchByNameRequest**](WindeedCompanySearchByNameRequest.md)|  | [optional] 

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


## CipcCompanySearchReg

> ApiReturnOfCompanySearchArray CipcCompanySearchReg (WindeedCompanySearchByRegRequest windeedCompanySearchByRegRequest = null)

Returns a list of possible company matches by company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CipcCompanySearchRegExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedCIPCApi(Configuration.Default);
            var windeedCompanySearchByRegRequest = new WindeedCompanySearchByRegRequest(); // WindeedCompanySearchByRegRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches by company registration number. Pass one of the references to the CompanyResult call to retrieve the full report.
                ApiReturnOfCompanySearchArray result = apiInstance.CipcCompanySearchReg(windeedCompanySearchByRegRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedCIPCApi.CipcCompanySearchReg: " + e.Message );
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
 **windeedCompanySearchByRegRequest** | [**WindeedCompanySearchByRegRequest**](WindeedCompanySearchByRegRequest.md)|  | [optional] 

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


## CipcDirectorResult

> ApiReturnOfWindeedCipcProxiesJurisitcOrNaturalReportResponse CipcDirectorResult (ReferenceRequest referenceRequest = null)

Returns director report for one of the references.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CipcDirectorResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedCIPCApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns director report for one of the references.
                ApiReturnOfWindeedCipcProxiesJurisitcOrNaturalReportResponse result = apiInstance.CipcDirectorResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedCIPCApi.CipcDirectorResult: " + e.Message );
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

[**ApiReturnOfWindeedCipcProxiesJurisitcOrNaturalReportResponse**](ApiReturnOfWindeedCipcProxiesJurisitcOrNaturalReportResponse.md)

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


## CipcDirectorSearch

> ApiReturnOfDirectorSearchArray CipcDirectorSearch (WindeedDirectorSearchRequest windeedDirectorSearchRequest = null)

Returns a list of possible director matches using personal details. Pass one of the references to the DirectorResult call to retrieve the full report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CipcDirectorSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedCIPCApi(Configuration.Default);
            var windeedDirectorSearchRequest = new WindeedDirectorSearchRequest(); // WindeedDirectorSearchRequest |  (optional) 

            try
            {
                // Returns a list of possible director matches using personal details. Pass one of the references to the DirectorResult call to retrieve the full report.
                ApiReturnOfDirectorSearchArray result = apiInstance.CipcDirectorSearch(windeedDirectorSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedCIPCApi.CipcDirectorSearch: " + e.Message );
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
 **windeedDirectorSearchRequest** | [**WindeedDirectorSearchRequest**](WindeedDirectorSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfDirectorSearchArray**](ApiReturnOfDirectorSearchArray.md)

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

