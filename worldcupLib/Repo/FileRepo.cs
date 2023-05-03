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
	public class FileRepo : IFile
	{
		//private static readonly string DIR = @"C:\Users\karlo_6zwakzv\Desktop\Faks\4. Semestar\Projektni zadaci\OOP - praktikum u.NET okolini\OOP-KarloHruskovec\Settings\";

		private static readonly string DIR =  @"..\..\..\Settings\";
		private readonly string LanguagePath = DIR + "postavke.txt";
		private readonly string TeamPath = DIR + "omiljenaekipa.txt";
		private readonly string PlayersPath = DIR + "omiljeniigraci.txt";
		private readonly string ResolutionPath = DIR + "resolution.txt";
		private readonly string PlayerImagesPath = DIR + "playerImages.txt";


		public FileRepo()
		{
			if (!Directory.Exists(DIR))
			{
				Directory.CreateDirectory(DIR);
			}
		}
		private void CreateIfNonExists(string path)
		{
			if (!File.Exists(path))
				File.Create(path).Close();
		}

		public void SaveSettings(string lang, string champ)
		{
			CreateIfNonExists(LanguagePath);
			using (StreamWriter writer = new StreamWriter(LanguagePath))
			{
				writer.WriteLine(lang);
				writer.WriteLine(champ);
			}
		}
		public List<string> LoadSettings()
		{
			CreateIfNonExists(LanguagePath);
			List<string> data = new List<string>();
			using (StreamReader reader = new StreamReader(LanguagePath))
			{
				string jezik = reader.ReadLine();
				string prvenstvo = reader.ReadLine();
				data.Add(jezik);
				data.Add(prvenstvo);
			}
			return data;
		}

		public void SaveResolution(string resolution)
		{
			CreateIfNonExists(ResolutionPath);
			using (StreamWriter writer = new StreamWriter(ResolutionPath))
			{
				writer.WriteLine(resolution);

			}
		}
		public string LoadResolution()
		{
			string resolution;

			using (StreamReader reader = new StreamReader(ResolutionPath))
			{
				resolution = reader.ReadLine();
			}
			return resolution;
		}

		public void SaveFavoriteTeam(Team team)
		{
			CreateIfNonExists(TeamPath);
			using (StreamWriter writer = new StreamWriter(TeamPath))
			{
				writer.WriteLine($"{team.Country}");
			}
		}
		public string LoadFavoriteTeam()
		{
			CreateIfNonExists(TeamPath);
			using (StreamReader reader = new StreamReader(TeamPath))
			{
				return reader.ReadLine();
			}
		}

		public void SaveFavoritePlayers(IList<Player> igraci)
		{
			CreateIfNonExists(PlayersPath);
			var json = JsonConvert.SerializeObject(igraci);
			File.WriteAllText(PlayersPath, json);

		}
		public List<Player> LoadFavoritePlayers()
		{
			CreateIfNonExists(PlayersPath);
			List<Player> players = new List<Player>();

			string lines = File.ReadAllText(PlayersPath);
			players = JsonConvert.DeserializeObject<List<Player>>(lines);
			return players;
		}

		public void SavePlayerImages(Player players)
		{
			CreateIfNonExists(PlayerImagesPath);
			var json = JsonConvert.SerializeObject(players);
			File.AppendAllText(PlayerImagesPath, json + Environment.NewLine);
		}

		public List<Player> LoadPlayerImages()
		{
			List<Player> players = new List<Player>();

			CreateIfNonExists(PlayerImagesPath);
			var serializer = new JsonSerializer();
			string json = File.ReadAllText(PlayerImagesPath);
			using (var tmp = new StringReader(json))
			{
				using (var jsonTextReader = new JsonTextReader(tmp))
				{
					jsonTextReader.SupportMultipleContent = true;
					while (jsonTextReader.Read())
					{
						var data = serializer.Deserialize<Player>(jsonTextReader);
						players.Add(data);
					}
				}
			}
			return players;
		}
	}
}
