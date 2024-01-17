using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            float imposto = 0;

            if (NumberOfEmployees < 14 + 1)
                imposto = 0.16f;
            else
                imposto = 0.14f;

            return AnualIncome * imposto;
        }

        public override string ToString() => $"\n\t{Name}: $ {Tax():n2}";
    }
}
