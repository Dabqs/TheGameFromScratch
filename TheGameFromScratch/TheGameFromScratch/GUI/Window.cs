using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class Window : GuiObject
    {
        protected Frame border;
        public Window(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            border = new Frame(x, y, width, height, borderChar);
        }
        public override void Render()
        {
            border.Render();
        }
    }
}
