using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        //Riley Carr
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> fruit = new Dictionary<string, List<string>>();
           fruit.Add("Fruits", new List<string>());
            fruit["Fruits"].Add("Apple");
            fruit["Fruits"].Add("Banana");
            fruit["Fruits"].Add("Watermelon");

            Dictionary<string, List<string>> veg = new Dictionary<string, List<string>>();
            veg.Add("Vegetables", new List<string>());
            veg["Vegetables"].Add("Carrots");
            veg["Vegetables"].Add("Lettuce");
            veg["Vegetables"].Add("Cucumber");


            Dictionary<string, List<string>> chip = new Dictionary<string, List<string>>();
            chip.Add("Chips", new List<string>());
            chip["Chips"].Add("Cheetos");
            chip["Chips"].Add("Lays");
            chip["Chips"].Add("Ruffles");

            Console.WriteLine("Would you like to add a new category or a new food?");
            string answer = Console.ReadLine();
            if (answer == "new category")
            {
                Console.WriteLine("What category would you like to add ?");
            }
            else if (answer == "new food")
            {
                Console.WriteLine("What category would you like to add");
                string catanswer = Console.ReadLine();
                if (catanswer == "Fruits")
                {
                    Console.WriteLine("what fruit");
                    string fruitanswer = Console.ReadKey();
                    fruit["Fruits"].Add(fruitanswer);
                }
                if (catanswer == "Vegetables")
                {
                    Console.WriteLine("what vegetable");
                    string veganswer = Console.ReadKey();
                    fruit["Vegetables"].Add(veganswer);
                }
                else if (catanswer == "Chips")
                {
                    Console.WriteLine("What chip?");
                    string chipanswer = Console.ReadLine();
                    chip["Chips"].Add("chipanswer");
                }
            }
            

            Console.WriteLine($"Fruits: Apple, Banana, Watermelon ");
            Console.WriteLine("Vegetables: Carrots, Lettuce, Cucumber");
            Console.WriteLine("Chips: Cheetos, Lays, Ruffles");

            Console.ReadKey();

        }

    }
        }
    

