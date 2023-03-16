using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CBB_Elo_Ratings.Data
{
	public class GamesService
	{
		public static async Task<Models.Game[]> GetGamesByDate(DateTime dateTime)
		{
			try
			{
				string searchString = DataContext.SearchString($"GamesByDate/{dateTime.ToString("yyyy-MMM-dd").ToUpper()}");
				using (HttpResponseMessage response = await DataContext.ApiClient.GetAsync(searchString))
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

            catch (Exception ex)
			{
				return new Models.Game[] { };
			}
		}

		public static async Task<Models.Game[]> GetTeamSchedule(string season, string team)
		{
            try
            {
                string searchString = DataContext.SearchString($"TeamSchedule/{season}/{team}");
                using (HttpResponseMessage response = await DataContext.ApiClient.GetAsync(searchString))
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
            catch (Exception ex)
            {
                return new Models.Game[] { };
            }
        }
	}
}

