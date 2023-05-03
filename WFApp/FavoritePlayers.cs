using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using worldcupLib.Interface;
using worldcupLib.Models;
using worldcupLib.Repo;
using worldcupLib;

namespace WFApp
{
	public partial class FavoritePlayers : Form
	{
		string startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, @"slike\");
		private IRepo _repo;
		private IFile _fileRepo;

		List<string> setting;
		string country;
		List<Player> playerImagesToSave = new List<Player>();
		HashSet<Player> playerList;
		List<Player> favoritePlayers;

		private UCPlayer selectedPlayer;
		private List<UCPlayer> selectedUCPlayers = new List<UCPlayer>();
		public FavoritePlayers()
		{
			InitializeComponent();
			_fileRepo = RepoFactory.GetFileRepository();
		}

		private void FavoritePlayers_Load(object sender, EventArgs e)
		{
			try
			{
				setting = _fileRepo.LoadSettings();
				country = _fileRepo.LoadFavoriteTeam();

				_repo = RepoFactory.GetChampionship(setting[1]);
				favoritePlayers = _fileRepo.LoadFavoritePlayers();
				FillAsyncPlayers(country);

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}


		private async void FillAsyncPlayers(string country)
		{
			playerList = await _repo.GetPlayers(country);
			List<Player> images = _fileRepo.LoadPlayerImages();
			UpdatePlayerImagePath(playerList, images);



			foreach (var player in playerList)
			{
				UCPlayer ucp = new UCPlayer(player);
				ucp.MouseClick += selectPlayer_click;
				ucp.MouseDoubleClick += choosePicture_click;
				flpAllPlayers.Controls.Add(ucp);
			}
			if (favoritePlayers != null)
			{
				foreach (var player in favoritePlayers)
				{
					UCPlayer uCPlayer = new UCPlayer(player);
					flpFavoritePlayers.Controls.Add(uCPlayer);
				}
			}
		}
	

		private void choosePicture_click(object sender, EventArgs e)
		{
			OpenFileDialog filedialog = new OpenFileDialog();
			filedialog.Filter = "Pictures|*.bmp;*.jpg;*.jpeg;*.png;|All files|*.*";
			if (!Directory.Exists(startupPath))
			{
				Directory.CreateDirectory(startupPath);
			}

			selectedPlayer = (UCPlayer)sender;


			if (filedialog.ShowDialog() == DialogResult.OK)
			{

				string iName = filedialog.SafeFileName;
				string filepath = filedialog.FileName;



				if (!File.Exists(startupPath + iName))
				{
					File.Copy(filepath, startupPath + iName);
				}
				selectedPlayer.Player.ImagePath = startupPath + iName;
				selectedPlayer.PlayerImage = new Bitmap(filedialog.OpenFile());
				_fileRepo.SavePlayerImages(selectedPlayer.Player);
			}
			else
			{
				filedialog.Dispose();
			}
		}
		private void selectPlayer_click(object sender, MouseEventArgs e)
		{

			if (e.Button == MouseButtons.Right)
			{
				selectedPlayer = (UCPlayer)sender;

				if (selectedPlayer.BackColor == Color.Gray)
				{
					selectedPlayer.BackColor = Color.Empty;
					selectedUCPlayers.Remove(selectedPlayer);
				}

				else
				{
					selectedPlayer.BackColor = Color.Yellow;
				}
			}
			if (!selectedUCPlayers.Contains(selectedPlayer) && selectedUCPlayers != null)
			{
				selectedUCPlayers.Add(selectedPlayer);
			}
		}

		private void UpdatePlayerImagePath(HashSet<Player> playerList, List<Player> images)
		{
			foreach (var item in images)
			{
				foreach (var igrac in playerList)
				{
					if (item.Name == igrac.Name)
					{
						igrac.ImagePath = item.ImagePath;
					}
				}
			}
		}
		private void btnStatistics_Click(object sender, EventArgs e)
		{
			Statistics stat = new Statistics();
			stat.Show();
			this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			flpFavoritePlayers.Controls.Clear();

			if (selectedUCPlayers.Count != 0)
			{
				foreach (var player in selectedUCPlayers)
				{
					player.IconFavoritePlayer = null;
					player.BackColor = Color.Empty;
					flpAllPlayers.Controls.Add(player);
				}
			}
			selectedUCPlayers.Clear();
		}


		private void flpFavoritePlayers_DragDrop(object sender, DragEventArgs e)
		{
			if (flpFavoritePlayers.Controls.Count < 3 && selectedUCPlayers.Count <= 3)
			{
				List<Player> players = new List<Player>();
				
				foreach (var player in selectedUCPlayers)
				{
					players.Add(player.Player);
					player.BackColor = Color.Empty;
					player.IconFavoritePlayer = assets.Star;
					flpFavoritePlayers.Controls.Add(player);
					
				}
				_fileRepo.SaveFavoritePlayers(players);
			}
			else
			{
				//to do if 
				MessageBox.Show(Properties.Resources.MaxIgraca);
			}
		}

		private void flpFavoritePlayers_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}


		public List<Player> ParseUCToPlayers()
		{
			List<Player> list = new List<Player>();
			foreach (UCPlayer player in flpFavoritePlayers.Controls)
			{
				list.Add(player.ParseFrameToPlayer(player));
			}
			return list;
		}
	}
}
