using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            IDroid[] droids = new IDroid[20]; // stores the droids
            DroidCollection DroidCollector = new DroidCollection(); // used to add new droids to the array

            int userChoice; // holds the menu choice
            int currentIndex = 0; // holds what index the array is at
                
            // Get the menu choice
            userChoice = UserInterface.GetMenuChoice();
            Console.WriteLine();

            while (userChoice != 4) // while the user doesn't want to exit
            {
                if (userChoice == 1) // if they want to add
                {
                    // pass over droids to the droidCollector class
                    DroidCollector.AddDroid(droids, currentIndex);
                    currentIndex++; // afterwards increment the new index
                }
                if (userChoice == 2) // if they want to print
                {
                    string outputString = ""; // create a string to hold the droids
                    foreach (IDroid droid in droids) // for each droid in the array
                    {
                        if (droid != null) // if the index is not null
                        {
                            outputString += droid.ToString() +  // add the droid to the outputString
                                Environment.NewLine + Environment.NewLine;
                        }

                    }
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(outputString); // write the output string once all are added
                    Console.ResetColor();
                }
                if (userChoice == 3) // if 3, print the console
                    Console.Clear();

                userChoice = UserInterface.GetMenuChoice(); // get the user's choice
            }

            
        }
    }
}
