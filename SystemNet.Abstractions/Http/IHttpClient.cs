using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpClient
	{
		Task<IHttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken);

		Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request);

		Task<string> GetStringAsync(Uri requestUri);

		Task<byte[]> GetByteArrayAsync(Uri requestUri);

		Task<Stream> GetStreamAsync(Uri requestUri);

		Task<IHttpResponseMessage> GetAsync(Uri requestUri);

		Task<IHttpResponseMessage> GetAsync(Uri requestUri, System.Net.Http.HttpCompletionOption completionOption);

		Task<IHttpResponseMessage> GetAsync(Uri requestUri, System.Net.Http.HttpCompletionOption completionOption,
			CancellationToken cancellationToken);

		Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content);

		Task<IHttpResponseMessage> PostAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken);

		Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content);

		Task<IHttpResponseMessage> PutAsync(Uri requestUri, IHttpContent content, CancellationToken cancellationToken);

		Task<IHttpResponseMessage> DeleteAsync(Uri requestUri);

		Task<IHttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken);

		Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, CancellationToken cancellationToken);

		Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption);

		Task<IHttpResponseMessage> SendAsync(IHttpRequestMessage request, System.Net.Http.HttpCompletionOption completionOption,
			CancellationToken cancellationToken);
	}
}
