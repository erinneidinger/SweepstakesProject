using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {

        Sweepstakes rear;
        Sweepstakes front;
        Stack<Sweepstakes> stack;

        public SweepstakesQueueManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
           
        }

        public void GetSweepstakes(Sweepstakes sweepstakes)
        {

        }

        public void Enqueue(Sweepstakes sweepstakes)
        {
            
        }
        public void Dequeue(Sweepstakes sweepstakes)
        {

        }

    }
}
