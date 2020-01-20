using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private Frame notActiveFrame;
        private bool isActive;
        private TextLine textLine;
        public Button(int x, int y, int width, int height, string buttonCaption) : base(x, y, width, height)
        {
            textLine = new TextLine(buttonCaption, X, Y, Width);
            isActive = false;
            activeFrame = new Frame(X, Y, Width, Height, '+');
            notActiveFrame = new Frame(X, Y, Width, Height, '#');
        }
        public void Render()
        {

        }
        public void SetActive()
        {
            isActive = true;
        }
    }
}
