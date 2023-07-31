# MarisIT.Api.Api.XdsConsumerIndividualApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DirectorList**](XdsConsumerIndividualApi.md#directorlist) | **POST** /api/v6/directorlist | Returns a list of possible consumer matches using ID number, firstname, surname. Pass one of the references to the DirectorResult call to retrieve the report.
[**DirectorResult**](XdsConsumerIndividualApi.md#directorresult) | **POST** /api/v6/directorresult | Returns the report for director/principal details.
[**IDVerificationRealTime**](XdsConsumerIndividualApi.md#idverificationrealtime) | **POST** /api/v6/idverificationrealtime | Returns identification details of an individual.
[**LinkageResult**](XdsConsumerIndividualApi.md#linkageresult) | **POST** /api/v6/linkageresult | Returns a consumer report with possible data matches;
[**LinkageSearch**](XdsConsumerIndividualApi.md#linkagesearch) | **POST** /api/v6/linkagesearch | Returns 2 sets of possible matches for. Return a reference from each set to the LinkageResult;
[**MaritalStatusRealTime**](XdsConsumerIndividualApi.md#maritalstatusrealtime) | **POST** /api/v6/maritalstatusrealtime | Returns the marital status of an individual.
[**XdsAccountTrace**](XdsConsumerIndividualApi.md#xdsaccounttrace) | **POST** /api/v6/xdsaccounttrace | Returns a list of possible consumer matches using account data. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsBankAccountIndividualById**](XdsConsumerIndividualApi.md#xdsbankaccountindividualbyid) | **POST** /api/v6/xdsbankaccountindividualbyid | Returns bank account verification data for individual.
[**XdsBankAccountIndividualByPassport**](XdsConsumerIndividualApi.md#xdsbankaccountindividualbypassport) | **POST** /api/v6/xdsbankaccountindividualbypassport | Returns bank account verification data for individual.
[**XdsBiometricList**](XdsConsumerIndividualApi.md#xdsbiometriclist) | **POST** /api/v6/xdsbiometriclist | Return a list of consumers by ID Numbers for Biometric data including ID photo.
[**XdsBiometricResult**](XdsConsumerIndividualApi.md#xdsbiometricresult) | **POST** /api/v6/xdsbiometricresult | Submit reference number from XdsBiometricList call and optional fingerprint data for verification.  Returns biometric data including ID photo&#39;s.
[**XdsConsumerCreditEnquiry**](XdsConsumerIndividualApi.md#xdsconsumercreditenquiry) | **POST** /api/v6/xdsconsumercreditenquiry | Returns a list of possible consumer matches using Id number. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsConsumerCreditEnquiryNames**](XdsConsumerIndividualApi.md#xdsconsumercreditenquirynames) | **POST** /api/v6/xdsconsumercreditenquirynames | Returns a list of possible consumer matches using names Pass one of the references to the TraceResult call to retrieve the report.
[**XdsConsumerCreditEnquiryPassport**](XdsConsumerIndividualApi.md#xdsconsumercreditenquirypassport) | **POST** /api/v6/xdsconsumercreditenquirypassport | Returns a list of possible consumer matches using passport. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsEasyTrace**](XdsConsumerIndividualApi.md#xdseasytrace) | **POST** /api/v6/xdseasytrace | Returns a list of possible consumer matches using consumer data. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsGetBonusSegments**](XdsConsumerIndividualApi.md#xdsgetbonussegments) | **POST** /api/v6/xdsgetbonussegments | Return bonus segments available for one of the trace search results
[**XdsIdTrace**](XdsConsumerIndividualApi.md#xdsidtrace) | **POST** /api/v6/xdsidtrace | Returns a list of possible consumer matches using ID number. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsPostalAddress**](XdsConsumerIndividualApi.md#xdspostaladdress) | **POST** /api/v6/xdspostaladdress | Returns a list of possible consumer matches using postal address. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsStreetTrace**](XdsConsumerIndividualApi.md#xdsstreettrace) | **POST** /api/v6/xdsstreettrace | Returns a list of possible consumer matches using street address. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsTelephoneToID**](XdsConsumerIndividualApi.md#xdstelephonetoid) | **POST** /api/v6/xdstelephonetoid | Returns a list of possible consumers with ID numbers searching by telephone only.
[**XdsTelephoneTrace**](XdsConsumerIndividualApi.md#xdstelephonetrace) | **POST** /api/v6/xdstelephonetrace | Returns a list of possible consumer matches using telephone and surname. Pass one of the references to the TraceResult call to retrieve the report.
[**XdsTraceResult**](XdsConsumerIndividualApi.md#xdstraceresult) | **POST** /api/v6/xdstraceresult | The consumer data using a reference number obtained from one of the trace search calls.



## DirectorList

> ApiReturnOfConsumerSearchArray DirectorList (XdsDirectorMatchRequest xdsDirectorMatchRequest = null)

Returns a list of possible consumer matches using ID number, firstname, surname. Pass one of the references to the DirectorResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class DirectorListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsDirectorMatchRequest = new XdsDirectorMatchRequest(); // XdsDirectorMatchRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using ID number, firstname, surname. Pass one of the references to the DirectorResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.DirectorList(xdsDirectorMatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.DirectorList: " + e.Message );
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
 **xdsDirectorMatchRequest** | [**XdsDirectorMatchRequest**](XdsDirectorMatchRequest.md)|  | [optional] 

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


## DirectorResult

> ApiReturnOfXdsDirector DirectorResult (ReferenceRequest referenceRequest = null)

Returns the report for director/principal details.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class DirectorResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns the report for director/principal details.
                ApiReturnOfXdsDirector result = apiInstance.DirectorResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.DirectorResult: " + e.Message );
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

[**ApiReturnOfXdsDirector**](ApiReturnOfXdsDirector.md)

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


## IDVerificationRealTime

> ApiReturnOfXdsHomeAffairs IDVerificationRealTime (XdsIDVerificationRequest xdsIDVerificationRequest = null)

Returns identification details of an individual.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class IDVerificationRealTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsIDVerificationRequest = new XdsIDVerificationRequest(); // XdsIDVerificationRequest |  (optional) 

            try
            {
                // Returns identification details of an individual.
                ApiReturnOfXdsHomeAffairs result = apiInstance.IDVerificationRealTime(xdsIDVerificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.IDVerificationRealTime: " + e.Message );
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
 **xdsIDVerificationRequest** | [**XdsIDVerificationRequest**](XdsIDVerificationRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsHomeAffairs**](ApiReturnOfXdsHomeAffairs.md)

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


## LinkageResult

> ApiReturnOfXdsLinkage LinkageResult (XdsLinkageReportRequest xdsLinkageReportRequest = null)

Returns a consumer report with possible data matches;

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class LinkageResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsLinkageReportRequest = new XdsLinkageReportRequest(); // XdsLinkageReportRequest |  (optional) 

            try
            {
                // Returns a consumer report with possible data matches;
                ApiReturnOfXdsLinkage result = apiInstance.LinkageResult(xdsLinkageReportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.LinkageResult: " + e.Message );
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
 **xdsLinkageReportRequest** | [**XdsLinkageReportRequest**](XdsLinkageReportRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsLinkage**](ApiReturnOfXdsLinkage.md)

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


## LinkageSearch

> ApiReturnOfXdsLinkageSearch LinkageSearch (XdsLinkageSearchRequest xdsLinkageSearchRequest = null)

Returns 2 sets of possible matches for. Return a reference from each set to the LinkageResult;

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class LinkageSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsLinkageSearchRequest = new XdsLinkageSearchRequest(); // XdsLinkageSearchRequest |  (optional) 

            try
            {
                // Returns 2 sets of possible matches for. Return a reference from each set to the LinkageResult;
                ApiReturnOfXdsLinkageSearch result = apiInstance.LinkageSearch(xdsLinkageSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.LinkageSearch: " + e.Message );
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
 **xdsLinkageSearchRequest** | [**XdsLinkageSearchRequest**](XdsLinkageSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsLinkageSearch**](ApiReturnOfXdsLinkageSearch.md)

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


## MaritalStatusRealTime

> ApiReturnOfXdsHomeAffairs MaritalStatusRealTime (XdsMaritalStatusRequest xdsMaritalStatusRequest = null)

Returns the marital status of an individual.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class MaritalStatusRealTimeExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsMaritalStatusRequest = new XdsMaritalStatusRequest(); // XdsMaritalStatusRequest |  (optional) 

            try
            {
                // Returns the marital status of an individual.
                ApiReturnOfXdsHomeAffairs result = apiInstance.MaritalStatusRealTime(xdsMaritalStatusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.MaritalStatusRealTime: " + e.Message );
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
 **xdsMaritalStatusRequest** | [**XdsMaritalStatusRequest**](XdsMaritalStatusRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsHomeAffairs**](ApiReturnOfXdsHomeAffairs.md)

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


## XdsAccountTrace

> ApiReturnOfConsumerSearchArray XdsAccountTrace (XdsAccountTraceRequest xdsAccountTraceRequest = null)

Returns a list of possible consumer matches using account data. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsAccountTraceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsAccountTraceRequest = new XdsAccountTraceRequest(); // XdsAccountTraceRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using account data. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsAccountTrace(xdsAccountTraceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsAccountTrace: " + e.Message );
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
 **xdsAccountTraceRequest** | [**XdsAccountTraceRequest**](XdsAccountTraceRequest.md)|  | [optional] 

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


## XdsBankAccountIndividualById

> ApiReturnOfXdsAccountVerificationResult XdsBankAccountIndividualById (XdsBankVerificationIDRequest xdsBankVerificationIDRequest = null)

Returns bank account verification data for individual.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBankAccountIndividualByIdExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsBankVerificationIDRequest = new XdsBankVerificationIDRequest(); // XdsBankVerificationIDRequest |  (optional) 

            try
            {
                // Returns bank account verification data for individual.
                ApiReturnOfXdsAccountVerificationResult result = apiInstance.XdsBankAccountIndividualById(xdsBankVerificationIDRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsBankAccountIndividualById: " + e.Message );
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
 **xdsBankVerificationIDRequest** | [**XdsBankVerificationIDRequest**](XdsBankVerificationIDRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsAccountVerificationResult**](ApiReturnOfXdsAccountVerificationResult.md)

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


## XdsBankAccountIndividualByPassport

> ApiReturnOfXdsAccountVerificationResult XdsBankAccountIndividualByPassport (XdsBankVerificationPassportRequest xdsBankVerificationPassportRequest = null)

Returns bank account verification data for individual.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBankAccountIndividualByPassportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsBankVerificationPassportRequest = new XdsBankVerificationPassportRequest(); // XdsBankVerificationPassportRequest |  (optional) 

            try
            {
                // Returns bank account verification data for individual.
                ApiReturnOfXdsAccountVerificationResult result = apiInstance.XdsBankAccountIndividualByPassport(xdsBankVerificationPassportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsBankAccountIndividualByPassport: " + e.Message );
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
 **xdsBankVerificationPassportRequest** | [**XdsBankVerificationPassportRequest**](XdsBankVerificationPassportRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsAccountVerificationResult**](ApiReturnOfXdsAccountVerificationResult.md)

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


## XdsBiometricList

> ApiReturnOfConsumerSearchArray XdsBiometricList (XdsBiometricSearchRequest xdsBiometricSearchRequest = null)

Return a list of consumers by ID Numbers for Biometric data including ID photo.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBiometricListExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsBiometricSearchRequest = new XdsBiometricSearchRequest(); // XdsBiometricSearchRequest |  (optional) 

            try
            {
                // Return a list of consumers by ID Numbers for Biometric data including ID photo.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsBiometricList(xdsBiometricSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsBiometricList: " + e.Message );
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
 **xdsBiometricSearchRequest** | [**XdsBiometricSearchRequest**](XdsBiometricSearchRequest.md)|  | [optional] 

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


## XdsBiometricResult

> ApiReturnOfXdsHomeAffairs XdsBiometricResult (XdsBiometricResultRequest xdsBiometricResultRequest = null)

Submit reference number from XdsBiometricList call and optional fingerprint data for verification.  Returns biometric data including ID photo's.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBiometricResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsBiometricResultRequest = new XdsBiometricResultRequest(); // XdsBiometricResultRequest |  (optional) 

            try
            {
                // Submit reference number from XdsBiometricList call and optional fingerprint data for verification.  Returns biometric data including ID photo's.
                ApiReturnOfXdsHomeAffairs result = apiInstance.XdsBiometricResult(xdsBiometricResultRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsBiometricResult: " + e.Message );
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
 **xdsBiometricResultRequest** | [**XdsBiometricResultRequest**](XdsBiometricResultRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsHomeAffairs**](ApiReturnOfXdsHomeAffairs.md)

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


## XdsConsumerCreditEnquiry

> ApiReturnOfConsumerSearchArray XdsConsumerCreditEnquiry (XdsConsumerCreditEnquiryIdRequest xdsConsumerCreditEnquiryIdRequest = null)

Returns a list of possible consumer matches using Id number. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsConsumerCreditEnquiryExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsConsumerCreditEnquiryIdRequest = new XdsConsumerCreditEnquiryIdRequest(); // XdsConsumerCreditEnquiryIdRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using Id number. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsConsumerCreditEnquiry(xdsConsumerCreditEnquiryIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsConsumerCreditEnquiry: " + e.Message );
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
 **xdsConsumerCreditEnquiryIdRequest** | [**XdsConsumerCreditEnquiryIdRequest**](XdsConsumerCreditEnquiryIdRequest.md)|  | [optional] 

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


## XdsConsumerCreditEnquiryNames

> ApiReturnOfConsumerSearchArray XdsConsumerCreditEnquiryNames (XdsConsumerCreditEnquiryNamesRequest xdsConsumerCreditEnquiryNamesRequest = null)

Returns a list of possible consumer matches using names Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsConsumerCreditEnquiryNamesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsConsumerCreditEnquiryNamesRequest = new XdsConsumerCreditEnquiryNamesRequest(); // XdsConsumerCreditEnquiryNamesRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using names Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsConsumerCreditEnquiryNames(xdsConsumerCreditEnquiryNamesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsConsumerCreditEnquiryNames: " + e.Message );
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
 **xdsConsumerCreditEnquiryNamesRequest** | [**XdsConsumerCreditEnquiryNamesRequest**](XdsConsumerCreditEnquiryNamesRequest.md)|  | [optional] 

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


## XdsConsumerCreditEnquiryPassport

> ApiReturnOfConsumerSearchArray XdsConsumerCreditEnquiryPassport (XdsConsumerCreditEnquiryPassportRequest xdsConsumerCreditEnquiryPassportRequest = null)

Returns a list of possible consumer matches using passport. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsConsumerCreditEnquiryPassportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsConsumerCreditEnquiryPassportRequest = new XdsConsumerCreditEnquiryPassportRequest(); // XdsConsumerCreditEnquiryPassportRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using passport. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsConsumerCreditEnquiryPassport(xdsConsumerCreditEnquiryPassportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsConsumerCreditEnquiryPassport: " + e.Message );
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
 **xdsConsumerCreditEnquiryPassportRequest** | [**XdsConsumerCreditEnquiryPassportRequest**](XdsConsumerCreditEnquiryPassportRequest.md)|  | [optional] 

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


## XdsEasyTrace

> ApiReturnOfConsumerSearchArray XdsEasyTrace (XdsEasyTraceRequest xdsEasyTraceRequest = null)

Returns a list of possible consumer matches using consumer data. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsEasyTraceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsEasyTraceRequest = new XdsEasyTraceRequest(); // XdsEasyTraceRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using consumer data. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsEasyTrace(xdsEasyTraceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsEasyTrace: " + e.Message );
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
 **xdsEasyTraceRequest** | [**XdsEasyTraceRequest**](XdsEasyTraceRequest.md)|  | [optional] 

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


## XdsGetBonusSegments

> ApiReturnOfBonusSegmentArray XdsGetBonusSegments (ReferenceRequest referenceRequest = null)

Return bonus segments available for one of the trace search results

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsGetBonusSegmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Return bonus segments available for one of the trace search results
                ApiReturnOfBonusSegmentArray result = apiInstance.XdsGetBonusSegments(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsGetBonusSegments: " + e.Message );
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

[**ApiReturnOfBonusSegmentArray**](ApiReturnOfBonusSegmentArray.md)

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


## XdsIdTrace

> ApiReturnOfConsumerSearchArray XdsIdTrace (XdsTraceIdRequest xdsTraceIdRequest = null)

Returns a list of possible consumer matches using ID number. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsIdTraceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsTraceIdRequest = new XdsTraceIdRequest(); // XdsTraceIdRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using ID number. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsIdTrace(xdsTraceIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsIdTrace: " + e.Message );
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


## XdsPostalAddress

> ApiReturnOfConsumerSearchArray XdsPostalAddress (XdsTraceAddressPostalRequest xdsTraceAddressPostalRequest = null)

Returns a list of possible consumer matches using postal address. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsPostalAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsTraceAddressPostalRequest = new XdsTraceAddressPostalRequest(); // XdsTraceAddressPostalRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using postal address. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsPostalAddress(xdsTraceAddressPostalRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsPostalAddress: " + e.Message );
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
 **xdsTraceAddressPostalRequest** | [**XdsTraceAddressPostalRequest**](XdsTraceAddressPostalRequest.md)|  | [optional] 

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


## XdsStreetTrace

> ApiReturnOfConsumerSearchArray XdsStreetTrace (XdsTraceAddressStreetRequest xdsTraceAddressStreetRequest = null)

Returns a list of possible consumer matches using street address. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsStreetTraceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsTraceAddressStreetRequest = new XdsTraceAddressStreetRequest(); // XdsTraceAddressStreetRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using street address. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsStreetTrace(xdsTraceAddressStreetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsStreetTrace: " + e.Message );
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
 **xdsTraceAddressStreetRequest** | [**XdsTraceAddressStreetRequest**](XdsTraceAddressStreetRequest.md)|  | [optional] 

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


## XdsTelephoneToID

> ApiReturnOfConsumerSearchArray XdsTelephoneToID (ServicesXdsTelephoneToIdRequest servicesXdsTelephoneToIdRequest = null)

Returns a list of possible consumers with ID numbers searching by telephone only.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsTelephoneToIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var servicesXdsTelephoneToIdRequest = new ServicesXdsTelephoneToIdRequest(); // ServicesXdsTelephoneToIdRequest |  (optional) 

            try
            {
                // Returns a list of possible consumers with ID numbers searching by telephone only.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsTelephoneToID(servicesXdsTelephoneToIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsTelephoneToID: " + e.Message );
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
 **servicesXdsTelephoneToIdRequest** | [**ServicesXdsTelephoneToIdRequest**](ServicesXdsTelephoneToIdRequest.md)|  | [optional] 

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


## XdsTelephoneTrace

> ApiReturnOfConsumerSearchArray XdsTelephoneTrace (XdsTraceTelephoneRequest xdsTraceTelephoneRequest = null)

Returns a list of possible consumer matches using telephone and surname. Pass one of the references to the TraceResult call to retrieve the report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsTelephoneTraceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var xdsTraceTelephoneRequest = new XdsTraceTelephoneRequest(); // XdsTraceTelephoneRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using telephone and surname. Pass one of the references to the TraceResult call to retrieve the report.
                ApiReturnOfConsumerSearchArray result = apiInstance.XdsTelephoneTrace(xdsTraceTelephoneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsTelephoneTrace: " + e.Message );
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
 **xdsTraceTelephoneRequest** | [**XdsTraceTelephoneRequest**](XdsTraceTelephoneRequest.md)|  | [optional] 

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


## XdsTraceResult

> ApiReturnOfXdsConsumer XdsTraceResult (ReferenceBonusRequest referenceBonusRequest = null)

The consumer data using a reference number obtained from one of the trace search calls.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsTraceResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsConsumerIndividualApi(Configuration.Default);
            var referenceBonusRequest = new ReferenceBonusRequest(); // ReferenceBonusRequest |  (optional) 

            try
            {
                // The consumer data using a reference number obtained from one of the trace search calls.
                ApiReturnOfXdsConsumer result = apiInstance.XdsTraceResult(referenceBonusRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsConsumerIndividualApi.XdsTraceResult: " + e.Message );
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
 **referenceBonusRequest** | [**ReferenceBonusRequest**](ReferenceBonusRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfXdsConsumer**](ApiReturnOfXdsConsumer.md)

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

