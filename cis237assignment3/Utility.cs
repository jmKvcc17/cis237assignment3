using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        protected bool toolBox;
        protected bool computerConnection;
        protected bool arm;
        protected decimal utilityCosts;

        // Constructors
        public Utility() { }

        // utility inherits part of its constructor from the droid class
        public Utility(string Material, string Model, string Color, 
            bool ToolBox, bool ComputerConnection,
            bool Arm) : base(Material, Model, Color)
        {
            toolBox = ToolBox;
            computerConnection = ComputerConnection;
            arm = Arm;
        }

        // Properties
        public decimal UtilityCost
        {
            get { return utilityCosts; }
            set { utilityCosts = value; }
        }

        // Methods
        // Print out the utility droid information
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tool Box: " +
                toolBox.ToString() + Environment.NewLine + "Computer Connection: "
                 + computerConnection.ToString() + Environment.NewLine +
                 "Arm: " + arm.ToString();
        }

        public override void CalculateTotalCost()
        {
            utilityCosts = 0;
            base.totalCost = 0;
            CalculateUtilityCost();
            
            base.totalCost += base.baseCost + utilityCosts;
        }

        // Adds up all the selected utility specific costs, allows 
        // child classes to use this data as well
        protected void CalculateUtilityCost()
        {
            if (toolBox)
                utilityCosts += 50m;
            if (computerConnection)
                utilityCosts += 70m;
            if (arm)
                utilityCosts += 80m;
        }
    }
}
