using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldcupLib.Models
{
	public class Player : IComparable<Player>
	{
		private const char DEL = '|';
		public string Name { get; set; }
		public bool Captain { get; set; }
		public int Shirt_number { get; set; }
		public string Position { get; set; }
		public int MyNumberOfGoals { get; set; }
		public int MyNumberOfYellowCards { get; set; }
		public string ImagePath { get; set; }

		public int CompareTo(Player other) => MyNumberOfGoals.CompareTo(other.MyNumberOfGoals);
		public override bool Equals(object obj) =>	obj is Player player && Name == player.Name;
		public override int GetHashCode() =>	17 + EqualityComparer<string>.Default.GetHashCode(Name);
		public override string ToString() => $"{Name} {Shirt_number} {Position} {Captain} {MyNumberOfGoals}-BrojZutih:{MyNumberOfYellowCards}";
		public string FormatForFile() => $"{Name}{DEL}{Shirt_number}{DEL}{Position}{DEL}{Captain}";
		internal static Player ParsePlayerFromFile(string line)
		{
			string[] detalji = line.Split(DEL);
			return new Player {
				Name = detalji[0],
				Shirt_number = int.Parse(detalji[1]),
				Position = detalji[2],
				Captain = bool.Parse(detalji[3])
			};
		}
	}
}
