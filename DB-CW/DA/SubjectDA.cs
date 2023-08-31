using Models;
using Error;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Security.Policy;

namespace DA
{
    public class SubjectDA
    {
        private string connectString;
        private NpgsqlConnection connector;
        public NpgsqlConnection Connector { get => connector; set => connector = value; }
        public SubjectDA(ConnectionArgs args)
        {
            this.connectString = args.getString();
            this.Connector = new NpgsqlConnection(this.connectString);
            if (this.Connector == null)
                throw new DataBaseConnectException();
            this.Connector.Open();
            if (this.Connector.State != ConnectionState.Open)
                throw new DataBaseConnectException();
        }
        public List<Subject> getAllSubject()
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Subjects";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.Connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Subject> allSubject = new List<Subject>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Subject subject = new Subject(reader.GetInt32(0), reader.GetString(1));
                    allSubject.Add(subject);
                }
            reader.Close();
            return allSubject;
        }
        public void addSubject(string name)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "insert into Subjects(name) values ('" + name + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.Connector);
            cmd.ExecuteNonQuery();
        }
        public void updateSubject(int id, string name)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "update Subjects set name = '" + name + "' where id_subject = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.Connector);
            cmd.ExecuteNonQuery();
        }
        public void deleteSubject(int id)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "delete from Subjects where id_subject = " + id.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector); 
            cmd.ExecuteNonQuery();
        }
        public string getSubjectFromId(int id_subject)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select name from Subjects where id_subject = " + id_subject.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            string subject = string.Empty;
            if(reader.HasRows)
            {
                reader.Read();
                subject = reader.GetString(0);
            }    
            reader.Close();
            return subject;
        }
        public int getIdFromName(string name)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select id_subject from Subjects where name = '" + name + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int id_subject = -1;
            if (reader.HasRows)
            {
                reader.Read();
                id_subject = reader.GetInt32(0);
            }
            reader.Close();
            return id_subject;
        }
    }
}
