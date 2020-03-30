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
                string answer;
                double Value1;
                double Value2;
                double result;
            do
            {
                Console.WriteLine("Please enter the type of calculation you want to perform");
                answer = Console.ReadLine();
                Console.WriteLine("Please enter one value");
                Value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter another value");
                Value2 = Convert.ToDouble(Console.ReadLine());

                if (answer == "Add")
                {
                    result = Add(Value1, Value2);
                    Console.WriteLine(Value1 + " + " + Value2 + " = " + result);
                }
                else if (answer == "Subtract")
                {
                    result = Subtract(Value1, Value2);
                    Console.WriteLine(Value1 + " - " + Value2 + " = " + result);
                }
                else if (answer == "Multiply")
                {
                    result = Multiply(Value1, Value2);
                    Console.WriteLine(Value1 + " x " + Value2 + " = " + result);
                }
                else if (answer == "Divide")
                {
                    result = Divide(Value1, Value2);
                    Console.WriteLine(Value1 + " /" + Value2 + " = " + result);
                }

                Console.WriteLine("Would you like to perform a new calculation?");
                answer2 = Console.ReadLine();
                if (answer2 == "No")
                {
                    Console.WriteLine("Thank you for using this service");
                }
                else if (answer2 == "Yes")
                {
                    if (answer == "Add")
                    {
                        result = Add(Value1, Value2);
                        Console.WriteLine(Value1 + " + " + Value2 + " = " + result);
                    }
                    else if (answer == "Subtract")
                    {
                        result = Subtract(Value1, Value2);
                        Console.WriteLine(Value1 + " - " + Value2 + " = " + result);
                    }
                    else if (answer == "Multiply")
                    {
                        result = Multiply(Value1, Value2);
                        Console.WriteLine(Value1 + " x " + Value2 + " = " + result);
                    }
                    else if (answer == "Divide")
                    {
                        result = Divide(Value1, Value2);
                        Console.WriteLine(Value1 + " /" + Value2 + " = " + result);
                    }
                }

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


