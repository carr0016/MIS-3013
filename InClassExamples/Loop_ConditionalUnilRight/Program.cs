using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_ConditionalUnilRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNumber = 1;
            int usersGuess = -1;

            while (usersGuess != randomNumber)
            {
                randomNumber = rand.Next(0, 2);
                 Console.WriteLine(randomNumber);

            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuessAsString = Console.ReadLine();

            
            const int HEADS_VALUE = 0;
            const int TAILS_VALUE = 1;

            if (usersGuessAsString = "Heads")
            else if (usersGuessAsString == "Tails")
            else 

            if(usersGuess == randomNumber)
                {
                    Console.WriteLine($"Congrats, {usersGuessAsString} was right!");
                }
                else if (usersGuessAsString ! = outcome)

                {
                    Console.WriteLine("You Guess Incorrectly")
                }
        }
    }
}
