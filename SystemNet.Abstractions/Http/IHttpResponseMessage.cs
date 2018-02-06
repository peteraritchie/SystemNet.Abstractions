using System;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpResponseMessage : IDisposable
	{
		/// <summary>Gets or sets the HTTP message version. </summary>
		/// <returns>The HTTP message version. The default is 1.1. </returns>
		Version Version { get; set; }

		/// <summary>Gets or sets the content of a HTTP response message. </summary>
		/// <returns>The content of the HTTP response message.</returns>
		IHttpContent Content { get; set; }

		/// <summary>Gets or sets the status code of the HTTP response.</summary>
		/// <returns>The status code of the HTTP response.</returns>
		System.Net.HttpStatusCode StatusCode { get; set; }

		/// <summary>Gets or sets the reason phrase which typically is sent by servers together with the status code. </summary>
		/// <returns>The reason phrase sent by the server.</returns>
		string ReasonPhrase { get; set; }

		/// <summary>Gets the collection of HTTP response headers. </summary>
		/// <returns>The collection of HTTP response headers.</returns>
		IHttpResponseHeaders Headers { get; }

		/// <summary>Gets or sets the request message which led to this response message.</summary>
		/// <returns>The request message which led to this response message.</returns>
		IHttpRequestMessage RequestMessage { get; set; }

		/// <summary>Gets a value that indicates if the HTTP response was successful.</summary>
		/// <returns>A value that indicates if the HTTP response was successful. <see langword="true" /> if <see cref="IHttpResponseMessage.StatusCode" /> was in the range 200-299; otherwise <see langword="false" />.</returns>
		bool IsSuccessStatusCode { get; }

		/// <summary>Throws an exception if the <see cref="IHttpResponseMessage.IsSuccessStatusCode" /> property for the HTTP response is <see langword="false" />.</summary>
		/// <returns>The HTTP response message if the call is successful.</returns>
		IHttpResponseMessage EnsureSuccessStatusCode();

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>A string representation of the current object.</returns>
		string ToString();
	}
}