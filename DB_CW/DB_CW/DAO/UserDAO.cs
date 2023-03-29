using DB_CW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DB_CW.DAO
{
    public class UserDAO
    {
        public DataTable getAllUser(string order)
        {
            string query = "select * from userlogin order by " + order;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int addUsers(UserDTO userDTO) 
        {
            string query = "insert into userlogin(username, passwords, id_role, nameUser, phoneUser, emailUser) values ( @username , @passwords , @id_role , @name , @phone , @email )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userDTO.Username, userDTO.Passwords, userDTO.Id_role, userDTO.NameUser, userDTO.PhoneUser, userDTO.EmailUser });
        }
        public int updateUser(UserDTO userDTO) 
        {
            string query = "update userlogin set username = @username , passwords = @passwords , id_role = @id_role , nameUser = @name , phoneUser = @phone , emailUser = @email where id_userlogin = @id_username ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userDTO.Username, userDTO.Passwords, userDTO.Id_role, userDTO.NameUser, userDTO.PhoneUser, userDTO.EmailUser, userDTO.Id_userlogin });
        }
        public int deleteUser(UserDTO userDTO) 
        {
            string query = "delete from userlogin where username = @username";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { userDTO.Username });
        }
        public DataTable searchByUsername(string username)
        {
            string query = "select * from userlogin where username like @username";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { username });
        }
        public DataTable searchByNameuser(string nameuser)
        {
            string query = "select * from userlogin where nameuser like @nameuser";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { nameuser });
        }
    }
}
