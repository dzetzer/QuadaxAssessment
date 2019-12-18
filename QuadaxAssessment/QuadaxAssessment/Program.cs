using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadaxAssessment
{
    class Program
    {
        static void Main()
        {
            bool appRun = true;
            while(appRun == true)
            {
                Mastermind mastermind = new Mastermind();

                while (mastermind.GameFinished == false)
                {
                    mastermind.MakeAttempt();
                }

                Console.WriteLine("Press Enter to restart the game");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
