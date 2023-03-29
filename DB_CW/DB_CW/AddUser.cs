using DB_CW.DAO;
using DB_CW.DTO;
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
        int id_userlogin = 0;
        public AddUser(DataGridViewRow row = null)
        {
            InitializeComponent();
            if (row != null)
            {
                this.id_userlogin = (int)row.Cells["id_userlogin"].Value;
                this.Text = "Edit User";
                this.ButtonAddUser.Text = "Edit User";
                this.AddUsername.Text = (string)row.Cells["username"].Value;
                this.AddPassword.Text = (string)row.Cells["passwords"].Value;
                this.AddNameUser.Text = (string)row.Cells["nameuser"].Value;
                this.AddEmail.Text = (string)row.Cells["emailuser"].Value;
                this.AddPhone.Text = (string)row.Cells["phoneuser"].Value;
                this.TypeRole.SelectedIndex = (int)row.Cells["id_role"].Value - 1;     
            }
        }
        private void AddUserForm_Click(object sender, EventArgs e)
        {
            if (AddNameUser.Text == "" || AddPassword.Text == "" || AddUsername.Text == "" || AddPhone.Text == "" || AddEmail.Text == "" || TypeRole.SelectedIndex == -1)
            {
                MessageBox.Show("Hay dien day du", "Error");
            }
            else
            {
                UserDTO userDTO = new UserDTO(id_userlogin, AddUsername.Text, AddPassword.Text, TypeRole.SelectedIndex + 1, AddNameUser.Text, AddPhone.Text, AddEmail.Text);
                int res;
                if (this.Text == "Add User")
                    res = userDTO.addUsers(userDTO);
                else
                    res = userDTO.updateUser(userDTO);
                if (res < 0)
                    MessageBox.Show("Username da dc su dung", "Error");
                else
                    this.Close();
            }
        }
        private void CancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
