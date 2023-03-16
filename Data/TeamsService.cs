using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CBB_Elo_Ratings.Data
{
	public class TeamsService
	{
        public static async Task<Models.Team[]> GetTeamsAsync()
            => await Common.GetRequest<Models.Team[]>($"teams");
    }
}

