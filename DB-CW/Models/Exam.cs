using System.Collections.Generic;

namespace Models
{
    public class Exam
    {
        private int id_exam;
        private string name;
        private int id_subject;
        private string code;
        private List<int> question;
        private int duration;

        public int Id_exam { get => id_exam; set => id_exam = value; }
        public string Name { get => name; set => name = value; }
        public int Id_subject { get => id_subject; set => id_subject = value; }
        public List<int> Question { get => question; set => question = value; }
        public string Code { get => code; set => code = value; }
        public int Duration { get => duration; set => duration = value; }

        public Exam(int id_exam, int id_subject, string name, string code, List<int> question, int duration)
        {
            this.id_subject = id_subject;
            this.name = name;
            this.code = code;
            this.id_exam = id_exam;
            this.question = question;
            this.duration = duration;
        }
    }
}
