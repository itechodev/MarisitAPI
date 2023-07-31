# MarisIT.Api.Api.WindeedSpiderApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SpiderCompanyRegSearch**](WindeedSpiderApi.md#spidercompanyregsearch) | **POST** /api/v6/spidercompanyregsearch | 
[**SpiderCompanyResult**](WindeedSpiderApi.md#spidercompanyresult) | **POST** /api/v6/spidercompanyresult | 
[**SpiderCompanySearch**](WindeedSpiderApi.md#spidercompanysearch) | **POST** /api/v6/spidercompanysearch | 
[**SpiderPersonResult**](WindeedSpiderApi.md#spiderpersonresult) | **POST** /api/v6/spiderpersonresult | 
[**SpiderPersonSearch**](WindeedSpiderApi.md#spiderpersonsearch) | **POST** /api/v6/spiderpersonsearch | 



## SpiderCompanyRegSearch

> ApiReturnOfCompanySearchArray SpiderCompanyRegSearch (WindeedSpiderCompanyRegSearchRequest windeedSpiderCompanyRegSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SpiderCompanyRegSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedSpiderApi(Configuration.Default);
            var windeedSpiderCompanyRegSearchRequest = new WindeedSpiderCompanyRegSearchRequest(); // WindeedSpiderCompanyRegSearchRequest |  (optional) 

            try
            {
                ApiReturnOfCompanySearchArray result = apiInstance.SpiderCompanyRegSearch(windeedSpiderCompanyRegSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedSpiderApi.SpiderCompanyRegSearch: " + e.Message );
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
 **windeedSpiderCompanyRegSearchRequest** | [**WindeedSpiderCompanyRegSearchRequest**](WindeedSpiderCompanyRegSearchRequest.md)|  | [optional] 

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


## SpiderCompanyResult

> ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten SpiderCompanyResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SpiderCompanyResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedSpiderApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten result = apiInstance.SpiderCompanyResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedSpiderApi.SpiderCompanyResult: " + e.Message );
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

[**ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten**](ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten.md)

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


## SpiderCompanySearch

> ApiReturnOfCompanySearchArray SpiderCompanySearch (WindeedSpiderCompanyNameSearchRequest windeedSpiderCompanyNameSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SpiderCompanySearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedSpiderApi(Configuration.Default);
            var windeedSpiderCompanyNameSearchRequest = new WindeedSpiderCompanyNameSearchRequest(); // WindeedSpiderCompanyNameSearchRequest |  (optional) 

            try
            {
                ApiReturnOfCompanySearchArray result = apiInstance.SpiderCompanySearch(windeedSpiderCompanyNameSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedSpiderApi.SpiderCompanySearch: " + e.Message );
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
 **windeedSpiderCompanyNameSearchRequest** | [**WindeedSpiderCompanyNameSearchRequest**](WindeedSpiderCompanyNameSearchRequest.md)|  | [optional] 

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


## SpiderPersonResult

> ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten SpiderPersonResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SpiderPersonResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedSpiderApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten result = apiInstance.SpiderPersonResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedSpiderApi.SpiderPersonResult: " + e.Message );
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

[**ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten**](ApiReturnOfWindeedSpiderProxiesSpiderResponseFlatten.md)

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


## SpiderPersonSearch

> ApiReturnOfConsumerSearchArray SpiderPersonSearch (WindeedSpiderPersonSearchRequest windeedSpiderPersonSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SpiderPersonSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedSpiderApi(Configuration.Default);
            var windeedSpiderPersonSearchRequest = new WindeedSpiderPersonSearchRequest(); // WindeedSpiderPersonSearchRequest |  (optional) 

            try
            {
                ApiReturnOfConsumerSearchArray result = apiInstance.SpiderPersonSearch(windeedSpiderPersonSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedSpiderApi.SpiderPersonSearch: " + e.Message );
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
 **windeedSpiderPersonSearchRequest** | [**WindeedSpiderPersonSearchRequest**](WindeedSpiderPersonSearchRequest.md)|  | [optional] 

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

