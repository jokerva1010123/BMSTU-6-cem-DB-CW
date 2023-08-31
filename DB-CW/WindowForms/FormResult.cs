using System.Collections.Generic;
using System.Windows.Forms;
using Models;
using BL;

namespace DB_CW
{
    public partial class FormResult : Form
    {
        private int id_user;
        private string role;
        private ResultServices resultServices;
        public FormResult(int id_user, string role, ResultServices resultServices)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.role = role;
            this.resultServices = resultServices;
        }
        void ShowAllResult()
        {
            grdResult.Rows.Clear();
            grdResult.Columns.Clear();
            grdResult.Columns.Add("nameExam", "Тест");
            grdResult.Columns.Add("nameStudent", "Студент");
            grdResult.Columns.Add("score", "Баллы");
            grdResult.Columns.Add("totalScore", "Макс. балл");
            grdResult.Columns.Add("startTime", "Начальное время");
            grdResult.Columns.Add("endTime", "Конечное время");
            List<Result> allResult = resultServices.getAllResult(this.role, this.id_user);
            foreach (Result result in allResult)
                grdResult.Rows.Add(result.NameExam, result.NameStudent, 
                    result.Score, result.TotalScore, result.StartTime, result.EndTime);
            this.grdResult.CurrentCell = null;
        }
        private void FormResult_Load(object sender, System.EventArgs e)
        {
            ShowAllResult();
        }
    }
}
