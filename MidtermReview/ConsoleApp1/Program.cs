using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalamountsaved = 0;
            int numofyears = 1;
            int numofmonth = 1;
            double money = 0;
            double intrate = 0.0;
            int years = 0;

            Console.WriteLine("How much money will you save in a week");
            money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much interest rate do you get per month");
            intrate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years would you like to save for");
            years = Convert.ToInt32(Console.ReadLine());

            for (int month = 1; month <= years * 12; month++)
            {
                totalamountsaved += money * 4;
                totalamountsaved += totalamountsaved * intrate;

                string monthname = month.ToString("N0");

                if (numofmonth == 1)
                {
                    monthname = "January";
                }
                else if (numofmonth == 2)
                {
                    monthname = "Feburary";
                }
                else if (numofmonth == 3)
                {
                    monthname = "March";
                }
                else if (numofmonth == 4)
                {
                    monthname = "April";
                }
                else if (numofmonth == 5)
                {
                    monthname = "May";
                }
                else if (numofmonth == 6)
                {
                    monthname = "June";
                }
                else if (numofmonth == 7)
                {
                    monthname = "July";
                }
                else if (numofmonth == 8)
                {
                    monthname = "August";
                }
                else if (numofmonth == 9)
                {
                    monthname = "September";
                }
                else if (numofmonth == 10)
                {
                    monthname = "October";
                }
                else if (numofmonth == 11)
                {
                    monthname = "November";
                }
                else if (numofmonth == 12)
                {
                    monthname = "December";
                }


                Console.WriteLine(monthname + " @ year " + numofyears.ToString("N0") + " : " + totalamountsaved.ToString("C2"));

                numofmonth++;

                if (month % 12 == 0)
                {
                    numofyears++;
                    numofmonth = 1;
                }
            }

            Console.ReadKey();

        }
    }
}
