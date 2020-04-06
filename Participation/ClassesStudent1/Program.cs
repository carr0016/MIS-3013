using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudent1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student();
            Student1.FirstName = "Riley";
            Student1.LastName = "Carr";

            Student1.CourseNames.Add("MIS3013");
            Student1.CourseGrades.Add("A");
            Student1.CalculateGPA();


            Console.ReadKey();

        }
    }
}
