using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of int with a size of 3
            int[] studentIds = new int[3];
            string[] studentNames = { "Adam", "Katie", "Micah" };  // these two arays are parallel, values at the same INDEX correlate to echother

            //[0][1][2]
            // ["Adam"] ["Katie"] ["Micah"]
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            // INDEX OUT OF RANGE BECAUSE WE ONLY HAVE SPACE FOR 3 VALUES -- studentIds[3] = 4;

            for (int i = 0; i < studentIds.Length; i++) // could also do studentNames.Length as they are Parallel
            {
                Console.WriteLine($"Student with ID {studentIds[i]} has a name of {studentNames[i]}");
            }

            //do same thing but with lists

            List<int> studIDs = new List<int>();
            studIds.Add(4);
            studIds.Add(5);
            studIds.Add(6);
            List<string> studNames = new List<string>();
            //studNames.Add("Lakin");
            //studNames.Add("Grant");
            //studNames.Add("Eric");

            for (int i = 0; i < studIDs.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIDs[i]}  has a name of {studNames[i]}");
            }

            //Combine array data and list data into a dictionary
            Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(1, "Adam");
            for (int i = 0; i < studentIds.Length; i++) // could also do studentNames.Length as they are Parallel
            {
                if (students.ContainsKey(studentIds[i]) == false)
                {
                    students.Add(studentIds[i], studentNames[i]);

                }

                if (students.ContainsKey(studentIds[i]) == false)
                {
                        students.Add(studIds[i], studentNames[i]);
                    }
                
           

            }
            Console.WriteLine("MADE IT THRU ALIVE");
            Console.ReadKey();
        }
    }
}
