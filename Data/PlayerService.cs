using System;
namespace CBB_Elo_Ratings.Data
{
	public class PlayerService
	{
		public static async Task<Models.Player[]> GetPlayersByTeam(string teamAbbr)
			=> await Common.GetRequest<Models.Player[]>($"Players/{teamAbbr}");
	}
}

