using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Textbox
    {
        public int padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }
        public Textbox()
        {

        }
        public void DisplayText()
        {
            Console.BackgroundColor = this.BackColor;
            Console.ForegroundColor = this.ForeColor;
            string TextTyped = new string(' ', this.padding) + this.Text + new string(' ', this.padding);
            Console.WriteLine(TextTyped);
        }
    }
}
