using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{//subject
    public class Sweepstakes
    {
        Random rnd = new Random();
        Dictionary<int, Contestant> dictionary;
        Contestant winner;
        private List<IContestant> contestants = new List<IContestant>();

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            dictionary.Add(contestant.Registrationnumber, contestant);
        }
        public string PickWinner()
        {
            winner = dictionary[rnd.Next(1, dictionary.Count)];
            return winner.Firstname + winner.Lastname;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(winner);
            Console.WriteLine(contestant); 
        }
        public void NotifyContestants()
        {
            foreach (IContestant contestant in contestants)
            {
                contestant.Notify(contestant);

                //if (contestant == winner)
                {

                }
            }
        }
    }
}
