using System;
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
        private const decimal costPerLanguage = 500m;

        // Constructors
        public Protocol() { }

        public Protocol(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            numberLanguages = NumberOfLanguages;
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + // base.ToString() uses the base classes (Droid) version of ToString
                " ";
        }

        public override decimal CalculateTotalCost()
        {
            return 0;
        }
    }
}
