using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using worldcupLib.Interface;
using worldcupLib.Models;

namespace worldcupLib.Repo
{
	public class WomenRepo : IRepo
 {
  private const string MatchesApiLink = @"http://worldcup.sfg.io/matches";
  private const string TeamsApiLink = @"http://worldcup.sfg.io/teams/";
  private const string ResultsApiLink = @"http://worldcup.sfg.io/teams/results";

  public async Task<List<Match>> GetMatches()
  {
   List<Match> list = new List<Match>();
   var webRequest = WebRequest.Create(MatchesApiLink) as HttpWebRequest;

   webRequest.ContentType = "application/json";
   webRequest.UserAgent = "Nothing";

   using (var s = webRequest.GetResponse().GetResponseStream())
   {
    using (var sr = new StreamReader(s))
    {
     var groupresults = sr.ReadToEnd();
     return await Task.Run(() =>
     {
      return JsonConvert.DeserializeObject<List<Match>>(groupresults);
     });
    }
   }

  }

  public async Task<List<Team>> GetTeams()
  {
   var webRequest = WebRequest.Create(TeamsApiLink) as HttpWebRequest;

   webRequest.ContentType = "application/json";
   webRequest.UserAgent = "Nothing";

   using (var s = webRequest.GetResponse().GetResponseStream())
   {
    using (var sr = new StreamReader(s))
    {
     var teams = sr.ReadToEnd();
     return await Task.Run(() => { return JsonConvert.DeserializeObject<List<Team>>(teams); });
    }
   }

  }
  public async Task<HashSet<Player>> GetPlayers(string country)
  {
   HashSet<Player> matchesSet = new HashSet<Player>();
   List<Match> matches = await GetMatches();

   foreach (Match item in matches)
   {
    if (item.Home_team_statistics.Country == country || item.Home_team_statistics.Country == country)
    {
     foreach (var igrac in item.Home_team_statistics.Starting_eleven)
     {
      matchesSet.Add(igrac);
     }
     foreach (var igrac in item.Home_team_statistics.Substitutes)
     {
      matchesSet.Add(igrac);
     }

    }
   }
   return await Task.Run(() => matchesSet);
  }


  public async Task<List<Event>> GetAllEvents(string country, List<Match> match)
  {
   List<Event> events = new List<Event>();

   foreach (var item in match)
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

  public async Task<List<Match>> GetMatchesByCountry(string country)
  {
   List<Match> teams = new List<Match>();
   List<Match> matches = await GetMatches();
   foreach (var match in matches)
   {
    if (match.Home_team_country == country || match.Away_team_country == country)
    {
     teams.Add(match);
    }
   }
   return await Task.Run(() => teams);
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

  public async Task<Match> GetMatch(string country1, string country2)
  {
   IList<Match> matches = await GetMatches();
   Match match = new Match();
   foreach (var mec in matches)
   {
    if (mec.Home_team_country == country1 && mec.Away_team_country == country2 || mec.Home_team_country == country2 && mec.Away_team_country == country1)
    {
     match = mec;
    }
   }
   return await Task.Run(() => match);
  }

  public async Task<IList<Result>> GetResult()
  {
   List<Result> list = new List<Result>();

   var webRequest = WebRequest.Create(ResultsApiLink) as HttpWebRequest;

   webRequest.ContentType = "application/json";
   webRequest.UserAgent = "Nothing";

   using (var s = webRequest.GetResponse().GetResponseStream())
   {
    using (var sr = new StreamReader(s))
    {
     var results = sr.ReadToEnd();
     return await Task.Run(() =>
     {
      //Thread.Sleep(5000);
      return JsonConvert.DeserializeObject<List<Result>>(results);
     });

    }
   }
  }
 }
}
