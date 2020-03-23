using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchWillISave
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the name of the month");
            string input = Console.ReadLine();

            if (input == "January")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (input == "February")
            {
                Console.WriteLine("Is it a Leap Year (yes or no?");
                string leapyear = Console.ReadLine();
                if (leapyear == "yes")
                {
                    Console.WriteLine("There are 29 days");
                }
                else
                {
                    Console.WriteLine("There are 28 days");
                }
            }
            else if (input == "March")
            {
                Console.WriteLine("There are 31 days");
            }
            else if (input == "April")
            {
                Console.WriteLine("There are 30 days");
            }
            else if (input == "May")
            {
                Console.WriteLine("There are 31 days");
            }
            else if (input == "June")
            {
                Console.WriteLine("There are 30 days");
            }
            else if (input == "July")
            {
                Console.WriteLine("There are 31 days");
            }
            else if (input == "August")
            {
                Console.WriteLine("There are 31 days");
            }
            else if (input == "September")
            {
                Console.WriteLine("There are 30 days");
            }
            else if (input == "October")
            {
                Console.WriteLine("There are 31 days");
            }
            else if (input == "November")
            {
                Console.WriteLine("There are 30 days");
            }
            else if (input == "December")
            {
                Console.WriteLine("There are 31 days");
            }

            Console.ReadKey();

        }
    }
}
