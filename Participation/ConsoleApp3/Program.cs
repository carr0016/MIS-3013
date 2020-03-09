using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCalculator
{
    class Program
    {

        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine($"{developerName} wrote this appliction for {className} on {dateOfWriting}");
        }



        static void Main(string[] args)
        {
            string answer2;
            
            
            List<double> Values = new List<double>();

            do
            {
                Console.WriteLine("Please enter the type of calculation you want to perform");
                string answer = Console.ReadLine();

                Console.WriteLine("Please enter one value");
                double Value1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter another value");
                double Value2 = Convert.ToDouble(Console.ReadLine());

                if (answer == "Add")
                {
                    double Addsum = Add(Value1, Value2);
                    Console.WriteLine(Value1 + " + " + Value2 + " = " + Addsum);
                }
                else if (answer == "Subtract")
                {
                    double SubtractAnswer = Subtract(Value1, Value2);
                    Console.WriteLine(Value1 + " - " + Value2 + " = " + SubtractAnswer);
                }
                else if (answer == "Multiply)
                {
                    double MultiplyAnswer = Multiply(Value1, Value2);
                    Console.WriteLine(Value1 + " x " + Value2 + " = " + MultiplyAnswer);
                }
                else if (answer == "Divide")
                {
                    double DivideAnswer = Divide(Value1, Value2);
                    Console.WriteLine(Value1 + " /" + Value2 + " = " + DivideAnswer);
                }

                Console.WriteLine("Would you like to perform a new calculation?");
                answer2 = Console.ReadLine();

            } while (answer2.ToLower() != "no");
         
        }

        static double Add(double v1, double v2)

        {

            return v1 + v2;

        }
        static double Subtract(double first, double second)

        {

            return first - second;

        }
        static double Multiply (double vv1, double vv2)

        {
            return vv1*vv2;

        }
        static double Divide (double vvv1, double vvv2)
        {
            return vvv1 / vvv2;
        }

    }
    }


