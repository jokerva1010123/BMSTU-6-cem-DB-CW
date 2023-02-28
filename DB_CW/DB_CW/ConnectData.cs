using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CW
{
    class ConnectData
    {
        public NpgsqlConnection connector;
        public void connect()
        {
            String strConnect = "Host=localhost;Username=postgres;Password=0612;Database=DB_CW";
            connector = new NpgsqlConnection(strConnect);
            connector.Open();
        }
        public void disconnect() 
        {
            connector.Close();
            connector.Dispose();
            connector = null;
        }
    }
}
