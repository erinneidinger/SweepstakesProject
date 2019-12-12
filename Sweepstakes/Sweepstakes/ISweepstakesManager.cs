using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    {
        Sweepstakes InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes(Sweepstakes sweepstakes);
    }
}
