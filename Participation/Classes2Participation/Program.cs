using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            ToyBox ToyBox1 = new ToyBox();
            Toy Toy1 = new Toy();

            Toy1.Manufacturer = "Bratz";
            Toy1.Name = "Chloe";
            Toy1.Price = 12.99;
            Toy1.GetAisle();
            Toy1.GetAisle2();

            Console.WriteLine($"The manufacturer of Toy 1 is {Toy1.Manufacturer}");
            Console.WriteLine($"The name of Toy 1 is {Toy1.Name}");
            Console.WriteLine($"The price of Toy 1 is {Toy1.Price}");
            Console.WriteLine($"Toy 1 is found on Aisle {Toy1.GetAisle()} {Toy.GetAisle2()}");

            Console.ReadKey();
        }
    }
}
