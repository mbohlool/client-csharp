/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.5.1-660c2a2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace io.kubernetes.csharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuthorizationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnversionedAPIGroup</returns>
        UnversionedAPIGroup GetAPIGroup ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnversionedAPIGroup</returns>
        ApiResponse<UnversionedAPIGroup> GetAPIGroupWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnversionedAPIGroup</returns>
        System.Threading.Tasks.Task<UnversionedAPIGroup> GetAPIGroupAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// get information of a group
        /// </remarks>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnversionedAPIGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<UnversionedAPIGroup>> GetAPIGroupAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuthorizationApi : IAuthorizationApi
    {
        private io.kubernetes.csharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthorizationApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = io.kubernetes.csharp.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthorizationApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = io.kubernetes.csharp.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public io.kubernetes.csharp.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        ///  get information of a group
        /// </summary>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UnversionedAPIGroup</returns>
        public UnversionedAPIGroup GetAPIGroup ()
        {
             ApiResponse<UnversionedAPIGroup> localVarResponse = GetAPIGroupWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UnversionedAPIGroup</returns>
        public ApiResponse< UnversionedAPIGroup > GetAPIGroupWithHttpInfo ()
        {

            var localVarPath = "/apis/authorization.k8s.io/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/yaml", 
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/yaml", 
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (BearerToken) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("authorization")))
            {
                localVarHeaderParams["authorization"] = Configuration.GetApiKeyWithPrefix("authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAPIGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UnversionedAPIGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnversionedAPIGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnversionedAPIGroup)));
            
        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of UnversionedAPIGroup</returns>
        public async System.Threading.Tasks.Task<UnversionedAPIGroup> GetAPIGroupAsync ()
        {
             ApiResponse<UnversionedAPIGroup> localVarResponse = await GetAPIGroupAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  get information of a group
        /// </summary>
        /// <exception cref="io.kubernetes.csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (UnversionedAPIGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UnversionedAPIGroup>> GetAPIGroupAsyncWithHttpInfo ()
        {

            var localVarPath = "/apis/authorization.k8s.io/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/yaml", 
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/yaml", 
                "application/vnd.kubernetes.protobuf"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");

            // authentication (BearerToken) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("authorization")))
            {
                localVarHeaderParams["authorization"] = Configuration.GetApiKeyWithPrefix("authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetAPIGroup", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UnversionedAPIGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UnversionedAPIGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UnversionedAPIGroup)));
            
        }

    }
}
