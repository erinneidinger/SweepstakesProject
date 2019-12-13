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
            Console.WriteLine("type stack or queue");
            string input = Console.ReadLine();
            ISweepstakesManager manager = SweepstakesFactory.CreateSweepstakesManager(input);
            MarketingFirm marketingfirm = new MarketingFirm(manager);
            Sweepstakes sweepstakes = new Sweepstakes();
            marketingfirm.manager.InsertSweepstakes(sweepstakes);
        }
    }
}
