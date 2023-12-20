// <auto-generated>

using System;

namespace Beam.Client
{
    /// <summary>
    /// A token constructed from an apiKey.
    /// </summary>
    public class ApiKeyToken : TokenBase
    {
        private string _raw;
        public string Header;

        /// <summary>
        /// Constructs an ApiKeyToken object.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="prefix"></param>
        /// <param name="timeout"></param>
        public ApiKeyToken(string value, string prefix = "", TimeSpan? timeout = null, string header = "x-api-key") : base(timeout)
        {
            _raw = $"{ prefix }{ value }";
            Header = header;
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        public virtual void UseInHeader(System.Net.Http.HttpRequestMessage request)
        {
            request.Headers.Add(Header, _raw);
        }

        /// <summary>
        /// Places the token in the query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="uriBuilder"></param>
        /// <param name="parseQueryString"></param>
        /// <param name="parameterName"></param>
        public virtual void UseInQuery(System.Net.Http.HttpRequestMessage request, UriBuilder uriBuilder, System.Collections.Specialized.NameValueCollection parseQueryString, string parameterName)
        {
            parseQueryString[parameterName] = Uri.EscapeDataString(_raw).ToString();
        }
    }
}