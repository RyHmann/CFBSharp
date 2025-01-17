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
    public interface IBettingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Betting lines
        /// </summary>
        /// <remarks>
        /// Closing betting lines
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ICollection&lt;GameLines&gt;</returns>
        ICollection<GameLines> GetLines (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null);

        /// <summary>
        /// Betting lines
        /// </summary>
        /// <remarks>
        /// Closing betting lines
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;GameLines&gt;</returns>
        ApiResponse<ICollection<GameLines>> GetLinesWithHttpInfo (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Betting lines
        /// </summary>
        /// <remarks>
        /// Closing betting lines
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ICollection&lt;GameLines&gt;</returns>
        System.Threading.Tasks.Task<ICollection<GameLines>> GetLinesAsync (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null);

        /// <summary>
        /// Betting lines
        /// </summary>
        /// <remarks>
        /// Closing betting lines
        /// </remarks>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;GameLines&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<ICollection<GameLines>>> GetLinesAsyncWithHttpInfo (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BettingApi : IBettingApi
    {
        private CFBSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BettingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BettingApi(String basePath)
        {
            this.Configuration = new CFBSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = CFBSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BettingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BettingApi(CFBSharp.Client.Configuration configuration = null)
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
        /// Betting lines Closing betting lines
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ICollection&lt;GameLines&gt;</returns>
        public ICollection<GameLines> GetLines (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null)
        {
             ApiResponse<ICollection<GameLines>> localVarResponse = GetLinesWithHttpInfo(gameId, year, week, seasonType, team, home, away, conference);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Betting lines Closing betting lines
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>ApiResponse of ICollection&lt;GameLines&gt;</returns>
        public ApiResponse< ICollection<GameLines> > GetLinesWithHttpInfo (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null)
        {

            var localVarPath = "./lines";
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

            if (gameId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "gameId", gameId)); // query parameter
            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (week != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "week", week)); // query parameter
            if (seasonType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seasonType", seasonType)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (home != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "home", home)); // query parameter
            if (away != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "away", away)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter

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
                Exception exception = ExceptionFactory("GetLines", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<GameLines>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<GameLines>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GameLines>)));
        }

        /// <summary>
        /// Betting lines Closing betting lines
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ICollection&lt;GameLines&gt;</returns>
        public async System.Threading.Tasks.Task<ICollection<GameLines>> GetLinesAsync (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null)
        {
             ApiResponse<ICollection<GameLines>> localVarResponse = await GetLinesAsyncWithHttpInfo(gameId, year, week, seasonType, team, home, away, conference);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Betting lines Closing betting lines
        /// </summary>
        /// <exception cref="CFBSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameId">Game id filter (optional)</param>
        /// <param name="year">Year/season filter for games (optional)</param>
        /// <param name="week">Week filter (optional)</param>
        /// <param name="seasonType">Season type filter (regular or postseason) (optional, default to regular)</param>
        /// <param name="team">Team (optional)</param>
        /// <param name="home">Home team filter (optional)</param>
        /// <param name="away">Away team filter (optional)</param>
        /// <param name="conference">Conference abbreviation filter (optional)</param>
        /// <returns>Task of ApiResponse (ICollection&lt;GameLines&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ICollection<GameLines>>> GetLinesAsyncWithHttpInfo (int? gameId = null, int? year = null, int? week = null, string seasonType = null, string team = null, string home = null, string away = null, string conference = null)
        {

            var localVarPath = "./lines";
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

            if (gameId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "gameId", gameId)); // query parameter
            if (year != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "year", year)); // query parameter
            if (week != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "week", week)); // query parameter
            if (seasonType != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "seasonType", seasonType)); // query parameter
            if (team != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "team", team)); // query parameter
            if (home != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "home", home)); // query parameter
            if (away != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "away", away)); // query parameter
            if (conference != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "conference", conference)); // query parameter

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
                Exception exception = ExceptionFactory("GetLines", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ICollection<GameLines>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ICollection<GameLines>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<GameLines>)));
        }

    }
}
