using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulators
{
    class Program
    {
        static void Main(string[] args)
        {
            //didnt work
            int counter;
            int sum = 0;
            double multiplication = 1;

             for (counter = 1; counter <= 100; counter++)
            {
                sum += counter;
                multiplication *= counter;
            }

            Console.WriteLine($"The summation from 1 - 100 is {sum.ToString("N0")}");
            Console.WriteLine("The multiplication from 1 - 100 is " + multiplication.ToString("N0"));


            Console.WriteLine("Press any key to exit >>");
            Console.ReadKey();
        }
    }
}
