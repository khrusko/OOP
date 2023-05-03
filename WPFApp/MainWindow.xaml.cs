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
using WPFApp;
namespace WPFApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void btnExit_Click(object sender, RoutedEventArgs e)
		{
			MessageBoxResult messageBoxResult = MessageBox.Show(Resources_HR.Exit, Resources_HR.CaptionConfirm, MessageBoxButton.OKCancel, MessageBoxImage.Warning);
			if (messageBoxResult == MessageBoxResult.OK)
			{
				Application.Current.Shutdown();

			}
		}

		private void btnSettings_Click(object sender, RoutedEventArgs e)
		{
			Main.Content = new SettingsView();
		}

		private void btnResults_Click(object sender, RoutedEventArgs e)
		{
			Main.Content = new LayoutView();
		}
	}
}
