using System;
using System.Collections.Generic;
using System.Text;

namespace TextBox
{
    public class TextBox
    {
        public int Padding { get; set; }
        public ConsoleColor BackColor { get; set; }
        public ConsoleColor ForeColor { get; set; }
        public string Text { get; set; }

        public TextBox()

        {
            Padding = 0;
            //BackColor=
            //ForeColor=
            Text = string.Empty;
        }
 
        public DisplayText()
        {

        }

    }
}
