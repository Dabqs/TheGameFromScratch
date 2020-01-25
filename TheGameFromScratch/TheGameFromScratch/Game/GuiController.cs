using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGameFromScratch.GUI;

namespace TheGameFromScratch.Game
{
    class GuiController
    {
        private GameWindow gameWindow;
        private CreditWindow creditWindow;
        private GameController gameController = new GameController();


        public void ShowMenu()
        {
            gameWindow = new GameWindow(0, 0, 120, 30, '%');
            Console.Clear();
            gameWindow.Render();
            ActivateMainMenu();

        }
        public void ShowCreditWindow()
        {
            creditWindow = new CreditWindow(28, 10, 60, 18, '%');
            creditWindow.Render();
            ActivateCreditMenu();

        }
        public void ActivateCreditMenu()
        {
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    if (pressedChar.Key == ConsoleKey.Enter || pressedChar.Key== ConsoleKey.Escape)
                    {
                        ShowMenu();
                    }
                    
                }
            } while (true);
        }
        public void ActivateMainMenu()
        {
            bool shouldRender = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Enter:
                            shouldRender = false;
                            switch (gameWindow.GetActiveButtonIndex())
                            {
                                case 0:
                                    gameController.InitGame();
                                    gameController.StartGame();
                                    break;
                                case 1:
                                    ShowCreditWindow();
                                    break;
                                case 2:
                                    Environment.Exit(0);
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.Clear();
                            ChangeActiveButton(gameWindow.GetActiveButtonIndex()-1);
                            gameWindow.Render();
                            break;
                        case ConsoleKey.RightArrow:
                            Console.Clear();
                            ChangeActiveButton(gameWindow.GetActiveButtonIndex() + 1);
                            gameWindow.Render();
                            break;
                        default:
                            break;
                    }
                }
            } while (shouldRender);
           
        }
        public void ChangeActiveButton(int targetButtonIndex)
        {
            if (targetButtonIndex >= 0 && targetButtonIndex < gameWindow.menuButtons.Count())
            {
                foreach (Button button in gameWindow.menuButtons)
                {
                    button.Deactivate();
                }
                gameWindow.menuButtons[targetButtonIndex].SetActive();
            }
        }
    }
}
