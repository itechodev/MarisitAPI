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
    public interface ILifeStyleAuditApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <returns>ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse</returns>
        ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse LifeStyleAudit (string idNumber = default(string), string reference = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <returns>ApiResponse of ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse</returns>
        ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse> LifeStyleAuditWithHttpInfo (string idNumber = default(string), string reference = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse</returns>
        System.Threading.Tasks.Task<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse> LifeStyleAuditAsync (string idNumber = default(string), string reference = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse>> LifeStyleAuditWithHttpInfoAsync (string idNumber = default(string), string reference = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LifeStyleAuditApi : ILifeStyleAuditApi
    {
        private MarisIT.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LifeStyleAuditApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LifeStyleAuditApi(String basePath)
        {
            this.Configuration = new MarisIT.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = MarisIT.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LifeStyleAuditApi"/> class
        /// </summary>
        /// <returns></returns>
        public LifeStyleAuditApi()
        {
            this.Configuration = MarisIT.Api.Client.Configuration.Default;

            ExceptionFactory = MarisIT.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LifeStyleAuditApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LifeStyleAuditApi(MarisIT.Api.Client.Configuration configuration = null)
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
        ///  
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <returns>ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse</returns>
        public ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse LifeStyleAudit (string idNumber = default(string), string reference = default(string))
        {
             ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse> localVarResponse = LifeStyleAuditWithHttpInfo(idNumber, reference);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <returns>ApiResponse of ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse</returns>
        public ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse> LifeStyleAuditWithHttpInfo (string idNumber = default(string), string reference = default(string))
        {

            var localVarPath = "/api/v6/lifestyleaudit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (idNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "IdNumber", idNumber)); // query parameter
            if (reference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "Reference", reference)); // query parameter

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
                Exception exception = ExceptionFactory("LifeStyleAudit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse</returns>
        public async System.Threading.Tasks.Task<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse> LifeStyleAuditAsync (string idNumber = default(string), string reference = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse> localVarResponse = await LifeStyleAuditWithHttpInfoAsync(idNumber, reference, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="MarisIT.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idNumber"> (optional)</param>
        /// <param name="reference"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse>> LifeStyleAuditWithHttpInfoAsync (string idNumber = default(string), string reference = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/api/v6/lifestyleaudit";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (idNumber != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "IdNumber", idNumber)); // query parameter
            if (reference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "Reference", reference)); // query parameter

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
                Exception exception = ExceptionFactory("LifeStyleAudit", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiReturnOfServicesLifeStyleAuditLifeStyleAuditResponse)));
        }

    }
}
