using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Rectangle rect1 = new Rectangle();
            rect1.Length = 8;
            rect1.Width = 10;


            Rectangle rect2 = new Rectangle();
            rect2.Width = 22;
            rect2.Length = 12;

            Console.WriteLine($"The area for the first rectangle is {rect1.CalculateArea()}");
            Console.WriteLine($"The perimeter for the first rectangle is {rect1.CalculatePerimeter()}");
            Console.WriteLine($"The area for the second rectangle is {rect2.CalculateArea()}");
            Console.WriteLine($"The perimeter for the second rectangle is {rect2.CalculateArea()}");


            Circle Circ1 = new Circle();
            Circ1.Radius = 4;

            Circle Circ2 = new Circle();
            Circ2.Radius = 44;

            Console.WriteLine($"The area for the first circle is {Circ1.CalculateArea()}");
            Console.WriteLine($"The perimeter for the first circle is {Circ1.CalculatePerimeter()}");
            Console.WriteLine($"The area for the second circle is {Circ2.CalculateArea()}");
            Console.WriteLine($"The perimeter for the second circle is {Circ2.CalculateArea()}");


            Console.ReadKey();
        }
        
                    

            


        }
    }
}
