using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldcupLib.Models
{
	public class Team
	{
  public int Id { get; set; }
  public string Country { get; set; }
  public object Alternate_name { get; set; }
  public string Fifa_code { get; set; }
  public int Group_id { get; set; }
  public string Group_letter { get; set; }
  public override string ToString() => $"{Country} ({Fifa_code})";
 }
}
