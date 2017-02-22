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

        // Methods
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Tool Box: " +
                toolBox.ToString() + Environment.NewLine + "Computer Connection: "
                 + computerConnection.ToString() + Environment.NewLine +
                 "Arm: " + arm.ToString();
        }

        public override void CalculateTotalCost()
        {
            if (toolBox)
                base.totalCost += 50m;
            if (computerConnection)
                base.totalCost += 70m;
            if (arm)
                base.totalCost += 80m;

            base.totalCost += base.baseCost;
        }
    }
}
