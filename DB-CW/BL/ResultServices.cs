using System.Collections.Generic;
using Models;
using DA;
using System;

namespace BL
{
    public class ResultServices
    {
        private ResultDA resultDA;
        public ResultDA ResultDA { get => resultDA; set => resultDA = value; }
        public ResultServices(ResultDA resultDA) 
        {
            this.resultDA = resultDA;
        }
        public List<Result> getAllResult(string role, int id_user)
        {
            return resultDA.getAllResult(role, id_user);
        }
        public void addResult(int id_exam, int id_user, DateTime start, DateTime end, int score, int totalscore)
        {
            resultDA.addResult(id_exam, id_user, start, end, score, totalscore);
        }
    }
}
