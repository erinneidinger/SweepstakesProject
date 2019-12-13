using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void AssignFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name:");
            contestant.Firstname = Console.ReadLine();
            Console.WriteLine("Your first name is: " + contestant.Firstname);
           
        }
        public static void AssignLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your last name:");
            contestant.Lastname = Console.ReadLine();
            Console.WriteLine("Your last name is: " + contestant.Lastname);
        }
        public static void AssignEmail(Contestant contestant)
        {
            Console.WriteLine("Please enter your email:");
            contestant.Email = Console.ReadLine();
            Console.WriteLine("Your email is: " + contestant.Email);
        }
        public static void AssignRegistrationNumber(Contestant contestant)
        { 
            Console.WriteLine("Your registration number is: " + contestant.Registrationnumber);
        }
    }
}
