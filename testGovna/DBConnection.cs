using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace testGovna
{
    public class DBConnection
    {
        public static string connectionString = "DataBase = my; DataSource = localhost; userid = root; password = qwerty;";

        public static MySqlCommand command = new MySqlCommand();
        public static MySqlConnection connect = new MySqlConnection();
        public static MySqlDataAdapter msDataAdapter = new MySqlDataAdapter();

        public static DataTable dtClient = new DataTable();
        public static DataTable dtGender = new DataTable();

        public static bool Connection()
        {
            try
            {
                connect = new MySqlConnection(connectionString);
                command = new MySqlCommand();
                command.Connection = connect;
                connect.Open();
                msDataAdapter = new MySqlDataAdapter(command);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void GetClient()
        {
            command.CommandText = "SELECT * FROM client";
            dtClient.Clear();
            msDataAdapter.Fill(dtClient);
        }

        public static bool DeleteClient(string id)
        {
            try
            {
                command.CommandText = $@"DELETE FROM client WHERE ID = '{id}'";
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void GetGender()
        {
            command.CommandText = "SELECT * FROM gender";
            dtGender.Clear();
            msDataAdapter.Fill(dtGender);
        }

        public static bool AddClient()
        {
            command.CommandText = "INSERT INTO client VALUES ('{}')";
            if (command.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
