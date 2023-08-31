using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormQuestion : Form
    {
        private QEServices qeServices;
        private readonly SubjectServices subjectServices;
        private int id_exam;
        private int id_question;
        private string ques, ans1, ans2, ans3, ans4, ans, subj, subjE, code, name, duration;
        private List<int> questions = new List<int>();
        public FormQuestion(QEServices qEServices, SubjectServices subjectServices)
        {
            InitializeComponent();
            this.qeServices = qEServices;
            this.subjectServices = subjectServices;
        }
        private void ShowAllQuestion(List<Question> allQuestions)
        {
            this.dgvQuestion.Rows.Clear();
            this.dgvQuestion.Columns.Clear();
            this.dgvQuestion.Columns.Add("id", "Id");
            this.dgvQuestion.Columns.Add("subject", "Предмет");
            this.dgvQuestion.Columns.Add("question", "Вопрос");
            this.dgvQuestion.Columns.Add("ans1", "Ответ А");
            this.dgvQuestion.Columns.Add("ans2", "Ответ Б");
            this.dgvQuestion.Columns.Add("ans3", "Ответ В");
            this.dgvQuestion.Columns.Add("ans4", "Ответ Г");
            this.dgvQuestion.Columns.Add("ans", "Ответ");
            foreach (Question question in allQuestions)
            {
                string subject = subjectServices.getSubjectFromId(question.Id_subject);
                this.dgvQuestion.Rows.Add(question.Id_question, subject, question.Ques,
                    question.Answer1, question.Answer2, question.Answer3, question.Answer4, question.Answer);
            }
            this.dgvQuestion.CurrentCell = null;
        }
        private void ShowAllExam(List<Exam> allExam)
        {
            this.dgvExam.Rows.Clear();
            this.dgvExam.Columns.Clear();
            this.dgvExam.Columns.Add("id", "Id");
            this.dgvExam.Columns.Add("name", "Тест");
            this.dgvExam.Columns.Add("code", "Код теста");
            this.dgvExam.Columns.Add("subject", "Предмет");
            this.dgvExam.Columns.Add("questions", "Вопросы");
            this.dgvExam.Columns.Add("time", "Время");
            foreach (Exam exam in allExam)
            {
                string subject = subjectServices.getSubjectFromId(exam.Id_subject);
                string question = "[" + string.Join(",", exam.Question) + "]";
                this.dgvExam.Rows.Add(exam.Id_exam, exam.Name, exam.Code, subject, question, exam.Duration);
            }
            this.dgvExam.CurrentCell = null;
        }
        private void FormQuestion_Load(object sender, System.EventArgs e)
        {
            ShowAllQuestion(qeServices.getAllQuestion());
            ShowAllExam(qeServices.getAllExam());
        }
        private void bntAddQuestion_Click(object sender, System.EventArgs e)
        {
            FormAddQuestion formAddQuestion = new FormAddQuestion(this.qeServices, this.subjectServices, "new");
            formAddQuestion.ShowDialog();
            ShowAllQuestion(qeServices.getAllQuestion());
            this.btnChangeQuestion.Enabled = false;
            this.btnDeleteQuestion.Enabled = false;
        }
        private void btnChangeQuestion_Click(object sender, System.EventArgs e)
        {
            object[] question = new object[] {ques, ans1, ans2, ans3, ans4, ans, subj, id_question};
            FormAddQuestion formAddQuestion = new FormAddQuestion(this.qeServices, this.subjectServices, "edit", question);
            formAddQuestion.ShowDialog();
            ShowAllQuestion(qeServices.getAllQuestion());
            this.btnChangeQuestion.Enabled = false;
            this.btnDeleteQuestion.Enabled = false;
        }
        private void btnDeleteQuestion_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("Удалить?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                qeServices.deleteQuestion(id_question);
                MessageBox.Show("Удалить вопрос успешно", "Info");
                ShowAllQuestion(qeServices.getAllQuestion());
                this.btnChangeQuestion.Enabled = false;
                this.btnDeleteQuestion.Enabled = false;
            }                
        }
        private void bntAddExam_Click(object sender, System.EventArgs e)
        {
            FormAddExam formAddExam = new FormAddExam(this.qeServices, this.subjectServices, "new");
            formAddExam.ShowDialog();
            ShowAllExam(qeServices.getAllExam());
            this.btnDeleteExam.Enabled = false;
            this.btnChangeExam.Enabled = false;
        }
        private void btnChangeExam_Click(object sender, System.EventArgs e)
        {
            object[] exam = new object[] {this.id_exam, this.subjE, this.code, this.name, this.questions, this.duration};
            FormAddExam formAddExam = new FormAddExam(this.qeServices, this.subjectServices, "edit", exam);
            formAddExam.ShowDialog();
            ShowAllExam(qeServices.getAllExam());
            this.btnDeleteExam.Enabled = false;
            this.btnChangeExam.Enabled = false;
        }
        private void btnDeleteExam_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                qeServices.deleteExam(id_exam);
                MessageBox.Show("Удалить тесты успешно", "Info");
                ShowAllExam(qeServices.getAllExam());
                this.btnDeleteExam.Enabled = false;
                this.btnChangeExam.Enabled = false;
            }
        }
        private void dgvQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (dgvQuestion.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dgvQuestion.CurrentRow.Selected = true;
                    id_question = Convert.ToInt32(dgvQuestion.Rows[e.RowIndex].Cells["id"].FormattedValue);
                    ques = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["question"].FormattedValue);
                    ans1 = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["ans1"].FormattedValue);
                    ans2 = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["ans2"].FormattedValue);
                    ans3 = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["ans3"].FormattedValue);
                    ans4 = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["ans4"].FormattedValue);
                    ans = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["ans"].FormattedValue);
                    subj = Convert.ToString(dgvQuestion.Rows[e.RowIndex].Cells["subject"].FormattedValue);

                    this.btnChangeQuestion.Enabled = true;
                    this.btnDeleteQuestion.Enabled = true;
                }
        }
        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (dgvExam.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dgvExam.CurrentRow.Selected = true;
                    this.id_exam = Convert.ToInt32(dgvExam.Rows[e.RowIndex].Cells["id"].FormattedValue);
                    this.subjE = Convert.ToString(dgvExam.Rows[e.RowIndex].Cells["subject"].FormattedValue);
                    this.code = Convert.ToString(dgvExam.Rows[e.RowIndex].Cells["code"].FormattedValue);
                    this.name = Convert.ToString(dgvExam.Rows[e.RowIndex].Cells["name"].FormattedValue);
                    string listquestion = Convert.ToString(dgvExam.Rows[e.RowIndex].Cells["questions"].FormattedValue);
                    this.duration = Convert.ToString(dgvExam.Rows[e.RowIndex].Cells["time"].FormattedValue);
                    try
                    {
                        this.questions = listquestion.TrimStart('[').TrimEnd(']').Split(',').Select(Int32.Parse).ToList();
                    }
                    catch
                    {
                        this.questions = new List<int>();
                    }

                    this.btnDeleteExam.Enabled = true;
                    this.btnChangeExam.Enabled = true;
                }
        }
    }
}
