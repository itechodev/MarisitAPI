# MarisIT.Api.Api.VerifyApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CriminalCheck**](VerifyApi.md#criminalcheck) | **POST** /api/v6/criminalcheck | Submit a request for an individual&#39;s criminal record. You will be notified when the report is ready. Use the reference and pass to the CriminalCheckReport.
[**CriminalCheckReport**](VerifyApi.md#criminalcheckreport) | **POST** /api/v6/criminalcheckreport | 
[**DeathCertificate**](VerifyApi.md#deathcertificate) | **POST** /api/v6/deathcertificate | Submit a request for an individual&#39;s death certificate. You will be notified when the report is ready. Use the reference and pass to the DeathCertificateReport.
[**DeathCertificateReport**](VerifyApi.md#deathcertificatereport) | **POST** /api/v6/deathcertificatereport | 
[**DriversLicence**](VerifyApi.md#driverslicence) | **POST** /api/v6/driverslicence | Submit a request for an individual&#39;s drivers licences. You will be notified when the report is ready. Use the reference and pass to the DriversLicenceReport.
[**DriversLicenceReport**](VerifyApi.md#driverslicencereport) | **POST** /api/v6/driverslicencereport | 
[**MatricCertificate**](VerifyApi.md#matriccertificate) | **POST** /api/v6/matriccertificate | Submit a request for an individual&#39;s matric certificate. You will be notified when the report is ready. Use the reference and pass to the MatricCertificateReport.
[**MatricCertificateReport**](VerifyApi.md#matriccertificatereport) | **POST** /api/v6/matriccertificatereport | 



## CriminalCheck

> ApiReturnOfVerifyReferenceResponse CriminalCheck (VerifyVerifyIdRequest verifyVerifyIdRequest = null)

Submit a request for an individual's criminal record. You will be notified when the report is ready. Use the reference and pass to the CriminalCheckReport.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CriminalCheckExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var verifyVerifyIdRequest = new VerifyVerifyIdRequest(); // VerifyVerifyIdRequest |  (optional) 

            try
            {
                // Submit a request for an individual's criminal record. You will be notified when the report is ready. Use the reference and pass to the CriminalCheckReport.
                ApiReturnOfVerifyReferenceResponse result = apiInstance.CriminalCheck(verifyVerifyIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.CriminalCheck: " + e.Message );
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
 **verifyVerifyIdRequest** | [**VerifyVerifyIdRequest**](VerifyVerifyIdRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVerifyReferenceResponse**](ApiReturnOfVerifyReferenceResponse.md)

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


## CriminalCheckReport

> ApiReturnOfApiReturnOfVerifyResultsCriminalCheckResultView CriminalCheckReport (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CriminalCheckReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfVerifyResultsCriminalCheckResultView result = apiInstance.CriminalCheckReport(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.CriminalCheckReport: " + e.Message );
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

[**ApiReturnOfApiReturnOfVerifyResultsCriminalCheckResultView**](ApiReturnOfApiReturnOfVerifyResultsCriminalCheckResultView.md)

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


## DeathCertificate

> ApiReturnOfVerifyReferenceResponse DeathCertificate (VerifyVerifyIdRequest verifyVerifyIdRequest = null)

Submit a request for an individual's death certificate. You will be notified when the report is ready. Use the reference and pass to the DeathCertificateReport.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class DeathCertificateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var verifyVerifyIdRequest = new VerifyVerifyIdRequest(); // VerifyVerifyIdRequest |  (optional) 

            try
            {
                // Submit a request for an individual's death certificate. You will be notified when the report is ready. Use the reference and pass to the DeathCertificateReport.
                ApiReturnOfVerifyReferenceResponse result = apiInstance.DeathCertificate(verifyVerifyIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.DeathCertificate: " + e.Message );
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
 **verifyVerifyIdRequest** | [**VerifyVerifyIdRequest**](VerifyVerifyIdRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVerifyReferenceResponse**](ApiReturnOfVerifyReferenceResponse.md)

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


## DeathCertificateReport

> ApiReturnOfApiReturnOfVerifyResultsNoModel DeathCertificateReport (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class DeathCertificateReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfVerifyResultsNoModel result = apiInstance.DeathCertificateReport(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.DeathCertificateReport: " + e.Message );
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

[**ApiReturnOfApiReturnOfVerifyResultsNoModel**](ApiReturnOfApiReturnOfVerifyResultsNoModel.md)

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


## DriversLicence

> ApiReturnOfVerifyReferenceResponse DriversLicence (VerifyVerifyIdRequest verifyVerifyIdRequest = null)

Submit a request for an individual's drivers licences. You will be notified when the report is ready. Use the reference and pass to the DriversLicenceReport.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class DriversLicenceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var verifyVerifyIdRequest = new VerifyVerifyIdRequest(); // VerifyVerifyIdRequest |  (optional) 

            try
            {
                // Submit a request for an individual's drivers licences. You will be notified when the report is ready. Use the reference and pass to the DriversLicenceReport.
                ApiReturnOfVerifyReferenceResponse result = apiInstance.DriversLicence(verifyVerifyIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.DriversLicence: " + e.Message );
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
 **verifyVerifyIdRequest** | [**VerifyVerifyIdRequest**](VerifyVerifyIdRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVerifyReferenceResponse**](ApiReturnOfVerifyReferenceResponse.md)

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


## DriversLicenceReport

> ApiReturnOfApiReturnOfApiReturnOfVerifyResultsDriversLicenceReportView DriversLicenceReport (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class DriversLicenceReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfApiReturnOfVerifyResultsDriversLicenceReportView result = apiInstance.DriversLicenceReport(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.DriversLicenceReport: " + e.Message );
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

[**ApiReturnOfApiReturnOfApiReturnOfVerifyResultsDriversLicenceReportView**](ApiReturnOfApiReturnOfApiReturnOfVerifyResultsDriversLicenceReportView.md)

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


## MatricCertificate

> ApiReturnOfVerifyReferenceResponse MatricCertificate (VerifyMatricCertificateRequest verifyMatricCertificateRequest = null)

Submit a request for an individual's matric certificate. You will be notified when the report is ready. Use the reference and pass to the MatricCertificateReport.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class MatricCertificateExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var verifyMatricCertificateRequest = new VerifyMatricCertificateRequest(); // VerifyMatricCertificateRequest |  (optional) 

            try
            {
                // Submit a request for an individual's matric certificate. You will be notified when the report is ready. Use the reference and pass to the MatricCertificateReport.
                ApiReturnOfVerifyReferenceResponse result = apiInstance.MatricCertificate(verifyMatricCertificateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.MatricCertificate: " + e.Message );
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
 **verifyMatricCertificateRequest** | [**VerifyMatricCertificateRequest**](VerifyMatricCertificateRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfVerifyReferenceResponse**](ApiReturnOfVerifyReferenceResponse.md)

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


## MatricCertificateReport

> ApiReturnOfApiReturnOfVerifyResultsMatricVerifyView MatricCertificateReport (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class MatricCertificateReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new VerifyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfVerifyResultsMatricVerifyView result = apiInstance.MatricCertificateReport(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling VerifyApi.MatricCertificateReport: " + e.Message );
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

[**ApiReturnOfApiReturnOfVerifyResultsMatricVerifyView**](ApiReturnOfApiReturnOfVerifyResultsMatricVerifyView.md)

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

