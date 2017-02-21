using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        // PRICES: If trash compactor, add 400m
        //         If vacuum, add 300m

        // Variables
        private bool trashCompactor;
        private bool vacuum;

        // Constructors
        public Janitor() { }

        public Janitor(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection,
            bool Arm, bool TrashCompactor, bool Vacuum) : base(Material, Model, Color, ToolBox, ComputerConnection,
                Arm)
        {
            trashCompactor = TrashCompactor;
            vacuum = Vacuum;
        }

        // Methods
        public override string ToString()
        {
            return "Variables";
        }

        public override void CalculateTotalCost()
        {

        }
    }
}
