using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using worldcupLib;
using worldcupLib.Interface;
using worldcupLib.Models;
using worldcupLib.Repo;

namespace WFApp
{

	public partial class Statistics : System.Windows.Forms.Form
	{

		IRepo repo;
		IFile _repoFile;
		List<Match> matches;
		List<worldcupLib.Models.Player> statisticsPlayers;
		string country;

		public Statistics()
		{
			_repoFile = RepoFactory.GetFileRepository();
			List<string> postavke = _repoFile.LoadSettings();
			string prvenstvo = postavke[1];
			repo = RepoFactory.GetChampionship(prvenstvo);
			InitializeComponent();
			try
			{
				_repoFile = RepoFactory.GetFileRepository();
				country = _repoFile.LoadFavoriteTeam();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		

		private async void Statistics_Load(object sender, EventArgs e)
		{
			try
			{
				matches = await repo.GetMatchesByCountry(country);
				statisticsPlayers = await LoadStatisticsPlayer();
				AddStatsToFlp();
				AddMatchesToFlp();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private async Task<List<worldcupLib.Models.Player>> LoadStatisticsPlayer()
		{
			string country = _repoFile.LoadFavoriteTeam();
			List<worldcupLib.Models.Player> playerList = new List<worldcupLib.Models.Player>();
			HashSet<worldcupLib.Models.Player> players = await repo.GetPlayers(country);
			List<Event> events = await repo.GetAllEvents(country, matches);
			foreach (var igrac in players)
			{
				foreach (var tmp in events)
				{
					if (tmp.Type_of_event == "goal" || tmp.Type_of_event == "goal-penalty")
					{
						if (igrac.Name == tmp.Player)
						{
							igrac.MyNumberOfGoals++;
						}
					}
					if (tmp.Type_of_event == "yellow-card")
					{
						if (igrac.Name == tmp.Player)
						{
							igrac.MyNumberOfYellowCards++;
						}
					}
				}
				playerList.Add(igrac);
			}
			return await Task.Run(() => playerList);
		}

		private void AddStatsToFlp()
		{
			flpStatistics.Controls.Clear();
			foreach (var igrac in statisticsPlayers)
			{
				PlayerStats ucp = new PlayerStats();
				ucp.FullName = igrac.Name;
				ucp.Goals = igrac.MyNumberOfGoals;
				ucp.YellowCards = igrac.MyNumberOfYellowCards;
				ucp.PlayerPhoto = GetPhoto(igrac.Name);
				flpStatistics.Controls.Add(ucp);
			}

		}

		private Image GetPhoto(string name)
		{
			ResourceManager MyResourceClass = new ResourceManager(typeof(assets));
			name = name.Replace(" ", "").ToLower();
			name = name.Replace("-", "_").ToLower();
			ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
			foreach (DictionaryEntry entry in resourceSet)
			{
				string resourceKey = entry.Key.ToString();
				if (resourceKey.ToLower() == name)
				{
					return (Image)entry.Value;

				}
			}
			return assets.DefaultImage;
		}


		private void AddMatchesToFlp()
		{
			flpAttendance.Controls.Clear();
			List<Match> tmpMatches = matches;

			foreach (var match in matches)
			{
				UCMatchResult ms = new UCMatchResult();
				ms.Locationn = match.Location;
				ms.Attendance = match.Attendance;
				ms.HomeTeam = match.Home_team_country;
				ms.AwayTeam = match.Away_team_country;

				flpAttendance.Controls.Add(ms);
			}

		}

		private void btnPrintPlayers_Click(object sender, EventArgs e)
		{
			try
			{
				printPreviewDialogPlayers.Show();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnPrintMatches_Click(object sender, EventArgs e)
		{
			try
			{
				printPreviewDialogMatches.Show();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
		private void printDocumentMatches_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Point point = new Point(0, 0);
			foreach (UCMatchResult match in flpAttendance.Controls)
			{
				Bitmap bitmap = new Bitmap(match.Size.Width, match.Size.Height);
				match.DrawToBitmap(bitmap, new Rectangle
				{
					Width = match.Size.Width,
					Height = match.Size.Height
				});
				e.Graphics.DrawImage(bitmap, point);
				point.Y += match.Height + 10;
			}
		}

		private void printDocumentPlayers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Point point = new Point(0, 0);
			int i = 1;

			foreach (PlayerStats player in flpStatistics.Controls)
			{
				if (i % 8 == 0)
				{
					point.X += player.Width + 15;
					point.Y = 0;

				}


				Bitmap bitmap = new Bitmap(player.Size.Width, player.Size.Height);
				player.DrawToBitmap(bitmap, new Rectangle
				{
					Width = player.Size.Width,
					Height = player.Size.Height
				});
				e.Graphics.DrawImage(bitmap, point);

				i++;
				point.Y += player.Height + 10;
			}
		}


	}
}
