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
        ConnectData con = new ConnectData();
        public static AdminForm instanceAdminForm;
        public AdminForm()
        {
            InitializeComponent();
            instanceAdminForm = this;
        }
        void loaddata(DataGridView dataGridView, string tablename)
        {
            dataGridView.Columns.Clear();
            con.connect();
            DataSet dataset = new DataSet();
            String query = "select * from " + tablename + " order by id_userlogin";
            NpgsqlDataAdapter adp = new NpgsqlDataAdapter(query, con.connector);
            adp.Fill(dataset);
            dataGridView.DataSource = dataset.Tables[0];
            con.disconnect();
            DataGridViewButtonColumn buttoncolumnedit = new DataGridViewButtonColumn();
            buttoncolumnedit.HeaderText = "Edit Row";
            buttoncolumnedit.Width = 100;
            buttoncolumnedit.Text = "Edit";
            buttoncolumnedit.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Insert(dataGridView.ColumnCount, buttoncolumnedit);
            DataGridViewButtonColumn buttoncolumndelete = new DataGridViewButtonColumn();
            buttoncolumndelete.HeaderText = "Delete Row";
            buttoncolumndelete.Width = 100;
            buttoncolumndelete.Text = "Delete";
            buttoncolumndelete.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Insert(dataGridView.ColumnCount, buttoncolumndelete);
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            loaddata(dataGridView1, "userlogin");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Do you want to delete username: {0}?", row.Cells["username"].Value), "Yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.connect();
                    String query = "delete from userlogin where username = @username";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, con.connector);
                    cmd.Parameters.AddWithValue("@username", row.Cells["username"].Value);
                    cmd.ExecuteNonQuery();
                    con.disconnect();
                    loaddata(dataGridView1, "userlogin");
                }
            }
            else if (e.ColumnIndex == dataGridView1.ColumnCount - 2)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                AddUser addUserform = new AddUser(row);
                addUserform.ShowDialog();
                addUserform = null;
                loaddata(dataGridView1, "userlogin");
            }
        }
        private void butAddNewUser_Click(object sender, EventArgs e)
        {
            AddUser addUserform = new AddUser();
            addUserform.ShowDialog();
            addUserform = null;
            loaddata(dataGridView1, "userlogin");
        }
    }
}
