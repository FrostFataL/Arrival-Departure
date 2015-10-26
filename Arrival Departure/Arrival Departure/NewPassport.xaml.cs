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
    /// Interaction logic for NewPassport.xaml
    /// </summary>
    public partial class NewPassport : Window
    {
        DB _database;

        public NewPassport(DB database)
        {
            InitializeComponent();
            _database = database;
        }

        private void CreatePassport(object sender, RoutedEventArgs e)
        {
            bool allTexts = true;
            List<String> lst = new List<string>();
            lst.Add(passportSeries.Text.ToUpper());
            lst.Add(passportNumber.Text);
            lst.Add(fullName.Text);
            lst.Add(gender.Text);
            lst.Add(birthDay.Text);
            lst.Add(birthPlace.Text);
            lst.Add(passportIssued.Text);
            lst.Add(whenPassportIssued.Text);
            lst.Add(registrationCity.Text);
            lst.Add(registrationStreet.Text);
            lst.Add(registrationHouse.Text);
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] == "")
                {
                    MessageBox.Show("Заполните все поля!");
                    allTexts = false;
                    return;
                }
                else
                    allTexts = true;
            }
            if (allTexts)
            {
                _database.AddPassport(lst);
                DialogResult = true;
            }
        }
    }
}
