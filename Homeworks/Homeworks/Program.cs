using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();

            Console.WriteLine("Emter your salary");
            double Salary;

            do
            {
                if (double.TryParse(Console.ReadLine(), out Salary))
                {
                    double FederalTax = CalculateFederalTax(Salary);
                    double FICATax = CalculateFICATax(Salary);
                    DisplayResults(Name, Salary, FederalTax, FICATax);
                }
                else
                {
                    Console.WriteLine("Error. Please type valid number");
                }
            } while (true);
        }

        public static double CalculateFederalTax(double Salary)
        {
            double TaxPercentage;
            if (Salary <= 9525)
            {
                TaxPercentage = 10;
            }
            else if (Salary <= 38700)
            {
                TaxPercentage = 12;
            }
            else if (Salary <= 82500)
            {
                TaxPercentage = 22;
            }
            else if (Salary <= 157500)
            {
                TaxPercentage = 24;
            }
            else if (Salary <= 200000)
            {
                TaxPercentage = 32;
            }
            else if (Salary <= 50000)
            {
                TaxPercentage = 35;
            }
            else
            {
                TaxPercentage = 37;
            }

            return (TaxPercentage * Salary) / 100;
        }

        public static double CalculateFICATax(double Salary)
        {
            return (6.2 * Salary) / 100;
        }

        public static void DisplayResults (string Name, double Salary, double FederalTax, double FICATax)
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Federal Tax: {FederalTax}");
            Console.WriteLine($"FICA Tax: {FICATax}");
            Console.WriteLine($"Net Salary: {Salary - FederalTax - FICATax}");
        }

        public static string Input()
        {
            return Console.ReadLine();
        }

        public static void Print(string MSG)
        {
            Console.WriteLine(MSG);
        }


    }
    
}

