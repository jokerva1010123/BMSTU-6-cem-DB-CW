using BL;
using DB_CW.WindowForms;
using System;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormHome : Form
    {
        private string username, role;
        private readonly int id_user;
        private UserServices userServices;
        private ResultServices resultServices;
        private SubjectServices subjectServices;
        private QEServices qeServices;
        public FormHome(string username, int id_user, string role, UserServices userServices, ResultServices resultServices, SubjectServices subjectServices, QEServices qEServices)
        {
            InitializeComponent();
            this.username = username;
            this.id_user = id_user;
            this.role = role;
            this.userServices = userServices;
            this.resultServices = resultServices;
            this.subjectServices = subjectServices;
            this.qeServices = qEServices;
        }
        private void FormHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Добро пожаловать, " + this.username + "!";
            if (this.role == "A")
            {
                btnThi.Visible = false;
                btnLichSuThi.Visible = true;
                btnQuanTri.Visible = true;
                btnUser.Visible = true;
                btnSubject.Visible = true;
            }
            else if (this.role == "T")
            {
                btnThi.Visible = false;
                btnLichSuThi.Visible = true;
                btnQuanTri.Visible = true;
                btnSubject.Visible = false;
                btnUser.Visible = false;
            }
            else
            {
                btnThi.Visible = true;
                btnLichSuThi.Visible = true;
                btnQuanTri.Visible = false;
                btnUser.Visible = false;
                btnSubject.Visible = false;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSubject_Click(object sender, EventArgs e)
        {
            FormSubject formSubject = new FormSubject(this.subjectServices);
            this.Hide();
            formSubject.ShowDialog();
            this.Show();
        }
        private void btnChangePW_Click(object sender, EventArgs e)
        {
            FormChangePW formChangePW = new FormChangePW(this.id_user, this.userServices);
            Hide();
            formChangePW.ShowDialog();
            Show();
        }
        private void btnLichSuThi_Click(object sender, EventArgs e)
        {
            FormResult formResult = new FormResult(this.id_user, this.role, this.resultServices);
            this.Hide();
            formResult.ShowDialog();
            this.Show();
        }
        private void btnQuanTri_Click(object sender, EventArgs e)
        {
            FormQuestion formQuestion = new FormQuestion(this.qeServices, this.subjectServices);
            this.Hide();
            formQuestion.ShowDialog();
            this.Show();
        }
        private void btnThi_Click(object sender, EventArgs e)
        {
            FormChooseExam fchooseExam = new FormChooseExam(this.qeServices, this.resultServices, this.id_user);
            this.Hide();
            fchooseExam.ShowDialog();
            this.Show();
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser(this.id_user, this.role, this.userServices);
            this.Hide();
            formUser.ShowDialog();
            this.Show();
        }
    }
}
