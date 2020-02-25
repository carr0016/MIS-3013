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
            string Monthname = "";

            Console.WriteLine("Input the name of the month");
            Monthname = Console.ReadLine();

            if (Monthname == "January")
            {
                Console.WriteLine("There are 31 days in the month ");
            }

            else if (Monthname == "February")
            {
                Console.WriteLine("Is it a leapyear?");
                string Leapyear = Console.ReadLine();

                if (Leapyear == "yes")
                {
                    Console.WriteLine("There are 29 days in the month");
                }
                else
                {
                    Console.WriteLine("There are 28 days in the month");
                }

            }
            else if (Monthname == "March")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (Monthname == "April")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (Monthname == "May")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (Monthname == "June")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (Monthname == "July")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (Monthname == "August")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (Monthname == "September")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (Monthname == "October")
            {
                Console.WriteLine("There are 31 days in the month");
            }
            else if (Monthname == "November")
            {
                Console.WriteLine("There are 30 days in the month");
            }
            else if (Monthname == "December")
            {
                Console.WriteLine("There are 31 days in the month");
            }

            Console.ReadKey();
            }
        }
    }

