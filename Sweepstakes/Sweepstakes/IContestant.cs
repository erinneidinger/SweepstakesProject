using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    //observer
    public interface IContestant
    {
        //string Name
        
        void Notify(IContestant contestant);
    }
}
