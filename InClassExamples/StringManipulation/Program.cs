using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  01234
            string firstName = "Riley";
            string lastName = "Carr";

            Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your firstname.");
            //Console.WriteLine("You have" + fistName.Length.ToString("N0") + "characters in your firstname.");
            Console.WriteLine($"You have {lastName.Length.ToString("N0")} characters in your lastname.");
            char firstInitial = firstName[0];
            char lastInitial = lastName[0];

            //Console.WriteLine(firstName.ToUpper()[0]);
            //Console.WriteLine(firstName.ToUpper()[1]);
            //Console.WriteLine(firstName.ToUpper()[2]);
            //Console.WriteLine(firstName.ToUpper()[3]);

            firstName = firstName.ToUpper();
            //Output every character of the firstname on a sperate line with BIG LETTERS
            for (int i = 0; i < firstName.Length; i++) //i= i +1
                {
                    char currentLetter = firstName[i];
                    Console.WriteLine(currentLetter);
                    
                }
            foreach (char currentLetter in firstName)
            {
                Console.WriteLine(currentLetter);
            }

            
            
            Console.WriteLine("Output every other letter of the first name");
            for (int i = 0; i < firstName.Length; i++) //i= i +1
            {
                char currentLetter = firstName[i];
                Console.Write(currentLetter + " ");

            }
            Console.WriteLine();
            Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");

            //Riley Carr
            //rraC yeliR

            string name = firstName + " "+lastName;
            var pieces = name.Split(' '); //Creates a collection with a size of 2
            string fName = name.Substring(0, firstName.Length);
            fName = "      " + fName + "        ";
            fName = fName.Trim();
            for (int i = name.Length - 1; i >=0; i--)
            {
                Console.Write(name[i]);
            }

            Console.ReadKey();

        }
    }
}
