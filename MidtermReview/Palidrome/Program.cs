using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word or phrase");
            string input = Console.ReadLine();
            int counter;
            counter = input.Length - 1;
            string inputrev = "";


            do
            {
                inputrev += input[counter];
                counter--;
            } while (counter >=0 );


            if (input == inputrev)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
