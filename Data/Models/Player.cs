using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class Player
	{
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamID { get; set; }
        public string Team { get; set; }
        public int Jersey { get; set; }
        public string Position { get; set; }
        public string Class { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string BirthCity { get; set; }
        public string BirthState { get; set; }
        public string HighSchool { get; set; }
        public string SportRadarPlayerID { get; set; }
        public object RotoworldPlayerID { get; set; }
        public object RotoWirePlayerID { get; set; }
        public object FantasyAlarmPlayerID { get; set; }
        public int GlobalTeamID { get; set; }
        public string InjuryStatus { get; set; }
        public string InjuryBodyPart { get; set; }
        public string InjuryNotes { get; set; }
        public object InjuryStartDate { get; set; }
    }
}

