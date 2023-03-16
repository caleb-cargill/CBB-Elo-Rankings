using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class Team
	{
        public int TeamID { get; set; }
        public string Key { get; set; }
        public bool Active { get; set; }
        public string School { get; set; }
        public string Name { get; set; }
        public int? ApRank { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? ConferenceWins { get; set; }
        public int? ConferenceLosses { get; set; }
        public int GlobalTeamID { get; set; }
        public int? ConferenceID { get; set; }
        public string Conference { get; set; }
        public string TeamLogoUrl { get; set; }
        public string ShortDisplayName { get; set; }
        public Stadium Stadium { get; set; }
    }
}

