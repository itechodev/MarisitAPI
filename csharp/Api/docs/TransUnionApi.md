# MarisIT.Api.Api.TransUnionApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TUConsumerForeignPassportReport**](TransUnionApi.md#tuconsumerforeignpassportreport) | **POST** /api/v6/tuconsumerforeignpassportreport | Returns full consumer data for given consumer details.
[**TUConsumerFraudReport**](TransUnionApi.md#tuconsumerfraudreport) | **POST** /api/v6/tuconsumerfraudreport | Returns full consumer data + fraud data for given consumer details.
[**TUConsumerIdReport**](TransUnionApi.md#tuconsumeridreport) | **POST** /api/v6/tuconsumeridreport | Returns full consumer data for given consumer details.
[**TUConsumerTraceByAddressAndSurname**](TransUnionApi.md#tuconsumertracebyaddressandsurname) | **POST** /api/v6/tuconsumertracebyaddressandsurname | Returns a list of possible consumer matches using address and surname. Pass one of the references to the TraceResult call to retrieve full consumer detail.
[**TUConsumerTraceByID**](TransUnionApi.md#tuconsumertracebyid) | **POST** /api/v6/tuconsumertracebyid | Returns a list of possible consumer matches using ID number. Pass one of the references to the TransUnionConsumerTraceResult call to retrieve full consumer detail.
[**TUConsumerTraceByTelephone**](TransUnionApi.md#tuconsumertracebytelephone) | **POST** /api/v6/tuconsumertracebytelephone | Returns a list of possible consumer matches using telephone number. Pass one of the references to the TransUnionConsumerTraceResult call to retrieve full consumer detail.
[**TUConsumerTraceResult**](TransUnionApi.md#tuconsumertraceresult) | **POST** /api/v6/tuconsumertraceresult | Returns full trace data for given reference number.



## TUConsumerForeignPassportReport

> ApiReturnOfTransunionConsumer118BureauResponse TUConsumerForeignPassportReport (TransunionConsumerPassportEnquiryRequest transunionConsumerPassportEnquiryRequest = null)

Returns full consumer data for given consumer details.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerForeignPassportReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var transunionConsumerPassportEnquiryRequest = new TransunionConsumerPassportEnquiryRequest(); // TransunionConsumerPassportEnquiryRequest |  (optional) 

            try
            {
                // Returns full consumer data for given consumer details.
                ApiReturnOfTransunionConsumer118BureauResponse result = apiInstance.TUConsumerForeignPassportReport(transunionConsumerPassportEnquiryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerForeignPassportReport: " + e.Message );
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
 **transunionConsumerPassportEnquiryRequest** | [**TransunionConsumerPassportEnquiryRequest**](TransunionConsumerPassportEnquiryRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfTransunionConsumer118BureauResponse**](ApiReturnOfTransunionConsumer118BureauResponse.md)

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


## TUConsumerFraudReport

> ApiReturnOfTransunionConsumer118BureauResponse TUConsumerFraudReport (TransunionConsumerIdEnquiryRequest transunionConsumerIdEnquiryRequest = null)

Returns full consumer data + fraud data for given consumer details.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerFraudReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var transunionConsumerIdEnquiryRequest = new TransunionConsumerIdEnquiryRequest(); // TransunionConsumerIdEnquiryRequest |  (optional) 

            try
            {
                // Returns full consumer data + fraud data for given consumer details.
                ApiReturnOfTransunionConsumer118BureauResponse result = apiInstance.TUConsumerFraudReport(transunionConsumerIdEnquiryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerFraudReport: " + e.Message );
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
 **transunionConsumerIdEnquiryRequest** | [**TransunionConsumerIdEnquiryRequest**](TransunionConsumerIdEnquiryRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfTransunionConsumer118BureauResponse**](ApiReturnOfTransunionConsumer118BureauResponse.md)

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


## TUConsumerIdReport

> ApiReturnOfTransunionConsumer118BureauResponse TUConsumerIdReport (TransunionConsumerIdEnquiryRequest transunionConsumerIdEnquiryRequest = null)

Returns full consumer data for given consumer details.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerIdReportExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var transunionConsumerIdEnquiryRequest = new TransunionConsumerIdEnquiryRequest(); // TransunionConsumerIdEnquiryRequest |  (optional) 

            try
            {
                // Returns full consumer data for given consumer details.
                ApiReturnOfTransunionConsumer118BureauResponse result = apiInstance.TUConsumerIdReport(transunionConsumerIdEnquiryRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerIdReport: " + e.Message );
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
 **transunionConsumerIdEnquiryRequest** | [**TransunionConsumerIdEnquiryRequest**](TransunionConsumerIdEnquiryRequest.md)|  | [optional] 

### Return type

[**ApiReturnOfTransunionConsumer118BureauResponse**](ApiReturnOfTransunionConsumer118BureauResponse.md)

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


## TUConsumerTraceByAddressAndSurname

> ApiReturnOfConsumerSearchArray TUConsumerTraceByAddressAndSurname (TransunionConsumerAddressSurnameRequest transunionConsumerAddressSurnameRequest = null)

Returns a list of possible consumer matches using address and surname. Pass one of the references to the TraceResult call to retrieve full consumer detail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerTraceByAddressAndSurnameExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var transunionConsumerAddressSurnameRequest = new TransunionConsumerAddressSurnameRequest(); // TransunionConsumerAddressSurnameRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using address and surname. Pass one of the references to the TraceResult call to retrieve full consumer detail.
                ApiReturnOfConsumerSearchArray result = apiInstance.TUConsumerTraceByAddressAndSurname(transunionConsumerAddressSurnameRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerTraceByAddressAndSurname: " + e.Message );
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
 **transunionConsumerAddressSurnameRequest** | [**TransunionConsumerAddressSurnameRequest**](TransunionConsumerAddressSurnameRequest.md)|  | [optional] 

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


## TUConsumerTraceByID

> ApiReturnOfConsumerSearchArray TUConsumerTraceByID (TransunionConsumerIdTraceRequest transunionConsumerIdTraceRequest = null)

Returns a list of possible consumer matches using ID number. Pass one of the references to the TransUnionConsumerTraceResult call to retrieve full consumer detail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerTraceByIDExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var transunionConsumerIdTraceRequest = new TransunionConsumerIdTraceRequest(); // TransunionConsumerIdTraceRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using ID number. Pass one of the references to the TransUnionConsumerTraceResult call to retrieve full consumer detail.
                ApiReturnOfConsumerSearchArray result = apiInstance.TUConsumerTraceByID(transunionConsumerIdTraceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerTraceByID: " + e.Message );
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
 **transunionConsumerIdTraceRequest** | [**TransunionConsumerIdTraceRequest**](TransunionConsumerIdTraceRequest.md)|  | [optional] 

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


## TUConsumerTraceByTelephone

> ApiReturnOfConsumerSearchArray TUConsumerTraceByTelephone (TransunionConsumerTelephoneTraceRequest transunionConsumerTelephoneTraceRequest = null)

Returns a list of possible consumer matches using telephone number. Pass one of the references to the TransUnionConsumerTraceResult call to retrieve full consumer detail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerTraceByTelephoneExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var transunionConsumerTelephoneTraceRequest = new TransunionConsumerTelephoneTraceRequest(); // TransunionConsumerTelephoneTraceRequest |  (optional) 

            try
            {
                // Returns a list of possible consumer matches using telephone number. Pass one of the references to the TransUnionConsumerTraceResult call to retrieve full consumer detail.
                ApiReturnOfConsumerSearchArray result = apiInstance.TUConsumerTraceByTelephone(transunionConsumerTelephoneTraceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerTraceByTelephone: " + e.Message );
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
 **transunionConsumerTelephoneTraceRequest** | [**TransunionConsumerTelephoneTraceRequest**](TransunionConsumerTelephoneTraceRequest.md)|  | [optional] 

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


## TUConsumerTraceResult

> ApiReturnOfTransunionConsumer118BureauResponse TUConsumerTraceResult (ReferenceRequest referenceRequest = null)

Returns full trace data for given reference number.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarisIT.Api.Api;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace Example
{
    public class TUConsumerTraceResultExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransUnionApi(Configuration.Default);
            var referenceRequest = new ReferenceRequest(); // ReferenceRequest |  (optional) 

            try
            {
                // Returns full trace data for given reference number.
                ApiReturnOfTransunionConsumer118BureauResponse result = apiInstance.TUConsumerTraceResult(referenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling TransUnionApi.TUConsumerTraceResult: " + e.Message );
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

[**ApiReturnOfTransunionConsumer118BureauResponse**](ApiReturnOfTransunionConsumer118BureauResponse.md)

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

