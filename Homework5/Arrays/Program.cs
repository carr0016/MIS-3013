using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    //Riley Carr
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you want to store?");
                int namelength = Convert.ToInt32(Console.ReadLine());

            string[] firstname = new string[namelength];
            string[] lastname = new string[namelength];

            for (int i = 0; i < namelength; i++)
            {
                Console.WriteLine($"Please enter first name of Student #{i + 1}");
                string firstnames = Console.ReadLine();
                firstname[i] = firstnames;

                Console.WriteLine($"Please enter last name of Student#{i + 1}");
                string lastnames = Console.ReadLine();
                lastname[i] = lastnames;

            }

            int index = 0;
            while (index < namelength)
            {
                Console.WriteLine($"{lastname[index]}, {firstname[index]}");
                index++;
            }
            Console.ReadKey();

           

        }
    }
}
