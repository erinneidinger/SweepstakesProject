using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> myStack; 
        public Sweepstakes top; 

        public SweepstakesStackManager()
        {
            myStack = new Stack<Sweepstakes>();
            top = null;
        }
        public Sweepstakes InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);

            return sweepstakes;
        }

        public Sweepstakes GetSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Pop();

            return sweepstakes;
        }
    }
}
