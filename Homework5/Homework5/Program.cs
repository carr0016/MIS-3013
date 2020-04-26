using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Directory = new Dictionary<string, int>();
            Console.WriteLine("Would you like to add a new category");
            string answer = Console.ReadLine();
           if (answer == "Yes")
            {
                Console.WriteLine("Enter the Name ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Age ");
                int Age = Convert.ToInt32(Console.ReadLine());
                Directory.Add(Name, Age);
            }
            Console.WriteLine("Press key to display the contents of your dictionary..");
            Console.ReadLine();
            foreach (var item in Directory)
            {
                Console.WriteLine("Name : " + item.Key);
                Console.WriteLine("Age : " + item.Value);
            }
            Console.ReadLine();

            Console.ReadKey();
        }

    }
        }
    

