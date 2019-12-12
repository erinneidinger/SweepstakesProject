using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    { 

        public static void AssignFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Your first name is: " + firstname);
        }
        public static void AssignLastName()
        {
            Console.WriteLine("Please enter your last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Your last name is: " + lastname);
        }
        public static void AssignEmail()
        {
            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Your email is: " + email);
        }
        public static void AssignRegistrationNumber(Random rnd)
        {
            int registrationnumber;

            registrationnumber = rnd.Next(1, 1000);
            Console.WriteLine("Your registration number is: " + registrationnumber);
        }
    }
}
