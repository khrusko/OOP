using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using worldcupLib.Interface;
using worldcupLib.Models;
using worldcupLib.Repo;

namespace WPFApp
{
	/// <summary>
	/// Interaction logic for LayoutView.xaml
	/// </summary>
	public partial class LayoutView : Page
	{
		private IRepo repo;
		private IFile _repoFile;

		private List<string> settings;
		private List<Result> _results;
		private List<Team> teams;
		private Team _HomeTeam;
		private List<TeamMatch> awayTeams;
		private List<Match> matches;
		private string _awayTeam;
		private Match _match;
		private List<Player> playerImages;
		string favoriteTeam;

		public LayoutView()
		{
			InitializeComponent();
			try
			{
				_repoFile = RepoFactory.GetFileRepository();
				favoriteTeam = _repoFile.LoadFavoriteTeam();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void cbAwayCountrys_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ResetFootballField();
			try
			{

				if (cbAwayCountrys.SelectedIndex != -1 && cbAwayCountrys != null)
				{

					_awayTeam = cbAwayCountrys.SelectedItem.ToString();
					_match = matches.Where(x => x.Home_team_country == _HomeTeam.Country && x.Away_team_country == _awayTeam || x.Home_team_country == _awayTeam && x.Away_team_country == _HomeTeam.Country).FirstOrDefault();

					if (_match != null)
					{
						GetResults();
						if (golman.Children.Count == 0)
						{
							SetPlayersOnField();
						}

					}
				}


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + "Greska awayselectionchanged");
			}


		}



		private void cbFavoriteCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			_HomeTeam = (cbFavoriteCountry.SelectedItem as Team);
			GetAwayTeams();
		}

		private void lblHomeTeam_MouseMove(object sender, MouseEventArgs e)
		{
			Result teamResult = _results.Where(x => x.Country == _HomeTeam.Country).FirstOrDefault();
			tbHomeTeamStats.Text = teamResult.ToString();
		}

		private void lblAwayTeam_MouseMove(object sender, MouseEventArgs e)
		{
			Result teamResulta = _results.Where(x => x.Country == _awayTeam).FirstOrDefault();
			tbAwayTeamStats.Text = teamResulta.ToString();
		}

		private async void Page_Loaded(object sender, RoutedEventArgs e)
		{
			try
			{
				settings = _repoFile.LoadSettings();

				string tournament = settings[1];
				repo = RepoFactory.GetChampionship(tournament);
				matches = await repo.GetMatches();
				_results = (List<Result>)await repo.GetResult();
				teams = await repo.GetTeams();
				awayTeams = await repo.GetAwayTeams(favoriteTeam);
				playerImages = _repoFile.LoadPlayerImages();
				AppendFavoriteTeams();
				GetAwayTeams();

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}


		private void AppendFavoriteTeams()
		{
			teams.Sort((x, y) => x.Country.CompareTo(y.Country));
			foreach (var item in teams)
			{
				cbFavoriteCountry.Items.Add(item);
			}

			_HomeTeam = teams.First(x => x.Country == favoriteTeam);
			cbFavoriteCountry.SelectedItem = _HomeTeam;

		}
		private void GetAwayTeams()
		{

			foreach (var match in matches)
			{
				if (match.Home_team.Country == _HomeTeam.Country || match.Away_team.Country == _HomeTeam.Country)
				{
					if (match.Home_team.Country != _HomeTeam.Country)
					{
						awayTeams.Add(match.Home_team);
					}
					else
					{
						awayTeams.Add(match.Away_team);
					}
				}

			}

			AppendAwayTeams();

			awayTeams.Clear();
		}

		public void ResetFootballField()
		{
			foreach (StackPanel item in footbalfield.Children)
			{
				item.Children.Clear();
			}
		}
		public void AppendAwayTeams()
		{
			if (cbAwayCountrys.Items.Count != 0)
			{
				cbAwayCountrys.Items.Clear();
			}

			foreach (var team in awayTeams)
			{
				cbAwayCountrys.Items.Add(team);
			}


			cbAwayCountrys.SelectedIndex = 0;

			_awayTeam = cbAwayCountrys.SelectedItem.ToString();


		}
		public void GetResults()
		{
			try
			{
				lblHomeTeam.Content = _HomeTeam.Country;
				lblAwayTeam.Content = cbAwayCountrys.SelectedItem.ToString();
				_match = matches.Where(x => x.Home_team_country == _HomeTeam.Country && x.Away_team_country == _awayTeam || x.Home_team_country == _awayTeam && x.Away_team_country == _HomeTeam.Country).FirstOrDefault();

				if (_match != null)
				{
					if (_HomeTeam.Country == _match.Away_team_country)
					{
						lblHomeTeamResult.Content = _match.Away_team.Goals.ToString();
						lblAwayTeamResult.Content = _match.Home_team.Goals.ToString();

					}
					else
					{
						lblHomeTeamResult.Content = _match.Home_team.Goals.ToString();
						lblAwayTeamResult.Content = _match.Away_team.Goals.ToString();
					}

				}
				if (footbalfield.Children.Count == 0)
				{
					footbalfield.Children.Clear();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void SetPlayersOnField()
		{

			if (_HomeTeam.Country != _match.Home_team_country)
			{
				foreach (var player in _match.Away_team_statistics.Starting_eleven)
				{
					GetPlayerImage(player);
					GetPlayerStats(player, _match.Away_team_events);
					AppendHomePlayerToField(player);


				}

				foreach (var playeraway in _match.Home_team_statistics.Starting_eleven)
				{
					GetPlayerImage(playeraway);
					GetPlayerStats(playeraway, _match.Home_team_events);
					AppendAwayPlayerToField(playeraway);

				}

			}
			else
			{
				foreach (var player in _match.Home_team_statistics.Starting_eleven)
				{
					GetPlayerImage(player);
					AppendHomePlayerToField(player);
					GetPlayerStats(player, _match.Home_team_events);

				}

				foreach (var playeraway in _match.Away_team_statistics.Starting_eleven)
				{
					GetPlayerImage(playeraway);
					AppendAwayPlayerToField(playeraway);
					GetPlayerStats(playeraway, _match.Away_team_events);

				}

			}
		}

		private void GetPlayerImage(StartingEleven player)
		{
			foreach (var imagePlayer in playerImages)
			{
				if (imagePlayer.Name.Equals(player.Name))
				{
					player.ImagePath = imagePlayer.ImagePath;
					break;
				}
			}
		}

		private void AppendAwayPlayerToField(StartingEleven playeraway)
		{
			PlayerOnField plf = new PlayerOnField(playeraway as StartingEleven);

			plf.MouseEnter += PlayerOnFieldSelected;
			plf.MouseLeave += Plf_MouseLeave;

			switch (playeraway.Position)
			{
				case "Goalie":
					AwayGoalie.Children.Add(plf);
					break;
				case "Defender":
					AwayDefender.Children.Add(plf);
					break;
				case "Midfield":
					AwayMidfield.Children.Add(plf);
					break;
				case "Forward":
					AwayForward.Children.Add(plf);
					break;

				default:
					break;
			}

		}

		private void AppendHomePlayerToField(StartingEleven player)
		{
			PlayerOnField plf = new PlayerOnField(player);

			plf.MouseEnter += PlayerOnFieldSelected;
			plf.MouseLeave += Plf_MouseLeave;
			switch (player.Position)
			{
				case "Goalie":
					this.golman.Children.Add(plf);
					break;
				case "Defender":
					Obrana.Children.Add(plf);
					break;
				case "Midfield":
					VezniRed.Children.Add(plf);
					break;
				case "Forward":
					Napad.Children.Add(plf);
					break;

				default:
					break;
			}
		}

		private void Plf_MouseLeave(object sender, MouseEventArgs e)
		{
			vbPlayerStats.Visibility = Visibility.Hidden;
		}

		private void GetPlayerStats(Player player, List<Event> matchEvents)
		{
			player.MyNumberOfGoals = 0;
			player.MyNumberOfYellowCards = 0;
			foreach (var eventt in matchEvents)
			{
				if (eventt.Type_of_event == "goal" || eventt.Type_of_event == "goal-penalty")
				{
					if (player.Name == eventt.Player)
					{
						player.MyNumberOfGoals++;
					}
				}
				if (eventt.Type_of_event == "yellow-card")
				{
					if (player.Name == eventt.Player)
					{
						player.MyNumberOfYellowCards++;
					}
				}
			}

		}

		private void PlayerOnFieldSelected(object sender, MouseEventArgs e)
		{
			PlayerOnField playerOnField = (PlayerOnField)sender;
			lblIgracStats.Content = playerOnField.ToString();
			vbPlayerStats.Visibility = Visibility.Visible;


		}


	}
}
