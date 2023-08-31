using Error;
using Models;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System;

namespace DA
{
    public class ResultDA
    {
        private string connectString;
        private NpgsqlConnection connector;
        public NpgsqlConnection Connector { get => connector; set => connector = value; }
        public ResultDA(ConnectionArgs args)
        {
            this.connectString = args.getString();
            this.Connector = new NpgsqlConnection(this.connectString);
            if (this.Connector == null)
                throw new DataBaseConnectException();
            this.Connector.Open();
            if (this.Connector.State != ConnectionState.Open)
                throw new DataBaseConnectException();
        }
        public List<Result> getAllResult(string role, int id_user)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query;
            if (role != "S")
                query = "select name_exam, code_exam, name, score, totalScore, starttime, endtime from Results join Exams on Results.id_exam = Exams.id_exam" +
                    " join Users on Results.id_user = Users.id";
            else
                query = "select name_exam, code_exam, name, score, totalScore, starttime, endtime from Results join Exams on Results.id_exam = Exams.id_exam" +
                    " join Users on Results.id_user = Users.id where Results.id_user = " + id_user.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Result> allResult = new List<Result>();
            if(reader.HasRows)
                while(reader.Read())
                {
                    Result result = new Result(reader.GetString(0), reader.GetString(1), reader.GetString(2), 
                        reader.GetInt32(3), reader.GetInt32(4), DateTime.Parse(reader.GetString(5)), DateTime.Parse(reader.GetString(6)));
                    allResult.Add(result);
                }
            reader.Close();
            return allResult;
        }        
        public void addResult(int id_exam, int id_user, DateTime start, DateTime end, int score, int totalscore)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "insert into Results(id_exam, id_user, starttime, endtime, score, totalscore) values (" +
                id_exam + ", " + id_user + ", '" + Convert.ToString(start) + "', '" + Convert.ToString(end) + "', " + 
                score + ", " + totalscore + ")";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
    }
}
