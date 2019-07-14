using System.Windows;
using System.Printing;
using System.Windows.Controls;

namespace ContractApp
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void PrintButtonClick(object sender, RoutedEventArgs e)
		{
			PrintDialog printDialog = new PrintDialog();
			if (printDialog.ShowDialog() == true)
			{
				printDialog.PrintVisual(gridElement, "Распечатываем");
			}
		}
	}
}
