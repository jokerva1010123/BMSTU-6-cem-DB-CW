using DB_CW.DAO;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = txtLogin.Text;
            string password = txtPassword.Text;
            int login = AccountDAO.Instance.Login(userName, password);            
            if (login > 0)
            {
                if (login == 1)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    adminForm = null;
                    this.Show();
                    this.txtLogin.Text = "";
                    this.txtPassword.Text = "";
                }
                else if (login == 2)
                {
                    this.Hide();
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.ShowDialog();
                    teacherForm = null;
                    this.Show();
                    this.txtLogin.Text = "";
                    this.txtPassword.Text = "";
                }
                else
                {
                    this.Hide();
                    StudentForm studentForm = new StudentForm();
                    studentForm.ShowDialog();
                    studentForm = null;
                    this.Show();
                    this.txtLogin.Text = "";
                    this.txtPassword.Text = "";
                }
            }
            else
            { 
                MessageBox.Show("Sai tai khoan hoac mat khau", "Error");
                return;
            }
        }
    }
}
