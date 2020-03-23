using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an animal (Cow, Rooster, Pig) ");
            string animal = Console.ReadLine();
            string sound = "";
            sound = Speak(animal);

            Console.WriteLine(sound);
            Console.ReadKey();
        }
        static string Speak(string animal)
        {
            string sound = "";
            if (animal == "Cow")
            {
                sound = "Moo";
              
            }
            if (animal == "Rooster")
            {
                sound = "Cockadoodledoo";
            }
             if (animal == "Pig")
            {
                sound = "Oink";
            }
            return sound;
        }




        
    }
}

