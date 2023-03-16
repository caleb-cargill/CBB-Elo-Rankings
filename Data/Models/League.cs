using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class League
	{
        public int ConferenceID { get; set; }
        public string Name { get; set; }
        public List<Team> Teams { get; set; }
    }
}

