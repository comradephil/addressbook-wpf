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
using System.IO;

namespace AddressBook
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

		private void searchBtn_click(object sender, RoutedEventArgs e)
		{
			textInputs.Visibility = Visibility.Visible;
			searchBtn.IsEnabled = false;
		}

		private void showContactsBtn_Click(object sender, RoutedEventArgs e)
		{
			textInputs.Visibility = Visibility.Collapsed;
			searchBtn.IsEnabled = true;
			FileReader(@"");
		}

		private void FileReader(string v)
		{
			try
			{
				
				foreach()
				{
					Contact newContact = new Contact();
				}
			}
			catch(FileNotFoundException)
			{
				errorlabel.Content = "Addresses Not Found - Check that the address file exists";
				errorlabel.Visibility = Visibility.Visible;
			}
			catch(Exception)
			{
				errorlabel.Content = "File path incorrect - Check that the address file exists";
				errorlabel.Visibility = Visibility.Visible;
			}
			finally
			{
				Console.ReadLine();
			}
		}

		private void addBtn_Click(object sender, RoutedEventArgs e)
		{
			textInputs.Visibility = Visibility.Visible;
			searchBtn.IsEnabled = false;
		}

		private void delBtn_Click(object sender, RoutedEventArgs e)
		{
			textInputs.Visibility = Visibility.Visible;
			searchBtn.IsEnabled = false;
		}

		private void emailInput_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void phoneNumberInput_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void lastNameInput_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void firstNameInput_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
