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
            IDroid[] droids = new IDroid[20];
            DroidCollection DroidCollector = new DroidCollection();

            int userChoice;
            int currentIndex = 0;

            userChoice = UserInterface.GetMenuChoice();

            while (userChoice != 3)
            {
                if (userChoice == 1)
                {
                    DroidCollector.AddDroid(droids, currentIndex);
                    currentIndex++;
                }
                else
                {
                    string outputString = "";
                    foreach (IDroid droid in droids)
                    {
                        if (droid != null)
                        {
                            outputString += droid.ToString();
                        }

                    }
                    Console.WriteLine(outputString);
                }

                userChoice = UserInterface.GetMenuChoice();

            }

            
        }
    }
}
