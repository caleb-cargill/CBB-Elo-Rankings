using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CBB_Elo_Ratings.Data
{
	public class GamesService
	{
		public static async Task<Models.Game[]> GetGamesByDate(DateTime dateTime)
            => await Common.GetRequest<Models.Game[]>($"GamesByDate/{dateTime.ToString("yyyy - MMM - dd").ToUpper()}");

		public static async Task<Models.Game[]> GetTeamSchedule(string season, string team)
            => await Common.GetRequest<Models.Game[]>($"TeamSchedule/{season}/{team}");
	}
}

