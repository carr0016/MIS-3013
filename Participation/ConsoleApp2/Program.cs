﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string examScore, answer;
            List<double> scores = new List<double>();

            do
            {
                Console.WriteLine($"Please enter your exam score>>");
                examScore = Console.ReadLine();
                double es = Convert.ToDouble(examScore);

                scores.Add(es);

                Console.WriteLine("Do you want to input another exam score? yes/no >>");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes");


            double sum = 0; //accumulator variable
            double minimum = scores[0];
            double maximum = scores[0];

            for (int i = 0; i < scores.Count; i++)
            {
                double score = scores[i];
                sum = sum + score;


                if (score < minimum)
                {
                    minimum = score;
                }
                if (score > maximum)
                {
                    maximum = score;
                }

            }

            double average = sum / scores.Count;

            Console.WriteLine($"Your average for the {scores.Count} exam grades is {average.ToString("N3")}.");
            Console.WriteLine($"Your minimum exam score is {minimum.ToString("N3")}.");
            Console.WriteLine($"Your maximum exam score is {maximum.ToString("N3")}.");

            Console.ReadKey();
        }
    }
}
