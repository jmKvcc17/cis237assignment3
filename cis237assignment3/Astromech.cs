using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        // PRICES: numberOfShips: number input * 500m
        // Variables
        private bool fireExtinquisher;
        private int numberShips;
        private const decimal COST_PER_SHIP = 500m;

        // Constructors 
        public Astromech() { }

        public Astromech(string Material, string Model, string Color, 
            bool ToolBox, bool ComputerConnection,
            bool Arm, bool FireExtinquisher, int NumberOfShips) : 
            base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            fireExtinquisher = FireExtinquisher;
            numberShips = NumberOfShips;
        }

        // Methods
        // Print out the variables and cost for the astromech droid
        public override string ToString()
        {
            return base.ToString() + "Fire Extinquisher: " + fireExtinquisher.ToString() + Environment.NewLine +
                "Number of ships: " + numberShips.ToString(); ;
        }

        public override void CalculateTotalCost()
        {
            base.utilityCosts = 0;
            base.totalCost = 0;

            CalculateUtilityCost(); // gets the utility costs
            if (fireExtinquisher)
                base.totalCost += 150m;

            base.totalCost += (numberShips * COST_PER_SHIP) + base.baseCost + base.UtilityCost; // add the base, utility and 
            // astromech costs to totalCost
        }

    }
}
