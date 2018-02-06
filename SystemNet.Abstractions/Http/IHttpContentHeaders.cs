using System;
using System.Collections.Generic;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpContentHeaders
	{
		/// <summary>Gets the value of the <see langword="Allow" /> content header on an HTTP response. </summary>
		/// <returns>The value of the <see langword="Allow" /> header on an HTTP response.</returns>
		ICollection<string> Allow { get; }

		/// <summary>Gets the value of the <see langword="Content-Disposition" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Disposition" /> content header on an HTTP response.</returns>
		System.Net.Http.Headers.ContentDispositionHeaderValue ContentDisposition { get; set; }

		/// <summary>Gets the value of the <see langword="Content-Encoding" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Encoding" /> content header on an HTTP response.</returns>
		ICollection<string> ContentEncoding { get; }

		/// <summary>Gets the value of the <see langword="Content-Language" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Language" /> content header on an HTTP response.</returns>
		ICollection<string> ContentLanguage { get; }

		/// <summary>Gets or sets the value of the <see langword="Content-Length" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Length" /> content header on an HTTP response.</returns>
		long? ContentLength { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Content-Location" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Location" /> content header on an HTTP response.</returns>
		Uri ContentLocation { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Content-MD5" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-MD5" /> content header on an HTTP response.</returns>
		byte[] ContentMD5 { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Content-Range" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Range" /> content header on an HTTP response.</returns>
		System.Net.Http.Headers.ContentRangeHeaderValue ContentRange { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Content-Type" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Content-Type" /> content header on an HTTP response.</returns>
		System.Net.Http.Headers.MediaTypeHeaderValue ContentType { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Expires" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Expires" /> content header on an HTTP response.</returns>
		DateTimeOffset? Expires { get; set; }

		/// <summary>Gets or sets the value of the <see langword="Last-Modified" /> content header on an HTTP response.</summary>
		/// <returns>The value of the <see langword="Last-Modified" /> content header on an HTTP response.</returns>
		DateTimeOffset? LastModified { get; set; }
	}
}