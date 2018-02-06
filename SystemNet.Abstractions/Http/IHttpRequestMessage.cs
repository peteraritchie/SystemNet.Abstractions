using System;
using System.Collections.Generic;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpRequestMessage : IDisposable
	{
		/// <summary>Gets or sets the HTTP message version.</summary>
		/// <returns>The HTTP message version. The default is 1.1.</returns>
		Version Version { get; set; }

		/// <summary>Gets or sets the contents of the HTTP message. </summary>
		/// <returns>The content of a message</returns>
		IHttpContent Content { get; set; }

		/// <summary>Gets or sets the HTTP method used by the HTTP request message.</summary>
		/// <returns>The HTTP method used by the request message. The default is the GET method.</returns>
		System.Net.Http.HttpMethod Method { get; set; }

		/// <summary>Gets or sets the <see cref="T:System.Uri" /> used for the HTTP request.</summary>
		/// <returns>The <see cref="T:System.Uri" /> used for the HTTP request.</returns>
		Uri RequestUri { get; set; }

		/// <summary>Gets the collection of HTTP request headers.</summary>
		/// <returns>The collection of HTTP request headers.</returns>
		System.Net.Http.Headers.HttpRequestHeaders Headers { get; }

		/// <summary>Gets a set of properties for the HTTP request.</summary>
		/// <returns>Returns <see cref="T:System.Collections.Generic.IDictionary`2" />.</returns>
		IDictionary<string, object> Properties { get; }

		/// <summary>Returns a string that represents the current object.</summary>
		/// <returns>A string representation of the current object.</returns>
		string ToString();
	}
}