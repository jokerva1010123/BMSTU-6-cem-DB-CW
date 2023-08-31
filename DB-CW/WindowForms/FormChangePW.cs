using BL;
using System;
using System.Windows.Forms;

namespace DB_CW.WindowForms
{
    public partial class FormChangePW : Form
    {
        private int id_user;
        private UserServices userServices;
        public FormChangePW(int id_user, UserServices userServices)
        {
            InitializeComponent();
            this.id_user = id_user;
            this.userServices = userServices;
        }
        private void btnChangePW_Click(object sender, System.EventArgs e)
        {
            try
            {
                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;
                string repeatPassword = txtRepeatPassword.Text;
                if (oldPassword.Length < 1)
                {
                    MessageBox.Show("Введите старый пароль!", "Error");
                    return;
                }
                if (newPassword.Length < 1)
                {
                    MessageBox.Show("Введите новый пароль!", "Error");
                    return;
                }
                if (repeatPassword.Length < 1)
                {
                    MessageBox.Show("Повторите новый пароль!", "Error");
                    return;
                }
                if(newPassword != repeatPassword)
                {
                    MessageBox.Show("Повторный новый пароль неверный!", "Error");
                    return;
                }
                string password = this.userServices.getPasswordFromId(this.id_user);
                if(password != oldPassword)
                {
                    MessageBox.Show("Старый пароль неверный!", "Error");
                    return;
                }
                userServices.changePW(this.id_user, newPassword);
                MessageBox.Show("Пароль успешно изменен!", "Info");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
