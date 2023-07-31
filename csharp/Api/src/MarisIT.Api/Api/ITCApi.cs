/*
 * MarisIT API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v6
 * Contact: development@marisit.co.za
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using MarisIT.Api.Client;
using MarisIT.Api.Model;

namespace MarisIT.Api.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IITCApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns consumer details for on of the searches
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <returns>ApiReturnOfItcItcConsumer</returns>
        [Obsolete]
        ApiReturnOfItcItcConsumer ItcResult (ReferenceRequest referenceRequest = default(ReferenceRequest));

        /// <summary>
        /// Returns consumer details for on of the searches
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiReturnOfItcItcConsumer</returns>
        [Obsolete]
        ApiResponse<ApiReturnOfItcItcConsumer> ItcResultWithHttpInfo (ReferenceRequest referenceRequest = default(ReferenceRequest));
        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <returns>ApiReturnOfConsumerSearchArray</returns>
        [Obsolete]
        ApiReturnOfConsumerSearchArray ItcSearch (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest));

        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiReturnOfConsumerSearchArray</returns>
        [Obsolete]
        ApiResponse<ApiReturnOfConsumerSearchArray> ItcSearchWithHttpInfo (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns consumer details for on of the searches
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiReturnOfItcItcConsumer</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiReturnOfItcItcConsumer> ItcResultAsync (ReferenceRequest referenceRequest = default(ReferenceRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns consumer details for on of the searches
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiReturnOfItcItcConsumer)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<ApiReturnOfItcItcConsumer>> ItcResultWithHttpInfoAsync (ReferenceRequest referenceRequest = default(ReferenceRequest), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiReturnOfConsumerSearchArray</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiReturnOfConsumerSearchArray> ItcSearchAsync (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiReturnOfConsumerSearchArray)</returns>
        [Obsolete]
        System.Threading.Tasks.Task<ApiResponse<ApiReturnOfConsumerSearchArray>> ItcSearchWithHttpInfoAsync (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ITCApi : IITCApi
    {
        private MarisIT.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ITCApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ITCApi(String basePath)
        {
            this.Configuration = new MarisIT.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MarisIT.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITCApi"/> class
        /// </summary>
        /// <returns></returns>
        public ITCApi()
        {
            this.Configuration = MarisIT.Api.Client.Configuration.Default;

            ExceptionFactory = MarisIT.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ITCApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ITCApi(MarisIT.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = MarisIT.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = MarisIT.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MarisIT.Api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MarisIT.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Returns consumer details for on of the searches 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <returns>ApiReturnOfItcItcConsumer</returns>
        [Obsolete]
        public ApiReturnOfItcItcConsumer ItcResult (ReferenceRequest referenceRequest = default(ReferenceRequest))
        {
             ApiResponse<ApiReturnOfItcItcConsumer> localVarResponse = ItcResultWithHttpInfo(referenceRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns consumer details for on of the searches 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiReturnOfItcItcConsumer</returns>
        [Obsolete]
        public ApiResponse<ApiReturnOfItcItcConsumer> ItcResultWithHttpInfo (ReferenceRequest referenceRequest = default(ReferenceRequest))
        {

            var localVarPath = "/api/v6/itcresult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (referenceRequest != null && referenceRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(referenceRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = referenceRequest; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ItcResult", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiReturnOfItcItcConsumer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiReturnOfItcItcConsumer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiReturnOfItcItcConsumer)));
        }

        /// <summary>
        /// Returns consumer details for on of the searches 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiReturnOfItcItcConsumer</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiReturnOfItcItcConsumer> ItcResultAsync (ReferenceRequest referenceRequest = default(ReferenceRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ApiReturnOfItcItcConsumer> localVarResponse = await ItcResultWithHttpInfoAsync(referenceRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns consumer details for on of the searches 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="referenceRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiReturnOfItcItcConsumer)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<ApiReturnOfItcItcConsumer>> ItcResultWithHttpInfoAsync (ReferenceRequest referenceRequest = default(ReferenceRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/api/v6/itcresult";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (referenceRequest != null && referenceRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(referenceRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = referenceRequest; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ItcResult", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiReturnOfItcItcConsumer>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiReturnOfItcItcConsumer) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiReturnOfItcItcConsumer)));
        }

        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report. 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <returns>ApiReturnOfConsumerSearchArray</returns>
        [Obsolete]
        public ApiReturnOfConsumerSearchArray ItcSearch (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest))
        {
             ApiResponse<ApiReturnOfConsumerSearchArray> localVarResponse = ItcSearchWithHttpInfo(itcSearchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report. 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <returns>ApiResponse of ApiReturnOfConsumerSearchArray</returns>
        [Obsolete]
        public ApiResponse<ApiReturnOfConsumerSearchArray> ItcSearchWithHttpInfo (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest))
        {

            var localVarPath = "/api/v6/itcsearch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (itcSearchRequest != null && itcSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(itcSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = itcSearchRequest; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ItcSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiReturnOfConsumerSearchArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiReturnOfConsumerSearchArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiReturnOfConsumerSearchArray)));
        }

        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report. 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiReturnOfConsumerSearchArray</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiReturnOfConsumerSearchArray> ItcSearchAsync (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ApiReturnOfConsumerSearchArray> localVarResponse = await ItcSearchWithHttpInfoAsync(itcSearchRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of possible consumer matches using a search query. Pass one of the references to the ItcResult call to retrieve the full report. 
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itcSearchRequest"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiReturnOfConsumerSearchArray)</returns>
        [Obsolete]
        public async System.Threading.Tasks.Task<ApiResponse<ApiReturnOfConsumerSearchArray>> ItcSearchWithHttpInfoAsync (ItcSearchRequest itcSearchRequest = default(ItcSearchRequest), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/api/v6/itcsearch";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (itcSearchRequest != null && itcSearchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(itcSearchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = itcSearchRequest; // byte array
            }

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ItcSearch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiReturnOfConsumerSearchArray>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiReturnOfConsumerSearchArray) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiReturnOfConsumerSearchArray)));
        }

    }
}
