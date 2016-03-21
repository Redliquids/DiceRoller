using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Roller.Models;

namespace Roller.Models
{
    class Menu
    {

        List<int> rollList = new List<int>();
        List<int> diceSidesList = new List<int>();


        public void testshowresultfuction()
        {
            for (int i = 0; i < rollList.Count; i++)
            {
                Console.WriteLine("Dice Sides: " + diceSidesList[i] + " ---------- Dice Result: " + rollList[i]);
            }
        }


        public void Entered_Menu ()
        {


            Console.Clear();
            Console.WriteLine("You have entered Menu.cs");
            Console.WriteLine();

            Console.WriteLine("1. Roll Dice");
            Console.WriteLine("2. List Dice Rolls");
            Console.WriteLine("0. To Quit");

            Functions function_instance = new Functions();

            char choice = Console.ReadKey().KeyChar;
            Console.Clear();

            switch (choice)
            {
                case '1':

                    Console.Write("Enter max roll value: ");

                    string userInput = Console.ReadLine();
                    int maxRollNr = 0;

                    try
                    {
                        maxRollNr = int.Parse(userInput);
                    }
                    catch (FormatException)
                    {
                        Entered_Menu();
                    }

                    diceSidesList.Add(maxRollNr);
                    int DiceRoll = function_instance.RollFunction(maxRollNr);

                    rollList.Add(DiceRoll);

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    // Console.ReadKey();
                    Console.Clear();
                    Entered_Menu();
                    break;

                case '2':
                    Console.Clear();

                    testshowresultfuction();
                    Console.WriteLine();
                    Console.WriteLine("No More Rolls To Display.");
                    Console.WriteLine("Press Any Key To Continue.");
                    Console.ReadKey();
                    Entered_Menu();

                    break;

                case '0':
                    System.Environment.Exit(0);
                    break;

                default:
                    Entered_Menu();
                    break;
            }



        }
    }
}