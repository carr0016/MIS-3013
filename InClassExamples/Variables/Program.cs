//Riley Carr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an string named firstName
            string firstName;

            //Assign a value to firstName (use your name)
            firstName = "Riley";

            //Create an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 13;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "Carr";
            string fullName = firstName + " " + lastName;

            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber
                + " \nwhich equates to a crazy number of " + crazyNumber);

            // MAKE IT DYNAMIC
            Console.WriteLine("Please enter your first name: >> ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: >> ");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number: >> ");
            string favoriteNumberAsString = Console.ReadLine();
            favoriteNumber = Convert.ToInt32(favoriteNumberAsString);
            //favoriteNumber = Convert.ToInt32(Console.ReadLine();

            fullName = firstName + " " + lastName;
            crazyNumber = 7.6767 * favoriteNumber;
            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber
                                + " \nwhich equates to a crazy number of " + crazyNumber);
            //Console.WriteLine($"{fullName} has the favortie number of {favoriteNumber} \nwhich equates to a crazy number of {crazyNumber}");
            Console.ReadKey();
        }
    }
}
