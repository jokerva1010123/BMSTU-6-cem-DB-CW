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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLDThi
{
    public partial class FormSubject : Form
    {
        int idSub;
        string nameSub;
        public FormSubject()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        public void GetListSubject()
        {
            var connection = new SqlConnection(connectionString);
            SqlCommand command1 = new SqlCommand("getListSubject", connection);
            command1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapterAdmin = new SqlDataAdapter(command1);
            DataTable dataTableAdmin = new DataTable();
            dataAdapterAdmin.Fill(dataTableAdmin);
            grdSubject.DataSource = dataTableAdmin;
        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            GetListSubject();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSubject.Text))
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
            else
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("createSubject", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter thisName = command.Parameters.Add("@name", SqlDbType.VarChar);
                thisName.Value = txtSubject.Text;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thêm mới thành công");
                GetListSubject();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubject.Text))
                MessageBox.Show("Yêu cầu nhập đủ thông tin");
            else
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("editSubject", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter thisName = command.Parameters.Add("@name", SqlDbType.VarChar);
                thisName.Value = txtSubject.Text;
                SqlParameter thisId = command.Parameters.Add("@id", SqlDbType.Int);
                thisId.Value = idSub;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cập nhật thành công");
                GetListSubject();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa? Dữ liệu sẽ không thể khôi phục.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand("deleteSubject", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter thisDeleteId = command.Parameters.Add("id", SqlDbType.Int);
                thisDeleteId.Value = idSub;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetListSubject();
            }
        }

        private void grdSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string checknull = grdSubject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (!string.IsNullOrEmpty(checknull) && !string.IsNullOrWhiteSpace(checknull))
                {
                    grdSubject.CurrentRow.Selected = true;
                    idSub = Convert.ToInt32(grdSubject.Rows[e.RowIndex].Cells[0].FormattedValue);
                    nameSub = grdSubject.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtSubject.Text = nameSub;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                MessageBox.Show("Yêu cầu nhập từ khóa dể tìm kiếm");
            else
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("searchSubject", connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter thisKeyWord = command.Parameters.Add("@keyword", SqlDbType.VarChar);
                thisKeyWord.Value = txtSearch.Text;
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                grdSubject.DataSource = dataTable;
            }
        }
    }
}
