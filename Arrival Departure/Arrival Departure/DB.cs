using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows;
using System.Data;
using System.Windows.Controls;

namespace Arrival_Departure
{
    public class DB
    {
        OleDbConnection conn;
        OleDbCommand command;

        public DB(String connectionString)
        {
            //OleDbCommand command;
            conn = new OleDbConnection(connectionString);
            //command = new OleDbCommand("Select * from data");
            try
            {
                conn.Open();
                //MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
        }

        public DB()
        {
            //OleDbCommand command;
            String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =passport.accdb";
            conn = new OleDbConnection(connectionString);
            //command = new OleDbCommand("Select * from data");
            try
            {
                conn.Open();
                //MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
            }
        }

        public void AddPassport(List<String> lst)
        {
            String cmd_str = "Insert into data (passportSeries, passportNumber, fullName, gender, birthDay, birthPlace," +
                "passportIssued, whenPassportIssued, registrationCity, registrationStreet, registrationHouse) VALUES (";

            for (int i = 0; i < lst.Count-1; i++)
            {
                cmd_str += "'" + lst[i] + "',";
            }

            cmd_str += "'" + lst[lst.Count-1] + "');";

            command = new OleDbCommand(cmd_str);
            command.Connection = conn;
            command.ExecuteNonQuery();
            //command.Cancel();
            //CloseDB();
        }

        public OleDbDataAdapter ShowUsersTransitList(DataGrid dg)
        {
            command = new OleDbCommand("Select * from transit");
            command.Connection = conn;
            command.ExecuteNonQuery();
            DataTable data = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(data);
            dg.ItemsSource = data.DefaultView;
            dataAdapter.Update(data);
            return dataAdapter;
        }

        public OleDbDataAdapter ShowUsersList(DataGrid dg)
        {
            command = new OleDbCommand("Select * from data;");
            command.Connection = conn;
            command.ExecuteNonQuery();
            DataTable data = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(data);
            dg.ItemsSource = data.DefaultView;
            dataAdapter.Update(data);
            return dataAdapter;
        }

        public OleDbDataAdapter ShowUsersListFiltering(DataGrid dg, String filter)
        {
            String sqlquery = "Select * from data where fullName like '%" + filter + "%' or fullName like '%" + filter +
                "' or fullName like '" + filter + "%';";
            //String sqlquery = "Select * from data where fullName like 'Вася';";
            command = new OleDbCommand(sqlquery);
            command.Connection = conn;
            command.ExecuteNonQuery();
            DataTable data = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(data);
            dg.ItemsSource = data.DefaultView;
            dataAdapter.Update(data);
            return dataAdapter;
        }

        public String UsersQuery(String query)
        {
            String sqlquery = "Select passportSeries from data where fullName = " + query + ";";
            command = new OleDbCommand(sqlquery);
            command.Connection = conn;
            OleDbDataReader dr = command.ExecuteReader();
            return dr.GetString(0);
        }

        public void CloseDB()
        {
            conn.Close();
        }
    }
}
