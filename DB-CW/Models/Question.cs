namespace Models
{
    public class Question
    {
        private int id_question;
        private int id_subject;
        private string ques;
        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;
        private string answer;

        public int Id_question { get => id_question; set => id_question = value; }
        public int Id_subject { get => id_subject; set => id_subject = value; }
        public string Ques { get => ques; set => ques = value; }
        public string Answer1 { get => answer1; set => answer1 = value; }
        public string Answer2 { get => answer2; set => answer2 = value; }
        public string Answer3 { get => answer3; set => answer3 = value; }
        public string Answer4 { get => answer4; set => answer4 = value; }
        public string Answer { get => answer; set => answer = value; }
        public Question(int id_question, int id_subject, string ques, string answer1, string answer2, string answer3, string answer4, string answer)
        {
            this.id_question = id_question;
            this.id_subject = id_subject;
            this.ques = ques;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.answer4 = answer4;
            this.answer = answer;
        }
    }
}
