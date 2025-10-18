using HNG_Stage_Zero_Task.Models;
using System.Text.Json;

namespace HNG_Stage_Zero_Task.Services
{
	public class CatFactService(IHttpClientFactory httpClientFactory)
	{
		public async Task<string> GetRandomCatFactAsync()
		{
			var client = httpClientFactory.CreateClient();
			var url = "https://catfact.ninja/fact";

			try
			{
				var response = await client.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					var contentStream = await response.Content.ReadAsStreamAsync();
					var catFact = await JsonSerializer.DeserializeAsync<CatFactResponse>(contentStream);
					return catFact?.Fact ?? "No cat fact found.";
				}
				return "Could not retrieve a cat fact at this time.";
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching cat fact: {ex.Message}");
				return "Failed to fetch cat fact due to a network error.";
			}
		}
	}
}
