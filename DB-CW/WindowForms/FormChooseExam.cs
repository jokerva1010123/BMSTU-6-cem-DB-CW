using BL;
using Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DB_CW
{
    public partial class FormChooseExam : Form
    {
        private QEServices qeServices;
        private ResultServices resultServices;
        private int id_user, id_exam;
        public FormChooseExam(QEServices qeServices, ResultServices resultServices, int id_user)
        {
            InitializeComponent();
            this.qeServices = qeServices;
            this.resultServices = resultServices;
            this.id_user = id_user;
            this.id_exam = -1;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            if(this.id_exam == -1)
            {
                MessageBox.Show("Выберите тест!", "Error");
                return;
            }
            if(this.id_exam == 0)
            {
                MessageBox.Show("Этот тест уже сделан. Выберите другой тест!", "Error");
                return;
            }
            FormTakeExam ftakeExam = new FormTakeExam(this.qeServices, this.resultServices, this.id_user, this.id_exam);
            this.Hide();
            ftakeExam.ShowDialog();
            ShowAllExam();
            this.Show();
        }
        private void ShowAllExam()
        {
            dgvExam.Rows.Clear();
            dgvExam.Columns.Clear();
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "Выбор";
            CBColumn.Name = "check";
            CBColumn.ValueType = typeof(bool);
            dgvExam.Columns.Add(CBColumn);
            dgvExam.Columns.Add("id", "Id");
            dgvExam.Columns.Add("name", "Название теста");
            dgvExam.Columns.Add("code", "Код теста");
            dgvExam.Columns.Add("time", "Время");
            List<Exam> allExam = qeServices.getAllExam();
            List<Result> allResult = resultServices.getAllResult("S", id_user);
            foreach (Exam exam in allExam)
            {
                bool flag = false;
                foreach (Result result in allResult)
                {
                    if (result.CodeExam == exam.Code)
                    {
                        flag = true;
                        dgvExam.Rows.Add(true, exam.Id_exam, exam.Name, exam.Code, exam.Duration);
                        break;
                    } 
                }
                if(!flag)
                    dgvExam.Rows.Add(false, exam.Id_exam, exam.Name, exam.Code, exam.Duration);
            }
            dgvExam.CurrentCell = null;
            dgvExam.Columns[0].Width = dgvExam.Columns[1].Width = 50;
        }
        private void FormChooseExam_Load(object sender, System.EventArgs e)
        {
            ShowAllExam();
        }
        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ((bool)dgvExam.Rows[e.RowIndex].Cells[0].Value == false) 
                {
                    id_exam = (int)dgvExam.Rows[e.RowIndex].Cells["id"].Value;
                }
                else
                {
                    id_exam = 0;
                }
            }
        }
    }
}
