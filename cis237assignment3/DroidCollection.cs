using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    // Adds the droids to the droids array
    class DroidCollection
    {
        public DroidCollection() { }

        // Methods 
        public void AddDroid(IDroid[] droids, int droidIndex)
        {
            // Get string input
            string model = UserInterface.GetModel();
            string material = UserInterface.GetMaterial();
            string color = UserInterface.GetColor();

            // If the droidIndex is still within the range of the array
            if (droidIndex < droids.Length - 1)
            {
                // If it is a protocol droid
                if (model == "1")
                {
                    int numberOfLanguages = UserInterface.GetNumOfLanguages();
                    droids[droidIndex] = new Protocol(material, "Protocol", color, numberOfLanguages); // ****
                }
                else // If it is a different droid
                {
                    // Get bool inputs specific to utility droids
                    bool arm = UserInterface.GetArm();
                    bool computerConnection = UserInterface.GetComputerConnection();
                    bool toolBox = UserInterface.GetToolBox();

                    if (model == "2") // if it is a utility droid
                    {
                        droids[droidIndex] = new Utility(material, "Utility", color, toolBox,
                        computerConnection, arm);
                    }
                    if (model == "3") // if it is an astromech droid
                    {
                        // Get inputs specific to astromech droids
                        bool fireExtinquisher = UserInterface.GetFireExtinquisher();
                        int numberOfShips = UserInterface.GetNumOfShips();

                        droids[droidIndex] = new Astromech(material, "Astromech", color, toolBox, computerConnection, arm,
                        fireExtinquisher, numberOfShips);
                    }
                    if (model == "4") // if it is a janitor droid
                    {
                        // Get inputs specific to Janitor droids
                        bool trashCompactor = UserInterface.GetTrashCompactor();
                        bool vacuum = UserInterface.GetVacuum();

                        droids[droidIndex] = new Janitor(material, "Janitor", color, toolBox,
                        computerConnection, arm, trashCompactor, vacuum);
                    }
                }
            }
            else
            {
                UserInterface.IndexError(); // Display error saying that the array is full
            }
        }
    }
}
