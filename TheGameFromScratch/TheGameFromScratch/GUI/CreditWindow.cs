using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameFromScratch.GUI
{
    class CreditWindow : Window
    {
        private int x = 28;
        private int y = 10;
        private int width = 60;
        private int height = 18;

        private Button backButton;
        private TextBlock creditTextBlock;
        public CreditWindow(int x, int y, int width, int height, char borderChar) : base(x, y, width, height, '@')
        {
            backButton = new Button(this.x +20, this.y +14, 18, 3, "Back");
            backButton.SetActive();
            creditTextBlock = new TextBlock(this.x +1, this.y +1 , this.width -1,
                new List<string> { 
                String.Empty,
                "Game design:",
                "Mantas Dapkus",
                String.Empty,
                "Programuotojas:",
                "Mantas Dapkus",
                String.Empty,
                "\'Art\':",
                "Mantas Dapkus",
                String.Empty,
                "Marketingas:",
                "Mantas Dapkus",
                String.Empty});
        }
        public void Render()
            {

            }
        }
    }
