using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.Game;
using TheGameFromScratch.GUI;
using TheGameFromScratch.Units;

namespace TheGameFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GuiController guiController = new GuiController();
            guiController.ShowMenu();
        }
    }
}
