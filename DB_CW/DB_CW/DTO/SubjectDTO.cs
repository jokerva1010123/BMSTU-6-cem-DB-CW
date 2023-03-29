using DB_CW.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CW.DTO
{
    public  class SubjectDTO
    {
        private int id_subject;
        private string namesubject;
        SubjectDAO subjectDAO = new SubjectDAO();
        public SubjectDTO() { }
        public SubjectDTO(int id_subject, string subject)
        {
            this.id_subject = id_subject;
            this.namesubject = subject;
        }
        public SubjectDTO(DataGridViewRow row)
        {
            this.id_subject = (int)row.Cells["id_subject"].Value;
            this.namesubject = (string)row.Cells["namesubject"].Value;
        }
        public int Id_subject { get => id_subject; set => id_subject = value; }
        public string Namesubject { get => namesubject; set => namesubject = value; }
        public DataTable getAllSubject()
        {
            return subjectDAO.getAllSubject();
        }
        public int addSubject(SubjectDTO subjectDTO) 
        {
            return addSubject(subjectDTO);
        }
        public int deleteSubject(SubjectDTO subjectDTO)
        { 
            return subjectDAO.deleteSubject(subjectDTO); 
        }
    }
}
