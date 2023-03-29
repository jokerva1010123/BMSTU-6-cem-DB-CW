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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        void loaddataUser(string order = "id_userlogin")
        {
            UserDTO userDTO = new UserDTO();
            dtgvUser.Columns.Clear();
            dtgvUser.DataSource = userDTO.getAllUser(order);
            DataGridViewButtonColumn buttoncolumnedit = new DataGridViewButtonColumn();
            buttoncolumnedit.HeaderText = "Edit Row";
            buttoncolumnedit.Width = 100;
            buttoncolumnedit.Text = "Edit";
            buttoncolumnedit.UseColumnTextForButtonValue = true;
            dtgvUser.Columns.Insert(dtgvUser.ColumnCount, buttoncolumnedit);
            DataGridViewButtonColumn buttoncolumndelete = new DataGridViewButtonColumn();
            buttoncolumndelete.HeaderText = "Delete Row";
            buttoncolumndelete.Width = 100;
            buttoncolumndelete.Text = "Delete";
            buttoncolumndelete.UseColumnTextForButtonValue = true;
            dtgvUser.Columns.Insert(dtgvUser.ColumnCount, buttoncolumndelete);
        }
        void loaddataSubject()
        {
            SubjectDTO subjectDTO = new SubjectDTO();
            dtgvSubject.Columns.Clear();
            dtgvSubject.DataSource = subjectDTO.getAllSubject();
            DataGridViewButtonColumn buttoncolumnedit = new DataGridViewButtonColumn();
            buttoncolumnedit.HeaderText = "Edit Subject";
            buttoncolumnedit.Width = 100;
            buttoncolumnedit.Text = "Edit";
            buttoncolumnedit.UseColumnTextForButtonValue = true;
            dtgvSubject.Columns.Insert(dtgvSubject.ColumnCount, buttoncolumnedit);
            DataGridViewButtonColumn buttoncolumndelete = new DataGridViewButtonColumn();
            buttoncolumndelete.HeaderText = "Delete Subject";
            buttoncolumndelete.Width = 100;
            buttoncolumndelete.Text = "Delete";
            buttoncolumndelete.UseColumnTextForButtonValue = true;
            dtgvSubject.Columns.Insert(dtgvSubject.ColumnCount, buttoncolumndelete);
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            loaddataUser();
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            loaddataSubject();
        }
        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvUser.ColumnCount - 1)
            {
                DataGridViewRow row = dtgvUser.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete username: {0}?", row.Cells["username"].Value), "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    UserDTO userDTO = new UserDTO(row);
                    userDTO.deleteUser(userDTO);
                    loaddataUser();
                }
            }
            else if (e.ColumnIndex == dtgvUser.ColumnCount - 2)
            {
                DataGridViewRow row = dtgvUser.Rows[e.RowIndex];
                AddUser addUserform = new AddUser(row);
                addUserform.ShowDialog();
                addUserform = null;
                loaddataUser();
            }
        }
        private void butAddNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUserform = new AddUser();
            addUserform.ShowDialog();
            addUserform = null;
            loaddataUser();
        }
        private void buttonSearchUser_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || comboBoxSearch.SelectedIndex == -1)
            {
                MessageBox.Show("Hay nhap day du", "Error");
                return;
            }
            string value = txtSearch.Text;
            UserDTO userDTO = new UserDTO();
            if (comboBoxSearch.SelectedIndex == 0)
            {
                dtgvUser.Columns.Clear();
                dtgvUser.DataSource = userDTO.searchByNameuser(value);
                DataGridViewButtonColumn buttoncolumnedit = new DataGridViewButtonColumn();
                buttoncolumnedit.HeaderText = "Edit Row";
                buttoncolumnedit.Width = 100;
                buttoncolumnedit.Text = "Edit";
                buttoncolumnedit.UseColumnTextForButtonValue = true;
                dtgvUser.Columns.Insert(dtgvUser.ColumnCount, buttoncolumnedit);
                DataGridViewButtonColumn buttoncolumndelete = new DataGridViewButtonColumn();
                buttoncolumndelete.HeaderText = "Delete Row";
                buttoncolumndelete.Width = 100;
                buttoncolumndelete.Text = "Delete";
                buttoncolumndelete.UseColumnTextForButtonValue = true;
                dtgvUser.Columns.Insert(dtgvUser.ColumnCount, buttoncolumndelete);
            }
            else
            {
                dtgvUser.Columns.Clear();
                dtgvUser.DataSource = userDTO.searchByUsername(value);
                DataGridViewButtonColumn buttoncolumnedit = new DataGridViewButtonColumn();
                buttoncolumnedit.HeaderText = "Edit Row";
                buttoncolumnedit.Width = 100;
                buttoncolumnedit.Text = "Edit";
                buttoncolumnedit.UseColumnTextForButtonValue = true;
                dtgvUser.Columns.Insert(dtgvUser.ColumnCount, buttoncolumnedit);
                DataGridViewButtonColumn buttoncolumndelete = new DataGridViewButtonColumn();
                buttoncolumndelete.HeaderText = "Delete Row";
                buttoncolumndelete.Width = 100;
                buttoncolumndelete.Text = "Delete";
                buttoncolumndelete.UseColumnTextForButtonValue = true;
                dtgvUser.Columns.Insert(dtgvUser.ColumnCount, buttoncolumndelete);
            }
        }
        private void buttonCancelSearch_Click(object sender, EventArgs e)
        {
            loaddataUser();
        }
        private void dtgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            DataGridViewRow row = dtgvSubject.Rows[e.RowIndex];
            if (dtgvSubject.Columns[e.ColumnIndex].HeaderText == "Delete Subject")
            {
                if (MessageBox.Show(string.Format("Do you want to delete namesubject: {0}?", row.Cells["namesubject"].Value), "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SubjectDTO subjectDTO = new SubjectDTO(row);
                    subjectDTO.deleteSubject(subjectDTO);
                    loaddataSubject();
                }
            }
        }
        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            if (buttonAddSubject.Text == "Edit")
            {
                string oldsubject = txtSubject.Text;
                string query = "update subject set namesubject = @namesubject where namesubject = @oldsubject ";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { txtSubject.Text, oldsubject });
                buttonAddSubject.Text = "Add";
                loaddataSubject();
            }
            else
            {
                string query = "insert into subject(namesubject) values ( @namesubject )";
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { txtSubject.Text });
                loaddataSubject();
            }
        }
        private void buttonSearchSubject_Click(object sender, EventArgs e)
        {
            if (txtSearchSubject.Text == "")
            {
                MessageBox.Show("Hay dien day du", "Error");
                return;
            }
            string query = "select * from subject where namesubject = @namesubject";
            dtgvSubject.Columns.Clear();
            dtgvSubject.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {txtSearchSubject.Text});
            DataGridViewButtonColumn buttoncolumnedit = new DataGridViewButtonColumn();
            buttoncolumnedit.HeaderText = "Edit Subject";
            buttoncolumnedit.Width = 100;
            buttoncolumnedit.Text = "Edit";
            buttoncolumnedit.UseColumnTextForButtonValue = true;
            dtgvSubject.Columns.Insert(dtgvSubject.ColumnCount, buttoncolumnedit);
            DataGridViewButtonColumn buttoncolumndelete = new DataGridViewButtonColumn();
            buttoncolumndelete.HeaderText = "Delete Subject";
            buttoncolumndelete.Width = 100;
            buttoncolumndelete.Text = "Delete";
            buttoncolumndelete.UseColumnTextForButtonValue = true;
            dtgvSubject.Columns.Insert(dtgvSubject.ColumnCount, buttoncolumndelete);
        }
        private void buttonCancelSearchSubject_Click(object sender, EventArgs e)
        {
            loaddataSubject();
        }
    }
}
