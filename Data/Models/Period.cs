using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class Period
	{
        public int PeriodID { get; set; }
        public int GameID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int AwayScore { get; set; }
        public int HomeScore { get; set; }
    }
}

