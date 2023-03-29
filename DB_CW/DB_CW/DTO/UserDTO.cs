using DB_CW.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CW.DTO
{
    public class UserDTO
    {
        private int id_userlogin;
        private int id_role;
        private string username;
        private string passwords;
        private string nameUser;
        private string phoneUser;
        private string emailUser;
        UserDAO daoUser = new UserDAO();

        public int Id_userlogin { get => id_userlogin; set => id_userlogin = value; }
        public int Id_role { get => id_role; set => id_role = value; }
        public string Username { get => username; set => username = value; }
        public string Passwords { get => passwords; set => passwords = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }
        public string PhoneUser { get => phoneUser; set => phoneUser = value; }
        public string EmailUser { get => emailUser; set => emailUser = value; }
        public UserDTO() { }
        public UserDTO(int id_userlogin, string username, string passwords, int id_role, string nameUser, string phoneUser, string emailUser)
        {
            this.id_userlogin = id_userlogin;
            this.username = username;
            this.passwords = passwords;
            this.id_role = id_role;
            this.nameUser = nameUser;
            this.phoneUser = phoneUser;
            this.emailUser = emailUser;
        }
        public UserDTO(DataGridViewRow row)
        {
            this.id_userlogin = (int)row.Cells["id_userlogin"].Value;
            this.username = (string)row.Cells["username"].Value;
            this.passwords = (string)row.Cells["passwords"].Value;
            this.id_role = (int)row.Cells["id_role"].Value;
            this.nameUser = (string)row.Cells["nameUser"].Value;
            this.phoneUser = (string)row.Cells["phoneUser"].Value;
            this.emailUser = (string)row.Cells["emailUser"].Value;
        }
        public DataTable getAllUser(string order)
        {
            return  daoUser.getAllUser(order);
        }
        public int addUsers(UserDTO user)
        {
            return daoUser.addUsers(user);
        }
        public int updateUser(UserDTO user) 
        {
            return daoUser.updateUser(user);
        }
        public int deleteUser(UserDTO user) 
        {
            return daoUser.deleteUser(user);
        }
        public DataTable searchByUsername(string username)
        {
            return daoUser.searchByUsername(username);
        }
        public DataTable searchByNameuser(string nameuser)
        {
            return daoUser.searchByNameuser(nameuser);
        }
    }
}
