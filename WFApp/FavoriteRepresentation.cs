using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using worldcupLib;
using worldcupLib.Interface;
using worldcupLib.Models;
using worldcupLib.Repo;

namespace WFApp
{
	public partial class FavoriteRepresentation : System.Windows.Forms.Form
	{
		IRepo repo;
		IFile _repoFile;
		private const string HR = "hr", EN = "en";
		public FavoriteRepresentation()
		{
			InitializeComponent();
			_repoFile = RepoFactory.GetFileRepository();
		}

		private void btnSubmitRepresentation_Click(object sender, EventArgs e)
		{
			Team team = cbRepresentation.SelectedItem as Team;
			_repoFile.SaveFavoriteTeam(team);

			this.Hide();
			FavoritePlayers form = new FavoritePlayers();
			this.Closed += (s, args) => this.Close();
			form.Show();
		}



		private async void FavoriteRepresentation_Load(object sender, EventArgs e)
		{
			List<string> postavke = _repoFile.LoadSettings();
			string prvenstvo = postavke[1];
			repo = RepoFactory.GetChampionship(prvenstvo);
			if (postavke[0] == "Hrvatski")
			{
				SetKultura(HR);
			}
			else
			{
				SetKultura(EN);
			}

			this.cbRepresentation.DataSource = await repo.GetTeams();
		}

		private void SetKultura(string jezik)
		{
			CultureInfo culture = new CultureInfo(jezik);

			Thread.CurrentThread.CurrentUICulture = culture;

			this.Controls.Clear();
			InitializeComponent();
		}


	}
}
