using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System;
using mis321_pa2_cwray2.General;
using static System.Console;

namespace mis321_pa2_cwray2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string prompt = "Make your selection.";
            // string[] options = {"Multiplayer  ", "Single-player", "Exit         "};
            Game gamePlay = Utils.NewGame();
            Menu mainMenu = Utils.MainMenu();
            int selectedIndex = mainMenu.Run();
            while (selectedIndex != 1)
            {
                if (selectedIndex == 0)
                {
                    // System.Console.WriteLine("Option 1");
                    // ReadKey();
                    gamePlay.TwoPlayers();
                    // Menu twoPlayers = Utils.GameMenu();
                    //Game multiplayer = new Game();
                }
                selectedIndex = mainMenu.Run();
                //yuh
            }
            
            //Menu(playerOne, playerTwo);

        }
    }
}
