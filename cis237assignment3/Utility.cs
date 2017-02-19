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

        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection,
            bool Arm) : base(Material, Model, Color)
        {
            toolBox = ToolBox;
            computerConnection = ComputerConnection;
            arm = Arm;
        }

        // Methods
        public override string ToString()
        {
            return "Return variables";
        }

        public override decimal CalculateTotalCost()
        {
            return 0;
        }
    }
}
