using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QLDThi
{
    public partial class FormLogin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        int userId;
        string hashPassword, role;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Yêu cầu nhập đủ thông tin đăng nhập");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("LoginCheck", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter thisUsername = command.Parameters.Add("username", SqlDbType.VarChar);
                thisUsername.Value = txtUsername.Text;
                connection.Open();
                var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (dataReader.HasRows == false)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    connection.Close();
                }
                else
                {
                    while (dataReader.Read())
                    {
                        userId = dataReader.GetInt32(0);
                        hashPassword = dataReader.GetString(2);
                        role = dataReader.GetString(3);
                    }
                    bool verified = BC.Verify(txtPassword.Text, hashPassword);
                    if (verified == true)
                    {
                        FormHome formHome = new FormHome(txtUsername.Text, userId, role);
                        Hide();
                        formHome.ShowDialog();
                        Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                        connection.Close();
                    }
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignup formSignup = new FormSignup();
            Hide();
            formSignup.ShowDialog();
            Show();
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                if (txtUsername.Text == "" || txtPassword.Text == "")
                    MessageBox.Show("Yêu cầu nhập đủ thông tin đăng nhập");
                else
                {
                    var connection = new SqlConnection(connectionString);
                    SqlCommand command = new SqlCommand("LoginCheck", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter thisUsername = command.Parameters.Add("username", SqlDbType.VarChar);
                    thisUsername.Value = txtUsername.Text;
                    connection.Open();
                    var dataReader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            userId = dataReader.GetInt32(0);
                            hashPassword = dataReader.GetString(2);
                            role = dataReader.GetString(3);
                        }
                        bool verified = BC.Verify(txtPassword.Text, hashPassword);
                        if (verified == true)
                        {
                            FormHome formHome = new FormHome(txtUsername.Text, userId, role);
                            Hide();
                            formHome.ShowDialog();
                            Show();
                        }
                        else
                        {
                            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                            connection.Close();
                        }
                    }
                    else
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    connection.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
