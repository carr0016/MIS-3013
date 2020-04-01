using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Textbox Textbox1 = new Textbox();
            Textbox1.backcolor = ConsoleColor.White;
            Textbox1.ForeColor = ConsoleColor.Gray;
            Textbox1.padding = 2;
            Textbox1.text = "This is for the first text box";

            Textbox Textbox2 = new Textbox();
            Textbox2.backcolor = ConsoleColor.Yellow;
            Textbox2.ForeColor = ConsoleColor.Black;
            Textbox2.padding = 4;
            Textbox2.text = "This is for the second text box";

            Console.ReadKey();

        }
    }
}
