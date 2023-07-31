# MarisIT.Api.Api.WindeedKnowledgeFactoryApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ErfToStreet**](WindeedKnowledgeFactoryApi.md#erftostreet) | **POST** /api/v6/erftostreet | 
[**ErfToStreetResult**](WindeedKnowledgeFactoryApi.md#erftostreetresult) | **POST** /api/v6/erftostreetresult | 
[**SchemeToStreet**](WindeedKnowledgeFactoryApi.md#schemetostreet) | **POST** /api/v6/schemetostreet | 
[**SchemeToStreetResult**](WindeedKnowledgeFactoryApi.md#schemetostreetresult) | **POST** /api/v6/schemetostreetresult | 
[**StreetToErf**](WindeedKnowledgeFactoryApi.md#streettoerf) | **POST** /api/v6/streettoerf | 
[**StreetToErfResult**](WindeedKnowledgeFactoryApi.md#streettoerfresult) | **POST** /api/v6/streettoerfresult | 



## ErfToStreet

> ApiReturnOfErfOrStreetSearchArray ErfToStreet (WindeedErfToStreetRequest windeedErfToStreetRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ErfToStreetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedKnowledgeFactoryApi(Configuration.Default);
            var windeedErfToStreetRequest = new WindeedErfToStreetRequest(); // WindeedErfToStreetRequest |  (optional) 

            try
            {
                ApiReturnOfErfOrStreetSearchArray result = apiInstance.ErfToStreet(windeedErfToStreetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedKnowledgeFactoryApi.ErfToStreet: " + e.Message );
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
 **windeedErfToStreetRequest** | [**WindeedErfToStreetRequest**](WindeedErfToStreetRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfErfOrStreetSearchArray**](ApiReturnOfErfOrStreetSearchArray.md)

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


## ErfToStreetResult

> ApiReturnOfWindeedKnowledgeFactoryErfToStreetResponse ErfToStreetResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ErfToStreetResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedKnowledgeFactoryApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedKnowledgeFactoryErfToStreetResponse result = apiInstance.ErfToStreetResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedKnowledgeFactoryApi.ErfToStreetResult: " + e.Message );
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

[**ApiReturnOfWindeedKnowledgeFactoryErfToStreetResponse**](ApiReturnOfWindeedKnowledgeFactoryErfToStreetResponse.md)

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


## SchemeToStreet

> ApiReturnOfSchemeSearchArray SchemeToStreet (WindeedSchemaToSteetRequest windeedSchemaToSteetRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SchemeToStreetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedKnowledgeFactoryApi(Configuration.Default);
            var windeedSchemaToSteetRequest = new WindeedSchemaToSteetRequest(); // WindeedSchemaToSteetRequest |  (optional) 

            try
            {
                ApiReturnOfSchemeSearchArray result = apiInstance.SchemeToStreet(windeedSchemaToSteetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedKnowledgeFactoryApi.SchemeToStreet: " + e.Message );
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
 **windeedSchemaToSteetRequest** | [**WindeedSchemaToSteetRequest**](WindeedSchemaToSteetRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfSchemeSearchArray**](ApiReturnOfSchemeSearchArray.md)

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


## SchemeToStreetResult

> ApiReturnOfWindeedKnowledgeFactorySectionalSchemeToStreetResponse SchemeToStreetResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SchemeToStreetResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedKnowledgeFactoryApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedKnowledgeFactorySectionalSchemeToStreetResponse result = apiInstance.SchemeToStreetResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedKnowledgeFactoryApi.SchemeToStreetResult: " + e.Message );
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

[**ApiReturnOfWindeedKnowledgeFactorySectionalSchemeToStreetResponse**](ApiReturnOfWindeedKnowledgeFactorySectionalSchemeToStreetResponse.md)

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


## StreetToErf

> ApiReturnOfErfOrStreetSearchArray StreetToErf (WindeedStreetToErfRequest windeedStreetToErfRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class StreetToErfExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedKnowledgeFactoryApi(Configuration.Default);
            var windeedStreetToErfRequest = new WindeedStreetToErfRequest(); // WindeedStreetToErfRequest |  (optional) 

            try
            {
                ApiReturnOfErfOrStreetSearchArray result = apiInstance.StreetToErf(windeedStreetToErfRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedKnowledgeFactoryApi.StreetToErf: " + e.Message );
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
 **windeedStreetToErfRequest** | [**WindeedStreetToErfRequest**](WindeedStreetToErfRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfErfOrStreetSearchArray**](ApiReturnOfErfOrStreetSearchArray.md)

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


## StreetToErfResult

> ApiReturnOfWindeedKnowledgeFactoryStreetToErfResponse StreetToErfResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class StreetToErfResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedKnowledgeFactoryApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedKnowledgeFactoryStreetToErfResponse result = apiInstance.StreetToErfResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedKnowledgeFactoryApi.StreetToErfResult: " + e.Message );
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

[**ApiReturnOfWindeedKnowledgeFactoryStreetToErfResponse**](ApiReturnOfWindeedKnowledgeFactoryStreetToErfResponse.md)

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

