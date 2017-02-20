using System;
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

        // Input
        static public string GetModel()
        {
            string Model;

            Console.WriteLine("There are 4 droid model types: Protocol, Utility, Astromech, and Janitor");
            Console.WriteLine("Enter: 1. Protocol" + Environment.NewLine + "2. Utility"
                 + Environment.NewLine + "3. Astromech" + Environment.NewLine + "4. Janitor");

            Model = Console.ReadLine();
            while (Model != "1" || Model != "2" || Model != "3" || Model != "4")
            {
                Console.WriteLine("Input Error. Try again.");
                Model = Console.ReadLine();
            }

            return Model;
        }

        static public string GetMaterial()
        {
            string Material;

            Console.WriteLine("Enter in material: ");
            Material = Console.ReadLine();

            return Material;
        }

        static public string GetColor()
        {
            string Color;

            Console.WriteLine("Enter in the droid color: ");
            Color = Console.ReadLine();

            return Color;
        }

        static public int GetNumOfLanguages() // **********
        {
            int NumberOfLanguages;
            bool goodInput = false;

            Console.WriteLine("Enter in the number of languages the droid knows: ");

            while(!goodInput)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out NumberOfLanguages);
                    goodInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }


            return NumberOfLanguages;
        }

        static public bool GetComputerConnection()
        {
            bool Choice;

            Console.WriteLine("Do you want the droid to have a computer connection?");


        }
    }
}
