using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string monthName = "";

            Console.WriteLine("Enter the name of the month");
            monthName = Console.ReadLine();

            if (monthName == "January" )
            {
                Console.WriteLine("There are 31 days in the month");
            }

            else if (monthName == "February")
            {
                Console.WriteLine("Is the Year A Leap Year? (yes or no)");
                string LeapYear = Console.ReadLine();

                if (LeapYear == "yes")
                {
                    Console.WriteLine("There are 29 days in the month");
                }
                else
                {
                    Console.WriteLine("There are 28 days in the month");
                }
            }
            else if (monthName == "March")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (monthName == "April")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (monthName == "May")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (monthName == "June")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (monthName == "July")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (monthName == "August")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (monthName == "September")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (monthName == "October")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (monthName == "November")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (monthName == "December")
            {
                Console.WriteLine("There are 31 days in the month");
            }

            Console.ReadKey();
           
        }
    }
}
