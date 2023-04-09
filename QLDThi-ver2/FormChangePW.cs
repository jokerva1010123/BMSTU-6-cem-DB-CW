using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QLDThi
{
    public partial class FormChangePW : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        string  errorMsg;
        int UserId;

        public FormChangePW(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == ""|| txtNewPassword.Text == "" || txtNewPasswordConfirm.Text == "")
                MessageBox.Show("Yêu cầu nhập đủ thông tin.");
            else if (txtNewPasswordConfirm.Text != txtNewPassword.Text)
                MessageBox.Show("Hai mật khẩu không trùng khớp");
            else if (ValidatePassword(txtNewPassword.Text, out errorMsg) == false)
            {
                MessageBox.Show(errorMsg);
            }
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand ChangePW = new SqlCommand("ChangePW", connection);
                ChangePW.CommandType = CommandType.StoredProcedure;
                SqlParameter thisId = ChangePW.Parameters.Add("@id", SqlDbType.VarChar);
                thisId.Value = UserId;
                SqlParameter thisPassword = ChangePW.Parameters.Add("@password", SqlDbType.VarChar);
                thisPassword.Value = BC.HashPassword(txtNewPassword.Text.Trim());
                connection.Open();
                ChangePW.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Đổi mật khẩu thành công!");
                Close();
            }
        }

        private bool ValidatePassword(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự thường";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự hoa";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa tối thiểu 8 ký tự";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ký tự số";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Mật khẩu phải chứa ít nhất một ký tự đặc biệt";
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
