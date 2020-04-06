using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesStudent1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> CourseNames { get; set; }
        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = " ";
            LastName = " ";
        }

        public Student(string First, string Second)
        {
            First = FirstName;
            Second = LastName;
        }

        public double CalculateGPA()
        {
            double points = 0;
            double Totalpoints = 0;

            foreach (var Grade in CourseGrades)
            {
                if (Grade == "A")
                {
                    points = 4.00;
                }
                else if (Grade == "B")
                {
                    points = 3.00;
                }
                else if (Grade == "C")
                {
                    points = 2.00;
                }
                else if (Grade == "D")
                {
                    points = 1.00;
                }
                else
                {
                    points = 0.00;
                }

                Totalpoints += points;
            }

             double GPA = Totalpoints / CourseNames.Count;
            Console.WriteLine($"Your GPA is {GPA}");

            return GPA;
               
            }
        }

    }
}
