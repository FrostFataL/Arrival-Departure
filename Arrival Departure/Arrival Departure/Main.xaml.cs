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
using System.Data.OleDb;

namespace Arrival_Departure
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        DB database;

        public Main()
        {
            InitializeComponent();
        }

        private void DataGridLoad(object sender, RoutedEventArgs e)
        {
            database = new DB(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=passport.accdb");
            DG.DataContext = database.ShowUsersList(DG);
        }

        private void Filtering(object sender, RoutedEventArgs e)
        {
            DG.DataContext = database.ShowUsersListFiltering(DG, NameFilter.Text);
        }

        private void AddNewPassport(object sender, RoutedEventArgs e)
        {
            NewPassport np = new NewPassport(database);
            np.Owner = this;
            if (np.ShowDialog() == true)
            {
                DG.DataContext = database.ShowUsersListFiltering(DG, "");
                MessageBox.Show("all good");
            }
        }

        private void ExitDB(object sender, RoutedEventArgs e)
        {
            database.CloseDB();
        }

        private void MoreInfo(object sender, SelectionChangedEventArgs e)
        {
            //database.UsersQuery(DG.SelectedItem.ToString());
            //List lst = DG.SelectedItems;
            //MessageBox.Show();
        }

    }
}
