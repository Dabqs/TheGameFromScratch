using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class GuiObject
    {
        protected int Height;
        protected int Width;
        protected int X;
        protected int Y;

        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
