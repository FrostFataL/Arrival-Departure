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

namespace Arrival_Departure
{
    /// <summary>
    /// Interaction logic for UsersControl.xaml
    /// </summary>
    public partial class UsersControl : Window
    {
        UserControl uc;
        DB database;

        public UsersControl()
        {
            InitializeComponent();
        }

        public UsersControl(DB database, int id)
        {
            this.database = database;
        }
    }
}
