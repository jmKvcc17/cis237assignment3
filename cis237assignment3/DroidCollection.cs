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

        /*
        public DroidCollection(IDroid[] droidCollection, string Material, string Model, string Color,
            int NumberOfLanguages = 0, bool ToolBox = false, bool arm = false, 
            bool computerConnection = false)
        */

        // Methods 
        public void AddDroid(IDroid[] droids, int droidIndex)
        {
            // Get string input
            string model = UserInterface.GetModel();
            string material = UserInterface.GetMaterial();
            string color = UserInterface.GetColor();

            

            // Get int inputs
            if (model == "protocol")
            {
                int numberOfLanguages = UserInterface.GetNumOfLanguages();
                droids[droidIndex] = new Protocol(material, model, color, numberOfLanguages); // ****
            }
            else
            {
                // Get bool inputs
                bool arm = UserInterface.GetArm();
                bool computerConnection = UserInterface.GetComputerConnection();
                bool toolBox = UserInterface.GetToolBox();

                if (model == "utility")
                {
                    droids[droidIndex] = new Utility(material, model, color, toolBox,
                    computerConnection, arm);
                }
                if (model == "astromech")
                {
                    bool fireExtinquisher = UserInterface.GetFireExtinquisher();
                    int numberOfShips = UserInterface.GetNumOfShips();

                    droids[droidIndex] = new Astromech(material, model, color, toolBox, computerConnection, arm,
                    fireExtinquisher, numberOfShips);
                }
                else
                {
                    bool trashCompactor = UserInterface.GetTrashCompactor();
                    bool vacuum = UserInterface.GetVacuum();

                    droids[droidIndex] = new Janitor(material, model, color, toolBox,
                    computerConnection, arm, trashCompactor, vacuum);
                }
                
                
                
            }
                
            
         
            if (model == "astromech")
            {
                
            }  
            if (model == "janitor")
            {
                
            }
                
        }
    }
}
