using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class CreditWindow : Window
    {
        private Button backButton;
        private TextBlock creditTextBlock;
        public CreditWindow(int x, int y, int width, int height, char borderChar) : base(x, y, width, height, borderChar)
        {
            backButton = new Button(X, Y, Width, Height, "Back");
            creditTextBlock = new TextBlock(X, Y, Width, new List<string> { "Mantas", "Dapkus" });
        }
        public void Render()
        {

        }
    }
}
