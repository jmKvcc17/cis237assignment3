using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
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

            if (droidIndex < droids.Length)
            {
                // Get int inputs
                if (model == "1")
                {
                    int numberOfLanguages = UserInterface.GetNumOfLanguages();
                    droids[droidIndex] = new Protocol(material, "Protocol", color, numberOfLanguages); // ****
                }
                else
                {
                    // Get bool inputs
                    bool arm = UserInterface.GetArm();
                    bool computerConnection = UserInterface.GetComputerConnection();
                    bool toolBox = UserInterface.GetToolBox();

                    if (model == "2")
                    {
                        droids[droidIndex] = new Utility(material, "Utility", color, toolBox,
                        computerConnection, arm);
                    }
                    if (model == "3")
                    {
                        bool fireExtinquisher = UserInterface.GetFireExtinquisher();
                        int numberOfShips = UserInterface.GetNumOfShips();

                        droids[droidIndex] = new Astromech(material, "Astromech", color, toolBox, computerConnection, arm,
                        fireExtinquisher, numberOfShips);
                    }
                    if (model == "4")
                    {
                        bool trashCompactor = UserInterface.GetTrashCompactor();
                        bool vacuum = UserInterface.GetVacuum();

                        droids[droidIndex] = new Janitor(material, "Janitor", color, toolBox,
                        computerConnection, arm, trashCompactor, vacuum);
                    }
                }
            }
            else
            {
                UserInterface.IndexError();
            }
        }
    }
}
