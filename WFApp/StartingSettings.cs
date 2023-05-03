using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using worldcupLib.Interface;
using worldcupLib.Repo;

namespace WFApp
{
	public partial class StartingSettings : System.Windows.Forms.Form
	{
		IFile _repoFile;
		public StartingSettings()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			//DialogResult result = MessageBox ... to do at end of project (localization globalization)

			try
			{
				_repoFile = RepoFactory.GetFileRepository();
				List<string> postavke = _repoFile.LoadSettings();
				RadioButton buttons = this.gBoxChampionship.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
				string selectedGender = "";
				if (buttons.Text == "Women")
				{
					selectedGender = "Women";
				}
				else if (buttons.Text == "Men")
				{
					selectedGender = "Men";
				}

				RadioButton buttons2 = this.gBoxLanguage.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
				string selectedLanguage = "";
				if (buttons2.Text == "English")
				{
					selectedLanguage = "English";
				}
				else if (buttons2.Text == "Croatian")
				{
					selectedLanguage = "Croatian";
				}
				_repoFile.SaveSettings(selectedLanguage, selectedGender);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

			try
			{
				this.Hide();
				FavoriteRepresentation form = new FavoriteRepresentation();
				form.Closed += (s, args) => this.Close();
				form.Show();
				

			}
			catch (Exception em)
			{
				MessageBox.Show(em.Message);
			}

		}

		private void StartingSettings_Load(object sender, EventArgs e)
		{

			try
			{
				_repoFile = RepoFactory.GetFileRepository();
				List<string> postavke = _repoFile.LoadSettings();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}
	}
}
