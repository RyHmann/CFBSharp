/* 
 * College Football Data API
 *
 * This is an API for accessing all sorts of college football data.  Please note that API keys should be supplied with \"Bearer \" prepended (e.g. \"Bearer your_key\"). API keys can be acquired from the CollegeFootballData.com website.
 *
 * OpenAPI spec version: 4.4.12
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using CFBSharp.Client;
using CFBSharp.Model;

namespace CFBSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRankingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Historical polls and rankings
        /// </summary>
        /// <remarks>
        /// Poll rankings
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>ICollection&lt;RankingWeek&gt;</returns>
        ICollection<RankingWeek> GetRankings (int? year, int? week = null, string seasonType = null);

        /// <summary>
        /// Historical polls and rankings
        /// </summary>
        /// <remarks>
        /// Poll rankings
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>ApiResponse of ICollection&lt;RankingWeek&gt;</returns>
        ApiResponse<ICollection<RankingWeek>> GetRankingsWithHttpInfo (int? year, int? week = null, string seasonType = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Historical polls and rankings
        /// </summary>
        /// <remarks>
        /// Poll rankings
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>Task of ICollection&lt;RankingWeek&gt;</returns>
        System.Threading.Tasks.Task<ICollection<RankingWeek>> GetRankingsAsync (int? year, int? week = null, string seasonType = null);

        /// <summary>
        /// Historical polls and rankings
        /// </summary>
        /// <remarks>
        /// Poll rankings
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;RankingWeek&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<RankingWeek>>> GetRankingsAsyncWithHttpInfo (int? year, int? week = null, string seasonType = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RankingsApi : IRankingsApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RankingsApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RankingsApi(CFBSharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = CFBSharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
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
        public CFBSharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CFBSharp.Client.ExceptionFactory ExceptionFactory
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
        /// Historical polls and rankings Poll rankings
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>ICollection&lt;RankingWeek&gt;</returns>
        public ICollection<RankingWeek> GetRankings (int? year, int? week = null, string seasonType = null)
        {
             ApiResponse<ICollection<RankingWeek>> localVarResponse = GetRankingsWithHttpInfo(year, week, seasonType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Historical polls and rankings Poll rankings
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>ApiResponse of ICollection&lt;RankingWeek&gt;</returns>
        public ApiResponse< ICollection<RankingWeek> > GetRankingsWithHttpInfo (int? year, int? week = null, string seasonType = null)
        {
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling RankingsApi->GetRankings");

            var localVarPath = "./rankings";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (week != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "week", week)); // query parameter
            if (seasonType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seasonType", seasonType)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRankings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<RankingWeek>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<RankingWeek>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RankingWeek>)));
        }

        /// <summary>
        /// Historical polls and rankings Poll rankings
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>Task of ICollection&lt;RankingWeek&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<RankingWeek>> GetRankingsAsync (int? year, int? week = null, string seasonType = null)
        {
             ApiResponse<ICollection<RankingWeek>> localVarResponse = await GetRankingsAsyncWithHttpInfo(year, week, seasonType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Historical polls and rankings Poll rankings
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="year">Year/season filter for games</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;RankingWeek&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<RankingWeek>>> GetRankingsAsyncWithHttpInfo (int? year, int? week = null, string seasonType = null)
        {
            // verify the required parameter 'year' is set
            if (year == null)
                throw new ApiException(400, "Missing required parameter 'year' when calling RankingsApi->GetRankings");

            var localVarPath = "./rankings";
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

            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (week != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "week", week)); // query parameter
            if (seasonType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seasonType", seasonType)); // query parameter

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetRankings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<RankingWeek>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<RankingWeek>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<RankingWeek>)));
        }

    }
}
