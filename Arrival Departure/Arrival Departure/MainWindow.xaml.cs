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
using System.Data.OleDb;

namespace Arrival_Departure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //DB _myDatabase;

        public MainWindow()
        {
            InitializeComponent();
            //_myDatabase = new DB(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=passport.accdb");
        }

        private void OpenNewPassport(object sender, RoutedEventArgs e)
        {
            
            //NewPassport np = new NewPassport();
            //np.Owner = this;
            //if (np.ShowDialog() == true)
            //    MessageBox.Show("Добавлен новый паспорт");
            //else
            //    MessageBox.Show("ooops");
        }

        //void MainWindow_Unload()
        //{
        //    myDB.CloseDB();
        //}

        //public void masd()
        //{
        //    OleDbConnection conn;
        //    OleDbCommand command;
        //    conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =passport.accdb");
        //    //command = new OleDbCommand("Select * from data");
        //    try
        //    {
        //        conn.Open();
        //        MessageBox.Show("Connection Open ! ");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Can not open connection ! ");
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
    }
}
