using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp
{
	public partial class PlayerStats : UserControl
	{
		public PlayerStats()
		{
			InitializeComponent();
		}
		public string FullName { get => FullName; set => lblPlayerName.Text = value; }
		public int Goals { get => Goals; set => lblNumberOfGoals.Text = value.ToString(); }
		public int YellowCards { get => YellowCards; set => lblYellowCards.Text = value.ToString(); }
		public Image PlayerPhoto { get => PlayerPhoto; set => pbPlayerImage.Image = value; }
	}
}
