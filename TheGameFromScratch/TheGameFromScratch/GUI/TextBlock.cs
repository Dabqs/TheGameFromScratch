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
        public TextBlock(int x, int y, int width, List<string> textLines) : base(x, y, width, 0)
        {
            for (int i = 0; i < textLines.Count; i++)
            {
                this.textLines.Add(new TextLine(textLines[i], X, Y + i, Width));
            }
        }
        public override void Render()
        {
            foreach (TextLine textLine in textLines)
            {
                textLine.Render();
            }
        }
    }
}
