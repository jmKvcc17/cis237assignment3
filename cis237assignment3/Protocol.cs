﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {

        // Backing fields
        private int numberLanguages;
        private const decimal COST_PER_LANGUAGE = 500m;

        // Constructors
        public Protocol() { }

        public Protocol(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            numberLanguages = NumberOfLanguages;
        }

        // Methods
        public override string ToString()
        {
            //CalculateTotalCost();
            return base.ToString() + Environment.NewLine +
                "Number of Languages: " + numberLanguages.ToString() + Environment.NewLine 
                + Environment.NewLine;
        }

        public override void CalculateTotalCost()
        {
            base.totalCost = 0;
            base.TotalCost = (numberLanguages * COST_PER_LANGUAGE) + base.baseCost;
        }
    }
}
