using DA;
using Error;
using Models;
using System.Collections.Generic;

namespace BL
{
    public class SubjectServices
    {
        private SubjectDA subjectDA;
        public SubjectDA SubjectDA { get => subjectDA; set => subjectDA = value; }
        public SubjectServices(SubjectDA subjectDA) 
        {
            this.subjectDA = subjectDA;
        }
        public List<Subject> getAllSubject() 
        {
            return subjectDA.getAllSubject();
        }
        public List<Subject> findSubject(string str)
        {
            List<Subject> allSubject = subjectDA.getAllSubject();
            List<Subject> result = new List<Subject>();
            foreach (Subject subject in allSubject) 
                if(subject.NameSubject.Contains(str))
                    result.Add(subject);
            return result;
        }
        public void addSubject(string name)
        {
            subjectDA.addSubject(name);
        }
        public void updateSubject(int id, string name)
        {
            subjectDA.updateSubject(id, name);
        }
        public void deleteSubject(int id)
        {
            subjectDA.deleteSubject(id);
        }
        public string getSubjectFromId(int id_subject)
        {
            return subjectDA.getSubjectFromId(id_subject);
        }
        public int getIdFromName(string name)
        {
            return subjectDA.getIdFromName(name);
        }
    }
}
