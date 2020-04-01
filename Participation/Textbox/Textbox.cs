using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTextBox
{
    class Textbox
    {
        public int Padding { get; set; }
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
            string TextTyped = new string(' ', this.Padding) + this.Text + new string(' ', this.Padding);
            Console.WriteLine(TextTyped);

        }
    }
}
