using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLDThi
{
    public partial class FormAddQuestion : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        int questionId, SubjectId;
        string typeForm, _listAnswer, SubjectName;
        string[] _answer;
        int max = 2147483647;
        List<string> listCorrectAnswer;
        class SubjectItem
        {
            public int subjectId { get; set; }

            public string subjectName { get; set; }
        }

        public FormAddQuestion(int question_id, string question, string answer, string correctAnswer, string type, int subjectId, string subjectName)
        {
            InitializeComponent();
            questionId = question_id;
            typeForm = type;
            SubjectName = subjectName;
            SubjectId = subjectId;
            if (typeForm == "new")
            {
                this.Text = "Thêm mới câu hỏi";
            }
            else if (typeForm == "edit")
            {
                this.Text = "Sửa câu hỏi";
                _answer = answer.TrimStart('[').TrimEnd(']').Split(',');

                richTextBox1.Text = Base64Decode(question);
                richTextBox2.Text = _answer[0];
                richTextBox3.Text = _answer[1];
                richTextBox4.Text = _answer[2];
                richTextBox5.Text = _answer[3];
                richTextBox6.Text = correctAnswer;
                listCorrectAnswer = new List<string>() { richTextBox2.Text.Trim(), richTextBox3.Text.Trim(), richTextBox4.Text.Trim(), richTextBox5.Text.Trim() };
                cbSubject.Text = SubjectName;
            }
        }

        public void saveChange()
        {
            if (validateAnswer() == true)
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand("editQuestion", connection);
                command.CommandType = CommandType.StoredProcedure;

                _listAnswer = String.Format("[{0}, {1}, {2}, {3}]", richTextBox2.Text.Trim(), richTextBox3.Text.Trim(), richTextBox4.Text.Trim(), richTextBox5.Text.Trim());
                SqlParameter id = command.Parameters.Add("id", SqlDbType.Int);
                id.Value = questionId;
                SqlParameter question = command.Parameters.Add("question", SqlDbType.NVarChar, max);
                question.Value = Base64Encode(richTextBox1.Text.Trim());
                SqlParameter listAnswer = command.Parameters.Add("listAnswer", SqlDbType.NVarChar, max);
                listAnswer.Value = _listAnswer;
                SqlParameter correctAnswer = command.Parameters.Add("correctAnswer", SqlDbType.NVarChar, max);
                correctAnswer.Value = richTextBox6.Text.Trim();
                SqlParameter subjectId = command.Parameters.Add("subjectId", SqlDbType.NVarChar, max);
                subjectId.Value = SubjectId;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("Đáp án đúng phải trùng với một trong các đáp án trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn hủy?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                richTextBox5.Text = "";
                richTextBox6.Text = "";
                Close();
            }
        }


        public void saveData()
        {
            listCorrectAnswer = new List<string>() { richTextBox2.Text.Trim(), richTextBox3.Text.Trim(), richTextBox4.Text.Trim(), richTextBox5.Text.Trim() };
            if (validateAnswer() == true)
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand("addQuestion", connection);
                command.CommandType = CommandType.StoredProcedure;

                _listAnswer = String.Format("[{0}, {1}, {2}, {3}]", richTextBox2.Text.Trim(), richTextBox3.Text.Trim(), richTextBox4.Text.Trim(), richTextBox5.Text.Trim());
                SqlParameter cauHoi = command.Parameters.Add("question", SqlDbType.NVarChar, max);
                cauHoi.Value = Base64Encode(richTextBox1.Text.Trim());
                SqlParameter listAnswer = command.Parameters.Add("listAnswer", SqlDbType.NVarChar, max);
                listAnswer.Value = _listAnswer;
                SqlParameter correctAnswer = command.Parameters.Add("correctAnswer", SqlDbType.NVarChar, max);
                correctAnswer.Value = richTextBox6.Text.Trim();
                SqlParameter subjectId = command.Parameters.Add("subjectId", SqlDbType.NVarChar, max);
                subjectId.Value = SubjectId;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("Đáp án đúng phải trùng với một trong các đáp án trên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void txtHoten_Validating(object sender, CancelEventArgs e)
        {
            string question = richTextBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(question))
            {
                e.Cancel = true;
                richTextBox1.Focus();
                errorName.SetError(richTextBox1, "Trường Câu hỏi không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(richTextBox1, "");
            }
        }

        private void txtDapan_Validating(object sender, CancelEventArgs e)
        {
            string answer1 = richTextBox2.Text.Trim();
            string answer2 = richTextBox3.Text.Trim();
            string answer3 = richTextBox4.Text.Trim();
            string answer4 = richTextBox5.Text.Trim();
            string correctAnswer = richTextBox6.Text.Trim();
            if (string.IsNullOrWhiteSpace(answer1))
            {
                e.Cancel = true;
                richTextBox2.Focus();
                errorName.SetError(richTextBox2, "Trường Đáp án không được bỏ trống");
            }
            else if (string.IsNullOrWhiteSpace(answer2))
            {
                e.Cancel = true;
                richTextBox3.Focus();
                errorName.SetError(richTextBox3, "Trường Đáp án không được bỏ trống");
            }
            else if (string.IsNullOrWhiteSpace(answer3))
            {
                e.Cancel = true;
                richTextBox4.Focus();
                errorName.SetError(richTextBox4, "Trường Đáp án không được bỏ trống");
            }
            else if (string.IsNullOrWhiteSpace(answer4))
            {
                e.Cancel = true;
                richTextBox5.Focus();
                errorName.SetError(richTextBox5, "Trường Đáp án không được bỏ trống");
            }
            else if (string.IsNullOrWhiteSpace(correctAnswer))
            {
                e.Cancel = true;
                richTextBox6.Focus();
                errorName.SetError(richTextBox6, "Trường Đáp án đúng không được bỏ trống");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(richTextBox2, "");
                errorName.SetError(richTextBox3, "");
                errorName.SetError(richTextBox4, "");
                errorName.SetError(richTextBox5, "");
                errorName.SetError(richTextBox6, "");
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (typeForm == "new")
                    saveData();
                else if (typeForm == "edit")
                    saveChange();
            }
        }

        private bool validateAnswer()
        {
            return listCorrectAnswer.Contains(richTextBox6.Text);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private void FormAddQuestion_Load(object sender, EventArgs e)
        {
            GetListSubject();
        }

        private void GetListSubject()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("getListSubject", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReaderSubject = command.ExecuteReader();
            if (dataReaderSubject.HasRows)
            {
                while (dataReaderSubject.Read())
                {
                    cbSubject.Items.Add(new SubjectItem()
                    {
                        subjectId = dataReaderSubject.GetInt32(0),
                        subjectName = dataReaderSubject.GetString(1)
                    });
                }
                cbSubject.DisplayMember = "subjectName";
                cbSubject.ValueMember = "subjectId";
            }
            connection.Close();
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubject.SelectedIndex != -1)
            {
                SubjectItem selectedItem = cbSubject.SelectedItem as SubjectItem;
                if (selectedItem != null)
                {
                    SubjectName = selectedItem.subjectName;
                    SubjectId = selectedItem.subjectId;
                }
            }
        }
    }
}
