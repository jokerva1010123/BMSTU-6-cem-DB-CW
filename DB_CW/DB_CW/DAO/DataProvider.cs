using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CW.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance 
        { 
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }
        public DataProvider() { }
        private string connectionStr = "Host=localhost;Username=postgres;Password=0612;Database=DB_CW";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (NpgsqlConnection connector = new NpgsqlConnection(connectionStr))
            {
                connector.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connector);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                }
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                adapter.Fill(data);
                connector.Close();  
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (NpgsqlConnection connector = new NpgsqlConnection(connectionStr))
            {
                connector.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connector);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                }
                try 
                { 
                    data = cmd.ExecuteNonQuery(); 
                }
                catch
                {
                    connector.Close();
                    return -1;
                }
                connector.Close();
            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (NpgsqlConnection connector = new NpgsqlConnection(connectionStr))
            {
                connector.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, connector);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                }
                data = cmd.ExecuteScalar();
                connector.Close();
            }
            return data;
        }
    }
}
