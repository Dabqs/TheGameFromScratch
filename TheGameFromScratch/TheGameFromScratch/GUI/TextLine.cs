using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class TextLine : GuiObject
    {
        public string Label
        {
            get { return label; }
            set
            {
                label = value ;
                Render();
            }
        }
        private string label;
        public TextLine(string data, int x, int y, int width) : base(x, y, width, 0)
        {
            Label = data;
        }
        public override void Render()
        {
            Console.SetCursorPosition(X, Y);

            if (Width > Label.Length)
            {
                int offset = (Width - Label.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            for (int i = 0; i < Label.Length; i++)
            {
                if (i <= Width)
                {
                    Console.Write(Label[i]);
                }
            }
        }
    }
}
