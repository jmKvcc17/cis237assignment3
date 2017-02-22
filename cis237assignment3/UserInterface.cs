﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    static class UserInterface
    {
        // Input for: material, model, color, numberOfLanguages (Protocol)
        // for utility: tool box, computer connection, arm (all bools)

        // Menu
        static public void DisplayMenu()
        {
            Console.WriteLine("This program allows you to add droids to a list.");
            Console.WriteLine("Option 1. Add droid to list");
            Console.WriteLine("Option 2. Display droid list");
            Console.WriteLine("Option 3. Exit program");
        }

        static public int GetMenuChoice()
        {
            string choice;

            UserInterface.DisplayMenu();
            Console.WriteLine("Enter menu choice: ");
            choice = Console.ReadLine();

            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.WriteLine("Enter menu choice: ");
                choice = Console.ReadLine();
            }

            return int.Parse(choice);
        }

        // Input
        static public string GetModel()
        {
            string Model;

            Console.WriteLine("There are 4 droid model types: Protocol, Utility, Astromech, and Janitor");
            Console.WriteLine("Enter:\n1. Protocol" + Environment.NewLine + "2. Utility"
                 + Environment.NewLine + "3. Astromech" + Environment.NewLine + "4. Janitor");

            Model = Console.ReadLine();
            while (Model != "1" && Model != "2" 
                && Model != "3" && Model != "4")
            {
                Console.WriteLine("Input Error. Try again.");
                Model = Console.ReadLine();
            }

            return Model;
        }

        static public string GetMaterial()
        {
            string Material;

            Console.WriteLine("Enter in material (carbonite, tanium, quadranium): ");
            Material = Console.ReadLine();

            while (Material != "carbonite" && Material != "tanium" && 
                Material != "quadranium")
            {
                Console.WriteLine("Error, enter in valid material");
                Console.WriteLine("Enter in material (carbonite, tanium, quadranium): ");
                Material = Console.ReadLine();
            }

            return Material;
        }

        static public string GetColor()
        {
            string Color;

            Console.WriteLine("Enter in the droid color (red, green, blue): ");
            Color = Console.ReadLine();

            return Color;
        }

        static public int GetNumOfLanguages() // **********
        {
            string NumberOfLanguages;
            int i = 0;
            bool notNum = false;

            Console.WriteLine("Enter in the number of languages the droid knows: ");
            NumberOfLanguages = Console.ReadLine();

            while (!notNum)
            {
                notNum = int.TryParse(NumberOfLanguages, out i);

                if (notNum)
                    i = int.Parse(NumberOfLanguages);
                else
                {
                    Console.WriteLine("Improper Input.");
                    Console.WriteLine("Enter in the number of languages the droid knows: ");
                    NumberOfLanguages = Console.ReadLine();
                }
                    
            }

            return i;
        }

        static public bool GetComputerConnection()
        {
            string Choice;

            Console.WriteLine("Do you want the droid to have a computer connection? (Y/n): ");
            Choice = Console.ReadLine();

            if (Choice == "Y")
                return true;
            else
                return false;

        }

        static public bool GetToolBox()
        {
            string toolBox;

            Console.WriteLine("Do you want the droid to have a tool box? (Y/n): ");
            toolBox = Console.ReadLine();

            if (toolBox == "Y")
                return true;
            else
                return false;
        }

        static public bool GetArm()
        {
            string Arm;

            Console.WriteLine("Do you want the droid to have an arm? (Y/n): ");
            Arm = Console.ReadLine();

            if (Arm == "Y")
                return true;
            else
                return false;
        }

        static public bool GetFireExtinquisher()
        {
            string FireExtinquisher;

            Console.WriteLine("Do you want the droid to have a fire extinquisher? (Y/n): ");
            FireExtinquisher = Console.ReadLine();

            if (FireExtinquisher == "Y")
                return true;
            else
                return false;
        }

        static public bool GetTrashCompactor()
        {
            string trashCompactor;

            Console.WriteLine("Do you want the droid to have a trash compactor? (Y/n): ");
            trashCompactor = Console.ReadLine();

            if (trashCompactor == "Y")
                return true;
            else
                return false;
        }

        static public bool GetVacuum()
        {
            string vacuum;

            Console.WriteLine("Do you want the droid to have a vacuum? (Y/n): ");
            vacuum = Console.ReadLine();

            if (vacuum == "Y")
                return true;
            else
                return false;
        }

        static public int GetNumOfShips() // **********
        {
            int NumberOfShips = 0;
            string hold;
            bool goodInput = false;

            Console.WriteLine("Enter in the number of ships: ");
            hold = Console.ReadLine();

            while (!goodInput)
            {
                goodInput = int.TryParse(hold, out NumberOfShips);

                if (goodInput)
                    NumberOfShips = int.Parse(hold);
                else
                {
                    Console.WriteLine("Input Error.");
                    Console.WriteLine("Enter in the number of ships: ");
                    hold = Console.ReadLine();
                }
            }

            return NumberOfShips;
        }

        static public void IndexError()
        {
            Console.WriteLine("No more droids can be stored.");
        }
    }
}
