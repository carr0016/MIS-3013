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
            //Riley Carr
            Console.WriteLine("How many student names do you want to store?");
            //reading number of students
            int numberOfStudents = int.Parse(Console.ReadLine());
            //creating two parallel arrays
            //creating array to store first names
            string[] firstNames = new string[numberOfStudents];
            //creating array to store last names
            string[] lastNames = new string[numberOfStudents];
            //using for loop
            Console.WriteLine("Enter first name: ");
                string firstname = Console.ReadLine();
                Console.WriteLine(" Entrer last name ");
                string lastname = Console.ReadLine();
            
            Console.WriteLine("Name: ");

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.WriteLine($"{lastname} , {firstname} ");
            }


            Console.ReadKey();



           

        }
    }
}
