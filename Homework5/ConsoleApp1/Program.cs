using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> GradesList = new List<double>();
            string Answer;

            do
            {
                Console.WriteLine("Enter your grade");
                double Grade = Convert.ToDouble(Console.ReadLine());
                GradesList.Add(Grade);

                Console.WriteLine("Do you want to enter another exam grade");
                Answer = Console.ReadLine();

            } while (Answer == "yes");


            double Sum = 0;

            foreach (var Grade in GradesList)
            {
                Sum = Sum + GradesList[i];
            }

        }
    }
}
