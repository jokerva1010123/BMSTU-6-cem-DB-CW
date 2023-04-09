using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDThi
{
    public partial class FormHome : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        String thisUsername, thisRole;
        int thisUserId;
        public FormHome(string username, int userId, string role)
        {
            InitializeComponent();
            thisUsername = username;
            thisRole = role;
            thisUserId = userId;
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Xin chào " + thisUsername;
            if (thisRole == "A")
            {
                btnThi.Visible = false;
                btnLichSuThi.Visible = true;
                btnQuanTri.Visible = true;
                btnUser.Visible = true;
                btnSubject.Visible = true;
            }
            else if(thisRole == "T")
            {
                btnThi.Visible = false;
                btnLichSuThi.Visible = true;
                btnQuanTri.Visible = true;
                btnSubject.Visible = true;
                btnUser.Text = "QUẢN LÝ HỌC SINH";
                btnUser.Visible = true;
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

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(thisUsername);
            Hide();
            formAdmin.ShowDialog();
            Show();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            FormChangePW formChangePW = new FormChangePW(thisUserId);
            Hide();
            formChangePW.ShowDialog();
            Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            FormChooseExam formChooseExam = new FormChooseExam(thisUserId, thisUsername, true);
            Hide();
            formChooseExam.ShowDialog();
            Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormUser formUser = new FormUser(thisUserId, thisRole);
            Hide();
            formUser.ShowDialog();
            Show();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            FormSubject formSubject = new FormSubject();
            Hide();
            formSubject.ShowDialog();
            Show();
            this.Refresh();
        }

        private void btnLichSuThi_Click(object sender, EventArgs e)
        {
            FormHistory formHistory = new FormHistory(thisUserId, thisRole);
            Hide();
            formHistory.ShowDialog();
            Show();
        }
    }
}
