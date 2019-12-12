using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        string winner;

        public Sweepstakes(string name)
        {
            Random rnd = new Random();
        }
        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.Registrationnumber, contestant.fullinfo);
        }
        public void PickWinnter(Random rnd)
        {
            winner = dictionary[rnd.Next(dictionary.Count)];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(winner);
        }
    }
}
