﻿using Npgsql;
using System.Data;
using Error;

namespace DA
{
    public class ConnectionArgs
    {
        private string user;
        private string password;
        private string host;
        private string database;
        private int port;
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Host { get => host; set => host = value; }
        public string Database { get => database; set => database = value; }
        public int Port { get => port; set => port = value; }
        public ConnectionArgs(string user, string host, string database, string password, int port)
        {
            this.user = user;
            this.password = password;
            this.host = host;
            this.database = database;
            this.port = port;
        }
        public ConnectionArgs(ConnectionArgs args)
        {
            user = args.User;
            password = args.Password;
            host = args.Host;
            database = args.Database;
            port = args.Port;
        }
        public string getString()
        {
            return "Host = " + host + "; Username = " + user + "; Password = " + password + "; Database = " + database + ";";
        }
    }
    public static class ConnectionCheck
    {
        public static void checkConnection(NpgsqlConnection connector)
        {
            if (connector == null || connector.State != ConnectionState.Open)
                throw new DataBaseConnectException();
        }
    }
}
