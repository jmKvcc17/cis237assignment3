using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    // Janitor class inherits from utility class
    class Janitor : Utility
    {
        

        // Variables
        private bool trashCompactor;
        private bool vacuum;

        // Constructors
        public Janitor() { }

        // Constructor that inherits from base variables from the base class
        public Janitor(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection,
            bool Arm, bool TrashCompactor, bool Vacuum) : base(Material, Model, Color, ToolBox, ComputerConnection,
                Arm)
        {
            trashCompactor = TrashCompactor;
            vacuum = Vacuum;
        }

        // Methods
        // Overrides ToString to display variables for Janitor
        public override string ToString()
        {
            return base.ToString() + "Trash Compactor: " + trashCompactor.ToString() + Environment.NewLine + 
                 "Vacuum: " + vacuum.ToString() + Environment.NewLine + Environment.NewLine;
        }

        public override void CalculateTotalCost()
        {
            // Reset utility and total costs
            base.UtilityCost = 0;
            base.totalCost = 0;

            CalculateUtilityCost(); // Calculate the utility cost

            // if there's a trash compactor or vacuum, add 
            // their respective prices
            if (trashCompactor)
                base.totalCost += 100m;
            if (vacuum)
                base.totalCost += 200m;

            base.totalCost += base.baseCost + base.UtilityCost; // Calculate the total cost
        }
    }
}
