using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 2 strings.
            var names = new List<string>() { "Ashlynn Dunbar", "Paige Anderson","Paige Johnson", "Kylee McKaughlin", "Hali'a Swartman-Hogan", "Sanaa Dotson", "Haley Sanchez", "Olivia Curtis", "Keyton Kinley", "Sarah Maras", "Abby Butler" , "Sarah Sanders", "Kira Morikawa", "Sabrina Simms", "Aysia Harty", "Brianna Kadiku", "Rylie Gregston" };
   
            foreach (string value in names)
            {
                Console.WriteLine("Name: " + value);
            }
            Console.ReadKey();
        }
    

        }
    }

