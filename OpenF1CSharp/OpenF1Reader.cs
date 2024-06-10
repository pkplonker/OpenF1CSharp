using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenF1CSharp
{
	public class OpenF1Reader : IDisposable
	{
		private readonly HttpClient client;

		public OpenF1Reader()
		{
			client = new HttpClient();
		}

		public async Task<string> Query(string url)
		{
			try
			{
				var response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadAsStringAsync();
			}
			catch (HttpRequestException e)
			{
				throw;
			}
		}

		public void Dispose()
		{
			client.Dispose();
		}
	}
}