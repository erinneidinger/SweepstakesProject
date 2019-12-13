using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class SweepstakesFactory 
    {
        public static ISweepstakesManager CreateSweepstakesManager(string structure)
        {
            switch (structure.ToLower())
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
                default:
                    Console.WriteLine("Not a valid option");
                    return null;
            }
        }
    }
}
