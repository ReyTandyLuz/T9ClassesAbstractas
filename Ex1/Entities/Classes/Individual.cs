using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            float imposto = 0;

            if (AnualIncome < 2000)
                imposto = 0.15f;
            else
                imposto = 0.25f;

            if (HealthExpenditures == 0)
                return AnualIncome * imposto;

            return AnualIncome * imposto - HealthExpenditures * 0.5;
        }

        public override string ToString() => $"\n\t{Name}: $ {Tax():n2}";
    }
}
