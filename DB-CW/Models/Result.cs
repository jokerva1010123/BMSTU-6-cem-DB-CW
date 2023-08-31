using System;

namespace Models
{
    public class Result
    {
        private string nameExam;
        private string codeExam;
        private string nameStudent;
        private int score;
        private int totalScore;
        private DateTime startTime;
        private DateTime endTime;
        public string NameExam { get => nameExam; set => nameExam = value; }
        public string NameStudent { get => nameStudent; set => nameStudent = value; }
        public int Score { get => score; set => score = value; }
        public int TotalScore { get => totalScore; set => totalScore = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string CodeExam { get => codeExam; set => codeExam = value; }
        public Result(string nameExam, string codeExam, string nameStudent, int score, int totalScore, DateTime startTime, DateTime endTime)
        {
            this.nameExam = nameExam;
            this.codeExam = codeExam;
            this.nameStudent = nameStudent;
            this.score = score;
            this.totalScore = totalScore;
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}
