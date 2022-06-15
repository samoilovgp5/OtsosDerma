using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace lapuh
{
    class DBconnection
    {
        static public string connectionstring = $@"database = lapushok; datasource = localhost; userid=root; password = qwerty; charset = utf8mb4";

        static public MySqlConnection MSConnection;
        static public MySqlCommand MSCommand;
        static public MySqlDataAdapter MSDataAdapter;


        static public bool connect()
        {
            try
            {
                MSConnection = new MySqlConnection(connectionstring);
                MSConnection.Open();
                MSCommand = new MySqlCommand();
                MSCommand.Connection = MSConnection;
                MSDataAdapter = new MySqlDataAdapter(MSCommand);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public DataTable sas = new DataTable(); 

        static public void getkal()
        {
            MSCommand.CommandText = "SELECT * FROM lapushok.client";
            sas.Clear();
            MSDataAdapter.Fill(sas);
        }
         static public void delkal(string sss)
        {
            MSCommand.CommandText = $@"DELETE FROM `lapushok`.`client` WHERE (`ID` = '{sss}');";
            DBconnection.MSCommand.ExecuteNonQuery();
        }

        static public int getcou()
        {
            MSCommand.CommandText = $@"SELECT count(*) FROM lapushok.client";
            object couu = MSCommand.ExecuteScalar();
            return Convert.ToInt32(couu);
        }
    }
}
