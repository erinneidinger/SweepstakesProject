using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    //concreteobserver
    public class Contestant : IContestant
    {

        string firstname;
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        string lastname;
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        int registrationnumber;
        public int Registrationnumber
        {
            get
            {
                return registrationnumber;
            }
            set
            {
                registrationnumber += 1;
            }
        }

        public Contestant()
        { 
            registrationnumber = 1;
        }
        public void Notify(IContestant contestant)
        {
            //Console.Write("The winner of this sweepstake is {0}! \n", );
        }
    }
}
