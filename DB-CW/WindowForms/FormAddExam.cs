using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormAddExam : Form
    {
        private QEServices qeServices;
        private SubjectServices subjectServices;
        private string type;
        private int id_subject, id_exam;
        private List<int> questions;
        public FormAddExam(QEServices qeServices, SubjectServices subjectServices, string type, object[] exam = null)
        {
            InitializeComponent();
            this.qeServices = qeServices;
            this.subjectServices = subjectServices;
            this.type = type;
            GetAllSubject();
            GetAllTime();
            if (this.type == "new")
            {
                this.Text = "Добавить ноывй тест";
                this.questions = new List<int>();
            }
            else
            {
                this.Text = "Изменить тест";
                this.id_exam = (int)exam[0];
                this.id_subject = subjectServices.getIdFromName((string)exam[1]);
                this.cbSubject.Text = (string)exam[1];
                this.txtCodeExam.Text = (string)exam[2];
                this.txtNameExam.Text = (string)exam[3];
                this.questions = (List<int>)exam[4];
                this.cbTime.Text = (string)exam[5];
            }
        }
        private void GetAllTime()
        {
            cbTime.Items.Add("5");
            cbTime.Items.Add("10");
            cbTime.Items.Add("20");
            cbTime.Items.Add("30");
        }
        private void GetAllSubject()
        {
            List<Subject> allSubject = subjectServices.getAllSubject();
            foreach (Subject subject in allSubject)
                cbSubject.Items.Add(subject.NameSubject);
        }
        private void ShowAllQuestion(List<Question> allQuestion, List<int> questions = null)
        {
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "Выбор";
            CBColumn.Name = "check";
            CBColumn.ValueType = typeof(bool);
            this.dgvQuestion.Rows.Clear();
            this.dgvQuestion.Columns.Clear();
            this.dgvQuestion.Columns.Add("id", "Id");
            this.dgvQuestion.Columns.Add(CBColumn);
            this.dgvQuestion.Columns.Add("subject", "Предмет");
            this.dgvQuestion.Columns.Add("question", "Вопрос");
            this.dgvQuestion.Columns.Add("ans1", "Ответ А");
            this.dgvQuestion.Columns.Add("ans2", "Ответ Б");
            this.dgvQuestion.Columns.Add("ans3", "Ответ В");
            this.dgvQuestion.Columns.Add("ans4", "Ответ Г");
            this.dgvQuestion.Columns.Add("ans", "Ответ");
            foreach (Question question in allQuestion)
            {
                string subject = subjectServices.getSubjectFromId(question.Id_subject);
                if (questions == null)
                    this.dgvQuestion.Rows.Add(question.Id_question, false, subject, question.Ques,
                    question.Answer1, question.Answer2, question.Answer3, question.Answer4, question.Answer);
                else 
                    if (questions.Contains(question.Id_question))
                    this.dgvQuestion.Rows.Add(question.Id_question, true, subject, question.Ques,
                        question.Answer1, question.Answer2, question.Answer3, question.Answer4, question.Answer);
                    else
                    this.dgvQuestion.Rows.Add(question.Id_question, false, subject, question.Ques,
                        question.Answer1, question.Answer2, question.Answer3, question.Answer4, question.Answer);
            }
            this.dgvQuestion.CurrentCell = null;
            foreach (DataGridViewColumn dc in dgvQuestion.Columns)
                if (dc.Index != 1)
                    dc.ReadOnly = true;
                else
                    dc.ReadOnly = false;
        }
        private void FormAddExam_Load(object sender, EventArgs e)
        {
            if (this.type == "new")
                ShowAllQuestion(qeServices.getAllQuestion());
            else
                ShowAllQuestion(qeServices.getAllQuestionSubject(id_subject), this.questions);
        }
        private void bntOK_Click(object sender, EventArgs e)
        {
            this.questions = new List<int>();
            foreach (DataGridViewRow row in dgvQuestion.Rows)
                if ((bool)row.Cells[1].Value == true)
                    this.questions.Add((int)row.Cells["id"].Value);
            if(this.type == "new")
            {
                try
                {
                    string nameExam = txtNameExam.Text;
                    string codeExam = txtCodeExam.Text;
                    int id_subject = subjectServices.getIdFromName(cbSubject.Text);
                    string duration = cbTime.Text;
                    if (qeServices.hasCodeExam(codeExam))
                        MessageBox.Show("Код теста уже существует!", "Info");
                    else if (nameExam.Length == 0)
                        MessageBox.Show("Введите название теста!" + nameExam, "Info");
                    else if (codeExam.Length == 0)
                        MessageBox.Show("Введите код теста!", "Info");
                    else if (id_subject < 1)
                        MessageBox.Show("Выберите предмет!", "Info");
                    else if (this.questions.Count == 0)
                        MessageBox.Show("Выберите вопросы для теста", "Info");
                    else if (duration.Length < 1)
                        MessageBox.Show("Выберите время для теста", "Info");
                    else
                    {
                        qeServices.addExam(id_subject, nameExam, codeExam, this.questions, Convert.ToInt32(duration));
                        MessageBox.Show("Успешно добавлен новый тест.", "Info");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    string nameExam = txtNameExam.Text;
                    int id_subject = subjectServices.getIdFromName(cbSubject.Text);
                    string codeExam = txtCodeExam.Text;
                    string duration = cbTime.Text;
                    if (nameExam.Length == 0)
                        MessageBox.Show("Введите название теста!", "Info");
                    else if (codeExam.Length == 0)
                        MessageBox.Show("Введите код теста!", "Info");
                    else if (id_subject < 1)
                        MessageBox.Show("Выберите предмет!", "Info");
                    else if (this.questions.Count == 0)
                        MessageBox.Show("Выберите вопросы для теста", "Info");
                    else if(this.id_exam != qeServices.getIdExamFromCode(codeExam) && qeServices.hasCodeExam(codeExam))
                        MessageBox.Show("Код теста уже существует!", "Info");
                    else if (duration.Length < 1)
                        MessageBox.Show("Выберите время для теста", "Info");
                    else
                    {
                        qeServices.updateExam(this.id_exam, id_subject, nameExam, codeExam, this.questions, Convert.ToInt32(duration));
                        MessageBox.Show("Успешно изменить информации теста.", "Info");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
        private void bntCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Отменить?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
        private void dgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                int id_question = Convert.ToInt32(this.dgvQuestion.Rows[e.RowIndex].Cells["id"].FormattedValue);
                if ((bool)this.dgvQuestion.CurrentCell.Value == false)
                    this.dgvQuestion.CurrentCell.Value = true;
                else
                    this.dgvQuestion.CurrentCell.Value = false;
            }
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_subject = subjectServices.getIdFromName(cbSubject.Text);
            ShowAllQuestion(qeServices.getAllQuestionSubject(id_subject));
        }        
    }
}
