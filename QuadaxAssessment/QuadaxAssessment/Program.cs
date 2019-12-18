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
            Mastermind mastermind = new Mastermind();

            while(mastermind.Attempts >= 0)
            {
                mastermind.MakeAttempt();
            }
        }
    }
}
