using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using worldcupLib.Models;

namespace worldcupLib.Interface
{
	public interface IRepo
	{
  Task<List<Event>> GetAllEvents(string country, List<Match> matches);
  Task<List<TeamMatch>> GetAwayTeams(string country);
  Task<List<Player>> GetStartingEleven(string country1, string country2);
  Task<Match> GetMatch(string country1, string country2);
  Task<IList<Result>> GetResult();
  Task<List<Team>> GetTeams();
  Task<List<Match>> GetMatches();
  Task<HashSet<Player>> GetPlayers(string players);
  Task<List<Match>> GetMatchesByCountry(string country);
 }
}
