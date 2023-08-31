using Models;
using DA;
using System.Collections.Generic;

namespace BL
{
    public class QEServices
    {
        private QEDA qeDA;
        public QEServices(QEDA qeDA)
        {
            this.qeDA = qeDA;
        }
        public List<Exam> getAllExam()
        {
            List<Exam> allExam = qeDA.getAllExam();
            foreach (Exam exam in allExam)
                exam.Question = qeDA.getListIdQuestion(exam.Id_exam);
            return allExam;
        }
        public List<Question> getQuestion(int id_exam)
        {
            return qeDA.getListQuestion(id_exam);
        }
        public List<Question> getAllQuestion()
        {
            return qeDA.getAllQuestion();
        }
        public List<Question> getAllQuestionSubject(int id_subject)
        {
            return qeDA.getAllQuestionSubject(id_subject);
        }
        public void deleteQuestion(int id_question)
        {
            qeDA.deleteQuestion(id_question);
        }
        public void deleteExam(int id_exam)
        {
            qeDA.deleteExam(id_exam);
        }
        public void addQuestion(string ques, string ans1, string ans2, string ans3, string ans4, string ans, int id_subject)
        {
            qeDA.addQuestion(ques, ans1, ans2, ans3, ans4, ans, id_subject);
        }
        public void updateQuestion(int id_question, string ques, string ans1, string ans2, string ans3, string ans4, string ans, int id_subject)
        {
            qeDA.updateQuestion(id_question, ques, ans1, ans2, ans3, ans4, ans, id_subject);
        }
        public void addExam(int id_subject, string nameExam, string code_exam, List<int> questions, int duration)
        {
            qeDA.addExam(id_subject, nameExam, code_exam, duration);
            int id_exam = qeDA.getIdExamFromCode(code_exam);
            foreach (int id_question in questions)
                qeDA.addQuestionExam(id_exam, id_question);
        }
        public void updateExam(int id_exam, int id_subject, string nameExam, string codeExam, List<int> questions, int duration)
        {
            qeDA.updateExam(id_exam, id_subject, nameExam, codeExam, duration);
            List<int> tmp_ques = qeDA.getListIdQuestion(id_exam);
            foreach (int id_question in tmp_ques)
                if (!questions.Contains(id_question))
                    qeDA.deleteQuestionExam(id_exam, id_question);
            foreach(int id_question in questions)
                if(!tmp_ques.Contains(id_question))
                {
                    qeDA.addQuestionExam(id_exam, id_question);
                    tmp_ques.Add(id_question);
                }
        }
        public bool hasCodeExam(string codeExam)
        {
            List<Exam> allExam = qeDA.getAllExam();
            foreach(Exam exam in allExam)
                if(exam.Code == codeExam)
                    return true;
            return false;
        }
        public int getIdExamFromCode(string codeExam)
        {
            List<Exam> allExam = qeDA.getAllExam();
            foreach (Exam exam in allExam)
                if (exam.Code == codeExam)
                    return exam.Id_exam;
            return -1;
        }
        public int getDuration(int id_exam)
        {
            return qeDA.getDuration(id_exam);
        }
    }
}
