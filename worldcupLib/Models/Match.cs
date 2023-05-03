using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldcupLib.Models
{
	public class Match : IComparable<Match>
	{
		public string Venue { get; set; }
		public string Location { get; set; }
		public string Status { get; set; }
		public string Time { get; set; }
		public string Fifa_id { get; set; }
		public Weather Weather { get; set; }
		public int Attendance { get; set; }
		public List<string> Officials { get; set; }
		public string Stage_name { get; set; }
		public string Home_team_country { get; set; }
		public string Away_team_country { get; set; }
		public DateTime Datetime { get; set; }
		public string Winner { get; set; }
		public string Winner_code { get; set; }
		public TeamMatch Home_team { get; set; }
		public TeamMatch Away_team { get; set; }
		public List<Event> Home_team_events { get; set; }
		public List<Event> Away_team_events { get; set; }
		public HomeTeamStatistics Home_team_statistics { get; set; }
		public AwayTeamStatistics Away_team_statistics { get; set; }
		public DateTime Last_event_update_at { get; set; }
		public DateTime? Last_score_update_at { get; set; }

		public int CompareTo(Match other) => Attendance.CompareTo(other.Attendance);
		public override string ToString()	=> $"Venue: {Venue} Location: {Location} Temeperatura: {Weather.Temp_celsius} Vrijeme: {Datetime} Hometeam: {Home_team} AwayTeam: {Away_team}";
	}
	public class TeamMatch
	{
		public string Country { get; set; }
		public string Code { get; set; }
		public int Goals { get; set; }
		public int Penalties { get; set; }

		public override string ToString() => $"{Country}";
	}

	public class Weather
	{
		public string Humidity { get; set; }
		public string Temp_celsius { get; set; }
		public string Temp_farenheit { get; set; }
		public string Wind_speed { get; set; }
		public string Description { get; set; }
	}

	public class HomeTeamStatistics
	{
		public string Country { get; set; }
		public int Attempts_on_goal { get; set; }
		public int On_target { get; set; }
		public int Off_target { get; set; }
		public int Blocked { get; set; }
		public int Woodwork { get; set; }
		public int Corners { get; set; }
		public int Offsides { get; set; }
		public int Ball_possession { get; set; }
		public int Pass_accuracy { get; set; }
		public int Num_passes { get; set; }
		public int Passes_completed { get; set; }
		public int Distance_covered { get; set; }
		public int Balls_recovered { get; set; }
		public int Tackles { get; set; }
		public int? Clearances { get; set; }
		public int? Yellow_cards { get; set; }
		public int? Red_cards { get; set; }
		public int? Fouls_committed { get; set; }
		public string Tactics { get; set; }
		public List<StartingEleven> Starting_eleven { get; set; }
		public List<Substitute> Substitutes { get; set; }
	}

	public class AwayTeamStatistics
	{
		public string Country { get; set; }
		public int Attempts_on_goal { get; set; }
		public int On_target { get; set; }
		public int Off_target { get; set; }
		public int Blocked { get; set; }
		public int Woodwork { get; set; }
		public int Corners { get; set; }
		public int Offsides { get; set; }
		public int Ball_possession { get; set; }
		public int Pass_accuracy { get; set; }
		public int Num_passes { get; set; }
		public int Passes_completed { get; set; }
		public int Distance_covered { get; set; }
		public int Balls_recovered { get; set; }
		public int Tackles { get; set; }
		public int? Clearances { get; set; }
		public int? Red_cards { get; set; }
		public int? Yellow_cards { get; set; }
		public int? Fouls_committed { get; set; }
		public string Tactics { get; set; }
		public List<StartingEleven> Starting_eleven { get; set; }
		public List<Substitute> Substitutes { get; set; }
	}

	public class HomeTeam : TeamMatch
	{

	}

	public class AwayTeam : TeamMatch
	{

	}

	public class HomeTeamEvent : Event
	{

	}

	public class AwayTeamEvent : Event
	{

	}

	public class StartingEleven : Player
	{

	}

	public class Substitute : Player
	{

	}


}
