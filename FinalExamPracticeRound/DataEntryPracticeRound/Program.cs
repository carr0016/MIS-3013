using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryPracticeRound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> Number = new List<double>();
            double answer;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number");
                answer = Convert.ToDouble(Console.ReadLine());
                Number.Add(answer);
               
            }
            double max = CalculateMax(Number);
            double average = CalculateAverage(Number);
            Console.WriteLine($"The maximum number is {max}");
            Console.WriteLine($"The average is {average}");
            Console.ReadKey();
        }

        private static double CalculateMax(List<double> number)
        {
            double max = 0;
            foreach (var answer in number)
            {
                if (answer > max)
                {
                    max = answer;
                }
            }
            return max;
        }

        private static double CalculateAverage(List<double> number)
        {
            double average;
            double sum = 0;
            foreach (var answer in number)
            {
                sum += answer;
            }
            return average = sum / number.Count;
        }
    }

    }





