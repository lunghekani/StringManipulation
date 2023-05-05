using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string lastName;

            string email;


            Console.WriteLine("Hey please enter your first name" );
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();

            // regular
            //email = firstName + "." + lastName+ "@uj.ac.za";
            // a bit more fancy
            //email = string.Concat(firstName, ".", lastName, "@uj.ac.za");

            //email = firstName[0] + "." + lastName + "@uj.ac.za";

            //email = firstName[3].ToString() + firstName[4].ToString() + firstName[5].ToString();

            email = firstName.Substring(0,1) + "." + lastName + "@uj.ac.za";



            Console.WriteLine("CONGRATULATIONS ");
            Console.WriteLine("your new email is "+ email);

            Console.ReadLine();
        }
    }
}
