using Ex1.Entities.Classes;
using Ex1.Entities.Enums;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("\nBem-vindo à diretoria de impostos de maximinos");

int numeroTaxPayer = Insert.Int("\nQuantos tax payers vão pagar impostos: ");

int i = 0;
TaxPayerStatus taxPayerAtual;
List<TaxPayer> taxPayers = new(); 

while (i < numeroTaxPayer)
{
    i++;
    taxPayerAtual = Insert.NivelProdutos(i);

    if (taxPayerAtual is TaxPayerStatus.Company)
    {
        taxPayers.Add(Insert.Company());
        continue;
    }

    taxPayers.Add(Insert.Individual());

}

if (taxPayers.Count == 0)
{
    Console.WriteLine("\nVocê não insiriu nenhuma pessoa/companhia ._.");
    Console.WriteLine("\nObrigado por ter utilizado o programa :)");
    return;
}

string menssagem = taxPayers.Count == 1 ?
    $"\nFoi {taxPayers.Count} uma pessoa/companhia inserida:" :
    $"\nForom {taxPayers.Count} umas pessoa/companhia inseridas:";

Console.WriteLine(menssagem);

foreach (var payer in taxPayers)
    Console.WriteLine(payer.ToString());

Console.WriteLine("\nMuito obrigado por ter utilizado este programa (:");
