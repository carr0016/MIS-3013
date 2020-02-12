using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to count to? >>");
            //string input = Console.ReadLine();
            //int threshold = Convert.ToInt32(input);
            int threshold = Convert.ToInt32(Console.ReadLine());

            //Could also use i < 101
            for (int i = 1; i <= threshold; i++)
            {
                Console.Write(i + " ");
            }

            double sum = 0; //this is an accumulator variable
            string answer;

            do
            {
                Console.WriteLine("Please give us a # to add >>");
                double number = Convert.ToDouble(Console.ReadLine());
                //sum = sum + number;
                sum += number;

                Console.WriteLine("Do you have another # to add? (y,n) >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "y");
            //} while (answer != "n"); 
            Console.WriteLine($"Your summation of values is {sum.ToString("N2")}");

            Console.ReadKey();
         }
    }
}
