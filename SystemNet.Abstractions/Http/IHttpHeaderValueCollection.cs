using System.Collections.Generic;

namespace PRI.SystemNet.Abstractions.Http
{
	public interface IHttpHeaderValueCollection<T> : ICollection<T> where T : class
	{
		/// <summary>Parses and adds an entry to the <see cref="T:IHttpHeaderValueCollection`1" />.</summary>
		/// <param name="input">The entry to add.</param>
		void ParseAdd(string input);

		/// <summary>Determines whether the input could be parsed and added to the <see cref="T:IHttpHeaderValueCollection`1" />.</summary>
		/// <param name="input">The entry to validate.</param>
		/// <returns>
		/// <see langword="true" /> if the <paramref name="input" /> could be parsed and added to the <see cref="T:IHttpHeaderValueCollection`1" /> instance; otherwise, <see langword="false" /></returns>
		bool TryParseAdd(string input);
	}
}