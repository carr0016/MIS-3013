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

            string[] FirstName = new string[1];
            string[] LastName = new string[1];

            for (int i = 0; i < CourseName.Length; i++)
            {
                Console.WriteLine("Please input a course name");
                CourseName[i] = Console.ReadLine();
                Console.WriteLine("Please input one course number");
                CourseNumber[i] = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < CourseNumber.Length; i++)
            {
                Console.WriteLine(CourseName[i] + CourseNumber[i]);
            }

           

            Console.ReadKey();
        }
    }
}
