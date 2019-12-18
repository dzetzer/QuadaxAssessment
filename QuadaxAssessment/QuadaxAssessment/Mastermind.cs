using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadaxAssessment
{
    class Mastermind
    {
        public int Attempts { get; set; }
        public string Answer { get; set; }

        public Mastermind()
        {
            Attempts = 10;
            Answer = GenAnswer();
        }

        private string GenAnswer()
        {
            Random random = new Random();
            string answer = "";

            for(int i = 0; i <= 3; i++)
            {
                answer += random.Next(1, 6).ToString();
            }

            return answer;
        }
    }
}
