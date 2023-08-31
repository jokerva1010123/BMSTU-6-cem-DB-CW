using System.Data;
using Npgsql;
using Error;
using Models;
using System;
using System.Collections.Generic;

namespace DA
{
    public class UserDA
    {
        private string connectString;
        private NpgsqlConnection connector;
        public NpgsqlConnection Connector { get => connector; set => connector = value; }
        public UserDA(ConnectionArgs args)
        {
            this.connectString = args.getString();
            this.Connector = new NpgsqlConnection(this.connectString);
            if (this.Connector == null)
                throw new DataBaseConnectException();
            this.Connector.Open();
            if (this.Connector.State != ConnectionState.Open)
                throw new DataBaseConnectException();
        }
        public User? login(string username, string password)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Users where username = '" + username + "' and pass_word = '" + password + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            User? user = null;
            if(reader.HasRows)
            {
                reader.Read();
                user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            reader.Close();
            return user;
        }
        public string getRoleFromId(int id)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select role from Users where id = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            string role = string.Empty;
            if (reader.HasRows)
            {
                reader.Read();
                role = reader.GetString(0);
            }
            reader.Close();
            return role;
        }
        public List<User> getAllUser(string role)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Users where role = '" + role + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<User> allUser = new List<User>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                    allUser.Add(user);
                }
            reader.Close();
            return allUser;
        }
        public Boolean existsUser(string username)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Users where username = '" + username + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
        public void addUser(string name, string username, string role, string password = "Abcd@123")
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "insert into Users(name, username, pass_word, role) values " +
                "( '" + name +"' , '" + username + "' , '" + password + "', '" + role +"')";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public int getIdFromUsername(string username)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select id from Users where username = '" + username +"'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int id = -1;
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            reader.Close();
            return id;
        }
        public void updateUser(int id, string name, string username)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "update Users set name = '" + name + "' , username = '" 
                + username + "' where id = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void deleteUser(int id)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "delete from Users where id = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void changePW(int id, string password = "Abcd@123")
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "update Users set pass_word = '" + password + "' where id = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public string getPasswordFromId(int id)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select pass_word from Users where id = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            string str = "";
            if (reader.HasRows)
            {
                reader.Read();
                str = reader.GetString(0);
            }
            reader.Close();
            return str;
        }
    }
}
