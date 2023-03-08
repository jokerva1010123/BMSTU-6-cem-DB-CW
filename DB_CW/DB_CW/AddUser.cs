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
    public partial class AddUser : Form
    {
        ConnectData con = new ConnectData();
        int id_userlogin;
        public AddUser(DataGridViewRow row = null)
        {
            InitializeComponent();
            if (row != null)
            {
                this.Text = "Edit User";
                this.ButtonAddUser.Text = "Edit User";
                this.AddUsername.Text = (string)row.Cells["username"].Value;
                this.AddPassword.Text = (string)row.Cells["passwords"].Value;
                this.AddNameUser.Text = (string)row.Cells["nameuser"].Value;
                this.AddEmail.Text = (string)row.Cells["emailuser"].Value;
                this.AddPhone.Text = (string)row.Cells["phoneuser"].Value;
                this.TypeRole.SelectedIndex = (int)row.Cells["id_role"].Value - 1;
                this.id_userlogin = (int)row.Cells["id_userlogin"].Value;
            }
        }

        private void AddUserForm_Click(object sender, EventArgs e)
        {
            con.connect();
            if (AddNameUser.Text == "" || AddPassword.Text == "" || AddUsername.Text == "" || AddPhone.Text == "" || AddEmail.Text == "" || TypeRole.SelectedIndex == -1)
            {

                MessageBox.Show("Hay dien day du", "Error");
            }
            else
            {
                String query;
                if (this.Text == "Add User")
                    query = "insert into userlogin(username, passwords, id_role, nameUser, phoneUser, emailUser) values (@username, @passwords, @id_role, @name, @phone, @email)";
                else
                    query = "update userlogin set username = @username, passwords = @passwords, nameUser = @name, phoneUser = @phone, emailUser = @email, id_role = @id_role where id_userlogin = " + id_userlogin.ToString();
                Console.WriteLine(query);
                NpgsqlCommand cmd = new NpgsqlCommand(query, con.connector);
                cmd.Parameters.AddWithValue("@username", AddUsername.Text);
                cmd.Parameters.AddWithValue("@passwords", AddPassword.Text);
                cmd.Parameters.AddWithValue("@name", AddNameUser.Text);
                cmd.Parameters.AddWithValue("@phone", AddPhone.Text);
                cmd.Parameters.AddWithValue("@email", AddEmail.Text);
                cmd.Parameters.AddWithValue("@id_role", TypeRole.SelectedIndex + 1);
                try
                {
                    cmd.ExecuteNonQuery();
                    con.disconnect();
                    this.Close();
                    return;
                }
                catch(Exception) 
                {
                    MessageBox.Show("Username da dc su dung", "Error");
                }
                con.disconnect();
            }
        }

        private void CancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
