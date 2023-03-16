using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CBB_Elo_Ratings.Data
{
	public class TeamsService
	{
        public static async Task<Models.Team[]> GetTeamsAsync()
        {
            try
            {
                string searchString = DataContext.SearchString($"teams");
                using (HttpResponseMessage response = await DataContext.ApiClient.GetAsync(searchString))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string results = await response.Content.ReadAsStringAsync();

                        var root = JsonConvert.DeserializeObject<Models.Team[]>(results);

                        return root;
                    }
                    else
                    {
                        throw new Exception($"Exception getting teams. Reason: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                return new Data.Models.Team[] { };
            }
        }
    }
}

