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
        public bool IsActive { get; private set; }
        private TextLine textLine;
        public string Label
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }
        private string label = string.Empty;
        public Button(int x, int y, int width, int height, string buttonCaption) : base(x, y, width, height)
        {
            textLine = new TextLine(buttonCaption, x + 1, y + 1 + ((height - 2) / 2), width - 2);
            IsActive = false;
            activeFrame = new Frame(x, y, width, height, '#');
            notActiveFrame = new Frame(x, y, width, height, '+');
        }
        public override void Render()
        {
            if (IsActive)
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
            IsActive = true;
        }
        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
