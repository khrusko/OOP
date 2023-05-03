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
using worldcupLib.Repo;

namespace WPFApp
{
	/// <summary>
	/// Interaction logic for SettingsView.xaml
	/// </summary>
	public partial class SettingsView : Page
	{
		private IFile _fileRepo = RepoFactory.GetFileRepository();
		public SettingsView()
		{
			InitializeComponent();
		}

		private void btnsave_Click(object sender, RoutedEventArgs e)
		{

			string resolution = cbRezolucija.Text;
			string language = cbJezik.Text;
			string tournament = cbPrvenstvo.Text;

			if (MessageBox.Show("Do you wish to save these settings", "Save settings",
					 MessageBoxButton.YesNo,
					 MessageBoxImage.Question) == MessageBoxResult.Yes)
			{
				_fileRepo.SaveSettings(language, tournament);
                ChangeResolution(resolution);


            }

		}

        public static void ChangeResolution(string type)
        {
            switch (type)
            {
                case "Fullscreen":
                    Application.Current.MainWindow.WindowStyle = WindowStyle.None;
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                    break;
                case "Medium":
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    Application.Current.MainWindow.Width = 1500;
                    Application.Current.MainWindow.Height = 900;
                    break;
                case "Small":
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    Application.Current.MainWindow.Width = 818;
                    Application.Current.MainWindow.Height = 556;
                    break;
                default:
                    Application.Current.MainWindow.WindowStyle = WindowStyle.SingleBorderWindow;
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                    Application.Current.MainWindow.Width = 1200;
                    Application.Current.MainWindow.Height = 800;
                    break;
            }
        }
    }
}
