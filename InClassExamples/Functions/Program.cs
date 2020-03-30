using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            List<double> grades = new List<double>();
            List<double> examgrades = new List<double>();
            List<double> quizgrades = new List<double>();
            List<double> homeworkgrades = new List<double>();

            do
            {
                double grade = GetValidDoubleFromUser("Please enter your exam grade");
                examgrades.Add(grade);



                Console.WriteLine("Do you have another value to enter");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "no");
        }
        static double GetValidDoubleFromUser(stringmessage)
        {
            Console.WriteLine("Please enter your exam grade");
            string response = Console.ReadLine();
            double grade = 0;
            while (double.TryParse(response, out grade) != true)
            {
                Console.WriteLine("Sorry, you must enter a valid number, please try again >>");
                response = Console.ReadLine();
            }
            return grade;
        }
}
}
