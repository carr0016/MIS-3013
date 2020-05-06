using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticeRound
{
    class Program
    {
        static void Main(string[] args)
        {
            Carssssss car1 = new Carssssss();
            car1.Manufacturer = "Mercades";
            car1.Year = 2018;
            car1.Model = "Benz C-Class";
            Console.WriteLine(car1);
            

            Carssssss car2 = new Carssssss();
            car2.Manufacturer = "BMW";
            car2.Year = 2014;
            car2.Model = "xx";
            Console.WriteLine(car2);
          

            Carssssss car3 = new Carssssss();
            car3.Manufacturer = "Camero";
            car3.Year = 2010;
            car3.Model = "1LS";
            Console.WriteLine(car3);
            

            Console.ReadKey();

        }
    }
}
