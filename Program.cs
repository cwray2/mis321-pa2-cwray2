using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System;
using static System.Console;

namespace mis321_pa2_cwray2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var playerOne = PlayerSelection(); //write player selection class
            // var PlayerTwo = PlayerSelection();
            // var DavyJones = new DavyJones(){Name="Davy Jones"};
            // var JackSparrow = new JackSparrow(){Name="Jack Sparrow"};
            // var WillTurner = new WillTurner(){Name="Davy Jones"};
            // bool displayMenu = true;
            // while (displayMenu)
            // {
            //     displayMenu = Menu();
            // }
            Menu();
            WriteLine();
            WriteLine();

            var playerOne = new DavyJones();
            var playerTwo = new JackSparrow();
            var playerThree = new WillTurner();

            WriteLine(playerOne.Name);
            WriteLine(playerOne.MaxPower);
            WriteLine(playerOne.Health);
            playerOne.ab.Attack();
            WriteLine(playerOne.AttackPower);
            WriteLine(playerOne.DefensePower);
            //Console.WriteLine(playerOne.Attack());
            WriteLine("\n\n" + playerTwo.Name);
            WriteLine(playerTwo.MaxPower);
            WriteLine(playerTwo.Health);
            playerTwo.ab.Attack();
            WriteLine(playerTwo.AttackPower);
            WriteLine(playerTwo.DefensePower);
            WriteLine("\n\n" + playerThree.Name);
            WriteLine(playerThree.MaxPower);
            WriteLine(playerThree.Health);
            playerThree.ab.Attack();
            WriteLine(playerThree.AttackPower);
            WriteLine(playerThree.DefensePower);

        }

        static void Menu() {
            int menuChoice = GetMenuChoice();
            while (menuChoice != 4) {
                while (menuChoice != 1 && menuChoice != 2 && menuChoice != 3) {
                    Console.WriteLine("Invalid Selection");
                    menuChoice = GetMenuChoice();
                }

                if (menuChoice == 1) {
                    HoldYourHorses();
                }
                else if (menuChoice == 2) {
                    HoldYourHorses();
                }
                else if (menuChoice == 3) {
                    HoldYourHorses();
                }
                menuChoice = GetMenuChoice();
            }
        }

        static int GetMenuChoice() {  //method to get the users choice for the menu
            //Console.Clear();
            Console.WriteLine("Welcome to  Big Al's Playlist! \n1)Show All Songs \n2)Add a Song \n3)Delete a Song \n4)Exit");
            return int.Parse(Console.ReadLine());
        }

        static void HoldYourHorses() {  //method to prevent the program from immediately looping back to the menu
            Console.WriteLine("Press any key to continue to the menu: ");
            Console.ReadKey();
            Console.Clear();
        }

        // private static bool Menu() {
        //     Console.WriteLine($"1)Loop \n2)End");
        //     int input = int.Parse(Console.ReadLine());
        //     if (input==2) {
        //         return false;
        //     }
        //     else {
        //         return true;
        //     }
        // }
    }
}
