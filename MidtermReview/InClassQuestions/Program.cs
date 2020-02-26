using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            List<double> allDaNumbers = new List<double>();

            Console.WriteLine("Please enter a number>>");
            string usersAnswersAsString = Console.ReadLine();
            double usersAnswerAsDouble = Convert.ToDouble(usersAnswerAsString);
            allDaNumbers.Add(usersAnswerAsDouble);

            Console.WriteLine("Do you want to enter another numer? >>");
            string enterAnotherNumber = Console.ReadLine();


            do
            {
                Console.WriteLine("Please enter a number>>");
                usersAnswersAsString = Console.ReadLine();
                usersAnswerAsDouble = Convert.ToDouble(usersAnswerAsString);
                allDaNumbers.Add(usersAnswerAsDouble);

                Console.WriteLine("Do you want to enter another number?>>");
                enterAnotherNumber = Console.ReadLine();

            } while (enterAnotherNumber == "yes");

            //While statement: do while is normally better over while
            //while (enterAnotherNumber == "yes")
            //{
            //  Console.WriteLine("Please enter a number>>");
            //   usersAnswersAsString = Console.ReadLine();
            //  usersAnswerAsDouble = Convert.ToDouble(usersAnswerAsString);
            //  allDaNumbers.Add(usersAnswerAsDouble);

            // Console.WriteLine("Do you want to enter another number?>>");
            //   enterAnotherNumber = Console.ReadLine();




            
            }
        }
    }
}
