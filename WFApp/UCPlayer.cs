using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using worldcupLib.Models;
using worldcupLib;

namespace WFApp
{
	public partial class UCPlayer : UserControl
	{
        public Player Player { get; set; }
        public UCPlayer(Player player)
        {
            InitializeComponent();
            this.Player = player;
            SetUCPlayer(Player);
        }

        public Image IconFavoritePlayer { get => IconFavoritePlayer; set => pbFavoritePlayer.Image = value; }
        public Image PlayerImage { get => PlayerImage; set => pbImagePlayer.Image = value; }

        public void SetUCPlayer(Player player)
        {
            if (String.IsNullOrEmpty(player.ImagePath))
                pbImagePlayer.Image = assets.DefaultImage;

            pbImagePlayer.ImageLocation = player.ImagePath;
            lblPlayerName.Text = player.Name;
            lblNumber.Text = player.Shirt_number.ToString();
            lblPosition.Text = player.Position;
            lblCaptain.Text = player.Captain ? "Capitan" : "";

        }

        public Player ParseFrameToPlayer(UCPlayer UCPlayer)
        {
            return new Player
            {
                Position = UCPlayer.Player.Position,
                Name = UCPlayer.Player.Name,
                Shirt_number = UCPlayer.Player.Shirt_number,
                Captain = UCPlayer.Player.Captain,
                ImagePath = UCPlayer.Player.ImagePath

            };

        }
        public override string ToString() => Player.Name;

		private void UCPlayer_MouseDown(object sender, MouseEventArgs e)
		{
            if (e.Button == MouseButtons.Left)
                this.DoDragDrop(this, DragDropEffects.All);
        }
	}
}
