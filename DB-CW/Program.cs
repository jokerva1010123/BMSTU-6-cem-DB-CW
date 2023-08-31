using BL;
using DA;
using System;
using System.Windows.Forms;

namespace DB_CW
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnectionArgs connectionArgs = new ConnectionArgs("postgres", "localhost", "db_cw", "0612", 5432);

            UserDA userDA = new UserDA(connectionArgs);
            ResultDA resultDA = new ResultDA(connectionArgs);
            SubjectDA subjectDA = new SubjectDA(connectionArgs);
            QEDA qeDA = new QEDA(connectionArgs);

            UserServices userServices = new UserServices(userDA);
            ResultServices resultServices = new ResultServices(resultDA);
            SubjectServices subjectServices = new SubjectServices(subjectDA);
            QEServices qeServices = new QEServices(qeDA);

            Application.Run(new FormLogin(userServices, resultServices, subjectServices, qeServices));
        }
    }
}
