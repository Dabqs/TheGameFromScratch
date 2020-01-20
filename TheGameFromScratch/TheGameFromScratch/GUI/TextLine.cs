using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class TextLine : GuiObject
    {
        private readonly string data;
        public TextLine(string data, int x, int y, int width) : base(x, y, width, 0)
        {
            this.data = data;
        }
        public void Render()
        {
            Console.SetCursorPosition(X, Y);

            if (Width > data.Length)
            {
                int offset = (Width - data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                if (i <= Width)
                {
                    Console.Write(data[i]);
                }
            }
        }
    }
}
