﻿using System;
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
            return base.ToString() + "Trash Compactor: " + trashCompactor.ToString() + Environment.NewLine + 
                 "Vacuum: " + vacuum.ToString() + Environment.NewLine + Environment.NewLine;
        }

        public override void CalculateTotalCost()
        {
            base.UtilityCost = 0;
            base.totalCost = 0;

            CalculateUtilityCost();

            if (trashCompactor)
                base.totalCost += 100m;
            if (vacuum)
                base.totalCost += 200m;

            base.totalCost += base.baseCost + base.UtilityCost;
        }
    }
}
