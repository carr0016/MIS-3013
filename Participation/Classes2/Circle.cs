using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Circle
    {
        public double Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public double CalculateArea()
        {
            const double PI = 3.1415926535897931;
            return PI * (Radius*Radius);
        }
        public double CalculatePerimeter()
        {
            const double PI = 3.1415926535897931;
            return (2 * PI) * Radius;
        }




    }
}
