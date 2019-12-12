using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string fullinfo;
        private string firstname;
        public string Firstname
        {
            get
            {
                return firstname;
            }
        }

        private string lastname;
        public string Lastname
        {
            get
            {
                return lastname;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
        }

        private int registrationnumber;
        public int Registrationnumber
        {
            get
            {
                return registrationnumber;
            }
        }

        public Contestant()
        {
            Contestant contestant = new Contestant();
            Random rnd = new Random();
        }
        public string AddFullName()
        {
            fullinfo = (Firstname + " " + Lastname + " " + Email);
            return fullinfo;
        }
    }
}
