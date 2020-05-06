using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPracticeRound
{
    class Carssssss
    {
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public Carssssss()
        {
            Manufacturer = "";
            Year = 0;
            Model = "";
        }
        public Carssssss(string manufacturer, int year, string model)
        {
            Manufacturer = manufacturer;
            Year = year;
            Model = model;

        }
        public override string ToString()
        {
            return Year + " " + Manufacturer + " " + Model;
        }
    }
}
