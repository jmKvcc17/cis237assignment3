using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid // Droid inherits from the IDroid interface
    {
        // Backing Fields
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        // Properties
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        // Constructors
        public Droid() {}

        // Constructor accepts material, model and color
        public Droid (string Material, string Model, string Color)
        {
            material = Material;
            model = Model;
            color = Color;
        }

        // Methods
        // overrides ToString, allows the droid information to print
        public override string ToString()
        {
            CalculateBaseCost(); // Finds the base cost
            CalculateTotalCost(); // Finds the total cost
            return "Model: " + model.ToUpper() + Environment.NewLine +
                   "Material: " + material.ToUpper() + Environment.NewLine +
                   "Color: " + color.ToUpper() + Environment.NewLine +
                   "Base Cost: " + baseCost.ToString("C") + Environment.NewLine +
                   "Total Cost: " + totalCost.ToString("C");
        }

        // Determines the baseCost based on material and type
        // and model
        public virtual void CalculateBaseCost()
        {
            baseCost = 0; // reset the baseCost for new droid
            baseCost += CalculateMaterialCost(material); // calculates the cost for material
            baseCost += CalculateColorCost(color); // calculates the cost for color

            // Determine the model used
            if (model == "Protocol")
                baseCost += 2000m;
            if (model == "Utility")
                baseCost += 2500m;
            if (model == "Astromech")
                baseCost += 3000m;
            if (model == "Janitor")
                baseCost += 3500m;
        }

        // Should be three colors: red, blue, green
        // returns price depending on color chosen
        public decimal CalculateColorCost(string color)
        {
            if (color == "red")
                return 50m;
            if (color == "blue")
                return 60m;
            if (color == "green")
                return 70m;
            return 0m;
        }

        // There are 3 materials: carbonite, tanium, quadranium
        public decimal CalculateMaterialCost(string material)
        {
            if (material == "carbonite")
                return 1000m;
            if (material == "tanium")
                return 2000m;
            if (material == "quadranium")
                return 3000m;
            return 0m;
        }

        // assigns baseCost to totalCost (Required by the interface)
        public abstract void CalculateTotalCost();
        
  
        

    }
}
