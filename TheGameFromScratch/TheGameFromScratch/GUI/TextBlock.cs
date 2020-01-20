using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class TextBlock : GuiObject
    {
        private readonly List<TextLine> textLines = new List<TextLine>();
        public TextBlock(int x, int y, int width, List<string> textLines ) : base(x, y, width, 0)
        {
            foreach (string textLine in textLines)
            {
                this.textLines.Add(new TextLine(textLine, X, Y, Width));
            }
        }
        public void Render()
        {

        }
    }
}
