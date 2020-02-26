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
            //didnt finish


            Console.WriteLine("How much money do you want to save a week?");
            double moneyweek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much interest rate will you get per month?");
            double intrate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many years would you like to save for?");
            int yearsave= Convert.ToInt32(Console.ReadLine());

            double AmountSavedPerMonth = (moneyweek * 4);
            double TotalAmountSaved = AmountSavedPerMonth;
            
            for (int i = 1; i <= yearsave *12; i++)
            {
                TotalAmountSaved = (TotalAmountSaved + AmountSavedPerMonth) * (1 + intrate);
                Console.WriteLine(TotalAmountSaved);  
            }

            Console.ReadKey();
        }
    }
}
