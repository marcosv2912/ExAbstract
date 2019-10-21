using System;
using System.Collections.Generic;
using System.Text;

namespace ExAbstract.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualincome, double healthexpenditures) : base(name, anualincome)
        {
            HealthExpenditures = healthexpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return ((AnualIncome * 0.15) - (HealthExpenditures * 0.5));
            }
            else
            {
                return ((AnualIncome * 0.25) - (HealthExpenditures * 0.5));
            }
        }
    }
}
