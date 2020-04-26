using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentnumber, answer;
            List<double> number = new List<double>();

            do
            {
                Console.WriteLine($"How many students names do you want to store");
                studentnumber = Console.ReadLine();
                double es = Convert.ToDouble(studentnumber);

                number.Add(es);

                Console.WriteLine("What is the student first name");
                string firstname = Console.ReadLine();

                Console.WriteLine("What is the student last name");
                string lastname = Console.ReadLine();

            } while (answer.ToLower() == "yes");



            Console.WriteLine($" {lastname} ");
         

            Console.ReadKey();

           

        }
    }
}
