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
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tool Box: " +
                toolBox.ToString() + Environment.NewLine + "Computer Connection: "
                 + computerConnection.ToString() + Environment.NewLine +
                 "Arm: " + arm.ToString() + Environment.NewLine;
        }

        public override void CalculateTotalCost()
        {
            utilityCosts = 0;
            base.totalCost = 0;
            CalculateUtilityCost();
            

            base.totalCost += base.baseCost + utilityCosts;
        }

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
