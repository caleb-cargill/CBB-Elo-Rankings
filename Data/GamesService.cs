using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CBB_Elo_Ratings.Data
{
	public class GamesService
	{
		private static string Endpoint = @"https://api.sportsdata.io/v3/cbb/scores/json/";
		private static string AccessKey = "";
		private static HttpClient ApiClient { get; set; }

		static GamesService()
		{
			if (ApiClient == null)
			{
				ApiClient = new HttpClient();
				ApiClient.BaseAddress = new Uri(Endpoint);
				ApiClient.DefaultRequestHeaders.Accept.Clear();
				ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			}
		}


		public static async Task<Models.Game[]> GetGamesByDate(DateTime dateTime)
		{
			try
			{
				string searchString = $"GamesByDate/2023-MAR-15{AccessKey}";
				using (HttpResponseMessage response = await ApiClient.GetAsync(searchString))
				{
					if (response.IsSuccessStatusCode)
					{
						string results = await response.Content.ReadAsStringAsync();

						var root = JsonConvert.DeserializeObject<Models.Game[]>(results);

						return root;
					}
					else
					{
						throw new Exception($"Exception when getting Games By Date. Reason: {response.ReasonPhrase}");
					}
				}
			}
			catch (Exception)
			{
				return new Models.Game[] { };
			}
		}
	}
}

