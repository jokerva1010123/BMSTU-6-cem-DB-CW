using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormUser : Form
    {
        #region private_variavle
        private int id_user;
        private string role;
        private UserServices userServices;
        #endregion
        #region Code_for_User_Form
        public FormUser(int id_user, string role, UserServices userServices)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.role = role;
            this.userServices = userServices;
            if (this.role == "T")
            {
                this.tabPage1.Hide();
                this.tabPage2.Hide();
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
            }
        }
        private void ShowAllAdmin(List<User> allUser)
        {
            this.dataGridViewAdmin.Rows.Clear();
            this.dataGridViewAdmin.Columns.Clear();
            this.dataGridViewAdmin.Columns.Add("id", "Id");
            this.dataGridViewAdmin.Columns.Add("usernameAdmin", "Логин");
            this.dataGridViewAdmin.Columns.Add("nameAdmin", "Ф. И. О.");
            foreach (User user in allUser)
                this.dataGridViewAdmin.Rows.Add(user.Id, user.Username, user.Name);
            this.dataGridViewAdmin.CurrentCell = null;
        }
        private void ShowAllTeacher(List<User> allUser)
        {
            this.dataGridViewTeacher.Rows.Clear();
            this.dataGridViewTeacher.Columns.Clear();
            this.dataGridViewTeacher.Columns.Add("idTeacher", "Id");
            this.dataGridViewTeacher.Columns.Add("usernameTeacher", "Логин");
            this.dataGridViewTeacher.Columns.Add("nameTeacher", "Ф. И. О.");
            foreach (User user in allUser)
                this.dataGridViewTeacher.Rows.Add(user.Id, user.Username, user.Name);
            this.dataGridViewTeacher.CurrentCell = null;
        }
        private void ShowAllStudent(List<User> allUser)
        {
            this.dataGridViewStudent.Rows.Clear();
            this.dataGridViewStudent.Columns.Clear();
            this.dataGridViewStudent.Columns.Add("idStudent", "Id");
            this.dataGridViewStudent.Columns.Add("usernameStudent", "Логин");
            this.dataGridViewStudent.Columns.Add("nameStudent", "Ф. И. О.");
            foreach (User user in allUser)
                this.dataGridViewStudent.Rows.Add(user.Id, user.Username, user.Name);
            this.dataGridViewStudent.CurrentCell = null;
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            List<User> allAdmin = userServices.getAllUser("A");
            List<User> allTeacher = userServices.getAllUser("T");
            List<User> allStudent = userServices.getAllUser("S");
            ShowAllAdmin(allAdmin);
            ShowAllTeacher(allTeacher);
            ShowAllStudent(allStudent);
        }
        #endregion
        #region Code_for_Admin_Tab
        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> allAdmin;
                if (txtAdminSearch.Text.Length == 0)
                    allAdmin = userServices.getAllUser("A");
                else
                    allAdmin = userServices.FindUser("A", txtAdminSearch.Text);
                ShowAllAdmin(allAdmin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string username = txtUsername.Text;
                if (name.Length == 0 || username.Length == 0)
                {
                    MessageBox.Show("Введите Ф. И. О. и логин!", "Error");
                    return;
                }
                userServices.addUser(name, username, "A");
                ShowAllAdmin(userServices.getAllUser("A"));
                txtName.Text = "";
                txtUsername.Text = "";
                MessageBox.Show("Успешно добавлен новый аккаунт.", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAdmin.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для измениния!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewAdmin.SelectedCells[0].RowIndex;
                if (dataGridViewAdmin.Rows[selectedRow].Cells["id"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для измениния!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewAdmin.Rows[selectedRow].Cells["id"].Value;
                string name = txtName.Text;
                string username = txtUsername.Text;
                int id_user = userServices.getIdFromUsername(username);
                if (id_user != -1 && id_user != id)
                {
                    MessageBox.Show("Логин уже существует!", "Ошибка");
                    return;
                }
                userServices.updateUser(id, name, username);
                MessageBox.Show("Успешно изменить информации аккаунта.", "Info");
                ShowAllAdmin(userServices.getAllUser("A"));
                txtName.Text = "";
                txtUsername.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAdmin.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для удаления!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewAdmin.SelectedCells[0].RowIndex;
                if (dataGridViewAdmin.Rows[selectedRow].Cells["id"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для удаления!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewAdmin.Rows[selectedRow].Cells["id"].Value;
                string username = (string)dataGridViewAdmin.Rows[selectedRow].Cells["usernameAdmin"].Value;
                if (id == this.id_user)
                {
                    MessageBox.Show("Нельзя себя удалить!", "Ошибка");
                    return;
                }
                if (MessageBox.Show("Удалить аккаунт: " + username + "?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userServices.deleteUser(id);
                    MessageBox.Show("Успешно удалить аккаунт.", "Info");
                    ShowAllAdmin(userServices.getAllUser("A"));
                    txtName.Text = "";
                    txtUsername.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void dataGridViewAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                if (dataGridViewAdmin.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewAdmin.CurrentRow.Selected = true;
                    txtName.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells["nameAdmin"].FormattedValue.ToString();
                    txtUsername.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells["usernameAdmin"].FormattedValue.ToString();
                }
        }
        private void dataGridViewAdmin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (dataGridViewAdmin.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dataGridViewAdmin.CurrentRow.Selected = true;
                    txtName.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells["nameAdmin"].FormattedValue.ToString();
                    txtUsername.Text = dataGridViewAdmin.Rows[e.RowIndex].Cells["usernameAdmin"].FormattedValue.ToString();
                }
        }
        #endregion
        #region Code_for_Teacher_Tab
        private void bntTeacherSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> allTeacher;
                if (txtTeacherSearch.Text.Length == 0)
                    allTeacher = userServices.getAllUser("T");
                else
                    allTeacher = userServices.FindUser("T", txtTeacherSearch.Text);
                ShowAllTeacher(allTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTeacherName.Text;
                string username = txtTeacherUsername.Text;
                if (name.Length == 0 || username.Length == 0)
                {
                    MessageBox.Show("Введите Ф. И. О. и логин!", "Error");
                    return;
                }
                userServices.addUser(name, username, "T");
                ShowAllTeacher(userServices.getAllUser("T"));
                MessageBox.Show("Успешно добавлен новый аккаунт.", "Info");
                txtTeacherName.Text = "";
                txtTeacherUsername.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntEditTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeacher.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для измениния!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewTeacher.SelectedCells[0].RowIndex;
                if (dataGridViewTeacher.Rows[selectedRow].Cells["idTeacher"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для измениния!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewTeacher.Rows[selectedRow].Cells["idTeacher"].Value;
                string name = txtTeacherName.Text;
                string username = txtTeacherUsername.Text;
                if (name.Length < 1 || username.Length < 1)
                {
                    MessageBox.Show("Введите Ф. И. О. и логин!", "Error");
                    return;
                }
                int id_user = userServices.getIdFromUsername(username);
                if (id_user != -1 && id_user != id)
                {
                    MessageBox.Show("Логин уже существует!", "Ошибка");
                    return;
                }
                userServices.updateUser(id, name, username);
                MessageBox.Show("Успешно изменить информации аккаунта.", "Info");
                ShowAllTeacher(userServices.getAllUser("T"));
                txtTeacherName.Text = "";
                txtTeacherUsername.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntDeleteTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeacher.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для удаления!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewTeacher.SelectedCells[0].RowIndex;
                if (dataGridViewTeacher.Rows[selectedRow].Cells["idTeacher"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для удаления!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewTeacher.Rows[selectedRow].Cells["idTeacher"].Value;
                string username = (string)dataGridViewTeacher.Rows[selectedRow].Cells["usernameTeacher"].Value;
                if (MessageBox.Show("Удалить аккаунт: " + username + "?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userServices.deleteUser(id);
                    MessageBox.Show("Успешно удалить аккаунт.", "Info");
                    ShowAllTeacher(userServices.getAllUser("T"));
                    txtTeacherName.Text = "";
                    txtTeacherUsername.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntTeacherReserPW_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTeacher.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для сброса пароля!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewTeacher.SelectedCells[0].RowIndex;
                if (dataGridViewTeacher.Rows[selectedRow].Cells["idTeacher"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для сброса пароля!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewTeacher.Rows[selectedRow].Cells["idTeacher"].Value;
                userServices.changePW(id);
                MessageBox.Show("Успешно сбросить пароль!", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                if (dataGridViewTeacher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewTeacher.CurrentRow.Selected = true;
                    txtTeacherName.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["nameTeacher"].FormattedValue.ToString();
                    txtTeacherUsername.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["usernameTeacher"].FormattedValue.ToString();
                }
        }
        private void dataGridViewTeacher_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (dataGridViewTeacher.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dataGridViewTeacher.CurrentRow.Selected = true;
                    txtTeacherName.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["nameTeacher"].FormattedValue.ToString();
                    txtTeacherUsername.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["usernameTeacher"].FormattedValue.ToString();
                }
        }
        #endregion
        #region Code_for_Student_Tab
        private void bntStudentSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<User> allStudent;
                if (txtStudentSearch.Text.Length == 0)
                    allStudent = userServices.getAllUser("S");
                else
                    allStudent = userServices.FindUser("S", txtStudentSearch.Text);
                ShowAllStudent(allStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtStudentName.Text;
                string username = txtStudentUsername.Text;
                if (name.Length < 1 || username.Length < 1)
                {
                    MessageBox.Show("Введите Ф. И. О. и логин!", "Error");
                    return;
                }
                userServices.addUser(name, username, "S");
                ShowAllStudent(userServices.getAllUser("S"));
                txtStudentName.Text = "";
                txtStudentUsername.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntChangeStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStudent.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для измениния!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewStudent.SelectedCells[0].RowIndex;
                if (dataGridViewStudent.Rows[selectedRow].Cells["idStudent"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для измениния!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewStudent.Rows[selectedRow].Cells["idStudent"].Value;
                string name = txtStudentName.Text;
                string username = txtStudentUsername.Text;
                if (name.Length < 1 || username.Length < 1)
                {
                    MessageBox.Show("Введите Ф. И. О. и логин!", "Error");
                    return;
                }
                int id_user = userServices.getIdFromUsername(username);
                if (id_user != -1 && id_user != id)
                {
                    MessageBox.Show("Логин уже существует!", "Ошибка");
                    return;
                }
                userServices.updateUser(id, name, username);
                MessageBox.Show("Успешно изменить информации аккаунта.", "Info");
                ShowAllStudent(userServices.getAllUser("S"));
                txtStudentName.Text = "";
                txtStudentUsername.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStudent.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для удаления!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewStudent.SelectedCells[0].RowIndex;
                if (dataGridViewStudent.Rows[selectedRow].Cells["idStudent"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для удаления!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewStudent.Rows[selectedRow].Cells["idStudent"].Value;
                string username = (string)dataGridViewStudent.Rows[selectedRow].Cells["usernameStudent"].Value;
                if (MessageBox.Show("Удалить аккаунт: " + username + "?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userServices.deleteUser(id);
                    MessageBox.Show("Успешно удалить аккаунт.", "Info");
                    ShowAllStudent(userServices.getAllUser("S"));
                    txtStudentName.Text = "";
                    txtStudentUsername.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntStudentResetPW_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStudent.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 аккаунт для сброса пароля!", "Ошибка");
                    return;
                }
                int selectedRow = dataGridViewStudent.SelectedCells[0].RowIndex;
                if (dataGridViewStudent.Rows[selectedRow].Cells["idStudent"].Value == null)
                {
                    MessageBox.Show("Выберите 1 аккаунт для сброса пароля!", "Ошибка");
                    return;
                }
                int id = (int)dataGridViewStudent.Rows[selectedRow].Cells["idStudent"].Value;
                userServices.changePW(id);
                MessageBox.Show("Успешно сбросить пароль!", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.RowIndex < dataGridViewStudent.Rows.Count)
                if (dataGridViewStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewStudent.CurrentRow.Selected = true;
                    txtStudentName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["nameStudent"].FormattedValue.ToString();
                    txtStudentUsername.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["usernameStudent"].FormattedValue.ToString();
                }
        }
        private void dataGridViewStudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (dataGridViewStudent.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dataGridViewStudent.CurrentRow.Selected = true;
                    txtStudentName.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["nameStudent"].FormattedValue.ToString();
                    txtStudentUsername.Text = dataGridViewStudent.Rows[e.RowIndex].Cells["usernameStudent"].FormattedValue.ToString();
                }
        }
        #endregion
    }
}
