using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accumulators2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            double multiplication = 1;

            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                multiplication *= i;
            }

            Console.WriteLine(sum.ToString("N0"));
            Console.WriteLine(multiplication.ToString("N0"));


            Console.ReadKey();
        }
    }
}
