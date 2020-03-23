using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMuchWillISaveAfterXYears
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneysavedinweek = 0;
            double intrate = 0;
            int years = 0;

            Console.WriteLine("how much momey will u save in a week");
            moneysavedinweek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("how much interest");
            intrate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("how many years");
            years = Convert.ToInt32(Console.ReadLine());

            int numofyears = 0;
            double totalamountsaved = 0;

            for (int month = 1; month <= years *12; month++)
            {
                totalamountsaved += moneysavedinweek * 4;
                totalamountsaved += totalamountsaved * intrate;

                if (month == 1)
                {
                    numofyears++;
                    Console.WriteLine("Janurary, year" + numofyears + totalamountsaved);
                }
                else if (month == 2)
                {
                    numofyears++;
                    Console.WriteLine("Februrary, year" + numofyears + totalamountsaved);
                }
            }



            Console.ReadKey();
        }
    }
}
