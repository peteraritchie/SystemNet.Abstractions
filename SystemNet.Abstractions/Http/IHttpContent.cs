using System.IO;
using System.Threading.Tasks;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpContent
	{
		/// <summary>Gets the HTTP content headers as defined in RFC 2616.</summary>
		/// <returns>The content headers as defined in RFC 2616.</returns>
		IHttpContentHeaders Headers { get; }

		/// <summary>Serialize the HTTP content to a string as an asynchronous operation.</summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task<string> ReadAsStringAsync();

		/// <summary>Serialize the HTTP content to a byte array as an asynchronous operation.</summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task<byte[]> ReadAsByteArrayAsync();

		/// <summary>Serialize the HTTP content and return a stream that represents the content as an asynchronous operation. </summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task<Stream> ReadAsStreamAsync();

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <param name="stream">The target stream.</param>
		/// <param name="context">Information about the transport (channel binding token, for example). This parameter may be <see langword="null" />.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task CopyToAsync(Stream stream, System.Net.TransportContext context);

		/// <summary>Serialize the HTTP content into a stream of bytes and copies it to the stream object provided as the <paramref name="stream" /> parameter.</summary>
		/// <param name="stream">The target stream.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task CopyToAsync(Stream stream);

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task LoadIntoBufferAsync();

		/// <summary>Serialize the HTTP content to a memory buffer as an asynchronous operation.</summary>
		/// <param name="maxBufferSize">The maximum size, in bytes, of the buffer to use.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		Task LoadIntoBufferAsync(long maxBufferSize);
	}
}