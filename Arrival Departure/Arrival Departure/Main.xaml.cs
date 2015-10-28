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
using System.Data;
using System.Collections;

namespace Arrival_Departure
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        DB database;
        Users usr;

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
            //Users usr = new Users();
            //Users usr = (Users)DG.SelectedItem;
            //MessageBox.Show(usr.FullName);
            //database.UsersQuery(DG.SelectedItem.ToString());
            //List lst = DG.SelectedItems;
            //MessageBox.Show();
            //DataRowView drv = DG.SelectedItems;
        }
    }

    public class Users
    {
        public int Id { get; set; }
        public String PassportSeries { get; set; }
        public String PassportNumber { get; set; }
        public String FullName { get; set; }
        public String Gender { get; set; }
        public String BirthDay { get; set; }
        public String BirthPlace { get; set; }
        public String PassportIssued { get; set; }
        public String WhenPassportIssued { get; set; }
        public String RegistrationCity { get; set; }
        public String RegistrationStreet { get; set; }
        public String RegistrationHouse { get; set; }
    }
}
