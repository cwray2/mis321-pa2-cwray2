using System;

namespace mis321_pa2_cwray2.General
{
    public class Menu
    {
        private int curIndex;
        private string[] MenuOptions;
        private string MenuPrompt;

        public Menu(string prompt, string[] options)
        {
            MenuPrompt = prompt;
            MenuOptions = options;
            curIndex = 0;
        }

        public void Display() {
            Console.WriteLine(MenuPrompt);

            for (var i = 0; i < MenuOptions.Length; i++)
            {
                string curOption = MenuOptions[i];
                string prefix;
                if (i == curIndex)
                {
                    prefix = "=>";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "  ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix} {curOption}");
                Console.ResetColor();
            }
        }

        public int Run() {
            ConsoleKey userinput;
            do
            {
                Console.Clear();
                Display();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                userinput = keyInfo.Key;

                if (userinput == ConsoleKey.UpArrow || userinput == ConsoleKey.LeftArrow)
                {
                    curIndex--;
                    if (curIndex == -1)
                    {
                        curIndex = MenuOptions.Length - 1;
                    }
                }
                else if(userinput == ConsoleKey.DownArrow || userinput == ConsoleKey.RightArrow)
                {
                    curIndex++;
                    if (curIndex == MenuOptions.Length)
                    {
                        curIndex = 0;
                    }
                }
            } while (userinput != ConsoleKey.Enter);

            return curIndex;
        
        }
    }
}