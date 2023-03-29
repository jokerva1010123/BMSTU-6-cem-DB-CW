using DB_CW.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_CW.DAO
{
    public class SubjectDAO
    {
        public DataTable getAllSubject()
        {
            string query = "select * from subject order by id_subject";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public int addSubject(SubjectDTO subjectDTO)
        {
            string query = "insert into userlogin(namesubject) values ( @namesubject )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { subjectDTO.Namesubject });
        }
        public int deleteSubject(SubjectDTO subjectDTO)
        {
            string query = "delete from subject where id_subject = @id_subject";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { subjectDTO.Id_subject });
        }
    }
}
