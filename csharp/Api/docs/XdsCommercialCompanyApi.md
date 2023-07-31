# MarisIT.Api.Api.XdsCommercialCompanyApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**XdsBankAccountVerificationBusiness**](XdsCommercialCompanyApi.md#xdsbankaccountverificationbusiness) | **POST** /api/v6/xdsbankaccountverificationbusiness | Returns bank account verification data for a business.
[**XdsBusinessMatchName**](XdsCommercialCompanyApi.md#xdsbusinessmatchname) | **POST** /api/v6/xdsbusinessmatchname | Returns a list of possible company matches using a business name.  Use one of the references to get a standard, details or CIPC report.
[**XdsBusinessMatchRegistration**](XdsCommercialCompanyApi.md#xdsbusinessmatchregistration) | **POST** /api/v6/xdsbusinessmatchregistration | Returns a list of possible company matches using registration number.   Use one of the references to get a standard, details or CIPC report.
[**XdsBusinessMatchResultCipc**](XdsCommercialCompanyApi.md#xdsbusinessmatchresultcipc) | **POST** /api/v6/xdsbusinessmatchresultcipc | Return a CIPC business report. Use a referene number from one business search calls.
[**XdsBusinessMatchResultDetailed**](XdsCommercialCompanyApi.md#xdsbusinessmatchresultdetailed) | **POST** /api/v6/xdsbusinessmatchresultdetailed | Return a detailed business report. Use a referene number from one of business search calls.
[**XdsBusinessMatchResultStandard**](XdsCommercialCompanyApi.md#xdsbusinessmatchresultstandard) | **POST** /api/v6/xdsbusinessmatchresultstandard | Return a standard business report. Use a referene number from one business search calls.
[**XdsBusinessMatchSoleProp**](XdsCommercialCompanyApi.md#xdsbusinessmatchsoleprop) | **POST** /api/v6/xdsbusinessmatchsoleprop | Returns a list of possible sole proprietor companies matching the owner&#39;s ID number  Use one of the references to get a standard, details or CIPC report.
[**XdsBusinessMatchVatNumber**](XdsCommercialCompanyApi.md#xdsbusinessmatchvatnumber) | **POST** /api/v6/xdsbusinessmatchvatnumber | Returns a list of possible company matches using a VAT registration number.  Use one of the references to get a standard, details or CIPC report.



## XdsBankAccountVerificationBusiness

> ApiReturnOfXdsAccountVerificationResult XdsBankAccountVerificationBusiness (XdsBankVerificationBusinessRequest xdsBankVerificationBusinessRequest = null)

Returns bank account verification data for a business.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBankAccountVerificationBusinessExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var xdsBankVerificationBusinessRequest = new XdsBankVerificationBusinessRequest(); // XdsBankVerificationBusinessRequest |  (optional) 

            try
            {
                // Returns bank account verification data for a business.
                ApiReturnOfXdsAccountVerificationResult result = apiInstance.XdsBankAccountVerificationBusiness(xdsBankVerificationBusinessRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBankAccountVerificationBusiness: " + e.Message );
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
 **xdsBankVerificationBusinessRequest** | [**XdsBankVerificationBusinessRequest**](XdsBankVerificationBusinessRequest.md)|  | [optional] 

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


## XdsBusinessMatchName

> ApiReturnOfCompanySearchArray XdsBusinessMatchName (XdsBusinessNameRequest xdsBusinessNameRequest = null)

Returns a list of possible company matches using a business name.  Use one of the references to get a standard, details or CIPC report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchNameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var xdsBusinessNameRequest = new XdsBusinessNameRequest(); // XdsBusinessNameRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using a business name.  Use one of the references to get a standard, details or CIPC report.
                ApiReturnOfCompanySearchArray result = apiInstance.XdsBusinessMatchName(xdsBusinessNameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchName: " + e.Message );
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
 **xdsBusinessNameRequest** | [**XdsBusinessNameRequest**](XdsBusinessNameRequest.md)|  | [optional] 

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


## XdsBusinessMatchRegistration

> ApiReturnOfCompanySearchArray XdsBusinessMatchRegistration (XdsBusinessRegNumberRequest xdsBusinessRegNumberRequest = null)

Returns a list of possible company matches using registration number.   Use one of the references to get a standard, details or CIPC report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchRegistrationExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var xdsBusinessRegNumberRequest = new XdsBusinessRegNumberRequest(); // XdsBusinessRegNumberRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using registration number.   Use one of the references to get a standard, details or CIPC report.
                ApiReturnOfCompanySearchArray result = apiInstance.XdsBusinessMatchRegistration(xdsBusinessRegNumberRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchRegistration: " + e.Message );
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
 **xdsBusinessRegNumberRequest** | [**XdsBusinessRegNumberRequest**](XdsBusinessRegNumberRequest.md)|  | [optional] 

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


## XdsBusinessMatchResultCipc

> ApiReturnOfXdsCommercial XdsBusinessMatchResultCipc (ReferenceRequest referenceRequest = null)

Return a CIPC business report. Use a referene number from one business search calls.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchResultCipcExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Return a CIPC business report. Use a referene number from one business search calls.
                ApiReturnOfXdsCommercial result = apiInstance.XdsBusinessMatchResultCipc(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchResultCipc: " + e.Message );
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

[**ApiReturnOfXdsCommercial**](ApiReturnOfXdsCommercial.md)

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


## XdsBusinessMatchResultDetailed

> ApiReturnOfXdsCommercial XdsBusinessMatchResultDetailed (ReferenceRequest referenceRequest = null)

Return a detailed business report. Use a referene number from one of business search calls.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchResultDetailedExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Return a detailed business report. Use a referene number from one of business search calls.
                ApiReturnOfXdsCommercial result = apiInstance.XdsBusinessMatchResultDetailed(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchResultDetailed: " + e.Message );
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

[**ApiReturnOfXdsCommercial**](ApiReturnOfXdsCommercial.md)

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


## XdsBusinessMatchResultStandard

> ApiReturnOfXdsCommercial XdsBusinessMatchResultStandard (ReferenceRequest referenceRequest = null)

Return a standard business report. Use a referene number from one business search calls.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchResultStandardExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Return a standard business report. Use a referene number from one business search calls.
                ApiReturnOfXdsCommercial result = apiInstance.XdsBusinessMatchResultStandard(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchResultStandard: " + e.Message );
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

[**ApiReturnOfXdsCommercial**](ApiReturnOfXdsCommercial.md)

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


## XdsBusinessMatchSoleProp

> ApiReturnOfCompanySearchArray XdsBusinessMatchSoleProp (XdsBusinessSoleProp xdsBusinessSoleProp = null)

Returns a list of possible sole proprietor companies matching the owner's ID number  Use one of the references to get a standard, details or CIPC report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchSolePropExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var xdsBusinessSoleProp = new XdsBusinessSoleProp(); // XdsBusinessSoleProp |  (optional) 

            try
            {
                // Returns a list of possible sole proprietor companies matching the owner's ID number  Use one of the references to get a standard, details or CIPC report.
                ApiReturnOfCompanySearchArray result = apiInstance.XdsBusinessMatchSoleProp(xdsBusinessSoleProp);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchSoleProp: " + e.Message );
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
 **xdsBusinessSoleProp** | [**XdsBusinessSoleProp**](XdsBusinessSoleProp.md)|  | [optional] 

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


## XdsBusinessMatchVatNumber

> ApiReturnOfCompanySearchArray XdsBusinessMatchVatNumber (XdsBusinessVatRequest xdsBusinessVatRequest = null)

Returns a list of possible company matches using a VAT registration number.  Use one of the references to get a standard, details or CIPC report.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class XdsBusinessMatchVatNumberExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new XdsCommercialCompanyApi(Configuration.Default);
            var xdsBusinessVatRequest = new XdsBusinessVatRequest(); // XdsBusinessVatRequest |  (optional) 

            try
            {
                // Returns a list of possible company matches using a VAT registration number.  Use one of the references to get a standard, details or CIPC report.
                ApiReturnOfCompanySearchArray result = apiInstance.XdsBusinessMatchVatNumber(xdsBusinessVatRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling XdsCommercialCompanyApi.XdsBusinessMatchVatNumber: " + e.Message );
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
 **xdsBusinessVatRequest** | [**XdsBusinessVatRequest**](XdsBusinessVatRequest.md)|  | [optional] 

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

