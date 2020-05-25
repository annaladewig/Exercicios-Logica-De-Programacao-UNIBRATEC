using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício28_CasasPopulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            const double verbaTotal = 100000000;
            const double custoPorCasaEmSalarioMinimo = 150;
            double valorSalarioMinimo, qtdCasas, saldoDaVerba, valorCasa;
            
            //Entrada
            Console.Write("Qual o valor do salário mínimo? R$ ");
            valorSalarioMinimo = Convert.ToDouble(Console.ReadLine());

            //Procesamento
            valorCasa = custoPorCasaEmSalarioMinimo * valorSalarioMinimo;
            saldoDaVerba = verbaTotal % valorCasa;
            qtdCasas = (verbaTotal - saldoDaVerba) / valorCasa;
            
            //Saídas
            Console.WriteLine("A quantidade total de casas que podem ser construídas é de {0:F0}.", qtdCasas);
            Console.WriteLine("O saldo da verba será de R$ {0:F}.", saldoDaVerba);
            Console.ReadKey();
        }
    }
}
