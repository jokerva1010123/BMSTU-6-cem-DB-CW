using Error;
using Models;
using Npgsql;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DA
{
    public class QEDA
    {
        private string connectString;
        private NpgsqlConnection connector;
        public NpgsqlConnection Connector { get => connector; set => connector = value; }
        public QEDA(ConnectionArgs args)
        {
            this.connectString = args.getString();
            this.Connector = new NpgsqlConnection(this.connectString);
            if (this.Connector == null)
                throw new DataBaseConnectException();
            this.Connector.Open();
            if (this.Connector.State != ConnectionState.Open)
                throw new DataBaseConnectException();
        }
        public List<Question> getAllQuestion()
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Questions";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Question> result = new List<Question>();
            if (reader.HasRows)
                while (reader.Read())
                    result.Add(new Question(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
            reader.Close();
            return result;
        }
        public List<Question> getAllQuestionSubject(int id_subject)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Questions where id_subject = " + id_subject.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Question> result = new List<Question>();
            if (reader.HasRows)
                while (reader.Read())
                    result.Add(new Question(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
            reader.Close();
            return result;
        }
        public List<Exam> getAllExam()
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from Exams";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Exam> result = new List<Exam>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    List<int> question = new List<int>();
                    result.Add(new Exam(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), question, reader.GetInt32(4)));
                }
            reader.Close();
            return result;
        }
        public List<int> getListIdQuestion(int id_exam)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select id_question from exam_question where id_exam = " + id_exam.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<int> result = new List<int>();
            if (reader.HasRows)
                while (reader.Read())
                    result.Add(reader.GetInt32(0));
            reader.Close();
            return result;
        }
        public List<Question> getListQuestion(int id_exam)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select * from questions join exam_question " +
                "on exam_question.id_question = questions.id_question where id_exam = " + id_exam;
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            List<Question> result = new List<Question>();
            if (reader.HasRows)
                while (reader.Read())
                {
                    Question question = new Question(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), 
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
                    result.Add(question);
                }
            reader.Close();
            return result;
        }
        public void deleteQuestion(int id_quetion)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "delete from Questions where id_question = " + id_quetion.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void deleteExam(int id_exam)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "delete from Exams where id_exam = " + id_exam.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void addQuestion(string ques, string ans1, string ans2, string ans3, string ans4, string ans, int id_subject)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "insert into Questions(id_subject, question, answer1, answer2, answer3, answer4, answer) " +
                "values (" + id_subject.ToString() + ", '" + ques + "', '" + ans1 + "', '" + ans2 + "', '" +
                ans3 + "', '" + ans4 + "', '" + ans + "')";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void updateQuestion(int id_question, string ques, string ans1, string ans2, string ans3, string ans4, string ans, int id_subject)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "update Questions set question = '" + ques + "', answer1 = '" + ans1 + "', answer2 = '" + ans2 + "', answer3 = '" + 
                ans3 + "', answer4 = '" + ans4 + "', answer = '" + ans + "', id_subject = " + id_subject.ToString() + " where id_question = " + id_question.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void addExam(int id_subject, string nameExam, string code_exam, int duration)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "insert into Exams(id_subject, name_exam, code_exam, duration) values (" + id_subject + ", '" + nameExam + "', '" + code_exam + "', " + duration +")";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public int getIdExamFromCode(string code)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "Select id_exam from Exams where code_exam = '" + code + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int id_exam = -1;
            if(reader.HasRows)
            {
                reader.Read();
                id_exam = reader.GetInt32(0);
            }
            reader.Close();
            return id_exam;
        }
        public void addQuestionExam(int id_exam, int id_question)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "insert into exam_question(id_exam, id_question) values (" + id_exam + ", " + id_question + ")";
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void deleteQuestionExam(int id_exam, int id_question)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "delete from exam_question where id_exam = " + id_exam + " and id_question = " + id_question;
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public void updateExam(int id_exam, int id_subject, string name, string code, int duration)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "update exams set name_exam = '" + name + "', code_exam = '" + code + "', id_subject = " + id_subject + ", duration = " + duration +
                "where id_exam = " + id_exam;
            NpgsqlCommand cmd = new NpgsqlCommand(query, this.connector);
            cmd.ExecuteNonQuery();
        }
        public int getDuration(int id_exam)
        {
            ConnectionCheck.checkConnection(this.connector);
            string query = "select duration from Exams where id_exam = " + id_exam;
            NpgsqlCommand cmd = new NpgsqlCommand(query, connector);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int result = -1;
            if(reader.HasRows)
            {
                reader.Read();
                result = reader.GetInt32(0);
            }
            reader.Close();
            return result;
        }
    }
}
