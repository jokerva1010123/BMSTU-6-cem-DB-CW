using BL;
using System;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormLogin : Form
    {
        private int id_user;
        private string role;
        private UserServices userServices;
        private ResultServices resultServices;
        private SubjectServices subjectServices;
        private QEServices qeServices;
        public FormLogin(UserServices userServices, ResultServices resultServices, SubjectServices subjectServices, QEServices qeServices)
        {
            InitializeComponent();
            this.userServices = userServices;
            this.id_user = -1;
            this.role = "";
            this.resultServices = resultServices;
            this.subjectServices = subjectServices;
            this.qeServices = qeServices;
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!", "Info");
                return;
            }
            try
            {
                this.id_user = userServices.login(txtLogin.Text, txtPassword.Text);
                this.role = userServices.getRoleFromId(this.id_user);
                FormHome formHome = new FormHome(txtLogin.Text, id_user, role, this.userServices, this.resultServices, this.subjectServices, this.qeServices);
                this.Hide();
                formHome.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info");
            }
        }
    }
}
