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
            textLine = new TextLine(buttonCaption, x +1, y +1 +((height-2)/2), width -2);
            isActive = false;
            activeFrame = new Frame(x, y, width, height, '#');
            notActiveFrame = new Frame(x, y, width, height, '+');
        }
        public override void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }

            textLine.Render();
        }
        public void SetActive()
        {
            isActive = true;
        }
    }
}
