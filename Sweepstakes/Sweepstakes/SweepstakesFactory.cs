using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesFactory 
    {
        public Sweepstakes CreateSweepstake(string structure)
        {
            Console.WriteLine("Please choose how you would like to manage your sweepstake. Type either 'queue' or 'stack'.");
            switch (structure.ToLower())
            {
                case "queue":
                    return;
                case "stack":
                    return ;
                default:
                    Console.WriteLine("Not a valid option.");
                    break;
            }
        }
    }
}
