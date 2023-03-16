using System;
namespace CBB_Elo_Ratings.Data.Models
{
	public class TeamStats
	{
        public int StatID { get; set; }
        public int TeamID { get; set; }
        public int SeasonType { get; set; }
        public int Season { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public object ConferenceWins { get; set; }
        public object ConferenceLosses { get; set; }
        public int GlobalTeamID { get; set; }
        public double Possessions { get; set; }
        public int GameID { get; set; }
        public int OpponentID { get; set; }
        public string Opponent { get; set; }
        public DateTime Day { get; set; }
        public DateTime DateTime { get; set; }
        public string HomeOrAway { get; set; }
        public bool IsGameOver { get; set; }
        public int GlobalGameID { get; set; }
        public int GlobalOpponentID { get; set; }
        public DateTime Updated { get; set; }
        public int Games { get; set; }
        public double FantasyPoints { get; set; }
        public int Minutes { get; set; }
        public int FieldGoalsMade { get; set; }
        public int FieldGoalsAttempted { get; set; }
        public double FieldGoalsPercentage { get; set; }
        public double EffectiveFieldGoalsPercentage { get; set; }
        public int TwoPointersMade { get; set; }
        public int TwoPointersAttempted { get; set; }
        public double TwoPointersPercentage { get; set; }
        public int ThreePointersMade { get; set; }
        public int ThreePointersAttempted { get; set; }
        public double ThreePointersPercentage { get; set; }
        public int FreeThrowsMade { get; set; }
        public int FreeThrowsAttempted { get; set; }
        public double FreeThrowsPercentage { get; set; }
        public int OffensiveRebounds { get; set; }
        public int DefensiveRebounds { get; set; }
        public int Rebounds { get; set; }
        public object OffensiveReboundsPercentage { get; set; }
        public object DefensiveReboundsPercentage { get; set; }
        public object TotalReboundsPercentage { get; set; }
        public int Assists { get; set; }
        public int Steals { get; set; }
        public int BlockedShots { get; set; }
        public int Turnovers { get; set; }
        public int PersonalFouls { get; set; }
        public int Points { get; set; }
        public double TrueShootingAttempts { get; set; }
        public double TrueShootingPercentage { get; set; }
        public object PlayerEfficiencyRating { get; set; }
        public object AssistsPercentage { get; set; }
        public object StealsPercentage { get; set; }
        public object BlocksPercentage { get; set; }
        public object TurnOversPercentage { get; set; }
        public object UsageRatePercentage { get; set; }
        public double FantasyPointsFanDuel { get; set; }
        public double FantasyPointsDraftKings { get; set; }
        public object FantasyPointsYahoo { get; set; }
    }
}

