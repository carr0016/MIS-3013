using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            string userInputReverse = "";
             
            Console.WriteLine("Input a word or phrase");
            string userinput = Console.ReadLine().ToLower();
            index = userinput.Length - 1;

            while (index >=0)
            {
                userInputReverse += userinput[index];

                index--;
            }

            if (userinput == userInputReverse) 
            {
                Console.WriteLine($"The word {userinput} is a palindrome");  
            }
            else 
            {
                Console.WriteLine($"The word {userinput} reversed is {userInputReverse} and NOT a palindrome");
            }

            Console.WriteLine(userInputReverse);

            Console.WriteLine("Press Any Key to exit");
            Console.ReadKey();
        }
    } 
}
