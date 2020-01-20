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

        }
    }
}
