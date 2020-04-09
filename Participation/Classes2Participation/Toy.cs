using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2Participation
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }
        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }
        public string GetAisle()
        {
            return Manufacturer.First().ToString().ToUpper();

        }
        public string GetAisle2()
        {
            Random rand = new Random();
            int randomnumber = rand.Next(1, 24);
            return randomnumber.ToString();
        }
    }
}
