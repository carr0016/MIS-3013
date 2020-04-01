using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        { //worked with Elizabeth Sparks and Dee Fogel
            Textbox Textbox1 = new Textbox();
            Textbox1.BackColor = ConsoleColor.White;
            Textbox1.ForeColor = ConsoleColor.Gray;
            Textbox1.padding = 2;
            Textbox1.Text = "For the first textbox";

            Textbox Textbox2 = new Textbox();
            Textbox2.BackColor = ConsoleColor.Black;
            Textbox2.ForeColor = ConsoleColor.Yellow;
            Textbox2.padding = 4;
            Textbox2.Text = "For the second textbox";

            Console.ReadKey();
        }
    }
}
