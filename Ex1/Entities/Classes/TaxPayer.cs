using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnualIncome { get; private set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
        public abstract override string ToString();
    }
}
