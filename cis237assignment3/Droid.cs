using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid
    {
        // Backing Fields
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        // Constructors
        public Droid() {}

        public Droid (string Material, string Model, string Color)
        {
            material = Material;
            model = Model;
            color = Color;
        }

        // Methods
        public override string ToString()
        {
            return "Material: " + material + Environment.NewLine +
                   "Model: " + model + Environment.NewLine +
                   "Color: " + color + Environment.NewLine +
                   "Base Cost: " + baseCost.ToString("C") + Environment.NewLine +
                   "Total Cost: " + totalCost.ToString("C") + Environment.NewLine;
        }

        // Determines the baseCost based on material and type. *****
        public void CalculateBaseCost()
        {

        }

        // assigns baseCost to totalCost (Required by the interface)
        public void CalculateTotalCost()
        {

        }

    }
}
