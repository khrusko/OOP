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
using worldcupLib.Models;

namespace WPFApp
{
	public partial class PlayerOnField : UserControl
	{
        Player Player { get; set; }
        public PlayerOnField(Player player)
        {
            InitializeComponent();
            this.Player = player;
            SetPlayer(player);
        }

        private void SetPlayer(Player player)
        {
            lblplayerName.Content = player.Name;
            lblplayerNumber.Content = player.Shirt_number;
            if (!string.IsNullOrEmpty(player.ImagePath))
            {
                ImagePlayer.Source = new BitmapImage(new Uri(player.ImagePath));
            }

        }

        public override string ToString()
        => $"{Player.Name} {Player.Shirt_number}" +
            $" {Player.Position}{Environment.NewLine}Kapetan: {Player.Captain}" +
            $"{Environment.NewLine}Golovi: {Player.MyNumberOfGoals}" +
            $"{Environment.NewLine}Zuti:{Player.MyNumberOfYellowCards}";

    }
}
