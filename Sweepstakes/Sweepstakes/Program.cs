using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ISweepstakesManager> sweepstakeStructures = new List<ISweepstakesManager>();
            SweepstakesQueueManager myQueue = new SweepstakesQueueManager();
            SweepstakesStackManager myStack = new SweepstakesStackManager();

            sweepstakeStructures.Add(myQueue);
            sweepstakeStructures.Add(myStack);
        }
    }
}
