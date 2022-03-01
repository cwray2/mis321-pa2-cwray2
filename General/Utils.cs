using System;
using mis321_pa2_cwray2.General;
using static System.Console;

namespace mis321_pa2_cwray2
{
    public static class Utils
    {
        //Allows player to choose their character
        public static Character GetCharChoice(string player)
        {
            Menu characterMenu = Utils.NewMenu($"{player} choose your character", new string[] { "Jack Sparrow", "Davy Jones", "Will Turner" });

            int charChoice = characterMenu.Run();

            if (charChoice == 1)
            {
                return new JackSparrow();
            }
            else if (charChoice == 2)
            {
                return new DavyJones();
            }
            else
            {
                return new WillTurner();
            }
        }

        public static Character NewJack()
        {
            return new JackSparrow();
        }

        public static Character NewDavy()
        {
            return new DavyJones();
        }

        public static Character NewWill()
        {
            return new WillTurner();
        }

        public static Game NewGame()
        {
            return new Game();
        }

        public static Menu NewMenu(string prompt, string[] options)
        {
            return new Menu(prompt, options);
        }

        public static Menu GameMenu()
        {
            string prompt = " It's your turn! What will you do?";
            string[] options = { "Attack", "Defend", "Heal  " };
            return new Menu(prompt, options);
        }

        public static Menu MainMenu()
        {
            string prompt = "Make your selection using the arrow keys";
            string[] options = { "Multiplayer  ", "Exit         " };
            return new Menu(prompt, options);
        }

        public static int RandomGen(int x, int y)
        {
            Random r = new Random();
            return r.Next(x, y);
        }
    }
}