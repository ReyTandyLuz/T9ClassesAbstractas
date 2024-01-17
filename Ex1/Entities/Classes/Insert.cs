using Ex1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal abstract class Insert
    {
        public static int Int(string enunciado)
        {
            while (true)
            {
                Console.Write(enunciado);
                if (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out int result) && result > 0)
                    return result;

                Console.WriteLine("\nQuantidade inválida!!!! Tente novamente");
            }
        }

        public static (string, double) TaxPayer()
        {
            string nome = String("\n\tQual é o nome?: ");
            double anualIncome = Double($"\n\tQuanto ganha {nome} ao ano?: ");

            return new(nome, anualIncome);
        }

        public static Individual Individual()
        {
            (string,double) taxPayer = TaxPayer();
            double healtExpenditures = Double($"\n\tQuanto forom os health expenditures de {taxPayer.Item1}?: ");

            return new(taxPayer.Item1, taxPayer.Item2, healtExpenditures);
        }

        public static Company Company()
        {
            (string, double) taxPayer = TaxPayer();
            int data = Int($"\n\tQuantos trabalhadores tem {taxPayer.Item1}?: ");

            return new(taxPayer.Item1, taxPayer.Item2, data);
        }

        public static double Double(string enunciado)
        {
            while (true)
            {
                Console.Write(enunciado);
                if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double result) && result >= 0)
                    return result;

                Console.WriteLine("\nNota inválida!!!! Tente novamente");
            }
        }

        public static TaxPayerStatus NivelProdutos(int numeroDeTaxPayer)
        {
            while (true)
            {
                string status = String("\nDe que nível é o taxPayer (Individual/Company)?: ");

                if (status.ToLower() == "individual")
                {
                    Console.WriteLine($"\nInformação do {numeroDeTaxPayer}º tax payer (individual):");
                    return TaxPayerStatus.Individual;
                }

                if (status.ToLower() == "company")
                {
                    Console.WriteLine($"\nInformação do {numeroDeTaxPayer}º tax payer (company):");
                    return TaxPayerStatus.Company;
                }

                Console.WriteLine("\nNivel inválido!!!! Tente novamente");
            }
        }

        public static string String(string enunciado)
        {
            string texto;

            while (true)
            {
                Console.Write(enunciado);
                texto = Console.ReadLine();

                if (!string.IsNullOrEmpty(texto))
                    return texto.Trim();

                Console.WriteLine("\n\tValor invalido!!!!!! Tente novamente");
            }
        }
    }
}
