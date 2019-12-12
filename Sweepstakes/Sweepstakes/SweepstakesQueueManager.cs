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
        Queue<Sweepstakes> myQueue;

        public SweepstakesQueueManager()
        {
            myQueue = new Queue<Sweepstakes>();
            front = null;
        }
        public Sweepstakes InsertSweepstakes (Sweepstakes sweepstakes)
        {
                myQueue.Enqueue(sweepstakes);

            return sweepstakes;
        }

        public Sweepstakes GetSweepstakes (Sweepstakes sweepstakes)
        {
            myQueue.Dequeue();

            return sweepstakes;
        }
    }
}
