using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> stack; 
        public Sweepstakes top; 

        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
            top = null;
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public void GetSweepstakes(Sweepstakes sweepstakes)
        {

        }
    }
}
