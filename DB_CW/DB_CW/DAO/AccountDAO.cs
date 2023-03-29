using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CW.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public int Login(string username, string password) 
        {
            string query = "select * from userlogin where username = @username and passwords = @password";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            if (data.Rows.Count < 0) return -1;
            DataRow row = data.Rows[0];
            return (int)row["id_role"]; 
        }
    }
}
