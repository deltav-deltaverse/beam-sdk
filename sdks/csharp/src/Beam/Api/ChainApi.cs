// <auto-generated>
/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Beam.Client;
using Beam.Model;
using System.Diagnostics.CodeAnalysis;

namespace Beam.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IChainApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        ChainApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IChainApiResponse"/>&gt;</returns>
        Task<IChainApiResponse> ChainAsync(Option<decimal> chainId = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="chainId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IChainApiResponse"/>&gt;</returns>
        Task<IChainApiResponse> ChainOrDefaultAsync(Option<decimal> chainId = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Estimate gas fee for a transaction on behalf of a profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEstimateProfileTransactionGasApiResponse"/>&gt;</returns>
        Task<IEstimateProfileTransactionGasApiResponse> EstimateProfileTransactionGasAsync(CreateTransactionRequestInput createTransactionRequestInput, string entityId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Estimate gas fee for a transaction on behalf of a profile
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEstimateProfileTransactionGasApiResponse"/>&gt;</returns>
        Task<IEstimateProfileTransactionGasApiResponse> EstimateProfileTransactionGasOrDefaultAsync(CreateTransactionRequestInput createTransactionRequestInput, string entityId, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="IChainApiResponse"/>
    /// </summary>
    public interface IChainApiResponse : Beam.Client.IApiResponse, IOk<Beam.Model.GetChainResponse>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// The <see cref="IEstimateProfileTransactionGasApiResponse"/>
    /// </summary>
    public interface IEstimateProfileTransactionGasApiResponse : Beam.Client.IApiResponse, IOk<Beam.Model.GetEstimateResponse>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ChainApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnChain;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorChain;

        internal void ExecuteOnChain(ChainApi.ChainApiResponse apiResponse)
        {
            OnChain?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorChain(Exception exception)
        {
            OnErrorChain?.Invoke(this, new ExceptionEventArgs(exception));
        }

        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnEstimateProfileTransactionGas;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorEstimateProfileTransactionGas;

        internal void ExecuteOnEstimateProfileTransactionGas(ChainApi.EstimateProfileTransactionGasApiResponse apiResponse)
        {
            OnEstimateProfileTransactionGas?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorEstimateProfileTransactionGas(Exception exception)
        {
            OnErrorEstimateProfileTransactionGas?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class ChainApi : IChainApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<ChainApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public ChainApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChainApi(ILogger<ChainApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, ChainApiEvents chainApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<ChainApi>();
            HttpClient = httpClient;
            Events = chainApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatChain(ref Option<decimal> chainId);

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="chainId"></param>
        private void AfterChainDefaultImplementation(IChainApiResponse apiResponseLocalVar, Option<decimal> chainId)
        {
            bool suppressDefaultLog = false;
            AfterChain(ref suppressDefaultLog, apiResponseLocalVar, chainId);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="chainId"></param>
        partial void AfterChain(ref bool suppressDefaultLog, IChainApiResponse apiResponseLocalVar, Option<decimal> chainId);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="chainId"></param>
        private void OnErrorChainDefaultImplementation(Exception exception, string pathFormat, string path, Option<decimal> chainId)
        {
            bool suppressDefaultLog = false;
            OnErrorChain(ref suppressDefaultLog, exception, pathFormat, path, chainId);
            if (!suppressDefaultLog)
                Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="chainId"></param>
        partial void OnErrorChain(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, Option<decimal> chainId);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="chainId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IChainApiResponse"/>&gt;</returns>
        public async Task<IChainApiResponse> ChainOrDefaultAsync(Option<decimal> chainId = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await ChainAsync(chainId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IChainApiResponse"/>&gt;</returns>
        public async Task<IChainApiResponse> ChainAsync(Option<decimal> chainId = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                FormatChain(ref chainId);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/chain";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (chainId.IsSet)
                        parseQueryStringLocalVar["chainId"] = chainId.Value.ToString();

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar;
                    apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);
                    apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "x-api-key");

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Get;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<ChainApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<ChainApiResponse>();

                        ChainApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/chain", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterChainDefaultImplementation(apiResponseLocalVar, chainId);

                        Events.ExecuteOnChain(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorChainDefaultImplementation(e, "/v1/chain", uriBuilderLocalVar.Path, chainId);
                Events.ExecuteOnErrorChain(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="ChainApiResponse"/>
        /// </summary>
        public partial class ChainApiResponse : Beam.Client.ApiResponse, IChainApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<ChainApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="ChainApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public ChainApiResponse(ILogger<ChainApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Beam.Model.GetChainResponse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Beam.Model.GetChainResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Beam.Model.GetChainResponse result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }

        partial void FormatEstimateProfileTransactionGas(CreateTransactionRequestInput createTransactionRequestInput, ref string entityId);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        /// <returns></returns>
        private void ValidateEstimateProfileTransactionGas(CreateTransactionRequestInput createTransactionRequestInput, string entityId)
        {
            if (createTransactionRequestInput == null)
                throw new ArgumentNullException(nameof(createTransactionRequestInput));

            if (entityId == null)
                throw new ArgumentNullException(nameof(entityId));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        private void AfterEstimateProfileTransactionGasDefaultImplementation(IEstimateProfileTransactionGasApiResponse apiResponseLocalVar, CreateTransactionRequestInput createTransactionRequestInput, string entityId)
        {
            bool suppressDefaultLog = false;
            AfterEstimateProfileTransactionGas(ref suppressDefaultLog, apiResponseLocalVar, createTransactionRequestInput, entityId);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        partial void AfterEstimateProfileTransactionGas(ref bool suppressDefaultLog, IEstimateProfileTransactionGasApiResponse apiResponseLocalVar, CreateTransactionRequestInput createTransactionRequestInput, string entityId);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        private void OnErrorEstimateProfileTransactionGasDefaultImplementation(Exception exception, string pathFormat, string path, CreateTransactionRequestInput createTransactionRequestInput, string entityId)
        {
            bool suppressDefaultLog = false;
            OnErrorEstimateProfileTransactionGas(ref suppressDefaultLog, exception, pathFormat, path, createTransactionRequestInput, entityId);
            if (!suppressDefaultLog)
                Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        partial void OnErrorEstimateProfileTransactionGas(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, CreateTransactionRequestInput createTransactionRequestInput, string entityId);

        /// <summary>
        /// Estimate gas fee for a transaction on behalf of a profile 
        /// </summary>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEstimateProfileTransactionGasApiResponse"/>&gt;</returns>
        public async Task<IEstimateProfileTransactionGasApiResponse> EstimateProfileTransactionGasOrDefaultAsync(CreateTransactionRequestInput createTransactionRequestInput, string entityId, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await EstimateProfileTransactionGasAsync(createTransactionRequestInput, entityId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Estimate gas fee for a transaction on behalf of a profile 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="createTransactionRequestInput"></param>
        /// <param name="entityId"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="IEstimateProfileTransactionGasApiResponse"/>&gt;</returns>
        public async Task<IEstimateProfileTransactionGasApiResponse> EstimateProfileTransactionGasAsync(CreateTransactionRequestInput createTransactionRequestInput, string entityId, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateEstimateProfileTransactionGas(createTransactionRequestInput, entityId);

                FormatEstimateProfileTransactionGas(createTransactionRequestInput, ref entityId);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/chain/estimate/profiles/{entityId}/transaction";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7BentityId%7D", Uri.EscapeDataString(entityId.ToString()));

                    httpRequestMessageLocalVar.Content = (createTransactionRequestInput as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(createTransactionRequestInput, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar;
                    apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);
                    apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "x-api-key");

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Post;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<EstimateProfileTransactionGasApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<EstimateProfileTransactionGasApiResponse>();

                        EstimateProfileTransactionGasApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/chain/estimate/profiles/{entityId}/transaction", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterEstimateProfileTransactionGasDefaultImplementation(apiResponseLocalVar, createTransactionRequestInput, entityId);

                        Events.ExecuteOnEstimateProfileTransactionGas(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorEstimateProfileTransactionGasDefaultImplementation(e, "/v1/chain/estimate/profiles/{entityId}/transaction", uriBuilderLocalVar.Path, createTransactionRequestInput, entityId);
                Events.ExecuteOnErrorEstimateProfileTransactionGas(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="EstimateProfileTransactionGasApiResponse"/>
        /// </summary>
        public partial class EstimateProfileTransactionGasApiResponse : Beam.Client.ApiResponse, IEstimateProfileTransactionGasApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<EstimateProfileTransactionGasApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="EstimateProfileTransactionGasApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public EstimateProfileTransactionGasApiResponse(ILogger<EstimateProfileTransactionGasApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Beam.Model.GetEstimateResponse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Beam.Model.GetEstimateResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Beam.Model.GetEstimateResponse result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
