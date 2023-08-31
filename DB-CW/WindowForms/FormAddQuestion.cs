using BL;
using Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormAddQuestion : Form
    {
        private QEServices qeServices;
        private SubjectServices subjectServices;
        private int id_question;
        private string type;
        public FormAddQuestion(QEServices qeServices, SubjectServices subjectServices, string type, object[] question = null)
        {
            InitializeComponent();
            this.qeServices = qeServices;
            this.subjectServices = subjectServices;
            this.type = type;
            GetAllSubject();
            if (this.type == "new")
                this.Text = "Добавить вопрос";
            else
            {
                this.Text = "Изменить вопрос";                
                this.txtQuestion.Text = (string)question[0];
                this.txtAns1.Text = (string)question[1];
                this.txtAns2.Text = (string)question[2];
                this.txtAns3.Text = (string)question[3];
                this.txtAns4.Text = (string)question[4];
                this.txtAns.Text = (string)question[5];
                this.cbSubject.Text = (string)question[6];
                this.id_question = (int)question[7];
                this.btnAdd.Text = "Сохранить";
            }
        }
        private void GetAllSubject()
        {
            List<Subject> allSubject = subjectServices.getAllSubject();
            foreach (Subject subject in allSubject)
                cbSubject.Items.Add(subject.NameSubject);
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            string ques = txtQuestion.Text;
            string ans1 = txtAns1.Text;
            string ans2 = txtAns2.Text;
            string ans3 = txtAns3.Text;
            string ans4 = txtAns4.Text;
            string ans = txtAns.Text;
            int id_subject = subjectServices.getIdFromName(cbSubject.Text);
            if(ques.Length == 0)
            {
                MessageBox.Show("Введите вопрос!", "Error");
                return;
            }
            if(ans.Length == 0 || ans1.Length == 0 || ans2.Length == 0 || ans3.Length == 0 || ans4.Length == 0)
            {
                MessageBox.Show("Введите все ответы!", "Error");
                return;
            }
            if(ans != ans1 && ans != ans2 && ans != ans3 && ans != ans4)
            {
                MessageBox.Show("Правильный ответ не совпадает с одном из ответов!", "Error");
                return;
            }
            if(id_subject < 1)
            {
                MessageBox.Show("Введите предмет для предмета!", "Error");
                return;
            }
            if (this.type == "new")
            {
                qeServices.addQuestion(ques, ans1, ans2, ans3, ans4, ans, id_subject);
                MessageBox.Show("Успешно добавлен новый вопрос.", "Info");
                this.Close();
            }
            else
            {
                qeServices.updateQuestion(id_question, ques, ans1, ans2, ans3, ans4, ans, id_subject);
                MessageBox.Show("Успешно изменить информации вопроса.", "Info");
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            if(MessageBox.Show("Отменить?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
