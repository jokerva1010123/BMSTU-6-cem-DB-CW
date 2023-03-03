using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class AddTeacher : Form
    {
        ConnectData con = new ConnectData();
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacherFromForm_Click(object sender, EventArgs e)
        {
            con.connect();
            if (AddNameTeacher.Text == "" || AddPasswordTeacher.Text == "" || AddUsernameTeacher.Text == "")
            {
                MessageBox.Show("Hay nhap day du", "Error");
            }
            else
            { 
                String query1 = "insert into userlogin values (@username, @passwords, 1)";
                String query2 = "insert into teacher values (@ID, @nameTeacher, @username, @passwords)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(query1, con.connector);
                NpgsqlCommand cmd2 = new NpgsqlCommand(query2, con.connector);
                cmd1.Parameters.AddWithValue("@username", AddUsernameTeacher.Text);
                cmd1.Parameters.AddWithValue("@passwords", AddPasswordTeacher.Text);
                cmd2.Parameters.AddWithValue("@ID", 1);
                cmd2.Parameters.AddWithValue("@nameTeacher", AddNameTeacher.Text);
                cmd2.Parameters.AddWithValue("@username", AddUsernameTeacher.Text);
                cmd2.Parameters.AddWithValue("@passwords", AddPasswordTeacher.Text);
                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    con.disconnect();
                    this.Close();
                }
                catch(Exception) 
                {
                    MessageBox.Show("Username da dc su dung", "Error");
                }
            }
        }

        private void CancelAddTeacher_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
