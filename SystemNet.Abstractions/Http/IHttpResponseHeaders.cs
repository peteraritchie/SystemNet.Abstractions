using System;
using System.Collections.Generic;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpResponseHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>
	{
		/// <summary>Gets the value of the <see langword="Accept-Ranges" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Accept-Ranges" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<string> AcceptRanges { get; }

		/// <summary>Gets or sets the value of the <see langword="Age" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Age" /> header for an HTTP response.</returns>
		TimeSpan? Age { get; set; }

		/// <summary>Gets or sets the value of the <see langword="ETag" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="ETag" /> header for an HTTP response.</returns>
		System.Net.Http.Headers.EntityTagHeaderValue ETag { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Location" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Location" /> header for an HTTP response.</returns>
		Uri Location { get; set; }

		/// <summary>Gets the value of the <see langword="Proxy-Authenticate" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Proxy-Authenticate" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue> ProxyAuthenticate { get; }

		/// <summary>Gets or sets the value of the <see langword="Retry-After" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Retry-After" /> header for an HTTP response.</returns>
		System.Net.Http.Headers.RetryConditionHeaderValue RetryAfter { get; set; }

		/// <summary>Gets the value of the <see langword="Server" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Server" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.ProductInfoHeaderValue> Server { get; }

		/// <summary>Gets the value of the <see langword="Vary" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Vary" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<string> Vary { get; }

		/// <summary>Gets the value of the <see langword="WWW-Authenticate" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="WWW-Authenticate" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.AuthenticationHeaderValue> WwwAuthenticate { get; }

		/// <summary>Gets or sets the value of the <see langword="Cache-Control" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Cache-Control" /> header for an HTTP response.</returns>
		System.Net.Http.Headers.CacheControlHeaderValue CacheControl { get; set; }

		/// <summary>Gets the value of the <see langword="Connection" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Connection" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<string> Connection { get; }

		/// <summary>Gets or sets a value that indicates if the <see langword="Connection" /> header for an HTTP response contains Close.</summary>
		/// <returns>
		/// <see langword="true" /> if the <see langword="Connection" /> header contains Close, otherwise <see langword="false" />.</returns>
		bool? ConnectionClose { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Date" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Date" /> header for an HTTP response.</returns>
		DateTimeOffset? Date { get; set; }

		/// <summary>Gets the value of the <see langword="Pragma" /> header for an HTTP response.</summary>
		/// <returns>Returns <see cref="T:IHttpHeaderValueCollection`1" />.The value of the <see langword="Pragma" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.NameValueHeaderValue> Pragma { get; }

		/// <summary>Gets the value of the <see langword="Trailer" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Trailer" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<string> Trailer { get; }

		/// <summary>Gets the value of the <see langword="Transfer-Encoding" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Transfer-Encoding" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.TransferCodingHeaderValue> TransferEncoding { get; }

		/// <summary>Gets or sets a value that indicates if the <see langword="Transfer-Encoding" /> header for an HTTP response contains chunked.</summary>
		/// <returns>
		/// <see langword="true" /> if the <see langword="Transfer-Encoding" /> header contains chunked, otherwise <see langword="false" />.</returns>
		bool? TransferEncodingChunked { get; set; }

		/// <summary>Gets the value of the <see langword="Upgrade" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Upgrade" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.ProductHeaderValue> Upgrade { get; }

		/// <summary>Gets the value of the <see langword="Via" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Via" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.ViaHeaderValue> Via { get; }

		/// <summary>Gets the value of the <see langword="Warning" /> header for an HTTP response.</summary>
		/// <returns>The value of the <see langword="Warning" /> header for an HTTP response.</returns>
		IHttpHeaderValueCollection<System.Net.Http.Headers.WarningHeaderValue> Warning { get; }
	}
}