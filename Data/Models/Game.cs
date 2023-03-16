using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class Game
	{
            public int GameID { get; set; }
            public int Season { get; set; }
            public int SeasonType { get; set; }
            public string Status { get; set; }
            public DateTime Day { get; set; }
            public DateTime DateTime { get; set; }
            public string AwayTeam { get; set; }
            public string HomeTeam { get; set; }
            public int AwayTeamID { get; set; }
            public int HomeTeamID { get; set; }
            public int AwayTeamScore { get; set; }
            public int HomeTeamScore { get; set; }
            public DateTime Updated { get; set; }
            public string Period { get; set; }
            public object TimeRemainingMinutes { get; set; }
            public object TimeRemainingSeconds { get; set; }
            public double PointSpread { get; set; }
            public double OverUnder { get; set; }
            public int AwayTeamMoneyLine { get; set; }
            public int HomeTeamMoneyLine { get; set; }
            public int GlobalGameID { get; set; }
            public int GlobalAwayTeamID { get; set; }
            public int GlobalHomeTeamID { get; set; }
            public int? TournamentID { get; set; }
            public object Bracket { get; set; }
            public object Round { get; set; }
            public int? AwayTeamSeed { get; set; }
            public int? HomeTeamSeed { get; set; }
            public object AwayTeamPreviousGameID { get; set; }
            public object HomeTeamPreviousGameID { get; set; }
            public object AwayTeamPreviousGlobalGameID { get; set; }
            public object HomeTeamPreviousGlobalGameID { get; set; }
            public object TournamentDisplayOrder { get; set; }
            public string TournamentDisplayOrderForHomeTeam { get; set; }
            public bool IsClosed { get; set; }
            public DateTime GameEndDateTime { get; set; }
            public int? HomeRotationNumber { get; set; }
            public int? AwayRotationNumber { get; set; }
            public object TopTeamPreviousGameId { get; set; }
            public object BottomTeamPreviousGameId { get; set; }
            public string Channel { get; set; }
            public bool NeutralVenue { get; set; }
            public int AwayPointSpreadPayout { get; set; }
            public int HomePointSpreadPayout { get; set; }
            public int OverPayout { get; set; }
            public int UnderPayout { get; set; }
            public DateTime DateTimeUTC { get; set; }
            public int Attendance { get; set; }
            public Stadium Stadium { get; set; }
            public List<Period> Periods { get; set; }
	}
}

