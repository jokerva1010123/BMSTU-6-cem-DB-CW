namespace Models
{
    public class Subject
    {
        private int id_subject;
        private string nameSubject;
        public int Id_subject { get => id_subject; set => id_subject = value; }
        public string NameSubject { get => nameSubject; set => nameSubject = value; }
        public Subject(int id_subject, string nameSubject)
        {
            this.id_subject = id_subject;
            this.nameSubject = nameSubject;
        }
    }
}
