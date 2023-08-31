using BL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormSubject : Form
    {
        private SubjectServices subjectServices;
        public FormSubject(SubjectServices subjectServices)
        {
            InitializeComponent();
            this.subjectServices = subjectServices;
        }
        private void ShowAllSubject(List<Subject> allSubject)
        {
            grdSubject.Rows.Clear();
            grdSubject.Columns.Clear();
            grdSubject.Columns.Add("id", "Id");
            grdSubject.Columns.Add("name", "Предмет");
            foreach (Subject subject in allSubject)
                grdSubject.Rows.Add(subject.Id_subject, subject.NameSubject);
            this.grdSubject.CurrentCell = null;
        }
        private void FormSubject_Load(object sender, System.EventArgs e)
        {
            List<Subject> allSubject = subjectServices.getAllSubject();
            ShowAllSubject(allSubject);
        }
        private void bntSearch_Click(object sender, System.EventArgs e)
        {
            if (txtSearch.Text.Length < 1)
                ShowAllSubject(subjectServices.getAllSubject());
            else
                ShowAllSubject(subjectServices.findSubject(txtSearch.Text));
        }
        private void bntAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                if (name.Length > 0)
                {
                    subjectServices.addSubject(name);
                    ShowAllSubject(subjectServices.getAllSubject());
                    MessageBox.Show("Успешно добавлен новый предмет!", "Info");
                    txtName.Text = "";
                }
                else
                    MessageBox.Show("Введите предмет!", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntEdit_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (grdSubject.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 предмет для измениния!", "Ошибка");
                    return;
                }
                int selectedRow = grdSubject.SelectedCells[0].RowIndex;
                if (grdSubject.Rows[selectedRow].Cells["id"].Value == null)
                {
                    MessageBox.Show("Выберите 1 предмет для измениния!", "Ошибка");
                    return;
                }
                int id = (int)grdSubject.Rows[selectedRow].Cells["id"].Value;
                string name = txtName.Text;
                if (name.Length == 0)
                {
                    MessageBox.Show("Введите предмет!", "Error");
                    return;
                }
                subjectServices.updateSubject(id, name);
                MessageBox.Show("Успешно изменить информации предмета.", "Info");
                ShowAllSubject(subjectServices.getAllSubject());
                txtName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void bntDelete_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (grdSubject.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Выберите 1 предмет для удаления!", "Ошибка");
                    return;
                }
                int selectedRow = grdSubject.SelectedCells[0].RowIndex;
                if (grdSubject.Rows[selectedRow].Cells["id"].Value == null)
                {
                    MessageBox.Show("Выберите 1 предмет для удаления!", "Ошибка");
                    return;
                }
                int id = (int)grdSubject.Rows[selectedRow].Cells["id"].Value;
                string name = (string)grdSubject.Rows[selectedRow].Cells["name"].Value;
                if (MessageBox.Show("Удалить предмет: " + name + "?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    subjectServices.deleteSubject(id);
                    MessageBox.Show("Успешно удалить предмет.", "Info");
                    ShowAllSubject(subjectServices.getAllSubject());
                    txtName.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void grdSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                if (grdSubject.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    grdSubject.CurrentRow.Selected = true;
                    txtName.Text = grdSubject.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                }
        }
        private void grdSubject_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (grdSubject.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    grdSubject.CurrentRow.Selected = true;
                    txtName.Text = grdSubject.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                }
        }
    }
}
