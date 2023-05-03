using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldcupLib.Models
{
	public class Result
 {
  private const char Del = '|';
  public int Id { get; set; }
  public string Country { get; set; }
  public object Alternate_name { get; set; }
  public string Fifa_code { get; set; }
  public int Group_id { get; set; }
  public string Group_letter { get; set; }
  public int Wins { get; set; }
  public int Draws { get; set; }
  public int Losses { get; set; }
  public int Games_played { get; set; }
  public int Points { get; set; }
  public int Goals_for { get; set; }
  public int Goals_against { get; set; }
  public int Goal_differential { get; set; }

  internal static Result ParseFromFile(string line)
  {
   string[] lines = line.Split(Del);

   return new Result
   {
    Id = int.Parse(lines[0]),
    Country = lines[1],
    Alternate_name = lines[2],
    Fifa_code = lines[3],
    Group_id = int.Parse(lines[4]),
    Group_letter = lines[5],
    Wins = int.Parse(lines[6]),
    Games_played = int.Parse(lines[7]),
    Points = int.Parse(lines[8]),
    Goals_for = int.Parse(lines[9]),
    Goals_against = int.Parse(lines[10]),
    Goal_differential = int.Parse(lines[11]),

   };
  }
  public override string ToString()=> $"Name:{Country}{Environment.NewLine}Code:{Fifa_code} GamesPlayed:{Games_played} Win: {Wins} Lose:{Losses} Draw:{Draws} {Environment.NewLine}Goals:{Goals_for}/{Goals_against}{Environment.NewLine}Goals Diff:{Goal_differential}";
 }
}
