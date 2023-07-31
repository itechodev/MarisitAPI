# MarisIT.Api.Api.WindeedOfficeApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AgriculturalResult**](WindeedOfficeApi.md#agriculturalresult) | **POST** /api/v6/agriculturalresult | 
[**AgriculturalSearch**](WindeedOfficeApi.md#agriculturalsearch) | **POST** /api/v6/agriculturalsearch | 
[**CompanyResult**](WindeedOfficeApi.md#companyresult) | **POST** /api/v6/companyresult | 
[**CompanySearch**](WindeedOfficeApi.md#companysearch) | **POST** /api/v6/companysearch | 
[**ErfResult**](WindeedOfficeApi.md#erfresult) | **POST** /api/v6/erfresult | 
[**ErfSearch**](WindeedOfficeApi.md#erfsearch) | **POST** /api/v6/erfsearch | 
[**FarmRemainingExtentSearch**](WindeedOfficeApi.md#farmremainingextentsearch) | **POST** /api/v6/farmremainingextentsearch | 
[**FarmResult**](WindeedOfficeApi.md#farmresult) | **POST** /api/v6/farmresult | 
[**FarmSearch**](WindeedOfficeApi.md#farmsearch) | **POST** /api/v6/farmsearch | 
[**PersonResult**](WindeedOfficeApi.md#personresult) | **POST** /api/v6/personresult | 
[**PersonSearch**](WindeedOfficeApi.md#personsearch) | **POST** /api/v6/personsearch | 
[**SectionalSchemeResult**](WindeedOfficeApi.md#sectionalschemeresult) | **POST** /api/v6/sectionalschemeresult | 
[**SectionalSchemeSearch**](WindeedOfficeApi.md#sectionalschemesearch) | **POST** /api/v6/sectionalschemesearch | 



## AgriculturalResult

> ApiReturnOfWindeedOfficeDocumentResponse AgriculturalResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class AgriculturalResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedOfficeDocumentResponse result = apiInstance.AgriculturalResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.AgriculturalResult: " + e.Message );
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

[**ApiReturnOfWindeedOfficeDocumentResponse**](ApiReturnOfWindeedOfficeDocumentResponse.md)

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


## AgriculturalSearch

> ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesAgriculturalHoldingPortionItem AgriculturalSearch (WindeedAgriculturalSearchRequest windeedAgriculturalSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class AgriculturalSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedAgriculturalSearchRequest = new WindeedAgriculturalSearchRequest(); // WindeedAgriculturalSearchRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesAgriculturalHoldingPortionItem result = apiInstance.AgriculturalSearch(windeedAgriculturalSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.AgriculturalSearch: " + e.Message );
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
 **windeedAgriculturalSearchRequest** | [**WindeedAgriculturalSearchRequest**](WindeedAgriculturalSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesAgriculturalHoldingPortionItem**](ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesAgriculturalHoldingPortionItem.md)

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


## CompanyResult

> ApiReturnOfWindeedCompanySearchResponse CompanyResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CompanyResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedCompanySearchResponse result = apiInstance.CompanyResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.CompanyResult: " + e.Message );
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

[**ApiReturnOfWindeedCompanySearchResponse**](ApiReturnOfWindeedCompanySearchResponse.md)

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


## CompanySearch

> ApiReturnOfApiReturnOfWindeedOfficeBaseOwnerResponseAndWindeedOwnerReferencedItem CompanySearch (WindeedCompanySearchRequest windeedCompanySearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class CompanySearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedCompanySearchRequest = new WindeedCompanySearchRequest(); // WindeedCompanySearchRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfWindeedOfficeBaseOwnerResponseAndWindeedOwnerReferencedItem result = apiInstance.CompanySearch(windeedCompanySearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.CompanySearch: " + e.Message );
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
 **windeedCompanySearchRequest** | [**WindeedCompanySearchRequest**](WindeedCompanySearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfApiReturnOfWindeedOfficeBaseOwnerResponseAndWindeedOwnerReferencedItem**](ApiReturnOfApiReturnOfWindeedOfficeBaseOwnerResponseAndWindeedOwnerReferencedItem.md)

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


## ErfResult

> ApiReturnOfWindeedOfficeDocumentResponse ErfResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ErfResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedOfficeDocumentResponse result = apiInstance.ErfResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.ErfResult: " + e.Message );
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

[**ApiReturnOfWindeedOfficeDocumentResponse**](ApiReturnOfWindeedOfficeDocumentResponse.md)

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


## ErfSearch

> ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesErfPortionItem ErfSearch (WindeedErfSearchRequest windeedErfSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class ErfSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedErfSearchRequest = new WindeedErfSearchRequest(); // WindeedErfSearchRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesErfPortionItem result = apiInstance.ErfSearch(windeedErfSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.ErfSearch: " + e.Message );
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
 **windeedErfSearchRequest** | [**WindeedErfSearchRequest**](WindeedErfSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesErfPortionItem**](ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesErfPortionItem.md)

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


## FarmRemainingExtentSearch

> ApiReturnOfWindeedOfficev1ProxiesFarmSearchResult FarmRemainingExtentSearch (WindeedFarmSearchRemainingExtentRequest windeedFarmSearchRemainingExtentRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class FarmRemainingExtentSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedFarmSearchRemainingExtentRequest = new WindeedFarmSearchRemainingExtentRequest(); // WindeedFarmSearchRemainingExtentRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedOfficev1ProxiesFarmSearchResult result = apiInstance.FarmRemainingExtentSearch(windeedFarmSearchRemainingExtentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.FarmRemainingExtentSearch: " + e.Message );
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
 **windeedFarmSearchRemainingExtentRequest** | [**WindeedFarmSearchRemainingExtentRequest**](WindeedFarmSearchRemainingExtentRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfWindeedOfficev1ProxiesFarmSearchResult**](ApiReturnOfWindeedOfficev1ProxiesFarmSearchResult.md)

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


## FarmResult

> ApiReturnOfWindeedOfficeDocumentResponse FarmResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class FarmResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedOfficeDocumentResponse result = apiInstance.FarmResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.FarmResult: " + e.Message );
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

[**ApiReturnOfWindeedOfficeDocumentResponse**](ApiReturnOfWindeedOfficeDocumentResponse.md)

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


## FarmSearch

> ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesFarmPortionItem FarmSearch (WindeedFarmSearchRequest windeedFarmSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class FarmSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedFarmSearchRequest = new WindeedFarmSearchRequest(); // WindeedFarmSearchRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesFarmPortionItem result = apiInstance.FarmSearch(windeedFarmSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.FarmSearch: " + e.Message );
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
 **windeedFarmSearchRequest** | [**WindeedFarmSearchRequest**](WindeedFarmSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesFarmPortionItem**](ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesFarmPortionItem.md)

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


## PersonResult

> ApiReturnOfWindeedSpiderSpiderResponse PersonResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class PersonResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedSpiderSpiderResponse result = apiInstance.PersonResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.PersonResult: " + e.Message );
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

[**ApiReturnOfWindeedSpiderSpiderResponse**](ApiReturnOfWindeedSpiderSpiderResponse.md)

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


## PersonSearch

> ApiReturnOfApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem PersonSearch (WindeedPersonSearchRequest windeedPersonSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class PersonSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedPersonSearchRequest = new WindeedPersonSearchRequest(); // WindeedPersonSearchRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem result = apiInstance.PersonSearch(windeedPersonSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.PersonSearch: " + e.Message );
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
 **windeedPersonSearchRequest** | [**WindeedPersonSearchRequest**](WindeedPersonSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem**](ApiReturnOfApiReturnOfWindeedOfficePersonResponseAndWindeedOwnerReferencedItem.md)

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


## SectionalSchemeResult

> ApiReturnOfWindeedOfficeDocumentResponse SectionalSchemeResult (ReferenceRequest referenceRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SectionalSchemeResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                ApiReturnOfWindeedOfficeDocumentResponse result = apiInstance.SectionalSchemeResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.SectionalSchemeResult: " + e.Message );
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

[**ApiReturnOfWindeedOfficeDocumentResponse**](ApiReturnOfWindeedOfficeDocumentResponse.md)

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


## SectionalSchemeSearch

> ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesSectionalSchemeUnit SectionalSchemeSearch (WindeedUnitSearchRequest windeedUnitSearchRequest = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class SectionalSchemeSearchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new WindeedOfficeApi(Configuration.Default);
            var windeedUnitSearchRequest = new WindeedUnitSearchRequest(); // WindeedUnitSearchRequest |  (optional) 

            try
            {
                ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesSectionalSchemeUnit result = apiInstance.SectionalSchemeSearch(windeedUnitSearchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling WindeedOfficeApi.SectionalSchemeSearch: " + e.Message );
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
 **windeedUnitSearchRequest** | [**WindeedUnitSearchRequest**](WindeedUnitSearchRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesSectionalSchemeUnit**](ApiReturnOfApiReturnOfWindeedOfficeDocumentResponseAndWindeedOfficeProxiesSectionalSchemeUnit.md)

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

