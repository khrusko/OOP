using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using worldcupLib.Interface;
using worldcupLib.Models;

namespace worldcupLib.Repo
{
	public class MenJson : IRepo
 {
  private static string DIR = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"json-endpoints\worldcup.sfg.io\men\");

  private string MatchesPath = DIR + "matches.json";
  private string ResultsPath = DIR + "results.json";
  private string TeamsPath = DIR + "teams.json";

  public async Task<List<Event>> GetAllEvents(string country, List<Match> mec)
  {
   List<Event> events = new List<Event>();

   foreach (var item in mec)
   {
    if (item.Home_team_country == country || item.Away_team_country == country)
    {
     foreach (var dogadaj in item.Home_team_events)
     {
      events.Add(dogadaj);
     }
     foreach (var dog in item.Away_team_events)
     {
      events.Add(dog);
     }
    }
   }

   return await Task.Run(() => events);
  }

  public async Task<List<TeamMatch>> GetAwayTeams(string country)
  {
   List<TeamMatch> opponents = new List<TeamMatch>();
   List<Match> matches = await GetMatches();

   foreach (var match in matches)
   {
    if (match.Home_team.Country == country || match.Away_team.Country == country)
    {
     if (match.Home_team.Country != country)
     {
      opponents.Add(match.Home_team);
     }
     else
     {
      opponents.Add(match.Away_team);
     }
    }
   }
   return await Task.Run(() => opponents);
  }


  public async Task<Match> GetMatch(string country1, string country2)
  {
   IList<Match> matches = await GetMatches();
   Match match = new Match();
   foreach (var mec in matches)
   {
    if (mec.Home_team_country == country1 && mec.Away_team_country == country2 || mec.Home_team_country == country2 && mec.Away_team_country == country1)
     match = mec;
   }
   return await Task.Run(() => match);
  }

  public async Task<List<Match>> GetMatches()
  {
   List<Match> list = new List<Match>();
   using (StreamReader r = new StreamReader(MatchesPath))
   {
    string json = r.ReadToEnd();
    list = JsonConvert.DeserializeObject<List<Match>>(json);
   }
   return await Task.Run(() =>
   {
    return list;
   });
  }

  public async Task<List<Match>> GetMatchesByCountry(string country)
  {
   List<Match> teams = new List<Match>();
   List<Match> matches = await GetMatches();
   foreach (var mec in matches)
   {
    if (mec.Home_team_country == country || mec.Away_team_country == country)
    {
     teams.Add(mec);
    }
   }
   return await Task.Run(() => teams);
  }

  public async Task<HashSet<Player>> GetPlayers(string country)
  {
   HashSet<Player> matchesSet = new HashSet<Player>();
   List<Match> matches = await GetMatches();

   foreach (Match item in matches)
   {
    if (item.Home_team_statistics.Country == country || item.Home_team_statistics.Country == country)
    {
     foreach (var player in item.Home_team_statistics.Starting_eleven)
     {
      matchesSet.Add(player);
     }
     foreach (var player in item.Home_team_statistics.Substitutes)
     {
      matchesSet.Add(player);
     }
    }
   }
   return await Task.Run(() => matchesSet);
  }

  public async Task<IList<Result>> GetResult()
  {
   List<Result> list = new List<Result>();
   using (StreamReader r = new StreamReader(ResultsPath))
   {
    string json = r.ReadToEnd();
    list = JsonConvert.DeserializeObject<List<Result>>(json);
   }
   return await Task.Run(() =>{return list;});
  }

  public async Task<List<Player>> GetStartingEleven(string country1, string country2)
  {
   List<Player> players = new List<Player>();
   List<Match> matches = await GetMatches();

   foreach (var match in matches)
   {
    if (match.Home_team.Country == country1 && match.Away_team.Country == country2 || match.Home_team_country == country2 && match.Away_team_country == country1)
    {
     foreach (var player in match.Home_team_statistics.Starting_eleven)
     {
      players.Add(player);
     }
    }
   }
   return await Task.Run(() => players);
  }

  public async Task<List<Team>> GetTeams()
  {
   List<Team> list = new List<Team>();
   using (StreamReader r = new StreamReader(TeamsPath))
   {
    string json = r.ReadToEnd();
    list = JsonConvert.DeserializeObject<List<Team>>(json);
   }
   return await Task.Run(() => {return list;});
  }

  public async Task<List<Match>> DajBroj()
  {
   List<Match> matchList = await GetMatches();
   return matchList;
  }


 }
}
