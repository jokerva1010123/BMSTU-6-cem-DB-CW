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
            ConnectData con = new ConnectData();
            con.connect();
            var sql = "SELECT * from userlogin where username = '" + txtLogin.Text + "' and passwords = '" + txtPassword.Text + "'";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, con.connector);

            NpgsqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true) 
            {
                var type = (int)reader.GetValue(2);
                if (type == 0)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    adminForm = null;
                    this.Show();
                    this.txtLogin.Text = "";
                    this.txtPassword.Text = "";
                }
                else if(type == 1)
                {
                    MessageBox.Show("Ban la giao vien", "Info");
                }
                else
                {
                    MessageBox.Show("Ban la hoc sinh", "Info");
                }
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau", "Error");
            }
            con.disconnect();
        }
    }
}
