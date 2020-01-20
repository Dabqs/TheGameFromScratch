using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class Window : GuiObject
    {
        private Frame border;
        public Window(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            border = new Frame(X, Y, Width, Height, borderChar);
        }
        public void Render()
        {

        }
    }
}
