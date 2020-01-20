using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class Frame : GuiObject
    {
        private char renderChar;
        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            this.renderChar = renderChar;
        }
        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Height; i++)
            {
                if (i == 0 || i == (Height-1))
                {
                    Console.SetCursorPosition(X, (Y +i));
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(renderChar);
                    }
                }
                else
                {
                    Console.SetCursorPosition(X, Y +i);
                    Console.WriteLine(renderChar);
                    Console.SetCursorPosition(X + (Width-1), Y + i);
                    Console.Write(renderChar);
                }
            }
        }
    }
}
