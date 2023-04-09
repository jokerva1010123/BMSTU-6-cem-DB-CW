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
    public partial class FormUser : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        String defaultPassword = "Abcd@123";
        string Name, Username, Role, Keyword;
        int UserId, thisUserId;

        public FormUser(int userId, string role)
        {
            InitializeComponent();
            UserId = userId;
            Role = role;
            if (Role == "T")
            {
                this.tabPage1.Hide();
                this.tabPage2.Hide();
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser("A");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserId == thisUserId)
            {
                MessageBox.Show("Không thể xóa chính mình");
            }
            else
            {
                DeleteUser();
                GetListAdmin();
                GetListTeacher();
                GetListStudent();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }
        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            SearchUser("A");
        }

        public void GetListAdmin()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("GetListUser", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlParameter thisRole = command1.Parameters.Add("@role", SqlDbType.VarChar);
            thisRole.Value = "A";
            SqlDataAdapter dataAdapterAdmin = new SqlDataAdapter(command1);
            DataTable dataTableAdmin = new DataTable();
            dataAdapterAdmin.Fill(dataTableAdmin);
            dataGridViewAdmin.DataSource = dataTableAdmin;
            txtName.Text = "";
            txtUsername.Text = "";
        }
        public void GetListTeacher()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("GetListUser", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlParameter thisRole = command1.Parameters.Add("@role", SqlDbType.VarChar);
            thisRole.Value = "T";
            SqlDataAdapter dataAdapterTeacher = new SqlDataAdapter(command1);
            DataTable dataTableTeacher = new DataTable();
            dataAdapterTeacher.Fill(dataTableTeacher);
            dataGridViewTeacher.DataSource = dataTableTeacher;
            txtTeacherName.Text = "";
            txtTeacherUsername.Text = "";
        }
        public void GetListStudent()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("GetListUser", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlParameter thisRole = command1.Parameters.Add("@role", SqlDbType.VarChar);
            thisRole.Value = "S";
            SqlDataAdapter dataAdapterStudent = new SqlDataAdapter(command1);
            DataTable dataTableStudent = new DataTable();
            dataAdapterStudent.Fill(dataTableStudent);
            dataGridViewStudent.DataSource = dataTableStudent;
            txtStudentName.Text = "";
            txtStudentUsername.Text = "";
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            GetListAdmin();
            GetListTeacher();
            GetListStudent();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddUser("T");
        }

        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dataGridViewAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewAdmin.CurrentRow.Selected = true;
                    thisUserId = Convert.ToInt32(dataGridViewAdmin.Rows[e.RowIndex].Cells[1].FormattedValue);
                    Username = dataGridViewAdmin.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    Name = dataGridViewAdmin.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtName.Text = Name;
                    txtUsername.Text = Username;
                }
            }
        }

        private void AddUser(string role)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Name))
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand checkExistUser = new SqlCommand("CheckExistUser", connection);
                checkExistUser.CommandType = CommandType.StoredProcedure;
                SqlParameter checkUsername = checkExistUser.Parameters.Add("@username", SqlDbType.VarChar);
                checkUsername.Value = Username;
                connection.Open();
                var dataReader = checkExistUser.ExecuteReader(CommandBehavior.CloseConnection);
                if (dataReader.HasRows)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                }
                else
                {
                    SqlCommand command = new SqlCommand("CreateUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter thisUsername = command.Parameters.Add("@username", SqlDbType.VarChar);
                    thisUsername.Value = Username;
                    SqlParameter thisName = command.Parameters.Add("@name", SqlDbType.VarChar);
                    thisName.Value = Name;
                    SqlParameter thisRole = command.Parameters.Add("@role", SqlDbType.VarChar);
                    thisRole.Value = role;
                    SqlParameter thisPassword = command.Parameters.Add("@password", SqlDbType.VarChar);
                    thisPassword.Value = BC.HashPassword(defaultPassword);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm mới thành công");
                    GetListAdmin();
                    GetListTeacher();
                    GetListStudent();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text)) Name = txtName.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text)) Username = txtUsername.Text;
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentName.Text)) Name = txtStudentName.Text;
        }

        private void txtStudentUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentUsername.Text)) Username = txtStudentUsername.Text;
        }

        private void txtTeacherUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTeacherUsername.Text)) Username = txtTeacherUsername.Text;
        }

        private void txtTeacherName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTeacherName.Text)) Name = txtTeacherName.Text;
        }

        private void txtAdminSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdminSearch.Text)) Keyword = txtAdminSearch.Text;
        }

        private void txtTeacherSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTeacherSearch.Text)) Keyword = txtTeacherSearch.Text;
        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStudentSearch.Text)) Keyword = txtStudentSearch.Text;
        }

        private void EditUser()
        {
            if (string.IsNullOrEmpty(Name)|| string.IsNullOrEmpty(Username))
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand checkExistUser = new SqlCommand("CheckExistUser", connection);
                checkExistUser.CommandType = CommandType.StoredProcedure;
                SqlParameter checkUsername = checkExistUser.Parameters.Add("@username", SqlDbType.VarChar);
                checkUsername.Value = Username;
                connection.Open();
                var dataReader = checkExistUser.ExecuteReader(CommandBehavior.CloseConnection);
                if (dataReader.HasRows)
                {
                    MessageBox.Show("Tên đăng nhập này đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                }
                else
                {
                    SqlCommand command = new SqlCommand("EditUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter thisUsername = command.Parameters.Add("@username", SqlDbType.VarChar);
                    thisUsername.Value = Username;
                    SqlParameter thisName = command.Parameters.Add("@name", SqlDbType.VarChar);
                    thisName.Value = Name;
                    SqlParameter thisEditId = command.Parameters.Add("@id", SqlDbType.Int);
                    thisEditId.Value = thisUserId;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cập nhật thành công");
                    GetListAdmin();
                    GetListTeacher();
                    GetListStudent();
                }
            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void BtnDeleteTeacher_Click(object sender, EventArgs e)
        {
            DeleteUser();
            GetListTeacher();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DeleteUser();
            GetListStudent();
        }

        private void btnTeacherResetPW_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddUser("S");
        }

        private void btnStudentResetPW_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }

        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dataGridViewTeacher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewTeacher.CurrentRow.Selected = true;

                    thisUserId = Convert.ToInt32(dataGridViewTeacher.Rows[e.RowIndex].Cells[1].FormattedValue);
                    Name = dataGridViewTeacher.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    Username = dataGridViewTeacher.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtTeacherName.Text = Name;
                    txtTeacherUsername.Text = Username;
                }
            }
        }

        private void btnTeacherSearch_Click(object sender, EventArgs e)
        {
            SearchUser("T");
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            SearchUser("S");
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dataGridViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewStudent.CurrentRow.Selected = true;

                    thisUserId = Convert.ToInt32(dataGridViewStudent.Rows[e.RowIndex].Cells[1].FormattedValue);
                    Name = dataGridViewStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    Username = dataGridViewStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtStudentName.Text = Name;
                    txtStudentUsername.Text = Username;
                }
            }
        }

        private void DeleteUser()
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa? Dữ liệu sẽ không thể khôi phục.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand("DeleteUser", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter thisDeleteId = command.Parameters.Add("id", SqlDbType.Int);
                thisDeleteId.Value = thisUserId;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetPassword()
        {
            if (Name == "" || Username == "")
                MessageBox.Show("Yêu cầu chọn tài khoản cần reset mật khẩu");
            else
            {

                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand("ResetPW", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter thisDeleteId = command.Parameters.Add("id", SqlDbType.Int);
                thisDeleteId.Value = thisUserId;
                SqlParameter thisPassword = command.Parameters.Add("@password", SqlDbType.VarChar);
                thisPassword.Value = BC.HashPassword(defaultPassword);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Reset mật khẩu thành công! Mật khẩu mới là Abcd@123", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchUser(string role)
        {
            if (string.IsNullOrEmpty(Keyword))
                MessageBox.Show("Yêu cầu nhập từ khóa dể tìm kiếm");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("SearchUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter thisKeyWord = command.Parameters.Add("@keyword", SqlDbType.VarChar);
                thisKeyWord.Value = Keyword;
                SqlParameter thisRole = command.Parameters.Add("@role", SqlDbType.VarChar);
                thisRole.Value = role;
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                if (role == "A") dataGridViewAdmin.DataSource = dataTable;
                else if (role == "T") dataGridViewTeacher.DataSource = dataTable;
                else dataGridViewStudent.DataSource = dataTable;
            }
        }
    }
}
