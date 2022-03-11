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
using System.Windows.Shapes;

namespace GenshinImpactAccountManager
{
    /// <summary>
    /// Logica di interazione per Database.xaml
    /// </summary>
    public partial class Database : Window
    {
        List<Account> Accounts;
        public Database()
        {

            InitializeComponent();

            Accounts = new List<Account>();

            DataReader();
        }

        void DataReader()
        {

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DatabasePath))
            {
                conn.CreateTable<Account>();
                Accounts = conn.Table<Account>().ToList();
            }

            if (Accounts != null)
            {
                DatabaseGrid.ItemsSource = Accounts;
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataReader();
            switch (SearchParameters.Text)
            {
                case "Username":
                    {
                        TextBox searchTextBox = sender as TextBox;
                        var filteredlist = Accounts.Where(a => a.Username.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        DatabaseGrid.ItemsSource = filteredlist;
                        break;
                    }
                case "AR":
                    {
                        TextBox searchTextBox = sender as TextBox;
                        var filteredlist = Accounts.Where(a => Convert.ToString(a.Rank).Contains(searchTextBox.Text)).ToList();
                        DatabaseGrid.ItemsSource = filteredlist;
                        break;
                    }
                case "Server":
                    {
                        TextBox searchTextBox = sender as TextBox;
                        var filteredlist = Accounts.Where(a => a.Server.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        DatabaseGrid.ItemsSource = filteredlist;
                        break;
                    }
                case "5 Stars":
                    {
                        TextBox searchTextBox = sender as TextBox;
                        var filteredlist = Accounts.Where(a => a.Fivestars.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        DatabaseGrid.ItemsSource = filteredlist;
                        break;
                    }
                case "4 Stars":
                    {
                        TextBox searchTextBox = sender as TextBox;
                        var filteredlist = Accounts.Where(a => a.Fourstars.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        DatabaseGrid.ItemsSource = filteredlist;
                        break;
                    }
                default:
                    break;
            }

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Are you sure you want to delete the selected account?", "Delete account?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(res == MessageBoxResult.Yes)
            {
                Account acc = DatabaseGrid.SelectedItem as Account;
                using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DatabasePath))
                {
                    conn.CreateTable<Account>();
                    if (DatabaseGrid.SelectedItem != null)
                    {
                        string querydelete = string.Format("DELETE FROM Account WHERE Username = '" + acc.Username + "'");
                        var list = conn.Query<Account>(querydelete);
                        MessageBox.Show("Account deleted", "Manage Accounts", MessageBoxButton.OK, MessageBoxImage.Information);
                        string queryreload = string.Format("SELECT * FROM Account");
                        List<Account> Nuovi = conn.Query<Account>(queryreload).ToList();
                        DatabaseGrid.ItemsSource = Nuovi;
                        DatabaseGrid.Items.Refresh();
                    }
                }
            }
        }
    }
}
