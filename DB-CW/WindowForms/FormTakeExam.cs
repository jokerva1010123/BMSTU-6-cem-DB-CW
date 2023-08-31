using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormTakeExam : Form
    {
        private QEServices qeServices;
        private ResultServices resultServices;
        private int id_user, id_exam, id_ques;
        private List<string> ans, correctAns;
        private DateTime start;
        private int minute, second;
        public FormTakeExam(QEServices qEServices, ResultServices resultServices, int id_user, int id_exam)
        {
            InitializeComponent();
            this.start = DateTime.Now;
            this.qeServices = qEServices;
            this.resultServices = resultServices;
            this.id_ques = -1;
            this.id_user = id_user;
            this.id_exam = id_exam;
            this.ans = new List<string>();
            this.correctAns = new List<string>();
            this.minute = 0;
            this.second = 0;
        }
        private void FormTakeExam_Load(object sender, System.EventArgs e)
        {
            dgvQuestion.Rows.Clear();
            dgvQuestion.Columns.Clear();
            dgvQuestion.Columns.Add("num", "Номер");
            dgvQuestion.Columns.Add("ques", "Вопрос");
            dgvQuestion.Columns.Add("ans1", "ans1");
            dgvQuestion.Columns.Add("ans2", "ans2");
            dgvQuestion.Columns.Add("ans3", "ans3");
            dgvQuestion.Columns.Add("ans4", "ans4");
            foreach(DataGridViewColumn c in dgvQuestion.Columns)
                if(c.Index > 1)
                    c.Visible = false;
            List<Question> listQuestion = qeServices.getQuestion(id_exam);
            int id = 1;
            foreach(Question question in listQuestion)
            {
                dgvQuestion.Rows.Add(id, question.Ques, question.Answer1, question.Answer2, question.Answer3,
                    question.Answer4);
                this.correctAns.Add(question.Answer);
                this.ans.Add("");
                id++;
            }
            dgvQuestion.Columns[0].Width = 50;
            dgvQuestion.CurrentCell.Selected = false;
            this.minute = qeServices.getDuration(id_exam);
            this.time.Text = string.Format("{0}:{1}", this.minute.ToString(), this.second.ToString());
        }
        private void dgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.gbAnswer.Enabled = true;
                this.id_ques = (int)dgvQuestion.Rows[e.RowIndex].Cells[0].Value;
                string ans1 = (string)dgvQuestion.Rows[e.RowIndex].Cells["ans1"].Value;
                string ans2 = (string)dgvQuestion.Rows[e.RowIndex].Cells["ans2"].Value;
                string ans3 = (string)dgvQuestion.Rows[e.RowIndex].Cells["ans3"].Value;
                string ans4 = (string)dgvQuestion.Rows[e.RowIndex].Cells["ans4"].Value;
                this.rAns1.Text = "A. " + ans1;
                this.rAns2.Text = "B. " + ans2;
                this.rAns3.Text = "C. " + ans3;
                this.rAns4.Text = "D. " + ans4;
                if (ans[e.RowIndex] == "")
                {
                    this.rAns1.Checked = false;
                    this.rAns2.Checked = false;
                    this.rAns3.Checked = false;
                    this.rAns4.Checked = false;
                }
                else
                {
                    if (ans[e.RowIndex] == ans1) this.rAns1.Checked = true;
                    if (ans[e.RowIndex] == ans2) this.rAns2.Checked = true;
                    if (ans[e.RowIndex] == ans3) this.rAns3.Checked = true;
                    if (ans[e.RowIndex] == ans4) this.rAns4.Checked = true;
                }
            }
        }
        private void rAns1_CheckedChanged(object sender, System.EventArgs e)
        {
            if(((RadioButton)sender).Checked)
            {
                string text = ((RadioButton)sender).Text;
                text = text.Split('A')[1].Trim();
                text = text.Split('.')[1].Trim();
                ans[id_ques - 1] = text;
            }
            else if(((RadioButton)sender).Checked == false)
                ans[id_ques - 1] = "";
        }
        private void rAns2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                string text = ((RadioButton)sender).Text;
                text = text.Split('B')[1].Trim();
                text = text.Split('.')[1].Trim();
                ans[id_ques - 1] = text;
            }
            else if (((RadioButton)sender).Checked == false)
                ans[id_ques - 1] = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.second == 0 && this.minute == 0)
            {
                this.timer.Enabled = false;
                int score = 0, totalScore = ans.Count;
                for (int i = 0; i < ans.Count; i++)
                    if (ans[i] == correctAns[i])
                        score++;
                DateTime end = DateTime.Now;
                resultServices.addResult(this.id_exam, this.id_user, start, end, score, totalScore);
                MessageBox.Show("Результат: " + score + "/" + totalScore, "Info");
                this.Close();
                return;
            }
            else if(this.second == 0)
            {
                this.second = 59;
                this.minute -= 1;
            }
            else
            {
                this.second -= 1;
            }
            this.time.Text = string.Format("{0}:{1}", this.minute.ToString(), this.second.ToString());
        }

        private void rAns3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                string text = ((RadioButton)sender).Text;
                text = text.Split('C')[1].Trim();
                text = text.Split('.')[1].Trim();
                ans[id_ques - 1] = text;
            }
            else if (((RadioButton)sender).Checked == false)
                ans[id_ques - 1] = "";
        }
        private void rAns4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                string text = ((RadioButton)sender).Text;
                text = text.Split('D')[1].Trim();
                text = text.Split('.')[1].Trim();
                ans[this.id_ques - 1] = text;
            }
            else if (((RadioButton)sender).Checked == false)
                ans[id_ques - 1] = "";
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Завершить тест?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int score = 0, totalScore = ans.Count;
                for (int i = 0; i < ans.Count; i++)
                    if (ans[i] == correctAns[i])
                        score++;
                DateTime end = DateTime.Now;
                resultServices.addResult(this.id_exam, this.id_user, start, end, score, totalScore);
                MessageBox.Show("Результат: " + score + "/" + totalScore, "Info");
                this.Close();
            }
        }
    }
}
