using System;
using static System.Console;
using mis321_pa2_cwray2.General;
namespace mis321_pa2_cwray2
{
    public class Game
    {
        public void TwoPlayers()
        {
            //instantiate new menu
            Menu twoPlayerMenu = Utils.GameMenu();

            Character playerOne = Utils.GetCharChoice("Player One");
            Console.WriteLine($"{playerOne.MaxPower} {playerOne.AttackPower} {playerOne.DefensePower}");
            ReadKey();
            Character playerTwo = Utils.GetCharChoice("Player Two");
            Console.WriteLine($"{playerTwo.MaxPower} {playerTwo.AttackPower} {playerTwo.DefensePower}");

            //randomize which player has the first turn
            bool firstPlayer = WhoGoesFirst();
            
            //the run method returns curIndex as an int
            int selectedIndex;

            //while loop to contain the basic gameplay
            while (playerOne.Health > 0 && playerTwo.Health > 0)
            {
                if (firstPlayer == true)
                {
                    Console.WriteLine($"Player One: press any key to continue");
                    ReadKey();
                    selectedIndex = twoPlayerMenu.Run();
                    PlayerTurn(playerOne, playerTwo, selectedIndex);
                    System.Console.WriteLine(playerTwo.Health);//
                    DisplayStats(playerOne, playerTwo);
                    ReadKey();
                    firstPlayer = false;
                    //set firstPlayer to false
                }
                else
                {
                    if (playerOne.Health > 0)
                    {
                        Console.WriteLine($"Player Two: press any key to continue");
                        ReadKey();
                        selectedIndex = twoPlayerMenu.Run();
                        PlayerTurn(playerTwo, playerOne, selectedIndex);
                        System.Console.WriteLine(playerOne.Health);//
                        DisplayStats(playerOne, playerTwo);
                        ReadKey();
                        firstPlayer = true;
                    }
                    //set firstPlayer to false
                }
            }
        }

        public static void PlayerTurn(Character curPlayer, Character enemyPlayer, int selectedIndex)
        {
            if (selectedIndex == 0)
            {
                curPlayer.ab.Attack();
                enemyPlayer.TakeDamage(curPlayer);
            }
            else if (selectedIndex == 1)
            {
                curPlayer.db.Defend();
            }
            else
            {
                curPlayer.Heal();
            }
            //return curPlayer.Health;
        }

        public static bool WhoGoesFirst()
        {
            int i = Utils.RandomGen(0, 100);
            if (i <= 49)
            {
                WriteLine("Player 1 goes first!");
                ReadKey();//
                //threading.sleep here
                return true;
            }
            else
            {
                WriteLine("Player 2 goes first!");
                ReadKey();//
                //threading.sleep here
                return false;
            }
        }

        public static void DisplayStats(Character playerOne, Character playerTwo)
        {
            Console.WriteLine($"Player One: health({playerOne.Health})");
            Console.WriteLine($"Player Two: health({playerTwo.Health})");
        }
    }
}