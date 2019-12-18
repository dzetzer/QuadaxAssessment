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
        public bool GameFinished { get; set; }

        public Mastermind()
        {
            Attempts = 10;
            Answer = GenAnswer();
            GameFinished = false;

            Console.WriteLine("Welcome to Mastermind!");
            Console.WriteLine("Guess the four digit code containing numbers between 1 and 6 \r\n");
            Console.WriteLine("\"-\" indicates a corrent number in an incorrect location");
            Console.WriteLine("\"+\" indicates a corrent number in a correct location");
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

        public void MakeAttempt()
        {
            Console.WriteLine("You have " + this.Attempts + " attempts remaining");
            string attempt = Console.ReadLine();

            if (attempt.Length >= 4)
            {
                CheckAttempt(attempt);
            }
            else Console.WriteLine("You did not enter a four digit number");
        }

        public void CheckAttempt(string attempt)
        {
            string attemptAssess = "";

            for (int i = 0; i <= 3; i++)
            {
                attemptAssess += CheckNumber(attempt[i], i);
            }

            Console.WriteLine(attemptAssess);

            this.Attempts--;

            if (attemptAssess == "++++")
            {
                Console.WriteLine("You Win! The answer was " + this.Answer);
                this.GameFinished = true;
            }
            else if (Attempts == 0)
            {
                Console.WriteLine("You Lose! The answer was " + this.Answer);
                this.GameFinished = true;
            }
        }

        public string CheckNumber(char charCheck, int charIndex)
        {
            if (this.Answer[charIndex] == charCheck) return "+";
            else if (this.Answer.Contains(charCheck)) return "-";
            else return " ";
        }
    }
}
