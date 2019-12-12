using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager<T>
    {
        public SweepstakesQueueManager()
        {
            Queue<T> myqueue = new Queue<T>();
        }
    }
}
