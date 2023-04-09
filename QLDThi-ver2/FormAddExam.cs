using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDThi
{
    public partial class FormAddExam : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        string question, correctAnswer, listAnswerRaw, SubjectName;
        int question_id, _examId, SubjectId;
        string listAnswer, _code, typeForm;
        List<int> thisListQuestionId = new List<int>();
        List<int> newListQuestionId = new List<int>();
        List<int> listQuestionId = new List<int>();
        class SubjectItem
        {
            public int subjectId { get; set; }

            public string subjectName { get; set; }
        }

        public FormAddExam(int examId, string code, string _listQuestionId, string type, int subjectId, string subjectName)
        {
            InitializeComponent();
            _code = code;
            _examId = examId;
            typeForm = type;
            SubjectId = subjectId;
            SubjectName = subjectName;
            thisListQuestionId = _listQuestionId != null ? _listQuestionId?.TrimStart('[').TrimEnd(']').Split(',')?.Select(Int32.Parse)?.ToList() : new List<int>();
            listQuestionId = thisListQuestionId;
        }

        private void FormAddExam_Load(object sender, EventArgs e)
        {
            ReloadForm();
            GetListSubject();
            cbSubject.SelectedItem = null;
            cbSubject.SelectedText = "Tất cả";
            if (typeForm == "edit")
            {
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    for (int j = 0; j < thisListQuestionId.Count; j++)
                    {
                        if (Convert.ToInt32(dataGridView3.Rows[i].Cells[1].Value) == Convert.ToInt32(thisListQuestionId[j]))
                        {
                            dataGridView3.Rows[i].Cells[0].Value = true;
                        }
                    }
                }
                textBox1.Text = _code;
                textBox1.ReadOnly = true;
                cbSubject.Text = SubjectName;
            }
        }
        public void ReloadForm()
        {
            //danh sách câu hỏi
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("getListQuestion", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapterQuestions = new SqlDataAdapter(command1);
            DataTable dataTableQuestion = new DataTable();
            dataAdapterQuestions.Fill(dataTableQuestion);
            dataGridView3.DataSource = dataTableQuestion;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (typeForm == "new")
                add();
            else if (typeForm == "edit")
                edit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                this.dataGridView3.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (this.dataGridView3.CurrentCell.Value == null || (bool)this.dataGridView3.CurrentCell.Value == false)
                {
                    this.dataGridView3.CurrentCell.Value = true;
                    var id = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                    if (typeForm == "new")
                    {
                        listQuestionId.Add(id);
                    }
                    else if (typeForm == "edit")
                    {
                        listQuestionId.ForEach((item) => { newListQuestionId.Add(item); });
                        newListQuestionId.Add(id);
                    }
                }
                else if ((bool)this.dataGridView3.CurrentCell.Value == true)
                {
                    this.dataGridView3.CurrentCell.Value = false;
                    var id = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value);
                    newListQuestionId = listQuestionId.ToList();
                    newListQuestionId.Remove(id);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridView3.CurrentRow.Selected = true;

                    question_id = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].FormattedValue);
                    question = (dataGridView3.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                    listAnswerRaw = (dataGridView3.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    correctAnswer = (dataGridView3.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                }
            }

        }

        private void add()
        {
            if (listQuestionId.Count() == 0)
                MessageBox.Show("Hãy chọn ít nhất một câu hỏi");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("addExam", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter thisCode = command.Parameters.Add("@code", SqlDbType.NVarChar);
                thisCode.Value = textBox1.Text;
                SqlParameter _listQuestionId = command.Parameters.Add("@listQuestionId", SqlDbType.NVarChar);
                string result = string.Join(",", listQuestionId);
                result = String.Format("[{0}]", result);
                _listQuestionId.Value = result;
                SqlParameter thisSubjectId = command.Parameters.Add("@subjectId", SqlDbType.NVarChar);
                thisSubjectId.Value = SubjectId;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm đề thi thành công");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Đã có lỗi xảy ra", e.Message);
                }
                connection.Close();
                Close();
            }
        }

        private void edit()
        {
            if (listQuestionId.Count() == 0)
                MessageBox.Show("Hãy chọn ít nhất một câu hỏi");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("editExam", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter _id = command.Parameters.Add("@id", SqlDbType.NVarChar);
                _id.Value = _examId;
                SqlParameter _listQuestionId = command.Parameters.Add("@listQuestionId", SqlDbType.NVarChar);
                string result = string.Join("; ", newListQuestionId);
                _listQuestionId.Value = result;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sửa đề thi thành công");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Đã có lỗi xảy ra", e.Message);
                }
                connection.Close();
                Close();
            }
        }
        private void GetListSubject()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("getListSubject", connection);
            command.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlDataReader dataReaderSubject = command.ExecuteReader();
            cbSubject.Items.Add(new SubjectItem()
            {
                subjectId = 0,
                subjectName = "Tất cả"
            });
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

        public void GetQuestionBySubjectId()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("getListQuestionBySubject", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlParameter thisSubjectId = command1.Parameters.Add("@subjectId", SqlDbType.Int);
            thisSubjectId.Value = SubjectId;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView3.DataSource = dataTable;
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
            GetQuestionBySubjectId();
        }
    }
}
